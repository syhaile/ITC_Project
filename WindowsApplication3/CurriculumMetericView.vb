Public Class CurriculumMetericView
   
    Dim curriculumQuarterAndDate As String = "Spring 2012"
    
    Private Sub CurriculumMetericView_Load( sender As Object,  e As EventArgs) Handles MyBase.Load
            lblMetricsTitle.Text = curriculumQuarterAndDate + " Metrics"
            lblCurriculumTitle.Text = curriculumQuarterAndDate + " Curriculum"
    End Sub
    Private Sub CurriculumMetricView_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        CurriculumView.Show()
    End Sub

Private Sub lblMetricsTitle_Click( sender As Object,  e As EventArgs) Handles lblMetricsTitle.Click

End Sub
End Class