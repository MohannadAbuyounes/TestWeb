using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWeb
{
    public partial class TestPostBack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //   لعدم تكرار العناصر في كل حدث يفعل ( ! isPostback )تستخدم 
            if (!Page.IsPostBack)
            {
                ddl.Items.Add("Mohannad");
                ddl.Items.Add("Hassan");
                ddl.Items.Add("Ahmad");
                ddl.Items.Add("Hadi");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}