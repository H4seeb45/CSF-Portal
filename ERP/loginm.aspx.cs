using System;
using System.Collections;
using System.Web;

namespace ERP
{
    public partial class loginm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click1(object sender, EventArgs e)
        {
            string username = Username.Value;
            string password = Password.Value;
           bool check = LoginBLL.authenticateUser(username, password);
            if(check==true)
            {
                ArrayList list = new ArrayList();

                        Session["UserName"] = username;
                        Session.Timeout = 5;
                
                if (checkbox.Checked == true)
                {
                    HttpCookie cookie = new HttpCookie("cookie");
                    cookie["UserName"] = username;
                    cookie.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(cookie);
                }
                Response.Redirect("Default.aspx");
            }
            else {

            }

        }
    }
}