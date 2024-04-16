using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace student2_advising
{
    public partial class view_all_prereq : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                String connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                //create a new connection
                SqlConnection conn = new SqlConnection(connstr);

                SqlCommand req = new SqlCommand("select * from view_Course_prerequisites", conn);
                req.CommandType = CommandType.Text;

                conn.Open();
                SqlDataReader reader = req.ExecuteReader();
                DataTable r = new DataTable();
                r.Load(reader);
                GridView1.DataSource = r;
                GridView1.DataBind();
                if (r.Rows.Count == 0)
                {
                    Label name = new Label();
                    name.Text = "no details to display";
                    form1.Controls.Add(name);
                }
                conn.Close();

            }
            catch(Exception ex)
            {
                Response.Write("No Details to View!");
                DataTable dt = new DataTable();
                GridView1.DataSource = dt;
                GridView1.DataBind();


            }




        }
        protected void prereq_back_Click(object sender, EventArgs e)
        {
            String connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connstr);
            Response.Redirect("student2.aspx");
        }
    }
}