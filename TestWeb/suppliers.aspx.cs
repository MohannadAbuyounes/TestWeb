using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWeb
{
    public partial class suppliers : System.Web.UI.Page
    {

        TestWeformDBEntities db = new TestWeformDBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            var supplierList = from s in db.Suppliers
                               select new
                               {
                                   s.SupplierID,
                                   s.CompanyName,
                                   s.ContactName,
                                   s.City,
                                   s.Country,
                                   s.Phone

                               };
            grd.DataSource = supplierList.ToList();
            grd.DataBind();
            HttpCookie httpCookie = new HttpCookie("cooklogin");
            httpCookie = Request.Cookies["cooklogin"];
            if (httpCookie["username"] == HttpUtility.UrlDecode("ADMIN"))
            {
                adminAdd.Visible = true;
         
            }
            else
            {
                adminAdd.Visible = false;
             
            }
        }

        protected void grd_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[2].Text = "كود المورد";
                e.Row.Cells[3].Text = " الشركة";
                e.Row.Cells[4].Text = "اسم المورد";
                e.Row.Cells[5].Text = " المدينة";
                e.Row.Cells[6].Text = " الدولة";
                e.Row.Cells[7].Text = " الهاتف";


            }
        }

        protected void grd_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {


            HttpCookie httpCookie = new HttpCookie("cooklogin");
            httpCookie = Request.Cookies["cooklogin"];
            if (httpCookie == null)
            {
                //admaincol.Visible = false;
              //  Response.Redirect("login.aspx");
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

      
            db.Suppliers.Remove(db.Suppliers.Find(hf.Value));
            db.SaveChanges();
            Response.Redirect("Suppliers.aspx");
            MultiView1.ActiveViewIndex = 0;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void grd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}