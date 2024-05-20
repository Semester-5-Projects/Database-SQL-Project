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
    public partial class students_page : System.Web.UI.Page
    {
        protected void bac(object sender, EventArgs e)
        {
            Response.Redirect("admin_page.aspx");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            SqlCommand students = new SqlCommand("AdminListStudentsWithAdvisors", conn);
            students.CommandType = CommandType.StoredProcedure;

            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(students);
            DataTable st = new DataTable();
            adapter.Fill(st);
            GridView1.DataSource = st;
            GridView1.DataBind();
            conn.Close();
            

        }
    }
}