<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ProductDetail.aspx.cs" Inherits="TinToyWeb.ProductDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="placeAccount" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="placeComment" runat="server">
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
    <form id="form1" runat="server">
        <table style="width: 100%;">
           <colgroup>
            <col />
            <col style="width:150px;"/>
            <col style="width:50px;"/>
            </colgroup>
            <tbody>
                <tr>
                    <td rowspan ="5">
                        <asp:Image ID="imgProduct" runat="server" />
                    </td>
                    <td align="left"><h4>
                        <asp:Label ID="lblName" runat="server" Text=""></asp:Label></h4></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2" align="left">
                        <asp:Label ID="lblDescription" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="left"><h4>
                        <asp:Label ID="lblPrice" runat="server" Text=""></asp:Label></h4></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td align="left"  >
                        <asp:Label ID="lblAvailability" runat="server" Text=""></asp:Label></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Button ID="btnBuy" runat="server" Text="Buy now"  OnClick="btnBuy_Click"/></td>
                    <td>
                        <asp:Button ID="btnCancle" runat="server" Text="Cancle" OnClick ="btnCancle_Click" /></td>
                </tr>
            </tbody>
        </table>   
    </form>
</asp:Content>
