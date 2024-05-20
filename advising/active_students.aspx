<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="active_students.aspx.cs" Inherits="advising.active_students" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="font-size: large">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Medium">
        </asp:GridView>
        <br />
            <asp:Button ID="Button1" runat="server" Text="Go Back to Previous Page" onClick="web" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large"/>
    </form>
</body>
</html>
