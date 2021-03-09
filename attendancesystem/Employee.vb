Imports MySql.Data.MySqlClient



Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()

        prcDisplayEmployee()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click






    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim oForm As New adminDashboard

        oForm.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim oForm As New addEmployee

        oForm.Show()

    End Sub

    Private Sub prcDisplayEmployee()

        dataAttendance = New DataTable()

        sqlAttendanceAdapter = New MySqlDataAdapter
        command.Connection = conAttendanceSystem
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcDisplayEmployees"
                .CommandType = CommandType.StoredProcedure
                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)


                If dataAttendance.Rows.Count > 0 Then
                    DataGridView1.RowCount = dataAttendance.Rows.Count

                    row = 0
                    While Not dataAttendance.Rows.Count - 1 < row
                        With DataGridView1
                            .Rows(row).Cells(0).Value = dataAttendance.Rows(row).Item("id").ToString
                            .Rows(row).Cells(1).Value = dataAttendance.Rows(row).Item("dept_id").ToString

                            .Rows(row).Cells(2).Value = dataAttendance.Rows(row).Item("f_name").ToString
                            .Rows(row).Cells(3).Value = dataAttendance.Rows(row).Item("l_name").ToString
                            .Rows(row).Cells(4).Value = dataAttendance.Rows(row).Item("address").ToString

                            .Rows(row).Cells(5).Value = dataAttendance.Rows(row).Item("birthdate").ToString
                            .Rows(row).Cells(6).Value = dataAttendance.Rows(row).Item("gender").ToString

                            .Rows(row).Cells(7).Value = dataAttendance.Rows(row).Item("date_hired").ToString
                            .Rows(row).Cells(8).Value = dataAttendance.Rows(row).Item("contactno").ToString


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



    Private Sub prcDisplayByAutoSearch(ByVal searchType As String, ByVal strValue As String)
        sqlAttendanceAdapter = New MySqlDataAdapter
        dataAttendance = New DataTable
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcSelAllEmployeeByAutoComplete"
                .Parameters.AddWithValue("@p_searchtype", searchType)
                .Parameters.AddWithValue("@p_value", strValue)
                .CommandType = CommandType.StoredProcedure
                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)

                If dataAttendance.Rows.Count > 0 Then
                    DataGridView1.RowCount = dataAttendance.Rows.Count
                    row = 0
                    While Not dataAttendance.Rows.Count - 1 < row
                        With DataGridView1
                            .Rows(row).Cells(0).Value = dataAttendance.Rows(row).Item("id").ToString
                            .Rows(row).Cells(1).Value = dataAttendance.Rows(row).Item("dept_id").ToString

                            .Rows(row).Cells(2).Value = dataAttendance.Rows(row).Item("f_name").ToString
                            .Rows(row).Cells(3).Value = dataAttendance.Rows(row).Item("l_name").ToString
                            .Rows(row).Cells(4).Value = dataAttendance.Rows(row).Item("address").ToString

                            .Rows(row).Cells(5).Value = dataAttendance.Rows(row).Item("birthdate").ToString
                            .Rows(row).Cells(6).Value = dataAttendance.Rows(row).Item("gender").ToString

                            .Rows(row).Cells(7).Value = dataAttendance.Rows(row).Item("date_hired").ToString
                            .Rows(row).Cells(8).Value = dataAttendance.Rows(row).Item("contactno").ToString

                        End With

                        row = row + 1
                    End While
                Else
                    MessageBox.Show("No Record Found...")
                    DataGridView1.Rows.Clear()


                End If
                sqlAttendanceAdapter.Dispose()
                dataAttendance.Dispose()

            End With
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim num As Integer

        Try
            num = MessageBox.Show("Delete data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If num = DialogResult.Yes Then
                With command
                    .Parameters.Clear()
                    .CommandText = "prcDeleteEmployee"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("emp_id", CInt(DataGridView1.CurrentRow.Cells(0).Value))
                    .ExecuteNonQuery()

                End With
            End If



        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcEditEmployee"
                .CommandType = CommandType.StoredProcedure

            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles textSearch.TextChanged
        prcDisplayByAutoSearch(ComboBox1.Text, textSearch.Text)
    End Sub
End Class
