
Public Class adminDashboard

    Shared Property adminDashboard As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub adminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        date1.Text = Date.Now.ToString("dd MMM yyy")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim oForm As New Form1

        oForm.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim oForm As New login

        oForm.Show()
        Me.Hide()
    End Sub

    Private Sub date1_Click(sender As Object, e As EventArgs) Handles date1.Click

    End Sub
End Class