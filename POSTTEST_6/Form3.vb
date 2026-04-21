Imports MySqlConnector

Public Class Form3
    Public mode As String
    Public selectedRowAkuarium As DataGridViewRow
    Public selectedRowIkan As DataGridViewRow

    ' Fungsi bantu agar sinkron dengan Form1
    Private Function GetMaxCapacity(index As Integer) As Integer
        Select Case index
            Case 0 : Return 50
            Case 1 : Return 200
            Case 2 : Return 500
            Case 3 : Return 2000
            Case Else : Return 50
        End Select
    End Function

    Private Function GetFishSizeCount(index As Integer) As Integer
        Select Case index
            Case 0 : Return 1
            Case 1 : Return 10
            Case 2 : Return 25
            Case 3 : Return 350
            Case Else : Return 1
        End Select
    End Function

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If mode = "akuarium" Then
            TabControl1.SelectedTab = tabAkuarium
            lblTitle.Text = "Edit Akuarium: " & selectedRowAkuarium.Cells("ID_AQ").Value.ToString()

            txtNamaBaru.Text = selectedRowAkuarium.Cells("NamaAkuarium").Value.ToString()

            ' Pilih index ComboBox berdasarkan angka kapasitas
            Dim cap As Integer = CInt(selectedRowAkuarium.Cells("Kapasitas").Value)
            Select Case cap
                Case 50 : cbKapasitasBaru.SelectedIndex = 0
                Case 200 : cbKapasitasBaru.SelectedIndex = 1
                Case 500 : cbKapasitasBaru.SelectedIndex = 2
                Case 2000 : cbKapasitasBaru.SelectedIndex = 3
            End Select

        ElseIf mode = "ikan" Then
            TabControl1.SelectedTab = tabIkan
            lblTitle.Text = "Edit Ikan: " & selectedRowIkan.Cells("ID_Ikan").Value.ToString()

            txtNamaIkanBaru.Text = selectedRowIkan.Cells("Nama_Ikan").Value.ToString()

            Dim size As Integer = CInt(selectedRowIkan.Cells("Ukuran").Value)
            Select Case size
                Case 1 : cbUkuranBaru.SelectedIndex = 0
                Case 10 : cbUkuranBaru.SelectedIndex = 1
                Case 25 : cbUkuranBaru.SelectedIndex = 2
                Case 350 : cbUkuranBaru.SelectedIndex = 3
            End Select
        End If
    End Sub

    ' --- UPDATE AKUARIUM ---
    Private Sub btnSimpanAkuarium_Click(sender As Object, e As EventArgs) Handles btnSimpanAkuarium.Click
        Try
            Dim id As String = selectedRowAkuarium.Cells("ID_AQ").Value.ToString()
            Dim kapLama As Integer = CInt(selectedRowAkuarium.Cells("Kapasitas").Value)
            Dim sisaLama As Integer = CInt(selectedRowAkuarium.Cells("Sisa").Value)

            Dim kapBaru As Integer = GetMaxCapacity(cbKapasitasBaru.SelectedIndex)
            Dim selisih As Integer = kapBaru - kapLama
            Dim sisaBaru As Integer = sisaLama + selisih

            If sisaBaru < 0 Then
                MessageBox.Show("Gagal! Kapasitas baru tidak cukup menampung ikan yang ada.")
                Return
            End If

            Using conn As New MySqlConnection(strConn)
                conn.Open()
                Dim q As String = "UPDATE tb_akuarium SET NamaAkuarium=@nm, Kapasitas=@kp, Sisa=@ss WHERE ID_AQ=@id"
                Dim cmd As New MySqlCommand(q, conn)
                cmd.Parameters.AddWithValue("@nm", txtNamaBaru.Text)
                cmd.Parameters.AddWithValue("@kp", kapBaru)
                cmd.Parameters.AddWithValue("@ss", sisaBaru)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Akuarium berhasil diperbarui!")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' --- UPDATE IKAN ---
    Private Sub btnSimpanIkan_Click(sender As Object, e As EventArgs) Handles btnSimpanIkan.Click
        Try
            Dim idIkan As String = selectedRowIkan.Cells("ID_Ikan").Value.ToString()
            Dim idAq As String = selectedRowIkan.Cells("NamaAQ").Value.ToString()
            Dim ukLama As Integer = CInt(selectedRowIkan.Cells("Ukuran").Value)
            Dim ukBaru As Integer = GetFishSizeCount(cbUkuranBaru.SelectedIndex)
            Dim selisih As Integer = ukLama - ukBaru ' Jika ukBaru lebih kecil, sisa bertambah

            Using conn As New MySqlConnection(strConn)
                conn.Open()
                ' 1. Update Data Ikan
                Dim cmd1 As New MySqlCommand("UPDATE tb_ikan SET Nama_Ikan=@nm, Ukuran=@uk WHERE ID_Ikan=@id", conn)
                cmd1.Parameters.AddWithValue("@nm", txtNamaIkanBaru.Text)
                cmd1.Parameters.AddWithValue("@uk", ukBaru)
                cmd1.Parameters.AddWithValue("@id", idIkan)
                cmd1.ExecuteNonQuery()

                ' 2. Update Sisa Kapasitas Akuarium (sinkronisasi)
                Dim cmd2 As New MySqlCommand("UPDATE tb_akuarium SET Sisa = Sisa + @sl WHERE ID_AQ = @aq", conn)
                cmd2.Parameters.AddWithValue("@sl", selisih)
                cmd2.Parameters.AddWithValue("@aq", idAq)
                cmd2.ExecuteNonQuery()
            End Using

            MessageBox.Show("Data Ikan berhasil diperbarui!")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancelAkuarium.Click, btnCancelIkan.Click, btnExit.Click
        Me.Close()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub
End Class