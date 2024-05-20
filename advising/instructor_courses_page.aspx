<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="instructor_courses_page.aspx.cs" Inherits="ADVISINGG.instructor_courses_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large">
        </asp:GridView>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Go Back to Previous Page" OnClick="bac" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large"/>
        <br />
    </form>
</body>
</html>
