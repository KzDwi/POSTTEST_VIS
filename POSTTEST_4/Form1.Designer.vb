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
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        TabControl = New TabControl()
        tpMain = New TabPage()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        rbWanita = New RadioButton()
        cbKomunitas = New ComboBox()
        rbPria = New RadioButton()
        dtpTglLahir = New DateTimePicker()
        txtID = New TextBox()
        txtNama = New TextBox()
        tpKontak = New TabPage()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        mtxtTelp = New MaskedTextBox()
        tpProfil = New TabPage()
        btnBrowse = New Button()
        btnSimpanCetak = New Button()
        gbHobi = New GroupBox()
        bhkHobi1 = New CheckBox()
        chkHobi2 = New CheckBox()
        chkHobi3 = New CheckBox()
        rbAnggota = New RadioButton()
        chkHobi4 = New CheckBox()
        rbAdmin = New RadioButton()
        chkHobi5 = New CheckBox()
        rbWakil = New RadioButton()
        chkHobi8 = New CheckBox()
        rbKetua = New RadioButton()
        chkHobi6 = New CheckBox()
        chkHobi7 = New CheckBox()
        pbFoto = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        Panel1 = New Panel()
        Label9 = New Label()
        PictureBox1 = New PictureBox()
        Button2 = New Button()
        Button1 = New Button()
        MenuStrip1.SuspendLayout()
        TabControl.SuspendLayout()
        tpMain.SuspendLayout()
        tpKontak.SuspendLayout()
        tpProfil.SuspendLayout()
        gbHobi.SuspendLayout()
        CType(pbFoto, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(4, 33)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(460, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(93, 24)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(94, 24)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(109, 24)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(91, 24)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(65, 24)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' TabControl
        ' 
        TabControl.Controls.Add(tpMain)
        TabControl.Controls.Add(tpKontak)
        TabControl.Controls.Add(tpProfil)
        TabControl.Location = New Point(0, 64)
        TabControl.Name = "TabControl"
        TabControl.SelectedIndex = 0
        TabControl.Size = New Size(800, 388)
        TabControl.TabIndex = 1
        ' 
        ' tpMain
        ' 
        tpMain.BackgroundImage = My.Resources.Resources.bg
        tpMain.Controls.Add(Label8)
        tpMain.Controls.Add(Label7)
        tpMain.Controls.Add(Label6)
        tpMain.Controls.Add(Label5)
        tpMain.Controls.Add(Label4)
        tpMain.Controls.Add(rbWanita)
        tpMain.Controls.Add(cbKomunitas)
        tpMain.Controls.Add(rbPria)
        tpMain.Controls.Add(dtpTglLahir)
        tpMain.Controls.Add(txtID)
        tpMain.Controls.Add(txtNama)
        tpMain.Location = New Point(4, 29)
        tpMain.Name = "tpMain"
        tpMain.Padding = New Padding(3)
        tpMain.Size = New Size(792, 355)
        tpMain.TabIndex = 0
        tpMain.Text = "Data Utama"
        tpMain.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(40, 234)
        Label8.Name = "Label8"
        Label8.Size = New Size(58, 20)
        Label8.TabIndex = 16
        Label8.Text = "Spesies"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(41, 177)
        Label7.Name = "Label7"
        Label7.Size = New Size(104, 20)
        Label7.TabIndex = 15
        Label7.Text = "Tanggal Lahir :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(40, 126)
        Label6.Name = "Label6"
        Label6.Size = New Size(105, 20)
        Label6.TabIndex = 14
        Label6.Text = "Jenis Kelamin :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(40, 72)
        Label5.Name = "Label5"
        Label5.Size = New Size(31, 20)
        Label5.TabIndex = 13
        Label5.Text = "ID :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(40, 25)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 20)
        Label4.TabIndex = 12
        Label4.Text = "Nama :"
        ' 
        ' rbWanita
        ' 
        rbWanita.AutoSize = True
        rbWanita.Location = New Point(291, 126)
        rbWanita.Name = "rbWanita"
        rbWanita.Size = New Size(76, 24)
        rbWanita.TabIndex = 11
        rbWanita.TabStop = True
        rbWanita.Text = "Wanita"
        rbWanita.UseVisualStyleBackColor = True
        ' 
        ' cbKomunitas
        ' 
        cbKomunitas.FormattingEnabled = True
        cbKomunitas.Items.AddRange(New Object() {"Kucing", "Anjing", "Naga", "Serigala", "Lainnya"})
        cbKomunitas.Location = New Point(216, 231)
        cbKomunitas.Name = "cbKomunitas"
        cbKomunitas.Size = New Size(151, 28)
        cbKomunitas.TabIndex = 10
        ' 
        ' rbPria
        ' 
        rbPria.AutoSize = True
        rbPria.Location = New Point(220, 126)
        rbPria.Name = "rbPria"
        rbPria.Size = New Size(55, 24)
        rbPria.TabIndex = 9
        rbPria.TabStop = True
        rbPria.Text = "Pria"
        rbPria.UseVisualStyleBackColor = True
        ' 
        ' dtpTglLahir
        ' 
        dtpTglLahir.Location = New Point(216, 172)
        dtpTglLahir.Name = "dtpTglLahir"
        dtpTglLahir.Size = New Size(250, 27)
        dtpTglLahir.TabIndex = 8
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(216, 69)
        txtID.Name = "txtID"
        txtID.Size = New Size(363, 27)
        txtID.TabIndex = 7
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(216, 18)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(363, 27)
        txtNama.TabIndex = 6
        ' 
        ' tpKontak
        ' 
        tpKontak.BackgroundImage = My.Resources.Resources.bg
        tpKontak.Controls.Add(Label3)
        tpKontak.Controls.Add(Label2)
        tpKontak.Controls.Add(Label1)
        tpKontak.Controls.Add(txtAlamat)
        tpKontak.Controls.Add(txtEmail)
        tpKontak.Controls.Add(mtxtTelp)
        tpKontak.Location = New Point(4, 29)
        tpKontak.Name = "tpKontak"
        tpKontak.Padding = New Padding(3)
        tpKontak.Size = New Size(792, 355)
        tpKontak.TabIndex = 1
        tpKontak.Text = "Kontak & Info"
        tpKontak.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(43, 146)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 20)
        Label3.TabIndex = 5
        Label3.Text = "Alamat :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(43, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 20)
        Label2.TabIndex = 4
        Label2.Text = "E-Mail :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(43, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 20)
        Label1.TabIndex = 3
        Label1.Text = "Nomor Telepon :"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(190, 150)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.PlaceholderText = "Masukkan Alamat"
        txtAlamat.Size = New Size(284, 112)
        txtAlamat.TabIndex = 2
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(190, 100)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Masukkan E-Mail"
        txtEmail.Size = New Size(284, 27)
        txtEmail.TabIndex = 1
        ' 
        ' mtxtTelp
        ' 
        mtxtTelp.Location = New Point(190, 48)
        mtxtTelp.Mask = "0000-0000-0000"
        mtxtTelp.Name = "mtxtTelp"
        mtxtTelp.Size = New Size(125, 27)
        mtxtTelp.TabIndex = 0
        ' 
        ' tpProfil
        ' 
        tpProfil.BackColor = Color.Transparent
        tpProfil.BackgroundImage = My.Resources.Resources.bg
        tpProfil.Controls.Add(btnBrowse)
        tpProfil.Controls.Add(btnSimpanCetak)
        tpProfil.Controls.Add(gbHobi)
        tpProfil.Controls.Add(pbFoto)
        tpProfil.Location = New Point(4, 29)
        tpProfil.Name = "tpProfil"
        tpProfil.Padding = New Padding(3)
        tpProfil.Size = New Size(792, 355)
        tpProfil.TabIndex = 2
        tpProfil.Text = "Profil & Aktivitas"
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.Khaki
        btnBrowse.FlatAppearance.BorderSize = 0
        btnBrowse.FlatStyle = FlatStyle.Flat
        btnBrowse.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBrowse.Location = New Point(68, 303)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(123, 29)
        btnBrowse.TabIndex = 4
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' btnSimpanCetak
        ' 
        btnSimpanCetak.BackColor = Color.PaleGreen
        btnSimpanCetak.FlatAppearance.BorderSize = 0
        btnSimpanCetak.FlatStyle = FlatStyle.Flat
        btnSimpanCetak.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpanCetak.Location = New Point(408, 303)
        btnSimpanCetak.Name = "btnSimpanCetak"
        btnSimpanCetak.Size = New Size(248, 29)
        btnSimpanCetak.TabIndex = 2
        btnSimpanCetak.Text = "Simpan dan Cetak Kartu"
        btnSimpanCetak.UseVisualStyleBackColor = False
        ' 
        ' gbHobi
        ' 
        gbHobi.Controls.Add(bhkHobi1)
        gbHobi.Controls.Add(chkHobi2)
        gbHobi.Controls.Add(chkHobi3)
        gbHobi.Controls.Add(rbAnggota)
        gbHobi.Controls.Add(chkHobi4)
        gbHobi.Controls.Add(rbAdmin)
        gbHobi.Controls.Add(chkHobi5)
        gbHobi.Controls.Add(rbWakil)
        gbHobi.Controls.Add(chkHobi8)
        gbHobi.Controls.Add(rbKetua)
        gbHobi.Controls.Add(chkHobi6)
        gbHobi.Controls.Add(chkHobi7)
        gbHobi.Location = New Point(283, 34)
        gbHobi.Name = "gbHobi"
        gbHobi.Size = New Size(441, 239)
        gbHobi.TabIndex = 1
        gbHobi.TabStop = False
        gbHobi.Text = "Pilihan Peran dan Hobi"
        ' 
        ' bhkHobi1
        ' 
        bhkHobi1.AutoSize = True
        bhkHobi1.Location = New Point(189, 30)
        bhkHobi1.Name = "bhkHobi1"
        bhkHobi1.Size = New Size(79, 24)
        bhkHobi1.TabIndex = 0
        bhkHobi1.Text = "Coding"
        bhkHobi1.UseVisualStyleBackColor = True
        ' 
        ' chkHobi2
        ' 
        chkHobi2.AutoSize = True
        chkHobi2.Location = New Point(188, 56)
        chkHobi2.Name = "chkHobi2"
        chkHobi2.Size = New Size(82, 24)
        chkHobi2.TabIndex = 1
        chkHobi2.Text = "Menulis"
        chkHobi2.UseVisualStyleBackColor = True
        ' 
        ' chkHobi3
        ' 
        chkHobi3.AutoSize = True
        chkHobi3.Location = New Point(188, 85)
        chkHobi3.Name = "chkHobi3"
        chkHobi3.Size = New Size(76, 24)
        chkHobi3.TabIndex = 2
        chkHobi3.Text = "Desain"
        chkHobi3.UseVisualStyleBackColor = True
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Location = New Point(15, 119)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(88, 24)
        rbAnggota.TabIndex = 11
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' chkHobi4
        ' 
        chkHobi4.AutoSize = True
        chkHobi4.Location = New Point(188, 116)
        chkHobi4.Name = "chkHobi4"
        chkHobi4.Size = New Size(83, 24)
        chkHobi4.TabIndex = 3
        chkHobi4.Text = "Gaming"
        chkHobi4.UseVisualStyleBackColor = True
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Location = New Point(15, 89)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(74, 24)
        rbAdmin.TabIndex = 10
        rbAdmin.TabStop = True
        rbAdmin.Text = "Admin"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' chkHobi5
        ' 
        chkHobi5.AutoSize = True
        chkHobi5.Location = New Point(331, 30)
        chkHobi5.Name = "chkHobi5"
        chkHobi5.Size = New Size(92, 24)
        chkHobi5.TabIndex = 4
        chkHobi5.Text = "Olahraga"
        chkHobi5.UseVisualStyleBackColor = True
        ' 
        ' rbWakil
        ' 
        rbWakil.AutoSize = True
        rbWakil.Location = New Point(15, 59)
        rbWakil.Name = "rbWakil"
        rbWakil.Size = New Size(108, 24)
        rbWakil.TabIndex = 9
        rbWakil.TabStop = True
        rbWakil.Text = "Wakil Ketua"
        rbWakil.UseVisualStyleBackColor = True
        ' 
        ' chkHobi8
        ' 
        chkHobi8.AutoSize = True
        chkHobi8.Location = New Point(331, 116)
        chkHobi8.Name = "chkHobi8"
        chkHobi8.Size = New Size(92, 24)
        chkHobi8.TabIndex = 7
        chkHobi8.Text = "Fotografi"
        chkHobi8.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(15, 29)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(68, 24)
        rbKetua.TabIndex = 8
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' chkHobi6
        ' 
        chkHobi6.AutoSize = True
        chkHobi6.Location = New Point(331, 56)
        chkHobi6.Name = "chkHobi6"
        chkHobi6.Size = New Size(69, 24)
        chkHobi6.TabIndex = 5
        chkHobi6.Text = "Musik"
        chkHobi6.UseVisualStyleBackColor = True
        ' 
        ' chkHobi7
        ' 
        chkHobi7.AutoSize = True
        chkHobi7.Location = New Point(331, 86)
        chkHobi7.Name = "chkHobi7"
        chkHobi7.Size = New Size(97, 24)
        chkHobi7.TabIndex = 6
        chkHobi7.Text = "Membaca"
        chkHobi7.UseVisualStyleBackColor = True
        ' 
        ' pbFoto
        ' 
        pbFoto.BorderStyle = BorderStyle.FixedSingle
        pbFoto.Location = New Point(45, 34)
        pbFoto.Name = "pbFoto"
        pbFoto.Size = New Size(171, 247)
        pbFoto.TabIndex = 0
        pbFoto.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGoldenrodYellow
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 30)
        Panel1.TabIndex = 2
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(195, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(317, 25)
        Label9.TabIndex = 3
        Label9.Text = "Formulir Furi Samarinda Solid Solidd"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.paw
        PictureBox1.Location = New Point(12, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(20, 20)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkSalmon
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button2.Location = New Point(739, -19)
        Button2.Name = "Button2"
        Button2.Size = New Size(61, 67)
        Button2.TabIndex = 1
        Button2.Text = "X"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Silver
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button1.Location = New Point(682, -19)
        Button1.Name = "Button1"
        Button1.Size = New Size(61, 67)
        Button1.TabIndex = 0
        Button1.Text = "—"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(TabControl)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.None
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl.ResumeLayout(False)
        tpMain.ResumeLayout(False)
        tpMain.PerformLayout()
        tpKontak.ResumeLayout(False)
        tpKontak.PerformLayout()
        tpProfil.ResumeLayout(False)
        gbHobi.ResumeLayout(False)
        gbHobi.PerformLayout()
        CType(pbFoto, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl As TabControl
    Friend WithEvents tpMain As TabPage
    Friend WithEvents cbKomunitas As ComboBox
    Friend WithEvents rbPria As RadioButton
    Friend WithEvents dtpTglLahir As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents tpKontak As TabPage
    Friend WithEvents rbWanita As RadioButton
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents mtxtTelp As MaskedTextBox
    Friend WithEvents tpProfil As TabPage
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnSimpanCetak As Button
    Friend WithEvents gbHobi As GroupBox
    Friend WithEvents chkHobi8 As CheckBox
    Friend WithEvents chkHobi7 As CheckBox
    Friend WithEvents chkHobi6 As CheckBox
    Friend WithEvents chkHobi5 As CheckBox
    Friend WithEvents chkHobi4 As CheckBox
    Friend WithEvents chkHobi3 As CheckBox
    Friend WithEvents chkHobi2 As CheckBox
    Friend WithEvents bhkHobi1 As CheckBox
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbWakil As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
