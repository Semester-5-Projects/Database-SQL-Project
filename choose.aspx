<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="choose.aspx.cs" Inherits="WebApplication1.choose" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size: xx-large">
            Welcome to The Advising System!<br />
            <div style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size:x-large">
    
    Please Select One<br />
                <br />
                <asp:Button ID="Button1" runat="server" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" Text="Student" OnClick="studentlogin" />
                <br />
                <br />
        </div>
        </div>
        <asp:Button ID="Button2" runat="server" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" Text="Advisor" OnClick="advisorlogin" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" Text="Admin" OnClick="adminlogin"/>
    </form>
</body>
</html>
