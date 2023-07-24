using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWeb
{

    public partial class updateSupplier : System.Web.UI.Page
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
                    txtSupplierID.Text = Request.QueryString["id"];
                    int suppID = int.Parse(txtSupplierID.Text);
                    var MyCust = db.Suppliers.FirstOrDefault(c => c.SupplierID == suppID);
                    txtCompanyName.Text = MyCust.CompanyName;
                    txtContactName.Text = MyCust.ContactName;
                    txtContactTitle.Text = MyCust.ContactTitle;
                    txtAddress.Text = MyCust.Address;
                    txtCity.Text = MyCust.City;
                    txtRegion.Text = MyCust.Region;
                    txtPostalCode.Text = MyCust.PostalCode;
                    txtCountry.Text = MyCust.Country;
                    txtPhone.Text = MyCust.Phone;
                    txtFax.Text = MyCust.Fax;
                }
            }

        }
        protected void btnAddSupplier_Click(object sender, EventArgs e)
        {
            int suppID = int.Parse(Request.QueryString["id"]);
            var updateCust = db.Suppliers.Find(suppID);
            updateCust.CompanyName = txtCompanyName.Text;
            updateCust.ContactName = txtContactName.Text;
            updateCust.ContactTitle = txtContactTitle.Text;
            updateCust.Address = txtAddress.Text;
            updateCust.City = txtCity.Text;
            updateCust.Region = txtRegion.Text;
            updateCust.PostalCode = txtPostalCode.Text;
            updateCust.Country = txtCountry.Text;
            updateCust.Phone = txtPhone.Text;
            updateCust.Fax = txtFax.Text;
            db.SaveChanges();
            Response.Redirect("Suppliers.aspx");

        }

        protected void btnCancelAddSupplier_Click(object sender, EventArgs e)
        {
            Response.Redirect("Suppliers.aspx");
        }
    }
}