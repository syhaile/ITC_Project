Public Class StudentView

    Dim ctrlStudentDB As New StudentDatabase

    Private Sub StudentView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim students As Collection = Controller.getStudentDB()
        Dim studentList As ArrayList = New ArrayList()
        Dim tempStudent As Student

        MessageBox.Show(students.Count())

        For Each tempStudent In students

            'lbxStudentList.DataSource = students
            lbxStudentList.ValueMember = tempStudent.ID.ToString()
            lbxStudentList.DisplayMember = tempStudent.Name.ToString()
        Next

    End Sub

    Private Sub lbxStudentList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxStudentList.SelectedIndexChanged

    End Sub
End Class