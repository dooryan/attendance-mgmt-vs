Imports System.DateTime



Public Class attendance
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Label2.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim oForm As New login
        oForm.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Date.Now.ToString("dd MMM yyy")
        Label3.Text = Date.Now.ToString("hh:mm:ss")

    End Sub
End Class