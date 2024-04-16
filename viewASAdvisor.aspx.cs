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
    public partial class viewAS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void bac(object sender, EventArgs e)
        {
            Response.Redirect("advisorMain.aspx");

        }


        protected void viewStudents(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand new_adv = new SqlCommand("Procedures_AdvisorViewAssignedStudents", conn);
            new_adv.CommandType = CommandType.StoredProcedure;
            string i = aid.Text;
            string m = maj.Text;

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

            if (m == "" || i == "")
            {
                Response.Write("Error! You have to insert a value into all fields. ");
                Response.Write("Try Again!");
                return;
            }

            new_adv.Parameters.Add(new SqlParameter("@major", m));
            new_adv.Parameters.Add(new SqlParameter("@AdvisorID", i));
            conn.Open();
            new_adv.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(new_adv);
            DataTable ad = new DataTable();
            adapter.Fill(ad);
            advTable.DataSource = ad;
            advTable.DataBind();
            conn.Close();
        }
    }


}
