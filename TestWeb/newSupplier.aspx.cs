using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWeb
{
    public partial class newSupplier : System.Web.UI.Page
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

        protected void btnAddSupplier_Click(object sender, EventArgs e)
        {
            var intTxtSupplierID = int.Parse(txtSupplierID.Text);
            if (Page.IsValid)
            {
                Supplier MySupplier = new Supplier
                {
                    SupplierID = intTxtSupplierID,
                    CompanyName = txtCompanyName.Text,
                    ContactName = txtContactName.Text,
                    ContactTitle = txtContactTitle.Text,
                    Address = txtAddress.Text,
                    City = txtCity.Text,
                    Region = txtRegion.Text,
                    PostalCode = txtPostalCode.Text,
                    Country = txtCountry.Text,
                    Phone = txtPhone.Text,
                    Fax = txtFax.Text,

                };
                db.Suppliers.Add(MySupplier);
                db.SaveChanges();
                Response.Redirect("Suppliers.aspx");
            }
        }

        protected void btnCancelAddSupplier_Click(object sender, EventArgs e)
        {
            Response.Redirect("Suppliers.aspx");

        }
        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            var intTxtSupplierID = int.Parse(txtSupplierID.Text);
            var cust = db.Suppliers.FirstOrDefault(c => c.SupplierID == intTxtSupplierID);
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
            var cust = db.Suppliers.FirstOrDefault(c => c.ContactName == txtContactName.Text);
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