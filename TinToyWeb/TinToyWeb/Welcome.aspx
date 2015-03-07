<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="TinToyWeb.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <%-- this will redirect to login page in 5 seconds after session timeout --%>
    <meta http-equiv="refresh" content="5; URL=Login.aspx" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 281px;
        }
        .auto-style3 {
            width: 337px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        Welcome
        <asp:Label ID="lblFirstName" runat="server"></asp:Label>
&nbsp;<asp:Label ID="lblLastName" runat="server"></asp:Label>
        </div>
        <table class="auto-style1">
            <tr>
                <td colspan="3" style="text-align: center">What can we do for you today?</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/ProductList.aspx">Browse</asp:HyperLink>
&nbsp;our store</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Registration.aspx">Edit</asp:HyperLink>
&nbsp;your information</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/CustomerList.aspx">View</asp:HyperLink>
&nbsp;orders</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Login.aspx">Logout</asp:HyperLink>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
