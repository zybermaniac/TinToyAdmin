<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Address.aspx.cs" Inherits="TinToyWeb.Address" %>
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
        <table class="auto-style1">
            <tr>
                <td colspan="3">
                    <asp:Label ID="lblResponse" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Label ID="lblAddress" runat="server" Text="Please complete your address information before proceeding"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="width: 150px">&nbsp;</td>
                <td class="auto-style5" style="width: 199px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2" align="right" style="width: 150px">Address Line 1:</td>
                <td class="auto-style5" style="width: 199px">
                    <asp:TextBox ID="txtLine1" runat="server" Width="175px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLine1" ErrorMessage="address is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" align="right" style="width: 150px">Address Line 2:</td>
                <td class="auto-style5" style="width: 199px">
                    <asp:TextBox ID="txtLine2" runat="server" Width="175px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2" align="right" style="width: 150px">City:</td>
                <td class="auto-style5" style="width: 199px">
                    <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCity" ErrorMessage="city is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" align="right" style="width: 150px">State:</td>
                <td class="auto-style5" style="width: 199px">
                    <asp:DropDownList ID="ddState" runat="server">
                    </asp:DropDownList>
                </td>
                <td>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddState" ErrorMessage="state is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" align="right" style="width: 150px">Zipcode:</td>
                <td class="auto-style5" style="width: 199px">
                    <asp:TextBox ID="txtZip" runat="server" Width="93px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtZip" ErrorMessage="zipcode is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="width: 150px"></td>
                <td class="auto-style6" style="width: 199px">
                    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Save" Width="103px" />
                    <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" Width="76px" CausesValidation="False" />
                </td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style2" style="width: 150px">&nbsp;</td>
                <td class="auto-style5" style="width: 199px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="placeComment" runat="server">
    <h3>02/22/15</h3>
    <p>If the address information was not entered at the time of registration, the system will bring user to address page. When in edit mode a user can edit primary shipping address. Later on we will include a feature where a user can have multiple addresses, and only one address can be set to a primary shipping address. The database table is already designed for this as well.</p>    <div class="hr-dots"> </div>
    <p>Technical: Again, the CausesValidation for cancel button is set to false so that it will ignore RequireFieldValidators. ContentPlaceHolder "placeLogout", and "placeLogin" will be visible according to the Customer object from the session. Submit button text will be shown either "Save" or "Update" according to the usage intention.</p>
    <div class="hr-dots"> </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="placeLogin" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="placeAccount" runat="server">
    <li><a href="Account.aspx">My Account</a></li>
    <li><a href="OrderList.aspx">My Orders</a></li>
</asp:Content>