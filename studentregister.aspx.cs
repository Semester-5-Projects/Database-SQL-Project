using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class studentregister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void newregistrations(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                //Create as new Connection
                SqlConnection conn = new SqlConnection(connStr);

                if (fname.Text=="" || lname.Text=="" || rpass.Text==""|| faculty.Text==""|| email.Text==""|| major.Text==""|| semint.Text=="")
                {
                    idis.Text = "Please Enter Details In The Textboxes";
                }

                else
                {
                    String firstname = fname.Text;
                    String lastname = lname.Text;
                    String pass = rpass.Text;
                    String f = faculty.Text;
                    String em = email.Text;
                    String m = major.Text;
                    int sem = Int16.Parse(semint.Text);


                    SqlCommand sreg = new SqlCommand("[Procedures_StudentRegistration]", conn);
                    sreg.CommandType = CommandType.StoredProcedure;
                    sreg.Parameters.Add(new SqlParameter("@first_name", firstname));
                    sreg.Parameters.Add(new SqlParameter("@last_name", lastname));
                    sreg.Parameters.Add(new SqlParameter("@password", pass));
                    sreg.Parameters.Add(new SqlParameter("@faculty", f));
                    sreg.Parameters.Add(new SqlParameter("@email", em));
                    sreg.Parameters.Add(new SqlParameter("@major", m));
                    sreg.Parameters.Add(new SqlParameter("@Semester", sem));


                    SqlParameter id = sreg.Parameters.Add("@Student_id", SqlDbType.Int);
                    id.Direction = ParameterDirection.Output;

                    conn.Open();
                    sreg.ExecuteNonQuery();
                    conn.Close();

                    successr.Text = "Registered Successfully";
                    idis.Text = "Your ID is " + id.Value;
                    goback.Text = "Press BACK To Login";
                }
            }
            catch(Exception ex)
            {
                idis.Text = "Semester Should Be An Integer Value";
            }
        }

        protected void backfromregb(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //Create as new Connection
            SqlConnection conn = new SqlConnection(connStr);

            Response.Redirect("login.aspx");
        }
    }
}