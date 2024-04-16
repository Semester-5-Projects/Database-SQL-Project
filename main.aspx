<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="advising.main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Delete a course along with its related slots" OnClick="a" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" Width="325px" />
        </div>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Delete a slot of a certain course if the course isn’t offered in the current semester" OnClick="b" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" Width="600px" />
        </p>
        <asp:Button ID="Button3" runat="server" Text="Add makeup exam for a certain course" OnClick="c" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" Width="300px"/>
        <p>
            <asp:Button ID="Button4" runat="server" OnClick="d" Text="View details for all payments along with their corresponding students" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" Width="525px" />
        </p>
        <p>
            <asp:Button ID="Button5" runat="server" OnClick="e" Text="Issue installments as per the number of installments for a certain payment" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" Width="550px" />
        </p>
        <p>
            <asp:Button ID="Button6" runat="server" OnClick="f" Text="Update a student status based on his/her financial status" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" Width="425px" />
        </p>
        <p>
            <asp:Button ID="Button7" runat="server" OnClick="g" Text="Fetch all details of active students" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" Width="275px" />
        </p>
        <p>
            <asp:Button ID="Button10" runat="server" OnClick="h" Text="View all graduation plans along with their initiated advisors" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" Width="450px" />
        </p>
        <p>
            <asp:Button ID="Button8" runat="server" OnClick="i" Text=" View all students transcript details" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" Width="275px" />
        </p>
        <p>
            <asp:Button ID="Button9" runat="server" OnClick="j" Text="Fetch all semesters along with their offered courses" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" Width="400px" />
        </p>
        <p>
            <asp:Button ID="Button11" runat="server" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" Text="Go Back to Previous Tasks" Width="250px" OnClick="web1" />
        </p>
    </form>
</body>
</html>
