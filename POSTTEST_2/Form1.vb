Imports System.Runtime.InteropServices

Public Class Form1
    'Control Buttons
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    'Button Tambah
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim judul As String = txtJudul.Text.Trim()
        Dim Genre As String = txtGenre.Text.Trim()
        If Not String.IsNullOrEmpty(judul) AndAlso Not String.IsNullOrEmpty(Genre) Then
            If TambahBuku(daftarBuku, jumlahBuku, judul) Then
                dgvBuku.Rows.Add(judul, Genre)
                txtJudul.Clear()
                txtGenre.Clear()
            End If
        Else
            MessageBox.Show("Judul dan Genre tidak boleh kosong!", "Peringatan",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    'Button Hapus
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim judulInput As String = txtJudul.Text.Trim()

        If String.IsNullOrEmpty(judulInput) Then
            MessageBox.Show("Masukkan judul buku yang ingin dihapus!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim found As Boolean = False
        For i As Integer = dgvBuku.Rows.Count - 1 To 0 Step -1
            Dim row As DataGridViewRow = dgvBuku.Rows(i)
            If Not row.IsNewRow AndAlso row.Cells(0).Value IsNot Nothing Then
                Dim rowJudul As String = row.Cells(0).Value.ToString().Trim()
                If String.Compare(rowJudul, judulInput, True) = 0 Then
                    HapusBuku(daftarBuku, jumlahBuku, judulInput)
                    dgvBuku.Rows.RemoveAt(i)
                    found = True
                    Exit For
                End If
            End If
        Next

        If found Then
            txtJudul.Clear()
            txtGenre.Clear()
        Else
            MessageBox.Show("Judul tidak ditemukan!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
