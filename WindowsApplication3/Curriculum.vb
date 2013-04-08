Public Class Curriculum
    'This class should take in "RequiredCoreCourses", "RequiredGECourses", & "ElectiveCoreCourses" to make up a curriculum
    Private m_ID, m_Title As String
    Private m_requiredCore As RequiredCoreCourses
    Private m_requiredGE As RequiredGECourses
    Private m_electiveCore As ElectiveCoreCourses

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
            Return m_Title
        End Get
        Set(value As String)
            m_Title = value
        End Set
    End Property

    Public Property RequiredCoreCourses As RequiredCoreCourses
        Get
            Return m_requiredCore
        End Get
        Set(value As RequiredCoreCourses)
            m_requiredCore = value
        End Set
    End Property

    Public Property RequiredGECourses As RequiredGECourses
        Get
            Return m_requiredGE
        End Get
        Set(value As RequiredGECourses)
            m_requiredGE = value
        End Set
    End Property

    Public Property ElectiveCourses As ElectiveCoreCourses
        Get
            Return m_electiveCore
        End Get
        Set(value As ElectiveCoreCourses)
            m_electiveCore = value
        End Set
    End Property


End Class
