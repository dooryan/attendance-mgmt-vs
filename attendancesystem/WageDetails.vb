Imports MySql.Data.MySqlClient

Public Class WageDetails
    Private Sub WageDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged


    End Sub

    Private Sub EmployeeInfo()
        Dim DA = New DataTable()
        Dim sqlAdapter = New MySqlDataAdapter
        'Dim v = ComboBox1.SelectedItem
        'Dim LogQuery As String = "SELECT USERNAME, PASSWORD, USER_TYPE FROM tbl_user WHERE USERNAME=@USERNAME AND PASSWORD=@PASSWORD "
        Using con As MySqlConnection = New MySqlConnection("server=localhost;user id=root;password=esperanza;database=db_attendance")
            Using cmd As MySqlCommand = New MySqlCommand("", con)

                cmd.CommandText = "prcDisplayPayDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("i", txtID.Text)
                sqlAdapter.SelectCommand = cmd
                DA.Clear()
                sqlAdapter.Fill(DA)

                If DA.Rows.Count > 0 Then
                    txtHourlyRate.Text = DA(0)(1)
                    txtGrossWage.Text = 48 * Val(txtHourlyRate.Text) * 2
                    txtName.Text = DA(0)(8)
                    txtDept.Text = DA(0)(10)
                    txtJobStat.Text = DA(0)(7)
                    txtphilhealth.Text = CDec(DA(0)(4))
                    txtsss.Text = CDec(DA(0)(5))
                    txtpagibig.Text = CDec(DA(0)(6))
                    txtDept.Text = DA(0)(11)
                    btnSave.Enabled = False
                    btnUpdate.Enabled = True
                    'txtBasic.Text = DA(0)(11)
                Else
                    Dim m = MessageBox.Show("No record found. Add record?", "", MessageBoxButtons.OKCancel)
                    If m = vbOK Then
                        'TextBox clear all
                        txtName.Clear()
                        txtDept.Clear()
                        txtDept.Clear()
                        txtJobStat.Clear()
                        txtphilhealth.Clear()
                        txtsss.Clear()
                        txtphilhealth.Clear()
                        txtpagibig.Clear()
                        txtHourlyRate.Clear()
                        txtGrossWage.Clear()

                        btnUpdate.Enabled = False
                        btnSave.Enabled = True
                    End If

                End If

            End Using
            con.Dispose()
        End Using

        'Multiply your monthly premium by 12 And 
        'you have total annual contributions Of Php 10, 92.06.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EmployeeInfo()
    End Sub

    Private Sub InsertPayDetails(ByVal flag)

        Dim rate_day = txtHourlyRate.Text * 8
        Dim rate_month = ((Val(txtHourlyRate.Text) * 48) * 52) / 12

        Try
            With command

                If (flag = "insert") Then
                    .CommandText = "prcInsertPayDetails"

                    .Parameters.Clear()
                    .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("id", txtID.Text)
                        .Parameters.AddWithValue("ratehour", txtHourlyRate.Text)
                        .Parameters.AddWithValue("rateday", rate_day)
                        .Parameters.AddWithValue("ratemonth", rate_month)
                        .Parameters.AddWithValue("phealth", txtphilhealth.Text)
                        .Parameters.AddWithValue("ss", txtsss.Text)
                        .Parameters.AddWithValue("pibig", txtpagibig.Text)
                        .Parameters.AddWithValue("jobstat", txtJobStat.Text)
                        .ExecuteNonQuery()

                        MessageBox.Show("Successfully added.", "Information", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information)


                ElseIf (flag = "update")


                    .Parameters.Clear()
                    .CommandText = "prcUpdatePayDetails"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("id", txtID.Text)
                    .Parameters.AddWithValue("hr", txtHourlyRate.Text)
                    .Parameters.AddWithValue("rd", rate_day)
                    .Parameters.AddWithValue("rm", rate_month)
                    .Parameters.AddWithValue("ph", txtphilhealth.Text)
                    .Parameters.AddWithValue("sss", txtsss.Text)
                    .Parameters.AddWithValue("pibig", txtpagibig.Text)
                    .Parameters.AddWithValue("jobstat", txtJobStat.Text)
                    .ExecuteNonQuery()

                    MessageBox.Show("Successfully updated.", "Information", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information)


                    'End Using
                    'End Using

                End If

            End With

            'End Using
            'End Using
        Catch ex As Exception

        End Try


    End Sub

    Private Sub txtDailyRate_TextChanged(sender As Object, e As EventArgs) Handles txtHourlyRate.TextChanged
        If ((Val(txtHourlyRate.Text) * 48) * 52) / 12 <= 10000 Then
            txtphilhealth.Text = 350 / 2
        Else
            txtphilhealth.Text = (((txtHourlyRate.Text * 8) * 22) * 0.035) / 2
        End If


        txtsss.Text = (((Val(txtHourlyRate.Text) * 48) * 52) / 12) * 0.0363
        txtpagibig.Text = (((Val(txtHourlyRate.Text) * 48) * 52) / 12) * 0.02
        txtGrossWage.Text = 48 * Val(txtHourlyRate.Text) * 2

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        InsertPayDetails("insert")

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        InsertPayDetails("update")
        'Dim rate_day = txtHourlyRate.Text * 8
        'Dim rate_month = ((Val(txtHourlyRate.Text) * 48) * 52) / 12

        'command.Connection = conAttendanceSystem




    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class