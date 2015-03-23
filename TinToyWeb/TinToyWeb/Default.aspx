<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TinToyWeb.Default" %>
<asp:Content ID="Content3" ContentPlaceHolderID="placeLogin" runat="server">
    <table style="width:100%">
        <colgroup>
            <col />
            <col style="width:60px;"/>
            <col style="width:60px;"/>
        </colgroup>
        <tbody>
            <tr>
                <td>&nbsp;</td>
                <td align="right"><a href="Login.aspx">Login</a></td>
                <td align="right"><a href="Registration.aspx">Register</a></td>
            </tr>
        </tbody>
    </table>
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
<asp:Content ID="Content1" ContentPlaceHolderID="placeMain" runat="server">
     <h2>Welcome to Our Store!</h2>
     <p>Toys are objects for the imagination, the physical things children manipulate in the real world as their minds race with fantastic scenarios and secret adventures. Toys don’t have to be complicated in design or made of expensive materials. Indeed, the best toys are often the simplest, used way past their breaking points, which makes collecting vintage toys in good condition a challenge.</p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="placeAccount" runat="server">
    <li><a href="Account.aspx">My Account</a></li>
    <li><a href="OrderList.aspx">My Orders</a></li>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="placeComment" runat="server">
    <h3>02/10/15</h3>
    <p>This Web Forms Masterpage was created by using a template from Free Website Templates. We picked this particular template mainly because of its simplicity. Five contentPlaceHolders are created. Two are on the left panel, and three are on the right (main) panel.</p>
    <p class="more"><a href="http://www.freewebsitetemplates.com">more</a></p>
    <div class="hr-dots"></div>
    <p>User can either login or register here by click on the links. Notice the left panel is now showing only 3 selections, Home, Products, and Contact us. Once a user is logged into the site there will be 2 more selections.</p>
    <div class="hr-dots"></div>
</asp:Content>



