<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Panel1 = New Panel()
        Panel5 = New Panel()
        btnHome = New Button()
        btnProfile = New Button()
        btnKeluar = New Button()
        btnKegiatan = New Button()
        pbUtama = New PictureBox()
        Panel2 = New Panel()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Label1 = New Label()
        btnBrosur1 = New Button()
        btnBrosur2 = New Button()
        PictureBox1 = New PictureBox()
        btnTampilkanGrafik = New Button()
        Panel1.SuspendLayout()
        CType(pbUtama, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoSize = True
        Panel1.BackColor = Color.FromArgb(CByte(13), CByte(64), CByte(41))
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(btnHome)
        Panel1.Controls.Add(btnProfile)
        Panel1.Controls.Add(btnKeluar)
        Panel1.Controls.Add(btnKegiatan)
        Panel1.Controls.Add(pbUtama)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(287, 1116)
        Panel1.TabIndex = 0
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(250), CByte(200), CByte(8))
        Panel5.Location = New Point(-1, 181)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(20, 51)
        Panel5.TabIndex = 4
        ' 
        ' btnHome
        ' 
        btnHome.FlatAppearance.BorderSize = 0
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHome.ForeColor = Color.White
        btnHome.Image = CType(resources.GetObject("btnHome.Image"), Image)
        btnHome.Location = New Point(0, 181)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(283, 51)
        btnHome.TabIndex = 7
        btnHome.Text = "   Home"
        btnHome.TextImageRelation = TextImageRelation.ImageBeforeText
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' btnProfile
        ' 
        btnProfile.FlatAppearance.BorderSize = 0
        btnProfile.FlatStyle = FlatStyle.Flat
        btnProfile.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnProfile.ForeColor = Color.White
        btnProfile.Image = CType(resources.GetObject("btnProfile.Image"), Image)
        btnProfile.Location = New Point(0, 356)
        btnProfile.Name = "btnProfile"
        btnProfile.Size = New Size(284, 51)
        btnProfile.TabIndex = 6
        btnProfile.Text = "   Profile"
        btnProfile.TextImageRelation = TextImageRelation.ImageBeforeText
        btnProfile.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.BackColor = Color.FromArgb(CByte(250), CByte(200), CByte(8))
        btnKeluar.Dock = DockStyle.Bottom
        btnKeluar.FlatAppearance.BorderSize = 0
        btnKeluar.FlatStyle = FlatStyle.Flat
        btnKeluar.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKeluar.ForeColor = Color.White
        btnKeluar.Image = CType(resources.GetObject("btnKeluar.Image"), Image)
        btnKeluar.Location = New Point(0, 1065)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(287, 51)
        btnKeluar.TabIndex = 5
        btnKeluar.Text = "    Keluar"
        btnKeluar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnKeluar.UseVisualStyleBackColor = False
        ' 
        ' btnKegiatan
        ' 
        btnKegiatan.FlatAppearance.BorderSize = 0
        btnKegiatan.FlatStyle = FlatStyle.Flat
        btnKegiatan.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKegiatan.ForeColor = Color.White
        btnKegiatan.Image = CType(resources.GetObject("btnKegiatan.Image"), Image)
        btnKegiatan.Location = New Point(-1, 271)
        btnKegiatan.Name = "btnKegiatan"
        btnKegiatan.Size = New Size(284, 51)
        btnKegiatan.TabIndex = 1
        btnKegiatan.Text = "   Kegiatan"
        btnKegiatan.TextImageRelation = TextImageRelation.ImageBeforeText
        btnKegiatan.UseVisualStyleBackColor = True
        ' 
        ' pbUtama
        ' 
        pbUtama.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pbUtama.Image = CType(resources.GetObject("pbUtama.Image"), Image)
        pbUtama.Location = New Point(62, 12)
        pbUtama.Name = "pbUtama"
        pbUtama.Size = New Size(160, 78)
        pbUtama.SizeMode = PictureBoxSizeMode.StretchImage
        pbUtama.TabIndex = 0
        pbUtama.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(250), CByte(200), CByte(8))
        Panel2.Location = New Point(284, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(926, 45)
        Panel2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(13), CByte(64), CByte(41))
        Label1.Location = New Point(308, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(453, 46)
        Label1.TabIndex = 2
        Label1.Text = "Brosur H'ney Organizer"
        ' 
        ' btnBrosur1
        ' 
        btnBrosur1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBrosur1.ForeColor = Color.White
        btnBrosur1.Image = CType(resources.GetObject("btnBrosur1.Image"), Image)
        btnBrosur1.Location = New Point(321, 138)
        btnBrosur1.Name = "btnBrosur1"
        btnBrosur1.Size = New Size(354, 463)
        btnBrosur1.TabIndex = 3
        btnBrosur1.Text = "Buka PDF"
        btnBrosur1.TextAlign = ContentAlignment.BottomCenter
        btnBrosur1.UseVisualStyleBackColor = True
        ' 
        ' btnBrosur2
        ' 
        btnBrosur2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBrosur2.ForeColor = Color.White
        btnBrosur2.Image = CType(resources.GetObject("btnBrosur2.Image"), Image)
        btnBrosur2.Location = New Point(767, 138)
        btnBrosur2.Name = "btnBrosur2"
        btnBrosur2.Size = New Size(354, 463)
        btnBrosur2.TabIndex = 4
        btnBrosur2.Text = "Buka PDF"
        btnBrosur2.TextAlign = ContentAlignment.BottomCenter
        btnBrosur2.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(321, 716)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(800, 400)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' btnTampilkanGrafik
        ' 
        btnTampilkanGrafik.BackColor = Color.FromArgb(CByte(13), CByte(64), CByte(41))
        btnTampilkanGrafik.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTampilkanGrafik.Location = New Point(321, 671)
        btnTampilkanGrafik.Name = "btnTampilkanGrafik"
        btnTampilkanGrafik.Size = New Size(137, 39)
        btnTampilkanGrafik.TabIndex = 6
        btnTampilkanGrafik.Text = "Tampilkan Grafik"
        btnTampilkanGrafik.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(239), CByte(245), CByte(235))
        ClientSize = New Size(1188, 678)
        Controls.Add(btnTampilkanGrafik)
        Controls.Add(PictureBox1)
        Controls.Add(btnBrosur2)
        Controls.Add(btnBrosur1)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.ControlLightLight
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        Panel1.ResumeLayout(False)
        CType(pbUtama, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbUtama As PictureBox
    Friend WithEvents btnKegiatan As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnTentang As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBrosur1 As Button
    Friend WithEvents btnBrosur2 As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnTampilkanGrafik As Button
End Class
