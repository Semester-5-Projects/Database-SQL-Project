# README

## Project Overview

The GUC has an advising system responsible for advising students. In our system, a **student is considered advising** if one or more of these conditions are met:

1. **Declared his/her major after the deadline**
2. **Has at least one missed course because of the below reasons:**
   - Didn’t take or attend one or more courses from the previous semesters.
   - Failed one or more courses, also not eligible for makeup (Check requirements).
3. **The student is considered under probation** (if his/her GPA is more than 3.7).

The aim of the project is to implement a modified advising system to serve the different students’ needs.
## Functionality

### Basic Structure of the Database using Procedures

1. **Wrote an SQL query to create a database called “Advising_System”**
2. **Created a procedure that creates all the tables of the database.**
   - **Name:** `CreateAllTables`
3. **Created a procedure that drops all tables inside the database.**
   - **Name:** `DropAllTables`
4. **Created a stored procedure to clear all records in all tables existing in the database.**
   - **Name:** `clearAllTables`

### Tables Created

- Advisor
- Student
- Student_Phone
- Graduation_Plan
- Course
- PreqCourse_course
- Instructor
- Instructor_Course
- Student_Instructor_Course_take
- Semester
- Course_Semester
- GradPlan_Course
- Slot
- Request
- MakeUp_Exam
- Exam_Student
- Payment
- Installment

### Basic Data Retrieval using Views

A) **Fetch details for all active students.**
   - **Name:** `view_Students`

B) **Fetch details for all courses with their prerequisites.**
   - **Name:** `view_Course_prerequisites`

C) **Fetch details for all instructors along with their assigned courses.**
   - **Name:** `Instructors_AssignedCourses`

D) **Fetch details for all payments along with their corresponding student.**
   - **Name:** `Student_Payment`

E) **Fetch details for all courses along with their corresponding slots’ details and instructors.**
   - **Name:** `Courses_Slots_Instructor`

F) **Fetch details for all courses along with their exams’ details.**
   - **Name:** `Courses_MakeupExams`

G) **Fetch students along with their taken courses’ details.**
   - **Name:** `Students_Courses_transcript`

H) **Fetch all semesters along with their offered courses.**
   - **Name:** `Semster_offered_Courses`

I) **Fetch all graduation plans along with their initiated advisors.**
   - **Name:** `Advisors_Graduation_Plan`

### All Other Functionalities using Procedures, Views and Functions (Scalar, TV)

- **Student Registration**  
- **Advisor Registration**  
- **List all advising students**  
- **List all Advisors**  
- **List all Students with their Advisors**  
- **Add new Semester**  
- **Add new course**  
- **Link instructor to course on specific slot**  
- **Link student to course with Specific instructor**  
- **Link student to advisor**  
- **Admin add exam**  
- **Issue installments as per the number of installments for a certain payment**  
- **Delete courses along with its related slots**  
- **Update student’s Status based on his/her financial status**  
- **Choose instructor for a certain selected course**  
- **Delete slots of certain courses if the course isn’t offered in the current semester**  
- **Advisor login using username and password**  
- **Insert graduation Plan**  
- **Add course inside certain plan of specific student**  
- **Update expected graduation date in a certain graduation plan**  
- **Delete course from certain graduation plan in certain semester**  
- **Retrieve requests for certain advisor**  
- **Approve/Reject extra credit hours’ request**  
- **View all students assigned to specific advisor from a certain major along with their taken courses**  
- **Approve/Reject courses request**  
- **View pending requests of specific advisor students**  
- **Student Login using username and password**  
- **Add Student mobile number(s)**  
- **View available courses in the current semester**  
- **Sending course’s request**  
- **Sending extra credit hours’ request**  
- **View graduation plan along with the assigned courses**  
- **Student view his first not paid installment deadline**  
- **View slots of certain course that is taught by a certain instructor**  
- **Register for first makeup exam**  
- **Second makeup Eligibility Check**  
- **Register for 2nd makeup exam**  
- **View required courses**  
- **View optional courses**  
- **View missing/remaining courses to specific student**  
- **Choose instructor for a certain selected course**  


## Contribution

Contributions are welcome! If you have any suggestions, improvements, or new features you'd like to see, feel free to fork this repository, make your changes, and submit a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

