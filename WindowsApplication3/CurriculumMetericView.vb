Imports System.ComponentModel

Public Class CurriculumMetericView

    'in class variables for handling data generation 
    Private m_graduatedStudents As Integer
    Private m_curriculum As String
    Private m_maxUnits, m_minUnits, m_avgUnits As String 
    'For displaying class information in the class metrics view
    Dim courses As Collection = Controller.getCourseDB
    Dim courseList As New List(Of Course)
    Dim tempCourse As New Course
    Dim enrollment As New Enrollment

    'For displaying information about students from their curriculums
    Dim students As Collection = Controller.getStudentDB
    Dim studentList As New List(Of Student)
    Dim tempStudent As New Student
    Dim unitsTaken As New ArrayList

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

    End Sub

    'handles user changes to the selected curriculum year 
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxCurriclum.SelectedIndexChanged

        'functions and stuff
        titleChanges()
        populateCurriculums()
        calcedGraduated()
        Units()

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

    End Sub

    Public Sub avgQuarterRemaining()

    End Sub

    Public Sub time()

    End Sub

    Public Function avgTime() 'in quarters 

    End Function

    Public Function minTime() 'in quarters 

    End Function

    Public Function maxTime() 'in quarters 

    End Function

    ' these four blocks of code are used to determine unit metrics 
    Public Sub Units()
        'Dim unitsTaken As Integer
        Dim unitArray As new ArrayList
        
        'Dim coursesTakenList As ArrayList = tempStudent.SectionsTaken
        'For Each Me.enrollment In coursesTakenList
        '    tempCourse = courses.Item(enrollment.SectionTaken.CourseID)
        '    unitsTaken += tempCourse.Units
        '    unitArray.Add(unitsTaken)
        'Next 

            unitArray.Add(4)
            unitArray.Add(16)

        m_maxUnits = (maxUnits(unitArray)).ToString
        m_minUnits = (minUnits(unitArray)).ToString
        m_avgUnits = (avgUnits(unitArray)).ToString
        
        lblMaxUnit.Text = "Maximum units taken: " + m_maxUnits
        lblMinUnit.Text = "Minimum units taken: " + m_minUnits
        lblAvgUnits.Text = "Average units taken: " + m_avgUnits

    End Sub 'working so far 

    Public Function avgUnits(ByVal unitArray As ArrayList)
        Dim units As Integer = Nothing 
        Dim num As Integer = Nothing 
        Dim calc As Double = Nothing 
        For i As Integer = 0 to (unitArray.Count - 1)
            units += unitArray(i) 

            unitArray.Count.ToString 
            num = unitArray.Count
            calc = units / num
        Next
        avgUnits = calc 
        Return avgUnits
    End Function 'working so far 

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