Imports System.IO
Imports System.Text.Json
Public Class Form1

    ' 1. Validasi Inputan Kosong
    Private Function ValidasiKosong() As Boolean
        ' Cek TextBox dan MaskedTextBox
        If txtNama.Text = "" Or txtID.Text = "" Or txtEmail.Text = "" Or txtAlamat.Text = "" Or Not mtxtTelp.MaskCompleted Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Cek Checkbox (minimal 1 hobi dipilih)
        Dim hobiTerisi As Boolean = False
        For Each ctrl As Control In gbHobi.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim chk As CheckBox = DirectCast(ctrl, CheckBox)
                If chk.Checked Then
                    hobiTerisi = True
                    Exit For
                End If
            End If
        Next

        If Not hobiTerisi Then
            MessageBox.Show("Inputan hobi tidak boleh kosong (Pilih minimal satu!)", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    ' 2. Validasi Nama hanya huruf
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = " "c Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    ' (MaskedTextBox mtxtTelepon sudah memvalidasi angka jika Mask diatur ke 0000-0000-00000)

    ' 3. Fitur Browse Foto
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pbFoto.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    ' 4. Simpan & Cetak (Berpindah ke Form2)
    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click
        If ValidasiKosong() Then
            Dim konfirmasi As DialogResult = MessageBox.Show("Apakah Anda yakin data sudah benar dan ingin mencetak kartu?", "Konfirmasi Cetak", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If konfirmasi = DialogResult.Yes Then
                ' Kumpulkan Hobi
                Dim hobiList As String = ""
                For Each ctrl As Control In gbHobi.Controls
                    If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then
                        hobiList &= DirectCast(ctrl, CheckBox).Text & ", "
                    End If
                Next

                Dim peran As String = If(rbKetua.Checked, "Ketua", If(rbWakil.Checked, "Wakil Ketua", If(rbAdmin.Checked, "Admin", "Anggota")))

                ' Kirim data ke Form 2
                Dim frm2 As New Form2()
                frm2.lblNama.Text = "Nama: " & txtNama.Text
                frm2.lblID.Text = "ID: " & txtID.Text
                frm2.lblKomunitas.Text = "Spesies: " & cbKomunitas.Text
                frm2.lblPeran.Text = "Peran: " & peran
                frm2.lblKontak.Text = "Telp: " & mtxtTelp.Text
                frm2.lblHobi.Text = "Hobi: " & hobiList.TrimEnd(","c, " "c)

                If pbFoto.Image IsNot Nothing Then
                    frm2.pbFotoHasil.Image = pbFoto.Image
                End If

                frm2.Show()
            End If
        End If
    End Sub

    ' 6. Menu Strip Navigasi
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim tutup As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If tutup = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        TabControl.SelectedTab = tpMain ' Berpindah tab via menu
    End Sub

    '7. Fitur Lihat Kartu (Preview tanpa konfirmasi)
    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        ' Kita gunakan fungsi ValidasiKosong() yang sudah dibuat sebelumnya
        If ValidasiKosong() Then
            ' Kumpulkan data Hobi
            Dim hobiList As String = ""
            For Each ctrl As Control In gbHobi.Controls
                If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then
                    hobiList &= DirectCast(ctrl, CheckBox).Text & ", "
                End If
            Next

            ' Tentukan Peran
            Dim peran As String = If(rbKetua.Checked, "Ketua", If(rbAdmin.Checked, "Admin", "Anggota"))

            ' Tampilkan Form 2 sebagai Preview (tanpa MessageBox konfirmasi)
            Dim frm2 As New Form2()
            frm2.lblNama.Text = "Nama: " & txtNama.Text
            frm2.lblID.Text = "ID: " & txtID.Text
            frm2.lblKomunitas.Text = "Spesies: " & cbKomunitas.Text
            frm2.lblPeran.Text = "Peran: " & peran
            frm2.lblKontak.Text = "Telp: " & mtxtTelp.Text
            frm2.lblHobi.Text = "Hobi: " & hobiList.TrimEnd(","c, " "c)

            ' Tampilkan foto jika sudah di-browse
            If pbFoto.Image IsNot Nothing Then
                frm2.pbFotoHasil.Image = pbFoto.Image
            End If

            ' Munculkan Form Preview
            frm2.Show()
        Else
            ' Jika ada yang kosong, beri tahu pengguna untuk melengkapi data dulu
            MessageBox.Show("Silakan lengkapi data di form terlebih dahulu untuk melihat pratinjau kartu.", "Data Belum Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' 8. Fitur Save File (Simpan Data JSON)
    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        SaveFileDialog1.Filter = "JSON File (*.json)|*.json"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                ' Buat objek dari data inputan
                Dim dataBaru As New AnggotaData With {
                    .Nama = txtNama.Text,
                    .ID = txtID.Text,
                    .Komunitas = cbKomunitas.Text,
                    .Telepon = mtxtTelp.Text
                }

                ' Konversi objek ke string JSON (Indented agar rapi dibaca di Notepad)
                Dim opsi As New JsonSerializerOptions With {.WriteIndented = True}
                Dim jsonString As String = JsonSerializer.Serialize(dataBaru, opsi)

                ' Tulis ke file
                File.WriteAllText(SaveFileDialog1.FileName, jsonString)

                MessageBox.Show("Data berhasil disimpan dalam format JSON!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Gagal menyimpan JSON: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' 9. Fitur Open File (Buka Data JSON - VERSI PERBAIKAN)
    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        OpenFileDialog1.Filter = "JSON File (*.json)|*.json"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                Dim jsonString As String = File.ReadAllText(OpenFileDialog1.FileName)

                Dim opsi As New JsonSerializerOptions With {
                    .PropertyNameCaseInsensitive = True
                }

                Dim dataMemuat As AnggotaData = JsonSerializer.Deserialize(Of AnggotaData)(jsonString, opsi)

                If dataMemuat IsNot Nothing Then
                    ' Gunakan pengisian manual dan tambahkan .Refresh atau Application.DoEvents jika perlu
                    txtNama.Text = If(dataMemuat.Nama, "")
                    txtID.Text = If(dataMemuat.ID, "")
                    cbKomunitas.Text = If(dataMemuat.Komunitas, "")

                    ' Khusus MaskedTextBox, terkadang butuh pembersihan spasi
                    mtxtTelp.Text = dataMemuat.Telepon

                    ' PENTING: Paksa UI untuk update tampilan
                    Me.Refresh()

                    MessageBox.Show("Data berhasil dimuat untuk: " & dataMemuat.Nama, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Data kosong atau tidak dikenali.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            Catch ex As Exception
                MessageBox.Show("Gagal memproses file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class

Public Class AnggotaData
    Public Property Nama As String
    Public Property ID As String
    Public Property Komunitas As String
    Public Property Telepon As String
    ' Kamu bisa menambah field lain di sini jika perlu
End Class