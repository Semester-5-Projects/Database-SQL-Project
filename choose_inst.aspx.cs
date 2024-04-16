using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace student2_advising
{
    public partial class choose_inst : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void choose_inst_button_Click(object sender, EventArgs e)
        {
            try
            {

                String connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                //create a new connection
                SqlConnection conn = new SqlConnection(connstr);
                if (choose_inst_inst_id.Text == "" || choose_inst_couse_id.Text == "" || choose_inst_semcode.Text == "")
                {
                    Response.Write("fill all textboxes");
                    output.Text = "";
                    return;

                }

                int sid = Int16.Parse((string)Session["studentid"]);
                int insid = Int16.Parse(choose_inst_inst_id.Text);
                int cid = Int16.Parse(choose_inst_couse_id.Text);
                String semcode = (choose_inst_semcode.Text);

                SqlCommand chooseins = new SqlCommand("[Procedures_Chooseinstructor]", conn);
                chooseins.CommandType = CommandType.StoredProcedure;
                chooseins.Parameters.Add(new SqlParameter("@StudentID", sid));
                chooseins.Parameters.Add(new SqlParameter("@instrucorID", insid));
                chooseins.Parameters.Add(new SqlParameter("@CourseID", cid));
                chooseins.Parameters.Add(new SqlParameter("@current_semester_code", semcode));

                conn.Open();
                int r = chooseins.ExecuteNonQuery();
                conn.Close();

                if (r > 0)
                {
                    output.Text = "Instructor chosen successfully";
                }
                else
                {
                    output.Text = "Failed to choose instructor!";
                }
            }
            catch (Exception ex)
            {
                Response.Write("Enter a valid course id or instructor id");
                Response.Write(", Try Again!");
                output.Text = "";
            }
           
        }

        protected void choose_inst_back_Click(object sender, EventArgs e)
        {
            String connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connstr);
            Response.Redirect("student2.aspx");
        }
    }
}