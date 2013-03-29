Public Class Form1
    Dim ctrlCourseDB As New CoursesDatabase
Private Sub ListView1_SelectedIndexChanged( sender As System.Object,  e As System.EventArgs) Handles ListView1.SelectedIndexChanged

End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Course As New Course
        Course.ID = "CIS-304"
        Course.Units = 4
        Course.DateOffered = Now.ToShortDateString
        Course.TimeOffered = Now.ToShortTimeString



    End Sub
End Class
