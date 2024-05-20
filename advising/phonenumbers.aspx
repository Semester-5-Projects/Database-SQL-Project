<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="phonenumbers.aspx.cs" Inherits="WebApplication1.phonenumbers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size: large">
            Add you phone number(s) one at a time<br />
            <asp:TextBox ID="addphone" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;<br />
            <asp:Button ID="addphoneb" runat="server"  OnClick="addbutton" Text="Add" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
            <br />
            <br />
            <asp:Label ID="resp" runat="server" Text=""></asp:Label>
        </div>
        <p>
            <asp:Button ID="backinphonenum" runat="server"  OnClick="backfromphonenum" Text="Go Back to Previous Page" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
            </p>
    </form>
</body>
</html>
