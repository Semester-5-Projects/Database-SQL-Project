<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="optionalcourses.aspx.cs" Inherits="WebApplication1.optionalcourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size: large">
            Enter the following information to view your Optional courses<br />
            <br />
            Current Semester Code<br />
            <asp:TextBox ID="semcodeoc" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="enteroc" runat="server" OnClick="eoc" Text="Enter" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
            <br />
            <br />
            <asp:GridView ID="GridViewoc" runat="server">
            </asp:GridView>
        </div>
        <p>
            <asp:Button ID="backfromoc" runat="server" OnClick="backfromocb" Text="Go Back to Previous Page" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
            </p>
    </form>
</body>
</html>
