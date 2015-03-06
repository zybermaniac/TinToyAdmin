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
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;            
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