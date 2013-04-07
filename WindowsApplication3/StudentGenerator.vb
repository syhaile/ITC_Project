Public Class StudentGenerator

    Private m_numberStudents, m_idLength As Integer
    Private m_curriculumDistribution() As Double
    Private m_dropoutRate As Double


    'db necessary to generate enrollments for students
    Private m_curriculumdb As CurriculumDatabase 
    Private m_coursedb As CoursesDatabase
    'more parameters with defaults

    ''' <summary>
    ''' Student generator objects needs curriculum and course databases to generate students. Default initial values are loaded during object construction,
    ''' values can be changed by changing properties.
    ''' </summary>
    ''' <param name="curricdb"></param>
    ''' <param name="coursedb"></param>
    ''' <remarks></remarks>
    Public Sub new(ByVal curricdb As CurriculumDatabase, ByVal coursedb As CoursesDatabase)
        m_idLength = 6
        m_numberStudents = 100
        m_curriculumdb = curricdb
        m_coursedb = coursedb
        'create values for distribution
        m_dropoutRate = 0
        'redim m_curriculumDistribution(m_curriculumdb.
    End Sub

    Public Function generateStudents() As ArrayList 
        'validate parameters first
        Dim studentList As New ArrayList(m_numberStudents)
        Dim studentCounter As Integer = 0
        While(studentCounter < m_numberStudents)
            'generate id
            Dim tempid As String = generateCode
            While(isDuplicateID(studentList, tempid))
                  tempid = generateCode
            End While
            Dim tempstudent As New Student
            tempstudent.ID = tempid
            studentList.Add(tempstudent)
            
        End While

        Return studentList
    End Function

    Private Function generateCode() As String
        Dim code As String = ""
        Dim counter As Integer = 0
        While(counter < m_idLength)
            code += generateRandomAlphaNumeric 
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
        Dim rng As New Random
        If((rng.Next() mod 1) = 1) then
            Return chr((rng.Next() mod 26) + 97)
         Else
            Return chr((rng.Next() mod 9) + 48)
        End If
    End Function

End Class
