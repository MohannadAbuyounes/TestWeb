using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWeb
{
    public partial class updateCustomer : System.Web.UI.Page
    {
        TestWeformDBEntities testWeformDBEntities = new TestWeformDBEntities();
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
                    txtCustomerID.Text = Request.QueryString["id"];
                    var MyCust = testWeformDBEntities.Customers.FirstOrDefault(c => c.CustomerID == txtCustomerID.Text);
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

        protected void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var updateCust = testWeformDBEntities.Customers.Find(Request.QueryString["id"]);
            updateCust.CompanyName= txtCompanyName.Text  ;
            updateCust.ContactName= txtContactName.Text  ;
            updateCust.ContactTitle=  txtContactTitle.Text ;
            updateCust.Address= txtAddress.Text ;
            updateCust.City= txtCity.Text  ;
            updateCust.Region= txtRegion.Text ;
            updateCust.PostalCode  =txtPostalCode.Text  ;
            updateCust.Country=txtCountry.Text  ;
            updateCust.Phone = txtPhone.Text  ;
            updateCust.Fax= txtFax.Text  ;
            testWeformDBEntities.SaveChanges();
            Response.Redirect("Customer.aspx");

        }

        protected void btnCancelAddCustomer_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customer.aspx");
        }
    }
}