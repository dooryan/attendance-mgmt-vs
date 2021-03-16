Imports MySql.Data.MySqlClient
Public Class adminDashboard

    Shared Property adminDashboard As String
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub adminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
        fncConnectDatabase()

        Timer1.Enabled = True

        ffff.Text = Date.Now.ToString("MMM dd, yyyy")

        Dim NAMEquery As String = "SELECT * FROM tbl_employee"
        Using NAMEcon As MySqlConnection = New MySqlConnection("server=localhost;user id=root;password=esperanza;database=db_attendance")
            Using NAMEcmd As MySqlCommand = New MySqlCommand(NAMEquery, NAMEcon)
                Using da As New MySqlDataAdapter()
                    da.SelectCommand = NAMEcmd
                    Using dt As New DataTable()
                        NAMEcon.Open()
                        da.Fill(dt)

                        If dt.Rows.Count > 0 Then
                            lblTotalEmp1.Text = dt.Rows.Count()

                        Else
                            lblTotalEmp1.Text = ""

                        End If

                    End Using
                    NAMEcon.Close()
                End Using
            End Using
        End Using


        Dim query As String = "SELECT * FROM tbl_timesheet WHERE tdate ='" & DateAndTime.Now.ToString("yyyy/MM/dd") & "'  AND  status='" & "IN" & "' "
        Using con As MySqlConnection = New MySqlConnection("server=localhost;user id=root;password=esperanza;database=db_attendance")
            Using cmd As MySqlCommand = New MySqlCommand(query, con)
                Using sda As New MySqlDataAdapter()
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            lblOntime1.Text = dt.Rows.Count.ToString()

                        Else
                            lblOntime1.Text = ""

                        End If
                    End Using
                End Using
            End Using
        End Using



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)


        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub date1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnTimesheet_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub lblOntime_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddNewUserToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Dim oForm As New addUser
        oForm.Show()
    End Sub

    Private Sub lblTotalEmp1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Dim oForm As New login

        oForm.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub btnTimesheet_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PayRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayRecordsToolStripMenuItem.Click
        AttendanceRecords.Show()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddPayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPayToolStripMenuItem.Click
        payroll.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub ViewReportsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddNewUserToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles AddNewUserToolStripMenuItem1.Click
        addUser.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oForm As New Form1

        oForm.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        EmpTimesheet.Show()
    End Sub

    Private Sub ViewUsersToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewUsersToolStripMenuItem1.Click
        viewUsers.Show()
    End Sub
End Class