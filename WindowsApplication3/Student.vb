Public Class Student

    Private m_ID, m_Name, m_enrolledQuarter As String
    Private m_enrolledYear As Integer 
    Private m_enrolledDate, m_ExpectedGraduation As Date
    Private m_CurrentStudent As Boolean = False
    Private m_coursesTaken As New Collection

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As String, ByVal name As String,
            ByVal enrolledYear As Integer, ByVal enrolledQuarter As String,  ByVal currentStudent As Boolean) ' Optional ByVal expectedGraudationDate As Date = Now
        'Me.ExpectedGraduationDate = expectedGraudationDate
        Me.ID = id
        Me.Name = name
        'Me.EnrolledDate = enrolledDate
        Me.EnrolledYear = enrolledYear
        Me.EnrolledQuarter = enrolledQuarter
        Me.CurrentStudent = currentStudent
    End Sub

    Public Sub New(ByVal id As String, ByVal currentStudent As Boolean)
        Dim ds As New DataSet
        Dim ta As New KSUDBDataSetTableAdapters.StudentTableAdapter
        ds.Tables.Add(ta.GetDataByID(id))
        Me.ID = id
        Me.Name = ds.Tables(0).Rows(0).Item("name")
        Me.EnrolledYear = ds.Tables(0).Rows(0).Item("yearStarted")
        Me.EnrolledQuarter = ds.Tables(0).Rows(0).Item("quarterStarted")
        Me.CurrentStudent = currentStudent

    End Sub

    Public Property ID As String
        Get
            Return m_ID
        End Get
        Set(value As String)
            m_ID = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return m_Name
        End Get
        Set(value As String)
            m_Name = value
        End Set
    End Property

    Public Property EnrolledQuarter As String
        Get
            Return m_enrolledQuarter
        End Get
        Set(value As String)
            m_enrolledQuarter = value
        End Set
    End Property 

    Public Property EnrolledYear As Integer 
        Get
            Return m_enrolledYear
        End Get
        Set(value As Integer)
            m_enrolledYear = value
        End Set
    End Property 

    Public Property EnrolledDate As Date
        Get
            Return m_enrolledDate
        End Get
        Set(value As Date)
            m_enrolledDate = value
        End Set
    End Property
    Public Property ExpectedGraduationDate As Date
        Get
            Return m_ExpectedGraduation
        End Get
        Set(value As Date)
            m_ExpectedGraduation = value
        End Set
    End Property
    Public Property CurrentStudent As Boolean
        Get
            Return m_CurrentStudent
        End Get
        Set(value As Boolean)
            m_CurrentStudent = value
        End Set
    End Property

    Public Property Courses As Collection
        Get
            Return m_coursesTaken
        End Get
        Set(value As Collection)
            m_coursesTaken = value
        End Set
    End Property

    Public Sub addCourseTaken(ByVal tempCourse As Course)
        m_coursesTaken.Add(tempCourse, tempCourse.ID)
    End Sub

    Public Function getStudentDescription()
        Dim msg As String = ""
        msg += "Student ID: " & m_ID & vbCrLf & " Student Name: " & m_Name & vbCrLf & " Enrolled Quarter: " & m_enrolledQuarter & vbCrLf & " Enrolled Year: " & m_enrolledYear & vbCrLf & " Current Student: " & m_CurrentStudent & vbCrLf
        If m_CurrentStudent = True Then
            msg += "Expected Graduation: " & m_ExpectedGraduation
        End If
        If Not m_coursesTaken.Count = 0 Then
            msg += vbCrLf & " Courses Taken" & vbCrLf
            For Each courseTaken As Course In m_coursesTaken 
                msg += "  " & courseTaken.ID & vbCrLf
            Next
        End If
        

        Return msg
    End Function
End Class
