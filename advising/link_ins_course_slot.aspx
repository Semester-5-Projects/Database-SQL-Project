<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="link_ins_course_slot.aspx.cs" Inherits="ADVISINGG.link_ins_course_slot" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size: large">
            Enter the following values to link an instructor to a course in a specific slot<br />
            <br />
            Instructor ID<br />
            <asp:TextBox ID="ins" runat="server"></asp:TextBox>
            <br />
            Course ID<br />
            <asp:TextBox ID="course" runat="server" Height="16px"></asp:TextBox>
            <br />
            Slot ID<br />
            <asp:TextBox ID="slot" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Link" OnClick="Web" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Go Back to Previous Page"  OnClick="bacc" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large"/>
        </div>
    </form>
</body>
</html>
