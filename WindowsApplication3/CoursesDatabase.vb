''' <summary>
''' This class contains all courses in the university. Data can be intialized from a TSV file.
''' </summary>
''' <remarks>TODO:
''' - constructor to initialize data from file
''' - code cleanup and documentation</remarks>
Public Class CoursesDatabase
    Private m_courseDatabase As New Collection
    Private ds As New KSUDBDataSet

    Public Property MasterDatabase As Collection
        Get
            Return m_courseDatabase
        End Get
        Set(value As Collection)
            m_courseDatabase = value
        End Set
    End Property

    Public Sub New()
        Dim ta As New KSUDBDataSetTableAdapters.CourseTableAdapter
        ta.Fill(ds.Course)
        Dim ta2 As New KSUDBDataSetTableAdapters.PrerequisiteTableAdapter
        ta2.Fill(ds.Prerequisite)
        For Each row As DataRow In ds.Course.Rows
            Dim c As New Course(row("courseID"))
            setCourse(c)
        Next
    End Sub

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
