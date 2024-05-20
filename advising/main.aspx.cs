using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace advising
{
    public partial class main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void web1(object sender, EventArgs e)
        {
            Response.Redirect("admin_page.aspx");
        }

        protected void a(object sender, EventArgs e)
        {
            Response.Redirect("delete_course.aspx");
        }

        protected void b(object sender, EventArgs e)
        {
            Response.Redirect("delete_slot.aspx");
        }

        protected void c(object sender, EventArgs e)
        {
            Response.Redirect("add_makeup.aspx");
        }
        protected void d(object sender, EventArgs e)
        {
            Response.Redirect("view_payments.aspx");
        }

        protected void e(object sender, EventArgs e)
        {
            Response.Redirect("issue_installments.aspx");
        }

        protected void f(object sender, EventArgs e)
        {
            Response.Redirect("update_status.aspx");
        }

            protected void g(object sender, EventArgs e)
        {
            Response.Redirect("active_students.aspx");
        }

        protected void h(object sender, EventArgs e)
        {
            Response.Redirect("view_gradplans.aspx");
        }

        protected void i(object sender, EventArgs e)
        {
            Response.Redirect("transcript.aspx");
        }
        protected void j(object sender, EventArgs e)
        {
            Response.Redirect("semesters_offered_courses.aspx");
        }
    }
}