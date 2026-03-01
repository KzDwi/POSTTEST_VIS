Public Class Form1
    Dim nilai As Double
    Dim IPK As Double
    Dim IPS As Double
    Dim SemCount As Integer

    Private Sub txtIPS_TextChanged(sender As Object, e As EventArgs) Handles txtIPS.TextChanged

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If Double.TryParse(txtIPS.Text, nilai) Then
            If nilai < 0 Or nilai > 4 Then
                MessageBox.Show("Nilai IPS harus antara 0 dan 4.")
                Return
            End If
            IPS += nilai
            SemCount += 1
            IPK = IPS / SemCount
            txtIPK.Text = IPK.ToString()
        Else
            MessageBox.Show("Masukkan nilai IPS yang valid.")
        End If

        If IPK > 3.0 Then
            lblPredikat.Text = "Sangat Memuaskan".ToString()
        ElseIf IPK > 2.75 Then
            lblPredikat.Text = "Memuaskan"
        ElseIf IPK >= 2.0 Then
            lblPredikat.Text = "Cukup"
        Else
            lblPredikat.Text = "Kurang"
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        IPK = 0
        txtIPK.Text = IPK.ToString()
        IPS = 0
        SemCount = 0
        txtIPS.Text = ""
    End Sub

    Private Sub txtIPK_TextChanged(sender As Object, e As EventArgs) Handles txtIPK.TextChanged

    End Sub

    Private Sub lblPredikat_Click(sender As Object, e As EventArgs) Handles lblPredikat.Click

    End Sub
End Class
