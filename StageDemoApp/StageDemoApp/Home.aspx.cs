using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StageDemoApp
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(this.Request.UrlReferrer != null) 
            {
                HttpCookie newCookie = Request.Cookies["loginCookie"];
                    lbl_userID.Text = newCookie["User ID"];
                lbl_userDomain.Text = newCookie["User Domain"];
                lbl_machine.Text = newCookie["Machine Name"];
                lbl_osVersion.Text = newCookie["OS Version"];            
            }

            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}