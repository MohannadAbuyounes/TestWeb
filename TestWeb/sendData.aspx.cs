using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWeb
{
    public partial class sendData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {

            //Session (the Viwe state same as session) for move data from pages
            // use mostly when have a persnal data (Security)
            // make hedk in server(all users use this web session)
            Session["Name"] = txtSend.Text;
            Response.Redirect("getData.aspx");
        }

        protected void btnSendQuery_Click(object sender, EventArgs e)
        {
            Response.Redirect("getData.aspx?name=" + txtSend.Text);
        }

        protected void btnSendCookie_Click(object sender, EventArgs e)
        {
            // for move data also but this is better than session , make it for all of thing one at time by using "key":"value" not like session
            // not make hedk in server 
            HttpCookie MyCookie = new HttpCookie("username");
            MyCookie.Values.Add("name", txtSend.Text);
            Response.Cookies.Add(MyCookie);
            Response.Redirect("getData.aspx");
        }
    }
}