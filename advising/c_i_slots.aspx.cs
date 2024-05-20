using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace student2_advising
{
    public partial class c_i_slots : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void slots_view_button_Click(object sender, EventArgs e)
        {
            try {
                String connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                //create a new connection
                SqlConnection conn = new SqlConnection(connstr);
                if(slots_course_id.Text==""|| slots_inst_id.Text=="")
                {
                    Response.Write("fill all textboxes");
                    DataTable t = new DataTable();
                    GridView5.DataSource = t;
                    GridView5.DataBind();
                    return;

                }
                int courseid = Int16.Parse(slots_course_id.Text);
                int instructorid = Int16.Parse(slots_inst_id.Text);

                SqlCommand slots = new SqlCommand("select * from dbo.[FN_StudentViewSlot](@CourseID,@InstructorID)", conn);
                slots.Parameters.Add(new SqlParameter("@CourseID", courseid));
                slots.Parameters.Add(new SqlParameter("@InstructorID", instructorid));

                conn.Open();
                SqlDataReader x = slots.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(x);
                GridView5.DataSource = dt;
                GridView5.DataBind();
                if (dt.Rows.Count == 0)
                {
                    Label name = new Label();
                    name.Text = "no slots to display";
                    form1.Controls.Add(name);
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                Response.Write("no slots to display or invalid input");
                Response.Write(", Try Again!");
                DataTable dt = new DataTable();
                GridView5.DataSource = dt;
                GridView5.DataBind();



            }
            
        }
        protected void c_i_slots_back_Click(object sender, EventArgs e)
        {
            String connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connstr);
            Response.Redirect("student2.aspx");
        }
    }
}