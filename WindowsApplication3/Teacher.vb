Public Class Teacher
    Private m_Code As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal code As String, ByVal name As String,
            ByVal department As String)
        Me.Code = code
        Me.Name = name
        Me.Department = department
    End Sub

    Public Property Code() As String
        Get
            Return m_Code
        End Get
        Set(ByVal value As String)
            If value.Length > 4 Then
                Throw New ArgumentException(
                    "Maximum length of Code is 4 characters.")
            Else
                m_Code = value
            End If
        End Set
    End Property

    Public Property Name() As String

    Public Property Department() As String

    Public Function GetDisplayText(ByVal sep As String) As String
        Dim text As String = Code & sep & name &
                             sep & department
        Return text
    End Function
End Class
