using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWeb
{
    public partial class updateProduct : System.Web.UI.Page
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
                    FillList();
                    txtProductID.Text = Request.QueryString["id"];
                    int suppID = int.Parse(txtProductID.Text);
                    var MyCust = db.Products.FirstOrDefault(c => c.ProductID == suppID);
                    txtProductName.Text = MyCust.ProductName;
                    txtPrice.Text = MyCust.UnitPrice.ToString();
                    ddlCategories.SelectedValue = MyCust.CategoryID.ToString();
                    ddlSupplier.SelectedValue = MyCust.SupplierID.ToString();


                }
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
            int suppID = int.Parse(Request.QueryString["id"]);
            var updateCust = db.Products.Find(suppID);
            decimal unitpeice = decimal.Parse(txtPrice.Text);
            updateCust.ProductName = txtProductName.Text;
            updateCust.SupplierID =  int.Parse(ddlSupplier.SelectedValue.ToString());

            updateCust.CategoryID =  int.Parse(ddlCategories.SelectedValue.ToString());
            updateCust.UnitPrice = unitpeice;
     
            db.SaveChanges();
            Response.Redirect("product.aspx");

        }

        protected void btnCancelAddProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("product.aspx");
        }
    }
}