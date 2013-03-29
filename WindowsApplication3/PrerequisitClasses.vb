Public Class PrerequisitClasses
    'This class should be expected to accept courses that will be required inorder to take a course from CoreRequirements -Miguel
    'Using PrerequisitClasses & CoreRequirements we can use them to make up the 3 main areas that make up a curriculum (Required Core, Elective Core, Required GE) -Miguel

    Private m_requiredClass, m_class As Course

    Public Property RequiredCourse As Course
        Get
            Return m_requiredClass
        End Get
        Set(value As Course)
            m_requiredClass = value
        End Set
    End Property

    Public Property Course As Course
        Get
            Return m_class
        End Get
        Set(value As Course)
            m_class = value
        End Set
    End Property

End Class
