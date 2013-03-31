Public Class Room
    'This class should make up what a room is (ID, location, time, dates)
    Private m_id, m_location, m_dates As String
    Private m_startTime, m_endTime As DateTime
    Private m_assigned As Boolean

    Public Property ID As String
        Get
            Return m_id
        End Get
        Set(value As String)
            m_id = value
        End Set
    End Property

    Public Property Location As String
        Get
            Return m_location
        End Get
        Set(value As String)
            m_location = value
        End Set
    End Property

    Public Property StartTime As DateTime
        Get
            Return m_startTime
        End Get
        Set(value As Date)
            m_startTime = value
        End Set
    End Property

    Public Property EndTime As DateTime
        Get
            Return m_endTime
        End Get
        Set(value As Date)
            m_endTime = value
        End Set
    End Property

    Public Property Days As String
        Get
            Return m_dates
        End Get
        Set(value As String)
            m_dates = value
        End Set
    End Property

    Public Property Assigned As Boolean
        Get
            Return m_assigned
        End Get
        Set(value As Boolean)
            m_assigned = value
        End Set
    End Property
    
    Public Function getDescription()
        Return "Room ID: " & m_id & vbCrLf & "Room Location: " & m_location & vbCrLf & "Date Assigned: " & m_dates & vbCrLf & "Start Time: " & m_startTime & vbCrLf & "End Time: " & m_endTime & vbCrLf
    End Function
End Class
