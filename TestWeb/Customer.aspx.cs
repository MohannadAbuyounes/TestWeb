using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWeb
{
    public partial class Customer1 : System.Web.UI.Page
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
                var CustomerList = from customerList in db.Customers
                                   select new
                                   {
                                       customerList.CustomerID,
                                       customerList.CompanyName,
                                       customerList.ContactName,
                                       customerList.City,
                                       customerList.Country,

                                   };
                grd.DataSource = CustomerList.ToList();
                grd.DataBind();
            }
           
        }

        protected void grd_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[2].Text = "كود العميل";
                e.Row.Cells[3].Text = " الشركة";
                e.Row.Cells[4].Text = "اسم العميل";
                e.Row.Cells[5].Text = " المدينة";
                e.Row.Cells[6].Text = " الدولة";

            }
        }

        protected void grd_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {


            HttpCookie httpCookie = new HttpCookie("cooklogin");
            httpCookie = Request.Cookies["cooklogin"];
            if (httpCookie == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                if (httpCookie["username"] == HttpUtility.UrlDecode("ADMIN"))
                {
                    lblName.Text = grd.Rows[e.RowIndex].Cells[4].Text;
                    hf.Value = grd.Rows[e.RowIndex].Cells[2].Text;
                    MultiView1.ActiveViewIndex = 1;
                }
            }
            

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            var MyCust = db.Customers.Find(hf.Value);
            db.Customers.Remove(MyCust);
            db.SaveChanges();
            Response.Redirect("Customer.aspx");
            MultiView1.ActiveViewIndex = 0;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

     
    }
}