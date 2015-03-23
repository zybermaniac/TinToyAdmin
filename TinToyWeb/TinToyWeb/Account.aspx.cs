using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TinToyWeb
{
    public partial class Account : System.Web.UI.Page
    {
        private TinToy.Customer _cus;
        protected void Page_Load(object sender, EventArgs e)
        {
            var x = Session["customer"];
            if (x != null && !string.IsNullOrEmpty(x.ToString()))
            {
                _cus = (TinToy.Customer)Session["customer"];
                lblName.Text = _cus.FirstName + " " + _cus.LastName;
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}