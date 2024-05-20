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

A) **Student Registration**  
B) **Advisor Registration**  
C) **List all advising students**  
D) **List all Advisors**  
E) **List all Students with their Advisors**  
F) **Add new Semester**  
G) **Add new course**  
H) **Link instructor to course on specific slot**  
I) **Link student to course with Specific instructor**  
J) **Link student to advisor**  
K) **Admin add exam**  
L) **Issue installments as per the number of installments for a certain payment**  
M) **Delete courses along with its related slots**  
N) **Update student’s Status based on his/her financial status**  
O) **Choose instructor for a certain selected course**  
P) **Delete slots of certain courses if the course isn’t offered in the current semester**  
Q) **Advisor login using username and password**  
R) **Insert graduation Plan**  
S) **Add course inside certain plan of specific student**  
T) **Update expected graduation date in a certain graduation plan**  
U) **Delete course from certain graduation plan in certain semester**  
V) **Retrieve requests for certain advisor**  
W) **Approve/Reject extra credit hours’ request**  
X) **View all students assigned to specific advisor from a certain major along with their taken courses**  
Y) **Approve/Reject courses request**  
Z) **View pending requests of specific advisor students**  
AA) **Student Login using username and password**  
BB) **Add Student mobile number(s)**  
CC) **View available courses in the current semester**  
DD) **Sending course’s request**  
EE) **Sending extra credit hours’ request**  
FF) **View graduation plan along with the assigned courses**  
GG) **Student view his first not paid installment deadline**  
HH) **View slots of certain course that is taught by a certain instructor**  
II) **Register for first makeup exam**  
JJ) **Second makeup Eligibility Check**  
KK) **Register for 2nd makeup exam**  
LL) **View required courses**  
MM) **View optional courses**  
NN) **View missing/remaining courses to specific student**  
OO) **Choose instructor for a certain selected course**  
