<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPageExtra.master" AutoEventWireup="true" CodeFile="ShoppingCart.aspx.cs" Inherits="Pages_ShoppingCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="pnlShoppingCart" runat="server">
</asp:Panel>
<table>
    <tr>
        <td><b>Total: </b></td>
        <td>
            <asp:Literal ID="litTotal" runat="server" Text=""></asp:Literal>
        </td>
    </tr>
    <tr>
        <td><b>Vat: </b></td>
        <td>
            <asp:Literal ID="litVat" runat="server" Text="" />
        </td>
    </tr>
    <tr>
        <td><b>Shipping: </b></td>
        <td>£ 1</td>
    </tr>
    <tr>
        <td><b>Total Amount: </b></td>
        <td>
            <asp:Literal ID="litTotalAmount" runat="server" Text="" />
        </td>
    </tr>
    <tr>
        <td>
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Default.aspx">Continue Shopping</asp:LinkButton>
            &nbsp;&nbsp; or
            <asp:Button ID="btnCheckout" runat="server" CssClass="button" PostBackUrl="~/sucees.aspx" Text="Check Out" Width="250px" />
            <br />
        </td>
    </tr>

</table>
      
</asp:Content>
