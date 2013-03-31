Public Class StudentDatabase
    'This class should have all the students in the database
    Private m_studentDatabase As New Collection
    Private Dim ds As New KSUDBDataSet
    

    Public Property MasterDatabase As Collection
        Get
            Return m_studentDatabase
        End Get
        Set(value As Collection)
            m_studentDatabase = value
        End Set
    End Property

    Public Sub New()
        Dim ta As New KSUDBDataSetTableAdapters.StudentTableAdapter
        ta.Fill(ds.Student)
        
        For Each row As DataRow In ds.Student.Rows
            Dim s As New Student(row("studentID"), false) 'false for now
            'need to add courses to student

            Dim tempds As New DataSet
            Dim ta2 as New KSUDBDataSetTableAdapters.SectionTableAdapter
            tempds.Tables.Add(ta2.GetCourseDataByStudentID(s.ID))
            For Each rowCourses As DataRow In tempds.Tables(0).Rows
                Dim c As New Course(rowCourses("courseID"))
                s.addCourseTaken(c)
            Next
            setStudent(s)
        Next
    End Sub


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
