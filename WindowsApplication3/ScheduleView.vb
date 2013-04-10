Public Class ScheduleView

    Private Sub lboxQuarters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lboxQuarters.SelectedIndexChanged
        If Not lboxQuarters.SelectedIndex = -1 Then
            pnlQuarter.Visible = True
            pnlClass.Visible = True
        End If
    End Sub

    Private Sub lboxClasses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lboxClasses.SelectedIndexChanged
        If Not lboxClasses.SelectedIndex = -1 Then
            pnlClassMetrics.Visible = True
        End If
    End Sub

    Private Sub ScheduleView_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class