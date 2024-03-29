﻿Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class AttendanceRecords

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AttendanceRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
        prcDisplayTimesheet()

        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "yyyy/MM/dd"


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
                            .Rows(row).Cells(5).Value = dataAttendance.Rows(row).Item("total_hours").ToString

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
                    Dim name = dataAttendance(0)(5) & "," & dataAttendance(0)(6)
                    row = 0
                    While Not dataAttendance.Rows.Count - 1 < row
                        With DataGridView1
                            ' .Rows(row).Cells(0).Value = dataAttendance.Rows(row).Item("id").ToString
                            .Rows(row).Cells(0).Value = dataAttendance.Rows(row).Item("id").ToString
                            .Rows(row).Cells(1).Value = dataAttendance(row)(5) & ", " & dataAttendance(row)(6)
                            .Rows(row).Cells(2).Value = dataAttendance.Rows(row).Item("date").ToString

                            .Rows(row).Cells(3).Value = dataAttendance.Rows(row).Item("gross_pay").ToString
                            .Rows(row).Cells(4).Value = dataAttendance.Rows(row).Item("total_deduction").ToString
                            .Rows(row).Cells(5).Value = dataAttendance.Rows(row).Item("total_pay").ToString
                            .Rows(row).Cells(6).Value = dataAttendance.Rows(row).Item("total_hours").ToString



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
                            .Rows(row).Cells(5).Value = dataAttendance.Rows(row).Item("total_hours").ToString

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

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Dispose()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        checkDatabaseConnection()



        Dim date1 As String = DateTimePicker1.Value.ToString("yyyy/MM/dd")
        Dim date2 As String = DateTimePicker2.Value.ToString("yyyy/MM/dd")

        dataAttendance = New DataTable()

        sqlAttendanceAdapter = New MySqlDataAdapter
        command.Connection = conAttendanceSystem
        Try
            With command
                .Parameters.Clear()
                If txtID.Text = "" Then
                    .CommandText = "reportDisplayPayHistorybyDate"
                    .Parameters.AddWithValue("d1", date1)
                    .Parameters.AddWithValue("d2", date2)

                Else
                    .CommandText = "reportDisplayPayHistorybyDateAndID"
                    .Parameters.AddWithValue("id", txtID.Text)
                    .Parameters.AddWithValue("d1", date1)
                    .Parameters.AddWithValue("d2", date2)
                End If

                .CommandType = CommandType.StoredProcedure
                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)


                If dataAttendance.Rows.Count > 0 Then
                    DataGridView1.RowCount = dataAttendance.Rows.Count
                    Dim name = dataAttendance(0)(5) & "," & dataAttendance(0)(6)
                    row = 0
                    While Not dataAttendance.Rows.Count - 1 < row
                        With DataGridView1
                            ' .Rows(row).Cells(0).Value = dataAttendance.Rows(row).Item("id").ToString
                            .Rows(row).Cells(0).Value = dataAttendance.Rows(row).Item("id").ToString
                            .Rows(row).Cells(1).Value = dataAttendance(row)(5) & ", " & dataAttendance(row)(6)
                            .Rows(row).Cells(2).Value = dataAttendance.Rows(row).Item("date").ToString

                            .Rows(row).Cells(3).Value = dataAttendance.Rows(row).Item("gross_pay").ToString
                            .Rows(row).Cells(4).Value = dataAttendance.Rows(row).Item("total_deduction").ToString
                            .Rows(row).Cells(5).Value = dataAttendance.Rows(row).Item("total_pay").ToString
                            .Rows(row).Cells(6).Value = dataAttendance.Rows(row).Item("total_hours").ToString



                        End With
                        row = row + 1
                    End While
                Else
                    MessageBox.Show("No data to show.")



                End If
                sqlAttendanceAdapter.Dispose()
                dataAttendance.Dispose()
            End With
        Catch ex As Exception

        End Try
        Me.Refresh()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim date1 As String = Date.Now.ToString("yyyy/MM/dd")
        Dim dt As New DataTable
        With dt
            .Columns.Add("EmployeeID")
            .Columns.Add("Name")
            .Columns.Add("Date")
            .Columns.Add("GrossPay")
            .Columns.Add("Deduction")
            .Columns.Add("TotalPay")
            .Columns.Add("WorkingDays")
        End With

        For Each dgr As DataGridViewRow In Me.DataGridView1.Rows
            dt.Rows.Add(dgr.Cells(0).Value, dgr.Cells(1).Value, dgr.Cells(2).Value, dgr.Cells(3).Value, dgr.Cells(4).Value, dgr.Cells(5).Value, dgr.Cells(6).Value)
        Next
        Dim report1 As ReportDocument
        report1 = New CrystalPayrollReport
        report1.SetDataSource(dt)
        Report.CrystalReportViewer1.ReportSource = report1

        Dim TxtDate1 As TextObject
        TxtDate1 = report1.ReportDefinition.ReportObjects("txtDate")
        TxtDate1.Text = date1

        Report.ShowDialog()
        Report.Dispose()
    End Sub
End Class