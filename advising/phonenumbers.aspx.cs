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
    public partial class phonenumbers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void backfromphonenum(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //Create as new Connection
            SqlConnection conn = new SqlConnection(connStr);

            Response.Redirect("options.aspx");
        }

        protected void addbutton(object sender, EventArgs e)
        {
            try {
                
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                //Create as new Connection
                SqlConnection conn = new SqlConnection(connStr);

                if (addphone.Text == "")
                {
                    resp.Text = "Please Enter A Phone Number In The Textbox";
                }
                else {
                    int id = Int16.Parse((string)Session["studentid"]);
                    String phonenumber = addphone.Text;

                    SqlCommand addphonenumproc = new SqlCommand("[Procedures_StudentaddMobile]", conn);
                    addphonenumproc.CommandType = CommandType.StoredProcedure;
                    addphonenumproc.Parameters.Add(new SqlParameter("@StudentID", id));
                    addphonenumproc.Parameters.Add(new SqlParameter("@mobile_number", phonenumber));

                    addphone.Text = String.Empty;

                    conn.Open();
                    addphonenumproc.ExecuteNonQuery();
                    resp.Text = "Phone Number Added Successfully";
                    conn.Close();
                }
                
               }
            catch(Exception ex)
            {
                resp.Text = "Phone Number Was Previously Saved, Try a Different One";
            }
            {

            }

            

        }
    }
}