<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="TinToyWeb.ContactUs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="placeAccount" runat="server">
    <li><a href="Account.aspx">My Account</a></li>
    <li><a href="OrderList.aspx">My Orders</a></li>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="placeComment" runat="server">
    <h3>02/20/15</h3>
    <p>Tin Toy Store website is made possible by SOMEE: An affordable instant hosting package where you can get your 
    Windows hosting account up and running within minutes.</p>
    <p class="more"><a href="http://www.somee.com">more</a></p>
    <div class="hr-dots"></div>
</asp:Content>
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
<asp:Content ID="Content5" ContentPlaceHolderID="placeMain" runat="server">
    <h4>Thank you for visitng us.</h4>
    <p>Hello all, my name is Thanya Moolmuang. I was the one who created this project. The main purpose of this project is to put various code snippets into a collection of codes for education and references. 
        Hopefully, they are very useful to many beginning level C# programmers (and hopefully intermediate level as well). The code is written in ASP.NET web form with C# using Visual Studio 2013, .NET framework 4.5. 
        Database for the website is created using database object resides in |DataDirectory|. I did not put too much work into the cosmetic side. I just tried to make it simple and clean.
        So please feel free to modify and add more on your own.</p>

     <p>Please feel free to copy this code and use it as you please. 
        Credit to all programmers on codeproject.com, stackoverflow.com, planet-source-code.com. Love you guys. Any questions, suggestions please write me at <a href="mailto:zybermaniac@yahoo.com?subject=TinToyStore">zybermaniac@yahoo.com</a> Enjoy and have a nice day.
        </p>
</asp:Content>