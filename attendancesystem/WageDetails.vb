Imports MySql.Data.MySqlClient

Public Class WageDetails
    Private Sub WageDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
                    txtName.Text = DA(0)(8)
                    txtDept.Text = DA(0)(10)
                    txtJobStat.Text = DA(0)(7)
                    txtphilhealth.Text = CDec(DA(0)(4))
                    txtsss.Text = CDec(DA(0)(5))
                    txtpagibig.Text = CDec(DA(0)(6))

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
                        txtpagibig.Clear()
                        'txtBasic.Clear()
                        btnUpdate.Enabled = False
                        btnSave.Enabled = True
                    End If

                End If
            End Using
        End Using

        'Multiply your monthly premium by 12 And 
        'you have total annual contributions Of Php 10, 92.06.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EmployeeInfo()
    End Sub

    Private Sub InsertPayDetails()

        Dim rate_hour = txtDailyRate.Text / 8
        Dim rate_month = txtDailyRate.Text * 22

        Using con As MySqlConnection = New MySqlConnection("server=localhost;user id=root;password=esperanza;database=db_attendance")
            Using c As MySqlCommand = New MySqlCommand("", con)

                c.CommandText = "prcInsertPayDetails"
                c.CommandType = CommandType.StoredProcedure
                c.Parameters.Clear()
                c.Parameters.AddWithValue("id", txtID.Text)
                c.Parameters.AddWithValue("ratehour", rate_hour)
                c.Parameters.AddWithValue("rateday", txtDailyRate.Text)
                c.Parameters.AddWithValue("ratemonth", rate_month)
                c.Parameters.AddWithValue("phealth", txtphilhealth.Text)
                c.Parameters.AddWithValue("ss", txtsss.Text)
                c.Parameters.AddWithValue("pibig", txtpagibig.Text)
                c.Parameters.AddWithValue("jobstat", txtJobStat.Text)

                c.ExecuteNonQuery()
                MessageBox.Show("Successfully updated Employee", "", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            End Using
        End Using
    End Sub

    Private Sub txtDailyRate_TextChanged(sender As Object, e As EventArgs) Handles txtDailyRate.TextChanged
        txtphilhealth.Text = ((txtDailyRate.Text * 22) * 0.035)
        txtsss.Text = ((txtDailyRate.Text * 22) * 0.0363)
        txtpagibig.Text = ((txtDailyRate.Text * 22) * 0.02)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        InsertPayDetails()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim rate_hour = txtDailyRate.Text / 8
        Dim rate_month = txtDailyRate.Text * 22

        Using connect As MySqlConnection = New MySqlConnection("server=localhost;user id=root;password=esperanza;database=db_attendance")
            Using command As MySqlCommand = New MySqlCommand("", connect)

                command.CommandText = "prcInsertPayDetails"
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Clear()
                command.Parameters.AddWithValue("id", txtID.Text)
                command.Parameters.AddWithValue("ratehour", rate_hour)
                command.Parameters.AddWithValue("rateday", txtDailyRate.Text)
                command.Parameters.AddWithValue("ratemonth", rate_month)
                command.Parameters.AddWithValue("phealth", txtphilhealth.Text)
                command.Parameters.AddWithValue("ss", txtsss.Text)
                command.Parameters.AddWithValue("pibig", txtpagibig.Text)
                command.Parameters.AddWithValue("jobstat", txtJobStat.Text)

                MessageBox.Show("Successfully added")
            End Using
        End Using
    End Sub
End Class