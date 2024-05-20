using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Data.Common;
using System.Web.Configuration;
using System.Text;

namespace advisor
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void blbt(object sender, EventArgs e)
        {
            Response.Redirect("loginAdvisor.aspx");

        }

        protected void registerbt(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand new_register = new SqlCommand("Procedures_AdvisorRegistration", conn);
            new_register.CommandType = CommandType.StoredProcedure;
            string u = un.Text;
            string p = pass.Text;
            string m = em.Text;
            string o = off.Text;

            if( u=="" || p == "" || m == "" || o == "")
                {
                    Response.Write("Error! You have to insert a value into all fields. ");
                    Response.Write("Try Again!");
                    return;
                }

                new_register.Parameters.Add(new SqlParameter("@advisor_name", u));
                new_register.Parameters.Add(new SqlParameter("@password", p));
                new_register.Parameters.Add(new SqlParameter("@email", m));
                new_register.Parameters.Add(new SqlParameter("@office", o));
                SqlParameter id = new_register.Parameters.Add("@Advisor_id", SqlDbType.Int);
                id.Direction = ParameterDirection.Output;
            try
            {
                conn.Open();
                new_register.ExecuteNonQuery();

                conn.Close();

                Response.Write("Register Successful");
                Response.Write("your id is" + id.Value);

            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }




        }
    }
}