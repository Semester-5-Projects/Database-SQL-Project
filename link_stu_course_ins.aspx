<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="link_stu_course_ins.aspx.cs" Inherits="ADVISINGG.link_stu_course_ins" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size: large">
            Enter the following values to link a student to a course with a specific instructor<br />
            <br />
            Instructor ID<br />
            <asp:TextBox ID="instructor" runat="server"></asp:TextBox>
            <br />
            Student ID<br />
            <asp:TextBox ID="student" runat="server"></asp:TextBox>
            <br />
            Course ID<br />
            <asp:TextBox ID="course" runat="server"></asp:TextBox>
            <br />
            Semester Code<br />
            <asp:TextBox ID="semester" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Link" OnClick="Web" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Go Back to Previous Page" OnClick="bacc" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
        </div>
    </form>
</body>
</html>
