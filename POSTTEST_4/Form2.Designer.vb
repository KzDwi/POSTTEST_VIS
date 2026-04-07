<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        pbFotoHasil = New PictureBox()
        lblNama = New Label()
        lblID = New Label()
        lblKomunitas = New Label()
        lblKontak = New Label()
        lblHobi = New Label()
        lblPeran = New Label()
        Panel1 = New Panel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label9 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        CType(pbFotoHasil, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbFotoHasil
        ' 
        pbFotoHasil.Location = New Point(42, 99)
        pbFotoHasil.Name = "pbFotoHasil"
        pbFotoHasil.Size = New Size(171, 247)
        pbFotoHasil.TabIndex = 1
        pbFotoHasil.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(311, 129)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(53, 20)
        lblNama.TabIndex = 2
        lblNama.Text = "Label1"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Location = New Point(311, 167)
        lblID.Name = "lblID"
        lblID.Size = New Size(53, 20)
        lblID.TabIndex = 3
        lblID.Text = "Label2"
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.AutoSize = True
        lblKomunitas.Location = New Point(311, 209)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(53, 20)
        lblKomunitas.TabIndex = 4
        lblKomunitas.Text = "Label3"
        ' 
        ' lblKontak
        ' 
        lblKontak.AutoSize = True
        lblKontak.Location = New Point(311, 247)
        lblKontak.Name = "lblKontak"
        lblKontak.Size = New Size(53, 20)
        lblKontak.TabIndex = 5
        lblKontak.Text = "Label4"
        ' 
        ' lblHobi
        ' 
        lblHobi.AutoSize = True
        lblHobi.Location = New Point(311, 289)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(53, 20)
        lblHobi.TabIndex = 6
        lblHobi.Text = "Label5"
        ' 
        ' lblPeran
        ' 
        lblPeran.AutoSize = True
        lblPeran.Location = New Point(311, 328)
        lblPeran.Name = "lblPeran"
        lblPeran.Size = New Size(53, 20)
        lblPeran.TabIndex = 7
        lblPeran.Text = "Label6"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGoldenrodYellow
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(FlowLayoutPanel1)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 30)
        Panel1.TabIndex = 8
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Location = New Point(468, 11)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(8, 8)
        FlowLayoutPanel1.TabIndex = 4
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(197, 3)
        Label9.Name = "Label9"
        Label9.Size = New Size(317, 25)
        Label9.TabIndex = 3
        Label9.Text = "Formulir Furi Samarinda Solid Solidd"
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
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.paw
        PictureBox1.Location = New Point(12, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(20, 20)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(lblPeran)
        Controls.Add(lblHobi)
        Controls.Add(lblKontak)
        Controls.Add(lblKomunitas)
        Controls.Add(lblID)
        Controls.Add(lblNama)
        Controls.Add(pbFotoHasil)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form2"
        Text = "Form2"
        CType(pbFotoHasil, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbFotoHasil As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents lblKontak As Label
    Friend WithEvents lblHobi As Label
    Friend WithEvents lblPeran As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
