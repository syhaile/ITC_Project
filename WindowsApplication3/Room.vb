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

    'Public Sub New(ByVal id As String)
    '    'Pull data from sql db to this class based on id
    '    Dim ds As New DataSet
    '    Dim ta As New KSUDBDataSetTableAdapters.ClassroomTableAdapter
    '    ds.Tables.Add(ta.GetClassroomDataByID(id))
    '    Me.ID = id
    '    Me.Building = ds.Tables(0).Rows(0).Item("buildingNumber")
    '    Me.RoomNumber = ds.Tables(0).Rows(0).Item("roomNumber")
    '    Me.Capacity = ds.Tables(0).Rows(0).Item("capacity")
    'End Sub

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
