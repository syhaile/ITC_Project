Public Class ScheduleDatabase
    'This class contains all schedule courses (courseID, teacherID, roomID, studentID's)
    Private m_scheduleDatabase As New Collection

    Public Property MasterDatabase As Collection
        Get
            Return m_scheduleDatabase
        End Get
        Set(value As Collection)
            m_scheduleDatabase = value
        End Set
    End Property

    Public Sub setSchedule(ByVal schedule As Schedule)
        m_scheduleDatabase.Add(schedule, schedule.ScheduleID)
    End Sub

    Public Function getSchedule(ByVal ID As String)
        Return m_scheduleDatabase.Item(ID)
    End Function

    Public Function getAllSchedules() As ArrayList
        Dim list As New ArrayList
        Dim schedule As Schedule
        For Each schedule In m_scheduleDatabase
            list.Add(schedule)
        Next
        Return list
    End Function
End Class
