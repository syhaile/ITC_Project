Public Class Teacher
    Private m_Code As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal code As Integer, ByVal name As String,
            ByVal department As String)
        Me.Code = code
        Me.Name = name
        Me.Department = department
    End Sub

    Public Property Code() As Integer

    Public Property Name() As String

    Public Property Department() As String

    Public Function GetDisplayText(ByVal sep As String) As String
        Dim text As String = Code & sep & name &
                             sep & department
        Return text
    End Function
End Class
