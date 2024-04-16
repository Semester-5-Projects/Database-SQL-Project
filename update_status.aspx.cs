using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Text;
using System.Reflection.Emit;

namespace advising
{
    public partial class update_status : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void back(object sender, EventArgs e)
        {
            Response.Redirect("main.aspx");
        }

        protected void web(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand update = new SqlCommand("Procedure_AdminUpdateStudentStatus", conn);
            update.CommandType = CommandType.StoredProcedure;
            string s = student.Text;

            byte[] g = Encoding.ASCII.GetBytes(student.Text);
            for (int j = 0; j < g.Length; j++)
            {

                if (g[j] < 48 || g[j] > 57)
                {
                    Label1.Text = "Sorry,Wrong Student ID <br/> Try Again!";
                    return;

                }
            }
            if (s == "" )
            {
                Label1.Text = "Error! You have to insert a value into all fields";
                return;
            }
            else
            {
                update.Parameters.Add(new SqlParameter("@student_id", s));
                
                conn.Open();
                update.ExecuteNonQuery();
                Response.Redirect("confirm.aspx");
                conn.Close();
            }

        }

    }
}