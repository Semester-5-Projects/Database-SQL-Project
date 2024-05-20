using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADVISINGG
{
    public partial class confirm_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }
        protected void web(object sender, EventArgs e)
        {
            Response.Redirect("admin_page.aspx");
        }
    }
}