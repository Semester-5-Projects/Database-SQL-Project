<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin_page.aspx.cs" Inherits="ADVISINGG.admin_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size: 18px">
        <div style="font-family: 'Bahnschrift SemiBold SemiConden'; font-size: x-large;">
            Hello Admin!<br />
            <br />
            Welcome to the Student Advisor Page<br />
            </div>
        <p>
            Select the procedure you wish to perform</p>
        <p>
            <asp:Button ID="all_advisors" runat="server" OnClick="web1" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Bold="False" Font-Names="Bahnschrift SemiBold SemiConden" Font-Overline="False" Font-Size="Large" Font-Strikeout="False" Text="List All Advisors" Width="150px" />
        &nbsp;</p>
        <p>
            <asp:Button ID="all_students" runat="server" OnClick="web2" Text="List all students with their corresponding advisors in the system" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" Width="500px" />
        </p>
        <p>
            <asp:Button ID="pending" runat="server" OnClick="web3" Text="&nbsp;List all pending requests" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" Width="200px" />
        </p>
        <p>
            <asp:Button ID="add_semester" runat="server" OnClick="web4" Text="&nbsp;Add a new semester" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" Width="175px" />
        </p>
        <p>
            <asp:Button ID="add_course" runat="server" OnClick="web5" Text="Add a new course" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" Width="150px" />
        </p>
        <asp:Button ID="link_ins_course_slot" runat="server" OnClick="web6" Text="Link instructor to a course in a specific slot" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" Width="350px" />
        <p>
            <asp:Button ID="link_stu_adv" runat="server" OnClick="web7" Text="Link a student to an advisor" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" Width="225px" />
        </p>
        <p>
            <asp:Button ID="link_stu_course_ins" runat="server" OnClick="web8" Text="Link a student to a course with a specific instructor" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" Width="400px" />
        </p>
        <p>
            <asp:Button ID="ins_details" runat="server"  OnClick="web9" Text="View all details of instructors along with their assigned courses" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" Width="500px" />
        </p>
        <p>
            <asp:Button ID="all_semesters" runat="server" OnClick="web10" Text="Fetch all semesters along with their offered courses" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" Width="400px" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" Text="More Options..." Width="150px" OnClick="web11" />
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" BackColor="#CCFFCC" BorderColor="#CCFFCC" Font-Names="Bahnschrift SemiBold SemiConden" Font-Size="Large" OnClick="mainn" Text="Click here to go back to the Main Page" Width="300px" />
        </p>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
