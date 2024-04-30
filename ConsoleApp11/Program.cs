using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source =LAPTOP-45N6M36C\\SQLEXPRESS; database = practice; Integrated Security=SSPI;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = " insert into temp1 values('TextBox1','TextBox2')";
            con.Open();

            SqlDataReader dr1 = cmd.ExecuteReader();
            dr1.Read();
        
        }
    }
}
