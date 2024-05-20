using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace advisor
{
    public partial class insertCourseGP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void bac(object sender, EventArgs e)
        {
            Response.Redirect("advisorMain.aspx");

        }


        protected void addbt(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand addC = new SqlCommand("Procedures_AdvisorAddCourseGP", conn);
            addC.CommandType = CommandType.StoredProcedure;
            string a = sid.Text;
            string b = sc.Text;
            string c = cn.Text;


            byte[] g = Encoding.ASCII.GetBytes(sid.Text);
            for (int j = 0; j < g.Length; j++)
            {
                if (g[j] < 48 || g[j] > 57)
                {
                    Response.Write("Sorry,Wrong ID. ");
                    Response.Write("Try Again!");
                    return;
                }
            }

            if (a == "" || b == "" || c == "")
            {
                Response.Write("Error! You have to insert a value into all fields ");
                Response.Write("Try Again!");
                return;
            }


            addC.Parameters.Add(new SqlParameter("@student_id", a));
            addC.Parameters.Add(new SqlParameter("@Semester_code", b));
            addC.Parameters.Add(new SqlParameter("@course_name", c));
            try
            {
                conn.Open();
                addC.ExecuteNonQuery();
                Response.Write("Course added successfully!");
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }
    }

}
