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
    public partial class Registration : System.Web.UI.Page
    {
        private TinToy.Customer _cus;
        protected void Page_Load(object sender, EventArgs e)
        {
            var x = Session["customer"];
            if (x != null && !string.IsNullOrEmpty(x.ToString()))
            {
                _cus = (TinToy.Customer)Session["customer"];
                if (!IsPostBack)
                {
                    //update existing
                    txtLogin.Text = _cus.Login;
                    txtLogin.Enabled = false;
                    txtPassword.Enabled = false;
                    txtRPassword.Enabled = false;
                    RequiredFieldValidator2.Enabled = false;
                    RequiredFieldValidator3.Enabled = false;
                    txtFirstName.Text = _cus.FirstName;
                    txtLastName.Text = _cus.LastName;
                    txtEmail.Text = _cus.Email;
                    txtPhone.Text = _cus.Phone;
                    btnSubmit.Text = "Update";
                }
                ((ContentPlaceHolder)Page.Master.FindControl("placeLogout")).Visible = true;
                ((ContentPlaceHolder)Page.Master.FindControl("placeAccount")).Visible = true;
            }
            else
            {
                ((ContentPlaceHolder)Page.Master.FindControl("placeLogout")).Visible = false;
                ((ContentPlaceHolder)Page.Master.FindControl("placeAccount")).Visible = false;
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ErrorMessage err = new ErrorMessage();
            boClsCustomer boCus = new boClsCustomer();
            if (IsPostBack && btnSubmit.Text == "Update")
            {
                //update existing
                _cus.FirstName = txtFirstName.Text;
                _cus.LastName = txtLastName.Text;
                _cus.Email = txtEmail.Text;
                _cus.Phone = txtPhone.Text;

                if (boCus.UpdateCustomer(_cus, ref err))
                {
                    if (string.IsNullOrEmpty(err.Message))
                    {
                        Session["customer"] = _cus;
                        Response.Redirect("Account.aspx");
                    }
                    else
                    {
                        lblResponse.Text = err.Message;
                    }
                }
            }

            if (IsPostBack && btnSubmit.Text == "Submit")
            {
                //crete new
                TinToy.Customer customer = new TinToy.Customer();
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
                    lblResponse.Text = err.Message;
                }
            }
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {         
            if (btnSubmit.Text == "Update")
            {
                //if from update existing, send back to account page
                Response.Redirect("Account.aspx");
            }
            else
            {
                //if from create new, send back to welcome page
                Response.Redirect("Default.aspx");
            }
        }
    }
}