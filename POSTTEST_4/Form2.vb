Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form ini hanya bertugas menampilkan hasil desain kartu.
        ' Semua label sudah diisi dari Form1.

        ' Opsional: Atur ukuran foto agar proporsional
        pbFotoHasil.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class