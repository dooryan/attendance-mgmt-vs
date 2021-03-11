Public Class addEmployee
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        Dim date1 As String = dhired.Value.ToString("yyyy/MM/dd")

        Dim date2 As String = bdate.Value.ToString("yyyy/MM/dd")


        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcAddEmployee"
                .CommandType = CommandType.StoredProcedure

                .Parameters.AddWithValue("fname", txtFname.Text)
                .Parameters.AddWithValue("lname", txtLname.Text)
                .Parameters.AddWithValue("address", txtAddress.Text)
                .Parameters.AddWithValue("bdate", date2)
                .Parameters.AddWithValue("datehired", date1)
                .Parameters.AddWithValue("gender", cmbGender.Text)
                .Parameters.AddWithValue("dept", cmbDept.Text)
                .Parameters.AddWithValue("contact", txtContact.Text)
                .ExecuteNonQuery()
                MessageBox.Show("Successfully added Employee", "Add Employee", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)

            End With
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)

        End Try




        Me.Hide()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Hide()
    End Sub

    Private Sub addEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()

    End Sub
End Class