Public Class CoursesDatabase
    'This class should contain a database having all Courses possible
    Private Shared m_courseDatabase As Collection

    Public Shared Property MasterDatabase As Collection
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

End Class
