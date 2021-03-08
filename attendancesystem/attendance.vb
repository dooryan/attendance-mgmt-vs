Imports System.DateTime



Public Class attendance
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Label2.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim oForm As New login
        oForm.Show()
        Me.Hide()
    End Sub
End Class