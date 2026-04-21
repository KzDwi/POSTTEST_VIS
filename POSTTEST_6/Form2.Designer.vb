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
        Panel1 = New Panel()
        Label6 = New Label()
        btnExit = New Button()
        lblCheat = New Label()
        txtCheat = New TextBox()
        btnCheat = New Button()
        lblValid = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SandyBrown
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(btnExit)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(400, 30)
        Panel1.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(33, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(180, 25)
        Label6.TabIndex = 7
        Label6.Text = "Cheat Code Redeem"
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.IndianRed
        btnExit.BackgroundImageLayout = ImageLayout.Stretch
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(328, -24)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(72, 70)
        btnExit.TabIndex = 7
        btnExit.Text = "X"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' lblCheat
        ' 
        lblCheat.AutoSize = True
        lblCheat.BackColor = Color.Transparent
        lblCheat.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCheat.Location = New Point(115, 61)
        lblCheat.Name = "lblCheat"
        lblCheat.Size = New Size(163, 20)
        lblCheat.TabIndex = 1
        lblCheat.Text = "Masukkan Cheat Code"
        ' 
        ' txtCheat
        ' 
        txtCheat.Location = New Point(33, 128)
        txtCheat.Name = "txtCheat"
        txtCheat.PlaceholderText = "Masukkan Cheat Code Disini"
        txtCheat.Size = New Size(334, 27)
        txtCheat.TabIndex = 2
        ' 
        ' btnCheat
        ' 
        btnCheat.BackColor = Color.Transparent
        btnCheat.BackgroundImage = My.Resources.Resources.button
        btnCheat.BackgroundImageLayout = ImageLayout.Stretch
        btnCheat.FlatAppearance.BorderSize = 0
        btnCheat.FlatStyle = FlatStyle.Flat
        btnCheat.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCheat.Location = New Point(121, 171)
        btnCheat.Name = "btnCheat"
        btnCheat.Size = New Size(149, 38)
        btnCheat.TabIndex = 3
        btnCheat.Text = "Gunakan"
        btnCheat.UseVisualStyleBackColor = False
        ' 
        ' lblValid
        ' 
        lblValid.BackColor = Color.Transparent
        lblValid.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblValid.Location = New Point(0, 91)
        lblValid.Name = "lblValid"
        lblValid.Size = New Size(400, 25)
        lblValid.TabIndex = 4
        lblValid.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.otherbg
        ClientSize = New Size(400, 240)
        Controls.Add(lblValid)
        Controls.Add(btnCheat)
        Controls.Add(txtCheat)
        Controls.Add(lblCheat)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCheat As Label
    Friend WithEvents txtCheat As TextBox
    Friend WithEvents btnCheat As Button
    Friend WithEvents lblValid As Label
    Friend WithEvents Label6 As Label
End Class
