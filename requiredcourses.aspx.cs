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
    public partial class requiredcourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void backfromrcb(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //Create as new Connection
            SqlConnection conn = new SqlConnection(connStr);

            Response.Redirect("options.aspx");
        }

        protected void erc(object sender, EventArgs e)
        {
            try
            {
                if (semcoderc.Text == "")
                {
                    DataTable ddt = new DataTable();
                    GridViewrc.DataSource = ddt;
                    GridViewrc.DataBind();
                    Label name = new Label();
                    name.Text = "Please Fill The TextBox";
                    form1.Controls.Add(name);
                }
                else {
                    string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                    //Create as new Connection
                    SqlConnection conn = new SqlConnection(connStr);

                    int id = Int16.Parse((string)Session["studentid"]);
                    String semcode = semcoderc.Text;

                    SqlCommand requiredcourses = new SqlCommand("[Procedures_ViewRequiredCourses]", conn);
                    requiredcourses.CommandType = CommandType.StoredProcedure;
                    requiredcourses.Parameters.Add(new SqlParameter("@StudentID", id));
                    requiredcourses.Parameters.Add(new SqlParameter("@current_semester_code", semcode));

                    conn.Open();
                    SqlDataAdapter ad = new SqlDataAdapter(requiredcourses);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    GridViewrc.DataSource = dt;
                    GridViewrc.DataBind();
                    if (dt.Rows.Count == 0)
                    {
                        Label name = new Label();
                        name.Text = "Invalid Semester Code or No Required Courses In This Semester";
                        form1.Controls.Add(name);
                    }
                    conn.Close();
                }
                
            }

             catch(Exception ex){
                Label name = new Label();
                name.Text = "Invalid Semester Code or No Required Courses In This Semester";
                form1.Controls.Add(name);
            }
        }
    }
}