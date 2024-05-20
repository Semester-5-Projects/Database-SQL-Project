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
    public partial class pendingRequests : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void bac(object sender, EventArgs e)
        {
            Response.Redirect("advisorMain.aspx");

        }


        protected void viewbt(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand pending = new SqlCommand("Procedures_AdvisorViewPendingRequests", conn);
            pending.CommandType = CommandType.StoredProcedure;
            string a = aid.Text;


            byte[] g = Encoding.ASCII.GetBytes(aid.Text);
            for (int j = 0; j < g.Length; j++)
            {
                if (g[j] < 48 || g[j] > 57)
                {
                    Response.Write("Sorry,Wrong ID. ");
                    Response.Write("Try Again!");
                    return;
                }
            }

            if (a == "")
            {
                Response.Write("Error! You have to insert a value into all fields ");
                Response.Write("Try Again!");
                return;
            }


            pending.Parameters.Add(new SqlParameter("@Advisor_ID", a));
            try
            {
                conn.Open();
                pending.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(pending);
                DataTable ad = new DataTable();
                adapter.Fill(ad);
                penTable.DataSource = ad;
                penTable.DataBind();
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }

}