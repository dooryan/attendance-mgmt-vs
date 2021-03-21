Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class payroll
    Dim totalHolidayHours = 0
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
        Dim mes = MessageBox.Show("Confirm PAY?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If mes = vbYes Then
            Dim petsa = Date.Now.ToString("yyyy/MM/dd")
            Dim gross As Decimal = Val(txtttlpay.Text)
            Dim deduct As Decimal = Val(txtTtlDeductions.Text)
            Dim totalpay As Decimal = Val(txtTotalPay.Text)
            Dim hourstotal As Integer = txtHours.Text
            Dim id = ComboBox1.Text

            'btnTotalPay.Text = totalpay


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
                    .Parameters.AddWithValue("hours", hourstotal)
                    .ExecuteNonQuery()


                    MessageBox.Show("Success", "Information", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)


                End With

            Catch ex As Exception
                MessageBox.Show("" & ex.Message)

            End Try
        Else



        End If







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



                'txtGrosspay.Text = Val(txtHours.Text) * CDec(DA(0)(1))
                txtHourlyRate.Text = DA(0)(1)
                txtPhil.Text = (CDec(DA(0)(4)) / 2) / 2
                txtSSS.Text = CDec(DA(0)(5)) / 2
                txtpagibig.Text = CDec(DA(0)(6)) / 2
                txtTtlDeductions.Text = Val(txtPhil.Text) + Val(txtSSS.Text) + Val(txtpagibig.Text)

                txtMonthly.Text = Val(((Val(txtHourlyRate.Text) * 48) * 52) / 12)
                txtBasicRate.Text = Val(txtMonthly.Text) / 2
                txtOTPay.Text = (Val(txtOvertime.Text) * Val(txtHourlyRate.Text)) * 1.25
                txtHoliday.Text = (totalHolidayHours * Val(txtHourlyRate.Text)) * 2
                txtttlpay.Text = (((Val(txtHours.Text)) * CDec(DA(0)(1)))) + Val(txtOTPay.Text) + Val(txtHoliday.Text)
                txtTotalPay.Text = Val(txtttlpay.Text) - Val(txtTtlDeductions.Text)
                txtHolidayHous.Text = totalHolidayHours


            End Using
        End Using

    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        getDaysCount()
        DisplayPayDetails()
        DisplayPayHistory()

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

                txtName.Text = DA(0)(0) & ", " & DA(0)(1)

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
        Dim dt = New DataSet
        'Dim cmd = New MySqlCommand

        ' Dim LogQuery As String = "SELECT USERNAME, PASSWORD, USER_TYPE FROM tbl_user WHERE USERNAME=@USERNAME AND PASSWORD=@PASSWORD "
        Using con As MySqlConnection = New MySqlConnection("server=localhost;user id=root;password=esperanza;database=db_attendance")
            Using cmd As MySqlCommand = New MySqlCommand("", con)

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
                Dim counter = 0
                Dim c = 0
                Dim x As Integer = 0
                Dim totalHours As Integer = 0
                Dim countOT As Integer = 0
                Dim countHoliday As Integer = 0
                'For i As Integer = 0 To DA.Rows.Count

                'x = CInt(DA(i)(6))
                'totalHours = totalHours + x
                'i = i + 1
                'Next
                Dim holidaydates() As String = {"2021/01/01", "2021/02/12", "2021/04/01",
                                                "2021/04/02", "2021/04/09", "2021/05/01",
                                                "2021/01/01", "2021/01/01", "2021/05/13",
                                                "2021/06/12", "2021/07/19", "2021/08/30",
                                                "2021/11/30", "2021/12/08", "2021/12/25",
                                                "2021/12/30"}

                While counter < DA.Rows.Count
                    x = CInt(DA(counter)(6))
                    totalHours = totalHours + x - 1


                    If (CInt(DA(counter)(6)) > 9) Then
                        countOT = countOT + (CInt(DA(counter)(6)) - 1) - 8
                        totalHours = totalHours - countOT
                    End If

                    counter = counter + 1
                End While

                While c < DA.Rows.Count

                    If (DA(c)(3) = holidaydates(0) Or DA(c)(3) = holidaydates(1) Or DA(c)(3) = holidaydates(2) Or
                             DA(c)(3) = holidaydates(3) Or DA(c)(3) = holidaydates(4) Or DA(c)(3) = holidaydates(5) Or
                              DA(c)(3) = holidaydates(6) Or DA(c)(3) = holidaydates(7) Or DA(c)(3) = holidaydates(8) Or
                              DA(c)(3) = holidaydates(9) Or DA(c)(3) = holidaydates(10) Or DA(c)(3) = holidaydates(11) Or
                              DA(c)(3) = holidaydates(12) Or DA(c)(3) = holidaydates(13) Or DA(c)(3) = holidaydates(14) Or
                              DA(c)(3) = holidaydates(15)) Then
                        x = CInt(DA(c)(6))
                        countHoliday = countHoliday + x - 1
                        totalHours = totalHours - countHoliday

                    End If
                    c = c + 1
                End While
                totalHolidayHours = countHoliday

                'x = x + Convert.ToInt32(DA(i)(6))

                If DA IsNot Nothing AndAlso DA.Rows.Count > 0 Then
                    'some code
                    'txtHours.Text = DA.Rows.Count.ToString

                    txtHours.Text = totalHours
                    txtOvertime.Text = countOT
                    txtHoliday.Text = countHoliday
                Else
                    'some code
                    txtHours.Text = "0"
                    txtOvertime.Text = "0"
                End If


                'count = dataAttendance.Rows.Count


            End Using
        End Using

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'Dim gross = Val(txtperHour.Text) * Val(txtHours.Text)
        'Dim deduct = Val(txtCAd.Text) + Val(txtpagibig.Text) + Val(txtPhil.Text) + Val(txtSSS.Text)
        ' Dim totalpay = gross - deduct
        'Dim daysperiod = txtHours

        'Dim hourly = Val(txtPerDay.Text) / 8
        'txtperHour.Text = hourly
        'txtMonth.Text = Val(txtPerDay.Text) * 20

        'btnTotalPay.Text = totalpay

    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        AddPay()
        DisplayPayHistory()
        Dim mes = MessageBox.Show("", "Generate Payslip?", MessageBoxButtons.YesNo)

        If (mes = vbYes) Then
            Dim dt As New DataTable
            With dt
                .Columns.Add("ID")
                .Columns.Add("Name")
                .Columns.Add("Overtime")
                .Columns.Add("Holiday")
                .Columns.Add("TotalSalary")
                .Columns.Add("Philhealth")
                .Columns.Add("Pagibig")
                .Columns.Add("SSS")
                .Columns.Add("TotalDeductions")
                .Columns.Add("NetPay")
            End With

            With dt
                Dim R As DataRow = dt.NewRow
                R("ID") = ComboBox1.Text
                R("Name") = txtName.Text
                R("Overtime") = txtOTPay.Text
                R("Holiday") = txtHoliday.Text
                R("TotalSalary") = txtttlpay.Text
                R("Philhealth") = txtPhil.Text
                R("SSS") = txtSSS.Text
                R("Pagibig") = txtpagibig.Text
                R("TotalDeductions") = txtTtlDeductions.Text
                R("NetPay") = txtTotalPay.Text

                dt.Rows.Add(R)
                '.Rows.Add(dgr.Cells(0).Value
                'dgr.Cells(1).Value, dgr.Cells(2).Value, dgr.Cells(3).Value, dgr.Cells(4).Value, dgr.Cells(5).Value, dgr.Cells(6).Value)

            End With

            Dim report1 As ReportDocument
            report1 = New Payslip
            report1.SetDataSource(dt)
            Report.CrystalReportViewer1.ReportSource = report1




            Report.ShowDialog()
            Report.Dispose()
        End If

    End Sub
    Private Sub DisplayPayHistory()
        Dim DA = New DataTable()
        Dim sqlAdapter = New MySqlDataAdapter
        Dim dt = New DataSet

        Using con As MySqlConnection = New MySqlConnection("server=localhost;user id=root;password=esperanza;database=db_attendance")
            Using cmd As MySqlCommand = New MySqlCommand("", con)

                cmd.CommandText = "prcDisplayPayHistorybyEmp"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("e_ID", ComboBox1.Text)

                sqlAdapter.SelectCommand = cmd
                DA.Clear()
                sqlAdapter.Fill(DA)

                If DA.Rows.Count > 0 Then
                    DataGridView1.RowCount = DA.Rows.Count
                    Dim name = DA(0)(5) & "," & DA(0)(6)
                    row = 0
                    While Not DA.Rows.Count - 1 < row
                        With DataGridView1
                            .Rows(row).Cells(0).Value = name
                            .Rows(row).Cells(1).Value = DA.Rows(row).Item("date").ToString
                            .Rows(row).Cells(2).Value = DA.Rows(row).Item("total_hours").ToString
                            .Rows(row).Cells(3).Value = DA.Rows(row).Item("gross_pay").ToString
                            .Rows(row).Cells(4).Value = DA.Rows(row).Item("total_deduction").ToString
                            .Rows(row).Cells(5).Value = DA.Rows(row).Item("total_pay").ToString


                        End With
                        row = row + 1
                    End While
                Else
                    MessageBox.Show("No record found...")



                End If



            End Using
        End Using
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class