<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="requiredcourses.aspx.cs" Inherits="WebApplication1.requiredcourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size: large">
            &nbsp;Enter Your Current Semester Code<br />
            <asp:TextBox ID="semcoderc" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="enterrc" runat="server" OnClick="erc" Text="Enter" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
            <br />
            <br />
            <asp:GridView ID="GridViewrc" runat="server">
            </asp:GridView>
            <br />
            <asp:Button ID="backfromrc" runat="server" OnClick="backfromrcb" Text="Go Back to Previous Page" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
        </div>
    </form>
</body>
</html>
