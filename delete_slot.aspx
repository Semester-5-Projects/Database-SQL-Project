<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="delete_slot.aspx.cs" Inherits="advising.delete_slot" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: 'Bahnschrift SemiCondensed'; font-size: large">
            Enter the following value to delete a slot<br />
            <br />
            Current Semester Code<br />
            <asp:TextBox ID="semester" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Delete" OnClick="web" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Go Back to Previous Page" OnClick="bacc" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
        </div>
    </form>
</body>
</html>
