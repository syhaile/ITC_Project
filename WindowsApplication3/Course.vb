Public Class Course

    Private m_ID, m_title As String
    Private m_units As Integer
    Private m_companionCourse, m_PreRequisit As String

    Public Sub New(ByVal id As String)
        Dim ds As New KSUDBDataSet
        Dim ta As New KSUDBDataSetTableAdapters.CourseTableAdapter
        ta.FillCourseDataByID(ds.Course,id)
        Dim ta2 As New KSUDBDataSetTableAdapters.PrerequisiteTableAdapter
        ta2.Fill(ds.Prerequisite)
        For Each row As DataRow In ds.Course.Rows
            Me.ID = row("courseID")
            Me.Units = row("units")
            If Not IsDBNull(row("CompanionClassID"))
                Me.CompanionCourse = row("CompanionClassID")
            End If
            For Each rowPre As DataRow In ds.Prerequisite
                If Me.ID = rowPre("courseID")
                    Me.PreRequisitCourse += rowPre("prerequisiteClassID") & " "
                End If
            Next
        Next
    End Sub

    Public Property CompanionCourse As String
        Get
            Return m_companionCourse
        End Get
        Set(value As String)
            m_companionCourse = value
        End Set
    End Property

    Public Property PreRequisitCourse As String
        Get
            Return m_PreRequisit
        End Get
        Set(value As String)
            m_PreRequisit = value
        End Set
    End Property

    Public Property Units As Integer
        Get
            Return m_units
        End Get
        Set(value As Integer)
            m_units = value
        End Set
    End Property

    Public Property ID As String
        Get
            Return m_ID
        End Get
        Set(value As String)
            m_ID = value
        End Set
    End Property

    Public Property Title As String
        Get
            Return m_title
        End Get
        Set(value As String)
            m_title = value
        End Set
    End Property

    Public Function getCourseDescription()
        Dim result As String
        result = "Course ID: " & m_ID & vbCrLf & "Units: " & m_units & vbCrLf
        If m_companionCourse <> "" Then
            result += "Companion Course: " & m_companionCourse & vbCrLf
        End If
        If m_PreRequisit <> "" Then
            result += "PreRequisit Course: " & m_PreRequisit & vbCrLf
        End If


        Return result


    End Function


End Class
