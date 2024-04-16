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
    public partial class advisors_page : System.Web.UI.Page
    {
        protected void bac(object sender, EventArgs e)
        {
            Response.Redirect("admin_page.aspx");
        }
            protected void Page_Load(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            SqlCommand advisors = new SqlCommand("Procedures_AdminListAdvisors", conn);
            advisors.CommandType = CommandType.StoredProcedure;

            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(advisors);
            DataTable ad = new DataTable();
            adapter.Fill(ad);
            advisorsTable.DataSource = ad;
            advisorsTable.DataBind();
            conn.Close();



        }
    }
}