using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace student2_advising
{
    public partial class view_inst : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                String connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                //create a new connection
                SqlConnection conn = new SqlConnection(connstr);

                int sid = Int16.Parse((string)Session["studentid"]);
               

                SqlCommand inst = new SqlCommand("select dbo.[FN_StudentUpcoming_installment](@student_ID)", conn);
                inst.Parameters.Add(new SqlParameter("@student_ID", sid));

                conn.Open();
                installdeadline.Text = inst.ExecuteScalar().ToString();
                conn.Close();

                if (inst.ExecuteScalar().ToString() == null)
                {
                    installdeadline.Text = "No upcoming installments";
                }
            }
            catch(Exception ex)
            {
                Response.Write("No Upcoming installments!");
                installdeadline.Text = "";
            }


        }

        protected void inst_back_Click(object sender, EventArgs e)
        {
            String connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connstr);
            Response.Redirect("student2.aspx");
        }
    }
}