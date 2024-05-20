using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace student2_advising
{
    public partial class student2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void View_gp(object sender, EventArgs e)
        {
            String connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connstr);
            Response.Redirect("view_g_p.aspx");


        }

        protected void view_upcoming_unpaid_installment(object sender, EventArgs e)
        {
            String connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connstr);
            Response.Redirect("view_inst.aspx");
        }

        protected void view_courses_and_exam_details(object sender, EventArgs e)
        {
            String connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connstr);
            Response.Redirect("exam_details.aspx");
        }

        protected void Register_makeup1(object sender, EventArgs e)
        {
            String connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connstr);
            Response.Redirect("makeup1.aspx");
        }

        protected void Register_makeup2(object sender, EventArgs e)
        {
            String connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connstr);
            Response.Redirect("makeup2.aspx");
        }

        protected void view_courses_and_slots_and_instructor_details(object sender, EventArgs e)
        {
            String connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connstr);
            Response.Redirect("Course_Slots_Instructor.aspx");

        }

        protected void view_slots_of_certain_course_taught_by_certain_inst(object sender, EventArgs e)
        {
            String connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connstr);
            Response.Redirect("c_i_slots.aspx");
        }

        protected void choose_inst_for_certain_course(object sender, EventArgs e)
        {
            String connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connstr);
            Response.Redirect("choose_inst.aspx");

        }

        protected void view_details_of_all_courses_and_prereq(object sender, EventArgs e)
        {

            String connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connstr);
            Response.Redirect("view_all_prereq.aspx");

        }

        protected void connection_Click(object sender, EventArgs e)
        {
            String connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connstr);
            Response.Redirect("options.aspx");
        }
    }
}