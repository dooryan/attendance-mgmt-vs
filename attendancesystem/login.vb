Public Class login
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If username.Text = "Admin" And password.Text = "Admin" Then
            Dim oForm As New adminDashboard
            oForm.Show()
            Me.Hide()

        Else
            Dim oForm As New attendance
            oForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub username_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged

    End Sub
End Class