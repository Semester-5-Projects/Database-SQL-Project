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
    public partial class add_course : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void back(object sender, EventArgs e)
        {
            Response.Redirect("admin_page.aspx");

        }


        protected void web(object sender, EventArgs e)
        {
            try
            {

                string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connstr);
                SqlCommand new_course = new SqlCommand("Procedures_AdminAddingCourse", conn);
                new_course.CommandType = CommandType.StoredProcedure;
                if (major.Text == "" || name.Text == "" || offered.Text == "" || semester.Text == "" || hours.Text == "")
                {
                    Label1.Text = "Error! You have to insert a value into all fields";
                    return;
                }



                byte[] d = Encoding.ASCII.GetBytes(hours.Text);
                for (int i = 0; i < d.Length; i++)
                {

                    if (d[i] < 48 || d[i] > 57)
                    {
                        Label1.Text = "Error! <br/> Hours have to be a number <br/> Try Again!";
                        return;

                    }
                }

                byte[] j = Encoding.ASCII.GetBytes(semester.Text);
                for (int i = 0; i < j.Length; i++)
                {

                    if (j[i] < 48 || j[i] > 57)
                    {
                        Label1.Text = "Error! <br/> Semester has to be a number <br/> Try Again!";
                        return;

                    }
                }
                byte[] k = Encoding.ASCII.GetBytes(offered.Text);
                for (int i = 0; i < k.Length; i++)
                {

                    if (k[i] < 48 || k[i] > 57)
                    {
                        Label1.Text = "Error! <br/> Offered or not has to be a number <br/> Try Again!";
                        return;

                    }
                }


                string m = major.Text;
                string n = name.Text;
                int o = Int16.Parse(offered.Text);
                int s = Int16.Parse(semester.Text);
                int h = Int16.Parse(hours.Text);

                if (offered.Text == "1" || offered.Text == "0")
                {
                    new_course.Parameters.Add(new SqlParameter("@major", m));
                    new_course.Parameters.Add(new SqlParameter("@name", n));
                    new_course.Parameters.Add(new SqlParameter("@semester", s));
                    new_course.Parameters.Add(new SqlParameter("@credit_hours", h));
                    new_course.Parameters.Add(new SqlParameter("@is_offered", o));

                    conn.Open();
                    new_course.ExecuteNonQuery();
                    Response.Redirect("confirm_page.aspx");
                    conn.Close();
                }
                else
                {
                    Label1.Text = "Error! <br/> Wrong Value for Offered Bit <br/>Can only be 1 or 0 <br/> Try Again!";
                    return;
                }
            }catch (Exception ex)
            {
                Label1.Text = "Error! <br/> Wrong data format Try Again";


            }
            
                
               
            


        }

    }
    }
