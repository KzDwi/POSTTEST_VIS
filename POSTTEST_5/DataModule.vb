Module DataModule
    ' --- VARIABEL GLOBAL / DATABASE SIMULATION ---
    Public KoinPemain As Integer = 500 ' Saldo awal
    Public dtAkuarium As New DataTable
    Public dtIkan As New DataTable

    Public Sub InitDatabase()
        ' Tabel Akuarium
        If dtAkuarium.Columns.Count = 0 Then
            dtAkuarium.Columns.Add("ID_AQ")
            dtAkuarium.Columns.Add("Nama")
            dtAkuarium.Columns.Add("Kapasitas", GetType(Integer))
            dtAkuarium.Columns.Add("Sisa", GetType(Integer))
        End If

        ' Tabel Ikan
        If dtIkan.Columns.Count = 0 Then
            dtIkan.Columns.Add("ID_Ikan")
            dtIkan.Columns.Add("ID_AQ")
            dtIkan.Columns.Add("Nama_Ikan")
            dtIkan.Columns.Add("Ukuran", GetType(Integer)) ' Ini adalah SizeCount
        End If
    End Sub
End Module