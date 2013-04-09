Imports System.ComponentModel

Public Class CurriculumMetericView

    'in class variables for handling data generation 
    Private m_graduatedStudents, m_droppedStudents, m_minTimeTaken, m_maxTimeTaken, m_minNumberUnits, m_maxNumberUnits,
        m_avgTimeTaken, m_avgNumberofUnitsRemaining, m_avgNubmerOfUnitsTaken, m_curriculum As String



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
    Dim curriclumList As New List(Of Curriculum)
    Dim tempCurriculum As New Curriculum

    Public Sub CurriculumMetericView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ClassBox.Hide()
        lblMetricsTitle.Text = m_curriculum + " Metrics"
        lblCurriculumTitle.Text = m_curriculum + " Curriculum"

        'generate a list of curriculums
        For Each tempCurriculum In curriculums
            cmbxCurriclum.Items.Add(tempCurriculum.ID)
            curriclumList.Add(tempCurriculum)

        Next

        'generate a list of students 
        For Each tempStudent In students
            studentList.Add(tempStudent)
            For Each Student In studentList
                
            Next
        Next


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxCurriclum.SelectedIndexChanged
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


End Class