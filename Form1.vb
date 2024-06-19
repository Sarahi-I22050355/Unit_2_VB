Imports System.IO
Public Class Form1

    Private filePath As String
    Private FilePathEmployee As String = "datos.bin"
    Private selectedUserId As Integer
    Private dataFilePath As String = "datos.txt"
    Private indexFilePath As String = "indices.txt"

#Region "Secuential Operations"
    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*"

        If openFileDialog.ShowDialog = DialogResult.Cancel Then
            Return
        End If

        filePath = openFileDialog.FileName
        OpenDGV()
    End Sub

    Public Sub OpenDGV()
        dgvEmployeeTable.Rows.Clear()
        dgvEmployeeTable.Columns.Clear()

        ' Leer las líneas del archivo CSV
        Dim lines As String() = File.ReadAllLines(filePath)

        ' Si hay líneas en el archivo
        If lines.Length > 0 Then
            ' Obtener los nombres de las columnas del primer registro
            Dim columnNames As String() = lines(0).Split(","c)

            ' Agregar columnas al DataGridView usando los nombres de las columnas del CSV
            For Each columnName As String In columnNames
                dgvEmployeeTable.Columns.Add(columnName, columnName)
            Next

            ' Agregar filas al DataGridView con el contenido del CSV (excluyendo la primera línea)
            For i As Integer = 1 To lines.Length - 1
                Dim fields As String() = lines(i).Split(","c)
                dgvEmployeeTable.Rows.Add(fields)
            Next
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*"

        If String.IsNullOrEmpty(filePath) OrElse Not File.Exists(filePath) Then
            MessageBox.Show("Please select a file to work.", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If txtName.Text = "" OrElse txtSecondName.Text = "" OrElse txtAge.Text = "" OrElse cbDepartament.Text = "" Then
            MessageBox.Show("Rellena todos los campos correctamente.", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Using writer As New StreamWriter(filePath, True)
            writer.WriteLine($"{txtName.Text},{txtSecondName.Text},{txtAge.Text},{cbDepartament.Text}")
        End Using

        OpenDGV()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrEmpty(filePath) OrElse Not File.Exists(filePath) Then
            MessageBox.Show("Select a file to work with.", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If txtName.Text = "" Then
            MessageBox.Show("To search, you need to use a NAME.", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Try
            ' Read the CSV file line by line
            Using reader As New StreamReader(filePath)
                While Not reader.EndOfStream
                    Dim line = reader.ReadLine
                    Dim fields = line.Split(","c)

                    ' Compare the search term with the first field (in this case, the name)
                    If fields.Length > 0 AndAlso fields(0) = txtName.Text Then
                        MessageBox.Show("Found: " & String.Join(", ", fields), "!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtName.Text = fields(0)
                        txtSecondName.Text = fields(1)
                        txtAge.Text = fields(2)
                        cbDepartament.Text = fields(3)

                        Return
                    End If
                End While
            End Using
        Catch ex As Exception
            Console.WriteLine("Error while searching in the CSV file: " & ex.Message)
        End Try

        MessageBox.Show("Nothing related to that name was found in the file", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Check if a file is selected
        If String.IsNullOrWhiteSpace(filePath) OrElse Not File.Exists(filePath) Then
            MessageBox.Show("Select a valid file to work with.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        ' Check if a name is entered to search
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Please enter a name to search for.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Try
            ' Read the CSV file line by line and write the non-deleted lines to a new temporary file
            Dim tempFilePath = Path.GetTempFileName
            Using reader As New StreamReader(filePath)
                Using writer As New StreamWriter(tempFilePath)
                    Dim line = reader.ReadLine
                    While line IsNot Nothing

                        ' Check if the current line contains the name to be deleted
                        If Not line.Contains(txtName.Text) Then
                            writer.WriteLine(line)
                        End If
                    End While
                End Using
            End Using

            ' Replace the original file with the temporary file
            File.Delete(filePath)
            File.Move(tempFilePath, filePath)
            OpenDGV()
        Catch ex As Exception
            MessageBox.Show("Error deleting the line from the CSV file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
#End Region

#Region "Secuential Indexed Operations"
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        ' Get the contact data from the form fields
        Dim name = txtNameSql.Text
        Dim phone = txtPhoneSql.Text
        Dim email = txtEmailSql.Text

        ' Insert the new contact into the indexed sequential file
        InsertContact(name, phone, email)
    End Sub

    Private Sub InsertContact(name As String, phone As String, email As String)
        Using indexedFile = New IndexedSequentialFile(Of Contact)(dataFilePath, indexFilePath)
            Try
                ' Get the ID of the last inserted contact to assign a new one
                Dim lastID As Integer = GetLastID()

                ' Increment the ID for the new contact
                Dim newID As Integer = lastID + 1
                Dim newContact As New Contact(newID, name, phone, email)
                ' Insert the new contact into the file
                indexedFile.InsertRecord(newID, newContact)

                ' Update the contacts list in the DataGridView
                ShowAllContacts()
            Catch ex As Exception
                MessageBox.Show("Error inserting the contact: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Function GetLastID() As Integer
        Using indexedFile = New IndexedSequentialFile(Of Contact)(dataFilePath, indexFilePath)
            ' Get all contacts from the file to find the last ID
            Dim contacts As List(Of Contact) = indexedFile.GetAllRecords()

            ' Check if there are any contacts in the list
            If contacts.Count > 0 Then
                ' Sort the contacts list by ID in descending order
                contacts.Sort(Function(x, y) y.ID.CompareTo(x.ID))

                ' Return the ID of the first contact (the highest one)
                Return contacts(0).ID
            Else
                ' If there are no contacts in the file, return 0
                Return 0
            End If
        End Using
    End Function

    Private Sub ShowAllContacts()
        Using indexedFile = New IndexedSequentialFile(Of Contact)(dataFilePath, indexFilePath)
            Try
                Dim contacts As List(Of Contact) = indexedFile.GetAllRecords()

                If contacts IsNot Nothing Then
                    For Each contact In contacts
                        dgvContactos.Rows.Add(contact.ID, contact.Name, contact.Phone, contact.Email)
                    Next
                Else
                    ' Handle the case where the contacts list is null
                    MessageBox.Show("The contacts list is null.")
                End If
            Catch ex As Exception
                ' Handle any exception that may occur while reading contacts
                MessageBox.Show("Error reading contacts: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub dgvContacts_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvContactos.MouseDoubleClick
        Using indexedFile = New IndexedSequentialFile(Of Contact)(dataFilePath, indexFilePath)
            If dgvContactos.SelectedRows.Count = 0 Then
                Return
            End If

            ' Get the selected contact
            Dim selectedContact = TryCast(dgvContactos.SelectedRows(0).DataBoundItem, Contact)

            ' Check if the selected contact could be obtained
            If selectedContact Is Nothing Then
                Return
            End If

            ' Get the ID of the selected user
            selectedUserId = CInt(dgvContactos.SelectedRows(0).Cells("ID").Value)

            ' Show the contact information in the TextBoxes
            txtNameSql.Text = selectedContact.Name
            txtPhoneSql.Text = selectedContact.Phone
            txtEmailSql.Text = selectedContact.Email
        End Using
    End Sub

    Private Sub btnUpdateSql_Click(sender As Object, e As EventArgs) Handles btnUpdateSql.Click
        ' Check if a user has been selected for modification
        If selectedUserId = 0 Then
            MessageBox.Show("Please select a user to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Get the modified data from the TextBoxes
        Dim name = txtNameSql.Text
        Dim phone = txtPhoneSql.Text
        Dim email = txtEmailSql.Text

        ' Create a Contact object with the modified data
        Dim modifiedContact As New Contact(selectedUserId, name, phone, email)
        ModifyUser(modifiedContact)
    End Sub

    Private Sub ModifyUser(ByVal modifiedContact As Contact)
        Using indexedFile = New IndexedSequentialFile(Of Contact)(dataFilePath, indexFilePath)
            indexedFile.LoadIndex()
            Try
                ' Modify the contact in the file
                indexedFile.UpdateRecord(modifiedContact.ID, modifiedContact)

                ' Show the updated contacts in the DataGridView
                ShowAllContacts()

                MessageBox.Show("User modified successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Error modifying user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub dgvContacts_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvContactos.MouseClick
        ' Check if a user has been selected for modification
        If selectedUserId = 0 Then
            MessageBox.Show("Please select a user to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Get the modified data from the TextBoxes
        Dim name = txtNameSql.Text
        Dim phone = txtPhoneSql.Text
        Dim email = txtEmailSql.Text

        ' Create a Contact object with the modified data
        Dim modifiedContact As New Contact(selectedUserId, name, phone, email)
        ModifyUser(modifiedContact)

    End Sub

    Private Sub btnDeleteSql_Click(sender As Object, e As EventArgs) Handles btnDeleteSql.Click
        ' Check if a user has been selected for deletion
        If selectedUserId = 0 Then
            MessageBox.Show("Please select a user to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using indexedFile As New IndexedSequentialFile(Of Contact)(dataFilePath, indexFilePath)
            indexedFile.LoadIndex()

            Try
                ' Delete the contact from the file
                indexedFile.DeleteRecord(selectedUserId)

                ' Show the updated contacts in the DataGridView
                ShowAllContacts()

                MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Error deleting user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

    End Sub


#End Region

#Region "Direct Operation"
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Binary Files (*.bin)|*.bin|All Files (*.*)|*.*"
        If openFileDialog.ShowDialog() = DialogResult.Cancel Then
            Return
        End If

        FilePathEmployee = openFileDialog.FileName
        ' Read the content of the selected file and display it in the DataGridView
        DisplayFileContent(FilePathEmployee)
        MessageBox.Show("File opened successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub DisplayFileContent(filePath As String)
        If New FileInfo(filePath).Length = 0 Then
            ' The file is empty, there is nothing to read
            MessageBox.Show("The file is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Clear the DataGridView before loading new data
        dgvEmpTabl.Rows.Clear()
        dgvEmpTabl.Columns.Clear()

        ' Read the content of the file and display it in the DataGridView
        Using reader As New BinaryReader(File.Open(filePath, FileMode.Open))
            ' Read the data from the file and add it to the DataGridView
            While reader.PeekChar() <> -1
                ' Read employee data from the file
                Dim id As Integer = reader.ReadInt32()
                Dim name As String = reader.ReadString()
                Dim department As String = reader.ReadString()

                ' Add a row to the DataGridView with the employee data
                dgvEmpTabl.Rows.Add(id, name, department)
            End While
        End Using
    End Sub

    Private Function SearchEmployeeByID(id As Integer) As Employee
        Using reader As New BinaryReader(File.Open(FilePathEmployee, FileMode.Open))
            While reader.PeekChar() <> -1
                Dim employee As Employee = employee.ReadFromFile(reader)
                If employee.ID = id Then
                    Return employee
                End If
            End While
        End Using
        Return Nothing ' Employee not found
    End Function

    Private Sub UpdateEmployee(updatedEmployee As Employee)
        Dim tempFilePath As String = Path.GetTempFileName()

        Using reader As New BinaryReader(File.Open(FilePathEmployee, FileMode.Open))
            Using writer As New BinaryWriter(File.Open(tempFilePath, FileMode.Create))
                While reader.PeekChar() <> -1
                    Dim employee As Employee = employee.ReadFromFile(reader)
                    If employee.ID = updatedEmployee.ID Then
                        updatedEmployee.WriteToFile(writer)
                    Else
                        employee.WriteToFile(writer)
                    End If
                End While
            End Using
        End Using

        File.Delete(FilePathEmployee)
        File.Move(tempFilePath, FilePathEmployee)
    End Sub

    Private Sub DeleteEmployee(employeeToDelete As Employee)
        Dim tempFilePath As String = Path.GetTempFileName()

        Using reader As New BinaryReader(File.Open(FilePathEmployee, FileMode.Open))
            Using writer As New BinaryWriter(File.Open(tempFilePath, FileMode.Create))
                While reader.PeekChar() <> -1
                    Dim employee As Employee = employee.ReadFromFile(reader)
                    If employee.ID <> employeeToDelete.ID Then
                        employee.WriteToFile(writer)
                    End If
                End While
            End Using
        End Using

        File.Delete(FilePathEmployee)
        File.Move(tempFilePath, FilePathEmployee)
    End Sub

    Private Sub ClearFields()
        txtID.Clear()
        txtNameDA.Clear()
        cbDepartamentDA.Text = ""
    End Sub

    Private Sub LoadData()
        Using reader As New BinaryReader(File.Open(FilePathEmployee, FileMode.Open))
            While reader.PeekChar() <> -1
                Dim employee As Employee = employee.ReadFromFile(reader)
                dgvEmpTabl.Rows.Add(employee.ID, employee.Name, employee.Department)
            End While
        End Using
    End Sub

    Private Sub ShowEmployeeData(employee As Employee)
        txtID.Text = employee.ID.ToString()
        txtNameDA.Text = employee.Name
        cbDepartamentDA.Text = employee.Department
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If String.IsNullOrEmpty(txtID.Text) OrElse String.IsNullOrEmpty(txtNameDA.Text) OrElse String.IsNullOrEmpty(cbDepartamentDA.Text) Then
            Return
        End If

        ' Save employee data
        Dim id As Integer = Convert.ToInt32(txtID.Text)
        Dim name As String = txtNameDA.Text
        Dim department As String = cbDepartamentDA.Text

        Dim employee As New Employee(id, name, department)

        Using writer As New BinaryWriter(File.Open(FilePathEmployee, FileMode.Append))
            employee.WriteToFile(writer)
        End Using
        ClearFields()
        LoadData() ' Reload data in the DataGridView after adding a new employee
        MessageBox.Show("Employee added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If String.IsNullOrEmpty(txtID.Text) Then
            Return
        End If

        Dim searchId As Integer = Convert.ToInt32(txtID.Text)
        Dim employee As Employee = SearchEmployeeByID(searchId)

        If employee Is Nothing Then
            MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ShowEmployeeData(employee)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If String.IsNullOrEmpty(txtID.Text) Then
            Return
        End If

        Dim searchId As Integer = Convert.ToInt32(txtID.Text)
        Dim employee As Employee = SearchEmployeeByID(searchId)

        If employee Is Nothing Then
            MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        employee.Name = txtNameDA.Text
        employee.Department = cbDepartamentDA.Text
        UpdateEmployee(employee)
        ClearFields()
        LoadData() ' Reload data in the DataGridView after updating an employee
        MessageBox.Show("Employee updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(txtID.Text) Then
            Return
        End If

        Dim searchId As Integer = Convert.ToInt32(txtID.Text)
        Dim employee As Employee = SearchEmployeeByID(searchId)

        If employee Is Nothing Then
            MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        DeleteEmployee(employee)
        ClearFields()
        LoadData() ' Reload data in the DataGridView after deleting an employee
        MessageBox.Show("Employee deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

#End Region
End Class