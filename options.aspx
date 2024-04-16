<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="options.aspx.cs" Inherits="WebApplication1.options" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size: x-large">
            Hello Student!<br />
            Welcome to the Student Advisor Page<br />
            <br />
            <div style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size: large">
    
            Select the procedure you wish to perform<br />
            <br />
            <asp:Button ID="phones" runat="server" OnClick="phonenumbers" Text="Add my telephone number(s)" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
            <br />
            <br />
            <asp:Button ID="oc" runat="server" OnClick="optionalcourses" Text="View all optional courses" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
            <br />
            <br />
            <asp:Button ID="ac" runat="server" OnClick="availablecourses" Text="View all available courses" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
            <br />
            <br />
            <asp:Button ID="rc" runat="server" OnClick="requiredcourses" Text="View the required courses" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
            <br />
            <br />
            <asp:Button ID="mc" runat="server" OnClick="missingcourses" Text="View the missing courses" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
            <br />
            <br />
            <asp:Button ID="cr" runat="server" OnClick="courserequest" Text=" Send a course request" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
            <br />
            <br />
            <asp:Button ID="chr" runat="server" OnClick="credithourrequest" Text="Send a credit hour request" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" Text="More Options..." OnClick="more" />
            <br />
        </div>
        <p>
            <asp:Button ID="backfromoptions" runat="server" OnClick="backfromoptionsb" Text="Click here to go back to the Main Page" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" />
            </p>
    </form>
</body>
</html>
