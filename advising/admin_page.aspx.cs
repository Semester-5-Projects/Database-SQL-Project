using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADVISINGG
{
    public partial class admin_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void web11(object sender, EventArgs e)
        {
            Response.Redirect("main.aspx");
        }

        protected void web1(object sender, EventArgs e)
        {
            Response.Redirect("advisors_page.aspx");
        }

        protected void web2(object sender, EventArgs e)
        {
            Response.Redirect("students_page.aspx");
        }

        protected void web3(object sender, EventArgs e)
        {
            Response.Redirect("requests.aspx");
        }

        protected void web4(object sender, EventArgs e)
        {
            Response.Redirect("add_semester.aspx");
        }

        protected void web5(object sender, EventArgs e)
        {
            Response.Redirect("add_course.aspx");
        }

        protected void web6(object sender, EventArgs e)
        {
            Response.Redirect("link_ins_course_slot.aspx");
        }

        protected void web7(object sender, EventArgs e)
        {
            Response.Redirect("link_stu_adv.aspx");
        }

        protected void web8(object sender, EventArgs e)
        {
            Response.Redirect("link_stu_course_ins.aspx");
        }

        protected void web9(object sender, EventArgs e)
        {
            Response.Redirect("instructor_courses_page.aspx");
        }

        protected void web10(object sender, EventArgs e)
        {
            Response.Redirect("semester_courses_page.aspx");
        }
        protected void mainn(object sender, EventArgs e)
        {
            Response.Redirect("choose.aspx");
        }

    }
}