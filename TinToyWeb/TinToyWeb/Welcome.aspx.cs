using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//
using TinToy;

namespace TinToyWeb
{
    public partial class Welcome : System.Web.UI.Page
    {
        private Customer _cus;
        protected void Page_Load(object sender, EventArgs e)
        {
            var x = Session["customer"];
            if (x != null)
            {
                _cus = (Customer)Session["customer"];
                lblFirstName.Text = _cus.FirstName;
                lblLastName.Text = _cus.LastName;
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}