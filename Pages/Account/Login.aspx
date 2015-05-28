<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPageExtra.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Pages_Account_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h4>Log In</h4>
<hr />
 <p>
    <asp:Literal ID="litStatusMessage" runat="server" />
</p>
<asp:Label ID="Label1" runat="server" AssociatedControlID="txtUserName">User name</asp:Label>
<br />
<asp:TextBox ID="txtUserName" runat="server" CssClass="inputs" />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtUserName" ErrorMessage="*"></asp:RequiredFieldValidator>
<br />
<asp:Label ID="Label2" runat="server" AssociatedControlID="txtPassword">Password</asp:Label>
<br />
<asp:TextBox ID="txtPassword" runat="server" CssClass="inputs" TextMode="Password" />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtPassword" ErrorMessage="*"></asp:RequiredFieldValidator>
<br />
<asp:Button ID="btnSignIn" runat="server" CssClass="button" OnClick="btnSignIn_OnClick" Text="Log in" />
    <div style="clear: both; background-color: #FFFFFF;"></div>
</asp:Content>

