Imports System.DateTime
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient



Public Class attendance


    Shared Property userDashboard As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIn.Click

        Dim user As String = Label1.Text
        Dim dateNow As String = Date.Now.ToString("yyyy/MM/dd")
        Dim timeNow As String = Date.Now.ToString("HH:mm:ss")
        Dim statt As String = "IN"
        Dim Flag = 0

        dataAttendance = New DataTable()
        sqlAttendanceAdapter = New MySqlDataAdapter
        command.Connection = conAttendanceSystem
        Dim com = New MySqlCommand()
        com.Connection = conAttendanceSystem

        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcValidateTimeEntry"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("uname", user)
                .Parameters.AddWithValue("stat", statt)
                .Parameters.AddWithValue("d", dateNow)

                .ExecuteNonQuery()
                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)

                If dataAttendance.Rows.Count >= 1 Then
                    MessageBox.Show("YOU HAVE ALREADY TIME-IN FOR TODAY", "", MessageBoxButtons.OK, MessageBoxIcon.Hand)

                ElseIf dataAttendance.Rows.Count <= 0 Then
                    With com
                        .Parameters.Clear()
                        .CommandText = "prcEntryTimesheet"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("uname", user)
                        .Parameters.AddWithValue("stat", statt)
                        .Parameters.AddWithValue("currTime", timeNow)
                        .Parameters.AddWithValue("currDate", dateNow)
                        .Parameters.AddWithValue("flag", Flag)
                        .ExecuteNonQuery()

                        MessageBox.Show("Time-in successful", "", MessageBoxButtons.OK,
                                                        MessageBoxIcon.Information)
                    End With
                End If
            End With

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)

        End Try
        displayTimesheet()

    End Sub

    Private Sub attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Refresh()
        Timer1.Enabled = True

        Label1.Text = userDashboard

        displayTimesheet()



    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Label2.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim oForm As New login
        oForm.Show()
        Me.Dispose()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Date.Now.ToString("dd MMM yyy")
        Label3.Text = Date.Now.ToString("hh:mm:ss")

    End Sub

    Private Sub btnOut_Click(sender As Object, e As EventArgs) Handles btnOut.Click

        Dim user As String = Label1.Text
        Dim dateNow As String = Date.Now.ToString("yyyy/MM/dd")
        Dim timeNow As String = Date.Now.ToString("HH:mm:ss")
        Dim statt As String = "OUT"

        dataAttendance = New DataTable()
        sqlAttendanceAdapter = New MySqlDataAdapter
        command.Connection = conAttendanceSystem
        Dim com = New MySqlCommand()
        com.Connection = conAttendanceSystem
        Dim Flag = 1
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcValidateTimeEntry"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("uname", user)
                .Parameters.AddWithValue("stat", statt)
                .Parameters.AddWithValue("d", dateNow)

                .ExecuteNonQuery()
                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)

                If dataAttendance.Rows.Count >= 1 Then
                    MessageBox.Show("YOU HAVE ALREADY TIME-OUT FOR TODAY", "", MessageBoxButtons.OK, MessageBoxIcon.Hand)

                ElseIf dataAttendance.Rows.Count <= 0 Then
                    With com
                        .Parameters.Clear()
                        .CommandText = "prcEntryTimesheet"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("uname", user)
                        .Parameters.AddWithValue("stat", statt)
                        .Parameters.AddWithValue("currTime", timeNow)
                        .Parameters.AddWithValue("currDate", dateNow)
                        .Parameters.AddWithValue("flag", Flag)
                        .ExecuteNonQuery()

                        MessageBox.Show("Time-out successful", "", MessageBoxButtons.OK,
                                                        MessageBoxIcon.Information)
                    End With
                End If
            End With

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)

        End Try
        displayTimesheet()
    End Sub

    Private Sub dgrid_emp_time_history_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgrid_emp_time_history.CellContentClick

    End Sub

    Private Sub displayTimesheet()
        Dim user As String = Label1.Text

        dataAttendance = New DataTable()
        sqlAttendanceAdapter = New MySqlDataAdapter
        command.Connection = conAttendanceSystem
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcDisplayEmpTimesheet"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("uname", user)
                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)


                If dataAttendance.Rows.Count > 0 Then
                    dgrid_emp_time_history.RowCount = dataAttendance.Rows.Count

                    row = 0
                    While Not dataAttendance.Rows.Count - 1 < row
                        With dgrid_emp_time_history
                            .Rows(row).Cells(0).Value = dataAttendance.Rows(row).Item("tdate").ToString
                            .Rows(row).Cells(1).Value = dataAttendance.Rows(row).Item("ttime").ToString

                            .Rows(row).Cells(2).Value = dataAttendance.Rows(row).Item("status").ToString

                        End With
                        row = row + 1
                    End While
                Else
                    MessageBox.Show("No record found...")



                End If
                sqlAttendanceAdapter.Dispose()
                dataAttendance.Dispose()
            End With
        Catch ex As Exception

        End Try




    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()
        login.Show()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class