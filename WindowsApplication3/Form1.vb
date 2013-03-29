Public Class Form1
    Dim ctrlCourseDB As New CoursesDatabase
    Dim ctrlStudentDB As New StudentDatabase
    Dim ctrlTeacherDB As New TeacherDatabase

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCreateCurriculum.Click

        'Testing creating a course and adding prerequisit Course
        Dim Course As New Course
        Course.ID = "CIS-234"
        Course.Title = "Beginners Java for Business"
        Course.Units = 4
        ctrlCourseDB.setCourse(Course)

        Course = New Course
        Course.ID = "CIS-304L"
        Course.Title = "Java Companion Lab"
        Course.Units = 2
        ctrlCourseDB.setCourse(Course)

        Course = New Course
        Course.ID = "CIS-304"
        Course.Title = "Intermediate Java for Business"
        Course.Units = 4
        Course.PreRequisitCourse = ctrlCourseDB.getCourse("CIS-234")  'requires a course. Therefore, I get course instance from database
        Course.CompanionCourse = ctrlCourseDB.getCourse("CIS-304L")
        ctrlCourseDB.setCourse(Course)


        'Test student

        Dim student As New Student(112233, "Miguel Angel Venegas", CDate("01/11/1111"), False)
        ctrlStudentDB.setStudent(student)

        'Test Teacher
        Dim teacher As New Teacher(998877, "Dr. S Curl")
        ctrlTeacherDB.setTeacher(teacher)

    End Sub


    Private Sub btnCourses_Click(sender As System.Object, e As System.EventArgs) Handles btnCourses.Click
        ListBox1.Items.Clear()
        'Loops list to show on listBox
        Dim list As ArrayList = ctrlCourseDB.getAllCourses()
        Dim tempCourse As Course
        For Each tempCourse In list
            ListBox1.Items.Add(tempCourse.ID & vbTab & tempCourse.Title)
        Next
    End Sub

    Private Sub btnStudents_Click(sender As System.Object, e As System.EventArgs) Handles btnStudents.Click
        ListBox1.Items.Clear()
        Dim list As ArrayList = ctrlStudentDB.getAllStudents()
        Dim tempStudent As Student
        For Each tempStudent In list
            ListBox1.Items.Add(tempStudent.ID & vbTab & tempStudent.Name)
        Next
    End Sub

    Private Sub btnTeacher_Click(sender As System.Object, e As System.EventArgs) Handles btnTeacher.Click
        ListBox1.Items.Clear()
        Dim list As ArrayList = ctrlTeacherDB.getAllTeachers()
        Dim tempTeacher As Teacher
        For Each tempTeacher In list
            ListBox1.Items.Add(tempTeacher.ID & vbTab & tempTeacher.Name)
        Next
    End Sub
End Class
