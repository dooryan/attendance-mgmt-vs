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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.DirectorySearcher2 = New System.DirectoryServices.DirectorySearcher()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.textSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.id1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.de = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fname1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lname1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.add1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bdate1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gender1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dHired1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BackgroundImage = Global.attendancesystem.My.Resources.Resources._61183
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(32, 158)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(185, 45)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackgroundImage = Global.attendancesystem.My.Resources.Resources.edit_new_icon_22
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Location = New System.Drawing.Point(32, 209)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(185, 45)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Wheat
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.btnRemove)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Location = New System.Drawing.Point(706, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 517)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.attendancesystem.My.Resources.Resources.Sumifru_1
        Me.PictureBox1.Location = New System.Drawing.Point(44, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button5.Location = New System.Drawing.Point(106, 473)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(68, 35)
        Me.Button5.TabIndex = 5
        Me.Button5.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackgroundImage = Global.attendancesystem.My.Resources.Resources.delete_remove_trash_trash_bin_trash_can_icon_1320073117929397588
        Me.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Location = New System.Drawing.Point(32, 260)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(185, 45)
        Me.btnRemove.TabIndex = 2
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'DirectorySearcher2
        '
        Me.DirectorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id1, Me.dID, Me.de, Me.fname1, Me.lname1, Me.add1, Me.bdate1, Me.gender1, Me.dHired1, Me.contact})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 97)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(688, 423)
        Me.DataGridView1.TabIndex = 5
        '
        'textSearch
        '
        Me.textSearch.Location = New System.Drawing.Point(180, 24)
        Me.textSearch.Name = "textSearch"
        Me.textSearch.Size = New System.Drawing.Size(292, 22)
        Me.textSearch.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Search Employee"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Wheat
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Corbel", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(493, 24)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(119, 45)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Font = New System.Drawing.Font("Corbel", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(358, 55)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(58, 21)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Auto"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"EMPLOYEE ID", "EMPLOYEE NAME"})
        Me.ComboBox1.Location = New System.Drawing.Point(180, 52)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(157, 24)
        Me.ComboBox1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.textSearch)
        Me.Panel2.Location = New System.Drawing.Point(12, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(676, 88)
        Me.Panel2.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Corbel", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(89, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Search by"
        '
        'id1
        '
        Me.id1.HeaderText = "ID"
        Me.id1.Name = "id1"
        Me.id1.Width = 50
        '
        'dID
        '
        Me.dID.HeaderText = "Dept ID"
        Me.dID.Name = "dID"
        Me.dID.ReadOnly = True
        Me.dID.Width = 84
        '
        'de
        '
        Me.de.HeaderText = "Department Name"
        Me.de.Name = "de"
        Me.de.Width = 139
        '
        'fname1
        '
        Me.fname1.HeaderText = "First Name"
        Me.fname1.Name = "fname1"
        Me.fname1.Width = 97
        '
        'lname1
        '
        Me.lname1.HeaderText = "Last Name"
        Me.lname1.Name = "lname1"
        Me.lname1.Width = 97
        '
        'add1
        '
        Me.add1.HeaderText = "Address"
        Me.add1.Name = "add1"
        Me.add1.Width = 89
        '
        'bdate1
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.bdate1.DefaultCellStyle = DataGridViewCellStyle1
        Me.bdate1.HeaderText = "Birthdate"
        Me.bdate1.Name = "bdate1"
        Me.bdate1.Width = 94
        '
        'gender1
        '
        Me.gender1.HeaderText = "Gender"
        Me.gender1.Name = "gender1"
        Me.gender1.Width = 85
        '
        'dHired1
        '
        Me.dHired1.HeaderText = "Date Hired"
        Me.dHired1.Name = "dHired1"
        Me.dHired1.Width = 97
        '
        'contact
        '
        Me.contact.HeaderText = "Contact No"
        Me.contact.Name = "contact"
        Me.contact.Width = 99
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(959, 523)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attendance "
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRemove As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents DirectorySearcher2 As DirectoryServices.DirectorySearcher
    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents textSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents id1 As DataGridViewTextBoxColumn
    Friend WithEvents dID As DataGridViewTextBoxColumn
    Friend WithEvents de As DataGridViewTextBoxColumn
    Friend WithEvents fname1 As DataGridViewTextBoxColumn
    Friend WithEvents lname1 As DataGridViewTextBoxColumn
    Friend WithEvents add1 As DataGridViewTextBoxColumn
    Friend WithEvents bdate1 As DataGridViewTextBoxColumn
    Friend WithEvents gender1 As DataGridViewTextBoxColumn
    Friend WithEvents dHired1 As DataGridViewTextBoxColumn
    Friend WithEvents contact As DataGridViewTextBoxColumn
End Class
