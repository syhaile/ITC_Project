Public Class StudentView

    Dim students As Collection = Controller.getStudentDB()
    Dim studentList As New List(Of Student)

    'On load, loop through students in studentDB and add them to Listbox
    Private Sub StudentView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim tempStudent As New Student

        For Each tempStudent In students
            lbxStudentList.Items.Add(tempStudent.Name)
            studentList.Add(tempStudent)
        Next

        lbxStudentList.SelectedIndex = 0
        lblStudentName.Text = studentList(lbxStudentList.SelectedIndex).Name

    End Sub

    'Update the Student information labels
    Private Sub lbxStudentList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxStudentList.SelectedIndexChanged
        lblStudentName.Text = studentList(lbxStudentList.SelectedIndex).Name
        'To string for curriculum?
        'lblCurriculum.Text = students(lbxStudentList.SelectedIndex).CurrentCurriculum
        'lblExpectedGraduation.Text = studentList(lbxStudentList.SelectedIndex).ExpectedGraduationDate
        lblGPAValue.Text = calculateGPA()
        lblClassesTakenValue.Text = studentList(lbxStudentList.SelectedIndex).SectionsTaken.Count()

    End Sub

    Private Function calculateGPA()

        Dim finalGradePoints As Double = 0.0
        Dim gradePoints As Double = 0.0
        Dim classGradePoints As Double = 0.0
        Dim unitsTaken As Double = 0.0
        Dim totalUnitsTaken As Double = 0.0
        Dim courseDB As Collection = Controller.getCourseDB()
        Dim course As New Course
        Dim enrollment As New Enrollment
        Dim coursesTakenList As ArrayList = studentList(lbxStudentList.SelectedIndex).SectionsTaken
        Dim GPA As Double

        For Each enrollment In coursesTakenList

            'Assign value to letter grade
            Select Case enrollment.Grade
                Case "A"
                    gradePoints = 4.0
                Case "A-"
                    gradePoints = 3.7
                Case "B+"
                    gradePoints = 3.33
                Case "B"
                    gradePoints = 3.0
                Case "B-"
                    gradePoints = 2.7
                Case "C+"
                    gradePoints = 2.3
                Case "C"
                    gradePoints = 2.0
                Case "C-"
                    gradePoints = 1.7
                Case "D+"
                    gradePoints = 1.3
                Case "D"
                    gradePoints = 1.0
                Case "D-"
                    gradePoints = 0.7
                Case "F"
                    gradePoints = 0
                Case "W"
                    gradePoints = 0
            End Select

            'Get course and then get the units for the course
            course = courseDB.Item(enrollment.SectionTaken.CourseID)
            unitsTaken = course.Units

            'Calculate the grade points earned for the class
            classGradePoints = gradePoints * CDbl(unitsTaken)

            'Update the counters for total units taken and final grade points
            totalUnitsTaken += unitsTaken
            finalGradePoints += classGradePoints
        Next

        'Calculate GPA and display to 3 decimal places
        GPA = Math.Round((finalGradePoints / totalUnitsTaken), 3)

        Return GPA.ToString()

    End Function

End Class