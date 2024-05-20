<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin_login.aspx.cs" Inherits="ADVISINGG.admin_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size: 20px">
            HINT:</p>
        <p style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size: 20px">
            id = 2339</p>
        <p style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size: 20px">
            pass = angela</p>
        <p style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size: 20px">
            &nbsp;</p>
        <p style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size: 20px">
            Enter your user id and password to login</p>
        <p style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size: large">
            User ID</p>
        <p>
            <asp:TextBox ID="id" runat="server"></asp:TextBox>
        </p>
        <p style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size: large">
            Password</p>
        <asp:TextBox ID="password" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="log_in" runat="server" Height="28px" OnClick="website" Text="Log In" Width="58px" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large"/>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Go Back to Previous Page" OnClick="bacc" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
        <br />
    </form>
</body>
</html>
