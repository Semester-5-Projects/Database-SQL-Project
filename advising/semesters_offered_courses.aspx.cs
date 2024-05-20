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
    public partial class semesters_offered_courses : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            SqlCommand req = new SqlCommand("select * from Semster_offered_Courses", conn);
            req.CommandType = CommandType.Text;

            conn.Open();
            SqlDataReader reader = req.ExecuteReader();
            DataTable s = new DataTable();
            s.Load(reader);
            GridView1.DataSource = s;
            GridView1.DataBind();
            conn.Close();
        }
        protected void web(object sender, EventArgs e)
        {
            Response.Redirect("main.aspx");
        }
    }
}