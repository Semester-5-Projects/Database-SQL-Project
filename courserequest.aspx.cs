using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class courserequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void backfromstudregb(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //Create as new Connection
            SqlConnection conn = new SqlConnection(connStr);

            Response.Redirect("options.aspx");
        }

        protected void sendcrb(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                //Create as new Connection
                SqlConnection conn = new SqlConnection(connStr);
                if (commentcreq.Text == "" || courseidcreq.Text == "")
                {
                    scr.Text = "Please Enter Details In Textboxes";
                }



                else
                {
                    int id = Int16.Parse((string)Session["studentid"]);
                    String type = "course";
                    int courseid = Int16.Parse(courseidcreq.Text);
                    String comment = commentcreq.Text;


                    SqlCommand sendcreq = new SqlCommand("[Procedures_StudentSendingCourseRequest]", conn);
                    sendcreq.CommandType = CommandType.StoredProcedure;
                    sendcreq.Parameters.Add(new SqlParameter("@courseID", courseid));
                    sendcreq.Parameters.Add(new SqlParameter("@StudentID", id));
                    sendcreq.Parameters.Add(new SqlParameter("@type", type));
                    sendcreq.Parameters.Add(new SqlParameter("@comment", comment));

                    courseidcreq.Text = String.Empty;
                    commentcreq.Text = String.Empty;


                    conn.Open();
                    int r = sendcreq.ExecuteNonQuery();
                    if (r > 0)
                    {
                        scr.Text = "Course Request Sent Successfully";
                    }

                    else
                    {
                        scr.Text = "Course ID not found";
                    }
                    conn.Close();

                   
                }
            }

            catch (Exception ex)
            {
                scr.Text = "Course ID should be an Integer Value";
            }
            
            
        }
    }
}