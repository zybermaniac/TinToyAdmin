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
    public partial class ProductList : System.Web.UI.Page
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
            TinToy.Product prod = new TinToy.Product();
            boClsProduct boProd = new boClsProduct();
            ErrorMessage err = new ErrorMessage();
            DataTable dt = boProd.SearchProduct(prod, ref err);
            dt = boProd.SearchProduct(prod, ref err);
            if (string.IsNullOrEmpty(err.Message))
            {
                gdProduct.DataSource = dt;
                gdProduct.DataBind();
            }
            else
            {
                //todo:
                Response.Write(err.Message);
            }
        }
        protected void gridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gdProduct.PageIndex = e.NewPageIndex;
            gdProduct.DataBind();
        }
        private string GetSortDirection(string SortExpression)
        {
            if (ViewState[SortExpression] == null)
            {
                ViewState[SortExpression] = "Asc";
            }
            else
            {
                ViewState[SortExpression] = ViewState[SortExpression].ToString() == "Desc" ? "Asc" : "Desc";
            }
            return ViewState[SortExpression].ToString();
        }
        protected void gridView_Sorting(object sender, GridViewSortEventArgs e)
        {
            string order = GetSortDirection(e.SortExpression);
            DataTable dt = gdProduct.DataSource as DataTable;
            if (dt != null)
            {
                dt.DefaultView.Sort = e.SortExpression + " " + order;
                gdProduct.DataSource = dt;
                gdProduct.DataBind();
            }
        }            
        protected void gdProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdProduct.SelectedRow;
            string id = row.Cells[1].Text;
            Session["productID"] = id;
            Response.Redirect("ProductDetail.aspx");
        }       
    }
}