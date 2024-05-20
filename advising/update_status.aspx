<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="update_status.aspx.cs" Inherits="advising.update_status" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size: large">
            Enter the following value to update a student&#39;s status<br />
            <br />
            Student ID
            <br />
            <asp:TextBox ID="student" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br />
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" Text="Update" onClick="web" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large"/>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Go Back to Previous Page" onClick="back" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large"/>
    </form>
</body>
</html>
