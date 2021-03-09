Imports MySql.Data.MySqlClient


Module modGlobalProcedure

    Public Function fncConnectDatabase() As Boolean
        Try
            strServerName = "localhost"
            strDatabaseName = "db_attendance"
            strUserID = "root"
            strUserPassword = "esperanza"

            If conAttendanceSystem.State = ConnectionState.Closed Then
                conAttendanceSystem = New MySqlConnection

                strConnection = "SERVER=" & strServerName & ";" _
                                   & "DATABASE=" & strDatabaseName & ";" _
                                   & "USERNAME=" & strUserID & ";" _
                                   & "Password=" & strUserPassword & ""

                conAttendanceSystem.ConnectionString = strConnection
                conAttendanceSystem.Open()
                command.Connection = conAttendanceSystem
                Return True
            Else
                conAttendanceSystem.Close()
                Return False


            End If

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)

        End Try
        Return False


    End Function

    Public Sub checkDatabaseConnection()
        Try
            If fncConnectDatabase() = True Then

            Else
                conAttendanceSystem.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub


End Module

