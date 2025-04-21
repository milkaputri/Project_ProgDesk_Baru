<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Panel1 = New Panel()
        Button1 = New Button()
        btnHome = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        llReset = New LinkLabel()
        Label5 = New Label()
        tbKataSandi = New TextBox()
        Label4 = New Label()
        tbNamaPengguna = New TextBox()
        btnSimpan = New Button()
        pbOpenEyes = New PictureBox()
        pbCloseEyes = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbOpenEyes, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbCloseEyes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(250), CByte(200), CByte(8))
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(btnHome)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(801, 45)
        Panel1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(750, 1)
        Button1.Name = "Button1"
        Button1.Size = New Size(48, 42)
        Button1.TabIndex = 9
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnHome
        ' 
        btnHome.FlatAppearance.BorderSize = 0
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHome.ForeColor = Color.White
        btnHome.Image = CType(resources.GetObject("btnHome.Image"), Image)
        btnHome.Location = New Point(1161, 1)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(48, 42)
        btnHome.TabIndex = 8
        btnHome.TextImageRelation = TextImageRelation.ImageBeforeText
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(13), CByte(64), CByte(41))
        Label1.Location = New Point(163, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(451, 33)
        Label1.TabIndex = 3
        Label1.Text = "Profile Admin H'Ney Organizer"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Enabled = False
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(275, 60)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(223, 96)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' llReset
        ' 
        llReset.AutoSize = True
        llReset.LinkColor = Color.Green
        llReset.Location = New Point(172, 321)
        llReset.Name = "llReset"
        llReset.Size = New Size(45, 20)
        llReset.TabIndex = 13
        llReset.TabStop = True
        llReset.Text = "Reset"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(136), CByte(159), CByte(132))
        Label5.Location = New Point(172, 246)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 20)
        Label5.TabIndex = 12
        Label5.Text = "Kata Sandi"
        ' 
        ' tbKataSandi
        ' 
        tbKataSandi.ForeColor = Color.Black
        tbKataSandi.Location = New Point(172, 269)
        tbKataSandi.Name = "tbKataSandi"
        tbKataSandi.PlaceholderText = "Masukan Kata Sandi"
        tbKataSandi.Size = New Size(442, 27)
        tbKataSandi.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(136), CByte(159), CByte(132))
        Label4.Location = New Point(172, 174)
        Label4.Name = "Label4"
        Label4.Size = New Size(123, 20)
        Label4.TabIndex = 10
        Label4.Text = "Nama Pengguna"
        ' 
        ' tbNamaPengguna
        ' 
        tbNamaPengguna.ForeColor = Color.Black
        tbNamaPengguna.Location = New Point(172, 197)
        tbNamaPengguna.Name = "tbNamaPengguna"
        tbNamaPengguna.PlaceholderText = "Masukan username"
        tbNamaPengguna.Size = New Size(442, 27)
        tbNamaPengguna.TabIndex = 9
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(13), CByte(64), CByte(41))
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.ForeColor = SystemColors.ButtonHighlight
        btnSimpan.Location = New Point(520, 317)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 29)
        btnSimpan.TabIndex = 14
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' pbOpenEyes
        ' 
        pbOpenEyes.BackColor = Color.White
        pbOpenEyes.Image = CType(resources.GetObject("pbOpenEyes.Image"), Image)
        pbOpenEyes.Location = New Point(590, 274)
        pbOpenEyes.Name = "pbOpenEyes"
        pbOpenEyes.Size = New Size(17, 18)
        pbOpenEyes.SizeMode = PictureBoxSizeMode.StretchImage
        pbOpenEyes.TabIndex = 15
        pbOpenEyes.TabStop = False
        ' 
        ' pbCloseEyes
        ' 
        pbCloseEyes.BackColor = Color.White
        pbCloseEyes.Image = CType(resources.GetObject("pbCloseEyes.Image"), Image)
        pbCloseEyes.Location = New Point(590, 274)
        pbCloseEyes.Name = "pbCloseEyes"
        pbCloseEyes.Size = New Size(17, 18)
        pbCloseEyes.SizeMode = PictureBoxSizeMode.StretchImage
        pbCloseEyes.TabIndex = 16
        pbCloseEyes.TabStop = False
        pbCloseEyes.Visible = False
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(239), CByte(245), CByte(235))
        ClientSize = New Size(800, 450)
        Controls.Add(pbCloseEyes)
        Controls.Add(pbOpenEyes)
        Controls.Add(btnSimpan)
        Controls.Add(llReset)
        Controls.Add(Label5)
        Controls.Add(tbKataSandi)
        Controls.Add(Label4)
        Controls.Add(tbNamaPengguna)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Name = "Form7"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form7"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(pbOpenEyes, ComponentModel.ISupportInitialize).EndInit()
        CType(pbCloseEyes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents llReset As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents tbKataSandi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbNamaPengguna As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents pbOpenEyes As PictureBox
    Friend WithEvents pbCloseEyes As PictureBox
    Friend WithEvents Button1 As Button
End Class
