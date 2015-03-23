<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="OrderList.aspx.cs" Inherits="TinToyWeb.OrderList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="placeAccount" runat="server">
    <li><a href="Account.aspx">My Account</a></li>
    <li><a href="OrderList.aspx">My Orders</a></li>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="placeComment" runat="server">
    <h3>03/12/15</h3>
    <p>This feature will be implemented on the next version.</p>    <div class="hr-dots"> </div>
</asp:Content>
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
    <p>Under construction please stay tune.</p>
</asp:Content>
