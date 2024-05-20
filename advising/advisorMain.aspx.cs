using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace advisor
{
    public partial class advisorMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }
        protected void bac(object sender, EventArgs e)
        {
            Response.Redirect("loginAdvisor.aspx");
        }
        protected void a3(object sender, EventArgs e)
        {
            Response.Redirect("viewASAdvisor.aspx");
        }
        protected void a4(object sender, EventArgs e)
        {
            Response.Redirect("insertGPAdvisor.aspx");
        }
        protected void a5(object sender, EventArgs e)
        {
            Response.Redirect("insertCourseGPAdvisor.aspx");
        }
        protected void a6(object sender, EventArgs e)
        {
            Response.Redirect("updateGPAdvisor.aspx");
        }
        protected void a7(object sender, EventArgs e)
        {
            Response.Redirect("deleteCourseAdvisor.aspx");
        }
        protected void a8(object sender, EventArgs e)
        {
            Response.Redirect("viewStudentsAdvisor.aspx");
        }
        protected void a9(object sender, EventArgs e)
        {
            Response.Redirect("viewRequestsAdvisor.aspx");

        }
        protected void a10(object sender, EventArgs e)
        {
            Response.Redirect("pendingRequestsAdvisor.aspx");
        }
        protected void a11(object sender, EventArgs e)
        {
            Response.Redirect("requestCHAdvisor.aspx");
        }
        protected void a12(object sender, EventArgs e)
        {
            Response.Redirect("courseRequestAdvisor.aspx");
        }
    }
}