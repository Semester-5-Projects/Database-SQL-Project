<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="advisorMain.aspx.cs" Inherits="advisor.advisorMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="wlp-whitespace-only-element-expansion">
            <asp:Button runat="server" Text="View Advising Students" OnClick="a3"></asp:Button>&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:Button runat="server" Text="Insert Graduation Plan" OnClick="a4"></asp:Button>&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:Button runat="server" Text="Insert Course in GP" OnClick="a5"></asp:Button>&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:Button runat="server" Text="Update Graduation Date" OnClick="a6"></asp:Button>&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:Button runat="server" Text="Delete Course From GP" OnClick="a7"></asp:Button>&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:Button runat="server" Text="View all assigned Students with a Certain Major" OnClick="a8"></asp:Button>&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:Button runat="server" Text="View all Requests" OnClick="a9"></asp:Button>&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:Button runat="server" Text="View all Pending Requests" OnClick="a10"></asp:Button>&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:Button runat="server" Text="Approve/Reject Credit Hours" OnClick="a11"></asp:Button>&nbsp;</div>
        <div>
            <asp:Button runat="server" Text="Approve/Reject Course" OnClick="a12"></asp:Button>
        </div>
                <div>
            <asp:Button runat="server" Text="Back" OnClick="bac"></asp:Button>
        </div>
    </form>
</body>
</html>
