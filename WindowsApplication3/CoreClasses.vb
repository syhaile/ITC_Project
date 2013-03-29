Public Class CoreClasses
    'This class should be expected to accept courses that have no prerequisit course required
    'Using PrerequisitClasses & CoreRequirements we can use them to make up the 3 main areas that make up a curriculum (Required Core, Elective Core, Required GE)

    Private m_class As Course

    Public Property Course As Course
        Get
            Return m_class
        End Get
        Set(value As Course)
            m_class = value
        End Set
    End Property


End Class
