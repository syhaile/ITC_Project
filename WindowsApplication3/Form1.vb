Public Class Form1
    Dim ctrlCourseDB As New CoursesDatabase
    Dim ctrlStudentDB As New StudentDatabase
    Dim ctrlTeacherDB As New TeacherDatabase
    Dim ctrlRoomDB As New RoomDatabase
    Dim ctrlScheduleDB As New Schedule

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCreateCurriculum.Click

        'Testing creating a course and adding prerequisit Course


        Dim course As New Course("CS101", 4, "", "MAT114")
        ctrlCourseDB.addCourse(course)
        course = New Course("CS102", 4, "", "CS101")
        ctrlCourseDB.addCourse(course)
        course = New Course("CS103", 4, "CS102", "")
        ctrlCourseDB.addCourse(course)

        'Test Teacher
        Dim teacher As New Teacher(998877, "Dr. S Curl")
        ctrlTeacherDB.setTeacher(teacher)
        teacher = New Teacher
        teacher.ID = "667788"
        teacher.Name = "Dr. S Zhang"
        ctrlTeacherDB.setTeacher(teacher)

        'Test Room
        Dim room As New Room
        room.ID = "CLA-1001"

        ctrlRoomDB.addRoom(room)


        room = New Room
        room.ID = "CLA-1002"

        ctrlRoomDB.addRoom(room)

        Dim student As New Student("112233", "Miguel Venegas", "2012", "Fall", True)
        ctrlStudentDB.addStudent(student)
        student = New Student("442233", "MarTIN Legaspi", "2012", "Fall", True)
        ctrlStudentDB.addStudent(student)

        'test adding room, course, student and professor  into a master schedule
        Dim scheduler As New Section
        scheduler.SectionID = "Spring-2012"
        scheduler.CourseID = "CIS-304"
        scheduler.RoomID = "CLA-1001"
        scheduler.TeacherID = "667788"
        scheduler.addStudentID("442233")
        scheduler.addStudentID("112233")
        ctrlScheduleDB.addSection(scheduler)

    End Sub


    Private Sub btnCourses_Click(sender As System.Object, e As System.EventArgs) Handles btnCourses.Click
        txtArea.Clear()
        'Loops list to show on listBox
        Dim list As ArrayList = ctrlCourseDB.getAllCourses()
        Dim tempCourse As Course
        Dim msg As String = ""
        For Each tempCourse In list
            msg += tempCourse.getCourseDescription & vbCrLf
        Next
        txtArea.Text = msg
    End Sub

    Private Sub btnStudents_Click(sender As System.Object, e As System.EventArgs) Handles btnStudents.Click
        txtArea.Clear()
        Dim list As ArrayList = ctrlStudentDB.getAllStudents()
        Dim tempStudent As Student
        Dim msg As String = ""
        For Each tempStudent In list
            msg += tempStudent.getStudentDescription & vbCrLf
        Next
        txtArea.Text = msg
    End Sub

    Private Sub btnTeacher_Click(sender As System.Object, e As System.EventArgs) Handles btnTeacher.Click
        txtArea.Clear()
        Dim list As ArrayList = ctrlTeacherDB.getAllTeachers()
        Dim tempTeacher As Teacher
        Dim msg As String = ""
        For Each tempTeacher In list
            msg += tempTeacher.getTeacherDescription & vbCrLf
        Next
        txtArea.Text = msg
    End Sub

    Private Sub btnRoom_Click(sender As System.Object, e As System.EventArgs) Handles btnRoom.Click
        txtArea.Clear()
        Dim list As ArrayList = ctrlRoomDB.getAllRooms()
        Dim tempRoom As Room
        Dim msg As String = ""
        For Each tempRoom In list
            msg += tempRoom.getDescription & vbCrLf
        Next
        txtArea.Text = msg
    End Sub

    Private Sub btnSchedule_Click(sender As System.Object, e As System.EventArgs) Handles btnSchedule.Click
        txtArea.Clear()
        Dim list As ArrayList = ctrlScheduleDB.getAllSections()
        Dim tempSchedule As Section
        Dim msg As String = ""

        For Each tempSchedule In list
            msg += tempSchedule.getSectionDescription & vbCrLf
        Next
        txtArea.Text = msg

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
