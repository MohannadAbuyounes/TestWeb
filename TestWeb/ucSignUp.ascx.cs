using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWeb
{
    public partial class ucSignUp : System.Web.UI.UserControl
    {
        TestWeformDBEntities db = new TestWeformDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                User MyUser = new User
                {
                    UserName=txtUserName.Text,
                    PassWord=txtPassword.Text,
                    UserAddress=txtAddress.Text,
                    UserEmail=txtEmail.Text,
                    UserPhone=txtPhone.Text,
                };
                db.Users.Add(MyUser);
                db.SaveChanges();
                HttpCookie MyCookie = new HttpCookie("cooklogin");
                MyCookie.Values.Add("username",HttpUtility.UrlEncode( txtUserName.Text.ToUpper()));
                Response.Cookies.Add(MyCookie);
                Response.Redirect("Home.aspx");
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}






