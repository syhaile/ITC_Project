Imports System.ComponentModel

Public Class CurriculumMetericView

    'in class variables for handling data generation 
    Private m_graduatedStudents As Integer
    Private m_curriculum As String
    'For displaying class information in the class metrics view
    Dim classes As Collection = Controller.getCourseDB
    Dim classList As New List(Of Course)
    Dim tempClass As New Course

    'For displaying information about students from their curriculums
    Dim students As Collection = Controller.getStudentDB
    Dim studentList As New List(Of Student)
    Dim tempStudent As New Student
    Dim unitsTaken As New ArrayList
    Dim Courses As String

    'For dispalying curriculum centric data
    Dim curriculums As Collection = Controller.getCurriculumDB
    Dim curriculumList As New List(Of Curriculum)
    Dim tempCurriculum As New Curriculum

    Public Sub CurriculumMetericView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ClassBox.Hide()
        lblMetricsTitle.Text = m_curriculum + " Metrics"
        lblCurriculumTitle.Text = m_curriculum + " Curriculum"

        'generate a list of curriculums
        For Each tempCurriculum In curriculums
            cmbxCurriclum.Items.Add(tempCurriculum.ID)
            curriculumList.Add(tempCurriculum)

        Next




    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxCurriclum.SelectedIndexChanged

        titleChanges()
        populateCurriculums()
        calcedGraduated()

    End Sub

    Private Sub lbxCurriculum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxCurriculum.SelectedIndexChanged
        ClassBox.Show()

        ClassBox.Text = classList(lbxCurriculum.SelectedIndex).ID
        lblUnit.Text = "Units: " + classList(lbxCurriculum.SelectedIndex).Units.ToString

        'For each loop for displaying the prerequisite classes 
        lblPrereq.Text = "Prerequite(s): "
        For Each PreRequisitCourse As String In classList(lbxCurriculum.SelectedIndex).PreRequisitCourse()

            lblPrereq.Text += PreRequisitCourse + " "
        Next

        lblCompanion.Text = "Companion Course(s): " + classList(lbxCurriculum.SelectedIndex).CompanionCourse


    End Sub

    Public Sub titleChanges()
        'updating the titles 
        m_curriculum = curriculumList(cmbxCurriclum.SelectedIndex).ID
        lblMetricsTitle.Text = m_curriculum + " Metrics"
        lblCurriculumTitle.Text = m_curriculum + " Curriculum"

    End Sub

    Public Sub populateCurriculums()
        lbxCurriculum.Items.Clear()

        For Each cid As String In tempCurriculum.ElectiveCourses.Courses
            tempClass.ID = cid
            lbxCurriculum.Items.Add(tempClass.ID)
            classList.Add(classes.Item(tempClass.ID))
        Next

        For Each cid As String In tempCurriculum.RequiredCoreCourses.Courses
            tempClass.ID = cid
            lbxCurriculum.Items.Add(tempClass.ID)
            classList.Add(classes.Item(tempClass.ID))
        Next

        For Each cid As String In tempCurriculum.RequiredGECourses.Courses
            tempClass.ID = cid
            lbxCurriculum.Items.Add(tempClass.ID)
            classList.Add(classes.Item(tempClass.ID))
        Next

    End Sub

    'For calculating graduated amount 
    Public Sub calcedGraduated()
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
    End Sub

    Public Sub calcedDropped()

    End Sub

    Public Sub avgQuarterRemaining()

    End Sub

    Public Sub avgTime()

    End Sub

    Public Sub minTime()

    End Sub

    Public Sub maxTime()

    End Sub

    Public Sub avgUnits()

    End Sub

    Public Sub minUnits()

    End Sub

    Public Sub maxUnits()

    End Sub

End Class