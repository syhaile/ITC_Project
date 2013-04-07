Public Class StudentView

    Dim ctrlStudentDB As New StudentDatabase

    Private Sub StudentView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim students As Collection = Controller.getStudentDB()
        Dim studentList As ArrayList = New ArrayList()
        Dim tempStudent As New Student

        For Each tempStudent In students
            studentList.Add(New Student() With {.ID = tempStudent.ID, .Name = tempStudent.Name})
            lbxStudentList.DataSource = studentList
            lbxStudentList.ValueMember = "ID"
            lbxStudentList.DisplayMember = "Name"
        Next

    End Sub

    Private Sub lbxStudentList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxStudentList.SelectedIndexChanged

    End Sub
End Class