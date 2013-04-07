Public Class CurriculumMetericView
   
    Private m_graduatedStudents, m_droppedStudents, m_minTimeTaken, m_maxTimeTaken, m_minNumberUnits, m_maxNumberUnits As Integer
    Private m_avgGPA, m_avgTimeTaken, m_avgNumberofUnitsRemaining, m_avgNubmerOfUnitsTaken As Double
    Private curriculumQuarterAndDate As String = "Spring 2012"
    Dim node As TreeNode 
 
    Private Sub CurriculumMetericView_Load( sender As Object,  e As EventArgs) Handles MyBase.Load
            Dim avgGPA As Double = 2.6           
            lblMetricsTitle.Text = curriculumQuarterAndDate + " Metrics"
            lblCurriculumTitle.Text = curriculumQuarterAndDate + " Curriculum"
            Dim m_avgGPAString As String = avgGPA.ToString()
            lblAvgGPA.Text = "Average GPA: " + m_avgGPAString
        
            'Populating the treeview for curriculum 
             node = New TreeNode 
    End Sub

    Private Sub CurriculumMetricView_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        CurriculumView.Show()
    End Sub

End Class