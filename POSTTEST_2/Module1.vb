Module Module1
    Public daftarBuku(99) As String
    Public jumlahBuku As Integer = 0
    'satu Fungsi
    Public Function TambahBuku(ByRef arrBuku() As String, ByRef jmlBuku As Integer, ByVal judul As String) As Boolean
        If jmlBuku < arrBuku.Length Then
            arrBuku(jmlBuku) = judul
            jmlBuku += 1
            Return True
        Else
            MessageBox.Show("Kapasitas buku sudah penuh!", "Peringatan",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
    End Function
    'Satu Prosedur
    Public Sub HapusBuku(ByRef arrBuku() As String, ByRef jmlBuku As Integer, ByVal judul As String)
        Dim index As Integer = Array.IndexOf(arrBuku, judul)
        If index >= 0 Then
            For i As Integer = index To jmlBuku - 2
                arrBuku(i) = arrBuku(i + 1)
            Next
            arrBuku(jmlBuku - 1) = Nothing
            jmlBuku -= 1
        Else
            MessageBox.Show("Buku tidak ditemukan!", "Peringatan",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Module
