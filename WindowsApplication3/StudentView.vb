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
        lblCurriculumValue.Text = studentList(lbxStudentList.SelectedIndex).CurrentCurriculum.ID
        lblExpectedGraduation.Text = "Expected Graduation Date: " + studentList(lbxStudentList.SelectedIndex).ExpectedGraduationDate.ToString("y")
        lblClassStandingValue.Text = getClassStanding()

    End Sub

    'Update the Student information labels
    Private Sub lbxStudentList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxStudentList.SelectedIndexChanged
        lblStudentName.Text = studentList(lbxStudentList.SelectedIndex).Name
        'To string for curriculum?
        lblCurriculumValue.Text = studentList(lbxStudentList.SelectedIndex).CurrentCurriculum.ID
        lblExpectedGraduation.Text = "Expected Graduation Date: " + studentList(lbxStudentList.SelectedIndex).ExpectedGraduationDate.ToString("y")
        lblGPAValue.Text = calculateGPA()
        lblClassesTakenValue.Text = studentList(lbxStudentList.SelectedIndex).SectionsTaken.Count()
        
    End Sub

    Private Function calculateGPA()

        Dim finalGradePoints As Double = 0.0
        Dim gradePoints As Double = 0.0
        Dim classGradePoints As Double = 0.0
        Dim unitsTaken As Double = 0.0
        Dim totalUnitsTaken As Double = 0.0
        Dim GPA As Double

        For Each enrollment In coursesTakenList

            'Assign value to letter grade

            calculateGPA()

            'Select Case enrollment.Grade
            '    Case "A"
            '        gradePoints = 4.0
            '    Case "A-"
            '        gradePoints = 3.7
            '    Case "B+"
            '        gradePoints = 3.33
            '    Case "B"
            '        gradePoints = 3.0
            '    Case "B-"
            '        gradePoints = 2.7
            '    Case "C+"
            '        gradePoints = 2.3
            '    Case "C"
            '        gradePoints = 2.0
            '    Case "C-"
            '        gradePoints = 1.7
            '    Case "D+"
            '        gradePoints = 1.3
            '    Case "D"
            '        gradePoints = 1.0
            '    Case "D-"
            '        gradePoints = 0.7
            '    Case "F"
            '        gradePoints = 0
            '    Case "W"
            '        gradePoints = 0
            'End Select

            'Get course and then get the units for the course
            unitsTaken = getUnitsTaken()

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

    Function getClassStanding()

        Dim classStanding As String
        Dim unitsTaken As Double = getUnitsTaken()

        Select Case unitsTaken
            Case Is > 134
                classStanding = "Senior"
            Case 90 To 134
                classStanding = "Junior"
            Case 45 To 89
                classStanding = "Sophomore"
            Case 0 To 44
                classStanding = "Freshman"
            Case Else
                classStanding = "Invalid unit count"

        End Select

        Return classStanding
    End Function

    Function getUnitsTaken()
        Dim unitsTaken As Double = 0.0
        Dim course As New Course
        Dim enrollment As New Enrollment
        Dim courseDB As Collection = Controller.getCourseDB()
        Dim coursesTakenList As ArrayList = studentList(lbxStudentList.SelectedIndex).SectionsTaken

        For Each enrollment In coursesTakenList
            course = courseDB.Item(enrollment.SectionTaken.CourseID)
            unitsTaken += course.Units
        Next
        
        Return unitsTaken
    End Function

    Function getMinimumQuartersLeft()
        Dim mininumQuartersLeft As Double = 0.0
        Dim requiredCoreCourses = studentList(lbxStudentList.SelectedIndex).CurrentCurriculum.RequiredCoreCourses.Courses.Count()
        Dim requiredGECourses = studentList(lbxStudentList.SelectedIndex).CurrentCurriculum.RequiredGECourses.Courses.Count()
        Dim ElectiveCourses = 4
        Dim coursesLeftCount As Double = 0.0
        Dim coursesLeftList As ArrayList = New ArrayList()
        Dim tempElectiveList As ArrayList = New ArrayList()
        Dim electiveUnitsRemaining As Integer = Controller.getCurriculumDB.Item(studentList(lbxStudentList.SelectedIndex).CurrentCurriculum.ID).electiveUnitsRequired
        Dim requiredCoreCoursesRemaining As Integer = Controller.getCurriculumDB.Item(studentList(lbxStudentList.SelectedIndex).CurrentCurriculum.ID).RequiredCoreCourses.count()
        Dim requiredGECoursesRemaining As Integer = Controller.getCurriculumDB.Item(studentList(lbxStudentList.SelectedIndex).CurrentCurriculum.RequiredGECourses.count()

        Dim course As New Course
        Dim enrollment As New Enrollment
        Dim coursesTakenList As ArrayList = studentList(lbxStudentList.SelectedIndex).SectionsTaken
        Dim courseDB As Collection = Controller.getCourseDB()
        Dim courseID As String
        Dim requiredCoreCoursesList As ArrayList = studentList(lbxStudentList.SelectedIndex).CurrentCurriculum.RequiredCoreCourses.Courses
        Dim requiredGECoursesList As ArrayList = studentList(lbxStudentList.SelectedIndex).CurrentCurriculum.RequiredGECourses.Courses
        Dim electiveCoursesList As ArrayList = studentList(lbxStudentList.SelectedIndex).CurrentCurriculum.ElectiveCourses.Courses

        For Each courseID In requiredCoreCoursesList
            coursesLeftList.Add(courseDB.Item(courseID))
        Next

        For Each courseID In requiredGECoursesList
            coursesLeftList.Add(courseDB.Item(courseID))
        Next

        For Each courseID In electiveCoursesList
            For Each enrollment In coursesTakenList
                If enrollment.Grade Is Nothing Or enrollment.Grade <= 1.7 Then
                    'Do nothing
                Else
                    electiveUnitsRemaining -= courseDB.Item(courseID).units
                End If
            Next
        Next

        If electiveUnitsRemaining < 0 Then
            electiveUnitsRemaining = 0
        End If



        'For Each enrollment In coursesTakenList
        '    course = courseDB.Item(enrollment.SectionTaken.CourseID)
        '    unitsTaken += course.Units
        'Next

        Return mininumQuartersLeft

    End Function

    Function calculateGradePoints()

        Dim enrollment As New Enrollment
        Dim coursesTakenList As ArrayList = studentList(lbxStudentList.SelectedIndex).SectionsTaken
        Dim gradePoints As Double = 0.0

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

        Next

        Return gradePoints

    End Function

End Class