<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="c_i_slots.aspx.cs" Inherits="student2_advising.c_i_slots" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="c_i_slots_back" runat="server" Text="Back" OnClick="c_i_slots_back_Click" />
            <br />
            Please enter Course_ID<br />
            <asp:TextBox ID="slots_course_id" runat="server"></asp:TextBox>
            <br />
            Please enter instructor ID<br />
            <asp:TextBox ID="slots_inst_id" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="slots_view_button" runat="server" Text="View" OnClick="slots_view_button_Click" />
            <br />
            <asp:GridView ID="GridView5" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
