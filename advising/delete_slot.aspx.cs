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
    public partial class delete_slot : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void bacc(object sender, EventArgs e)
        {
            Response.Redirect("main.aspx");


        }
        protected void web(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand delete_semester = new SqlCommand("Procedures_AdminDeleteSlots", conn);
            delete_semester.CommandType = CommandType.StoredProcedure;


            
            if (semester.Text == "")
            {
                Label1.Text="Error! You have to insert a value into the field";
                return;
            }
            else
            {
                String c = semester.Text;
                delete_semester.Parameters.Add(new SqlParameter("@current_semester", c));
                conn.Open();
                delete_semester.ExecuteNonQuery();
                Response.Redirect("confirm.aspx");
                conn.Close();
            }

        }
    }
}

        
   
