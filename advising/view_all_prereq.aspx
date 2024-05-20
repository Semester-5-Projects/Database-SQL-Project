<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view_all_prereq.aspx.cs" Inherits="student2_advising.view_all_prereq" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="prereq_back" runat="server" Text="Back" OnClick="prereq_back_Click" />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
