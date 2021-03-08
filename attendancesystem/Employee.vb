Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click








    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim connection As New MySqlConnection("datasource=localhost;username=root;password=esperanza")
        Dim dataAttendance As New DataTable()

        Dim sqlAttendanceAdapter As New MySqlDataAdapter

        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcDisplayEmployees"
                .CommandType = CommandType.StoredProcedure
                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)

            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim oForm As New adminDashboard

        oForm.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oForm As New addEmployee

        oForm.Show()

    End Sub
End Class
