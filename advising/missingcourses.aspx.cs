using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class missingcourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void backfrommsb(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //Create as new Connection
            SqlConnection conn = new SqlConnection(connStr);

            Response.Redirect("options.aspx");
        }

        protected void vmc(object sender, EventArgs e)
        {
            try
            {

                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                //Create as new Connection
                SqlConnection conn = new SqlConnection(connStr);

                int id = Int16.Parse((string)Session["studentid"]);

                SqlCommand missingcourses = new SqlCommand("[Procedures_ViewMS]", conn);
                missingcourses.CommandType = CommandType.StoredProcedure;
                missingcourses.Parameters.Add(new SqlParameter("@StudentID", id));

                conn.Open();
                SqlDataAdapter ad = new SqlDataAdapter(missingcourses);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                GridViewmc.DataSource = dt;
                GridViewmc.DataBind();
                if (dt.Rows.Count == 0)
                {
                    Label name = new Label();
                    name.Text = "No Missing Courses";
                    form1.Controls.Add(name);
                }
                conn.Close();
                
            }

            catch(Exception ex){
                Label name = new Label();
                name.Text = "No Missing Courses";
                form1.Controls.Add(name);
            }
        }
    }
}