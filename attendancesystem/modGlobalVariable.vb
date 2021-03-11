Imports MySql.Data.MySqlClient


Module modGlobalVariable
    Public strServerName As String
    Public strDatabaseName As String
    Public strUserID As String
    Public strUserPassword As String
    Public conAttendanceSystem As New MySqlConnection
    Public strConnection As String
    Public command As New MySqlCommand
    Public dataAttendance As New DataTable
    Public sqlAttendanceAdapter As New MySqlDataAdapter
    Public row As Integer
    Public IntOperation As Integer
End Module

