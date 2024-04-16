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
    public partial class insertGP : System.Web.UI.Page
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
            SqlCommand addGP = new SqlCommand("Procedures_AdvisorCreateGP", conn);
            addGP.CommandType = CommandType.StoredProcedure;
            string q = sc.Text;
            string r = gd.Text;
            string x = cd.Text;
            string t = aid.Text;
            string u = sid.Text;

            byte[] g = Encoding.ASCII.GetBytes(aid.Text);
            for (int j = 0; j < g.Length; j++)
            {
                if (g[j] < 48 || g[j] > 57)
                {
                    Response.Write("Sorry,Wrong Advisor ID. ");
                    Response.Write("Try Again!");
                    return;
                }
            }


            byte[] f = Encoding.ASCII.GetBytes(cd.Text);
            for (int j = 0; j < f.Length; j++)
            {
                if (f[j] < 48 || f[j] > 57)
                {
                    Response.Write("Sorry,Wrong Credit hours. ");
                    Response.Write("Try Again!");
                    return;
                }
            }

            byte[] p = Encoding.ASCII.GetBytes(sid.Text);
            for (int j = 0; j < p.Length; j++)
            {
                if (p[j] < 48 || p[j] > 57)
                {
                    Response.Write("Sorry,Wrong Student ID. ");
                    Response.Write("Try Again!");
                    return;
                }
            }

            if (u == "" || q == "" || r == "" || x == "" || t == "")
            {
                Response.Write("Error! You have to insert a value into all fields ");
                Response.Write("Try Again!");
                return;
            }

            addGP.Parameters.Add(new SqlParameter("@Semester_code", q));
            addGP.Parameters.Add(new SqlParameter("@expected_graduation_date", r));
            addGP.Parameters.Add(new SqlParameter("@sem_credit_hours", x));
            addGP.Parameters.Add(new SqlParameter("@advisor_id", t));
            addGP.Parameters.Add(new SqlParameter("@student_id", u));
            try
            {
                conn.Open();
                addGP.ExecuteNonQuery();
                Response.Write("Graduation plan inserted Successfully!");
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }
    }

}