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
    public partial class credithourrequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void backfromchreqb(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //Create as new Connection
            SqlConnection conn = new SqlConnection(connStr);

            Response.Redirect("options.aspx");
        }

        protected void sendchreqb(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                //Create as new Connection
                SqlConnection conn = new SqlConnection(connStr);

                if (cht.Text == "" || commentchreq.Text == "")
                {
                    schr.Text = "Please Enter Details In Textboxes";
                }

                else {
                    int id = Int16.Parse((string)Session["studentid"]);
                    String type = "credit_hours";
                    int ch = Int16.Parse(cht.Text);
                    String comment = commentchreq.Text;

                    SqlCommand sendcreq = new SqlCommand("[Procedures_StudentSendingCHRequest]", conn);
                    sendcreq.CommandType = CommandType.StoredProcedure;
                    sendcreq.Parameters.Add(new SqlParameter("@credit_hours", ch));
                    sendcreq.Parameters.Add(new SqlParameter("@StudentID", id));
                    sendcreq.Parameters.Add(new SqlParameter("@type", type));
                    sendcreq.Parameters.Add(new SqlParameter("@comment", comment));

                    commentchreq.Text = String.Empty;
                    cht.Text = String.Empty;

                    conn.Open();
                    int r=sendcreq.ExecuteNonQuery();
                    if (r > 0)
                    {
                        schr.Text = "Credit Hours Request Sent Successfully";
                    }

                    else
                    {
                        schr.Text = "Invalid";
                    }
                    conn.Close();

                   
                    
                }
                
            }
            catch(Exception ex)
            {
                schr.Text = "Credit Hours should be an Integer Value";
            }
        }
    }
}