using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWeb
{
    public partial class TestLINQ : System.Web.UI.Page
    {
        TestWeformDBEntities db = new TestWeformDBEntities();


        //  LINQولكن يوجد افضل منها من ناحيه الداء والسرعه وهي  if & else الطريقه العادية مع

        /*   protected void Page_Load(object sender, EventArgs e)
          {
              var MyCustomerTable = db.Customers.ToList();

              grd.DataSource = MyCustomerTable;
              grd.DataBind();
          }


           protected void btuContrySarech_Click(object sender, EventArgs e)
            {
                var MyCustomerTable = db.Customers.ToList();
                if (txtContrySarech.Text == "")
                {
                    grd.DataSource = MyCustomerTable;
                    grd.DataBind();
                }
                else
                {
                    grd.DataSource = MyCustomerTable.Where(c => c.Country == txtContrySarech.Text);
                    grd.DataBind();
                }

            }*/
        protected void Page_Load(object sender, EventArgs e)
        {
            var MyLINQList = from customerTable in db.Customers select customerTable;
            grd.DataSource = MyLINQList.ToList();
            grd.DataBind();

        }
        protected void btnContrySarech_Click(object sender, EventArgs e)
        {
            var MyLINQListInBut = from customerTable in db.Customers 
                                  where customerTable.Country == txtContrySarech.Text 
                                  select customerTable;
            grd.DataSource = MyLINQListInBut.ToList();
            grd.DataBind();
        }

        protected void btnAll_Click(object sender, EventArgs e)
        {
            txtContrySarech.Text = "";
            var MyLINQList = from customerTable in db.Customers select customerTable;
            grd.DataSource = MyLINQList.ToList();
            grd.DataBind();
        }

        protected void txtContrySarech_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnShowColums_Click(object sender, EventArgs e)
        {
            txtContrySarech.Text = "";
            var MyLINQList = from customerTable in db.Customers 
                             select new { customerTable.ContactName, customerTable.Address,
                                 customerTable.Country,customerTable.Phone};
            grd.DataSource = MyLINQList.ToList();
            grd.DataBind();
        }

        protected void btnNameSarech_Click(object sender, EventArgs e)
        {
            var MyLINQListInBut = from customerTable in db.Customers
                                  where customerTable.ContactName.Contains(txtContrySarech.Text)
                                  select customerTable;
            grd.DataSource = MyLINQListInBut.ToList();
            grd.DataBind();
        }

        protected void btnSort_Click(object sender, EventArgs e)
        {
            txtContrySarech.Text = "";
            var MyProductList = from productList in db.Products
                                orderby productList.UnitPrice descending
                                select productList;
            grd.DataSource = MyProductList.ToList();
            grd.DataBind();
        }
    }
}
