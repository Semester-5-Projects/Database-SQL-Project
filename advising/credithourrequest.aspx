<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="credithourrequest.aspx.cs" Inherits="WebApplication1.credithourrequest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size: large">
            Enter the following information to send a Credit Hours Request<br />
            <br />
            Credit Hours<br />
            <asp:TextBox ID="cht" runat="server"></asp:TextBox>
            <br />
            <br />
            Comment<br />
            <asp:TextBox ID="commentchreq" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="schr" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="sendchreq" runat="server" OnClick="sendchreqb" Text="Send" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
            <br />
            <br />
            <asp:Button ID="backfromchreq" runat="server" OnClick="backfromchreqb" Text="Back" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
        </div>
    </form>
</body>
</html>
