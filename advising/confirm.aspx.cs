using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace advising
{
    public partial class confirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void web(object sender, EventArgs e)
        {
            Response.Redirect("main.aspx");
        }
    }
}