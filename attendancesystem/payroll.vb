Imports MySql.Data.MySqlClient
Public Class payroll
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub payroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()

    End Sub
    Private Sub AddPay()



        Dim petsa = Date.Now.ToString("yyyy/MM/dd")
        Dim gross As Decimal = Val(txtPerDay.Text) * Val(txtdays.Text)
        Dim deduct As Decimal = Val(txtCAd.Text) + Val(txtpagibig.Text) + Val(txtPhil.Text) + Val(txtSSS.Text)
        Dim totalpay As Decimal = gross - deduct
        Dim daysperiod As Integer = txtdays.Text
        Dim id = 1
        btnTotalPay.Text = totalpay


        Try

            With command
                .Parameters.Clear()
                .CommandText = "prcInsertPay"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("i", id)
                .Parameters.AddWithValue("date", petsa)
                .Parameters.AddWithValue("gpay", gross)
                .Parameters.AddWithValue("ttldeduction", deduct)
                .Parameters.AddWithValue("ttlpay", totalpay)
                .Parameters.AddWithValue("days", daysperiod)
                .ExecuteNonQuery()



                MessageBox.Show("Success", "", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)

            End With
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)

        End Try



    End Sub
    Private Sub DisplayPayDetails()
        'Dim reader As MySqlDataReader
        dataAttendance = New DataTable()
        Dim id = 1
        'sqlAttendanceAdapter = New MySqlDataAdapter
        'command.Connection = conAttendanceSystem
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcDisplayPayDetails"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("id", id)
                .ExecuteReader()

                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)

                '   reader = command.ExecuteReader

                'If reader.HasRows Then
                'reader.Read()
                'txtperHour.Text = reader("rate_hour")


                'txtPerDay.Text = reader("rate_day")
                'txtMonth.Text = reader("rate_month")

                'txtPhil.Text = reader("philhealth")
                ' txtSSS.Text = reader("sss")
                '
                ' txtpagibig.Text = reader("pag-ibig")

                'Else

                MessageBox.Show("No record found...")



                '   End If



                sqlAttendanceAdapter.Dispose()
                dataAttendance.Dispose()
            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click

    End Sub


    Private Sub T()
        Call fncConnectDatabase()
        ' sqlAttendanceAdapter = New MySqlDataAdapter
        dataAttendance = New DataTable
        'Dim data As New DataSet
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcDisplayPayDetails"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("i", 1)

                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)

                '  If dataAttendance.Rows.Count > 0 Then


                'Dim A = CStr(dataAttendance.Rows().Item("id").ToString)
                'Label14.Text = dataAttendance.Rows().Item("id").ToString

                ' txtperHour.Text = dataAttendance.Rows().Item("rate_hour").ToString
                'txtPerDay.Text = dataAttendance.Rows().Item("rate_day").ToString
                'txtMonth.Text = dataAttendance.Rows().Item("rate_month").ToString
                'txtPhil.Text = dataAttendance.Rows().Item("philhealth").ToString
                'txtSSS.Text = dataAttendance.Rows().Item("sss").ToString
                'txtpagibig.Text = dataAttendance.Rows().Item("pagibig").ToString                Else
                'MessageBox.Show("Error")
                ' End If
                If dataAttendance.Rows.Count > 0 Then
                    DataGridView1.RowCount = dataAttendance.Rows.Count
                    row = 0
                    While Not dataAttendance.Rows.Count - 1 < row
                        With DataGridView1

                            .Rows(row).Cells(0).Value = dataAttendance.Rows(row).Item("emp_id").ToString
                            .Rows(row).Cells(1).Value = dataAttendance.Rows(row).Item("rate_hour").ToString
                            .Rows(row).Cells(2).Value = dataAttendance.Rows(row).Item("rate_day").ToString
                            .Rows(row).Cells(3).Value = dataAttendance.Rows(row).Item("rate_month").ToString
                            .Rows(row).Cells(4).Value = dataAttendance.Rows(row).Item("philhealth").ToString
                            .Rows(row).Cells(5).Value = dataAttendance.Rows(row).Item("sss").ToString
                            .Rows(row).Cells(6).Value = dataAttendance.Rows(row).Item("pagibig").ToString

                            'Label13.Text = DataGridView1.Rows(0).Cells(0).Value
                            txtperHour.Text = DataGridView1.Rows(0).Cells(1).Value
                            txtPerDay.Text = DataGridView1.Rows(0).Cells(2).Value
                            txtMonth.Text = DataGridView1.Rows(0).Cells(3).Value
                            txtPhil.Text = DataGridView1.Rows(0).Cells(4).Value
                            txtSSS.Text = DataGridView1.Rows(0).Cells(5).Value
                            txtpagibig.Text = DataGridView1.Rows(0).Cells(6).Value

                        End With
                    End While
                Else
                    MessageBox.Show("Error")




                End If



                sqlAttendanceAdapter.Dispose()
                dataAttendance.Dispose()
                ' data.Dispose()

            End With
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim gross = Val(txtPerDay.Text) * Val(txtdays.Text)
        Dim deduct = Val(txtCAd.Text) + Val(txtpagibig.Text) + Val(txtPhil.Text) + Val(txtSSS.Text)
        Dim totalpay = gross - deduct
        Dim daysperiod = txtdays

        Dim hourly = Val(txtPerDay.Text) / 8
        txtperHour.Text = hourly
        txtMonth.Text = Val(txtPerDay.Text) * 20

        btnTotalPay.Text = totalpay

    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        AddPay()



    End Sub
End Class