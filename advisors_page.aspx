<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="advisors_page.aspx.cs" Inherits="ADVISINGG.advisors_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="advisorsTable" runat="server" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large">
</asp:GridView>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Go Back to Previous Page" onclick="bac" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large"/>
        </p>
    </form>
</body>
</html>
