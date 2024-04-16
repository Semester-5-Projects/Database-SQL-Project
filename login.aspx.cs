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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void slogin(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                //Create as new Connection
                SqlConnection conn = new SqlConnection(connStr);

                if (userid.Text == "" | password.Text == "")
                {
                   r.Text="Please Enter Details In The Textboxes";
                }
                else
                {
                    Session["studentid"] = userid.Text;
                    int idd = Int16.Parse(userid.Text);
                    String pass = password.Text;

                    SqlCommand slog = new SqlCommand("select dbo.[FN_StudentLogin](@Student_id , @password )", conn);
                    slog.Parameters.Add(new SqlParameter("@Student_id", idd));
                    slog.Parameters.Add(new SqlParameter("@password", pass));
                    // slog.CommandType = CommandType.Text;


                    conn.Open();
                    object bit = slog.ExecuteScalar();
                    conn.Close();

                    if (Convert.ToInt32(bit) == 0)
                    {
                        r.Text = "Invalid Login";
                    }
                    else
                    {
                        Response.Redirect("options.aspx");
                    }
                }
            }
            catch(Exception ex)
            {
                r.Text = "ID Should Be An Integer Value";
            }
               
          

        }

        protected void studentregistration(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //Create as new Connection
            SqlConnection conn = new SqlConnection(connStr);
            Response.Redirect("studentregister.aspx");

        }

        protected void backfromloginb(object sender, EventArgs e)
        {
            Response.Redirect("choose.aspx");
        }
    }
}