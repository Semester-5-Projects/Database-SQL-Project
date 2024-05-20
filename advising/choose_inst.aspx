<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="choose_inst.aspx.cs" Inherits="student2_advising.choose_inst" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="choose_inst_back" runat="server" Text="Back" OnClick="choose_inst_back_Click" />
            <br />
            Please enter Instructor ID<br />
            <asp:TextBox ID="choose_inst_inst_id" runat="server"></asp:TextBox>
            <br />
            Please enter Course ID<br />
            <asp:TextBox ID="choose_inst_couse_id" runat="server"></asp:TextBox>
            <br />
            Please enter current semester code<br />
            <asp:TextBox ID="choose_inst_semcode" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="choose_inst_button" runat="server" Text="Choose" OnClick="choose_inst_button_Click" />
            <br />
            <br />
            <asp:Label ID="output" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
