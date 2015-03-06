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
            Customer cus = new Customer();
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
        private string ConvertSortDirectionToSql(SortDirection sortDirection)
        {
            string newSortDirection = String.Empty;
            switch (sortDirection)
            {
                case SortDirection.Ascending:
                    newSortDirection = "ASC";
                    break;

                case SortDirection.Descending:
                    newSortDirection = "DESC";
                    break;
            }
            return newSortDirection;
        }
        protected void gridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gdCustomerList.PageIndex = e.NewPageIndex;
            gdCustomerList.DataBind();
        }
        protected void gridView_Sorting(object sender, GridViewSortEventArgs e)
        {
            DataTable dataTable = gdCustomerList.DataSource as DataTable;

            if (dataTable != null)
            {
                DataView dataView = new DataView(dataTable);
                dataView.Sort = e.SortExpression + " " + ConvertSortDirectionToSql(e.SortDirection);

                gdCustomerList.DataSource = dataView;
                gdCustomerList.DataBind();
            }
        }
    }
}