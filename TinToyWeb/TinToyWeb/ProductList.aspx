<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="TinToyWeb.ProductList" %>
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
  <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gdProduct" runat="server" OnSelectedIndexChanged="gdProduct_SelectedIndexChanged" CellPadding="4" ForeColor="Black" GridLines="Horizontal" AllowPaging="True" AllowSorting="True" OnPageIndexChanging="gridView_PageIndexChanging" OnSorting="gridView_Sorting" AutoGenerateColumns="False" PageSize="5" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" >
            <Columns>
                <asp:ButtonField Text="Select" CommandName="Select" />
                <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                <asp:TemplateField HeaderText="Image">
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" Width="75px" Height="75px" ImageUrl='<%# "ImageHandler.ashx?ID="+ Eval("ID") %>'/>
                    </ItemTemplate>
                </asp:TemplateField>                 
                <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                <asp:BoundField DataField="Availability" HeaderText="Availability" SortExpression="Availability" ItemStyle-HorizontalAlign="Center" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
       </div>
    </form>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="placeComment" runat="server">
    <h3>03/01/15</h3>
    <p>All the products from our store displays neatly in the grid along with its miniature picture. Since this is a small store and we don't have that many toys (10-20 the most) we have decided to list them all out here. The display number per page can be set. Right now we are setting it to 5.</p>
    <div class="hr-dots"> </div>
    <p>Technical: User can alphabetically sort each column by clicking on the header. It will also toggle sort direction alternatively between acending and decending automatically.</p>
    <div class="hr-dots"> </div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="placeAccount" runat="server">
    <li><a href="Account.aspx">My Account</a></li>
    <li><a href="OrderList.aspx">My Orders</a></li>
</asp:Content>