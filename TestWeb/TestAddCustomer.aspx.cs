using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWeb
{
    public partial class AddCustomer : System.Web.UI.Page
    {
        TestWeformDBEntities db = new TestWeformDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var MyLINQList = from customerTable in db.Customers select customerTable;
            grd.DataSource = MyLINQList.ToList();
            grd.DataBind();
        }

        protected void btnAddCustomer_Click(object sender, EventArgs e)
        {

         /*   string customerID = txtContactName.Text;

            if (customerID.Length >= 3)
            {
                string firstThreeChars = customerID.Substring(0, 3);
                Console.WriteLine(firstThreeChars);
            }*/
            var OAddCustomer = new Customer
            {
                CustomerID = "01",
                CompanyName=txtCompanyName.Text,
                ContactName=txtContactName.Text,
                ContactTitle=txtContactTitle.Text,
                Address=txtAddress.Text,
                City=txtCity.Text,
                Region = txtRegion.Text,
                PostalCode = txtPostalCode.Text,
                Country = txtCountry.Text,
                Phone = txtPhone.Text,
                Fax = txtFax.Text,
            };
            db.Customers.Add(OAddCustomer);
            db.SaveChanges();

        }

        protected void btnUpDate_Click(object sender, EventArgs e)
        {
            var MyCustomerUpDate = db.Customers.Find("01");
            MyCustomerUpDate.CompanyName = "Mohannad Hassan";
            db.SaveChanges ();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            var MyCustomerDel = db.Customers.Find("01");
            db.Customers.Remove(MyCustomerDel);
            db.SaveChanges();
        }
    }
}