using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CompanyWebsite
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string uname, pass;
            uname = username.Text;
            pass = password.Text;

            if (uname == "admin" && pass == "admin")
            {
                Response.Redirect("Dashboard.aspx");
            }
            else
            {
                //Label1.Text = "Wrong credentials!";
            }
        }
    }
}