Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Public Class login
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        checkDatabaseConnection()

        Dim USERNAME As String = txtusername.Text
        Dim PASSWORD As String = txtpassword.Text

        If txtusername.Text = "" Or txtpassword.Text = "" Then
            MessageBox.Show("PLEASE YOUR CRENDENTIALS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            Dim LogQuery As String = "SELECT USERNAME, PASSWORD, USER_TYPE FROM tbl_user WHERE USERNAME=@USERNAME AND PASSWORD=@PASSWORD "
            Using con As MySqlConnection = New MySqlConnection("server=localhost;user id=root;password=esperanza;database=db_attendance")
                Using cmd As MySqlCommand = New MySqlCommand(LogQuery, con)

                    cmd.Parameters.AddWithValue("@USERNAME", USERNAME)
                    cmd.Parameters.AddWithValue("@PASSWORD", PASSWORD)

                    Dim da As New MySqlDataAdapter(cmd)
                    Dim myTable As New DataTable

                    con.Open()
                    da.Fill(myTable)
                    If myTable.Rows.Count > 0 Then
                        Dim message As String = "You have successfully login. Please click ok to proceed."
                        Dim caption As String = "Success"
                        Dim result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information)

                        If myTable.Rows(0)("USER_TYPE") = "admin" Then
                            Dim adminDashboard As New adminDashboard
                            adminDashboard.adminDashboard = txtusername.Text
                            adminDashboard.Show()

                        ElseIf myTable.Rows(0)("USER_TYPE") = "user" Then
                            Dim UserDashboard As New attendance
                            attendance.userDashboard = txtusername.Text
                            attendance.Show()


                        End If
                        txtusername.Clear()
                        txtpassword.Clear()
                    Else
                        MessageBox.Show("Username or password does not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    con.Close()
                End Using
            End Using
        End If








    End Sub

    Private Sub username_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class