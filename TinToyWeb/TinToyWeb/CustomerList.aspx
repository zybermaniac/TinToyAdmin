<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerList.aspx.cs" Inherits="TinToyWeb.CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="gdCustomerList" AllowPaging="True" AllowSorting="True" OnPageIndexChanging="gridView_PageIndexChanging" OnSorting="gridView_Sorting" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
