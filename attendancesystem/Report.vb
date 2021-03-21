Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine



Public Class Report
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load


    End Sub

    Public Class report

    End Class

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        checkDatabaseConnection()




        Dim date1 As String = "2021/03/20"
        Dim date2 As String = "2021/03/20"

        Dim myReport As New ReportDocument
        Dim myData As New DataSet
        Dim connn As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter

        'connn.ConnectionString =
        '"SERVER=" & "localhost" & ";" _
        '& "DATABASE=" & "db_attendance" & ";" _
        ' & "USERNAME=" & "root" & ";" _
        '& "Password=" & "esperanza" & ""

        Try
            'Dim report As New CrystalReport1
            'report.Load()

            With command
                .Parameters.Clear()
                .CommandText = "reportDisplayPayHistory"
                .CommandType = CommandType.StoredProcedure
                '.Parameters.AddWithValue("d", date1)

                .Parameters.Clear()


                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)
            End With

            ' report.SetDataSource(dataAttendance)




            'CrystalReportViewer1.ReportSource = report
            CrystalReportViewer1.RefreshReport()
            CrystalReportViewer1.Show()

        Catch ex As Exception

        End Try




    End Sub
    Private Sub generateXML()

    End Sub


End Class