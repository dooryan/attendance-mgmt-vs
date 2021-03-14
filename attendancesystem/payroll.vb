Imports MySql.Data.MySqlClient
Public Class payroll
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub payroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()

        ComboBox1.Items.Clear()

        Try
            dataAttendance = New DataTable()

            sqlAttendanceAdapter = New MySqlDataAdapter
            command.Connection = conAttendanceSystem
            With command
                .Parameters.Clear()
                .CommandText = "prcDisplayEmployeeID"
                .CommandType = CommandType.StoredProcedure
                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)

                sqlAttendanceAdapter.Fill(dataAttendance)
                ComboBox1.DataSource = dataAttendance
                ComboBox1.DisplayMember = "id"
                ComboBox1.ValueMember = "id"
            End With




            'sqlAttendanceAdapter.Dispose()
            'dataAttendance.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub
    Private Sub AddPay()



        Dim petsa = Date.Now.ToString("yyyy/MM/dd")
        Dim gross As Decimal = Val(txtPerDay.Text) * Val(txtdays.Text)
        Dim deduct As Decimal = Val(txtCAd.Text) + Val(txtpagibig.Text) + Val(txtPhil.Text) + Val(txtSSS.Text)
        Dim totalpay As Decimal = gross - deduct
        Dim daysperiod As Integer = txtdays.Text
        Dim id = ComboBox1.Text
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

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)

        End Try



    End Sub
    Private Sub DisplayPayDetails()
        Dim DA = New DataTable()
        Dim sqlAdapter = New MySqlDataAdapter
        Dim v = ComboBox1.SelectedItem
        'Dim LogQuery As String = "SELECT USERNAME, PASSWORD, USER_TYPE FROM tbl_user WHERE USERNAME=@USERNAME AND PASSWORD=@PASSWORD "
        Using con As MySqlConnection = New MySqlConnection("server=localhost;user id=root;password=esperanza;database=db_attendance")
            Using cmd As MySqlCommand = New MySqlCommand("", con)

                cmd.CommandText = "prcDisplayPayDetails"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("i", ComboBox1.Text)
                sqlAdapter.SelectCommand = cmd
                DA.Clear()
                sqlAdapter.Fill(DA)


                txtperHour.Text = DA(0)(1)
                txtPerDay.Text = DA(0)(2)
                txtMonth.Text = Val(txtPerDay.Text) * Val(txtdays.Text)

                txtPhil.Text = DA(0)(4)
                txtSSS.Text = DA(0)(5)
                txtpagibig.Text = DA(0)(6)

            End Using
        End Using

    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        getDaysCount()
        DisplayPayDetails()

        Dim DA = New DataTable()
        Dim sqlAdapter = New MySqlDataAdapter
        Dim v = ComboBox1.SelectedItem
        'Dim LogQuery As String = "SELECT USERNAME, PASSWORD, USER_TYPE FROM tbl_user WHERE USERNAME=@USERNAME AND PASSWORD=@PASSWORD "
        Using con As MySqlConnection = New MySqlConnection("server=localhost;user id=root;password=esperanza;database=db_attendance")
            Using cmd As MySqlCommand = New MySqlCommand("", con)

                cmd.CommandText = "prcSelectEmpName"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("aydi", ComboBox1.Text)
                sqlAdapter.SelectCommand = cmd
                DA.Clear()
                sqlAdapter.Fill(DA)

                txtName.Text = DA(0)(0)

            End Using
        End Using

    End Sub
    Private Sub getDaysCount()

        Dim date1 As String = DateTimePicker1.Value.ToString("yyyy/MM/dd")
        Dim date2 As String = DateTimePicker2.Value.ToString("yyyy/MM/dd")

        'Dim count As Integer
        'txtdays.Text = count

        Dim DA = New DataTable()
        Dim sqlAdapter = New MySqlDataAdapter
        'Dim cmd = New MySqlCommand

        Dim LogQuery As String = "SELECT USERNAME, PASSWORD, USER_TYPE FROM tbl_user WHERE USERNAME=@USERNAME AND PASSWORD=@PASSWORD "
        Using con As MySqlConnection = New MySqlConnection("server=localhost;user id=root;password=esperanza;database=db_attendance")
            Using cmd As MySqlCommand = New MySqlCommand(LogQuery, con)

                cmd.CommandText = "prcFilterSummaryHours"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("date1", date1)
                cmd.Parameters.AddWithValue("date2", date2)
                cmd.Parameters.AddWithValue("i", ComboBox1.Text)

                sqlAdapter.SelectCommand = cmd
                DA.Clear()
                sqlAdapter.Fill(DA)



                row = 0
                If DA IsNot Nothing AndAlso DA.Rows.Count > 0 Then
                    'some code
                    txtdays.Text = DA.Rows.Count.ToString
                Else
                    'some code
                    txtdays.Text = "0"
                End If


                'count = dataAttendance.Rows.Count


            End Using
        End Using

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim gross = Val(txtPerDay.Text) * Val(txtdays.Text)
        Dim deduct = Val(txtCAd.Text) + Val(txtpagibig.Text) + Val(txtPhil.Text) + Val(txtSSS.Text)
        Dim totalpay = gross - deduct
        Dim daysperiod = txtdays

        Dim hourly = Val(txtPerDay.Text) / 8
        'txtperHour.Text = hourly
        'txtMonth.Text = Val(txtPerDay.Text) * 20

        btnTotalPay.Text = totalpay

    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        AddPay()



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class