<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        lblTitle = New Label()
        btnExit = New Button()
        TabControl1 = New TabControl()
        tabAkuarium = New TabPage()
        btnSimpanAkuarium = New Button()
        btnCancelAkuarium = New Button()
        cbKapasitasBaru = New ComboBox()
        txtNamaBaru = New TextBox()
        tabIkan = New TabPage()
        btnSimpanIkan = New Button()
        cbUkuranBaru = New ComboBox()
        btnCancelIkan = New Button()
        txtNamaIkanBaru = New TextBox()
        Panel1.SuspendLayout()
        TabControl1.SuspendLayout()
        tabAkuarium.SuspendLayout()
        tabIkan.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SandyBrown
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(lblTitle)
        Panel1.Controls.Add(btnExit)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(600, 30)
        Panel1.TabIndex = 1
        ' 
        ' lblTitle
        ' 
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(33, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(452, 25)
        lblTitle.TabIndex = 7
        lblTitle.Text = "Update Akuarium"
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.IndianRed
        btnExit.BackgroundImageLayout = ImageLayout.Stretch
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(528, -24)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(72, 70)
        btnExit.TabIndex = 7
        btnExit.Text = "X"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tabAkuarium)
        TabControl1.Controls.Add(tabIkan)
        TabControl1.DrawMode = TabDrawMode.OwnerDrawFixed
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.Location = New Point(0, 28)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(600, 353)
        TabControl1.TabIndex = 2
        ' 
        ' tabAkuarium
        ' 
        tabAkuarium.BackgroundImage = My.Resources.Resources.download
        tabAkuarium.BackgroundImageLayout = ImageLayout.Stretch
        tabAkuarium.Controls.Add(btnSimpanAkuarium)
        tabAkuarium.Controls.Add(btnCancelAkuarium)
        tabAkuarium.Controls.Add(cbKapasitasBaru)
        tabAkuarium.Controls.Add(txtNamaBaru)
        tabAkuarium.Location = New Point(4, 29)
        tabAkuarium.Name = "tabAkuarium"
        tabAkuarium.Padding = New Padding(3)
        tabAkuarium.Size = New Size(592, 320)
        tabAkuarium.TabIndex = 0
        tabAkuarium.Text = "TabPage1"
        tabAkuarium.UseVisualStyleBackColor = True
        ' 
        ' btnSimpanAkuarium
        ' 
        btnSimpanAkuarium.BackColor = Color.Transparent
        btnSimpanAkuarium.BackgroundImage = My.Resources.Resources.thinbtn
        btnSimpanAkuarium.BackgroundImageLayout = ImageLayout.Stretch
        btnSimpanAkuarium.FlatAppearance.BorderSize = 0
        btnSimpanAkuarium.FlatStyle = FlatStyle.Flat
        btnSimpanAkuarium.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpanAkuarium.Location = New Point(321, 154)
        btnSimpanAkuarium.Margin = New Padding(4, 5, 4, 5)
        btnSimpanAkuarium.Name = "btnSimpanAkuarium"
        btnSimpanAkuarium.Size = New Size(179, 40)
        btnSimpanAkuarium.TabIndex = 11
        btnSimpanAkuarium.Text = "Simpan Update"
        btnSimpanAkuarium.UseVisualStyleBackColor = False
        ' 
        ' btnCancelAkuarium
        ' 
        btnCancelAkuarium.BackColor = Color.Transparent
        btnCancelAkuarium.BackgroundImage = My.Resources.Resources.thinbtn
        btnCancelAkuarium.BackgroundImageLayout = ImageLayout.Stretch
        btnCancelAkuarium.FlatAppearance.BorderSize = 0
        btnCancelAkuarium.FlatStyle = FlatStyle.Flat
        btnCancelAkuarium.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancelAkuarium.Location = New Point(58, 154)
        btnCancelAkuarium.Margin = New Padding(4, 5, 4, 5)
        btnCancelAkuarium.Name = "btnCancelAkuarium"
        btnCancelAkuarium.Size = New Size(165, 40)
        btnCancelAkuarium.TabIndex = 10
        btnCancelAkuarium.Text = "Batal Update"
        btnCancelAkuarium.UseVisualStyleBackColor = False
        ' 
        ' cbKapasitasBaru
        ' 
        cbKapasitasBaru.DropDownStyle = ComboBoxStyle.DropDownList
        cbKapasitasBaru.FormattingEnabled = True
        cbKapasitasBaru.Items.AddRange(New Object() {"Kecil (10 Size)", "Sedang (50 Size)", "Besar (100 Size)", "Sangat Besar (500 Size)"})
        cbKapasitasBaru.Location = New Point(29, 77)
        cbKapasitasBaru.Name = "cbKapasitasBaru"
        cbKapasitasBaru.Size = New Size(151, 28)
        cbKapasitasBaru.TabIndex = 9
        ' 
        ' txtNamaBaru
        ' 
        txtNamaBaru.Location = New Point(29, 25)
        txtNamaBaru.Margin = New Padding(4, 5, 4, 5)
        txtNamaBaru.Name = "txtNamaBaru"
        txtNamaBaru.PlaceholderText = "Masukkan Nama Akuarium Baru"
        txtNamaBaru.Size = New Size(497, 27)
        txtNamaBaru.TabIndex = 8
        ' 
        ' tabIkan
        ' 
        tabIkan.BackgroundImage = My.Resources.Resources.download
        tabIkan.BackgroundImageLayout = ImageLayout.Stretch
        tabIkan.Controls.Add(btnSimpanIkan)
        tabIkan.Controls.Add(cbUkuranBaru)
        tabIkan.Controls.Add(btnCancelIkan)
        tabIkan.Controls.Add(txtNamaIkanBaru)
        tabIkan.Location = New Point(4, 5)
        tabIkan.Name = "tabIkan"
        tabIkan.Padding = New Padding(3)
        tabIkan.Size = New Size(592, 344)
        tabIkan.TabIndex = 1
        tabIkan.Text = "TabPage2"
        tabIkan.UseVisualStyleBackColor = True
        ' 
        ' btnSimpanIkan
        ' 
        btnSimpanIkan.BackColor = Color.Transparent
        btnSimpanIkan.BackgroundImage = My.Resources.Resources.thinbtn
        btnSimpanIkan.BackgroundImageLayout = ImageLayout.Stretch
        btnSimpanIkan.FlatAppearance.BorderSize = 0
        btnSimpanIkan.FlatStyle = FlatStyle.Flat
        btnSimpanIkan.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpanIkan.Location = New Point(340, 165)
        btnSimpanIkan.Margin = New Padding(4, 5, 4, 5)
        btnSimpanIkan.Name = "btnSimpanIkan"
        btnSimpanIkan.Size = New Size(165, 40)
        btnSimpanIkan.TabIndex = 13
        btnSimpanIkan.Text = "Simpan Update"
        btnSimpanIkan.UseVisualStyleBackColor = False
        ' 
        ' cbUkuranBaru
        ' 
        cbUkuranBaru.DropDownStyle = ComboBoxStyle.DropDownList
        cbUkuranBaru.FormattingEnabled = True
        cbUkuranBaru.Items.AddRange(New Object() {"Kecil (1 Size)", "Sedang (10 Size)", "Besar (25 Size)", "Sangat Besar (350 Size)"})
        cbUkuranBaru.Location = New Point(29, 82)
        cbUkuranBaru.Name = "cbUkuranBaru"
        cbUkuranBaru.Size = New Size(261, 28)
        cbUkuranBaru.TabIndex = 12
        ' 
        ' btnCancelIkan
        ' 
        btnCancelIkan.BackColor = Color.Transparent
        btnCancelIkan.BackgroundImage = My.Resources.Resources.thinbtn
        btnCancelIkan.BackgroundImageLayout = ImageLayout.Stretch
        btnCancelIkan.FlatAppearance.BorderSize = 0
        btnCancelIkan.FlatStyle = FlatStyle.Flat
        btnCancelIkan.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancelIkan.Location = New Point(67, 165)
        btnCancelIkan.Margin = New Padding(4, 5, 4, 5)
        btnCancelIkan.Name = "btnCancelIkan"
        btnCancelIkan.Size = New Size(165, 40)
        btnCancelIkan.TabIndex = 11
        btnCancelIkan.Text = "Batal Ubah"
        btnCancelIkan.UseVisualStyleBackColor = False
        ' 
        ' txtNamaIkanBaru
        ' 
        txtNamaIkanBaru.Location = New Point(29, 25)
        txtNamaIkanBaru.Margin = New Padding(4, 5, 4, 5)
        txtNamaIkanBaru.Name = "txtNamaIkanBaru"
        txtNamaIkanBaru.PlaceholderText = "Masukkan Nama Ikan Baru"
        txtNamaIkanBaru.Size = New Size(522, 27)
        txtNamaIkanBaru.TabIndex = 10
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(600, 380)
        Controls.Add(TabControl1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form3"
        Text = "Form3"
        Panel1.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        tabAkuarium.ResumeLayout(False)
        tabAkuarium.PerformLayout()
        tabIkan.ResumeLayout(False)
        tabIkan.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabAkuarium As TabPage
    Friend WithEvents tabIkan As TabPage
    Friend WithEvents cbKapasitasBaru As ComboBox
    Friend WithEvents txtNamaBaru As TextBox
    Friend WithEvents btnSimpanAkuarium As Button
    Friend WithEvents btnCancelAkuarium As Button
    Friend WithEvents btnSimpanIkan As Button
    Friend WithEvents cbUkuranBaru As ComboBox
    Friend WithEvents btnCancelIkan As Button
    Friend WithEvents txtNamaIkanBaru As TextBox
End Class
