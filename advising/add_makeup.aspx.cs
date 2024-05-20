using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Text;

namespace advising
{
    public partial class add_makeup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }
        protected void back(object sender, EventArgs e)
        {
            Response.Redirect("main.aspx");
        }

        protected void web(object sender, EventArgs e)
        {
            try { 
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand new_course = new SqlCommand("Procedures_AdminAddExam", conn);
            new_course.CommandType = CommandType.StoredProcedure;
            string t = type.Text;
            string d = data.Text;
            string c = course.Text;
            byte[] g = Encoding.ASCII.GetBytes(course.Text);
            for (int j = 0; j < g.Length; j++)
            {

                if (g[j] < 48 || g[j] > 57)
                {
                    Label1.Text = "Sorry,Wrong Course <br/> Try Again!";
                   
                    return;

                }
            }
            if (t == "" || d == "" || c == "" )
            {
                Label1.Text = "Error! You have to insert a value into all fields";
                return;
            }
            else
            {
                new_course.Parameters.Add(new SqlParameter("@Type", t));
                new_course.Parameters.Add(new SqlParameter("@date", d));
                new_course.Parameters.Add(new SqlParameter("@courseID", c));
                
                    conn.Open();
                    new_course.ExecuteNonQuery();
                    Response.Redirect("confirm.aspx");
                    conn.Close();
                }
               
            }
            catch (Exception ex)
            {
                Label1.Text = "Error! <br/> Wrong date format OR <br/> Course Not Found ";
            }
        }
    }
}