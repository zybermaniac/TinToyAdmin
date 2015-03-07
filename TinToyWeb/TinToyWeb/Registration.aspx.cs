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
    public partial class wfRegistration : System.Web.UI.Page
    {
        private Customer _cus;
        protected void Page_Load(object sender, EventArgs e)
        {
            var x = Session["customer"];
            if (x != null)
            {
                _cus = (Customer)Session["customer"];
                txtFirstName.Text = _cus.FirstName;
                txtLastName.Text = _cus.LastName;
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            ErrorMessage err = new ErrorMessage();
            boClsCustomer boCus = new boClsCustomer();
            customer.Login = txtLogin.Text;
            customer.Password = txtPassword.Text;
            customer.FirstName = txtFirstName.Text;
            customer.LastName = txtLastName.Text;
            customer.Email = txtEmail.Text;
            customer.Phone = txtPhone.Text;
            if (boCus.CreateCustomer(customer, ref err) != 0)
            {                
                Response.Redirect("Login.aspx");
            }
            else
            {
                Response.Write(err.Message);
            }
        }
    }
}