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
    public partial class requests : System.Web.UI.Page
    {
        protected void bac(object sender, EventArgs e)
        {
            Response.Redirect("admin_page.aspx");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            SqlCommand req = new SqlCommand("select * from all_Pending_Requests", conn);
            req.CommandType = CommandType.Text;

            conn.Open();
            SqlDataReader reader = req.ExecuteReader();
            DataTable r = new DataTable();
            r.Load(reader);
            GridView1.DataSource = r;
            GridView1.DataBind();
            conn.Close();

        }
    }
}