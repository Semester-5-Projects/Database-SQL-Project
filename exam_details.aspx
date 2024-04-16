<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="exam_details.aspx.cs" Inherits="student2_advising.exam_details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="exam_details_back" runat="server" Text="Back" OnClick="exam_details_back_Click" />
            <br />
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
