<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view_gradplans.aspx.cs" Inherits="advising.view_gradplans" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large">
        </asp:GridView>
        <br />
            <asp:Button ID="Button1" runat="server" Text="Go Back to Previous Page" OnClick="web" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
    </form>
</body>
</html>
