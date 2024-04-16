using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADVISINGG
{
    public partial class admin_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void bacc(object sender, EventArgs e)
        {
            Response.Redirect("choose.aspx");

        }


        protected void website(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            byte[] d = Encoding.ASCII.GetBytes(id.Text);
            for (int i = 0; i < d.Length; i++)
            {

                if (d[i] < 48 || d[i] > 57)
                {
                    Label1.Text = "Error! <br/> Wrong User ID <br/> Try Again!";
                    return;

                }
            }

            if(id.Text=="" || password.Text == "")
            {
                Label1.Text = "Error! <br/> You have to insert a value into all fields";
                return;
            }

            int ID = Int16.Parse(id.Text);
            string pass = password.Text;



            if (ID == 2339 && pass == "angela")
            {
                Label1.Text = "Hello Admin,Welcome to the Advising Page!";
                Response.Redirect("admin_page.aspx");
            }
            else
            {
                if (ID != 2339)
                {
                    Label1.Text = "Error! <br/> Wrong User ID <br/> Try Again! ";
                   

                }
                else
                {
                    Label1.Text = "Error! <br/> Wrong Password <br/> Try Again! ";
                    

                }

            }

        }
    }
    }