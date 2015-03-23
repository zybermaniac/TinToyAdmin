using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TinToyWeb
{
    public partial class Default : System.Web.UI.Page
    {
        TinToy.Customer _cus;
        protected void Page_Load(object sender, EventArgs e)
        {
            var x = Session["customer"];
            if (x != null && !string.IsNullOrEmpty(x.ToString()))
            {
                _cus = (TinToy.Customer)Session["customer"];
                lblLogin.Text = _cus.FirstName + " " + _cus.LastName;
                ((ContentPlaceHolder)Page.Master.FindControl("placeLogin")).Visible = false;
                ((ContentPlaceHolder)Page.Master.FindControl("placeLogout")).Visible = true;
                ((ContentPlaceHolder)Page.Master.FindControl("placeAccount")).Visible = true;
            }
            else
            {
                ((ContentPlaceHolder)Page.Master.FindControl("placeLogin")).Visible = true;
                ((ContentPlaceHolder)Page.Master.FindControl("placeLogout")).Visible = false;
                ((ContentPlaceHolder)Page.Master.FindControl("placeAccount")).Visible = false;
            }
        }
    }
}