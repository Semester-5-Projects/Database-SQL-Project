<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pendingRequestsAdvisor.aspx.cs" Inherits="advisor.pendingRequests" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="Advisor ID"></asp:Label>
        </div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:TextBox runat="server" ID="aid"></asp:TextBox>&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:Button runat="server" Text="View" OnClick="viewbt"></asp:Button>&nbsp;</div>
        <div class="">&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:GridView runat="server" ID="penTable"></asp:GridView>
            &nbsp;</div>
            <div class="wlp-whitespace-only-element-expansion">
<asp:Button runat="server" Text="Back" OnClick="bac"></asp:Button>&nbsp;</div>


    </form>
</body>
</html>
