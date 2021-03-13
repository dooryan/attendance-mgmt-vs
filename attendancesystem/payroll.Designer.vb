<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payroll
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtperHour = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPerDay = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdays = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCAd = New System.Windows.Forms.TextBox()
        Me.txtPhil = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSSS = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtpagibig = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.date1 = New System.Windows.Forms.DateTimePicker()
        Me.date2 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnTotalPay = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.d = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rate_hour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mrate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sss = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(117, 14)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(98, 22)
        Me.txtID.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(117, 45)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(223, 22)
        Me.txtName.TabIndex = 4
        '
        'txtperHour
        '
        Me.txtperHour.BackColor = System.Drawing.Color.Snow
        Me.txtperHour.Location = New System.Drawing.Point(134, 209)
        Me.txtperHour.Name = "txtperHour"
        Me.txtperHour.Size = New System.Drawing.Size(190, 22)
        Me.txtperHour.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Income"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Rate per Hour"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Rate Wage"
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(135, 242)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(190, 22)
        Me.txtMonth.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Rate per Day"
        '
        'txtPerDay
        '
        Me.txtPerDay.BackColor = System.Drawing.Color.LightCoral
        Me.txtPerDay.Location = New System.Drawing.Point(134, 181)
        Me.txtPerDay.Name = "txtPerDay"
        Me.txtPerDay.Size = New System.Drawing.Size(190, 22)
        Me.txtPerDay.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "No. of days"
        '
        'txtdays
        '
        Me.txtdays.BackColor = System.Drawing.Color.LightCoral
        Me.txtdays.Location = New System.Drawing.Point(134, 280)
        Me.txtdays.Name = "txtdays"
        Me.txtdays.Size = New System.Drawing.Size(190, 22)
        Me.txtdays.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(415, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Deductions"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(461, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Cash Advance"
        '
        'txtCAd
        '
        Me.txtCAd.BackColor = System.Drawing.Color.LightCoral
        Me.txtCAd.Location = New System.Drawing.Point(566, 181)
        Me.txtCAd.Name = "txtCAd"
        Me.txtCAd.Size = New System.Drawing.Size(190, 22)
        Me.txtCAd.TabIndex = 16
        '
        'txtPhil
        '
        Me.txtPhil.BackColor = System.Drawing.Color.LightCoral
        Me.txtPhil.Location = New System.Drawing.Point(566, 209)
        Me.txtPhil.Name = "txtPhil"
        Me.txtPhil.Size = New System.Drawing.Size(190, 22)
        Me.txtPhil.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(471, 214)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 17)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Philhealth"
        '
        'txtSSS
        '
        Me.txtSSS.BackColor = System.Drawing.Color.LightCoral
        Me.txtSSS.Location = New System.Drawing.Point(566, 242)
        Me.txtSSS.Name = "txtSSS"
        Me.txtSSS.Size = New System.Drawing.Size(190, 22)
        Me.txtSSS.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(506, 247)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 17)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "SSS"
        '
        'txtpagibig
        '
        Me.txtpagibig.BackColor = System.Drawing.Color.LightCoral
        Me.txtpagibig.Location = New System.Drawing.Point(566, 270)
        Me.txtpagibig.Name = "txtpagibig"
        Me.txtpagibig.Size = New System.Drawing.Size(190, 22)
        Me.txtpagibig.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(501, 275)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 17)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Pag-ibig"
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(626, 353)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(130, 51)
        Me.btnPay.TabIndex = 23
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'date1
        '
        Me.date1.Location = New System.Drawing.Point(406, 6)
        Me.date1.Name = "date1"
        Me.date1.Size = New System.Drawing.Size(290, 22)
        Me.date1.TabIndex = 24
        '
        'date2
        '
        Me.date2.Location = New System.Drawing.Point(407, 45)
        Me.date2.Name = "date2"
        Me.date2.Size = New System.Drawing.Size(288, 22)
        Me.date2.TabIndex = 25
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnFilter)
        Me.Panel1.Controls.Add(Me.date2)
        Me.Panel1.Controls.Add(Me.date1)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(803, 89)
        Me.Panel1.TabIndex = 26
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(718, 10)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(74, 56)
        Me.btnFilter.TabIndex = 26
        Me.btnFilter.Text = "GO"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'btnTotalPay
        '
        Me.btnTotalPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotalPay.Location = New System.Drawing.Point(39, 335)
        Me.btnTotalPay.Name = "btnTotalPay"
        Me.btnTotalPay.Size = New System.Drawing.Size(285, 45)
        Me.btnTotalPay.TabIndex = 27
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.d, Me.emp_id, Me.rate_hour, Me.dr, Me.mrate, Me.sss, Me.phil, Me.pg})
        Me.DataGridView1.Location = New System.Drawing.Point(693, 111)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(111, 38)
        Me.DataGridView1.TabIndex = 31
        Me.DataGridView1.Visible = False
        '
        'd
        '
        Me.d.HeaderText = "id"
        Me.d.Name = "d"
        '
        'emp_id
        '
        Me.emp_id.HeaderText = "Employee ID"
        Me.emp_id.Name = "emp_id"
        '
        'rate_hour
        '
        Me.rate_hour.HeaderText = "Hourly Rate"
        Me.rate_hour.Name = "rate_hour"
        '
        'dr
        '
        Me.dr.HeaderText = "Daily Rate"
        Me.dr.Name = "dr"
        '
        'mrate
        '
        Me.mrate.HeaderText = "Monthly Rate"
        Me.mrate.Name = "mrate"
        '
        'sss
        '
        Me.sss.HeaderText = "SSS"
        Me.sss.Name = "sss"
        '
        'phil
        '
        Me.phil.HeaderText = "philhealth"
        Me.phil.Name = "phil"
        '
        'pg
        '
        Me.pg.HeaderText = "pagibig"
        Me.pg.Name = "pg"
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(79, 386)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(190, 40)
        Me.btnCompute.TabIndex = 32
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'payroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 449)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnTotalPay)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.txtpagibig)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtSSS)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtPhil)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCAd)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtdays)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPerDay)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtperHour)
        Me.Name = "payroll"
        Me.Text = "payroll"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtperHour As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMonth As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPerDay As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtdays As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCAd As TextBox
    Friend WithEvents txtPhil As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSSS As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtpagibig As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnPay As Button
    Friend WithEvents date1 As DateTimePicker
    Friend WithEvents date2 As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnFilter As Button
    Friend WithEvents btnTotalPay As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents d As DataGridViewTextBoxColumn
    Friend WithEvents emp_id As DataGridViewTextBoxColumn
    Friend WithEvents rate_hour As DataGridViewTextBoxColumn
    Friend WithEvents dr As DataGridViewTextBoxColumn
    Friend WithEvents mrate As DataGridViewTextBoxColumn
    Friend WithEvents sss As DataGridViewTextBoxColumn
    Friend WithEvents phil As DataGridViewTextBoxColumn
    Friend WithEvents pg As DataGridViewTextBoxColumn
    Friend WithEvents btnCompute As Button
End Class
