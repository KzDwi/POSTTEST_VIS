Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitDatabase()

        ' Hubungkan DataGridView ke DataTable
        dgvAkuarium.DataSource = dtAkuarium
        dgvIkan.DataSource = dtIkan

        ' Setup UI
        UpdateTampilanKoin()
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0

        ' Inisialisasi ComboBox agar tidak kosong/error
        If cbKapasitas.Items.Count > 0 Then cbKapasitas.SelectedIndex = 0
        If cbUkuran.Items.Count > 0 Then cbUkuran.SelectedIndex = 0

        RefreshComboAkuarium()
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

    Private Sub RefreshComboAkuarium()
        cbPilihAkuarium.Items.Clear()
        For Each row As DataRow In dtAkuarium.Rows
            cbPilihAkuarium.Items.Add(row("ID_AQ").ToString() & " | " & row("Nama").ToString())
        Next
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
    Private Sub btnTambahAkuarium_Click(sender As Object, e As EventArgs) Handles btnTambahAkuarium.Click
        If cbKapasitas.SelectedIndex = -1 Then Return

        Dim harga As Integer = 0
        Select Case cbKapasitas.SelectedIndex
            Case 0 : harga = 100
            Case 1 : harga = 400
            Case 2 : harga = 900
            Case 3 : harga = 2400
        End Select

        If KoinPemain >= harga Then
            If txtNamaAkuarium.Text.Trim <> "" Then
                KoinPemain -= harga
                Dim kapasitasVal As Integer = GetMaxCapacity(cbKapasitas.SelectedIndex)
                Dim id As String = "AQ-" & DateTime.Now.Ticks.ToString().Substring(13)

                dtAkuarium.Rows.Add(id, txtNamaAkuarium.Text, kapasitasVal, kapasitasVal)

                UpdateTampilanKoin()
                RefreshComboAkuarium()
                MessageBox.Show("Akuarium Berhasil Dibeli!")
                txtNamaAkuarium.Clear()
            Else
                MessageBox.Show("Nama akuarium tidak boleh kosong!")
            End If
        Else
            MessageBox.Show("Koin tidak cukup! Harga: " & harga)
        End If
    End Sub

    Private Sub btnHapusAkuarium_Click(sender As Object, e As EventArgs) Handles btnHapusAkuarium.Click
        Dim idInput As String = txtNamaAkuarium.Text.Trim() ' Mengambil ID dari TextBox
        Dim rows() As DataRow = dtAkuarium.Select("ID_AQ = '" & idInput & "'")

        If rows.Length > 0 Then
            ' Konfirmasi sebelum hapus
            Dim result = MessageBox.Show("Hapus akuarium ini akan menghapus semua ikan di dalamnya. Lanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                ' 1. Hapus semua ikan di dalamnya (Cascade Delete) [cite: 17, 18]
                For i As Integer = dtIkan.Rows.Count - 1 To 0 Step -1
                    If dtIkan.Rows(i)("ID_AQ").ToString() = idInput Then
                        dtIkan.Rows.RemoveAt(i)
                    End If
                Next

                ' 2. Hapus akuarium tersebut [cite: 19]
                rows(0).Delete()
                RefreshComboAkuarium()
                UpdateTampilanKoin()
                txtNamaAkuarium.Clear()
                MessageBox.Show("Akuarium dan ikannya berhasil dihapus.")
            End If
        Else
            MessageBox.Show("ID Akuarium tidak ditemukan! Periksa kembali kodenya.")
        End If
    End Sub

    ' --- TAB 3: CRUD IKAN ---
    Private Sub btnBeliIkan_Click(sender As Object, e As EventArgs) Handles btnBeliIkan.Click
        If cbPilihAkuarium.SelectedIndex = -1 Then
            MessageBox.Show("Pilih akuarium terlebih dahulu!")
            Return
        End If

        Dim hargaIkan As Integer = GetHargaIkan(cbUkuran.SelectedIndex)
        Dim sizeCountIkan As Integer = GetFishSizeCount(cbUkuran.SelectedIndex)
        Dim idAQ As String = cbPilihAkuarium.SelectedItem.ToString().Split("|")(0).Trim()

        If KoinPemain >= hargaIkan Then
            ' Cari baris akuarium untuk cek sisa kapasitas
            Dim rows() As DataRow = dtAkuarium.Select("ID_AQ = '" & idAQ & "'")
            If rows.Length > 0 Then
                Dim rowAQ As DataRow = rows(0)

                If CInt(rowAQ("Sisa")) >= sizeCountIkan Then
                    ' Proses Transaksi
                    KoinPemain -= hargaIkan
                    rowAQ("Sisa") = CInt(rowAQ("Sisa")) - sizeCountIkan

                    Dim idIkan As String = "IK-" & DateTime.Now.Ticks.ToString().Substring(13)
                    dtIkan.Rows.Add(idIkan, idAQ, txtNamaIkan.Text, sizeCountIkan)

                    UpdateTampilanKoin()
                    MessageBox.Show($"Ikan {txtNamaIkan.Text} berhasil dibeli!")
                    txtNamaIkan.Clear()
                Else
                    MessageBox.Show("Kapasitas (SizeCount) akuarium tidak muat!")
                End If
            End If
        Else
            MessageBox.Show("Koin tidak cukup! Harga ikan: " & hargaIkan)
        End If
    End Sub

    Private Sub btnHapusIkan_Click(sender As Object, e As EventArgs) Handles btnHapusIkan.Click
        Dim idInput As String = txtNamaIkan.Text.Trim()
        Dim rowsIkan() As DataRow = dtIkan.Select("ID_Ikan = '" & idInput & "'")

        If rowsIkan.Length > 0 Then
            Dim rowIkan As DataRow = rowsIkan(0)
            Dim idAQ As String = rowIkan("ID_AQ").ToString()
            Dim ukuran As Integer = CInt(rowIkan("Ukuran"))

            ' Kembalikan kapasitas ke akuarium asal [cite: 26, 27]
            Dim rowsAQ() As DataRow = dtAkuarium.Select("ID_AQ = '" & idAQ & "'")
            If rowsAQ.Length > 0 Then
                rowsAQ(0)("Sisa") = CInt(rowsAQ(0)("Sisa")) + ukuran
            End If

            ' Hapus ikan
            rowIkan.Delete()
            UpdateTampilanKoin()
            txtNamaIkan.Clear()
            MessageBox.Show("Ikan berhasil dihapus dan kapasitas akuarium dikembalikan.")
        Else
            MessageBox.Show("ID Ikan tidak ditemukan!")
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

    Private Sub btnUpdateAkuarium_Click(sender As Object, e As EventArgs) Handles btnUpdateAkuarium.Click
        ' Asumsikan ada txtIdUpdateAQ untuk input ID dan txtNamaBaruAQ untuk nama baru
        Dim idAQ As String = txtIdUpdateAQ.Text.Trim()
        Dim rows() As DataRow = dtAkuarium.Select("ID_AQ = '" & idAQ & "'")

        If rows.Length > 0 Then
            If txtNamaBaruAQ.Text.Trim() <> "" Then
                rows(0)("Nama") = txtNamaBaruAQ.Text.Trim()
                RefreshComboAkuarium() ' Refresh list di Tab Ikan [cite: 10, 15]
                MessageBox.Show("Nama Akuarium berhasil diupdate!")
            Else
                MessageBox.Show("Nama baru tidak boleh kosong!")
            End If
        Else
            MessageBox.Show("ID Akuarium tidak ditemukan!")
        End If
    End Sub
    Private Sub btnUpdateIkan_Click(sender As Object, e As EventArgs) Handles btnUpdateIkan.Click
        ' Asumsikan ada txtIdUpdateIkan, txtNamaBaruIkan, dan cbPindahAkuarium (ComboBox ID Baru)
        Dim idIkan As String = txtIdUpdateIkan.Text.Trim()
        Dim rowsIkan() As DataRow = dtIkan.Select("ID_Ikan = '" & idIkan & "'")

        If rowsIkan.Length = 0 Then
            MessageBox.Show("ID Ikan tidak ditemukan!")
            Return
        End If

        Dim rowIkan As DataRow = rowsIkan(0)
        Dim idAQ_Lama As String = rowIkan("ID_AQ").ToString()
        Dim idAQ_Baru As String = cbPindahAkuarium.SelectedItem.ToString().Split("|")(0).Trim() ' Ambil ID dari ComboBox [cite: 20]
        Dim sizeIkan As Integer = CInt(rowIkan("Ukuran"))

        ' 1. Update Nama Ikan jika diisi
        If txtNamaBaruIkan.Text.Trim() <> "" Then
            rowIkan("Nama_Ikan") = txtNamaBaruIkan.Text.Trim()
        End If

        ' 2. Logika Pindah Akuarium
        If idAQ_Lama <> idAQ_Baru Then
            ' Cek Kapasitas di Akuarium Baru
            Dim rowsAQBaru() As DataRow = dtAkuarium.Select("ID_AQ = '" & idAQ_Baru & "'")
            If rowsAQBaru.Length > 0 Then
                Dim rowAQBaru As DataRow = rowsAQBaru(0)

                If CInt(rowAQBaru("Sisa")) >= sizeIkan Then
                    ' Kembalikan kapasitas ke akuarium lama [cite: 26]
                    Dim rowsAQLama() As DataRow = dtAkuarium.Select("ID_AQ = '" & idAQ_Lama & "'")
                    If rowsAQLama.Length > 0 Then
                        rowsAQLama(0)("Sisa") = CInt(rowsAQLama(0)("Sisa")) + sizeIkan
                    End If

                    ' Potong kapasitas di akuarium baru [cite: 22]
                    rowAQBaru("Sisa") = CInt(rowAQBaru("Sisa")) - sizeIkan

                    ' Update ID_AQ di data ikan
                    rowIkan("ID_AQ") = idAQ_Baru
                    MessageBox.Show("Ikan berhasil dipindahkan dan diupdate!")
                Else
                    MessageBox.Show("Gagal pindah! Kapasitas akuarium baru tidak cukup.")
            End If
        End If
        Else
        MessageBox.Show("Nama ikan berhasil diperbarui (tetap di akuarium yang sama).")
        End If
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
End Class