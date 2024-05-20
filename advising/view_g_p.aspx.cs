using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace student2_advising
{
    public partial class view_g_p : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                String connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                //create a new connection
                SqlConnection conn = new SqlConnection(connstr);

                int sid = Int16.Parse((string)Session["studentid"]);
               

                SqlCommand gp = new SqlCommand("select * from dbo.[FN_StudentViewGP](@student_ID)", conn);
                gp.Parameters.Add(new SqlParameter("@student_ID", sid));

                conn.Open();
                SqlDataReader x = gp.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(x);
                GridView4.DataSource = dt;
                GridView4.DataBind();
                if (dt.Rows.Count == 0)
                {
                    Label name = new Label();
                    name.Text = "no details to display";
                    form1.Controls.Add(name);
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                Response.Write("No Details to View!");
                DataTable dt = new DataTable();
                GridView4.DataSource = dt;
                GridView4.DataBind();

            }

        }

        protected void gp_back_Click(object sender, EventArgs e)
        {
            String connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connstr);
            Response.Redirect("student2.aspx");


        }
    }
}