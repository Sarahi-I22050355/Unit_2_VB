Imports System.IO
Imports System.Collections.Generic

Public Class IndexedSequentialFile(Of T)
    Implements IDisposable

    Private ReadOnly dataFilePath As String
    Private ReadOnly indexFilePath As String
    Private ReadOnly index As Dictionary(Of Integer, Long)

    Public Sub New(dataFilePath As String, indexFilePath As String)
        If dataFilePath Is Nothing Then
            Throw New ArgumentNullException(NameOf(dataFilePath))
        End If

        If indexFilePath Is Nothing Then
            Throw New ArgumentNullException(NameOf(indexFilePath))
        End If

        Me.dataFilePath = dataFilePath
        Me.indexFilePath = indexFilePath
        Me.index = New Dictionary(Of Integer, Long)()
    End Sub


    Public Function GetAllRecords() As List(Of T)
        LoadIndex()

        Dim records As New List(Of T)()

        Using reader As New StreamReader(dataFilePath)
            For Each position In index.Values
                reader.BaseStream.Seek(position, SeekOrigin.Begin)
                Dim line As String = reader.ReadLine()
                Dim record As T = ParseRecord(line)
                records.Add(record)
            Next
        End Using

        Return records
    End Function

    Public Sub InsertRecord(key As Integer, record As T)
        Dim position As Long = GetEndOfFilePosition(dataFilePath)

        Using dataWriter As New StreamWriter(dataFilePath, True),
              indexWriter As New StreamWriter(indexFilePath, True)
            dataWriter.WriteLine(record.ToString())
            indexWriter.WriteLine($"{key}:{position}")
        End Using
    End Sub

    Public Function GetRecordByKey(key As Integer) As T
        LoadIndex()

        Dim position As Long ' Declarar la variable position aquí

        If Not index.TryGetValue(key, position) Then
            Throw New KeyNotFoundException($"Key {key} not found in index.")
        End If

        Using reader As New StreamReader(dataFilePath)
            reader.BaseStream.Seek(position, SeekOrigin.Begin)
            Dim line As String = reader.ReadLine()
            Return ParseRecord(line)
        End Using
    End Function


    Public Sub LoadIndex()
        Dim key As Integer ' Declarar la variable key aquí
        Dim position As Long ' Declarar la variable position aquí

        index.Clear()

        Try
            If Not File.Exists(indexFilePath) Then
                Console.WriteLine($"Error: The index file does not exist at the specified location: {indexFilePath}")
                Return
            End If

            Using indexReader As New StreamReader(indexFilePath)
                Dim line As String = indexReader.ReadLine()
                While (line) IsNot Nothing
                    Dim parts() As String = line.Split(":"c)
                    If parts.Length = 2 AndAlso Integer.TryParse(parts(0), key) AndAlso Long.TryParse(parts(1), position) Then
                        index(key) = position
                    Else
                        Console.WriteLine($"Error: Line with incorrect format in the index file: {line}")
                    End If
                    line = indexReader.ReadLine() ' Leer la siguiente línea
                End While
            End Using
        Catch ex As Exception
            Console.WriteLine($"Error loading the index: {ex.Message}")
        End Try
    End Sub


    Private Function GetEndOfFilePosition(filePath As String) As Long
        Using fileStream As New FileStream(filePath, FileMode.OpenOrCreate)
            Return fileStream.Length
        End Using
    End Function

    Private Function ParseRecord(line As String) As T
        Dim parts() As String = line.Split(","c)

        Dim id As Integer = Integer.Parse(parts(0))
        Dim name As String = parts(1)
        Dim phone As String = parts(2)
        Dim email As String = parts(3)

        ' Aquí necesitarías retornar una instancia del objeto T con los valores obtenidos
        Return DirectCast(DirectCast(New Contact(id, name, phone, email), Object), T)

    End Function

    Public Sub UpdateRecord(key As Integer, newRecord As T)
        Dim position As Long

        If Not index.TryGetValue(key, position) Then
            Throw New KeyNotFoundException($"Key {key} not found in index.")
            Return
        End If

        Using dataWriter As New StreamWriter(dataFilePath),
              reader As New StreamReader(dataFilePath)
            Dim line As String = reader.ReadLine()
            Dim currentPosition As Long = 0
            While (line) IsNot Nothing
                If currentPosition = position Then
                    dataWriter.WriteLine(newRecord.ToString())
                Else
                    dataWriter.WriteLine(line)
                End If
                currentPosition = reader.BaseStream.Position
            End While
        End Using
    End Sub

    Public Sub DeleteRecord(key As Integer)
        Dim position As Long

        If Not index.TryGetValue(key, position) Then
            Throw New KeyNotFoundException($"Key {key} not found in index.")
            Return
        End If

        index.Remove(key)

        Using indexWriter As New StreamWriter(indexFilePath)
            For Each kvp In index
                indexWriter.WriteLine($"{kvp.Key}:{kvp.Value}")
            Next
        End Using

        UpdateDataFile(position)
    End Sub

    Private Sub UpdateDataFile(positionToRemove As Long)
        Dim tempFilePath As String = Path.GetTempFileName()

        Using tempWriter As New StreamWriter(tempFilePath),
              reader As New StreamReader(dataFilePath)
            Dim line As String = reader.ReadLine()
            Dim currentPosition As Long = 0
            While (line) IsNot Nothing
                If currentPosition <> positionToRemove Then
                    tempWriter.WriteLine(line)
                End If
                currentPosition = reader.BaseStream.Position
            End While
        End Using

        File.Delete(dataFilePath)
        File.Move(tempFilePath, dataFilePath)
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        ' No hay recursos adicionales que cerrar, pero puedes agregarlos si es necesario
    End Sub
End Class

