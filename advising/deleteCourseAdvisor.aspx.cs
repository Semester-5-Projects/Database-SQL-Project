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
    public partial class deleteCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void bac(object sender, EventArgs e)
        {
            Response.Redirect("advisorMain.aspx");

        }

        protected void deletebt(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand deleteC = new SqlCommand("Procedures_AdvisorDeleteFromGP", conn);
            deleteC.CommandType = CommandType.StoredProcedure;
            string a = sid.Text;
            string b = sc.Text;
            string c = cid.Text;


            byte[] g = Encoding.ASCII.GetBytes(sid.Text);
            for (int j = 0; j < g.Length; j++)
            {
                if (g[j] < 48 || g[j] > 57)
                {
                    Response.Write("Sorry,Wrong Student ID. ");
                    Response.Write("Try Again!");
                    return;
                }
            }

            byte[] f = Encoding.ASCII.GetBytes(cid.Text);
            for (int j = 0; j < f.Length; j++)
            {
                if (f[j] < 48 || f[j] > 57)
                {
                    Response.Write("Sorry,Wrong Course ID. ");
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


            deleteC.Parameters.Add(new SqlParameter("@studentID", a));
            deleteC.Parameters.Add(new SqlParameter("@sem_code", b));
            deleteC.Parameters.Add(new SqlParameter("@courseID", c));
            try
            {
                conn.Open();
                deleteC.ExecuteNonQuery();
                Response.Write("Course deleted successfully!");
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }
    }


}