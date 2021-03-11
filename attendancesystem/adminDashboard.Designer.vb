<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminDashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnTimesheet = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblOntime = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTotalEmp = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.date1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLeave = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Wheat
        Me.Panel1.Controls.Add(Me.btnTimesheet)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(208, 527)
        Me.Panel1.TabIndex = 0
        '
        'btnTimesheet
        '
        Me.btnTimesheet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTimesheet.Location = New System.Drawing.Point(0, 270)
        Me.btnTimesheet.Name = "btnTimesheet"
        Me.btnTimesheet.Size = New System.Drawing.Size(208, 49)
        Me.btnTimesheet.TabIndex = 5
        Me.btnTimesheet.Text = "Timesheets"
        Me.btnTimesheet.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.attendancesystem.My.Resources.Resources.free_exit_logout_icon_2857_thumb
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(0, 475)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(208, 49)
        Me.Button5.TabIndex = 4
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.attendancesystem.My.Resources.Resources.Sumifru_1
        Me.PictureBox1.Location = New System.Drawing.Point(13, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(0, 215)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(208, 49)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Employees"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(0, 325)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(208, 49)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Add User"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(0, 160)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(208, 49)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Dashboard"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(233, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Welcome, Admin."
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Peru
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.lblOntime)
        Me.Panel3.Location = New System.Drawing.Point(278, 88)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(165, 121)
        Me.Panel3.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(23, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ON TIME"
        '
        'lblOntime
        '
        Me.lblOntime.AutoSize = True
        Me.lblOntime.BackColor = System.Drawing.Color.Transparent
        Me.lblOntime.CausesValidation = False
        Me.lblOntime.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOntime.ForeColor = System.Drawing.Color.Black
        Me.lblOntime.Location = New System.Drawing.Point(3, 13)
        Me.lblOntime.Name = "lblOntime"
        Me.lblOntime.Size = New System.Drawing.Size(51, 55)
        Me.lblOntime.TabIndex = 4
        Me.lblOntime.Text = "0"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.NavajoWhite
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.lblTotalEmp)
        Me.Panel5.Location = New System.Drawing.Point(494, 88)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(165, 121)
        Me.Panel5.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(10, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 18)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "TOTAL Employees"
        '
        'lblTotalEmp
        '
        Me.lblTotalEmp.AutoSize = True
        Me.lblTotalEmp.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalEmp.CausesValidation = False
        Me.lblTotalEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEmp.ForeColor = System.Drawing.Color.Black
        Me.lblTotalEmp.Location = New System.Drawing.Point(3, 13)
        Me.lblTotalEmp.Name = "lblTotalEmp"
        Me.lblTotalEmp.Size = New System.Drawing.Size(51, 55)
        Me.lblTotalEmp.TabIndex = 4
        Me.lblTotalEmp.Text = "0"
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(876, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(36, 32)
        Me.Button4.TabIndex = 10
        Me.Button4.UseVisualStyleBackColor = True
        '
        'date1
        '
        Me.date1.AutoSize = True
        Me.date1.BackColor = System.Drawing.Color.Transparent
        Me.date1.Font = New System.Drawing.Font("Trebuchet MS", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date1.Location = New System.Drawing.Point(513, 16)
        Me.date1.Name = "date1"
        Me.date1.Size = New System.Drawing.Size(87, 42)
        Me.date1.TabIndex = 12
        Me.date1.Text = "date"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.OldLace
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.lblLeave)
        Me.Panel6.Location = New System.Drawing.Point(698, 88)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(165, 121)
        Me.Panel6.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(26, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "On-LEAVE"
        '
        'lblLeave
        '
        Me.lblLeave.AutoSize = True
        Me.lblLeave.BackColor = System.Drawing.Color.Transparent
        Me.lblLeave.CausesValidation = False
        Me.lblLeave.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeave.ForeColor = System.Drawing.Color.Black
        Me.lblLeave.Location = New System.Drawing.Point(3, 13)
        Me.lblLeave.Name = "lblLeave"
        Me.lblLeave.Size = New System.Drawing.Size(51, 55)
        Me.lblLeave.TabIndex = 4
        Me.lblLeave.Text = "0"
        '
        'adminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(912, 521)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.date1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminDashboard"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents lblOntime As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTotalEmp As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents date1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblLeave As Label
    Friend WithEvents btnTimesheet As Button
End Class
