using Microsoft.SqlServer.Server;
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
    public partial class availablecourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            
        }

        protected void backfromacb(object sender, EventArgs e)
        {
            Response.Redirect("options.aspx");
        }

        protected void gotoac2(object sender, EventArgs e)
        {
            try
            {
                if (acsemcode.Text == "")
                {
                    DataTable ddt = new DataTable();
                    GridViewac.DataSource = ddt;
                    GridViewac.DataBind();
                    Label name = new Label();
                    name.Text = "Please Fill The TextBox";
                    form1.Controls.Add(name);
                }
                else {
                    string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                    //Create as new Connection
                    SqlConnection conn = new SqlConnection(connStr);

                    String semcode = acsemcode.Text;

                    SqlCommand avai = new SqlCommand("select * from dbo.[FN_SemsterAvailableCourses](@semstercode)", conn);
                    avai.Parameters.Add(new SqlParameter("@semstercode", semcode));

                    conn.Open();
                    SqlDataReader ad = avai.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(ad);
                    GridViewac.DataSource = dt;
                    GridViewac.DataBind();
                    if (dt.Rows.Count == 0)
                    {
                        Label name = new Label();
                        name.Text = "Invalid Semester Code or No Available Courses In This Semester";
                        form1.Controls.Add(name);
                    }
                    conn.Close();
                }
                
                
            }
            catch(Exception ex)
            {
                Label name = new Label();
                name.Text = "Invalid Semester Code or No Available Courses In This Semester";
                form1.Controls.Add(name);
            }
        }
    }
}