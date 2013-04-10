Imports System.ComponentModel

Public Class CurriculumMetericView

    'in class variables for handling data generation 
    Private m_graduatedStudents, m_droppedStudents As Integer
    Private m_curriculum As String
    Private m_maxUnits, m_minUnits, m_avgUnits, m_unitsLeft As String ' for unit metrics 
    Private m_maxTime, m_minTime, m_avgTime As String ' for time metrics 

    'For displaying class information in the class metrics view
    Dim courses As Collection = Controller.getCourseDB
    Dim courseList As New List(Of Course)
    Dim tempCourse As New Course
    Dim enrollment As New Enrollment

    Dim enrollmentList As New List(Of Enrollment)

    'For displaying information about students from their curriculums
    Dim students As Collection = Controller.getStudentDB
    Dim studentList As New List(Of Student)
    Dim tempStudent As New Student
    Dim unitsTaken As New ArrayList
    Dim quartersAttended As New ArrayList

    'For dispalying curriculum centric data
    Dim curriculums As Collection = Controller.getCurriculumDB
    Dim curriculumList As New List(Of Curriculum)
    Dim tempCurriculum As New Curriculum

    'handles events that occur during the view load 
    Public Sub CurriculumMetericView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'hides the classBox and then also changes the titles depending on the selected curriculum
        ClassBox.Hide()
        lblMetricsTitle.Text = m_curriculum + " Metrics"
        lblCurriculumTitle.Text = m_curriculum + " Curriculum"

        'generate a list of curriculums
        For Each Me.tempCurriculum In curriculums
            cmbxCurriclum.Items.Add(tempCurriculum.ID)
            curriculumList.Add(tempCurriculum)
        Next

        For Each tempStudent In students
            studentList.Add(tempStudent)
        Next
    End Sub

    'handles user changes to the selected curriculum year 
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxCurriclum.SelectedIndexChanged

        'functions and stuff
        titleChanges()
        populateCurriculums()
        calcedGraduated()
        Units()
        time()

    End Sub 

    'handles user selection of different classes in the curriculum
    Private Sub lbxCurriculum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxCurriculum.SelectedIndexChanged
        
        'displays the class box after class is selected
        ClassBox.Show()

        'changes the classbox label
        ClassBox.Text = courseList(lbxCurriculum.SelectedIndex).ID

        'updates the unit label to display class units
        lblUnit.Text = "Units: " + courseList(lbxCurriculum.SelectedIndex).Units.ToString

        'For each loop for displaying the prerequisite classes 
        lblPrereq.Text = "Prerequite(s): "
        For Each PreRequisitCourse As String In courseList(lbxCurriculum.SelectedIndex).PreRequisitCourse()
            lblPrereq.Text += PreRequisitCourse + " "
        Next

        'displays the companion courses for a class 
        lblCompanion.Text = "Companion Course(s): " + courseList(lbxCurriculum.SelectedIndex).CompanionCourse

    End Sub 

    'Used to change the curriculum view titles 
    Public Sub titleChanges()
        'updating the titles 
        m_curriculum = curriculumList(cmbxCurriclum.SelectedIndex).ID
        lblMetricsTitle.Text = m_curriculum + " Metrics"
        lblCurriculumTitle.Text = m_curriculum + " Curriculum"

    End Sub 'working so far  

    'populates the curriculum
    Public Sub populateCurriculums()
        
        'resets the listbox for classes in a curriculum
        lbxCurriculum.Items.Clear()
        
        'These for loops go through and add the different classes into the curriculum view 
        For Each cid As String In tempCurriculum.ElectiveCourses.Courses
            tempCourse.ID = cid
            lbxCurriculum.Items.Add(tempCourse.ID)
            courseList.Add(courses.Item(tempCourse.ID))
        Next

        For Each cid As String In tempCurriculum.RequiredCoreCourses.Courses
            tempCourse.ID = cid
            lbxCurriculum.Items.Add(tempCourse.ID)
            courseList.Add(courses.Item(tempCourse.ID))
        Next

        For Each cid As String In tempCurriculum.RequiredGECourses.Courses
            tempCourse.ID = cid
            lbxCurriculum.Items.Add(tempCourse.ID)
            courseList.Add(courses.Item(tempCourse.ID))
        Next

    End Sub 'working so far 

    'For calculating graduated amount 
    Public Sub calcedGraduated()

        'not sure if this is actually working or not; currently unable to test 
        For Each classCount In students
            Dim graduationCounter As Integer
            classCount = tempStudent.Courses.Count
            If classCount >= 59 Then
                graduationCounter += 1
                m_graduatedStudents = graduationCounter
            Else

            End If
        Next
        Dim grad As String
        grad = m_graduatedStudents.ToString
        lblGrad.Text = "Graduated Students: " + grad

    End Sub 'Unsure if working or not 

    Public Sub calcedDropped()

    End Sub 'not finished 

    Public Sub time()
        ' Dim quarterCount As Integer = 0
        Dim currentQuarter As String = ""
        Dim currentYear As Integer = 0

        Dim quarterArray As New ArrayList
        Dim totalQuarterArray As New ArrayList

        For Each std As Student In studentList
            If std.CurrentCurriculum.ID = curriculumList(cmbxCurriclum.SelectedIndex).ID Then
                quarterArray.Add(std.SectionsTaken)
            End If
        Next

        For Each enrollarray As ArrayList In quarterArray
            Dim quarterCount As Integer = 0
            For Each enroll As Enrollment In enrollarray
                If ((Not enroll.Quarter = currentQuarter Or Not _
                    enroll.Year = currentYear) Or enroll.Quarter = Nothing) Then
                    quarterCount += 1
                    currentQuarter = enroll.Quarter
                    currentYear = enroll.Year
                End If
            Next
            totalQuarterArray.Add(quarterCount)
        Next

        m_maxTime = (maxTime(totalQuarterArray)).ToString
        m_minTime = (minTime(totalQuarterArray)).ToString
        m_avgTime = (avgTime(totalQuarterArray)).ToString

        lblMaxTime.Text = "Maximum quarters attended: " + m_maxTime
        lblMinTime.Text = "Minimum quarters attended: " + m_minTime
        lblAvgTime.Text = "Average quarters attended: " + m_avgTime

    End Sub 'This needs much work 

    Public Function avgTime(ByVal quarterArray As ArrayList) 'in quarters 
        Dim quarters As Integer = Nothing
        Dim num As Integer = Nothing
        Dim calc As Double = Nothing
        For i As Integer = 0 To (quarterArray.Count - 1)
            quarters += quarterArray(i)

            quarterArray.Count.ToString()
            num = quarterArray.Count
            calc = quarters / num
        Next
        avgTime = calc
        Return avgTime

    End Function 'cant test yet

    Public Function minTime(ByVal quarterArray As ArrayList) 'in quarters 
        Dim min As Integer = Nothing

        For i As Integer = 0 To (quarterArray.Count - 1)
            If i = 0 Then
                min = quarterArray(i)
            Else
                If quarterArray(i) < min Then min = quarterArray(i)
            End If
        Next
        minTime = min
        Return minTime

    End Function 'cant test yet

    Public Function maxTime(ByVal quarterArray As ArrayList) 'in quarters 
        Dim max As Integer = Nothing

        For i As Integer = 0 To (quarterArray.Count - 1)
            If i = 0 Then
                max = quarterArray(i)
            Else
                If quarterArray(i) > max Then max = quarterArray(i)
            End If
        Next
        maxTime = max
        Return maxTime

    End Function 'cant test yet






    ' these four blocks of code are used to determine unit metrics 
    Public Sub Units()

        Dim unitArray As new ArrayList
        Dim course As New Course
        Dim courseDB As Collection = Controller.getCourseDB()
         
        'Dim coursesTakenList As ArrayList = tempStudent.SectionsTaken
        
        Dim sectionArray As New ArrayList

        For Each std As Student In studentList
            If std.CurrentCurriculum.ID = curriculumList(cmbxCurriclum.SelectedIndex).ID Then
                sectionArray.Add(std.SectionsTaken)
            End If
        Next

        For Each enrollarray As ArrayList In sectionArray
            Dim unitsTaken As Integer = 0
            For Each enroll As Enrollment In enrollarray
                tempCourse = courses.Item(enroll.SectionTaken.CourseID)
                unitsTaken += tempCourse.Units

            Next
            unitArray.Add(unitsTaken)
        Next

        m_maxUnits = (maxUnits(unitArray)).ToString
        m_minUnits = (minUnits(unitArray)).ToString
        m_avgUnits = (avgUnits(unitArray)).ToString
        ' m_unitsLeft = (avgUnitsRemaining()).ToString

        lblMaxUnit.Text = "Maximum units taken: " + m_maxUnits
        lblMinUnit.Text = "Minimum units taken: " + m_minUnits
        lblAvgUnits.Text = "Average units taken: " + m_avgUnits
        'lblAvgRemaining.Text = "Average Remaining Units: " + m_unitsLeft

    End Sub 'works for avg, max, and min 

    Public Function avgUnits(ByVal unitArray As ArrayList)
        Dim units As Integer = Nothing 
        Dim num As Integer = Nothing 
        Dim calc As Double = Nothing 
        For i As Integer = 0 to (unitArray.Count - 1)
            units += unitArray(i) 

            'unitArray.Count.ToString 
            num = unitArray.Count
            calc = units / num
        Next
        avgUnits = calc 
        Return avgUnits
    End Function 'working so far 

    Public Function avgUnitsRemaining()
        avgUnitsRemaining = "0"
        Return avgUnitsRemaining
    End Function 'not working 

    Public Function maxUnits(ByVal unitArray As ArrayList)
        Dim max As Integer = Nothing 
 
        For i As Integer = 0 to (unitArray.Count - 1)
            If i = 0 then 
                max = unitArray(i)
            Else 
                If unitArray(i) > max then max = unitArray(i)
            End If
        Next
        maxUnits = max 
        Return maxUnits
    End Function 'working so far 

    Public Function minUnits(ByVal unitArray As ArrayList) 
        Dim min As Integer = Nothing 
 
        For i As Integer = 0 to (unitArray.Count - 1)
            If i = 0 then 
                min = unitArray(i)
            Else 
                If unitArray(i) < min then min = unitArray(i)
            End If
        Next
        minUnits = min 
        Return minUnits
    End Function 'working so far 

End Class