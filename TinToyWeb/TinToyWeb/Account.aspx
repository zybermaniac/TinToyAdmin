<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="TinToyWeb.Account" %>
<asp:Content ID="Content1" ContentPlaceHolderID="placeAccount" runat="server">
    <li><a href="Account.aspx">My Account</a></li>
    <li><a href="OrderList.aspx">My Orders</a></li>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="placeComment" runat="server">
    <h3>02/27/15</h3>
    <p>Here user can choose to edit personal information and shipping address.</p>
    <div class="hr-dots"> </div></asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="placeLogin" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="placeLogout" runat="server">
    <table style="width:100%">
        <colgroup>
            <col />
            <col style="width:200px;"/>
            <col style="width:50px;"/>
        </colgroup>
        <tbody>
            <tr>
                <td>&nbsp;</td>
                <td align="right"><asp:Label ID="lblLogin" runat="server"></asp:Label></td>
                <td align="right"><a href="Logout.aspx">Logout</a></td>
            </tr>
        </tbody>
    </table>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="placeMain" runat="server">
    <form id="form1" runat="server">
        <div style="text-align: center">
            <h2>Welcome&nbsp;<asp:Label ID="lblName" runat="server"></asp:Label></h2>
        </div>
        <table class="auto-style1" style="width: 480px">
            <tr>
                <td colspan="3" style="text-align: left"><h2>You Account</h2></td>
            </tr>
            <tr>
                <td class="auto-style2" style="width: 88px">&nbsp;</td>
                <td class="auto-style3" style="width: 304px">
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Registration.aspx">Edit</asp:HyperLink>
&nbsp;your personal information</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2" style="width: 88px">&nbsp;</td>
                <td class="auto-style3" style="width: 304px">
                    <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Address.aspx">Edit</asp:HyperLink>
&nbsp;your address</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</asp:Content>
