Public Class Student

    Private m_ID, m_Name As String
    Private m_enrolledDate, m_ExpectedGraduation As Date
    Private m_CurrentStudent As Boolean = False
    Private m_coursesTaken As Collection

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As String, ByVal name As String,
            ByVal enrolledDate As Date, ByVal currentStudent As Boolean) ' Optional ByVal expectedGraudationDate As Date = Now
        'Me.ExpectedGraduationDate = expectedGraudationDate
        Me.ID = id
        Me.Name = name
        Me.EnrolledDate = enrolledDate
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
        msg += "Student ID: " & m_ID & vbCrLf & " Student Name: " & m_Name & vbCrLf & " Enrolled Date: " & m_enrolledDate & vbCrLf & " Current Student: " & m_CurrentStudent & vbCrLf
        If m_CurrentStudent = True Then
            msg += "Expected Graduation: " & m_ExpectedGraduation
        End If

        'add courses taken to description

        Return msg
    End Function
End Class
