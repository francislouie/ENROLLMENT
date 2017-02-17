Imports MySql.Data.MySqlClient

Module exec_connector
    Public exec_conn As New MySqlConnection
    Public exec_command As New MySqlCommand
    Public exec_combuilder As New MySqlCommandBuilder
    Public exec_dreader As MySqlDataReader
    Public exec_dadapter As New MySqlDataAdapter
    Public Sub ConnectDatabase()
        Try
            Console.WriteLine("Connecting...")
            If exec_conn.State = ConnectionState.Closed Then
                exec_conn.ConnectionString = "server=localhost;" _
                                       & "userid=root;" _
                                       & "password=root;" _
                                       & "database=enrollment;"
                'exec_conn.Open()
                Console.WriteLine("Connection Succesful!")
            End If
        Catch myerror As Exception
            Console.WriteLine("Connection Error")
            End
        End Try
    End Sub
    Public Sub DisconnectDatabase()
        Try
            exec_conn.Close()
        Catch myerror As MySql.Data.MySqlClient.MySqlException
        End Try
    End Sub
End Module