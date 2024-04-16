<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication1.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
    <div style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size: large">
        Please Login<br />
        <br />
        User ID<br />
        <asp:TextBox ID="userid" runat="server"></asp:TextBox>
        <br />
        <br />
        Password<br />
        <asp:TextBox ID="password" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="loginbutton" runat="server" OnClick="slogin" Text="LogIn" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
        <br />
        <asp:Label ID="r" runat="server" Text=""></asp:Label>
        <br />
        No account? Register Here!<br />
        <asp:Button ID="register" runat="server" OnClick="studentregistration" Text="Register" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
        <br />
    </div>
       <p>
        <asp:Button ID="backfromlogin" runat="server" OnClick="backfromloginb" Text="Go Back to Previous Page" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
        </p>
</form>
</body>
</html>
