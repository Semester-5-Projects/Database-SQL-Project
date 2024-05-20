<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view_g_p.aspx.cs" Inherits="student2_advising.view_g_p" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="gp_back" runat="server" Text="Back" OnClick="gp_back_Click" />
            <br />
            <asp:GridView ID="GridView4" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
