Imports MySqlConnector

Module DataModule
    Public KoinPemain As Integer = 500 ' Saldo awal

    ' String koneksi utama (setelah DB terbuat)
    Public strConn As String = "Server=localhost;User ID=root;Password=;Database=db_akuarium;"

    Public Sub InitDatabase()
        ' Koneksi awal tanpa menyebutkan Database untuk keperluan pengecekan/pembuatan DB
        Dim serverConnStr As String = "Server=localhost;User ID=root;Password=;"

        Using conn As New MySqlConnection(serverConnStr)
            Try
                conn.Open()

                ' 1. Buat Database jika belum ada
                Dim cmdDb As New MySqlCommand("CREATE DATABASE IF NOT EXISTS db_akuarium;", conn)
                cmdDb.ExecuteNonQuery()

                ' Gunakan database tersebut
                Dim cmdUse As New MySqlCommand("USE db_akuarium;", conn)
                cmdUse.ExecuteNonQuery()

                ' 2. Buat Tabel Akuarium
                Dim queryTbAkuarium As String = "
                    CREATE TABLE IF NOT EXISTS tb_akuarium (
                        ID_AQ VARCHAR(10) PRIMARY KEY,
                        NamaAkuarium VARCHAR(50),
                        Kapasitas INT,
                        Sisa INT
                    );"
                Dim cmdTbAq As New MySqlCommand(queryTbAkuarium, conn)
                cmdTbAq.ExecuteNonQuery()

                ' 3. Buat Tabel Ikan (Dengan Relasi Foreign Key ke ID_AQ)
                Dim queryTbIkan As String = "
                    CREATE TABLE IF NOT EXISTS tb_ikan (
                        ID_Ikan VARCHAR(10) PRIMARY KEY,
                        Nama_Ikan VARCHAR(50),
                        NamaAQ VARCHAR(10),
                        Ukuran INT,
                        FOREIGN KEY (NamaAQ) REFERENCES tb_akuarium(ID_AQ) 
                        ON DELETE CASCADE ON UPDATE CASCADE
                    );"
                Dim cmdTbIkan As New MySqlCommand(queryTbIkan, conn)
                cmdTbIkan.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show("Gagal inisialisasi database: " & ex.Message)
            End Try
        End Using
    End Sub
End Module