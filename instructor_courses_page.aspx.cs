using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADVISINGG
{
    public partial class instructor_courses_page : System.Web.UI.Page
    {
        protected void bac(object sender, EventArgs e)
        {
            Response.Redirect("admin_page.aspx");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            SqlCommand ins = new SqlCommand("select * from Instructors_AssignedCourses", conn);
            ins.CommandType = CommandType.Text;

            
            SqlDataReader reader = ins.ExecuteReader();
            DataTable i = new DataTable();
            i.Load(reader);
            GridView1.DataSource = i;
            GridView1.DataBind();

            conn.Close();

        }
    }
}