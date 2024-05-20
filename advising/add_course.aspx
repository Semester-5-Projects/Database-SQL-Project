<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add_course.aspx.cs" Inherits="ADVISINGG.add_course" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size: large">
            Enter the following values to add a new Course<br />
            <div style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size: medium">
                    <br />
            <asp:Label ID="Label2" runat="server" Text="offered should be 0 (for not offered) or 1 (for offered)
                <br />
              credit hours and semester should be integers"></asp:Label><br />
            <br />
                <div style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size: large">
            Course Name<br />
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
            <br />
            Offered or not<br />
            <asp:TextBox ID="offered" runat="server"></asp:TextBox>
            <br />
            Credit Hours<br />
            <asp:TextBox ID="hours" runat="server"></asp:TextBox>
            <br />
            Semester<br />
            <asp:TextBox ID="semester" runat="server"></asp:TextBox>
            <br />
            Major<br />
            <asp:TextBox ID="major" runat="server" ></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="web" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Font-Size="Large" Text="Go Back to Previous Page" OnClick="back" />
        </div>
    </form>
</body>
</html>
