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
    public partial class optionalcourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void backfromocb(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //Create as new Connection
            SqlConnection conn = new SqlConnection(connStr);

            Response.Redirect("options.aspx");
        }

        protected void eoc(object sender, EventArgs e)
        {
            try
            {
                if (semcodeoc.Text == "")
                {
                    DataTable ddt = new DataTable();
                    GridViewoc.DataSource = ddt;
                    GridViewoc.DataBind();
                    Label name = new Label();
                    name.Text = "Please Fill The TextBox";
                    form1.Controls.Add(name);
                }
                else
                {
                    string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                    //Create as new Connection
                    SqlConnection conn = new SqlConnection(connStr);

                    int id = Int16.Parse((string)Session["studentid"]);
                    String semcode = semcodeoc.Text;

                    SqlCommand optionalcourses = new SqlCommand("[Procedures_ViewOptionalCourse]", conn);
                    optionalcourses.CommandType = CommandType.StoredProcedure;
                    optionalcourses.Parameters.Add(new SqlParameter("@StudentID", id));
                    optionalcourses.Parameters.Add(new SqlParameter("@current_semester_code", semcode));

                    conn.Open();
                    SqlDataAdapter ad = new SqlDataAdapter(optionalcourses);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    GridViewoc.DataSource = dt;
                    GridViewoc.DataBind();
                    if(dt.Rows.Count==0)
                    {
                        Label name = new Label();
                        name.Text = "Invalid Semester Code or No Optional Courses In This Semester";
                        form1.Controls.Add(name);
                    }
                    conn.Close();
                }
                
            }

            catch(Exception ex){
                Label name = new Label();
                name.Text = "Invalid Semester Code or No Optional Courses In This Semester";
                form1.Controls.Add(name);
            }
        }
    }
}