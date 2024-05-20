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
    public partial class viewRequests : System.Web.UI.Page
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

            if (aid.Text == "")
            {
                Response.Write("Error! You have to insert a value into all fields ");
                Response.Write("Try Again!");
                return;
            }


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

            int a = Int16.Parse(aid.Text);

            SqlCommand view_request = new SqlCommand("select * from dbo.FN_Advisors_Requests(@advisor_Id)", conn);
            view_request.Parameters.Add(new SqlParameter("@advisor_id", a));

            conn.Open();
            SqlDataReader reader = view_request.ExecuteReader();
            DataTable ad = new DataTable();
            ad.Load(reader);
            table.DataSource = ad;
            table.DataBind();
            conn.Close();

        }



    }
}