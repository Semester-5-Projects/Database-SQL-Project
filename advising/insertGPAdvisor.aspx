
            <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insertGPAdvisor.aspx.cs" Inherits="advisor.insertGP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
  <div class="wlp-whitespace-only-element-expansion">
     <asp:Label runat="server" Text="Semester Code"></asp:Label>&nbsp;</div>
 <div class="wlp-whitespace-only-element-expansion">
     <asp:TextBox runat="server" ID="sc"></asp:TextBox>&nbsp;</div>
 <div class="wlp-whitespace-only-element-expansion">
     <asp:Label runat="server" Text="Expected Graduation Date"></asp:Label>&nbsp;</div>
 <div class="wlp-whitespace-only-element-expansion">
     <asp:TextBox runat="server" ID="gd"></asp:TextBox >&nbsp;</div>
 <div class="wlp-whitespace-only-element-expansion">
     <asp:Label runat="server" Text="Semester Credit Hours"></asp:Label>&nbsp;</div>
 <div class="wlp-whitespace-only-element-expansion">
     <asp:TextBox runat="server" ID="cd"></asp:TextBox>&nbsp;</div>
 <div class="wlp-whitespace-only-element-expansion">
     <asp:Label runat="server" Text="Advisor ID"></asp:Label>&nbsp;</div>
 <div class="wlp-whitespace-only-element-expansion">
     <asp:TextBox runat="server" ID="aid"></asp:TextBox>&nbsp;</div>
 <div class="wlp-whitespace-only-element-expansion">
     <asp:Label runat="server" Text="Student ID"></asp:Label>&nbsp;</div>
 <div class="wlp-whitespace-only-element-expansion">
     <asp:TextBox runat="server" ID="sid"></asp:TextBox>&nbsp;</div>
 <div class="wlp-whitespace-only-element-expansion">&nbsp;</div>
 <div class="wlp-whitespace-only-element-expansion">
     <asp:Button runat="server" Text="Add" OnClick="addbt"></asp:Button>&nbsp;</div>
         <div class="wlp-whitespace-only-element-expansion">
<asp:Button runat="server" Text="Back" OnClick="bac"></asp:Button>&nbsp;</div>
    </form>
</body>
</html>
