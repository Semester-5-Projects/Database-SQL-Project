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
    public partial class courseRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void bac(object sender, EventArgs e)
        {
            Response.Redirect("advisorMain.aspx");

        }

        protected void statusbt(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand request = new SqlCommand("Procedures_AdvisorApproveRejectCourseRequest", conn);
            request.CommandType = CommandType.StoredProcedure;
            string a = rid.Text;
            string b = sc.Text;


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

            if (a == "" || b == "")
            {
                Response.Write("Error! You have to insert a value into all fields ");
                Response.Write("Try Again!");
                return;
            }


            request.Parameters.Add(new SqlParameter("@requestID", a));
            request.Parameters.Add(new SqlParameter("@current_semester_code", b));
            try
            {
                conn.Open();
                request.ExecuteNonQuery();
                Response.Write("Request Status Updated!");
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }
    }
}