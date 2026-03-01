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
        Label1 = New Label()
        Label2 = New Label()
        lblPredikat = New Label()
        txtIPS = New TextBox()
        btnTambah = New Button()
        txtIPK = New TextBox()
        btnReset = New Button()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Panel7 = New Panel()
        Panel8 = New Panel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(254, 140)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 20)
        Label1.TabIndex = 0
        Label1.Text = "IP Semester"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(254, 227)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 20)
        Label2.TabIndex = 1
        Label2.Text = "IP Kumulatif"
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(360, 273)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(56, 20)
        lblPredikat.TabIndex = 2
        lblPredikat.Text = "Kurang"
        ' 
        ' txtIPS
        ' 
        txtIPS.Cursor = Cursors.IBeam
        txtIPS.Location = New Point(360, 137)
        txtIPS.Name = "txtIPS"
        txtIPS.Size = New Size(168, 27)
        txtIPS.TabIndex = 3
        ' 
        ' btnTambah
        ' 
        btnTambah.Cursor = Cursors.Hand
        btnTambah.Location = New Point(360, 170)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(81, 35)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' txtIPK
        ' 
        txtIPK.Cursor = Cursors.No
        txtIPK.Location = New Point(360, 224)
        txtIPK.Name = "txtIPK"
        txtIPK.ReadOnly = True
        txtIPK.Size = New Size(168, 27)
        txtIPK.TabIndex = 6
        txtIPK.Text = "0"
        ' 
        ' btnReset
        ' 
        btnReset.Cursor = Cursors.Hand
        btnReset.Location = New Point(447, 170)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(81, 35)
        btnReset.TabIndex = 7
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Location = New Point(583, -5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(339, 466)
        Panel1.TabIndex = 8
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Location = New Point(-17, -10)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(218, 466)
        Panel2.TabIndex = 9
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveCaption
        Panel3.Location = New Point(-37, -40)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(900, 142)
        Panel3.TabIndex = 10
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ActiveCaption
        Panel4.Location = New Point(-26, 317)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(864, 144)
        Panel4.TabIndex = 11
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ButtonShadow
        Panel5.Location = New Point(583, 104)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(5, 216)
        Panel5.TabIndex = 0
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.ButtonShadow
        Panel6.Location = New Point(207, 317)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(380, 7)
        Panel6.TabIndex = 0
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.ControlDarkDark
        Panel7.Location = New Point(207, 108)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(35, 11)
        Panel7.TabIndex = 0
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = SystemColors.ControlDarkDark
        Panel8.Location = New Point(254, 108)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(17, 11)
        Panel8.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel8)
        Controls.Add(Panel7)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(btnReset)
        Controls.Add(txtIPK)
        Controls.Add(btnTambah)
        Controls.Add(txtIPS)
        Controls.Add(lblPredikat)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kalkulator IP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPredikat As Label
    Friend WithEvents txtIPS As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel

End Class
