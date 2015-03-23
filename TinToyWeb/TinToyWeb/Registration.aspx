<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="TinToyWeb.Registration" %>
<asp:Content ID="Content2" ContentPlaceHolderID="placeLogin" runat="server">
</asp:Content>
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
    <div>    
        <table class="auto-style1">
            <tr>
                <td colspan ="3" align="center"><asp:Label ID="lblResponse" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td class="auto-style3" style="width: 131px" align="right">Username:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLogin" ErrorMessage="username is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4" style="width: 131px" align="right">Password:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="password is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4" style="width: 131px" align="right">Confirm Password:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtRPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtRPassword" ErrorMessage="confirm password is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtRPassword" ErrorMessage="confirm password must be the same" ForeColor="Red"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4" style="width: 131px" align="right">First Name:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtFirstName" ErrorMessage="first name is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4" style="width: 131px" align="right">Last Name:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtLastName" ErrorMessage="last name is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4" style="width: 131px" align="right">Email:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtEmail" ErrorMessage="email is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="invalid email format" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4" style="width: 131px" align="right">Phone:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtPhone" runat="server" TextMode="Phone"></asp:TextBox>
                </td>
                <td style="margin-left: 40px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtPhone" ErrorMessage="phone is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7" style="width: 131px"></td>
                <td class="auto-style8">
                    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
                    <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" CausesValidation="False" />
                </td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
        </table>    
    </div>
    </form>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="placeComment" runat="server">
    <h3>02/18/15</h3>
    <p>Every fields must be entered. When in edit mode: Username and password cannot be edited here. Later on we will add an option where user can change password.</p>    <div class="hr-dots"> </div>
    <p>Technical: For speed and educational purposes we implemented RequiredFieldValidators feature. And for each field we bound it to appropriate controls along with error messages. The CausesValidation for cancel button is set to false so that it will ignore RequireFieldValidators. ContentPlaceHolder "placeLogout", and "placeLogin" will be visible according to the Customer object from the session. Submit button text will be shown either "Save" or "Update" according to the usage intention.</p>
    <div class="hr-dots"> </div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="placeAccount" runat="server">
    <li><a href="Account.aspx">My Account</a></li>
    <li><a href="OrderList.aspx">My Orders</a></li>
</asp:Content>
