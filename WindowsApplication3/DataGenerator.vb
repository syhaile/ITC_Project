Public Class DataGenerator
    Private tempCourseDB As Collection = Controller.getCourseDB


    Private Sub btnClassesBrowse_Click(sender As Object, e As EventArgs) Handles btnClassesBrowse.Click
        txtClassesFileSRC.Enabled = True
        'pop up windows browser for file src
    End Sub

    Private Sub txtCourseName_TextChanged(sender As Object, e As EventArgs) Handles txtCourseName.TextChanged
        If txtCourseName.Text = "" Then
            nudClassesUnits.Enabled = False
            btnClassesAddClass.Visible = False
            cboxClassesCompanion.Enabled = False
            cboxClassesPrerequisites.Enabled = False
        Else
            nudClassesUnits.Enabled = True
            btnClassesAddClass.Visible = True
            cboxClassesCompanion.Enabled = True
            cboxClassesPrerequisites.Enabled = True
        End If
    End Sub

    Private Sub cboxClassesCompanion_CheckedChanged(sender As Object, e As EventArgs) Handles cboxClassesCompanion.CheckedChanged
        If cboxClassesCompanion.Checked = True Then
            txtClassesCompanion.Enabled = True
        Else
            txtClassesCompanion.Enabled = False
            txtClassesCompanion.Text = ""
        End If
    End Sub

    Private Sub cboxClassesPrerequisites_CheckedChanged(sender As Object, e As EventArgs) Handles cboxClassesPrerequisites.CheckedChanged
        If cboxClassesPrerequisites.Checked = True Then
            txtClassesPrerequisites.Enabled = True
        Else
            txtClassesPrerequisites.Enabled = False
            txtClassesPrerequisites.Text = ""
        End If
    End Sub

    Private Sub btnClassesAddClass_Click(sender As Object, e As EventArgs) Handles btnClassesAddClass.Click
        Dim course As New Course(txtCourseName.Text, nudClassesUnits.Value, txtClassesCompanion.Text, txtClassesPrerequisites.Text)
        tempCourseDB.Add(course, course.ID)
        updateCourseDB()
        updateListbox()
        txtCourseName.Text = ""
        nudClassesUnits.Value = 1
        txtClassesCompanion.Text = ""
        txtClassesPrerequisites.Text = ""
        cboxClassesCompanion.Checked = False
        cboxClassesPrerequisites.Checked = False
    End Sub

    Private Sub updateListbox()
        lboxClassesCourses.Items.Clear()
        lboxCurriculumCourses.Items.Clear()
      
        Dim list As New ArrayList
        Dim course As Course
        For Each course In tempCourseDB
            lboxClassesCourses.Items.Add(course.ID & "  " & course.Units)
            lboxCurriculumCourses.Items.Add(course.ID)
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnCurriculumAddGE.Click
        If lboxCurriculumCourses.SelectedIndex = -1 Then
            MessageBox.Show("You must have a course selected in order to attach it to the current curriculum")
        Else
            If lboxCurriculumReqGE.Items.Contains(lboxCurriculumCourses.SelectedItem) = True Then
                MessageBox.Show("That course is already in the current curriculum")
            Else
                lboxCurriculumReqGE.Items.Add(lboxCurriculumCourses.SelectedItem)
                lboxCurriculumCourses.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If lboxClassesCourses.SelectedIndex = -1 Then
            MessageBox.Show("You must have a course selected in order to delete one")
        Else
            tempCourseDB.Remove(lboxClassesCourses.SelectedItem)
            lboxClassesCourses.Items.RemoveAt(lboxClassesCourses.SelectedIndex)
            updateCourseDB()
        End If
    End Sub

    Private Sub updateCourseDB()
        Controller.updateCourseDB(tempCourseDB)
    End Sub

    Private Sub btnCurriculumAddCore_Click(sender As Object, e As EventArgs) Handles btnCurriculumAddCore.Click
        If lboxCurriculumCourses.SelectedIndex = -1 Then
            MessageBox.Show("You must have a course selected in order to attach it to the current curriculum")
        Else
            If lboxCurriculumReqCore.Items.Contains(lboxCurriculumCourses.SelectedItem) = True Then
                MessageBox.Show("That course is already in the current curriculum")
            Else
                lboxCurriculumReqCore.Items.Add(lboxCurriculumCourses.SelectedItem)
                lboxCurriculumCourses.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub btnCurriculumAddElectives_Click(sender As Object, e As EventArgs) Handles btnCurriculumAddElectives.Click
        If lboxCurriculumCourses.SelectedIndex = -1 Then
            MessageBox.Show("You must have a course selected in order to attach it to the current curriculum")
        Else
            If lboxCurriculumElective.Items.Contains(lboxCurriculumCourses.SelectedItem) = True Then
                MessageBox.Show("That course is already in the current curriculum")
            Else
                lboxCurriculumElective.Items.Add(lboxCurriculumCourses.SelectedItem)
                lboxCurriculumCourses.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub DataGenerator_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class