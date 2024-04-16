using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace advising
{
    public partial class delete_course : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void back(object sender, EventArgs e)
        {
            Response.Redirect("main.aspx");
        }
        protected void Web (object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand new_course = new SqlCommand("Procedures_AdminDeleteCourse", conn);
            new_course.CommandType = CommandType.StoredProcedure;
            

            byte[] g = Encoding.ASCII.GetBytes(course.Text);
            for (int j = 0; j < g.Length; j++)
            {

                if (g[j] < 48 || g[j] > 57)
                {
                    Label1.Text= "Sorry,Wrong Advisor  <br/> Try Again!";
                    
                    return;

                }
            }
            if (course.Text == "")
            {
                Label1.Text = "Error! You have to insert a value the field";
                return;
            }
            else
            {
                int c = Int16.Parse(course.Text);
                new_course.Parameters.Add(new SqlParameter("@courseID", c));
                conn.Open();
                new_course.ExecuteNonQuery();
                Response.Redirect("confirm.aspx");
                conn.Close();
            }

        }
    }
}
