Imports System.IO

Public Class DataGenerator
    Private tempCourseDB As Collection = Controller.getCourseDB
    Private tempCurriculumCollection As Collection = Controller.getCurriculumDB
    Private classesLocalFile As Boolean = True
    Private curriculumLocalFile As Boolean = True
    Private studentLocalFile As Boolean = True

    Private Function ReadFile(ByVal url As String) As StreamReader
        Dim req As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(url)
        Dim rep As System.Net.HttpWebResponse = req.GetResponse()
        Dim str As New System.IO.StreamReader(rep.GetResponseStream)

        Return str
    End Function

    Private Sub btnClassesBrowse_Click(sender As Object, e As EventArgs) Handles btnClassesBrowse.Click
        txtClassesFileSRC.Enabled = True
        Dim input As Integer = MessageBox.Show("Is the file a local file?", "File Import", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If input = vbYes Then
            Dim fbd As New OpenFileDialog
            If fbd.ShowDialog = DialogResult.OK Then
                txtClassesFileSRC.Text = fbd.FileName
            End If
            classesLocalFile = True
        ElseIf input = vbNo Then
            Dim fileLocation As String = InputBox("Please enter the web location of file you wish to upload", "Web File Import", "http://www.csupomona.edu/~mavenegas/courses.txt")
            txtClassesFileSRC.Text = fileLocation
            classesLocalFile = False
        End If
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
            lboxCurriculumReqGE.Items.Add(lboxCurriculumCourses.SelectedItem)
            lboxCurriculumReqGE.SelectedItem = lboxCurriculumCourses.SelectedItem
            lboxCurriculumCourses.Items.Remove(lboxCurriculumCourses.SelectedItem)
            lboxCurriculumCourses.SelectedIndex = -1
            updateCurriculumDB()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If lboxClassesCourses.SelectedIndex = -1 Then
            MessageBox.Show("You must have a course selected in order to remove one")
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
            lboxCurriculumReqCore.Items.Add(lboxCurriculumCourses.SelectedItem)
            lboxCurriculumReqCore.SelectedItem = lboxCurriculumCourses.SelectedItem
            lboxCurriculumCourses.Items.Remove(lboxCurriculumCourses.SelectedItem)
            lboxCurriculumCourses.SelectedIndex = -1
            updateCurriculumDB()
        End If
    End Sub

    Private Sub btnCurriculumAddElectives_Click(sender As Object, e As EventArgs) Handles btnCurriculumAddElectives.Click
        If lboxCurriculumCourses.SelectedIndex = -1 Then
            MessageBox.Show("You must have a course selected in order to attach it to the current curriculum")
        Else
            lboxCurriculumElective.Items.Add(lboxCurriculumCourses.SelectedItem)
            lboxCurriculumElective.SelectedItem = lboxCurriculumCourses.SelectedItem
            lboxCurriculumCourses.Items.Remove(lboxCurriculumCourses.SelectedItem)
            lboxCurriculumCourses.SelectedIndex = -1
            updateCurriculumDB()
        End If
    End Sub

    Private Sub btnRandomGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRandomGenerate.Click
        Dim myGenerator As New StudentGenerator(Controller.getCurriculumDB, Controller.getCourseDB)
        Dim mylist As ArrayList = myGenerator.generateStudents
        For Each st As Student In mylist
            testbox.Text += st.ID + " " + vbNewLine
        Next
    End Sub

    Private Sub btnClassesImport_Click(sender As Object, e As EventArgs) Handles btnClassesImport.Click
        Dim stringReader As String
        Dim reader As StreamReader

        If classesLocalFile = True Then
            reader = New StreamReader(txtClassesFileSRC.Text)
            stringReader = reader.ReadLine()
        Else
            reader = ReadFile(txtClassesFileSRC.Text)
            stringReader = reader.ReadLine()

        End If




        While Not StringReader Is Nothing
            Dim lineValue() As String = StringReader.Split(vbTab)

            Dim preRequisitArray As New ArrayList
            Dim tempCourse As New Course
            tempCourse.ID = lineValue(0)
            tempCourse.Units = Integer.Parse(lineValue(1))

            Dim preRequisit() As String = lineValue(2).Split(",")
            For index = 0 To preRequisit.Count - 1 Step 1
                preRequisitArray.Add(preRequisit(index))
            Next

            tempCourse.PreRequisitCourse = preRequisitArray
            tempCourse.CompanionCourse = lineValue(3)
            tempCourseDB.Add(tempCourse, tempCourse.ID)
            lboxClassesCourses.Items.Add(tempCourse.ID)
            StringReader = reader.ReadLine()
        End While

        updateCourseDB()
        updateListbox()
    End Sub


    Private Sub btnCurriculumBrowse_Click(sender As Object, e As EventArgs) Handles btnCurriculumBrowse.Click
        txtCurriculumFileSrc.Enabled = True
        Dim input As Integer = MessageBox.Show("Is the file a local file?", "File Import", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If input = vbYes Then
            Dim fbd As New OpenFileDialog
            If fbd.ShowDialog = DialogResult.OK Then
                txtCurriculumFileSrc.Text = fbd.FileName
            End If
            curriculumLocalFile = True
        ElseIf input = vbNo Then
            Dim fileLocation As String = InputBox("Please enter the web location of file you wish to upload", "Web File Import", "http://www.csupomona.edu/~mavenegas/curriculumTest.txt")
            txtCurriculumFileSrc.Text = fileLocation
            curriculumLocalFile = False
        End If

    End Sub



    Private Sub btnCurriculumImport_Click(sender As Object, e As EventArgs) Handles btnCurriculumImport.Click
        Dim curriculumYear As String = ""
        Dim reqGE, reqCore, reqElect, reqGEStart, reqGEEnd, reqCoreStart, reqCoreEnd, reqElectStart, reqElectEnd As Integer
        Dim stringReader As String
        Dim reader As StreamReader

        If curriculumLocalFile = True Then
            reader = New StreamReader(txtCurriculumFileSrc.Text)
        Else
            reader = ReadFile(txtCurriculumFileSrc.Text)
        End If

        stringReader = reader.ReadLine()

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
            reqElectStart = reqElect + 2
            reqElectEnd = lineValue.Count - 1

            Dim reqElectiveUnits As String = lineValue(reqElect + 1)
            Dim reqGEArray, reqCoreArray, reqElectArray, allCourses As New ArrayList

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
            Next

            'set Required Core Courses
            Dim tempReqCore As New RequiredCoreCourses
            For index = 0 To reqCoreArray.Count - 1 Step 1
                tempReqCore.addCourse(reqCoreArray(index))
            Next

            'set Elective Courses
            Dim tempElective As New ElectiveCoreCourses
            For index = 0 To reqElectArray.Count - 1 Step 1
                tempElective.addCourse(reqElectArray(index))
            Next

            'set Curriculum
            Dim tempCurriculum As New Curriculum
            tempCurriculum.ID = curriculumYear
            tempCurriculum.RequiredGECourses = tempReqGE
            tempCurriculum.RequiredCoreCourses = tempReqCore
            tempCurriculum.ElectiveCourses = tempElective
            If Not tempCurriculumCollection.Contains(tempCurriculum.ID) Then
                tempCurriculumCollection.Add(tempCurriculum, tempCurriculum.ID)
            Else
                tempCurriculumCollection.Remove(tempCurriculum.ID)
                tempCurriculumCollection.Add(tempCurriculum, tempCurriculum.ID)
            End If



            Controller.updateCurriculumDB(tempCurriculumCollection)

            stringReader = reader.ReadLine()
        End While
        updateComboBox()
        ''set curriculum year
        'cboCurriculumYear.Items.Add(curriculumYear)
        'cboCurriculumYear.SelectedItem = curriculumYear
        'lboxCurriculumReqGE.Items.Add(reqGEArray(index))
        ' lboxCurriculumReqCore.Items.Add(reqCoreArray(index))
        'lboxCurriculumElective.Items.Add(reqCoreArray(index))

    End Sub

    Private Sub updateComboBox()
        cboCurriculumYear.Items.Clear()
        tempCurriculumCollection = Controller.getCurriculumDB
        Dim tempCurriculum As New Curriculum
        For Each tempCurriculum In tempCurriculumCollection
            cboCurriculumYear.Items.Add(tempCurriculum.ID)
        Next
    End Sub

    Private Sub lboxCurriculumReqGE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lboxCurriculumReqGE.SelectedIndexChanged
        If Not lboxCurriculumReqGE.SelectedIndex = -1 Then
            lboxCurriculumElective.SelectedIndex = -1
            lboxCurriculumReqCore.SelectedIndex = -1
        End If


    End Sub

    Private Sub lboxCurriculumReqCore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lboxCurriculumReqCore.SelectedIndexChanged
        If Not lboxCurriculumReqCore.SelectedIndex = -1 Then
            lboxCurriculumElective.SelectedIndex = -1
            lboxCurriculumReqGE.SelectedIndex = -1
        End If

    End Sub

    Private Sub lboxCurriculumElective_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lboxCurriculumElective.SelectedIndexChanged
        If Not lboxCurriculumElective.SelectedIndex = -1 Then
            lboxCurriculumReqGE.SelectedIndex = -1
            lboxCurriculumReqCore.SelectedIndex = -1
        End If

    End Sub

    Private Sub btnCurriculumDrop_Click(sender As Object, e As EventArgs) Handles btnCurriculumDrop.Click
        If Not lboxCurriculumElective.SelectedIndex = -1 Then
            lboxCurriculumCourses.Items.Add(lboxCurriculumElective.SelectedItem)
            lboxCurriculumElective.Items.Remove(lboxCurriculumElective.SelectedItem)
        ElseIf Not lboxCurriculumReqCore.SelectedIndex = -1 Then
            lboxCurriculumCourses.Items.Add(lboxCurriculumReqCore.SelectedItem)
            lboxCurriculumReqCore.Items.Remove(lboxCurriculumReqCore.SelectedItem)
        ElseIf Not lboxCurriculumReqGE.SelectedIndex = -1 Then
            lboxCurriculumCourses.Items.Add(lboxCurriculumReqGE.SelectedItem)
            lboxCurriculumReqGE.Items.Remove(lboxCurriculumReqGE.SelectedItem)
        End If
        updateCurriculumDB()
    End Sub

    Private Sub updateCurriculumDB()
        'set Required GE Courses
        Dim tempReqGE As New RequiredGECourses
        For index = 0 To lboxCurriculumReqGE.Items.Count - 1 Step 1
            tempReqGE.addCourse(lboxCurriculumReqGE.Items(index))
        Next

        'set Required Core Courses
        Dim tempReqCore As New RequiredCoreCourses
        For index = 0 To lboxCurriculumReqCore.Items.Count - 1 Step 1
            tempReqCore.addCourse(lboxCurriculumReqCore.Items(index))
        Next

        'set Elective Courses
        Dim tempElective As New ElectiveCoreCourses
        For index = 0 To lboxCurriculumElective.Items.Count - 1 Step 1
            tempElective.addCourse(lboxCurriculumElective.Items(index))
        Next

        'set Curriculum
        Dim tempCurriculum As New Curriculum
        tempCurriculum.ID = cboCurriculumYear.SelectedItem
        tempCurriculum.RequiredGECourses = tempReqGE
        tempCurriculum.RequiredCoreCourses = tempReqCore
        tempCurriculum.ElectiveCourses = tempElective
        If Not tempCurriculumCollection.Contains(tempCurriculum.ID) Then
            tempCurriculumCollection.Add(tempCurriculum, tempCurriculum.ID)
        Else
            tempCurriculumCollection.Remove(tempCurriculum.ID)
            tempCurriculumCollection.Add(tempCurriculum, tempCurriculum.ID)
        End If




        Controller.updateCurriculumDB(tempCurriculumCollection)
    End Sub

    Private Sub cboCurriculumYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCurriculumYear.SelectedIndexChanged
        lboxCurriculumElective.Items.Clear()
        lboxCurriculumReqCore.Items.Clear()
        lboxCurriculumReqGE.Items.Clear()

        tempCurriculumCollection = Controller.getCurriculumDB

        Dim currentCurriculum As Curriculum = tempCurriculumCollection.Item(cboCurriculumYear.SelectedItem)
        Dim currentReqGE As RequiredGECourses = currentCurriculum.RequiredGECourses
        Dim currentRegCore As RequiredCoreCourses = currentCurriculum.RequiredCoreCourses
        Dim currentElective As ElectiveCoreCourses = currentCurriculum.ElectiveCourses

        Dim currentReqGECourse As ArrayList = currentReqGE.Courses
        Dim currentReqCoreCourse As ArrayList = currentRegCore.Courses
        Dim currentElectiveCourse As ArrayList = currentElective.Courses

        Dim nullString As String = ""

        For Each nullString In currentReqGECourse
            lboxCurriculumReqGE.Items.Add(nullString)
        Next

        For Each nullString In currentReqCoreCourse
            lboxCurriculumReqCore.Items.Add(nullString)
        Next

        For Each nullString In currentElectiveCourse
            lboxCurriculumElective.Items.Add(nullString)
        Next
        Dim nullCourse As New Course
        tempCourseDB = Controller.getCourseDB
        lboxCurriculumCourses.Items.Clear()
        For Each nullCourse In tempCourseDB
            lboxCurriculumCourses.Items.Add(nullCourse.ID)
        Next
        validateCourseLeft()

    End Sub

    Private Sub validateCourseLeft()
        For index = 0 To lboxCurriculumReqGE.Items.Count - 1 Step 1
            lboxCurriculumCourses.Items.Remove(lboxCurriculumReqGE.Items(index))
        Next

        For index = 0 To lboxCurriculumReqCore.Items.Count - 1 Step 1
            lboxCurriculumCourses.Items.Remove(lboxCurriculumReqCore.Items(index))
        Next

        For index = 0 To lboxCurriculumElective.Items.Count - 1 Step 1
            lboxCurriculumCourses.Items.Remove(lboxCurriculumElective.Items(index))
        Next
    End Sub

    Private Sub btnCurriculumNew_Click(sender As Object, e As EventArgs) Handles btnCurriculumNew.Click
        Dim year As String = 1999
        Dim int As Integer
        While Not (year >= 2000) And (year <= 2100)
            Try
                int = Integer.Parse(InputBox("Please enter the year this curriculum will be applied to", "Curriculum Year Required", "2014"))
                year = int.ToString
            Catch ex As Exception
                MessageBox.Show("Please Enter a year between 2000 and 2100")
            End Try

        End While

        Dim tempCurriculum As New Curriculum
        tempCurriculum.ID = year
        tempCurriculum.RequiredGECourses = New RequiredGECourses
        tempCurriculum.RequiredCoreCourses = New RequiredCoreCourses
        tempCurriculum.ElectiveCourses = New ElectiveCoreCourses
        If Not tempCurriculumCollection.Contains(tempCurriculum.ID) Then
            tempCurriculumCollection.Add(tempCurriculum, tempCurriculum.ID)
        Else
            tempCurriculumCollection.Remove(tempCurriculum.ID)
            tempCurriculumCollection.Add(tempCurriculum, tempCurriculum.ID)
        End If

        Controller.updateCurriculumDB(tempCurriculumCollection)
        updateComboBox()
        cboCurriculumYear.SelectedItem = tempCurriculum.ID
    End Sub

    Private Sub btnStudentBrowse_Click(sender As Object, e As EventArgs) Handles btnStudentBrowse.Click
        txtCurriculumFileSrc.Enabled = True
        Dim fbd As New OpenFileDialog
        If fbd.ShowDialog = DialogResult.OK Then
            txtStudentFileSrc.Text = fbd.FileName
        End If
    End Sub
End Class