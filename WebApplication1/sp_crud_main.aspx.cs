using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Azure;

namespace WebApplication1
{
    public partial class sp_crud_main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e) //insert 
        {
            SqlConnection conn = new SqlConnection("Data Source= LAPTOP-45N6M36C\\SQLEXPRESS; database = practice; Integrated Security=SSPI;");
            SqlCommand cmd = new SqlCommand("sp_insert",conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nam", TextBox1.Text);
            cmd.Parameters.AddWithValue("@email", TextBox2.Text);
            cmd.Parameters.AddWithValue("@mobile", int.Parse(TextBox3.Text));

            conn.Open();
            cmd.ExecuteNonQuery();           //asynchronous way while we are not returning any value
            Response.Write("value inserted");     

        }

        protected void Button2_Click(object sender, EventArgs e)  //update
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-45N6M36C\\SQLEXPRESS ;database=practice ;integrated security=SSPI;");
            SqlCommand cmd = new SqlCommand("sp_update",con);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id",int.Parse(TextBox4.Text));
            cmd.Parameters.AddWithValue("@up_nam", TextBox5.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("Value updated");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("Data Source=LAPTOP-45N6M36C\\SQLEXPRESS ;database=practice ;integrated security=SSPI;");
            SqlCommand cmd1 = new SqlCommand("sp_delete", con1);

            cmd1.CommandType = System.Data.CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@id",int.Parse(TextBox6.Text));

            con1.Open();
            cmd1.ExecuteNonQuery();
            Response.Write("record deleted");
        }
    }
}