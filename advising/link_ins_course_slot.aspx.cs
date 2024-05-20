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

namespace ADVISINGG
{
    public partial class link_ins_course_slot : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Web(object sender, EventArgs e)
        {
            try { 
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand link = new SqlCommand("Procedures_AdminLinkInstructor", conn);
            link.CommandType = CommandType.StoredProcedure;
            byte[] d = Encoding.ASCII.GetBytes(course.Text);
            for (int j = 0; j < d.Length; j++)
            {

                if (d[j] < 48 || d[j] > 57)
                {
                    Label1.Text= "Error! <br/> Wrong Course ID <br/> Try Again! ";
                    
                    return;

                }
            }

            byte[] g = Encoding.ASCII.GetBytes(ins.Text);
            for (int j = 0; j < g.Length; j++)
            {

                if (g[j] < 48 || g[j] > 57)
                {
                        Label1.Text = "Error! <br/> Wrong Instructor ID <br/> Try Again! ";
                        return;

                }
            }

            byte[] h = Encoding.ASCII.GetBytes(slot.Text);
            for (int j = 0; j < h.Length; j++)
            {

                if (h[j] < 48 || h[j] > 57)
                {
                    Label1.Text = "Error! <br/> Wrong Slot <br/> Try Again! ";
                    
                    return;

                }
            }

            if (course.Text == "" || ins.Text == "" || slot.Text == "")
            {
                    Label1.Text = "Error! <br/> You have to insert a value into all fields";
                return;
            }

            int c = Int16.Parse(course.Text); 
            int i = Int16.Parse(ins.Text);
            int s = Int16.Parse(slot.Text);


            
           
                link.Parameters.Add(new SqlParameter("@cours_id", c));
                link.Parameters.Add(new SqlParameter("@instructor_id", i));
                link.Parameters.Add(new SqlParameter("@slot_id", s));
                
                    conn.Open();
                    link.ExecuteNonQuery();
                    Response.Redirect("confirm_page.aspx");
                    conn.Close();
                }
                catch (Exception ex)
                {
                Label1.Text = "Error! <br/> Course or Instructor Not Found";
                }
            








        }
        protected void bacc(object sender, EventArgs e)
        {
            Response.Redirect("admin_page.aspx");


        }
    }
}