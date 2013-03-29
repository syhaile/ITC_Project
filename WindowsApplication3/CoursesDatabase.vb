Public Class CoursesDatabase
    'This class should contain a database having all Courses possible
    Private m_courseDatabase As New Collection

    Public Property MasterDatabase As Collection
        Get
            Return m_courseDatabase
        End Get
        Set(value As Collection)
            m_courseDatabase = value
        End Set
    End Property

    Public Sub setCourse(ByVal course As Course)
   
        m_courseDatabase.Add(course, course.ID)
    End Sub

    Public Function getCourse(ByVal ID As String)
        Return m_courseDatabase.Item(ID)
    End Function

    Public Function getAllCourses() As ArrayList
        Dim list As New ArrayList
        Dim course As Course
        For Each course In m_courseDatabase
            list.Add(course)
        Next
        Return list
    End Function
End Class
