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
    public partial class Address : System.Web.UI.Page
    {
        private TinToy.Customer _cus;
        private TinToy.Address _add;

        protected void Page_Load(object sender, EventArgs e)
        {
            var x = Session["customer"];
            if (x != null && !string.IsNullOrEmpty(x.ToString()))
            {
                _cus = (TinToy.Customer)Session["customer"];
                if (!IsPostBack)
                {
                    TinToy.AdminCode adminCode = new TinToy.AdminCode();
                    boClsAdminCode boAdminCode = new boClsAdminCode();
                    ErrorMessage err = new ErrorMessage();
                    DataTable dt = boAdminCode.GetStateList(ref err);
                    if (string.IsNullOrEmpty(err.Message))
                    {
                        ddState.DataSource = dt;
                        ddState.DataTextField = "Description";
                        ddState.DataValueField = "Code";
                        ddState.DataBind();
                        ddState.Items.Insert(0, new ListItem("<Select>", ""));
                    }
                    else
                    {
                        lblResponse.Text = err.Message;
                        return;
                    }

                    //fill up address filds
                    boClsAddress boAddress = new boClsAddress();
                    err = new ErrorMessage();
                    _add = boAddress.GetPrimaryAddressByCustomerID(_cus.ID, ref err);
                    if (string.IsNullOrEmpty(err.Message))
                    {
                        //update existing
                        lblAddress.Text = "Address for " + _cus.FirstName + " " + _cus.LastName;
                        btnSubmit.Text = "Update";
                        txtLine1.Text = _add.Line1;
                        txtLine2.Text = _add.Line2;
                        txtCity.Text = _add.City;
                        ddState.SelectedValue = _add.State;
                        txtZip.Text = _add.Zip;
                        Session["address"] = _add;
                    }
                }
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ErrorMessage err = new ErrorMessage();
            boClsAddress boAddress = new boClsAddress();
            if (IsPostBack && btnSubmit.Text == "Save")
            {
                //create new
                _add = new TinToy.Address();
                _add.Line1 = txtLine1.Text;
                _add.Line2 = txtLine2.Text;
                _add.City = txtCity.Text;
                _add.State = ddState.SelectedValue;
                _add.Zip = txtZip.Text;
                _add.CustomerID = _cus.ID;
                if (boAddress.CreateAddress(_add, ref err) != 0)
                {
                    Response.Redirect("Welcome.aspx");
                }
                else
                {
                    lblResponse.Text = err.Message;
                }
            }

            if (IsPostBack && btnSubmit.Text == "Update")
            {
                //update existing
                var x = Session["address"];
                if (!string.IsNullOrEmpty(x.ToString()))
                {
                    _add = (TinToy.Address)Session["address"];
                    _add.Line1 = txtLine1.Text;
                    _add.Line2 = txtLine2.Text;
                    _add.City = txtCity.Text;
                    _add.State = ddState.SelectedValue;
                    _add.Zip = txtZip.Text;
                    if (boAddress.UpdateAddress(_add, ref err))
                    {
                        Response.Redirect("Account.aspx");
                    }
                    else
                    {
                        lblResponse.Text = err.Message;
                    }
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
                Response.Redirect("Welcome.aspx");
            }
        }
    }
}