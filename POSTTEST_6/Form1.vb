Imports System.Text.RegularExpressions
Imports MySqlConnector

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Jalankan auto-create DB dari Module
        InitDatabase()

        UpdateTampilanKoin()
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0

        If cbKapasitas.Items.Count > 0 Then cbKapasitas.SelectedIndex = 0
        If cbUkuran.Items.Count > 0 Then cbUkuran.SelectedIndex = 0

        ' Tarik data dari MySQL ke Grid
        LoadData()
    End Sub

    ' --- FUNGSI LOAD DATA DARI MYSQL ---
    Public Sub LoadData()
        dgvAkuarium.Rows.Clear()
        dgvIkan.Rows.Clear()
        cbPilihAkuarium.Items.Clear()

        Using conn As New MySqlConnection(strConn)
            Try
                conn.Open()

                ' Load Akuarium
                Dim cmdAq As New MySqlCommand("SELECT * FROM tb_akuarium", conn)
                Dim rdAq As MySqlDataReader = cmdAq.ExecuteReader()
                While rdAq.Read()
                    dgvAkuarium.Rows.Add(rdAq("ID_AQ"), rdAq("NamaAkuarium"), rdAq("Kapasitas"), rdAq("Sisa"))
                    cbPilihAkuarium.Items.Add(rdAq("ID_AQ").ToString() & " | " & rdAq("NamaAkuarium").ToString())
                End While
                rdAq.Close()

                ' Load Ikan
                Dim cmdIkan As New MySqlCommand("SELECT * FROM tb_ikan", conn)
                Dim rdIkan As MySqlDataReader = cmdIkan.ExecuteReader()
                While rdIkan.Read()
                    dgvIkan.Rows.Add(rdIkan("ID_Ikan"), rdIkan("Nama_Ikan"), rdIkan("NamaAQ"), rdIkan("Ukuran"))
                End While
                rdIkan.Close()

            Catch ex As Exception
                MessageBox.Show("Gagal memuat data: " & ex.Message)
            End Try
        End Using
    End Sub

    ' --- LOGIKA NILAI (SIZECOUNT & KAPASITAS) ---

    ' Berapa kapasitas yang didapat saat beli akuarium
    Private Function GetMaxCapacity(index As Integer) As Integer
        Select Case index
            Case 0 : Return 50    ' Kecil
            Case 1 : Return 200   ' Sedang
            Case 2 : Return 500   ' Besar
            Case 3 : Return 2000  ' Sangat Besar
            Case Else : Return 0
        End Select
    End Function

    ' Berapa SizeCount yang dimakan ikan
    Private Function GetFishSizeCount(index As Integer) As Integer
        Select Case index
            Case 0 : Return 1     ' Kecil
            Case 1 : Return 10    ' Sedang
            Case 2 : Return 25    ' Besar
            Case 3 : Return 350   ' Sangat Besar (SpecialSize)
            Case Else : Return 0
        End Select
    End Function

    ' Harga Ikan
    Private Function GetHargaIkan(index As Integer) As Integer
        Select Case index
            Case 0 : Return 25
            Case 1 : Return 180
            Case 2 : Return 450
            Case 3 : Return 4000
            Case Else : Return 0
        End Select
    End Function

    ' --- FUNGSI UPDATE UI ---
    Public Sub UpdateTampilanKoin()
        ' Logika Progress Bar & Bonus
        If ProgressBar1.Value >= ProgressBar1.Maximum Then
            ProgressBar1.Value = 0
            KoinPemain += 25
            lblStatusKoin.Text = "Jumlah Koin: " & KoinPemain & " (BONUS!)"
        Else
            lblStatusKoin.Text = "Jumlah Koin: " & KoinPemain
        End If

        lblKoinBesar.Text = KoinPemain.ToString()
    End Sub

    ' --- TAB 1: CLICKER GAME ---
    Private Sub btnClicker_Click(sender As Object, e As EventArgs) Handles btnClicker.Click
        KoinPemain += 5
        ' Naikkan progress bar setiap klik
        If ProgressBar1.Value + 10 <= ProgressBar1.Maximum Then
            ProgressBar1.Value += 10
        Else
            ProgressBar1.Value = ProgressBar1.Maximum
        End If
        UpdateTampilanKoin()
    End Sub

    ' --- TAB 2: CRUD AKUARIUM ---
    ' --- REFRESH COMBOBOX (Penting agar pilihan Akuarium sinkron) ---
    Private Sub RefreshComboAkuarium()
        cbPilihAkuarium.Items.Clear()
        For Each row As DataGridViewRow In dgvAkuarium.Rows
            If Not row.IsNewRow Then
                ' Mengambil ID_AQ dan NamaAkuarium dari cell
                Dim id As String = row.Cells("ID_AQ").Value.ToString()
                Dim nama As String = row.Cells("NamaAkuarium").Value.ToString()
                cbPilihAkuarium.Items.Add(id & " | " & nama)
            End If
        Next
    End Sub

    ' --- CREATE: TAMBAH AKUARIUM ---
    Private Sub btnTambahAkuarium_Click(sender As Object, e As EventArgs) Handles btnTambahAkuarium.Click
        ' Validasi Koin (Asumsi harga 100)
        If KoinPemain < 100 Then
            MessageBox.Show("Koin tidak cukup (Butuh 100)!")
            Return
        End If

        Dim idAuto As String = "AQ" & (dgvAkuarium.Rows.Count + 1).ToString("D3")
        Dim nama As String = txtNamaAkuarium.Text
        Dim kap As Integer = GetMaxCapacity(cbKapasitas.SelectedIndex)

        Using conn As New MySqlConnection(strConn)
            Try
                conn.Open()
                Dim query As String = "INSERT INTO tb_akuarium (ID_AQ, NamaAkuarium, Kapasitas, Sisa) VALUES (@id, @nama, @kap, @sisa)"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", idAuto)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@kap", kap)
                cmd.Parameters.AddWithValue("@sisa", kap)
                cmd.ExecuteNonQuery()

                KoinPemain -= 100
                UpdateTampilanKoin()
                LoadData()
                MessageBox.Show("Akuarium Berhasil Dibeli!")
            Catch ex As Exception
                MessageBox.Show("Gagal Simpan: " & ex.Message)
            End Try
        End Using
    End Sub

    ' --- CREATE: TAMBAH IKAN ---
    Private Sub btnBeliIkan_Click(sender As Object, e As EventArgs) Handles btnBeliIkan.Click
        If cbPilihAkuarium.SelectedIndex = -1 Then
            MessageBox.Show("Pilih akuarium tujuan terlebih dahulu!")
            Return
        End If

        ' --- PERBAIKAN 1: Ambil ID-nya saja (jaga-jaga jika ada format "AQ001 | Nama") ---
        Dim textPilihan As String = cbPilihAkuarium.SelectedItem.ToString()
        Dim idAqTujuan As String = textPilihan.Split("|"c)(0).Trim()

        Dim ukuranIkan As Integer = GetFishSizeCount(cbUkuran.SelectedIndex)
        Dim hargaIkan As Integer = ukuranIkan * 2 ' Asumsi harga

        If KoinPemain < hargaIkan Then
            MessageBox.Show("Koin tidak cukup!")
            Return
        End If

        Using conn As New MySqlConnection(strConn)
            Try
                conn.Open()
                ' Cek sisa kapasitas di DB
                Dim cmdCek As New MySqlCommand("SELECT Sisa FROM tb_akuarium WHERE ID_AQ = @id", conn)
                cmdCek.Parameters.AddWithValue("@id", idAqTujuan)

                ' --- PERBAIKAN 2: Tangani nilai kosong agar tidak dianggap 0 ---
                Dim result As Object = cmdCek.ExecuteScalar()

                If result Is Nothing OrElse IsDBNull(result) Then
                    MessageBox.Show("Error: Akuarium dengan ID '" & idAqTujuan & "' tidak ditemukan di database!")
                    Return
                End If

                Dim sisaSekarang As Integer = CInt(result)

                ' Tambahan informasi sisa kapasitas pada pesan error agar jelas
                If sisaSekarang < ukuranIkan Then
                    MessageBox.Show("Akuarium penuh! (Sisa kapasitas: " & sisaSekarang & ", Ukuran Ikan: " & ukuranIkan & ")")
                    Return
                End If

                ' 1. Tambah Ikan
                Dim idIkan As String = "F" & (dgvIkan.Rows.Count + 1).ToString("D3")
                Dim cmdIkan As New MySqlCommand("INSERT INTO tb_ikan (ID_Ikan, Nama_Ikan, NamaAQ, Ukuran) VALUES (@id, @nm, @aq, @uk)", conn)
                cmdIkan.Parameters.AddWithValue("@id", idIkan)
                cmdIkan.Parameters.AddWithValue("@nm", txtNamaIkan.Text)
                cmdIkan.Parameters.AddWithValue("@aq", idAqTujuan)
                cmdIkan.Parameters.AddWithValue("@uk", ukuranIkan)
                cmdIkan.ExecuteNonQuery()

                ' 2. Potong Sisa Kapasitas Akuarium
                Dim cmdUpdateAq As New MySqlCommand("UPDATE tb_akuarium SET Sisa = Sisa - @uk WHERE ID_AQ = @aq", conn)
                cmdUpdateAq.Parameters.AddWithValue("@uk", ukuranIkan)
                cmdUpdateAq.Parameters.AddWithValue("@aq", idAqTujuan)
                cmdUpdateAq.ExecuteNonQuery()

                KoinPemain -= hargaIkan
                UpdateTampilanKoin()
                LoadData()
                MessageBox.Show("Ikan berhasil dimasukkan ke " & idAqTujuan)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    ' --- DELETE: HAPUS IKAN (Melepas Ikan) ---
    Private Sub btnHapusIkan_Click(sender As Object, e As EventArgs) Handles btnHapusIkan.Click
        Dim idIkan As String = txtNamaIkan.Text.Trim()
        If idIkan = "" Then Return

        Using conn As New MySqlConnection(strConn)
            Try
                conn.Open()
                ' 1. Cari dulu data ikan (untuk tau ukuran dan dia di akuarium mana)
                Dim cmdCari As New MySqlCommand("SELECT Ukuran, NamaAQ FROM tb_ikan WHERE ID_Ikan = @id", conn)
                cmdCari.Parameters.AddWithValue("@id", idIkan)
                Dim rd As MySqlDataReader = cmdCari.ExecuteReader()

                If rd.Read() Then
                    Dim ukuranIkan As Integer = CInt(rd("Ukuran"))
                    Dim idAq As String = rd("NamaAQ").ToString()
                    rd.Close()

                    ' 2. Hapus Ikan
                    Dim cmdDel As New MySqlCommand("DELETE FROM tb_ikan WHERE ID_Ikan = @id", conn)
                    cmdDel.Parameters.AddWithValue("@id", idIkan)
                    cmdDel.ExecuteNonQuery()

                    ' 3. Kembalikan Sisa Kapasitas Akuarium
                    Dim cmdRestore As New MySqlCommand("UPDATE tb_akuarium SET Sisa = Sisa + @uk WHERE ID_AQ = @aq", conn)
                    cmdRestore.Parameters.AddWithValue("@uk", ukuranIkan)
                    cmdRestore.Parameters.AddWithValue("@aq", idAq)
                    cmdRestore.ExecuteNonQuery()

                    MessageBox.Show("Ikan berhasil dilepas/dihapus!")
                    LoadData()
                Else
                    rd.Close()
                    MessageBox.Show("ID Ikan tidak ditemukan!")
                End If
            Catch ex As Exception
                MessageBox.Show("Gagal Hapus Ikan: " & ex.Message)
            End Try
        End Using
    End Sub

    ' --- DELETE: HAPUS AKUARIUM ---
    Private Sub btnHapusAkuarium_Click(sender As Object, e As EventArgs) Handles btnHapusAkuarium.Click
        Dim id As String = txtNamaAkuarium.Text.Trim()
        If id = "" Then Return

        If MessageBox.Show("Hapus " & id & "? Semua ikan didalamnya akan ikut terhapus!", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Using conn As New MySqlConnection(strConn)
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM tb_akuarium WHERE ID_AQ = @id", conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using
            LoadData()
        End If
    End Sub

    ' --- UI EVENTS (Label & Navigation) ---
    Private Sub cbUkuran_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbUkuran.SelectedIndexChanged
        btnBeliIkan.Text = "Beli (" & GetHargaIkan(cbUkuran.SelectedIndex) & " Koin)"
    End Sub

    Private Sub cbKapasitas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKapasitas.SelectedIndexChanged
        Dim harga As Integer = 0
        Select Case cbKapasitas.SelectedIndex
            Case 0 : harga = 100
            Case 1 : harga = 400
            Case 2 : harga = 900
            Case 3 : harga = 2400
        End Select
        btnTambahAkuarium.Text = "Beli (" & harga & " Koin)"
    End Sub

    ' Dragging & System Buttons
    Private isDragging As Boolean = False
    Private mouseOffset As Point
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            mouseOffset = New Point(-e.X, -e.Y)
        End If
    End Sub
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If isDragging Then
            Dim mousePos As Point = MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub
    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        isDragging = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    ' Menu Navigation
    Private Sub CariUangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CariUangToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage1
    End Sub
    Private Sub AkuariumToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AkuariumToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage2
    End Sub
    Private Sub IkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IkanToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage3
        RefreshComboAkuarium()
    End Sub
    Private Sub CheatsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheatsToolStripMenuItem.Click
        Form2.Show()
    End Sub
    Private Sub MisiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MisiToolStripMenuItem.Click
        MessageBox.Show("Misi belum tersedia. Tunggu update selanjutnya!")
    End Sub
    ' --- UPDATE AKUARIUM ---
    Private Sub btnUpdateAkuarium_Click(sender As Object, e As EventArgs) Handles btnUpdateAkuarium.Click
        Dim idCari As String = txtNamaAkuarium.Text.Trim()
        Dim foundRow As DataGridViewRow = Nothing

        For Each row As DataGridViewRow In dgvAkuarium.Rows
            If Not row.IsNewRow AndAlso row.Cells("ID_AQ").Value.ToString() = idCari Then
                foundRow = row
                Exit For
            End If
        Next

        If foundRow IsNot Nothing Then
            Dim f As New Form3
            f.mode = "akuarium"
            f.selectedRowAkuarium = foundRow
            f.ShowDialog()
            LoadData() ' Refresh setelah kembali dari Form3
        Else
            MessageBox.Show("ID Akuarium tidak ditemukan!")
        End If
    End Sub

    ' --- UPDATE IKAN ---
    Private Sub btnUpdateIkan_Click(sender As Object, e As EventArgs) Handles btnUpdateIkan.Click
        Dim idCari As String = txtNamaIkan.Text.Trim()
        Dim foundRow As DataGridViewRow = Nothing

        For Each row As DataGridViewRow In dgvIkan.Rows
            If Not row.IsNewRow AndAlso row.Cells("ID_Ikan").Value.ToString() = idCari Then
                foundRow = row
                Exit For
            End If
        Next

        If foundRow IsNot Nothing Then
            Dim f As New Form3
            f.mode = "ikan"
            f.selectedRowIkan = foundRow
            f.ShowDialog()
            LoadData()
        Else
            MessageBox.Show("ID Ikan tidak ditemukan!")
        End If
    End Sub

End Class