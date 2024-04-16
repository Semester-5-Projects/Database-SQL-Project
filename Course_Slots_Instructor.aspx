<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Course_Slots_Instructor.aspx.cs" Inherits="student2_advising.Course_Slots_Instructor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="csi_back" runat="server" Text="Back" OnClick="csi_back_Click" />
            <br />
            <asp:GridView ID="GridView3" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
