Public Class Course

    Private m_ID, m_title, m_date, m_time, m_room As String
    Private m_units As Integer
    Private m_companionCourse, m_PreRequisit As Course
    Private m_teacher As Teacher
    Private m_student As Student

    Public Property RoomNumber As String
        Get
            Return m_room
        End Get
        Set(value As String)
            m_room = value
        End Set
    End Property

    Public Property CompanionCourse As Course
        Get
            Return m_companionCourse
        End Get
        Set(value As Course)
            m_companionCourse = value
        End Set
    End Property

    Public Property Teacher As Teacher
        Get
            Return m_teacher
        End Get
        Set(value As Teacher)
            m_teacher = value
        End Set
    End Property
    Public Property PreRequisitCourse As Course
        Get
            Return m_PreRequisit
        End Get
        Set(value As Course)
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

    Public Property DateOffered As String
        Get
            Return m_date
        End Get
        Set(value As String)
            m_date = value
        End Set
    End Property

    Public Property TimeOffered As String
        Get
            Return m_time
        End Get
        Set(value As String)
            m_time = value
        End Set
    End Property


End Class
