

Public Class addUser


    Private Sub addUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dateNow As String = Date.Now.ToString("yyyy-MM-dd hh:mm:ss")
        Dim type As String
        If CheckBox1.Checked Then
            type = "admin"
        Else
            type = "user"
        End If
        Try

            With command
                .Parameters.Clear()
                .CommandText = "prcAddUser"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("id", txtID.Text)
                .Parameters.AddWithValue("uname", txtUname.Text)
                .Parameters.AddWithValue("pass", txtPass.Text)
                .Parameters.AddWithValue("d", dateNow)
                .Parameters.AddWithValue("utype", type)


                .ExecuteNonQuery()

                MessageBox.Show("Successfully added User", "", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)

            End With
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)

        End Try




        Me.Hide()
    End Sub

End Class