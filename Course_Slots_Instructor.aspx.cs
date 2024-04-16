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
    public partial class Course_Slots_Instructor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                String connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                //create a new connection
                SqlConnection conn = new SqlConnection(connstr);

                SqlCommand Course_Slots_Instructor_pageload = new SqlCommand("select * from Courses_Slots_Instructor", conn);
                Course_Slots_Instructor_pageload.CommandType = CommandType.Text;

                conn.Open();
                SqlDataReader reader = Course_Slots_Instructor_pageload.ExecuteReader();
                DataTable r = new DataTable();
                r.Load(reader);
                GridView3.DataSource = r;
                GridView3.DataBind();
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
                Response.Write("No Details To View!");
                Response.Write(", Try Again!");
               
            }
        }
        protected void csi_back_Click(object sender, EventArgs e)
        {
            String connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connstr);
            Response.Redirect("student2.aspx");
        }
    }
}