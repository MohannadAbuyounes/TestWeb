using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWeb
{
    public partial class categoies : System.Web.UI.Page
    {
        TestWeformDBEntities db = new TestWeformDBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            var catList = from cat in db.Categories
                               select new
                               {
                                   cat.CategoryID,
                                   cat.CategoryName,
                                   cat.Description,
                               

                               };
            grd.DataSource = catList.ToList();
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
                e.Row.Cells[2].Text = "كود الفئة";
                e.Row.Cells[3].Text = " اسم الفئة";
                e.Row.Cells[4].Text = "الوصف";
             


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


            db.Categories.Remove(db.Categories.Find(hf.Value));
            db.SaveChanges();
            Response.Redirect("Categorys.aspx");
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