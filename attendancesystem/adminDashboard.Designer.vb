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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SumifruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewEmployeeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeSheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewUserToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewUsersToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotalEmp1 = New System.Windows.Forms.Label()
        Me.ffff = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblAbsent = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblOntime1 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblLate = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Panel10.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Cambria", 23.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label15.Location = New System.Drawing.Point(-73, -61)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(951, 46)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Laak Banana Employees Multi-Purpose Cooperative "
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Transparent
        Me.Panel10.BackgroundImage = CType(resources.GetObject("Panel10.BackgroundImage"), System.Drawing.Image)
        Me.Panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel10.Controls.Add(Me.Panel9)
        Me.Panel10.Location = New System.Drawing.Point(54, 91)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1012, 528)
        Me.Panel10.TabIndex = 38
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.White
        Me.Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel9.Controls.Add(Me.MenuStrip1)
        Me.Panel9.Controls.Add(Me.Panel8)
        Me.Panel9.Controls.Add(Me.Panel13)
        Me.Panel9.Location = New System.Drawing.Point(16, 20)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(981, 486)
        Me.Panel9.TabIndex = 33
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SumifruToolStripMenuItem, Me.DToolStripMenuItem, Me.TimeSheetToolStripMenuItem, Me.UserToolStripMenuItem, Me.ToolStripMenuItem1, Me.LogOutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 1)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(631, 30)
        Me.MenuStrip1.TabIndex = 32
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SumifruToolStripMenuItem
        '
        Me.SumifruToolStripMenuItem.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SumifruToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.SumifruToolStripMenuItem.Name = "SumifruToolStripMenuItem"
        Me.SumifruToolStripMenuItem.Size = New System.Drawing.Size(69, 26)
        Me.SumifruToolStripMenuItem.Text = "Menu"
        '
        'DToolStripMenuItem
        '
        Me.DToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewEmployeeToolStripMenuItem1, Me.Button3})
        Me.DToolStripMenuItem.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.DToolStripMenuItem.Name = "DToolStripMenuItem"
        Me.DToolStripMenuItem.Size = New System.Drawing.Size(115, 26)
        Me.DToolStripMenuItem.Text = "Employees "
        '
        'AddNewEmployeeToolStripMenuItem1
        '
        Me.AddNewEmployeeToolStripMenuItem1.Name = "AddNewEmployeeToolStripMenuItem1"
        Me.AddNewEmployeeToolStripMenuItem1.Size = New System.Drawing.Size(250, 26)
        Me.AddNewEmployeeToolStripMenuItem1.Text = "Add New Employee"
        '
        'Button3
        '
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(250, 26)
        Me.Button3.Text = "View Employee"
        '
        'TimeSheetToolStripMenuItem
        '
        Me.TimeSheetToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Button6})
        Me.TimeSheetToolStripMenuItem.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeSheetToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.TimeSheetToolStripMenuItem.Name = "TimeSheetToolStripMenuItem"
        Me.TimeSheetToolStripMenuItem.Size = New System.Drawing.Size(110, 26)
        Me.TimeSheetToolStripMenuItem.Text = "Time Sheet"
        '
        'Button6
        '
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(259, 26)
        Me.Button6.Text = "Employee TimeSheet"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewUserToolStripMenuItem1, Me.ViewUsersToolStripMenuItem1})
        Me.UserToolStripMenuItem.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.UserToolStripMenuItem.Text = "Manage Accounts"
        '
        'AddNewUserToolStripMenuItem1
        '
        Me.AddNewUserToolStripMenuItem1.Name = "AddNewUserToolStripMenuItem1"
        Me.AddNewUserToolStripMenuItem1.Size = New System.Drawing.Size(204, 26)
        Me.AddNewUserToolStripMenuItem1.Text = "Add new User"
        '
        'ViewUsersToolStripMenuItem1
        '
        Me.ViewUsersToolStripMenuItem1.Name = "ViewUsersToolStripMenuItem1"
        Me.ViewUsersToolStripMenuItem1.Size = New System.Drawing.Size(204, 26)
        Me.ViewUsersToolStripMenuItem1.Text = "View Users"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddPayToolStripMenuItem, Me.PayRecordsToolStripMenuItem})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(80, 26)
        Me.ToolStripMenuItem1.Text = "Payroll"
        '
        'AddPayToolStripMenuItem
        '
        Me.AddPayToolStripMenuItem.Name = "AddPayToolStripMenuItem"
        Me.AddPayToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.AddPayToolStripMenuItem.Text = "Add Pay"
        '
        'PayRecordsToolStripMenuItem
        '
        Me.PayRecordsToolStripMenuItem.Name = "PayRecordsToolStripMenuItem"
        Me.PayRecordsToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.PayRecordsToolStripMenuItem.Text = "Pay Records"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(84, 26)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Controls.Add(Me.Label2)
        Me.Panel8.Controls.Add(Me.Panel2)
        Me.Panel8.Controls.Add(Me.ffff)
        Me.Panel8.Controls.Add(Me.Panel4)
        Me.Panel8.Controls.Add(Me.Panel7)
        Me.Panel8.Controls.Add(Me.Panel11)
        Me.Panel8.Controls.Add(Me.Panel12)
        Me.Panel8.Location = New System.Drawing.Point(184, 36)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(797, 450)
        Me.Panel8.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cambria", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(316, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(401, 55)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Welcome, Admin!"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.lblTotalEmp1)
        Me.Panel2.Location = New System.Drawing.Point(517, 230)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(221, 114)
        Me.Panel2.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 22)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "TOTAL Employees"
        '
        'lblTotalEmp1
        '
        Me.lblTotalEmp1.AutoSize = True
        Me.lblTotalEmp1.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalEmp1.CausesValidation = False
        Me.lblTotalEmp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEmp1.ForeColor = System.Drawing.Color.White
        Me.lblTotalEmp1.Location = New System.Drawing.Point(3, 14)
        Me.lblTotalEmp1.Name = "lblTotalEmp1"
        Me.lblTotalEmp1.Size = New System.Drawing.Size(51, 55)
        Me.lblTotalEmp1.TabIndex = 4
        Me.lblTotalEmp1.Text = "0"
        '
        'ffff
        '
        Me.ffff.AutoSize = True
        Me.ffff.BackColor = System.Drawing.Color.Transparent
        Me.ffff.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ffff.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.ffff.Location = New System.Drawing.Point(449, 7)
        Me.ffff.Name = "ffff"
        Me.ffff.Size = New System.Drawing.Size(61, 28)
        Me.ffff.TabIndex = 21
        Me.ffff.Text = "date"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Location = New System.Drawing.Point(564, 107)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(171, 114)
        Me.Panel4.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(27, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 22)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "On-LEAVE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.CausesValidation = False
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(3, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 55)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "0"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Label11)
        Me.Panel7.Controls.Add(Me.lblAbsent)
        Me.Panel7.Location = New System.Drawing.Point(217, 107)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(163, 114)
        Me.Panel7.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(27, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 22)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "ABSENT"
        '
        'lblAbsent
        '
        Me.lblAbsent.AutoSize = True
        Me.lblAbsent.BackColor = System.Drawing.Color.Transparent
        Me.lblAbsent.CausesValidation = False
        Me.lblAbsent.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbsent.ForeColor = System.Drawing.Color.White
        Me.lblAbsent.Location = New System.Drawing.Point(3, 14)
        Me.lblAbsent.Name = "lblAbsent"
        Me.lblAbsent.Size = New System.Drawing.Size(51, 55)
        Me.lblAbsent.TabIndex = 4
        Me.lblAbsent.Text = "0"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.Label12)
        Me.Panel11.Controls.Add(Me.lblOntime1)
        Me.Panel11.Location = New System.Drawing.Point(47, 107)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(165, 114)
        Me.Panel11.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(23, 84)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 22)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "ON TIME"
        '
        'lblOntime1
        '
        Me.lblOntime1.AutoSize = True
        Me.lblOntime1.BackColor = System.Drawing.Color.Transparent
        Me.lblOntime1.CausesValidation = False
        Me.lblOntime1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOntime1.ForeColor = System.Drawing.Color.White
        Me.lblOntime1.Location = New System.Drawing.Point(3, 14)
        Me.lblOntime1.Name = "lblOntime1"
        Me.lblOntime1.Size = New System.Drawing.Size(51, 55)
        Me.lblOntime1.TabIndex = 4
        Me.lblOntime1.Text = "0"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.Label14)
        Me.Panel12.Controls.Add(Me.lblLate)
        Me.Panel12.Location = New System.Drawing.Point(387, 107)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(171, 114)
        Me.Panel12.TabIndex = 17
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(27, 84)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 22)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "LATE"
        '
        'lblLate
        '
        Me.lblLate.AutoSize = True
        Me.lblLate.BackColor = System.Drawing.Color.Transparent
        Me.lblLate.CausesValidation = False
        Me.lblLate.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLate.ForeColor = System.Drawing.Color.White
        Me.lblLate.Location = New System.Drawing.Point(3, 14)
        Me.lblLate.Name = "lblLate"
        Me.lblLate.Size = New System.Drawing.Size(51, 55)
        Me.lblLate.TabIndex = 4
        Me.lblLate.Text = "0"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel13.Controls.Add(Me.Button9)
        Me.Panel13.Location = New System.Drawing.Point(0, 36)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(185, 450)
        Me.Panel13.TabIndex = 23
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button9.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(17, 133)
        Me.Button9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(160, 49)
        Me.Button9.TabIndex = 26
        Me.Button9.Text = "Dashboard"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'adminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1139, 700)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Label15)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "adminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attendance System"
        Me.Panel10.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SumifruToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewEmployeeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Button3 As ToolStripMenuItem
    Friend WithEvents TimeSheetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button6 As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddPayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PayRecordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotalEmp1 As Label
    Friend WithEvents ffff As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents lblAbsent As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents lblOntime1 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents lblLate As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents AddNewUserToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ViewUsersToolStripMenuItem1 As ToolStripMenuItem
End Class
