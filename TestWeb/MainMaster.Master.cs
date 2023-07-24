using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWeb
{
    public partial class MainMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie MyCookie = new HttpCookie("cooklogin");
            MyCookie = Request.Cookies["cooklogin"];
            if (MyCookie == null)
            {
                lstWelcome.Visible = false;
                lstDataOfClenit.Visible = false;
                lstLogBtn.Visible = true;
            }
            else
            {
                lstWelcome.Visible = true;
                lstDataOfClenit.Visible = true;
                lstLogBtn.Visible = false;
                lbtnUser.Text =HttpUtility.UrlDecode(MyCookie["username"].ToUpper());
               
            }
        }

        protected void lbtnLogOut_Click(object sender, EventArgs e)
        {
            HttpCookie MyCookie = new HttpCookie("cooklogin");
            MyCookie.Expires = DateTime.Now.AddYears(-1);
            Response.Cookies.Add(MyCookie);
            Response.Redirect("Home.aspx");
        }
    }
}