using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWeb
{
    public partial class newCategory : System.Web.UI.Page
    {
        TestWeformDBEntities db = new TestWeformDBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            // للصلاحيات 
            HttpCookie httpCookie = new HttpCookie("cooklogin");
            httpCookie = Request.Cookies["cooklogin"];
            if (httpCookie == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                if (httpCookie["username"] != HttpUtility.UrlDecode("ADMIN"))
                {
                    Response.Redirect("login.aspx");
                }
            }
        }

        protected void btnAddCategory_Click(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
                Category MyCategory = new Category
                {
        
                    CategoryName = txtCategoryName.Text,
                    Description = txtDescraption.Text,
                    

                };
                db.Categories.Add(MyCategory);
                db.SaveChanges();
                Response.Redirect("categoies.aspx");
            }
        }

        protected void btnCancelAddCategory_Click(object sender, EventArgs e)
        {
            Response.Redirect("categoies.aspx");

        }


        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {
            var cust = db.Categories.FirstOrDefault(c => c.CategoryName == txtCategoryName.Text);
            if (cust == null)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;

            }
        }
    }
}