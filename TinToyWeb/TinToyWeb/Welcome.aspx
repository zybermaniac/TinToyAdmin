<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="TinToyWeb.Welcome" %>
<asp:Content ID="Content3" ContentPlaceHolderID="placeLogout" runat="server">
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
<asp:Content ID="Content1" ContentPlaceHolderID="placeMain" runat="server">
    <form id="form1" runat="server">
        <div style="text-align: center">
            <h2>Welcome&nbsp;<asp:Label ID="lblName" runat="server"></asp:Label></h2>
        </div>
        <p>From novelty and classic to unusual and usual – this is what you will find at Tin Toy Store. There is something collectible for everyone.</p>
    </form>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="placeComment" runat="server">
    <h3>02/19/15</h3>
    <p>Once a registered user logged in 2 more selections on the left panel will be showned (My Account, and My Orders). Now user can manage their own account or view related orders.</p>
    <div class="hr-dots"> </div>
    <p>Technical: Typical welcome page greets a user by firstname and lastname. Once a registered user is logged-in the session called "customer" is created. This session value contains a Customer class object.</p>
    <div class="hr-dots"> </div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="placeAccount" runat="server">
    <li><a href="Account.aspx">My Account</a></li>
    <li><a href="OrderList.aspx">My Orders</a></li>
</asp:Content>