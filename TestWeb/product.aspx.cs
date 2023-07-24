using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWeb.Bootstrap
{
    public partial class product : System.Web.UI.Page
    {
        TestWeformDBEntities db = new TestWeformDBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            /*   var ProductList = from p in db.Products
                                 join s in db.Suppliers on p.ProductID equals s.SupplierID
                                 join c in db.Categories on p.ProductID equals c.CategoryID
                                 select new
                                  {
                                      p.ProductID,
                                      p.ProductName,
                                      c.CategoryName,
                                      s.ContactName,
                                      p.UnitPrice

                                  };*/
            var ProductList = from p in db.Products
                              select new
                              {
                                  p.ProductID,
                                  p.ProductName,
                                  p.Category.CategoryName,
                                  p.Supplier.ContactName,
                                  p.UnitPrice

                              };
            grd.DataSource = ProductList.ToList();
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
                e.Row.Cells[2].Text = "كود الصنف";
                e.Row.Cells[3].Text = " اسم الصنف";
                e.Row.Cells[4].Text = "اسم الفئة";
                e.Row.Cells[5].Text = " اسم المورد";
                e.Row.Cells[6].Text = " السعر";
        


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
                    lblName.Text = grd.Rows[e.RowIndex].Cells[3].Text;
                    hf.Value = grd.Rows[e.RowIndex].Cells[2].Text;

                    MultiView1.ActiveViewIndex = 1;
                }
            }


        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(hf.Value);
            db.Products.Remove(db.Products.Find(productId));
            db.SaveChanges();
            Response.Redirect("product.aspx");
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