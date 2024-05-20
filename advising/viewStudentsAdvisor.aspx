<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewStudentsAdvisor.aspx.cs" Inherits="advisor.viewStudents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="Advior ID"></asp:Label>
        </div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:TextBox runat="server" ID="adId"></asp:TextBox>&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:Label runat="server" Text="Major"></asp:Label>&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:TextBox runat="server" ID="maj"></asp:TextBox>&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:Button runat="server" Text="View" onClick="viewbt"></asp:Button>&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">&nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
            <asp:GridView runat="server" ID="students"></asp:GridView>
            &nbsp;</div>
            <div class="wlp-whitespace-only-element-expansion">
<asp:Button runat="server" Text="Back" OnClick="bac"></asp:Button>&nbsp;</div>




    </form>
</body>
</html>
