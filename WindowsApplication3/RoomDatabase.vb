Public Class RoomDatabase
    'This class should contain the main database of all rooms available
    Private m_roomDatabase As New Collection

    Public Property MasterDatabase As Collection
        Get
            Return m_roomDatabase
        End Get
        Set(value As Collection)
            m_roomDatabase = value
        End Set
    End Property

    Public Sub setRoom(ByVal room As Room)
        m_roomDatabase.Add(room, room.ID)
    End Sub

    Public Function getRoom(ByVal ID As String)
        Return m_roomDatabase.Item(ID)
    End Function

    Public Function getAllRooms() As ArrayList
        Dim list As New ArrayList
        Dim room As Room
        For Each room In m_roomDatabase
            list.Add(room)
        Next
        Return list
    End Function

End Class
