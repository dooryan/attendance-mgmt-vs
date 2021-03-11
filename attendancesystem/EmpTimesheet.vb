Imports MySql.Data.MySqlClient
Imports EXCEL = Microsoft.Office.Interop.Excel



Public Class EmpTimesheet

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        prcDisplayTimesheet()

    End Sub

    Private Sub prcDisplayTimesheet()

        dataAttendance = New DataTable()

        sqlAttendanceAdapter = New MySqlDataAdapter
        command.Connection = conAttendanceSystem
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcDisplayAllTimesheet"
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
                            .Rows(row).Cells(1).Value = dataAttendance.Rows(row).Item("f_name").ToString
                            .Rows(row).Cells(2).Value = dataAttendance.Rows(row).Item("l_name").ToString

                            .Rows(row).Cells(3).Value = dataAttendance.Rows(row).Item("tdate").ToString
                            .Rows(row).Cells(4).Value = dataAttendance.Rows(row).Item("ttime").ToString
                            .Rows(row).Cells(5).Value = dataAttendance.Rows(row).Item("status").ToString



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

    Private Sub EmpTimesheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        checkDatabaseConnection()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "yyyy/MM/dd"

        ComboBox1.Items.Clear()

        Try
            dataAttendance = New DataTable()

            sqlAttendanceAdapter = New MySqlDataAdapter
            command.Connection = conAttendanceSystem
            With command
                .Parameters.Clear()
                .CommandText = "prcDisplayEmployee"
                .CommandType = CommandType.StoredProcedure
                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)
            End With


            sqlAttendanceAdapter.Fill(dataAttendance)
            ComboBox1.DataSource = dataAttendance
            ComboBox1.DisplayMember = "emp_id"
            ComboBox1.ValueMember = "emp_id"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim date1 As String = DateTimePicker1.Value.ToString("yyyy/MM/dd")

        Dim date2 As String = DateTimePicker2.Value.ToString("yyyy/MM/dd")

        dataAttendance = New DataTable()
        sqlAttendanceAdapter = New MySqlDataAdapter
        command.Connection = conAttendanceSystem

        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcFilterTimesheet"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("date1", date1)
                .Parameters.AddWithValue("date2", date2)
                .Parameters.AddWithValue("id", ComboBox1.Text)
                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)
                If dataAttendance.Rows.Count > 0 Then
                    DataGridView1.RowCount = dataAttendance.Rows.Count

                    row = 0
                    While Not dataAttendance.Rows.Count - 1 < row
                        With DataGridView1
                            .Rows(row).Cells(0).Value = dataAttendance.Rows(row).Item("id").ToString
                            .Rows(row).Cells(1).Value = dataAttendance.Rows(row).Item("f_name").ToString
                            .Rows(row).Cells(2).Value = dataAttendance.Rows(row).Item("l_name").ToString

                            .Rows(row).Cells(3).Value = dataAttendance.Rows(row).Item("tdate").ToString
                            .Rows(row).Cells(4).Value = dataAttendance.Rows(row).Item("ttime").ToString
                            .Rows(row).Cells(5).Value = dataAttendance.Rows(row).Item("status").ToString



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


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim date1 As String = DateTimePicker1.Value.ToString("yyyy/MM/dd")
        Dim date2 As String = DateTimePicker2.Value.ToString("yyyy/MM/dd")

        dataAttendance = New DataTable()
        sqlAttendanceAdapter = New MySqlDataAdapter
        command.Connection = conAttendanceSystem
        Dim ds As New DataSet

        Dim i, j As Integer

        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")

        With command
            .Parameters.Clear()
            .CommandText = "prcFilterTimesheet"
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("date1", date1)
            .Parameters.AddWithValue("date2", date2)
            .Parameters.AddWithValue("id", ComboBox1.Text)

            sqlAttendanceAdapter.SelectCommand = command
            sqlAttendanceAdapter.Fill(ds)

            For i = 0 To ds.Tables(0).Rows.Count - 1
                For j = 0 To ds.Tables(0).Columns.Count - 1
                    xlWorkSheet.Cells(i + 1, j + 1) =
                    ds.Tables(0).Rows(i).Item(j)
                Next
            Next

        End With



        Try
            Dim fbd As New FolderBrowserDialog

            If fbd.ShowDialog() = vbOK Then

                xlWorkSheet.SaveAs(fbd.SelectedPath & "\" & ComboBox1.SelectedValue & "AttendanceRecord.xlsx")
                xlWorkBook.Close()
                xlApp.Quit()

                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xlWorkSheet)

                MessageBox.Show("Succcessfully exported to Excel file!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

End Class