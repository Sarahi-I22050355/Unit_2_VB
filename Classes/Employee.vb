Imports System.IO

Public Class Employee
    Public Property ID As Integer
    Public Property Name As String
    Public Property Department As String

    Public Sub New(id As Integer, name As String, department As String)
        Me.ID = id
        Me.Name = name
        Me.Department = department
    End Sub

    Public Sub WriteToFile(writer As BinaryWriter)
        writer.Write(ID)
        writer.Write(Name)
        writer.Write(Department)
    End Sub

    Public Shared Function ReadFromFile(reader As BinaryReader) As Employee
        Try
            Dim id As Integer = reader.ReadInt32()
            Dim name As String = reader.ReadString()
            Dim department As String = reader.ReadString()
            Return New Employee(id, name, department)
        Catch generatedExceptionName As EndOfStreamException
            Throw New InvalidOperationException("Failed to read data from the file.")
        End Try
    End Function

End Class
