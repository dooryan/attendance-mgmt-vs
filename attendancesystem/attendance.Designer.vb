<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class attendance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(attendance))
        Me.btnIn = New System.Windows.Forms.Button()
        Me.btnOut = New System.Windows.Forms.Button()
        Me.dgrid_emp_time_history = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.date1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.time1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgrid_emp_time_history, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnIn
        '
        Me.btnIn.BackColor = System.Drawing.Color.Wheat
        Me.btnIn.BackgroundImage = Global.attendancesystem.My.Resources.Resources._800722
        Me.btnIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIn.Location = New System.Drawing.Point(325, 90)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(242, 102)
        Me.btnIn.TabIndex = 0
        Me.btnIn.Text = "TIME IN"
        Me.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIn.UseVisualStyleBackColor = False
        '
        'btnOut
        '
        Me.btnOut.BackColor = System.Drawing.Color.Wheat
        Me.btnOut.BackgroundImage = Global.attendancesystem.My.Resources.Resources._1267047
        Me.btnOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOut.Location = New System.Drawing.Point(579, 90)
        Me.btnOut.Name = "btnOut"
        Me.btnOut.Size = New System.Drawing.Size(242, 102)
        Me.btnOut.TabIndex = 1
        Me.btnOut.Text = "TIME OUT"
        Me.btnOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOut.UseVisualStyleBackColor = False
        '
        'dgrid_emp_time_history
        '
        Me.dgrid_emp_time_history.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgrid_emp_time_history.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgrid_emp_time_history.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgrid_emp_time_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrid_emp_time_history.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.date1, Me.time1, Me.stat})
        Me.dgrid_emp_time_history.Location = New System.Drawing.Point(325, 216)
        Me.dgrid_emp_time_history.Name = "dgrid_emp_time_history"
        Me.dgrid_emp_time_history.RowTemplate.Height = 24
        Me.dgrid_emp_time_history.Size = New System.Drawing.Size(496, 200)
        Me.dgrid_emp_time_history.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(528, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 34)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Hello, Employee 234!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 42)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Date"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Wheat
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(89, 401)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 32)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "logout"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.attendancesystem.My.Resources.Resources.Sumifru_1
        Me.PictureBox1.Location = New System.Drawing.Point(18, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(280, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 49)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Time"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Tan
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(18, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(280, 180)
        Me.Panel1.TabIndex = 9
        '
        'date1
        '
        Me.date1.HeaderText = "Date"
        Me.date1.Name = "date1"
        '
        'time1
        '
        Me.time1.HeaderText = "Time"
        Me.time1.Name = "time1"
        '
        'stat
        '
        Me.stat.HeaderText = "IN/OUT"
        Me.stat.Name = "stat"
        '
        'attendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(846, 445)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgrid_emp_time_history)
        Me.Controls.Add(Me.btnOut)
        Me.Controls.Add(Me.btnIn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "attendance"
        Me.Text = "attendance"
        CType(Me.dgrid_emp_time_history, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIn As Button
    Friend WithEvents btnOut As Button
    Friend WithEvents dgrid_emp_time_history As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents date1 As DataGridViewTextBoxColumn
    Friend WithEvents time1 As DataGridViewTextBoxColumn
    Friend WithEvents stat As DataGridViewTextBoxColumn
End Class
