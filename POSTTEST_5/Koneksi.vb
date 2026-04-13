
Public Module Koneksi
    Imports MySql.Data.MySqlClient
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public adapter As MySqlDataAdapter
    Public ds As DataSet

    Public Sub BukaKoneksi()
        Dim str As String = "server=localhost;user id=root;password=;database=db_akuarium"
        Try
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then conn.Open()
        Catch ex As Exception
            MsgBox("Koneksi Gagal: " & ex.Message)
        End Try
    End Sub
End Module