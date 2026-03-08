<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PanelTitle = New Panel()
        btnExit = New Button()
        Label1 = New Label()
        btnMinimize = New Button()
        dgvBuku = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Label2 = New Label()
        txtJudul = New TextBox()
        txtGenre = New TextBox()
        btnTambah = New Button()
        btnHapus = New Button()
        Panel1 = New Panel()
        PanelTitle.SuspendLayout()
        CType(dgvBuku, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelTitle
        ' 
        PanelTitle.BackColor = Color.SaddleBrown
        PanelTitle.Controls.Add(btnExit)
        PanelTitle.Controls.Add(Label1)
        PanelTitle.Controls.Add(btnMinimize)
        PanelTitle.Location = New Point(0, 0)
        PanelTitle.Name = "PanelTitle"
        PanelTitle.Size = New Size(800, 35)
        PanelTitle.TabIndex = 0
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.LightCoral
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        btnExit.Location = New Point(730, -7)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(74, 50)
        btnExit.TabIndex = 3
        btnExit.Text = "X"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 28)
        Label1.TabIndex = 2
        Label1.Text = "Posttest 2"
        ' 
        ' btnMinimize
        ' 
        btnMinimize.BackColor = Color.Goldenrod
        btnMinimize.FlatStyle = FlatStyle.Flat
        btnMinimize.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        btnMinimize.Location = New Point(665, -8)
        btnMinimize.Name = "btnMinimize"
        btnMinimize.Size = New Size(69, 53)
        btnMinimize.TabIndex = 1
        btnMinimize.Text = "—"
        btnMinimize.UseVisualStyleBackColor = False
        ' 
        ' dgvBuku
        ' 
        dgvBuku.AllowUserToAddRows = False
        dgvBuku.AllowUserToDeleteRows = False
        dgvBuku.AllowUserToResizeColumns = False
        dgvBuku.AllowUserToResizeRows = False
        dgvBuku.BackgroundColor = SystemColors.Control
        dgvBuku.BorderStyle = BorderStyle.None
        dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBuku.ColumnHeadersVisible = False
        dgvBuku.Columns.AddRange(New DataGridViewColumn() {Column1, Column2})
        dgvBuku.EnableHeadersVisualStyles = False
        dgvBuku.GridColor = Color.SaddleBrown
        dgvBuku.Location = New Point(489, 104)
        dgvBuku.Name = "dgvBuku"
        dgvBuku.ReadOnly = True
        dgvBuku.RowHeadersVisible = False
        dgvBuku.RowHeadersWidth = 51
        dgvBuku.Size = New Size(251, 437)
        dgvBuku.TabIndex = 1
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Judul"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Genre"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 125
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(122, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(189, 41)
        Label2.TabIndex = 0
        Label2.Text = "Daftar Buku"
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(30, 21)
        txtJudul.Name = "txtJudul"
        txtJudul.PlaceholderText = "Masukkan Judul Buku"
        txtJudul.Size = New Size(276, 27)
        txtJudul.TabIndex = 2
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(30, 90)
        txtGenre.Name = "txtGenre"
        txtGenre.PlaceholderText = "Masukkan Genre Buku"
        txtGenre.Size = New Size(276, 27)
        txtGenre.TabIndex = 3
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.Gold
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnTambah.Location = New Point(30, 167)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(121, 40)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah Buku"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.LightCoral
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnHapus.ForeColor = SystemColors.ActiveCaptionText
        btnHapus.Location = New Point(185, 167)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(121, 40)
        btnHapus.TabIndex = 5
        btnHapus.Text = "Hapus Buku"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SaddleBrown
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(btnHapus)
        Panel1.Controls.Add(btnTambah)
        Panel1.Controls.Add(txtGenre)
        Panel1.Controls.Add(txtJudul)
        Panel1.Location = New Point(53, 166)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(335, 247)
        Panel1.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleGoldenrod
        ClientSize = New Size(800, 464)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(dgvBuku)
        Controls.Add(PanelTitle)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Posttest 2"
        PanelTitle.ResumeLayout(False)
        PanelTitle.PerformLayout()
        CType(dgvBuku, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PanelTitle As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvBuku As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents Panel1 As Panel

End Class
