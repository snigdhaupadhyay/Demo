using System;
using System.Collections.Generic;
using System.DirectoryServices.Protocols;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StageDemoApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //This method is to validate the User 
        public static bool fnValidateUser()
        {
            bool validation;
            try
            {
                LdapConnection lcon = new LdapConnection(
                                           (new LdapDirectoryIdentifier((string)null, false, false)));
                System.Net.NetworkCredential nc = new NetworkCredential(Environment.UserName,
                                       "Hello@123", Environment.UserDomainName);
                lcon.Credential = nc;
                lcon.AuthType = AuthType.Negotiate;
                // user has authenticated at this point,
                // as the credentials were used to login to the dc.
                lcon.Bind(nc);
                validation = true;
            }
            catch (LdapException)
            {
                validation = false;
            }
            return validation;
        }
        protected void btn_submit_Click(object sender, EventArgs e)
        {
            string userID = txt_userID.Text;
            string password = txt_password.Text;

            if(userID== Environment.UserName)
            {
                HttpCookie loginCookie = new HttpCookie("loginCookie");
                //loginCookie.Value = userID;
                loginCookie["User ID"] = userID;
                loginCookie["User Domain"] = Environment.UserDomainName;
                loginCookie["Machine Name"] = Environment.MachineName;
                loginCookie["OS Version"] = Environment.OSVersion.ToString();
                Response.Cookies.Add(loginCookie);
                Response.Redirect("Home.aspx");

            }
            else
            {
                lbl_message.Text = "User is not valid";
            }
        }
    }
}