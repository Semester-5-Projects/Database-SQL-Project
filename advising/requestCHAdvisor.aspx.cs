using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace advisor
{
    public partial class requestch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void bac(object sender, EventArgs e)
        {
            Response.Redirect("advisorMain.aspx");

        }

        protected void web(object sender, EventArgs e)
        {
            
                string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connstr);
                SqlCommand addC = new SqlCommand("Procedures_AdvisorApproveRejectCHRequest", conn);
                addC.CommandType = CommandType.StoredProcedure;
                


                byte[] g = Encoding.ASCII.GetBytes(rid.Text);
                for (int j = 0; j < g.Length; j++)
                {
                    if (g[j] < 48 || g[j] > 57)
                    {
                        Response.Write("Sorry,Wrong ID. ");
                        Response.Write("Try Again!");
                        return;
                    }
                }
            string r = rid.Text;
            string s = sc.Text;

            if (r == "" || s == "" )
                {
                    Response.Write("Error! You have to insert a value into all fields ");
                    Response.Write("Try Again!");
                    return;
                }


                addC.Parameters.Add(new SqlParameter("@requestID", r));
                addC.Parameters.Add(new SqlParameter("@current_sem_code", s));
            try
            {
                conn.Open();
                addC.ExecuteNonQuery();
                Response.Write("Status updates successfully!");
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
            }
        }

    }
    
