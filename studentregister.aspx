<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentregister.aspx.cs" Inherits="WebApplication1.studentregister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size: large">
            <br />
            Please Fill The Below Details To Register as a Student<br />
            <br />
            First Name<br />
            <asp:TextBox ID="fname" runat="server"></asp:TextBox>
            <br />
            <br />
            Last Name<br />
            <asp:TextBox ID="lname" runat="server"></asp:TextBox>
            <br />
            <br />
            Password<br />
            <asp:TextBox ID="rpass" runat="server"></asp:TextBox>
            <br />
            <br />
            Faculty<br />
            <asp:TextBox ID="faculty" runat="server"></asp:TextBox>
            <br />
            <br />
            Email<br />
            <asp:TextBox ID="email" runat="server"></asp:TextBox>
            <br />
            <br />
            Major<br />
            <asp:TextBox ID="major" runat="server"></asp:TextBox>
            <br />
            <br />
            Semester<br />
            <asp:TextBox ID="semint" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="newreg" runat="server" OnClick="newregistrations" Text="Register" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
            <br />
            <br />
            <asp:Label ID="successr" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="idis" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="goback" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="backfromreg" runat="server" OnClick="backfromregb" Text="Go Back to Previous Page
" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
            <br />
        </div>
    </form>
</body>
</html>
