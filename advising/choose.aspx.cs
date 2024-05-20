using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class choose : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void studentlogin(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //Create as new Connection
            SqlConnection conn = new SqlConnection(connStr);
            Response.Redirect("login.aspx");
        }

        protected void advisorlogin(object sender, EventArgs e)
        {
            Response.Redirect("loginAdvisor.aspx");

        }

        protected void adminlogin(object sender, EventArgs e)
        {
            Response.Redirect("admin_login.aspx");
            
        }
    }
}