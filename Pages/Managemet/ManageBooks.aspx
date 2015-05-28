<%@ Page Title="" Language="C#" MasterPageFile="MasterPageExtra.master" AutoEventWireup="true" CodeFile="ManageBooks.aspx.cs" Inherits="Pages_Managemet_ManageBooks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div>
         <p>
             Name:</p>
         <p>
             <asp:TextBox ID="txtName" runat="server" CssClass="inputs"></asp:TextBox>
         </p>
         <p>
             Type:</p>
         <p>
             <asp:DropDownList ID="ddlType" runat="server" CssClass="inputs" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="ID">
             </asp:DropDownList>
             <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BookDBConnectionString %>" SelectCommand="SELECT * FROM [BookType] ORDER BY [Name]"></asp:SqlDataSource>
         </p>
         <p>
             Price:</p>
         <p>
             <asp:TextBox ID="txtPrice" runat="server" CssClass="inputs"></asp:TextBox>
             <br />
             <br />
             Author:<br />
             <asp:TextBox ID="txtAuthor" runat="server" CssClass="inputs"></asp:TextBox>
         </p>
         <p>
             Image:</p>
         <p>
             <asp:DropDownList ID="ddlImage" runat="server" CssClass="inputs" Width="270">
             </asp:DropDownList>
         </p>
         <p>
             Upload A picture<asp:FileUpload ID="FileUpload1" runat="server" />
             <asp:Button ID="btnUploadImage" runat="server" CausesValidation="False" onclick="btnUploadImage_Click" Text="Upload Image" />
         </p>
         <p>
             Description:</p>
         <p>
             <asp:TextBox ID="txtDescription" runat="server" CssClass="inputs" Height="74px" TextMode="MultiLine" Width="240px"></asp:TextBox>
         </p>
         <p>
             <asp:Button ID="btnSubmit" runat="server" CssClass="button" OnClick="btnSubmit_Click" Text="Submit" />
             <asp:Button ID="btnCancel" runat="server" CssClass="button" Text="Home" PostBackUrl="~/Pages/Managemet/ManageBooksDetails.aspx" />
         </p>
         <p>
             <asp:Label ID="lblResult" runat="server"></asp:Label>
         </p>
     </div>
</asp:Content>

