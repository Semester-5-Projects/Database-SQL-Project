<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registerAdvisor.aspx.cs" Inherits="advisor.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="register" runat="server">
        <div class="wlp-whitespace-only-element-expansion">
            <asp:Label runat="server" Text="Username"></asp:Label>&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:TextBox runat="server" ID="un"></asp:TextBox>&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:Label runat="server" Text="Password"></asp:Label>&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:TextBox runat="server" ID="pass"></asp:TextBox >&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:Label runat="server" Text="Email"></asp:Label>&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:TextBox runat="server" ID="em"></asp:TextBox>&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:Label runat="server" Text="Office"></asp:Label>&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:TextBox runat="server" ID="off"></asp:TextBox>&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:Button runat="server" Text="Register" OnClick="registerbt"></asp:Button>&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:Button runat="server" Text="Back to login page" OnClick="blbt"></asp:Button>&nbsp;</div>


    </form>
</body>
</html>
