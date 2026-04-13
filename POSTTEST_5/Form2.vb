Public Class Form2
    Private isDragging As Boolean = False
    Private mouseOffset As Point
    ' Form movement handlers
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
        If e.Button = MouseButtons.Left Then
            isDragging = False
        End If
    End Sub
    Private Sub txtCheat_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCheat.KeyDown
        ' Periksa apakah tombol yang ditekan adalah Enter
        If e.KeyCode = Keys.Enter Then
            ' Mencegah suara "beep" sistem
            e.SuppressKeyPress = True

            ' Lakukan aksi, misalnya klik tombol atau pindah fokus
            btnCheat.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            e.SuppressKeyPress = True
            Me.Close() ' Menutup form jika tombol Escape ditekan
            ' Atau: Me.SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub
    Private Sub btnCheat_Click(sender As Object, e As EventArgs) Handles btnCheat.Click
        If txtCheat.Text = "KOINCHEAT" Then
            KoinPemain += 6000
            lblValid.ForeColor = Color.Green
            lblValid.Text = "Cheat Activated! Koin +6000"
        ElseIf txtCheat.Text = "BANKRUPT" Then
            KoinPemain = 0
            lblValid.ForeColor = Color.Green
            lblValid.Text = "Cheat Activated! Koin Reset to 0"
        Else
            lblValid.ForeColor = Color.Red
            lblValid.Text = "Invalid Cheat Code!"
        End If
        Form1.UpdateTampilanKoin()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


End Class