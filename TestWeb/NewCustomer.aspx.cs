using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWeb
{
    public partial class NewCustomer : System.Web.UI.Page
    {
        TestWeformDBEntities testWeformDBEntities = new TestWeformDBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            // للصلاحيات 
            HttpCookie httpCookie = new HttpCookie("cooklogin");
            httpCookie = Request.Cookies["cooklogin"];
            if (httpCookie == null )
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

        protected void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (Page.IsValid) {
                Customer MyCustomer = new Customer
                {
                    CustomerID = txtCustomerID.Text,
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
                testWeformDBEntities.Customers.Add(MyCustomer);
                testWeformDBEntities.SaveChanges();
                Response.Redirect("Customer.aspx");
            }
  


        }

        protected void btnCancelAddCustomer_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customer.aspx");
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            var cust = testWeformDBEntities.Customers.FirstOrDefault(c => c.CustomerID == txtCustomerID.Text);
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
            var cust = testWeformDBEntities.Customers.FirstOrDefault(c => c.ContactName == txtContactName.Text);
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