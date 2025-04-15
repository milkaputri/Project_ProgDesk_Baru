Imports MySql.Data.MySqlClient

Module ModuleDB
    Public pengguna As String = "milka"
    Public ppassword As String = "inimilka123"
    Public myStrCon As MySqlConnectionStringBuilder = New MySqlConnectionStringBuilder()
    Public myConn As MySqlConnection
    Public myCommand As MySqlCommand
    Public myDataReader As MySqlDataReader
    Public myDataAdapter As MySqlDataAdapter
    'Public jns As String = String.Empty
    Public tbluser As String = "users" 'nama tabel user
    Public bts As Integer = 5
    Public Sub CreateConnection()
        myStrCon.UserID = "root"
        myStrCon.Server = "localhost"
        myStrCon.Password = ""
        myStrCon.Database = "project_akhir" 'sesuaikan nama databasenya
        myConn = New MySqlConnection(myStrCon.ToString)
    End Sub
End Module
