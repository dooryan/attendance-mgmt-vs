<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class attendance
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(attendance))
        Me.btnIn = New System.Windows.Forms.Button()
        Me.btnOut = New System.Windows.Forms.Button()
        Me.dgrid_emp_time_history = New System.Windows.Forms.DataGridView()
        Me.date1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.time1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgrid_emp_time_history, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnIn
        '
        Me.btnIn.BackColor = System.Drawing.Color.SlateGray
        Me.btnIn.BackgroundImage = Global.attendancesystem.My.Resources.Resources._800722
        Me.btnIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIn.Location = New System.Drawing.Point(18, 18)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(242, 102)
        Me.btnIn.TabIndex = 0
        Me.btnIn.Text = "TIME IN"
        Me.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIn.UseVisualStyleBackColor = False
        '
        'btnOut
        '
        Me.btnOut.BackColor = System.Drawing.Color.SlateGray
        Me.btnOut.BackgroundImage = Global.attendancesystem.My.Resources.Resources._1267047
        Me.btnOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOut.Location = New System.Drawing.Point(272, 18)
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
        Me.dgrid_emp_time_history.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgrid_emp_time_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrid_emp_time_history.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.date1, Me.time1, Me.stat})
        Me.dgrid_emp_time_history.Location = New System.Drawing.Point(18, 132)
        Me.dgrid_emp_time_history.Name = "dgrid_emp_time_history"
        Me.dgrid_emp_time_history.RowTemplate.Height = 24
        Me.dgrid_emp_time_history.Size = New System.Drawing.Size(496, 200)
        Me.dgrid_emp_time_history.TabIndex = 2
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(110, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 34)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "user"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Corbel", 22.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 46)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Date"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 51)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = " "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.btnIn)
        Me.Panel2.Controls.Add(Me.btnOut)
        Me.Panel2.Controls.Add(Me.dgrid_emp_time_history)
        Me.Panel2.Location = New System.Drawing.Point(233, 23)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(531, 353)
        Me.Panel2.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Gadugi", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 34)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Hello, "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(17, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(822, 436)
        Me.Panel1.TabIndex = 20
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Snow
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Location = New System.Drawing.Point(22, 18)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(782, 399)
        Me.Panel3.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.attendancesystem.My.Resources.Resources.free_exit_logout_icon_2857_thumb
        Me.PictureBox1.Location = New System.Drawing.Point(35, 332)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'attendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(859, 480)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "attendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "attendance"
        CType(Me.dgrid_emp_time_history, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnIn As Button
    Friend WithEvents btnOut As Button
    Friend WithEvents dgrid_emp_time_history As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents date1 As DataGridViewTextBoxColumn
    Friend WithEvents time1 As DataGridViewTextBoxColumn
    Friend WithEvents stat As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
End Class
