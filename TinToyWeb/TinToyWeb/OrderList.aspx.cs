using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//
using TinToy;
using System.Data;

namespace TinToyWeb
{
    public partial class OrderList : System.Web.UI.Page
    {
        TinToy.Customer _cus;
        protected void Page_Load(object sender, EventArgs e)
        {
            var x = Session["customer"];
            if (x != null && !string.IsNullOrEmpty(x.ToString()))
            {
                _cus = (TinToy.Customer)Session["customer"];
                lblLogin.Text = _cus.FirstName + " " + _cus.LastName;
            }
            else
            {
            }
        }
    }
}