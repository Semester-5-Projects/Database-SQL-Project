<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student2.aspx.cs" Inherits="student2_advising.student2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="connection" runat="server" Text="Back" OnClick="connection_Click" />
            <br />
            <br />
            <asp:Button ID="View_gpp" runat="server" Text="View Graduation plan" OnClick="View_gp" />
            <br />
            <br />
            <asp:Button ID="view_upcoming_unpaid_installmentt" runat="server" Text="View upcoming installment" OnClick="view_upcoming_unpaid_installment"/>
            <br />
            <br />
            <asp:Button ID="view_courses_and_exam_detailss" runat="server" Text="view upcoming Exams" OnClick="view_courses_and_exam_details" />
            <br />
            <br />
            <asp:Button ID="Register_makeup11" runat="server" Text="Registration to first makeup" OnClick="Register_makeup1" />
            <br />
            <br />
            <asp:Button ID="Register_makeup22" runat="server" Text="Registration to second makeup" OnClick="Register_makeup2" />
            <br />
            <br />
            <asp:Button ID="view_courses_and_slots_and_instructor_detailss" runat="server" Text="view schedule"  OnClick="view_courses_and_slots_and_instructor_details"  />
            <br />
            <br />
            <asp:Button ID="view_slots_of_certain_course_taught_by_certain_instt" runat="server" Text="view slots" OnClick="view_slots_of_certain_course_taught_by_certain_inst" />
            <br />
            <br />
            <asp:Button ID="choose_inst_for_certain_coursee" runat="server" Text="choose Instructor" OnClick="choose_inst_for_certain_course"/>
            <br />
            <br />
            <asp:Button ID="view_details_of_all_courses_and_prereqq" runat="server" Text="view prerequisite courses" OnClick="view_details_of_all_courses_and_prereq"/>
            <br />
        </div>
    </form>
</body>
</html>