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
    public partial class link_stu_course_ins : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void bacc(object sender, EventArgs e)
        {
            Response.Redirect("admin_page.aspx");


        }
        protected void Web(object sender, EventArgs e)
        {
            try { 
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand link = new SqlCommand("Procedures_AdminLinkStudent", conn);
            link.CommandType = CommandType.StoredProcedure;
                if (course.Text == "" || instructor.Text == "" || student.Text == "" || semester.Text == "")
                {
                    Label1.Text="Error! You have to insert a value into all fields";
                    return;
                }

                byte[] g = Encoding.ASCII.GetBytes(student.Text);
            for (int j = 0; j < g.Length; j++)
            {

                if (g[j] < 48 || g[j] > 57)
                {
                        Label1.Text = "Error! <br/> Wrong Student ID <br/> Try Again! ";
                        return;

                }
            }

            byte[] d = Encoding.ASCII.GetBytes(instructor.Text);
            for (int j = 0; j < d.Length; j++)
            {

                if (d[j] < 48 || d[j] > 57)
                {
                        Label1.Text = "Error! <br/> Wrong Instructor ID <br/> Try Again! ";
                        return;

                }
            }

            byte[] k = Encoding.ASCII.GetBytes(course.Text);
            for (int j = 0; j < k.Length; j++)
            {

                if (k[j] < 48 || k[j] > 57)
                {
                        Label1.Text = "Error! <br/> Wrong Course ID <br/> Try Again! ";
                        return;

                }
            }


            int s = Int16.Parse(student.Text);
            int c = Int16.Parse(course.Text);
            int ins = Int16.Parse(instructor.Text);
            String sc = semester.Text;

            if (semester.Text[0].Equals('S') || semester.Text[0].Equals('s'))
            {
                if (semester.Text.Length == 3)
                {
                    byte[] h = Encoding.ASCII.GetBytes(semester.Text);
                    for (int i = 1; i < 3; i++)
                    {

                        if (h[i] < 48 || h[i] > 57)
                        {
                            Label1.Text="Error! <br/> Wrong Semester Code Format <br/> Try Again!";
                            return;

                        }
                    }
                }
                else
                {
                    byte[] dm = Encoding.ASCII.GetBytes(semester.Text);
                    for (int i = 1; i < 3; i++)
                    {

                        if (dm[i] < 48 || dm[i] > 57)
                        {
                                Label1.Text = "Error! <br/> Wrong Semester Code Format <br/> Try Again!";
                            return;

                        }
                        if (!semester.Text[3].Equals('R') && !(semester.Text[4].Equals('1') || semester.Text[4].Equals('2')))
                        {
                                Label1.Text = "Error! <br/> Wrong Semester Code Format <br/> Try Again!";
                            return;
                        }
                    }

                }
            }
            else
            {
                if (semester.Text[0].Equals('W') || semester.Text[0].Equals('w'))
                {
                    byte[] p = Encoding.ASCII.GetBytes(semester.Text);
                    for (int i = 1; i < p.Length; i++)
                    {

                        if (p[i] < 48 || p[i] > 57)
                        {
                                Label1.Text = "Error! <br/> Wrong Semester Code Format <br/> Try Again!";
                            return;

                        }
                    }
                }

                else
                {

                        Label1.Text = "Error! <br/> Wrong Semester Code Format <br/> Try Again!";
                    return;
                }
            }

            
            
                link.Parameters.Add(new SqlParameter("@cours_id", c));
                link.Parameters.Add(new SqlParameter("@instructor_id", ins));
                link.Parameters.Add(new SqlParameter("@studentID", s));
                link.Parameters.Add(new SqlParameter("@semester_code", sc));
                
                    conn.Open();
                    link.ExecuteNonQuery();
                    Response.Redirect("confirm_page.aspx");
                    conn.Close();
                }
                catch(Exception ex)
                {
                        Label1.Text = "Error! <br/>" +
                    "course/instructor/student Not Found <br/> or " +
                    "these are already linked,choose a different course/instructor/semester";
                }
            


        }
        
        }

    }
