using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace ADVISINGG
{
    public partial class link_stu_adv : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected void bacc(object sender, EventArgs e)
        {
            Response.Redirect("admin_page.aspx");


        }

        protected void Play (object sender, EventArgs e)
        {
            try
            {
                string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            SqlCommand link = new SqlCommand("Procedures_AdminLinkStudentToAdvisor", conn);
            
            link.CommandType = CommandType.StoredProcedure;

            byte[] d = Encoding.ASCII.GetBytes(student.Text);
            for (int j = 0; j < d.Length; j++)
            {

                if (d[j] < 48 || d[j] > 57)
                {
                        Label1.Text = "Error! <br/> Wrong Student ID <br/> Try Again! ";
                        return;

                }
            }

            byte[] g = Encoding.ASCII.GetBytes(advisor.Text);
            for (int j = 0; j < g.Length; j++)
            {

                if (g[j] < 48 || g[j] > 57)
                {
                        Label1.Text = "Error! <br/> Wrong Advisor ID <br/> Try Again! ";
                        return;

                }
            }
            if (advisor.Text == "" || student.Text == "")
            {
                    Label1.Text = "Error! You have to insert a value into all fields";
                return;
            }

            int s = Int16.Parse(student.Text);
            int a = Int16.Parse(advisor.Text);

            
            
                link.Parameters.Add(new SqlParameter("@studentID", s));
                link.Parameters.Add(new SqlParameter("@advisorID", a));

                
                    link.ExecuteNonQuery();
                    Response.Redirect("confirm_page.aspx");
                    conn.Close();
                }
                catch(Exception ex)
                {
                Label1.Text = "Error! Instructor Not Found";
            }
            


        }

    }
}