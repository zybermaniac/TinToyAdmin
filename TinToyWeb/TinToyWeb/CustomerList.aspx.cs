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
    public partial class CustomerList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TinToy.Customer cus = new TinToy.Customer();
            boClsCustomer boCus = new boClsCustomer();
            ErrorMessage err = new ErrorMessage();
            DataTable dt = boCus.SearchCustomer(cus, ref err);
            if (err.Message != null)
            {
                Response.Write(err.Message);
            }
            else
            {
                gdCustomerList.DataSource = dt;
                gdCustomerList.DataBind();
            }
        }
        protected void gridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gdCustomerList.PageIndex = e.NewPageIndex;
            gdCustomerList.DataBind();
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
            DataTable dt = gdCustomerList.DataSource as DataTable;
            if (dt != null)
            {
                DataView dv = new DataView(dt);
                dv.Sort = e.SortExpression + " " + order;
                gdCustomerList.DataSource = dv;
                gdCustomerList.DataBind();
            }
        } 
    }
}