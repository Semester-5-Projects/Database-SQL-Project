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
    public partial class updateGP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void bac(object sender, EventArgs e)
        {
            Response.Redirect("advisorMain.aspx");

        }


        protected void updatebt(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand updateGD = new SqlCommand("Procedures_AdvisorUpdateGP", conn);
            updateGD.CommandType = CommandType.StoredProcedure;
            string a = gd.Text;
            string b = sid.Text;

            byte[] g = Encoding.ASCII.GetBytes(sid.Text);
            for (int j = 0; j < g.Length; j++)
            {
                if (g[j] < 48 || g[j] > 57)
                {
                    Response.Write("Sorry,Wrong ID ");
                    Response.Write("Try Again!");
                    return;
                }
            }

            if (a == "" || b == "" )
            {
                Response.Write("Error! You have to insert a value into all fields ");
                Response.Write("Try Again!");
                return;
            }
            try
            {
                updateGD.Parameters.Add(new SqlParameter("@expected_grad_date", a));
                updateGD.Parameters.Add(new SqlParameter("@studentID", b));
                conn.Open();
                updateGD.ExecuteNonQuery();
                Response.Write("Date Updated Successfully!");
                conn.Close();
            }
            catch (Exception ex) { 
                Response.Write(ex.ToString());
            
            }
        }
    }



}