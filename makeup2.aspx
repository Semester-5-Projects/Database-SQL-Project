<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="makeup2.aspx.cs" Inherits="student2_advising.makeup2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="makeup2_back" runat="server" Text="Back" OnClick="makeup2_back_Click" />
            <br />
            Please enter the course ID<br />
            <asp:TextBox ID="makeup2_course_id" runat="server"></asp:TextBox>
            <br />
            Please enter your current semester<br />
            <asp:TextBox ID="makeup2_semester_code" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Register_makeup_exam2" runat="server" Text="Register" OnClick="Register_makeup_exam2_Click" />
            <br />
            <asp:Label ID="makeup2label" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
