
            <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewASAdvisor.aspx.cs" Inherits="advisor.viewAS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="wlp-whitespace-only-element-expansion">
        <asp:Label runat="server" Text="Advisor ID"></asp:Label>
        &nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
        <asp:TextBox runat="server" ID="aid"></asp:TextBox>
        &nbsp;
        &nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
        <asp:Label runat="server" Text="Major"></asp:Label>
        &nbsp;</div>
        <div class="wlp-whitespace-only-element-expansion">
        <asp:TextBox runat="server" ID="maj"></asp:TextBox>
        &nbsp;</div>
        <div class="">&nbsp;</div>
        <div class="">
            <asp:Button runat="server" Text="View" OnClick="viewStudents"></asp:Button>&nbsp;</div>
        <div class="">&nbsp;</div>
        <div class="">
            <asp:GridView runat="server" ID="advTable"></asp:GridView>
            &nbsp;</div>
            <div class="wlp-whitespace-only-element-expansion">
<asp:Button runat="server" Text="Back" OnClick="bac"></asp:Button>&nbsp;</div>





    </form>
</body>
</html>
