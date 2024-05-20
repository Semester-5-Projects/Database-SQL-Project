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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void bac(object sender, EventArgs e)
        {
            Response.Redirect("choose.aspx");

        }
        protected void regbt(object sender, EventArgs e)
        {
            Response.Redirect("registerAdvisor.aspx");

        }
        protected void loginbt(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            string u = un.Text;
            string p = pass.Text;


            byte[] g = Encoding.ASCII.GetBytes(un.Text);
            for (int j = 0; j < g.Length; j++)
            {
                if (g[j] < 48 || g[j] > 57)
                {
                    Response.Write("Sorry,Wrong ID. ");
                    Response.Write("Try Again!");
                    return;
                }
            }

            if (u == "" || p == "")
            {
                Response.Write("Error! You have to insert a value into all fields. ");
                Response.Write("Try Again!");
                return;
            }

            try
            {
                conn.Open();
                SqlCommand new_login = new SqlCommand("Select dbo.FN_AdvisorLogin(@advisor_Id,@password)", conn);
                new_login.CommandType = CommandType.Text;
                new_login.Parameters.Add(new SqlParameter("@advisor_Id", u));
                new_login.Parameters.Add(new SqlParameter("@password", p));
                bool s = Convert.ToBoolean(new_login.ExecuteScalar());
                conn.Close();


                if (s == true)
                {
                    Response.Write("Login successful");
                    Response.Redirect("advisorMain.aspx");
                }
                else
                {
                    Response.Write("Try Again!");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }


        }
    }
}
