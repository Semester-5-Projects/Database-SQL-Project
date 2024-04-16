<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="missingcourses.aspx.cs" Inherits="WebApplication1.missingcourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size: large">
            <asp:Button ID="viewmc" runat="server" OnClick="vmc" Text="Click To View Missing Courses" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
            <br />
            <br />
            <asp:GridView ID="GridViewmc" runat="server" Font-Names="
">
            </asp:GridView>
        </div>
        <p>
            <asp:Button ID="backfromms" runat="server" OnClick="backfrommsb" Text="Go Back to Previous Page" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
            </p>
    </form>
</body>
</html>
