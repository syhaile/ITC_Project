﻿Imports System.IO

Public Class DataGenerator
    Private tempCourseDB As Collection = Controller.getCourseDB
    Private tempCurriculumCollection As Collection = Controller.getCurriculumDB


    Private Sub btnClassesBrowse_Click(sender As Object, e As EventArgs) Handles btnClassesBrowse.Click
        txtClassesFileSRC.Enabled = True
        txtClassesFileSRC.Text = "C:\courses.txt"
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
        tempCourseDB = Controller.getCourseDB
        Dim templist As New ArrayList()
        For Each word As String In txtClassesPrerequisites.Text.Split(" ")
            templist.Add(word)
        Next
        Dim course As New Course(txtCourseName.Text, nudClassesUnits.Value, txtClassesCompanion.Text, templist)
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
        tempCourseDB = Controller.getCourseDB
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

    Private Sub btnRandomGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRandomGenerate.Click
        Dim myGenerator As New StudentGenerator(Controller.getCurriculumDB, Controller.getCourseDB)
        Dim mylist As ArrayList = myGenerator.generateStudents
        For Each st As Student In mylist
            testbox.Text += st.ID + " " + vbNewLine
        Next
    End Sub

    Private Sub btnClassesImport_Click(sender As Object, e As EventArgs) Handles btnClassesImport.Click
        Dim reader As New StreamReader(txtClassesFileSRC.Text)
        Dim stringReader As String = reader.ReadLine()


        While Not stringReader Is Nothing
            Dim lineValue() As String = stringReader.Split(vbTab)

            Dim preRequisitArray As New ArrayList
            Dim tempCourse As New Course
            tempCourse.ID = lineValue(0)
            tempCourse.Units = Integer.Parse(lineValue(1))

            Dim preRequisit() As String = lineValue(2).Split(",")
            For index = 0 To preRequisit.Count - 1 Step 1
                preRequisitArray.Add(index)
            Next

            tempCourse.PreRequisitCourse = preRequisitArray
            tempCourse.CompanionCourse = lineValue(3)
            tempCourseDB.Add(tempCourse, tempCourse.ID)
            lboxClassesCourses.Items.Add(tempCourse.ID)
            stringReader = reader.ReadLine()
        End While

        updateCourseDB()
        updateListbox()
    End Sub

 
    Private Sub btnCurriculumBrowse_Click(sender As Object, e As EventArgs) Handles btnCurriculumBrowse.Click
        txtCurriculumFileSrc.Enabled = True
        txtCurriculumFileSrc.Text = "C:\curriculumTest.txt"

    End Sub



    Private Sub btnCurriculumImport_Click(sender As Object, e As EventArgs) Handles btnCurriculumImport.Click
        Dim curriculumYear As String = ""
        Dim reqGE, reqCore, reqElect, reqGEStart, reqGEEnd, reqCoreStart, reqCoreEnd, reqElectStart, reqElectEnd As Integer
        Dim reader As New StreamReader(txtCurriculumFileSrc.Text)
        Dim stringReader As String = reader.ReadLine()
        Dim reqGEArray, reqCoreArray, reqElectArray, allCourses As New ArrayList

        While Not stringReader Is Nothing
            Dim lineValue() As String = stringReader.Split(vbTab)

            'Determine location of "curriculum year", "Category's"
            For index = 0 To lineValue.Count - 1 Step 1
                If lineValue(index) = "CURRICULUM YEAR" Then
                    curriculumYear = lineValue(index + 1)
                End If

                If lineValue(index) = "CATEGORY" Then
                    If lineValue(index + 1) = "Require GE" Then
                        reqGE = index + 1
                    ElseIf lineValue(index + 1) = "Required Core" Then
                        reqCore = index + 1
                    ElseIf lineValue(index + 1) = "Elective Core" Then
                        reqElect = index + 1
                    End If
                End If
            Next

            'Set start and end location
            reqGEStart = reqGE + 1
            reqGEEnd = reqCore - 2
            reqCoreStart = reqCore + 1
            reqCoreEnd = reqElect - 2
            reqElectStart = reqElect + 1
            reqElectEnd = lineValue.Count - 1

            'Get Required GE Courses
            For index = reqGEStart To reqGEEnd Step 1
                reqGEArray.Add(lineValue(index))
            Next

            'Get Required Core Courses
            For index = reqCoreStart To reqCoreEnd Step 1
                reqCoreArray.Add(lineValue(index))
            Next

            'Get Elective Courses
            For index = reqElectStart To reqElectEnd Step 1
                reqElectArray.Add(lineValue(index))
            Next

            'set Required GE Courses
            Dim tempReqGE As New RequiredGECourses
            For index = 0 To reqGEArray.Count - 1 Step 1
                tempReqGE.addCourse(reqGEArray(index))
                lboxCurriculumReqGE.Items.Add(reqGEArray(index))
            Next

            'set Required Core Courses
            Dim tempReqCore As New RequiredCoreCourses
            For index = 0 To reqCoreArray.Count - 1 Step 1
                tempReqCore.addCourse(reqCoreArray(index))
                lboxCurriculumReqCore.Items.Add(reqCoreArray(index))
            Next

            'set Elective Courses
            Dim tempElective As New ElectiveCoreCourses
            For index = 0 To reqElectArray.Count - 1 Step 1
                tempElective.addCourse(reqElectArray(index))
                lboxCurriculumElective.Items.Add(reqCoreArray(index))
            Next

            'set Curriculum
            Dim tempCurriculum As New Curriculum
            tempCurriculum.ID = curriculumYear
            tempCurriculum.RequiredGECourses = tempReqGE
            tempCurriculum.RequiredCoreCourses = tempReqCore
            tempCurriculum.ElectiveCourses = tempElective
            tempCurriculumCollection.Add(tempCurriculum, tempCurriculum.ID)



            Controller.updateCurriculumDB(tempCurriculumCollection)

            stringReader = reader.ReadLine()
        End While


    End Sub

   
End Class