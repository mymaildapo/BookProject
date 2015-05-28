<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPageExtra.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Pages_Account_Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h4>Register a new user</h4>
<hr />
<p>
    <asp:Literal ID="litStatusMessage" runat="server" />
</p>
User name:<br />
<asp:TextBox ID="txtUserName" runat="server" CssClass="inputs" />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName" ErrorMessage="*"></asp:RequiredFieldValidator>
<br />
Password:
<br />
<asp:TextBox ID="txtPassword" runat="server" CssClass="inputs" TextMode="Password" />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="*"></asp:RequiredFieldValidator>
<br />
Confirm password:
<br />
<asp:TextBox ID="txtConfirmPassword" runat="server" CssClass="inputs" TextMode="Password" />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtConfirmPassword" ErrorMessage="*"></asp:RequiredFieldValidator>
<br />
First Name:<br />
<asp:TextBox ID="txtFirstName" runat="server" CssClass="inputs" />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtFirstName" ErrorMessage="*"></asp:RequiredFieldValidator>
<br />
Last Name:<br />
<asp:TextBox ID="txtLastName" runat="server" CssClass="inputs" />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtLastName" ErrorMessage="*"></asp:RequiredFieldValidator>
<br />
Address:<br />
<asp:TextBox ID="txtAddress" runat="server" CssClass="inputs" />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtAddress" ErrorMessage="*"></asp:RequiredFieldValidator>
<br />
Postal Code:<br />
<asp:TextBox ID="txtPostalCode" runat="server" CssClass="inputs" />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtPostalCode" ErrorMessage="*"></asp:RequiredFieldValidator>
    <br />
    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtConfirmPassword" ControlToValidate="txtPassword" ErrorMessage="Passwords must match"></asp:CompareValidator>
<br />
<p>
    <asp:Button ID="btnRegister" runat="server" CssClass="button" OnClick="btnRegister_Click" Text="Register" Width="150px" />
</p>
    <div style="clear: both; background-color: #FFFFFF;"></div>
</asp:Content>

