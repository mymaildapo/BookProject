<%@ Page Title="" Language="C#" MasterPageFile="MasterPageExtra.master" AutoEventWireup="true" CodeFile="ManageBooksDetails.aspx.cs" Inherits="Pages_Managemet_ManageBooksDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<br />
<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="ID">
</asp:DropDownList>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BookDBConnectionString %>" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [BookType]"></asp:SqlDataSource>
<asp:SqlDataSource ID="sdsProduct" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:BookDBConnectionString %>" DeleteCommand="DELETE FROM [BookTB] WHERE [Id] = @original_Id AND [TypeID] = @original_TypeID AND [Name] = @original_Name AND [Price] = @original_Price AND [Description] = @original_Description AND (([Image] = @original_Image) OR ([Image] IS NULL AND @original_Image IS NULL)) AND [author] = @original_author" InsertCommand="INSERT INTO [BookTB] ([TypeID], [Name], [Price], [Description], [Image], [author]) VALUES (@TypeID, @Name, @Price, @Description, @Image, @author)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [BookTB] WHERE ([TypeID] = @TypeID)" UpdateCommand="UPDATE [BookTB] SET [TypeID] = @TypeID, [Name] = @Name, [Price] = @Price, [Description] = @Description, [Image] = @Image, [author] = @author WHERE [Id] = @original_Id AND [TypeID] = @original_TypeID AND [Name] = @original_Name AND [Price] = @original_Price AND [Description] = @original_Description AND (([Image] = @original_Image) OR ([Image] IS NULL AND @original_Image IS NULL)) AND [author] = @original_author">
    <DeleteParameters>
        <asp:Parameter Name="original_Id" Type="Int32" />
        <asp:Parameter Name="original_TypeID" Type="Int32" />
        <asp:Parameter Name="original_Name" Type="String" />
        <asp:Parameter Name="original_Price" Type="Double" />
        <asp:Parameter Name="original_Description" Type="String" />
        <asp:Parameter Name="original_Image" Type="String" />
        <asp:Parameter Name="original_author" Type="String" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="TypeID" Type="Int32" />
        <asp:Parameter Name="Name" Type="String" />
        <asp:Parameter Name="Price" Type="Double" />
        <asp:Parameter Name="Description" Type="String" />
        <asp:Parameter Name="Image" Type="String" />
        <asp:Parameter Name="author" Type="String" />
    </InsertParameters>
    <SelectParameters>
        <asp:ControlParameter ControlID="DropDownList1" Name="TypeID" PropertyName="SelectedValue" Type="Int32" />
    </SelectParameters>
    <UpdateParameters>
        <asp:Parameter Name="TypeID" Type="Int32" />
        <asp:Parameter Name="Name" Type="String" />
        <asp:Parameter Name="Price" Type="Double" />
        <asp:Parameter Name="Description" Type="String" />
        <asp:Parameter Name="Image" Type="String" />
        <asp:Parameter Name="author" Type="String" />
        <asp:Parameter Name="original_Id" Type="Int32" />
        <asp:Parameter Name="original_TypeID" Type="Int32" />
        <asp:Parameter Name="original_Name" Type="String" />
        <asp:Parameter Name="original_Price" Type="Double" />
        <asp:Parameter Name="original_Description" Type="String" />
        <asp:Parameter Name="original_Image" Type="String" />
        <asp:Parameter Name="original_author" Type="String" />
    </UpdateParameters>
</asp:SqlDataSource>
                                                                                                                                                                                    <%--GridView1 below go to the event tab choose rowediting double click to go OnRowEditing="GridView1_RowEditing"--%><br />
<asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id" DataSourceID="sdsProduct" ForeColor="#333333" GridLines="None" OnRowEditing="GridView1_RowEditing" Width="100%">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
        <asp:BoundField DataField="TypeID" HeaderText="TypeID" SortExpression="TypeID" />
        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
        <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
        <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
        <asp:BoundField DataField="Image" HeaderText="Image" SortExpression="Image" />
        <asp:BoundField DataField="author" HeaderText="author" SortExpression="author" />
    </Columns>
    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
    <SortedAscendingCellStyle BackColor="#FDF5AC" />
    <SortedAscendingHeaderStyle BackColor="#4D0000" />
    <SortedDescendingCellStyle BackColor="#FCF6C0" />
    <SortedDescendingHeaderStyle BackColor="#820000" />
</asp:GridView>

</asp:Content>

