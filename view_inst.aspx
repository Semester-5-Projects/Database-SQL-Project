<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view_inst.aspx.cs" Inherits="student2_advising.view_inst" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="inst_back" runat="server" Text="Back" OnClick="inst_back_Click" />
            <br />
            <br />
            <asp:Label ID="installdeadline" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
