<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="issue_installments.aspx.cs" Inherits="advising.issue_installments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size: large">
        Enter the following value to issue installment<br />
        <br />
        Payment ID<p>
            <asp:TextBox ID="payment" runat="server" style="margin-bottom: 4px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </p>
        <asp:Button ID="Button1" runat="server" Text="Issue Installments" OnClick="web" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Go Back to Previous Page" OnClick="back" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
    </form>
</body>
</html>
