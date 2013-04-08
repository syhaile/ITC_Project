Public Class Enrollment
        Private m_grade, m_quarter, m_year As String
        Private m_section As Section

        Public Sub new()
            
        End Sub

        Public Sub new(ByVal section As Section)
            SectionTaken = section
        End Sub

    Public Sub New(ByVal section As Section, ByVal grade As String)
        m_section = section
        m_grade = grade

    End Sub

    Public Sub New(ByVal section As Section, ByVal grade As String, ByVal year As String, ByVal quarter As String)
        m_section = section
        m_grade = grade
        m_year = year
        m_quarter = quarter
    End Sub

        public Property SectionTaken As Section
            Get
                Return m_section
            End Get
            Set(ByVal value As Section)
                m_section = value
            End Set
        end property 

        Public Property Grade As String

            Get
                Return m_grade
            End Get
            Set(ByVal value As String)
                m_grade = value
            End Set
        end property

        Public Property Year As String

            Get
                Return m_year
            End Get
            Set(ByVal value As String)
                m_year = value
            End Set
        end property

        Public Property Quarter As String

            Get
                Return m_quarter
            End Get
            Set(ByVal value As String)
                m_quarter = value
            End Set
        end property
    End Class
