Public Class Contact
    Public Property ID As Integer
    Public Property Name As String
    Public Property Phone As String
    Public Property Email As String

    Public Sub New(id As Integer, name As String, phone As String, email As String)
        Me.ID = id
        Me.Name = name
        Me.Phone = phone
        Me.Email = email
    End Sub
End Class

