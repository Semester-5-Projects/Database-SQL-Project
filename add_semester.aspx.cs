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
    public partial class add_semester : System.Web.UI.Page
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
            try { 
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand new_sem = new SqlCommand("AdminAddingSemester", conn);
            new_sem.CommandType = CommandType.StoredProcedure;
            string start_date = start.Text;
            string end_date = end.Text;
            string sem_code = code.Text;
            if (start_date == "" || end_date == "" || sem_code == "")
            {
                Label1.Text = "Error! <br/> You have to insert a value into all fields";
                return;
            }
            if (sem_code[0].Equals('S') || sem_code[0].Equals('s'))
            {
                if (sem_code.Length == 3)
                {
                    byte[] d = Encoding.ASCII.GetBytes(code.Text);
                    for (int i = 1; i < 3; i++)
                    {

                        if (d[i] < 48 || d[i] > 57)
                        {
                            Label1.Text = "Error! <br/> Wrong Semester Code Format <br/> Try Again!";
                            return;

                        }
                    }
                }
                else
                {
                    byte[] d = Encoding.ASCII.GetBytes(code.Text);
                    for (int i = 1; i < 3; i++)
                    {

                        if (d[i] < 48 || d[i] > 57)
                        {
                            Label1.Text = "Error! <br/> Wrong Semester Code Format <br/> Try Again!";
                            return;

                        }
                        if (!code.Text[3].Equals('R') && !(code.Text[4].Equals('1') || code.Text[4].Equals('2')))
                        {
                            Label1.Text = "Error! <br/> Wrong Semester Code Format <br/> Try Again!";
                            return;
                        }
                    }

                }
            }
            else
            {
                if (sem_code[0].Equals('W') || sem_code[0].Equals('w'))
                {
                    byte[] d = Encoding.ASCII.GetBytes(code.Text);
                    for (int i = 1; i < d.Length; i++)
                    {

                        if (d[i] < 48 || d[i] > 57)
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

            
            
                new_sem.Parameters.Add(new SqlParameter("@start_date", start_date));
                new_sem.Parameters.Add(new SqlParameter("@end_date", end_date));
                new_sem.Parameters.Add(new SqlParameter("@semester_code", sem_code));
                
                    conn.Open();
                    new_sem.ExecuteNonQuery();
                    Response.Redirect("confirm_page.aspx");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Label1.Text = "Error! <br/> There is already a semester with this Code <br/>   Please enter a different semester code " +
                        "<br/> or the date is in the wrong format";
                }
            


        }

        
    }
}