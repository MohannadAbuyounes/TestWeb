using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWeb
{
    public partial class updateCategory : System.Web.UI.Page
    {
        TestWeformDBEntities db = new TestWeformDBEntities();


        protected void Page_Load(object sender, EventArgs e)
        {
             HttpCookie httpCookie = new HttpCookie("cooklogin");
            httpCookie = Request.Cookies["cooklogin"];
            if (httpCookie == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
          
                if (Page.IsPostBack == false)
                {
                    txtCategoryID.Text = Request.QueryString["id"];
                    int suppID = int.Parse(txtCategoryID.Text);
                    var MyCust = db.Categories.FirstOrDefault(c => c.CategoryID == suppID);
                    txtCategoryName.Text = MyCust.CategoryName;
                    txtDescrption.Text = MyCust.Description;
                }
            }

        }
        protected void btnAddCategory_Click(object sender, EventArgs e)
        {
            int suppID = int.Parse(Request.QueryString["id"]);
            var updateCust = db.Categories.Find(suppID);
            updateCust.CategoryName = txtCategoryName.Text;
         updateCust.Description = txtDescrption.Text;
            db.SaveChanges();
            Response.Redirect("categoies.aspx");

        }

        protected void btnCancelAddCategory_Click(object sender, EventArgs e)
        {
            Response.Redirect("categoies.aspx");
        }
    }
}