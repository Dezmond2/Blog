<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Blog.WebUI.Admin.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    Welcome
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPHolder" runat="server">
    <asp:Button ID="Login" Text="Login" OnClick="Login_Click"  runat="server"/>
</asp:Content>
