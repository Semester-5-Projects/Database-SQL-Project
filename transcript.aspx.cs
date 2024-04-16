using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace advising
{
    public partial class transcript : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            SqlCommand req = new SqlCommand("select * from Students_Courses_transcript", conn);
            req.CommandType = CommandType.Text;

            conn.Open();
            SqlDataReader reader = req.ExecuteReader();
            DataTable r = new DataTable();
            r.Load(reader);
            GridView1.DataSource = r;
            GridView1.DataBind();
            conn.Close();
        }
        protected void web(object sender, EventArgs e)
        {
            Response.Redirect("main.aspx");
        }
    }
}