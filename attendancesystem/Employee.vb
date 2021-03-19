Imports MySql.Data.MySqlClient



Public Class Form1
    Private id As Integer
    Shared Property flag As Boolean
    Shared Property F As Boolean


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
        prcDisplayEmployee()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Dim oForm As New adminDashboard

        oForm.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


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
                            .Rows(row).Cells(2).Value = dataAttendance.Rows(row).Item("name").ToString

                            .Rows(row).Cells(3).Value = dataAttendance.Rows(row).Item("f_name").ToString
                            .Rows(row).Cells(4).Value = dataAttendance.Rows(row).Item("l_name").ToString
                            .Rows(row).Cells(5).Value = dataAttendance.Rows(row).Item("address").ToString

                            .Rows(row).Cells(6).Value = dataAttendance.Rows(row).Item("birthdate").ToString
                            .Rows(row).Cells(7).Value = dataAttendance.Rows(row).Item("gender").ToString

                            .Rows(row).Cells(8).Value = dataAttendance.Rows(row).Item("date_hired").ToString
                            .Rows(row).Cells(9).Value = dataAttendance.Rows(row).Item("contactno").ToString


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
                            .Rows(row).Cells(2).Value = dataAttendance.Rows(row).Item("name").ToString

                            .Rows(row).Cells(3).Value = dataAttendance.Rows(row).Item("f_name").ToString
                            .Rows(row).Cells(4).Value = dataAttendance.Rows(row).Item("l_name").ToString
                            .Rows(row).Cells(5).Value = dataAttendance.Rows(row).Item("address").ToString

                            .Rows(row).Cells(6).Value = dataAttendance.Rows(row).Item("birthdate").ToString
                            .Rows(row).Cells(7).Value = dataAttendance.Rows(row).Item("gender").ToString

                            .Rows(row).Cells(8).Value = dataAttendance.Rows(row).Item("date_hired").ToString
                            .Rows(row).Cells(9).Value = dataAttendance.Rows(row).Item("contactno").ToString

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

    Private Sub Auto(ByVal strValue As String)
        sqlAttendanceAdapter = New MySqlDataAdapter
        dataAttendance = New DataTable
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcSearchEmpAuto"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_value", strValue)

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
                            .Rows(row).Cells(2).Value = dataAttendance.Rows(row).Item("name").ToString

                            .Rows(row).Cells(3).Value = dataAttendance.Rows(row).Item("f_name").ToString
                            .Rows(row).Cells(4).Value = dataAttendance.Rows(row).Item("l_name").ToString
                            .Rows(row).Cells(5).Value = dataAttendance.Rows(row).Item("address").ToString

                            .Rows(row).Cells(6).Value = dataAttendance.Rows(row).Item("birthdate").ToString
                            .Rows(row).Cells(7).Value = dataAttendance.Rows(row).Item("gender").ToString

                            .Rows(row).Cells(8).Value = dataAttendance.Rows(row).Item("date_hired").ToString
                            .Rows(row).Cells(9).Value = dataAttendance.Rows(row).Item("contactno").ToString

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



    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)


    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)



    End Sub


    Private Sub prcDisplayBySearchType(ByVal strSearch As String)
        sqlAttendanceAdapter = New MySqlDataAdapter
        dataAttendance = New DataTable
        Try
            With command
                .Parameters.Clear()

                If ComboBox1.Text = "EMPLOYEE ID" Then
                    .CommandText = "prcSelcEmpbyID"
                    .Parameters.AddWithValue("@empID", strSearch)

                ElseIf ComboBox1.Text = "EMPLOYEE NAME" Then
                    .CommandText = "prcSelcEmpbyName"
                    .Parameters.AddWithValue("empName", strSearch)


                Else
                    .CommandText = "prcDisplayEmployees"

                End If
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
                            .Rows(row).Cells(2).Value = dataAttendance.Rows(row).Item("name").ToString

                            .Rows(row).Cells(3).Value = dataAttendance.Rows(row).Item("f_name").ToString
                            .Rows(row).Cells(4).Value = dataAttendance.Rows(row).Item("l_name").ToString
                            .Rows(row).Cells(5).Value = dataAttendance.Rows(row).Item("address").ToString

                            .Rows(row).Cells(6).Value = dataAttendance.Rows(row).Item("birthdate").ToString
                            .Rows(row).Cells(7).Value = dataAttendance.Rows(row).Item("gender").ToString

                            .Rows(row).Cells(8).Value = dataAttendance.Rows(row).Item("date_hired").ToString
                            .Rows(row).Cells(9).Value = dataAttendance.Rows(row).Item("contactno").ToString

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


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        If chkAuto.Checked = True Then
            Auto(textSearch.Text)
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        If chkAuto.Checked = True Then
            btnSearch.Enabled = False
            textSearch.Clear()
            textSearch.Enabled = True
        Else
            btnSearch.Enabled = True



        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With addEmployee
            .ShowDialog()
            IntOperation = 0
            addEmployee.flag = False
        End With
        prcDisplayEmployee()


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        With addEmployee
            IntOperation = 1
            id = CInt(DataGridView1.CurrentRow.Cells(0).Value.ToString)

            .Label9.Text = DataGridView1.CurrentRow.Cells(0).Value

            .cmbDept.Text = DataGridView1.CurrentRow.Cells(2).Value
            .txtFname.Text = DataGridView1.CurrentRow.Cells(3).Value
            .txtLname.Text = DataGridView1.CurrentRow.Cells(4).Value
            .txtAddress.Text = DataGridView1.CurrentRow.Cells(5).Value
            .bdate.Value = DataGridView1.CurrentRow.Cells(6).Value

            .cmbGender.Text = DataGridView1.CurrentRow.Cells(7).Value
            .dhired.Value = DataGridView1.CurrentRow.Cells(8).Value


            .txtContact.Text = DataGridView1.CurrentRow.Cells(9).Value
            .ShowDialog()

        End With

        addEmployee.flag = True

        'Dim flag As New addEmployee
        'addEmployee.flag = True

        ' Dim F As New addEmployee
        'addEmployee.F = False




        Me.Refresh()
        prcDisplayEmployee()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
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
        prcDisplayEmployee()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnSearch.Click
        prcDisplayBySearchType(textSearch.Text)
    End Sub

    Private Sub textSearch_TextChanged(sender As Object, e As EventArgs)
        If chkAuto.Checked = True Then
            prcDisplayByAutoSearch(ComboBox1.Text, textSearch.Text)
        End If
    End Sub

    Private Sub chkAuto_CheckedChanged(sender As Object, e As EventArgs) Handles chkAuto.CheckedChanged
        If chkAuto.Checked = True Then
            btnSearch.Enabled = False
            textSearch.Clear()
            textSearch.Enabled = True
        Else
            btnSearch.Enabled = True

        End If
    End Sub

    Private Sub DataGridView1_CellContentClick_2(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub textSearch_TextChanged_1(sender As Object, e As EventArgs) Handles textSearch.TextChanged
        prcDisplayByAutoSearch(ComboBox1.Text, textSearch.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "EMPLOYEE ID" Then
            textSearch.Enabled = True
            textSearch.Clear()
        ElseIf ComboBox1.Text = "EMPLOYEE NAME" Then
            textSearch.Enabled = True
            textSearch.Clear()
        Else
            textSearch.Enabled = False
            textSearch.Clear()


        End If
    End Sub
End Class
