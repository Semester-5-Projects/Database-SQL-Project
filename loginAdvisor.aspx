<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginAdvisor.aspx.cs" Inherits="advisor.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="login" runat="server">
        <div>
        </div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:Label runat="server" Text="Advisor ID"></asp:Label>&nbsp;</div>
        <div class="">
            <asp:TextBox runat="server" ID="un"></asp:TextBox>&nbsp;</div>
        <div class="">
            <asp:Label runat="server" Text="Password"></asp:Label>&nbsp;</div>
        <div class="">
            <asp:TextBox runat="server" ID="pass"></asp:TextBox>&nbsp;</div>
        <div class="">&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:Button runat="server" Text="Login" OnClick="loginbt"></asp:Button>&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:Label runat="server" Text="Don't have an account?"></asp:Label>&nbsp;</div>
       <div class="wlp-whitespace-only-element-expansion">
            <asp:Button runat="server" Text="Register Here" OnClick="regbt"></asp:Button>&nbsp;</div>
       <div class="wlp-whitespace-only-element-expansion">
            <asp:Button runat="server" Text="Back" OnClick="bac"></asp:Button>&nbsp;</div>
    </form>
</body>
</html>
