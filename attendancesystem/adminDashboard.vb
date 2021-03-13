Imports MySql.Data.MySqlClient
Public Class adminDashboard

    Shared Property adminDashboard As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub adminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
        fncConnectDatabase()

        Timer1.Enabled = True

        date1.Text = Date.Now.ToString("MMM dd, yyyy")

        Dim NAMEquery As String = "SELECT * FROM tbl_employee"
        Using NAMEcon As MySqlConnection = New MySqlConnection("server=localhost;user id=root;password=esperanza;database=db_attendance")
            Using NAMEcmd As MySqlCommand = New MySqlCommand(NAMEquery, NAMEcon)
                Using da As New MySqlDataAdapter()
                    da.SelectCommand = NAMEcmd
                    Using dt As New DataTable()
                        NAMEcon.Open()
                        da.Fill(dt)

                        If dt.Rows.Count > 0 Then
                            lblTotalEmp.Text = dt.Rows.Count()

                        Else
                            lblTotalEmp.Text = ""

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
                            lblOntime.Text = dt.Rows.Count.ToString()

                        Else
                            lblOntime.Text = ""

                        End If
                    End Using
                End Using
            End Using
        End Using



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim oForm As New Form1

        oForm.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim oForm As New login

        oForm.Show()
        Me.Hide()
    End Sub

    Private Sub date1_Click(sender As Object, e As EventArgs) Handles date1.Click

    End Sub

    Private Sub btnTimesheet_Click(sender As Object, e As EventArgs) Handles btnTimesheet.Click
        AttendanceRecords.Show()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim oForm As New addUser
        oForm.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        EmpTimesheet.Show()


    End Sub

    Private Sub lblOntime_Click(sender As Object, e As EventArgs) Handles lblOntime.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        payroll.Show()

    End Sub
End Class