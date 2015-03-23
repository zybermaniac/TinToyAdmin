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
    public partial class Login : System.Web.UI.Page
    {
        private TinToy.Address _add;
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["customer"] = string.Empty;
            Session["address"] = string.Empty;
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            boClsCustomer boCus = new boClsCustomer();
            ErrorMessage err = new ErrorMessage();
            TinToy.Customer cus = boCus.GetCustomerByLogin(txtLogin.Text, ref err);
            if (string.IsNullOrEmpty(cus.Login))
            {
                lblResponse.Text = err.Message;
            }
            else
            {
                if (cus.Password != txtPassword.Text)
                {
                    lblResponse.Text = "Incorrect password!";
                }
                else
                {
                    Session["customer"] = cus;

                    //check address completion
                    boClsAddress boAddress = new boClsAddress();
                    _add = boAddress.GetPrimaryAddressByCustomerID(cus.ID, ref err);
                    if (string.IsNullOrEmpty(err.Message))
                    {
                        Session["address"] = _add;
                        Response.Redirect("Welcome.aspx");
                    }
                    else
                    {
                        //need to fill in address
                        Response.Redirect("Address.aspx");
                    }
                }
            }
        }
    }
}