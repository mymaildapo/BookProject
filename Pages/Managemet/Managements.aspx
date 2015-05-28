<%@ Page Title="" Language="C#" MasterPageFile="MasterPageExtra.master" AutoEventWireup="true" CodeFile="Managements.aspx.cs" Inherits="Pages_Managemet_Managements" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div>
    
        <p>
            Name:</p>
        <p>
            <asp:TextBox ID="txtName" runat="server" CssClass="inputs"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        </p>
        <p>
            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </p>
         <p>
             &nbsp;</p>
    
         <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ID" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Width="328px">
             <AlternatingRowStyle BackColor="White" />
             <Columns>
                 <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                 <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                 <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
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
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BookDBConnectionString %>" DeleteCommand="DELETE FROM [BookType] WHERE [ID] = @ID" InsertCommand="INSERT INTO [BookType] ([Name]) VALUES (@Name)" SelectCommand="SELECT * FROM [BookType]" UpdateCommand="UPDATE [BookType] SET [Name] = @Name WHERE [ID] = @ID">
             <DeleteParameters>
                 <asp:Parameter Name="ID" Type="Int32" />
             </DeleteParameters>
             <InsertParameters>
                 <asp:Parameter Name="Name" Type="String" />
             </InsertParameters>
             <UpdateParameters>
                 <asp:Parameter Name="Name" Type="String" />
                 <asp:Parameter Name="ID" Type="Int32" />
             </UpdateParameters>
         </asp:SqlDataSource>
    
    </div>
</asp:Content>

