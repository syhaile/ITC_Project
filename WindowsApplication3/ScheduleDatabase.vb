''' <summary>
''' Contains all schedules loaded and created by application.
''' </summary>
''' <remarks>TODO:
''' - generate data from TSV file
''' - create file that contains schedules made by program
''' - functions needed by views if any
''' - code cleanup and documentation</remarks>
Public Class ScheduleDatabase
    'This class holds a collection of schedule objects and pushes updates to relevant tables in sql db
    Private m_scheduleDatabase As Collection

    'Public Sub New()
    '    'pull data from sql db to this database placeholder
    '    Dim ds As New KSUDBDataSet
    '    Dim ta As New KSUDBDataSetTableAdapters.ClassScheduleTableAdapter
    '    ta.Fill(ds.ClassSchedule)
    '    For Each row As DataRow In ds.ClassSchedule.Rows
    '        addSchedule(New Schedule(row("scheduleID")))
    '    Next

    'End Sub

    Public Sub addSchedule(ByVal schedule As Schedule)
        m_scheduleDatabase.Add(schedule, schedule.ScheduleID)
    End Sub

    Public Function getSchedule(ByVal id As String) As Schedule
        Return m_scheduleDatabase.Item(id)
    End Function

    Public Function getAllSchedule() As ArrayList
        Dim list As New ArrayList
        For Each sched As Schedule In m_scheduleDatabase
            list.Add(sched)
        Next
        Return list
    End Function

End Class
