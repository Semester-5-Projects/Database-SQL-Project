<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="availablecourses.aspx.cs" Inherits="WebApplication1.availablecourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size: medium">
            Enter the following value to view all the available courses<br />
            <br />
            Current Semester Code<br />
            <asp:TextBox ID="acsemcode" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="enter" runat="server" OnClick="gotoac2" Text="Enter" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
            <br />
            <br />
            <asp:GridView ID="GridViewac" runat="server">
            </asp:GridView>
            <br />
            <asp:Button ID="backfromac" runat="server" OnClick="backfromacb" Text="Go Back to Previous Page" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
        </div>
    </form>
</body>
</html>
