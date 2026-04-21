<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        AkuariumToolStripMenuItem = New ToolStripMenuItem()
        IkanToolStripMenuItem = New ToolStripMenuItem()
        CariUangToolStripMenuItem = New ToolStripMenuItem()
        MisiToolStripMenuItem = New ToolStripMenuItem()
        CheatsToolStripMenuItem = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        ProgressBar1 = New ProgressBar()
        lblKoinBesar = New Label()
        btnClicker = New Button()
        TabPage2 = New TabPage()
        btnUpdateAkuarium = New Button()
        cbKapasitas = New ComboBox()
        dgvAkuarium = New DataGridView()
        ID_AQ = New DataGridViewTextBoxColumn()
        NamaAkuarium = New DataGridViewTextBoxColumn()
        Kapasitas = New DataGridViewTextBoxColumn()
        Sisa = New DataGridViewTextBoxColumn()
        btnHapusAkuarium = New Button()
        btnTambahAkuarium = New Button()
        txtNamaAkuarium = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        TabPage3 = New TabPage()
        btnUpdateIkan = New Button()
        cbUkuran = New ComboBox()
        dgvIkan = New DataGridView()
        ID_Ikan = New DataGridViewTextBoxColumn()
        Nama_Ikan = New DataGridViewTextBoxColumn()
        NamaAQ = New DataGridViewTextBoxColumn()
        Ukuran = New DataGridViewTextBoxColumn()
        btnHapusIkan = New Button()
        btnBeliIkan = New Button()
        cbPilihAkuarium = New ComboBox()
        txtNamaIkan = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Panel1 = New Panel()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        btnExit = New Button()
        btnMinimize = New Button()
        lblStatusKoin = New Label()
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        CType(dgvAkuarium, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        CType(dgvIkan, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.SandyBrown
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {AkuariumToolStripMenuItem, IkanToolStripMenuItem, CariUangToolStripMenuItem, MisiToolStripMenuItem, CheatsToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 40)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(8, 3, 0, 3)
        MenuStrip1.Size = New Size(391, 30)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AkuariumToolStripMenuItem
        ' 
        AkuariumToolStripMenuItem.BackColor = Color.SandyBrown
        AkuariumToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText
        AkuariumToolStripMenuItem.Name = "AkuariumToolStripMenuItem"
        AkuariumToolStripMenuItem.Size = New Size(86, 24)
        AkuariumToolStripMenuItem.Text = "Akuarium"
        ' 
        ' IkanToolStripMenuItem
        ' 
        IkanToolStripMenuItem.Name = "IkanToolStripMenuItem"
        IkanToolStripMenuItem.Size = New Size(50, 24)
        IkanToolStripMenuItem.Text = "Ikan"
        ' 
        ' CariUangToolStripMenuItem
        ' 
        CariUangToolStripMenuItem.Name = "CariUangToolStripMenuItem"
        CariUangToolStripMenuItem.Size = New Size(88, 24)
        CariUangToolStripMenuItem.Text = "Cari Uang"
        ' 
        ' MisiToolStripMenuItem
        ' 
        MisiToolStripMenuItem.Name = "MisiToolStripMenuItem"
        MisiToolStripMenuItem.Size = New Size(90, 24)
        MisiToolStripMenuItem.Text = "Misi (WIP)"
        ' 
        ' CheatsToolStripMenuItem
        ' 
        CheatsToolStripMenuItem.Name = "CheatsToolStripMenuItem"
        CheatsToolStripMenuItem.Size = New Size(67, 24)
        CheatsToolStripMenuItem.Text = "Cheats"
        ' 
        ' TabControl1
        ' 
        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.DrawMode = TabDrawMode.OwnerDrawFixed
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.Location = New Point(0, 70)
        TabControl1.Margin = New Padding(4, 5, 4, 5)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1024, 712)
        TabControl1.SizeMode = TabSizeMode.Fixed
        TabControl1.TabIndex = 2
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = SystemColors.Control
        TabPage1.BackgroundImage = My.Resources.Resources.otherbg
        TabPage1.BackgroundImageLayout = ImageLayout.Stretch
        TabPage1.Controls.Add(ProgressBar1)
        TabPage1.Controls.Add(lblKoinBesar)
        TabPage1.Controls.Add(btnClicker)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Margin = New Padding(4, 5, 4, 5)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(4, 5, 4, 5)
        TabPage1.Size = New Size(1016, 684)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Dapat Koin"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(8, 3)
        ProgressBar1.MarqueeAnimationSpeed = 0
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(1000, 15)
        ProgressBar1.TabIndex = 2
        ' 
        ' lblKoinBesar
        ' 
        lblKoinBesar.BackColor = Color.Transparent
        lblKoinBesar.Font = New Font("Microsoft Sans Serif", 48.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblKoinBesar.Location = New Point(137, 99)
        lblKoinBesar.Margin = New Padding(4, 0, 4, 0)
        lblKoinBesar.Name = "lblKoinBesar"
        lblKoinBesar.Size = New Size(747, 129)
        lblKoinBesar.TabIndex = 1
        lblKoinBesar.Text = "0"
        lblKoinBesar.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnClicker
        ' 
        btnClicker.BackColor = Color.Transparent
        btnClicker.BackgroundImage = My.Resources.Resources.button
        btnClicker.BackgroundImageLayout = ImageLayout.Stretch
        btnClicker.FlatAppearance.BorderSize = 0
        btnClicker.FlatStyle = FlatStyle.Flat
        btnClicker.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClicker.Location = New Point(382, 289)
        btnClicker.Margin = New Padding(4, 5, 4, 5)
        btnClicker.Name = "btnClicker"
        btnClicker.Size = New Size(250, 120)
        btnClicker.TabIndex = 0
        btnClicker.Text = "Klik Cari Koin!"
        btnClicker.UseVisualStyleBackColor = False
        ' 
        ' TabPage2
        ' 
        TabPage2.BackgroundImage = My.Resources.Resources.download
        TabPage2.BackgroundImageLayout = ImageLayout.Stretch
        TabPage2.Controls.Add(btnUpdateAkuarium)
        TabPage2.Controls.Add(cbKapasitas)
        TabPage2.Controls.Add(dgvAkuarium)
        TabPage2.Controls.Add(btnHapusAkuarium)
        TabPage2.Controls.Add(btnTambahAkuarium)
        TabPage2.Controls.Add(txtNamaAkuarium)
        TabPage2.Controls.Add(Label2)
        TabPage2.Controls.Add(Label1)
        TabPage2.Location = New Point(4, 5)
        TabPage2.Margin = New Padding(4, 5, 4, 5)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(4, 5, 4, 5)
        TabPage2.Size = New Size(1016, 703)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kelola Akuarium"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateAkuarium
        ' 
        btnUpdateAkuarium.BackColor = Color.Transparent
        btnUpdateAkuarium.BackgroundImage = My.Resources.Resources.thinbtn
        btnUpdateAkuarium.BackgroundImageLayout = ImageLayout.Stretch
        btnUpdateAkuarium.FlatAppearance.BorderSize = 0
        btnUpdateAkuarium.FlatStyle = FlatStyle.Flat
        btnUpdateAkuarium.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdateAkuarium.Location = New Point(831, 29)
        btnUpdateAkuarium.Margin = New Padding(4, 5, 4, 5)
        btnUpdateAkuarium.Name = "btnUpdateAkuarium"
        btnUpdateAkuarium.Size = New Size(165, 40)
        btnUpdateAkuarium.TabIndex = 8
        btnUpdateAkuarium.Text = "Update Akuarium"
        btnUpdateAkuarium.UseVisualStyleBackColor = False
        ' 
        ' cbKapasitas
        ' 
        cbKapasitas.DropDownStyle = ComboBoxStyle.DropDownList
        cbKapasitas.FormattingEnabled = True
        cbKapasitas.Items.AddRange(New Object() {"Kecil (10 Size)", "Sedang (50 Size)", "Besar (100 Size)", "Sangat Besar (500 Size)"})
        cbKapasitas.Location = New Point(167, 97)
        cbKapasitas.Name = "cbKapasitas"
        cbKapasitas.Size = New Size(151, 28)
        cbKapasitas.TabIndex = 7
        ' 
        ' dgvAkuarium
        ' 
        dgvAkuarium.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAkuarium.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvAkuarium.BackgroundColor = Color.Wheat
        dgvAkuarium.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAkuarium.Columns.AddRange(New DataGridViewColumn() {ID_AQ, NamaAkuarium, Kapasitas, Sisa})
        dgvAkuarium.Location = New Point(31, 228)
        dgvAkuarium.Margin = New Padding(4, 5, 4, 5)
        dgvAkuarium.Name = "dgvAkuarium"
        dgvAkuarium.RowHeadersWidth = 51
        dgvAkuarium.Size = New Size(954, 402)
        dgvAkuarium.TabIndex = 6
        ' 
        ' ID_AQ
        ' 
        ID_AQ.HeaderText = "ID Aquarium"
        ID_AQ.MinimumWidth = 6
        ID_AQ.Name = "ID_AQ"
        ID_AQ.ReadOnly = True
        ' 
        ' NamaAkuarium
        ' 
        NamaAkuarium.HeaderText = "Nama"
        NamaAkuarium.MinimumWidth = 6
        NamaAkuarium.Name = "NamaAkuarium"
        NamaAkuarium.ReadOnly = True
        ' 
        ' Kapasitas
        ' 
        Kapasitas.HeaderText = "Kapasitas"
        Kapasitas.MinimumWidth = 6
        Kapasitas.Name = "Kapasitas"
        Kapasitas.ReadOnly = True
        ' 
        ' Sisa
        ' 
        Sisa.HeaderText = "Sisa"
        Sisa.MinimumWidth = 6
        Sisa.Name = "Sisa"
        Sisa.ReadOnly = True
        ' 
        ' btnHapusAkuarium
        ' 
        btnHapusAkuarium.BackColor = Color.Transparent
        btnHapusAkuarium.BackgroundImage = My.Resources.Resources.thinbtn
        btnHapusAkuarium.BackgroundImageLayout = ImageLayout.Stretch
        btnHapusAkuarium.FlatAppearance.BorderSize = 0
        btnHapusAkuarium.FlatStyle = FlatStyle.Flat
        btnHapusAkuarium.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHapusAkuarium.Location = New Point(626, 152)
        btnHapusAkuarium.Margin = New Padding(4, 5, 4, 5)
        btnHapusAkuarium.Name = "btnHapusAkuarium"
        btnHapusAkuarium.Size = New Size(165, 40)
        btnHapusAkuarium.TabIndex = 5
        btnHapusAkuarium.Text = "Hapus Akuarium"
        btnHapusAkuarium.UseVisualStyleBackColor = False
        ' 
        ' btnTambahAkuarium
        ' 
        btnTambahAkuarium.BackColor = Color.Transparent
        btnTambahAkuarium.BackgroundImage = My.Resources.Resources.thinbtn
        btnTambahAkuarium.BackgroundImageLayout = ImageLayout.Stretch
        btnTambahAkuarium.FlatAppearance.BorderSize = 0
        btnTambahAkuarium.FlatStyle = FlatStyle.Flat
        btnTambahAkuarium.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTambahAkuarium.Location = New Point(176, 152)
        btnTambahAkuarium.Margin = New Padding(4, 5, 4, 5)
        btnTambahAkuarium.Name = "btnTambahAkuarium"
        btnTambahAkuarium.Size = New Size(255, 40)
        btnTambahAkuarium.TabIndex = 4
        btnTambahAkuarium.Text = "Beli (100 Koin)"
        btnTambahAkuarium.UseVisualStyleBackColor = False
        ' 
        ' txtNamaAkuarium
        ' 
        txtNamaAkuarium.Location = New Point(167, 45)
        txtNamaAkuarium.Margin = New Padding(4, 5, 4, 5)
        txtNamaAkuarium.Name = "txtNamaAkuarium"
        txtNamaAkuarium.PlaceholderText = "Masukkan Nama atau ID Akuarium"
        txtNamaAkuarium.Size = New Size(624, 27)
        txtNamaAkuarium.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label2.Location = New Point(27, 105)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(133, 20)
        Label2.TabIndex = 1
        Label2.Text = "Ukuran Akuarium"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label1.Location = New Point(27, 49)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nama Akuarium"
        ' 
        ' TabPage3
        ' 
        TabPage3.BackgroundImage = My.Resources.Resources.download
        TabPage3.BackgroundImageLayout = ImageLayout.Stretch
        TabPage3.Controls.Add(btnUpdateIkan)
        TabPage3.Controls.Add(cbUkuran)
        TabPage3.Controls.Add(dgvIkan)
        TabPage3.Controls.Add(btnHapusIkan)
        TabPage3.Controls.Add(btnBeliIkan)
        TabPage3.Controls.Add(cbPilihAkuarium)
        TabPage3.Controls.Add(txtNamaIkan)
        TabPage3.Controls.Add(Label5)
        TabPage3.Controls.Add(Label4)
        TabPage3.Controls.Add(Label3)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Margin = New Padding(4, 5, 4, 5)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(1016, 684)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Kelola Ikan"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateIkan
        ' 
        btnUpdateIkan.BackColor = Color.Transparent
        btnUpdateIkan.BackgroundImage = My.Resources.Resources.thinbtn
        btnUpdateIkan.BackgroundImageLayout = ImageLayout.Stretch
        btnUpdateIkan.FlatAppearance.BorderSize = 0
        btnUpdateIkan.FlatStyle = FlatStyle.Flat
        btnUpdateIkan.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdateIkan.Location = New Point(822, 32)
        btnUpdateIkan.Margin = New Padding(4, 5, 4, 5)
        btnUpdateIkan.Name = "btnUpdateIkan"
        btnUpdateIkan.Size = New Size(165, 40)
        btnUpdateIkan.TabIndex = 10
        btnUpdateIkan.Text = "Update Ikan"
        btnUpdateIkan.UseVisualStyleBackColor = False
        ' 
        ' cbUkuran
        ' 
        cbUkuran.DropDownStyle = ComboBoxStyle.DropDownList
        cbUkuran.FormattingEnabled = True
        cbUkuran.Items.AddRange(New Object() {"Kecil (1 Size)", "Sedang (10 Size)", "Besar (25 Size)", "Sangat Besar (350 Size)"})
        cbUkuran.Location = New Point(163, 142)
        cbUkuran.Name = "cbUkuran"
        cbUkuran.Size = New Size(261, 28)
        cbUkuran.TabIndex = 9
        ' 
        ' dgvIkan
        ' 
        dgvIkan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvIkan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvIkan.BackgroundColor = Color.Wheat
        dgvIkan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvIkan.Columns.AddRange(New DataGridViewColumn() {ID_Ikan, Nama_Ikan, NamaAQ, Ukuran})
        dgvIkan.Location = New Point(32, 260)
        dgvIkan.Margin = New Padding(4, 5, 4, 5)
        dgvIkan.Name = "dgvIkan"
        dgvIkan.RowHeadersWidth = 51
        dgvIkan.Size = New Size(955, 368)
        dgvIkan.TabIndex = 8
        ' 
        ' ID_Ikan
        ' 
        ID_Ikan.HeaderText = "ID Ikan"
        ID_Ikan.MinimumWidth = 6
        ID_Ikan.Name = "ID_Ikan"
        ID_Ikan.ReadOnly = True
        ' 
        ' Nama_Ikan
        ' 
        Nama_Ikan.HeaderText = "Nama Ikan"
        Nama_Ikan.MinimumWidth = 6
        Nama_Ikan.Name = "Nama_Ikan"
        Nama_Ikan.ReadOnly = True
        ' 
        ' NamaAQ
        ' 
        NamaAQ.HeaderText = "Akuarium"
        NamaAQ.MinimumWidth = 6
        NamaAQ.Name = "NamaAQ"
        NamaAQ.ReadOnly = True
        ' 
        ' Ukuran
        ' 
        Ukuran.HeaderText = "Ukuran"
        Ukuran.MinimumWidth = 6
        Ukuran.Name = "Ukuran"
        Ukuran.ReadOnly = True
        ' 
        ' btnHapusIkan
        ' 
        btnHapusIkan.BackColor = Color.Transparent
        btnHapusIkan.BackgroundImage = My.Resources.Resources.thinbtn
        btnHapusIkan.BackgroundImageLayout = ImageLayout.Stretch
        btnHapusIkan.FlatAppearance.BorderSize = 0
        btnHapusIkan.FlatStyle = FlatStyle.Flat
        btnHapusIkan.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHapusIkan.Location = New Point(647, 194)
        btnHapusIkan.Margin = New Padding(4, 5, 4, 5)
        btnHapusIkan.Name = "btnHapusIkan"
        btnHapusIkan.Size = New Size(165, 40)
        btnHapusIkan.TabIndex = 7
        btnHapusIkan.Text = "Hapus Ikan"
        btnHapusIkan.UseVisualStyleBackColor = False
        ' 
        ' btnBeliIkan
        ' 
        btnBeliIkan.BackColor = Color.Transparent
        btnBeliIkan.BackgroundImage = CType(resources.GetObject("btnBeliIkan.BackgroundImage"), Image)
        btnBeliIkan.BackgroundImageLayout = ImageLayout.Stretch
        btnBeliIkan.FlatAppearance.BorderSize = 0
        btnBeliIkan.FlatStyle = FlatStyle.Flat
        btnBeliIkan.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBeliIkan.Location = New Point(240, 194)
        btnBeliIkan.Margin = New Padding(4, 5, 4, 5)
        btnBeliIkan.Name = "btnBeliIkan"
        btnBeliIkan.Size = New Size(256, 40)
        btnBeliIkan.TabIndex = 6
        btnBeliIkan.Text = "Beli Ikan (25 Koin)"
        btnBeliIkan.UseVisualStyleBackColor = False
        ' 
        ' cbPilihAkuarium
        ' 
        cbPilihAkuarium.DropDownStyle = ComboBoxStyle.DropDownList
        cbPilihAkuarium.FormattingEnabled = True
        cbPilihAkuarium.Location = New Point(163, 32)
        cbPilihAkuarium.Margin = New Padding(4, 5, 4, 5)
        cbPilihAkuarium.Name = "cbPilihAkuarium"
        cbPilihAkuarium.Size = New Size(623, 28)
        cbPilihAkuarium.TabIndex = 5
        ' 
        ' txtNamaIkan
        ' 
        txtNamaIkan.Location = New Point(163, 85)
        txtNamaIkan.Margin = New Padding(4, 5, 4, 5)
        txtNamaIkan.Name = "txtNamaIkan"
        txtNamaIkan.PlaceholderText = "Masukkan Nama Ikan atau ID Ikan"
        txtNamaIkan.Size = New Size(623, 27)
        txtNamaIkan.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label5.Location = New Point(28, 37)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(112, 20)
        Label5.TabIndex = 2
        Label5.Text = "Pilih Akuarium"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label4.Location = New Point(28, 145)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 20)
        Label4.TabIndex = 1
        Label4.Text = "Ukuran"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label3.Location = New Point(28, 89)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 20)
        Label3.TabIndex = 0
        Label3.Text = "Nama Ikan"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SandyBrown
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(btnExit)
        Panel1.Controls.Add(btnMinimize)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1024, 35)
        Panel1.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(56, 3)
        Label6.Name = "Label6"
        Label6.Size = New Size(156, 25)
        Label6.TabIndex = 6
        Label6.Text = "MyAquarium Lite"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.aquarium_4374206
        PictureBox1.Location = New Point(12, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(24, 24)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.IndianRed
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(952, -15)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(72, 70)
        btnExit.TabIndex = 5
        btnExit.Text = "X"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnMinimize
        ' 
        btnMinimize.BackColor = Color.Peru
        btnMinimize.FlatAppearance.BorderSize = 0
        btnMinimize.FlatStyle = FlatStyle.Flat
        btnMinimize.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMinimize.Location = New Point(885, -15)
        btnMinimize.Name = "btnMinimize"
        btnMinimize.Size = New Size(72, 70)
        btnMinimize.TabIndex = 4
        btnMinimize.Text = "—"
        btnMinimize.UseVisualStyleBackColor = False
        ' 
        ' lblStatusKoin
        ' 
        lblStatusKoin.AutoSize = True
        lblStatusKoin.Font = New Font("Segoe UI", 9.8F, FontStyle.Bold)
        lblStatusKoin.Location = New Point(11, 784)
        lblStatusKoin.Name = "lblStatusKoin"
        lblStatusKoin.Size = New Size(124, 23)
        lblStatusKoin.TabIndex = 4
        lblStatusKoin.Text = "Jumlah Koin : "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SandyBrown
        ClientSize = New Size(1024, 808)
        Controls.Add(lblStatusKoin)
        Controls.Add(Panel1)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        ForeColor = SystemColors.ActiveCaptionText
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sistem Wisata Akuarium"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(dgvAkuarium, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        CType(dgvIkan, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AkuariumToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents lblKoinBesar As System.Windows.Forms.Label
    Friend WithEvents btnClicker As System.Windows.Forms.Button
    Friend WithEvents dgvAkuarium As System.Windows.Forms.DataGridView
    Friend WithEvents btnHapusAkuarium As System.Windows.Forms.Button
    Friend WithEvents btnTambahAkuarium As System.Windows.Forms.Button
    Friend WithEvents txtNamaAkuarium As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvIkan As System.Windows.Forms.DataGridView
    Friend WithEvents btnHapusIkan As System.Windows.Forms.Button
    Friend WithEvents btnBeliIkan As System.Windows.Forms.Button
    Friend WithEvents cbPilihAkuarium As System.Windows.Forms.ComboBox
    Friend WithEvents txtNamaIkan As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbUkuran As ComboBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbKapasitas As ComboBox
    Friend WithEvents IkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CariUangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MisiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheatsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblStatusKoin As Label
    Friend WithEvents btnUpdateAkuarium As Button
    Friend WithEvents btnUpdateIkan As Button
    Friend WithEvents ID_AQ As DataGridViewTextBoxColumn
    Friend WithEvents NamaAkuarium As DataGridViewTextBoxColumn
    Friend WithEvents Kapasitas As DataGridViewTextBoxColumn
    Friend WithEvents Sisa As DataGridViewTextBoxColumn
    Friend WithEvents ID_Ikan As DataGridViewTextBoxColumn
    Friend WithEvents Nama_Ikan As DataGridViewTextBoxColumn
    Friend WithEvents NamaAQ As DataGridViewTextBoxColumn
    Friend WithEvents Ukuran As DataGridViewTextBoxColumn
End Class