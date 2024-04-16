<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="courserequest.aspx.cs" Inherits="WebApplication1.courserequest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size: large">
            Enter the following information to send a Course Request<br />
            <br />
            Course ID<br />
            <asp:TextBox ID="courseidcreq" runat="server"></asp:TextBox>
            <br />
            <br />
            Comment<br />
            <asp:TextBox ID="commentcreq" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="scr" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Button ID="sendcreq" runat="server" OnClick="sendcrb" Text="Send" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" style="width: 54px" />
            <br />
            <br />
        </div>
        <p>
            <asp:Button ID="backfromstudreg" runat="server" OnClick="backfromstudregb" Text="Go Back to Previous Page" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
            </p>
    </form>
</body>
</html>
