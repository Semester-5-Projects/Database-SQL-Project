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
    public partial class semester_courses_page : System.Web.UI.Page
    {
        protected void bac(object sender, EventArgs e)
        {
            Response.Redirect("admin_page.aspx");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            SqlCommand sem = new SqlCommand("select* from Semster_offered_Courses", conn);
            sem.CommandType = CommandType.Text;

            conn.Open();
            SqlDataReader reader = sem.ExecuteReader();
            DataTable s = new DataTable();
            s.Load(reader);
            GridView1.DataSource = s;
            GridView1.DataBind();
            conn.Close();
            
        }
    }
}