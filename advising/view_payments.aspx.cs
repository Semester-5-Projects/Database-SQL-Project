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
    public partial class view_payments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            SqlCommand pay = new SqlCommand("select * from Student_Payment", conn);
            pay.CommandType = CommandType.Text;

            conn.Open();
            SqlDataReader reader = pay.ExecuteReader();
            DataTable p = new DataTable();
            p.Load(reader);
            GridView1.DataSource = p;
            GridView1.DataBind();
            conn.Close();
        }
        protected void web(object sender, EventArgs e)
        {
            Response.Redirect("main.aspx");
        }
    }
}