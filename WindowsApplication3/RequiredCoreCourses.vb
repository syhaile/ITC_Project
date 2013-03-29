Public Class RequiredCoreCourses
    'This class should take a "PrerequisitClasses" & "CoreRequirements" that will make up one of the 3 main sections -Miguel
    Private m_preRequisit As PrerequisitClasses
    Private m_coreReq As CoreClasses

    Public Property PreRequisitCourses As PrerequisitClasses
        Get
            Return m_preRequisit
        End Get
        Set(value As PrerequisitClasses)
            m_preRequisit = value
        End Set
    End Property

    Public Property CoreRequirementCourses As CoreClasses
        Get
            Return m_coreReq
        End Get
        Set(value As CoreClasses)
            m_coreReq = value
        End Set
    End Property

End Class
