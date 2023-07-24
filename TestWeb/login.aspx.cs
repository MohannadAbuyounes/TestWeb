using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWeb
{
    public partial class login : System.Web.UI.Page
    {
        TestWeformDBEntities db = new TestWeformDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                var myUser = db.Users.Where(user => user.UserName == txtUserName.Text && user.PassWord == txtPassword.Text);
                if (myUser.Count()>0)
                {
                    HttpCookie MyCookie = new HttpCookie("cooklogin");
                    MyCookie.Values.Add("username", HttpUtility.UrlEncode(txtUserName.Text.ToUpper()));
                    if (chbRemember.Checked)
                    {
                        MyCookie.Expires = DateTime.Now.AddYears(10);
                    }
                    Response.Cookies.Add(MyCookie);
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    Label1.Text = "Wrong passowrd  or Username";
                }
            }
        }
    }
}