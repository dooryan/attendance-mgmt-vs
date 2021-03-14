Imports MySql.Data.MySqlClient

Public Class AttendanceRecords

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AttendanceRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
        prcDisplayTimesheet()


    End Sub
    Private Sub prcAutoSearch(ByVal searchType As String, ByVal strValue As String)
        sqlAttendanceAdapter = New MySqlDataAdapter
        dataAttendance = New DataTable
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcSearchPayHistoryAuto"
                .Parameters.AddWithValue("@p_searchtype", searchType)

                .CommandType = CommandType.StoredProcedure
                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)

                If dataAttendance.Rows.Count > 0 Then
                    DataGridView1.RowCount = dataAttendance.Rows.Count
                    row = 0
                    While Not dataAttendance.Rows.Count - 1 < row
                        With DataGridView1

                            .Rows(row).Cells(0).Value = dataAttendance.Rows(row).Item("emp_id").ToString
                            .Rows(row).Cells(1).Value = dataAttendance.Rows(row).Item("date").ToString

                            .Rows(row).Cells(2).Value = dataAttendance.Rows(row).Item("gross_pay").ToString
                            .Rows(row).Cells(3).Value = dataAttendance.Rows(row).Item("total_deduction").ToString
                            .Rows(row).Cells(4).Value = dataAttendance.Rows(row).Item("total_pay").ToString
                            .Rows(row).Cells(5).Value = dataAttendance.Rows(row).Item("day_period").ToString

                        End With

                        row = row + 1
                    End While
                Else

                    DataGridView1.Rows.Clear()


                End If
                sqlAttendanceAdapter.Dispose()
                dataAttendance.Dispose()

            End With
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub

    Private Sub prcDisplayTimesheet()

        dataAttendance = New DataTable()

        sqlAttendanceAdapter = New MySqlDataAdapter
        command.Connection = conAttendanceSystem
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcDisplayAllPayHistory"
                .CommandType = CommandType.StoredProcedure
                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)


                If dataAttendance.Rows.Count > 0 Then
                    DataGridView1.RowCount = dataAttendance.Rows.Count

                    row = 0
                    While Not dataAttendance.Rows.Count - 1 < row
                        With DataGridView1
                            ' .Rows(row).Cells(0).Value = dataAttendance.Rows(row).Item("id").ToString
                            .Rows(row).Cells(0).Value = dataAttendance.Rows(row).Item("emp_id").ToString
                            .Rows(row).Cells(1).Value = dataAttendance.Rows(row).Item("date").ToString

                            .Rows(row).Cells(2).Value = dataAttendance.Rows(row).Item("gross_pay").ToString
                            .Rows(row).Cells(3).Value = dataAttendance.Rows(row).Item("total_deduction").ToString
                            .Rows(row).Cells(4).Value = dataAttendance.Rows(row).Item("total_pay").ToString
                            .Rows(row).Cells(5).Value = dataAttendance.Rows(row).Item("day_period").ToString



                        End With
                        row = row + 1
                    End While
                Else




                End If
                sqlAttendanceAdapter.Dispose()
                dataAttendance.Dispose()
            End With
        Catch ex As Exception

        End Try
        Me.Refresh()
    End Sub


    Private Sub prcDisplayByAutoSearch(ByVal strValue As String)
        sqlAttendanceAdapter = New MySqlDataAdapter
        dataAttendance = New DataTable
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcSearchPayHistoryAuto"
                '.Parameters.AddWithValue("@p_searchtype", searchType)
                .Parameters.AddWithValue("p_value", strValue)
                .CommandType = CommandType.StoredProcedure
                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)

                If dataAttendance.Rows.Count > 0 Then
                    DataGridView1.RowCount = dataAttendance.Rows.Count
                    row = 0
                    While Not dataAttendance.Rows.Count - 1 < row
                        With DataGridView1

                            .Rows(row).Cells(0).Value = dataAttendance.Rows(row).Item("emp_id").ToString
                            .Rows(row).Cells(1).Value = dataAttendance.Rows(row).Item("date").ToString

                            .Rows(row).Cells(2).Value = dataAttendance.Rows(row).Item("gross_pay").ToString
                            .Rows(row).Cells(3).Value = dataAttendance.Rows(row).Item("total_deduction").ToString
                            .Rows(row).Cells(4).Value = dataAttendance.Rows(row).Item("total_pay").ToString
                            .Rows(row).Cells(5).Value = dataAttendance.Rows(row).Item("day_period").ToString

                        End With

                        row = row + 1
                    End While
                Else

                    DataGridView1.Rows.Clear()


                End If
                sqlAttendanceAdapter.Dispose()
                dataAttendance.Dispose()

            End With
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        prcDisplayByAutoSearch(TextBox1.Text)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Dispose()

    End Sub
End Class