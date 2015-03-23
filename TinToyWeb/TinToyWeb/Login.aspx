<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TinToyWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="placeMain" runat="server"> 
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3" style="width: 146px">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3" style="width: 146px">&nbsp;</td>
                <td>
                    <asp:Label ID="lblResponse" runat="server" Text="" ForeColor="Red"></asp:Label></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2" style="width: 146px" align="right">Username:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLogin" ErrorMessage="username is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="width: 146px" align="right">Password:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="password is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5" style="width: 146px"></td>
                <td class="auto-style6">
                    <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" Width="100px" />
                </td>
                <td>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Registration.aspx" Target="_parent">Register</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="width: 146px">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="placeComment" runat="server">
    <h3>02/21/15</h3>
    <p>If you are new to the site please register first. If you have been here before please login.</p>
    <div class="hr-dots"></div>
</asp:Content>