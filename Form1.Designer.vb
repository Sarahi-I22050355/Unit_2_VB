<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbDepartament = New System.Windows.Forms.ComboBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSecondName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvEmployeeTable = New System.Windows.Forms.DataGridView()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnUpdateSql = New System.Windows.Forms.Button()
        Me.btnDeleteSql = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.txtEmailSql = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPhoneSql = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNameSql = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgvContactos = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbDepartamentDA = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtNameDA = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgvEmpTabl = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvEmployeeTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvContactos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvEmpTabl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(-3, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(813, 447)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.btnOpen)
        Me.TabPage1.Controls.Add(Me.btnDelete)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.cbDepartament)
        Me.TabPage1.Controls.Add(Me.txtAge)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtSecondName)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.dgvEmployeeTable)
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Controls.Add(Me.txtName)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(805, 414)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Sequential Operations"
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(11, 306)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(94, 29)
        Me.btnOpen.TabIndex = 13
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(579, 335)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(94, 29)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(579, 300)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 29)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(580, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Departament"
        '
        'cbDepartament
        '
        Me.cbDepartament.FormattingEnabled = True
        Me.cbDepartament.Items.AddRange(New Object() {"Office", "Library", "Servers", "Administration"})
        Me.cbDepartament.Location = New System.Drawing.Point(580, 219)
        Me.cbDepartament.Name = "cbDepartament"
        Me.cbDepartament.Size = New System.Drawing.Size(168, 28)
        Me.cbDepartament.TabIndex = 9
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(579, 160)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(169, 27)
        Me.txtAge.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(579, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Age"
        '
        'txtSecondName
        '
        Me.txtSecondName.Location = New System.Drawing.Point(579, 100)
        Me.txtSecondName.Name = "txtSecondName"
        Me.txtSecondName.Size = New System.Drawing.Size(169, 27)
        Me.txtSecondName.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(579, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Second Name"
        '
        'dgvEmployeeTable
        '
        Me.dgvEmployeeTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvEmployeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployeeTable.Location = New System.Drawing.Point(11, 81)
        Me.dgvEmployeeTable.Name = "dgvEmployeeTable"
        Me.dgvEmployeeTable.RowHeadersWidth = 51
        Me.dgvEmployeeTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmployeeTable.Size = New System.Drawing.Size(520, 204)
        Me.dgvEmployeeTable.TabIndex = 4
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(579, 265)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 29)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(579, 37)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(169, 27)
        Me.txtName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(579, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EMPLOYEE REGISTRATION"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.btnUpdateSql)
        Me.TabPage2.Controls.Add(Me.btnDeleteSql)
        Me.TabPage2.Controls.Add(Me.btnInsert)
        Me.TabPage2.Controls.Add(Me.txtEmailSql)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txtPhoneSql)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txtNameSql)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.dgvContactos)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(805, 414)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Sequential Indexed Operations"
        '
        'btnUpdateSql
        '
        Me.btnUpdateSql.Location = New System.Drawing.Point(702, 259)
        Me.btnUpdateSql.Name = "btnUpdateSql"
        Me.btnUpdateSql.Size = New System.Drawing.Size(94, 38)
        Me.btnUpdateSql.TabIndex = 17
        Me.btnUpdateSql.Text = "Update"
        Me.btnUpdateSql.UseVisualStyleBackColor = True
        '
        'btnDeleteSql
        '
        Me.btnDeleteSql.Location = New System.Drawing.Point(583, 259)
        Me.btnDeleteSql.Name = "btnDeleteSql"
        Me.btnDeleteSql.Size = New System.Drawing.Size(103, 38)
        Me.btnDeleteSql.TabIndex = 16
        Me.btnDeleteSql.Text = "Delete"
        Me.btnDeleteSql.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(583, 209)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(213, 44)
        Me.btnInsert.TabIndex = 15
        Me.btnInsert.Text = "Add"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'txtEmailSql
        '
        Me.txtEmailSql.Location = New System.Drawing.Point(583, 166)
        Me.txtEmailSql.Name = "txtEmailSql"
        Me.txtEmailSql.Size = New System.Drawing.Size(213, 27)
        Me.txtEmailSql.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(583, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Email"
        '
        'txtPhoneSql
        '
        Me.txtPhoneSql.Location = New System.Drawing.Point(583, 106)
        Me.txtPhoneSql.Name = "txtPhoneSql"
        Me.txtPhoneSql.Size = New System.Drawing.Size(213, 27)
        Me.txtPhoneSql.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(583, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Phone"
        '
        'txtNameSql
        '
        Me.txtNameSql.Location = New System.Drawing.Point(583, 43)
        Me.txtNameSql.Name = "txtNameSql"
        Me.txtNameSql.Size = New System.Drawing.Size(213, 27)
        Me.txtNameSql.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(583, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 20)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Name"
        '
        'dgvContactos
        '
        Me.dgvContactos.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContactos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.NName, Me.PPhone, Me.EEmail})
        Me.dgvContactos.Location = New System.Drawing.Point(11, 76)
        Me.dgvContactos.Name = "dgvContactos"
        Me.dgvContactos.RowHeadersWidth = 51
        Me.dgvContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvContactos.Size = New System.Drawing.Size(553, 204)
        Me.dgvContactos.TabIndex = 6
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.Width = 125
        '
        'NName
        '
        Me.NName.HeaderText = "Name"
        Me.NName.MinimumWidth = 6
        Me.NName.Name = "NName"
        Me.NName.Width = 125
        '
        'PPhone
        '
        Me.PPhone.HeaderText = "Phone"
        Me.PPhone.MinimumWidth = 6
        Me.PPhone.Name = "PPhone"
        Me.PPhone.Width = 125
        '
        'EEmail
        '
        Me.EEmail.HeaderText = "Email"
        Me.EEmail.MinimumWidth = 6
        Me.EEmail.Name = "EEmail"
        Me.EEmail.Width = 125
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(3, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 41)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "CONTACS"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.Button5)
        Me.TabPage3.Controls.Add(Me.Button6)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.cbDepartamentDA)
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(Me.Button4)
        Me.TabPage3.Controls.Add(Me.txtNameDA)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.txtID)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.dgvEmpTabl)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(805, 414)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Direct Operations"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(129, 288)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(94, 38)
        Me.Button5.TabIndex = 32
        Me.Button5.Text = "Update"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(10, 288)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(103, 38)
        Me.Button6.TabIndex = 31
        Me.Button6.Text = "Open"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(498, 167)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 20)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Departament"
        '
        'cbDepartamentDA
        '
        Me.cbDepartamentDA.FormattingEnabled = True
        Me.cbDepartamentDA.Items.AddRange(New Object() {"Office", "Library", "Servers", "Administration"})
        Me.cbDepartamentDA.Location = New System.Drawing.Point(498, 190)
        Me.cbDepartamentDA.Name = "cbDepartamentDA"
        Me.cbDepartamentDA.Size = New System.Drawing.Size(213, 28)
        Me.cbDepartamentDA.TabIndex = 29
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(617, 283)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 38)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(498, 283)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 38)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(498, 233)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(213, 44)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtNameDA
        '
        Me.txtNameDA.Location = New System.Drawing.Point(498, 130)
        Me.txtNameDA.Name = "txtNameDA"
        Me.txtNameDA.Size = New System.Drawing.Size(213, 27)
        Me.txtNameDA.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(498, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 20)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Name"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(498, 67)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(213, 27)
        Me.txtID.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(498, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 20)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "ID"
        '
        'dgvEmpTabl
        '
        Me.dgvEmpTabl.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvEmpTabl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpTabl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgvEmpTabl.Location = New System.Drawing.Point(11, 78)
        Me.dgvEmpTabl.Name = "dgvEmpTabl"
        Me.dgvEmpTabl.RowHeadersWidth = 51
        Me.dgvEmpTabl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmpTabl.Size = New System.Drawing.Size(432, 204)
        Me.dgvEmpTabl.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Departament"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(3, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(350, 41)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "EMPLOYEE DEPARTMENT"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 447)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Unit 2 VB"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvEmployeeTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvContactos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgvEmpTabl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgvEmployeeTable As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSecondName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents dgvContactos As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents btnOpen As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cbDepartament As ComboBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents NName As DataGridViewTextBoxColumn
    Friend WithEvents PPhone As DataGridViewTextBoxColumn
    Friend WithEvents EEmail As DataGridViewTextBoxColumn
    Friend WithEvents btnUpdateSql As Button
    Friend WithEvents btnDeleteSql As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents txtEmailSql As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPhoneSql As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNameSql As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents txtNameDA As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents dgvEmpTabl As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cbDepartamentDA As ComboBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn

End Class
