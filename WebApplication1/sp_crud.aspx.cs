using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class sp_crud : System.Web.UI.Page
        //normal insert update without sp
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source= LAPTOP-45N6M36C\\SQLEXPRESS; database = practice; Integrated Security=SSPI;"))
            {

               
                SqlCommand cmd = new SqlCommand("insert into temp1 values('" + TextBox1.Text + "','" + int.Parse(TextBox2.Text) + "')",con);
               
                con.Open();

                //  SqlDataReader dr = cmd.ExecuteReader();


                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Response.Write("User inserted successfully!");
                }
                else
                {
                   Response.Write("An error occurred during insertion.");
                }
                //  GridView1.DataSource = dr;
                //  GridView1.DataBind();

            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source= LAPTOP-45N6M36C\\SQLEXPRESS; database = practice; Integrated Security=SSPI;"))
            {


                SqlCommand cmd = new SqlCommand(("update temp1 set age = '" + int.Parse(TextBox3.Text) + "' where id='" + int.Parse(TextBox4.Text) + "' "), con);
                con.Open();

                //  SqlDataReader dr = cmd.ExecuteReader();


                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Response.Write("User updated successfully!");
                }
                else
                {
                    Response.Write("An error occurred during updation.");
                }
            }
        }
    }
}