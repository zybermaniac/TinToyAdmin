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
        protected void Page_Load(object sender, EventArgs e)
        {
            Product prod = new Product();
            boClsProduct boProd = new boClsProduct();
            ErrorMessage err = new ErrorMessage();
            DataTable dt = boProd.SearchProduct(prod, ref err);
            if (err.Message != null)
            {
                Response.Write(err.Message);
            }
            else
            {
                gdProduct.DataSource = dt;
                gdProduct.DataBind();
            }
        }
        protected void gridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gdProduct.PageIndex = e.NewPageIndex;
            gdProduct.DataBind();
        }
        public string GetSortDirection(string SortExpression)
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
                DataView dv = new DataView(dt);
                dv.Sort = e.SortExpression + " " + order;
                gdProduct.DataSource = dv;
                gdProduct.DataBind();
            }
        } 
    }
}