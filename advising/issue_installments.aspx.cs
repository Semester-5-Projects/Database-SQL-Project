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

namespace advising
{
    public partial class issue_installments : System.Web.UI.Page
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
            try { 
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand install = new SqlCommand("Procedures_AdminIssueInstallment", conn);
            install.CommandType = CommandType.StoredProcedure;
            string p = payment.Text;
            byte[] g = Encoding.ASCII.GetBytes(payment.Text);
            for (int j = 0; j < g.Length; j++)
            {

                if (g[j] < 48 || g[j] > 57)
                {
                        Label1.Text = "Sorry,Wrong Payment ID <br/> Try Again!";
                        return;

                }
            }
            if (p == "" )
            {
                Label1.Text="Error! You have to insert a value into all fields";
                return;
            }
            else
            {
                install.Parameters.Add(new SqlParameter("@payment_id", p));
                
                    conn.Open();
                    install.ExecuteNonQuery();
                    Response.Redirect("confirm.aspx");
                    conn.Close();
                
            }
            }
            catch (Exception ex)
            {
                Label1.Text="Installments were already issued for this Payment";

            }
        }
    }
}
    
