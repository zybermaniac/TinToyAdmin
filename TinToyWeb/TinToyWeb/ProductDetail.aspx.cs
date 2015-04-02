using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//
using TinToy;
using System.IO;

namespace TinToyWeb
{
    public partial class ProductDetail : System.Web.UI.Page
    {
        TinToy.Customer _cus;
        TinToy.Product _prod;
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
            int id = Int32.Parse(Session["productID"].ToString());
            boClsProduct boPro = new boClsProduct();
            ErrorMessage err = new ErrorMessage();
            _prod = boPro.GetProductByID(id, ref err);
            if (string.IsNullOrEmpty(err.Message))
            {
                imgProduct.Width = 220;
                imgProduct.Height = 220;
                imgProduct.ImageUrl = "ImageHandler.ashx?ID=" + id;
                lblName.Text = _prod.Name;
                lblDescription.Text = _prod.Description; 
                lblPrice.Text = "$" + _prod.Price;
                lblAvailability.Text = "in stock: " + _prod.Availability;
            }
            else
            {
                //todo: 
                Response.Write(err.Message);
            }
        }

        protected void btnBuy_Click(object sender, EventArgs e)
        {

        }

        protected void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductList.aspx");
        }
    }
}