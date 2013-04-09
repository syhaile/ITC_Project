Public Class StudentGenerator

    Private m_numberStudents, m_idLength As Integer
    Private m_curriculumDistribution As New ArrayList
    Private m_dropoutRate As Double
    Private m_curriculumList As New ArrayList
    Private m_currentQuarter As String
    Private m_currentYear As Integer
    Private m_quatersToDropout As Integer
    Private m_randomClassSelection As Boolean
    Private m_classesPerQuarter As Integer
    Private rng As New Random

    'db necessary to generate enrollments for students
    Private m_curriculumdb As Collection 
    Private m_coursedb As Collection
    'more parameters with defaults

    ''' <summary>
    ''' Student generator objects needs curriculum and course databases to generate students. Default initial values are loaded during object construction,
    ''' values can be changed by changing properties.
    ''' </summary>
    ''' <param name="curricdb"></param>
    ''' <param name="coursedb"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal curricdb As Collection, ByVal coursedb As Collection)
        m_idLength = 6
        m_numberStudents = 100
        m_curriculumdb = curricdb
        m_coursedb = coursedb
        m_dropoutRate = 0
        m_currentQuarter = "Spring"
        m_currentYear = 2013
        m_quatersToDropout = 3
        m_randomClassSelection = true
        m_classesPerQuarter = 4
        'create values for distribution
        ''generate list of curriculums
        For Each c As Curriculum In curricdb
            m_curriculumList.Add(c)
            m_curriculumDistribution.Add(1.0/curricdb.Count)
        Next

    End Sub

    Public Function generateStudents() As ArrayList 
        'validate parameters first
        Dim studentList As New ArrayList(m_numberStudents)
        Dim studentCounter As Integer = 0
        'generate id
        While(studentCounter < m_numberStudents)           
            Dim tempid As String = generateCode
            While(isDuplicateID(studentList, tempid))
                  tempid = generateCode
            End While
            Dim tempstudent As New Student
            tempstudent.ID = tempid
            tempstudent.Name = generateRandomName
            studentList.Add(tempstudent)
            studentCounter+= 1
        End While

        'add curriculums to student (default all students begin in Fall)
        studentCounter = 0
        Dim distmilestones(m_curriculumDistribution.Count -1) As Integer
        Dim counter As Integer = 0
        For Each value As double In m_curriculumDistribution 
            If(counter = 0) then
                distmilestones.SetValue(CInt(value * m_numberStudents), counter)
                Else
                distmilestones.SetValue(CInt(value * m_numberStudents) + distmilestones(counter-1), counter)
            End If
            counter += 1
        Next
        For Each tempstudent As Student In studentList
            For counter = distmilestones.Length - 1 to 0 Step -1
                If(studentCounter < distmilestones(counter))
                    'assign curriculum to use for this distribution on student
                    tempstudent.CurrentCurriculum = m_curriculumList.Item(counter)
                    tempstudent.EnrolledQuarter = "FALL"
                    tempstudent.EnrolledYear = Integer.Parse(tempstudent.CurrentCurriculum.ID)
                End If
            Next
            studentCounter += 1
        Next

        'mark dropout students
        Dim dropoutstudents As new ArrayList
        Dim studentsToDrop As Integer = m_dropoutRate * m_numberStudents
        Dim rng As New Random

        For dropcounter As Integer = 0 to studentsToDrop Step 1
            Dim tempindex As Integer = rng.Next() mod studentList.Count -1
            While(isDuplicateID(dropoutstudents, studentList.Item(tempindex).ID))
                tempindex = rng.Next() mod studentList.Count -1
            End While
            dropoutstudents.Add(studentList.Item(tempindex))
        Next

        'add courses to each student(default behavior is random 1 to 4 classes per quarter)
        For Each stud As Student In studentList
            Dim totalquarters As Integer = calcQuatertersTaken(stud)
            If(dropoutstudents.Contains(stud))
                totalquarters -= 3
            End If
            For quartercounter As Integer = 0 To calcQuatertersTaken(stud) Step 1
                Dim coursestaking As Integer = m_classesPerQuarter - 1
                If(m_randomClassSelection) Then
                    coursestaking = (rng.Next mod 3) + 1                    
                End If
                
                For classcounter As Integer = 0 To coursestaking Step 1
                    Dim tempsection As Section = generateRandomSection(stud.CurrentCurriculum)
                    While (Not isValidSection(stud, tempsection))
                        tempsection = generateRandomSection(stud.CurrentCurriculum)
                    End While
                    stud.addCourseTakenWithGradeAndDate(tempsection, generateRandomGrade, calcYear(quartercounter, stud), calcQuarter(quartercounter))
                Next
            Next
        Next


        Return studentList
    End Function

    Private Function generateCode() As String
        Dim code As String = ""
        Dim counter As Integer = 0
        While(counter < m_idLength)
            code += generateRandomAlphaNumeric 
            counter += 1
        End While

        Return code
    End Function

    Private Function isDuplicateID(ByVal studentlist As ArrayList, ByVal id As String) As Boolean
        For Each Student As Student In studentlist
            If(Student.ID = id)
                Return True
            End If
        Next
        Return False
    End Function

    Private Function generateRandomAlphaNumeric() As Char
        Dim temp As Integer = rng.Next() mod 2
        If(false) then
            Return chr((rng.Next() mod 26) + 97)
         Else
            Return chr((rng.Next() mod 10) + 48)
        End If
    End Function

    Private Function generateRandomSection(ByVal curric As Curriculum) As Section
        Dim tempcourselist As new ArrayList
        Dim mysection As New Section
        For Each cid As String In curric.ElectiveCourses.Courses
            tempcourselist.Add(cid)
        Next

        For Each cid As String In curric.RequiredCoreCourses.Courses
            tempcourselist.Add(cid)
        Next

        For Each cid As String In curric.RequiredGECourses.Courses
            tempcourselist.Add(cid)
        Next

        mysection.CourseID = tempcourselist.Item(rng.Next() mod tempcourselist.Count)
        Return mysection
    End Function

    Private Function isValidSection(ByVal student As Student, ByVal section As Section) As Boolean
        'check empty
        If(section.CourseID = Nothing)
            Return false
        End If
           

        'check taken
        For Each enroll As Enrollment In student.SectionsTaken
            If(enroll.SectionTaken.CourseID = section.CourseID)
                If(enroll.Grade = "A" or enroll.Grade = "B" or enroll.Grade = "C")
                    Return false
                End If
            End If
        Next
        'check prereqs
        'Dim prereqs As ArrayList = m_coursedb.Item(section.CourseID).PreRequisitCourse
        Dim prereqs As ArrayList = generatePrereqs(section.CourseID)
        Dim tempcourselist As New ArrayList
        For Each enroll As Enrollment In student.SectionsTaken
            tempcourselist.Add(enroll.SectionTaken.CourseID)
        Next
        For Each cid As String In prereqs
            If((Not tempcourselist.Contains(cid)) and Not cid = nothing)
               Return False
            End If
        Next

        Return true
    End Function

    Private Function calcQuatertersTaken(ByVal stud As Student) As Integer
        Dim value As Integer = 0
        Dim currqval As Integer = 0
        Dim qval As Integer = 0
        If(stud.EnrolledQuarter.ToUpper = "FALL") Then
            qval = 0
            ElseIf(stud.EnrolledQuarter.ToUpper = "WINTER") Then
            qval = 1
            ElseIf(stud.EnrolledQuarter.ToUpper = "SPRING") Then
            qval = 2
        End If

        If(m_currentQuarter.ToUpper = "FALL") Then
            currqval = 0
            ElseIf(m_currentQuarter.ToUpper = "WINTER") Then
            currqval = 1
            ElseIf(m_currentQuarter.ToUpper = "SPRING") Then
            currqval = 2
        End If

        value = (m_currentYear - stud.EnrolledYear) + (currqval - qval)

        Return value
    End Function

    Private Function generateRandomGrade() As String
        Dim temp As Integer = rng.Next Mod 5
        Select Case temp
            Case 0
                Return "A"
            Case 1
                Return "B"
            Case 2
                Return "C"
            Case 3
                Return "D"
            Case Else 
                Return "F"
        End Select
    End Function

    'only works if students only start in fall
    Private Function calcQuarter(ByVal currentCounter As Integer) As String
        Select Case currentCounter mod 3
            Case 0
                Return "FALL"
            Case 1
                Return "WINTER"
            Case Else
                Return "SPRING"
        End Select
    End Function

    Private Function calcYear(ByVal currentCounter As Integer, ByVal stud As Student) As Integer
        Dim value As Integer = stud.EnrolledYear
        value += currentCounter/3

        Return value
    End Function

    Private Function generatePrereqs(ByVal cid As String) As ArrayList
        Dim prereqs As ArrayList
        If(cid = Nothing)
            prereqs = New ArrayList
            Return prereqs
        End If

        If(m_coursedb.Contains(cid) and Not m_coursedb.Item(cid).PreRequisitCourse.Contains(Nothing)) then 
            prereqs = m_coursedb.Item(cid).PreRequisitCourse
            'For Each preq As String In prereqs
            '    If( Not preq = Nothing)
            '        Dim tempreqs As ArrayList = generatePrereqs(preq)
            '        For Each p As String In tempreqs
            '            If(Not p = Nothing)
            '                prereqs.Add(p)
            '            End If                      
            '        Next
            '    End If
            'Next


            Else 
            prereqs = New ArrayList
        End If

        
        
        Return prereqs
    End Function

    Private Function generateRandomName() As String
        Dim firstnames = New String() {"Florence","Dan","Toni","Philip","Renee","Caroline","Sally","Stacy","Sharon","Dorothy","Annie","Dwight","Vivian","Tom","Gwendolyn","Phillip","Jane","Kristin","Steven", _
"Neil","Marcia","Becky","Priscilla","Keith","Billy","Dolores","Leo","Annie","Joyce","Carmen","Pauline","Fred","Vicki","Carlos","Fred","Valerie","Christine", _
"Dwight","Danielle","Vincent","Claude","Patricia","Guy","Kathleen","Tonya","Sean","Kevin","Alan","Marie","Andrew","Jacqueline","Ethel","Emily","Edwin", _
"Holly","Ashley","Larry","Ted","Paula","Wade","Kimberly","Maureen","Phyllis","Francis","Gary","Ellen","Geoffrey","Jason","Christian","Nina","Michele", _
"Jason","Ruby","Renee","Peter","Clarence","Janet","Hugh","Marcia","Paige","Rodney","Sara","Martin","Dorothy","Clarence","Cecil","Elisabeth","Lauren", _
"Glenda","Jay","Sarah","Joan","Dolores","Mary","Nathan","Linda","Judy","Kay","Wallace","Steve","Arnold","Anne","Meredith","Lori","Maureen","Sean", _
"Lindsay","Steven","Jim","Vickie","Elizabeth","Zachary","Sheryl","Jenny","Beverly","Joel","Craig","Martha","Rosemary","Stacey","Yvonne","Don"}
        Dim lastnames = New String() {"Knight", "Nelson", "Clements", "Duke", "Levine", "Bennett", "Martin", "Ramsey", "Curtis", "Wilkerson", "Miller", "Cash", "Daniels", "Levin", "Ford", "Simmons", _
"Golden", "Hernandez", "Simpson", "Ross", "Alston", "Cole", "Walsh", "Koch", "Harding", "Young", "Davies", "Carr", "Carver", "Joyner", "Feldman", "McPherson", _
"Burnett", "Meyer", "Kramer", "Conway", "Harding", "Hartman", "Taylor", "Harrison", "McDaniel", "Gay", "Braswell", "Craig", "Reynolds", "Boyer", _
"O'Connor", "Burnette", "Wright", "Harris", "Doyle", "Holden", "French", "Woodward", "Sawyer", "Rose", "Bland", "Moran", "Hensley", "Harvey", "Sparks", _
"Cain", "Hurley", "Alston", "Vaughan", "Fox", "Meyer", "Marsh", "Holder", "Case", "Desai", "Law", "Todd", "Vogel", "Carpenter", "Pearce", "Stuart", "Miller", _
"Barnett", "Pollard", "Wilkerson", "Raynor", "Bernstein", "McConnell", "Walker", "Coates", "Barnes", "Sigmon", "Weeks", "Keith", "Herring", "Branch", _
"Cooper", "Payne", "Langley", "Mercer", "Dawson", "Paul", "Matthews", "Schwartz", "McCarthy", "Stern", "Norton", "Collier", "Adkins", "Boyer", "Gibbons", _
"Cobb", "Lu", "Miles", "Joyce", "Sweeney", "McKenzie", "Potter", "Bowles", "Terry", "Shaffer", "Stephens", "Hayes", "Pollard", "Allred", "Brandt", "Lawson", _
"Ballard", "McCormick", "Stark"}
        Dim name As String = ""

        name += firstnames(rng.Next mod firstnames.Length) + " " + lastnames(rng.Next mod lastnames.Length)

        Return name
    End Function

End Class
