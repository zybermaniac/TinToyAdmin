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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["customer"] = string.Empty;
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            boClsCustomer boCus = new boClsCustomer();
            ErrorMessage err = new ErrorMessage();
            Customer cus = boCus.GetCustomerByLogin(txtLogin.Text, ref err);
            if (cus.Login == null)
            {
                Response.Write(err.Message);
            }
            else
            {
                if (cus.Password != txtPassword.Text)
                {
                    Response.Write("Incorrect password!");
                }
                else
                {
                    Session["customer"] = cus;
                    Response.Redirect("Welcome.aspx");
                }
            }
        }
    }
}