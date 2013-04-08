Public Class StudentView

    Dim students As Collection = Controller.getStudentDB()
    Dim studentList As New List(Of Student)

    'On load, loop through students in studentDB and add them to Listbox
    Private Sub StudentView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim tempStudent As New Student

        For Each tempStudent In students
            lbxStudentList.Items.Add(tempStudent.Name)
            studentList.Add(tempStudent)
        Next

        lbxStudentList.SelectedIndex = 0
        lblStudentName.Text = studentList(lbxStudentList.SelectedIndex).Name

    End Sub

    'Update the Student information labels
    Private Sub lbxStudentList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxStudentList.SelectedIndexChanged
        lblStudentName.Text = studentList(lbxStudentList.SelectedIndex).Name
        'To string for curriculum?
        'lblCurriculum.Text = students(lbxStudentList.SelectedIndex).CurrentCurriculum
        'lblExpectedGraduation.Text = studentList(lbxStudentList.SelectedIndex).ExpectedGraduationDate
        'lblGPAValue.Text = studentList(lbxStudentList.SelectedIndex).GPA

    End Sub


End Class