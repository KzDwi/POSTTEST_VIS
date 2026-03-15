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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        txtAlamat = New TextBox()
        btnCetak = New Button()
        grupHobi = New GroupBox()
        cbGaming = New CheckBox()
        cbCoding = New CheckBox()
        cbFotography = New CheckBox()
        cbDrawing = New CheckBox()
        cbWriting = New CheckBox()
        cbFishing = New CheckBox()
        cbReading = New CheckBox()
        cbCrafting = New CheckBox()
        cbSinging = New CheckBox()
        cbEditing = New CheckBox()
        grupJK = New GroupBox()
        rbCowo = New RadioButton()
        rbCewe = New RadioButton()
        dtpLahir = New DateTimePicker()
        txtTelp = New TextBox()
        txtUmur = New TextBox()
        txtNama = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnBrowse = New Button()
        picProfil = New PictureBox()
        Panel1.SuspendLayout()
        grupHobi.SuspendLayout()
        grupJK.SuspendLayout()
        CType(picProfil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.Kaizen_Community2
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(txtAlamat)
        Panel1.Controls.Add(btnCetak)
        Panel1.Controls.Add(grupHobi)
        Panel1.Controls.Add(grupJK)
        Panel1.Controls.Add(dtpLahir)
        Panel1.Controls.Add(txtTelp)
        Panel1.Controls.Add(txtUmur)
        Panel1.Controls.Add(txtNama)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnBrowse)
        Panel1.Controls.Add(picProfil)
        Panel1.Location = New Point(-2, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(804, 454)
        Panel1.TabIndex = 0
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(202, 180)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(335, 23)
        txtAlamat.TabIndex = 15
        ' 
        ' btnCetak
        ' 
        btnCetak.Font = New Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCetak.Location = New Point(30, 417)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(507, 23)
        btnCetak.TabIndex = 16
        btnCetak.Text = "Buat Kartu"
        ' 
        ' grupHobi
        ' 
        grupHobi.BackColor = Color.LightSkyBlue
        grupHobi.Controls.Add(cbGaming)
        grupHobi.Controls.Add(cbCoding)
        grupHobi.Controls.Add(cbFotography)
        grupHobi.Controls.Add(cbDrawing)
        grupHobi.Controls.Add(cbWriting)
        grupHobi.Controls.Add(cbFishing)
        grupHobi.Controls.Add(cbReading)
        grupHobi.Controls.Add(cbCrafting)
        grupHobi.Controls.Add(cbSinging)
        grupHobi.Controls.Add(cbEditing)
        grupHobi.Font = New Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grupHobi.ForeColor = Color.White
        grupHobi.Location = New Point(278, 234)
        grupHobi.Name = "grupHobi"
        grupHobi.Size = New Size(259, 177)
        grupHobi.TabIndex = 17
        grupHobi.TabStop = False
        grupHobi.Text = "Macam - Macam Hobi"
        ' 
        ' cbGaming
        ' 
        cbGaming.Location = New Point(6, 23)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(104, 24)
        cbGaming.TabIndex = 0
        cbGaming.Text = "Gaming"
        ' 
        ' cbCoding
        ' 
        cbCoding.Location = New Point(147, 98)
        cbCoding.Name = "cbCoding"
        cbCoding.Size = New Size(104, 24)
        cbCoding.TabIndex = 1
        cbCoding.Text = "Coding"
        ' 
        ' cbFotography
        ' 
        cbFotography.Location = New Point(147, 48)
        cbFotography.Name = "cbFotography"
        cbFotography.Size = New Size(104, 24)
        cbFotography.TabIndex = 2
        cbFotography.Text = "Fotography"
        ' 
        ' cbDrawing
        ' 
        cbDrawing.Location = New Point(6, 98)
        cbDrawing.Name = "cbDrawing"
        cbDrawing.Size = New Size(104, 24)
        cbDrawing.TabIndex = 3
        cbDrawing.Text = "Drawing"
        ' 
        ' cbWriting
        ' 
        cbWriting.Location = New Point(6, 123)
        cbWriting.Name = "cbWriting"
        cbWriting.Size = New Size(104, 24)
        cbWriting.TabIndex = 4
        cbWriting.Text = "Writing"
        ' 
        ' cbFishing
        ' 
        cbFishing.Location = New Point(147, 123)
        cbFishing.Name = "cbFishing"
        cbFishing.Size = New Size(104, 24)
        cbFishing.TabIndex = 5
        cbFishing.Text = "Fishing"
        ' 
        ' cbReading
        ' 
        cbReading.Location = New Point(6, 72)
        cbReading.Name = "cbReading"
        cbReading.Size = New Size(104, 24)
        cbReading.TabIndex = 6
        cbReading.Text = "Reading"
        ' 
        ' cbCrafting
        ' 
        cbCrafting.Location = New Point(147, 72)
        cbCrafting.Name = "cbCrafting"
        cbCrafting.Size = New Size(104, 24)
        cbCrafting.TabIndex = 7
        cbCrafting.Text = "Crafting"
        ' 
        ' cbSinging
        ' 
        cbSinging.Location = New Point(6, 47)
        cbSinging.Name = "cbSinging"
        cbSinging.Size = New Size(104, 24)
        cbSinging.TabIndex = 8
        cbSinging.Text = "Singing"
        ' 
        ' cbEditing
        ' 
        cbEditing.Location = New Point(147, 22)
        cbEditing.Name = "cbEditing"
        cbEditing.Size = New Size(104, 24)
        cbEditing.TabIndex = 9
        cbEditing.Text = "Editing"
        ' 
        ' grupJK
        ' 
        grupJK.BackColor = Color.LightSkyBlue
        grupJK.Controls.Add(rbCowo)
        grupJK.Controls.Add(rbCewe)
        grupJK.Font = New Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grupJK.ForeColor = Color.White
        grupJK.Location = New Point(30, 234)
        grupJK.Name = "grupJK"
        grupJK.Size = New Size(224, 177)
        grupJK.TabIndex = 18
        grupJK.TabStop = False
        grupJK.Text = "Jenis Kelamin"
        ' 
        ' rbCowo
        ' 
        rbCowo.Location = New Point(6, 22)
        rbCowo.Name = "rbCowo"
        rbCowo.Size = New Size(104, 24)
        rbCowo.TabIndex = 0
        rbCowo.Text = "Laki - Laki"
        ' 
        ' rbCewe
        ' 
        rbCewe.Location = New Point(6, 47)
        rbCewe.Name = "rbCewe"
        rbCewe.Size = New Size(104, 24)
        rbCewe.TabIndex = 1
        rbCewe.Text = "Perempuan"
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Location = New Point(202, 109)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(335, 23)
        dtpLahir.TabIndex = 19
        ' 
        ' txtTelp
        ' 
        txtTelp.Location = New Point(202, 146)
        txtTelp.Name = "txtTelp"
        txtTelp.Size = New Size(337, 23)
        txtTelp.TabIndex = 20
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(202, 71)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(335, 23)
        txtUmur.TabIndex = 21
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(202, 36)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(335, 23)
        txtNama.TabIndex = 22
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.LightSkyBlue
        Label5.BorderStyle = BorderStyle.Fixed3D
        Label5.Font = New Font("Sitka Text", 9F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(30, 180)
        Label5.Name = "Label5"
        Label5.Size = New Size(110, 23)
        Label5.TabIndex = 23
        Label5.Text = "Alamat :"
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.LightSkyBlue
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.Font = New Font("Sitka Text", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(31, 146)
        Label4.Name = "Label4"
        Label4.Size = New Size(109, 23)
        Label4.TabIndex = 24
        Label4.Text = "Nomor Telepon :"
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.LightSkyBlue
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Font = New Font("Sitka Text", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(30, 112)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 23)
        Label3.TabIndex = 25
        Label3.Text = "Tanggal Lahir :"
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.LightSkyBlue
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Font = New Font("Sitka Text", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(30, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 23)
        Label2.TabIndex = 26
        Label2.Text = "Umur :"
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.LightSkyBlue
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Font = New Font("Sitka Text", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(30, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 23)
        Label1.TabIndex = 27
        Label1.Text = "Nama :"
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Font = New Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBrowse.Location = New Point(571, 417)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(219, 24)
        btnBrowse.TabIndex = 2
        btnBrowse.Text = "Browse"
        ' 
        ' picProfil
        ' 
        picProfil.BackColor = Color.LightSkyBlue
        picProfil.Location = New Point(571, 35)
        picProfil.Name = "picProfil"
        picProfil.Size = New Size(219, 377)
        picProfil.SizeMode = PictureBoxSizeMode.StretchImage
        picProfil.TabIndex = 14
        picProfil.TabStop = False
        ' 
        ' Form1
        ' 
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        grupHobi.ResumeLayout(False)
        grupJK.ResumeLayout(False)
        CType(picProfil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBrowse As Button
    Friend WithEvents picProfil As PictureBox
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents grupHobi As GroupBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents cbFotography As CheckBox
    Friend WithEvents cbDrawing As CheckBox
    Friend WithEvents cbWriting As CheckBox
    Friend WithEvents cbFishing As CheckBox
    Friend WithEvents cbReading As CheckBox
    Friend WithEvents cbCrafting As CheckBox
    Friend WithEvents cbSinging As CheckBox
    Friend WithEvents cbEditing As CheckBox
    Friend WithEvents grupJK As GroupBox
    Friend WithEvents rbCowo As RadioButton
    Friend WithEvents rbCewe As RadioButton
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label

End Class
