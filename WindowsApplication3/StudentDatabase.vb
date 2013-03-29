Public Class StudentDatabase
    'This class should have all the students in the database
    Private m_studentDatabase As New Collection

    Public Property MasterDatabase As Collection
        Get
            Return m_studentDatabase
        End Get
        Set(value As Collection)
            m_studentDatabase = value
        End Set
    End Property

    Public Sub setStudent(ByVal student As Student)
        m_studentDatabase.Add(student, student.ID)
    End Sub

    Public Function getStudent(ByVal ID As String)
        Return m_studentDatabase.Item(ID)
    End Function

    Public Function getAllStudents() As ArrayList
        Dim list As New ArrayList
        Dim student As Student
        For Each student In m_studentDatabase
            list.Add(student)
        Next
        Return list
    End Function
End Class
