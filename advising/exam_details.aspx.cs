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
    public partial class exam_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                String connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                //create a new connection
                SqlConnection conn = new SqlConnection(connstr);

                SqlCommand exam_details_pageload = new SqlCommand("select * from Courses_MakeupExams", conn);
                exam_details_pageload.CommandType = CommandType.Text;

                conn.Open();
                SqlDataReader reader = exam_details_pageload.ExecuteReader();
                DataTable r = new DataTable();
                r.Load(reader);
                GridView2.DataSource = r;
                GridView2.DataBind();
                if (r.Rows.Count == 0)
                {
                    Label name = new Label();
                    name.Text = "no exams to display";
                    form1.Controls.Add(name);
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                Response.Write("No Exams To View!");
                Response.Write(", Try Again!");
            }

        }

        protected void exam_details_back_Click(object sender, EventArgs e)
        {
            String connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connstr);
            Response.Redirect("student2.aspx");
        }
    }
}