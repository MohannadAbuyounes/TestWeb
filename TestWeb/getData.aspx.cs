using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWeb
{
    public partial class getData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //session
            if (Session["Name"] != null)
                lblSession.Text = Session["Name"].ToString();
            else
                lblSession.Text = "Not data sent";
            if (Request.QueryString["Name"] != null)
                lblQuery.Text = Request.QueryString["name"].ToString();
            else
                lblQuery.Text = "No data sent";


            //cookies
            HttpCookie MyCookie = new HttpCookie("username");
            MyCookie=Request.Cookies["username"];
            if (MyCookie == null)
                lblCookies.Text = "No cookie sent";
            else
                lblCookies.Text = MyCookie["name"];
        }
    }
}