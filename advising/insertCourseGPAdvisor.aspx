<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insertCourseGPAdvisor.aspx.cs" Inherits="advisor.insertCourseGP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="Student ID"></asp:Label>
        </div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:TextBox runat="server" ID="sid"></asp:TextBox>&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:Label runat="server" Text="Semster Code"></asp:Label>&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:TextBox runat="server" ID="sc"></asp:TextBox>
            &nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:Label runat="server" Text="Course Name"></asp:Label>&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:TextBox runat="server" ID="cn"></asp:TextBox>&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:Button runat="server" Text="Add" OnClick="addbt"></asp:Button>&nbsp;</div>
         <div class="wlp-whitespace-only-element-expansion">
<asp:Button runat="server" Text="Back" OnClick="bac"></asp:Button>&nbsp;</div>




    </form>
</body>
</html>
