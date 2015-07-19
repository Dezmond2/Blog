<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Blog.WebUI.Admin.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    Login
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPHolder" runat="server">
    <asp:Login
        ID="MainLogin"
        runat="server"
        DestinationPageUrl="~/Users.aspx"
        OnLoggingIn="MainLogin_LoggingIn">
    </asp:Login>
</asp:Content>
