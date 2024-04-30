using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IdentityModel.Selectors;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //label code connecting it with button
       
        protected void Visibility(object sender, EventArgs e)
        {
            Label1.Visible = !Label1.Visible;
            GridView1.Visible = !GridView1.Visible;
        }

     
    
    }
}