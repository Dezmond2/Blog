<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="Blog.WebUI.Admin.Users" %>

<asp:Content ID="ContentHead" ContentPlaceHolderID="head" runat="server">
    Users list
</asp:Content>

<asp:Content ID="ContentMain" ContentPlaceHolderID="CPHolder" runat="server">

    <asp:ObjectDataSource ID="UsersDS"
                          runat="server"
                          TypeName="Blog.Repository.EFUserRepository"
                          SelectMethod="GetUsers"
                          UpdateMethod="UpdateUser">

        <UpdateParameters>
            <asp:Parameter Name="IsEnable" Type="Boolean" />
        </UpdateParameters>

    </asp:ObjectDataSource>

    <asp:GridView ID="gvUsers"
                  runat="server"
                  DataSourceID="UsersDS"
                  DataKeyNames="Id"
                  AllowPaging="True"
                  ForeColor="#333333"
                  GridLines="Horizontal"
                  AutoGenerateColumns="false">

        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="true" />
            <asp:BoundField DataField="FirstName" HeaderText="FirstName" ReadOnly="true" />
            <asp:BoundField DataField="LastName" HeaderText="LastName" ReadOnly="true" />
            <asp:BoundField DataField="Login" HeaderText="Login" ReadOnly="true" />
            <asp:BoundField DataField="Password" HeaderText="Password" ReadOnly="true" />
            <asp:CheckBoxField DataField="IsAdmin" HeaderText="IsAdmin" ReadOnly="true" />
            <asp:CheckBoxField DataField="IsEnable" HeaderText="IsEnable" />
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
