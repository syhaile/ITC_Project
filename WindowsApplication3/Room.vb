''' <summary>
''' This class represents a classroom on campus.
''' </summary>
''' <remarks>TODO:
''' - better tostring method
''' - code cleanup and documentation</remarks>
Public Class Room
    'This class should make up what a room is (ID, location)
    Private m_id As String
    Private m_capacity, m_building, m_roomNumber As Integer

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As String, ByVal capacity As Integer)
        m_id = id
        m_capacity = capacity
    End Sub

    Public Property ID As String
        Get
            Return m_id
        End Get
        Set(ByVal value As String)
            m_id = value
        End Set
    End Property


    Public Property Building() As Integer
        Get
            Return m_building
        End Get
        Set(ByVal value As Integer)
            m_building = value
        End Set
    End Property

    Public Property RoomNumber() As Integer
        Get
            Return m_roomNumber

        End Get
        Set(ByVal value As Integer)
            m_roomNumber = value
        End Set
    End Property

    Public Property Capacity As Integer
        Get 
            Return m_capacity
        End Get
        Set(ByVal value As Integer)
            m_capacity = value
        End Set
    End Property

    'needs fixin
    Public Function getDescription()
        Return "Room ID: " & m_id & vbCrLf & "Room Location: " 
    End Function
End Class
