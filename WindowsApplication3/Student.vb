Public Class Student
        Private m_Code As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As Integer, ByVal name As String,
            ByVal enrolledDate As Date, ByVal currentStudent As Boolean)
        Me.ID = id
        Me.Name = name
        Me.EnrolledDate = enrolledDate
        Me.CurrentStudent = currentStudent
    End Sub

    Public Property ID() As Integer
    
    Public Property Name() As String

    Public Property EnrolledDate() As Date

    Public Property CurrentStudent() As Boolean


    Public Function GetDisplayText(ByVal sep As String) As String
        Dim text As String = ID & sep & Name & sep & EnrolledDate & sep &CurrentStudent
        Return text
    End Function
End Class
