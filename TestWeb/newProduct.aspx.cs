using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWeb
{
    public partial class newProduct : System.Web.UI.Page
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

            if (Page.IsPostBack == false)
            {
                FillList();
            }
        }
        void FillList()
        {
            ddlSupplier.DataSource = db.Suppliers.ToList();
            ddlSupplier.DataValueField = "SupplierID";
            ddlSupplier.DataTextField = "ContactName";
            ddlSupplier.DataBind();
            ddlCategories.DataSource = db.Categories.ToList();
            ddlCategories.DataValueField = "CategoryID";
            ddlCategories.DataTextField = "CategoryName";
            ddlCategories.DataBind();

        }
        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            var intTxtProductID = int.Parse(txtProductID.Text);
            decimal unitPrice = decimal.Parse(txtPrice.Text);
            if (Page.IsValid)
            {
                Product MyProduct = new Product
                {
                    ProductID = intTxtProductID,
                   ProductName=txtProductName.Text,
                   CategoryID=int.Parse(ddlCategories.SelectedValue.ToString()),
                   SupplierID=int.Parse(ddlSupplier.SelectedValue.ToString()),
                   UnitPrice= unitPrice,

                };
                db.Products.Add(MyProduct);
                db.SaveChanges();
                Response.Redirect("product.aspx");
            }
        }

        protected void btnCancelAddProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("product.aspx");

        }
        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            var intTxtProductID = int.Parse(txtProductID.Text);
            var cust = db.Products.FirstOrDefault(c => c.ProductID == intTxtProductID);
            if (cust == null)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;

            }
        }

        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {
            var cust = db.Products.FirstOrDefault(c => c.ProductName == txtProductName.Text);
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