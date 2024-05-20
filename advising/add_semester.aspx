<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add_semester.aspx.cs" Inherits="ADVISINGG.add_semester" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size: large">
            Enter the following values to add a new semester<br />
            <br />
            Date is in the format(mm-dd-yyyy)<br />
            <br />
            Start Date <br />
            <asp:TextBox ID="start" runat="server"></asp:TextBox>
            <br />
            End Date<br />
            <asp:TextBox ID="end" runat="server" ></asp:TextBox>
            <br />
            Semester Code<br />
            <asp:TextBox ID="code" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="web" Font-Names="Bahnschrift SemiBold SemiConden" Font-Overline="False" Font-Size="Large" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Go Back to Previous Page"  Font-Names="Bahnschrift SemiBold SemiConden" Font-Overline="False" Font-Size="Large" OnClick="back" />
        </div>
    </form>
</body>
</html>
