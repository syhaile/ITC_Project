Public Class RoomDatabase
    'This class should contain the main database of all rooms available
    Private m_roomDatabase As New Collection

    Public Sub New()
        'Add rooms from db to this db
        Dim ds As New KSUDBDataSet
        Dim ta As New KSUDBDataSetTableAdapters.ClassroomTableAdapter
        ta.Fill(ds.Classroom)
        For Each row As DataRow In ds.Classroom.Rows
            addRoom(New Room(row("classroomID")))
        Next
    End Sub

    Public Property MasterDatabase As Collection
        Get
            Return m_roomDatabase
        End Get
        Set(value As Collection)
            m_roomDatabase = value
        End Set
    End Property

    Public Sub addRoom(ByVal room As Room)
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
