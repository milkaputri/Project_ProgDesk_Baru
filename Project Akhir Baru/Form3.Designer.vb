<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Panel1 = New Panel()
        Panel3 = New Panel()
        btnHome = New Button()
        btnTentang = New Button()
        btnProfile = New Button()
        btnAgenda = New Button()
        btnKeluar = New Button()
        pbUtama = New PictureBox()
        Button4 = New Button()
        btnBrosur1 = New Button()
        tbCariAcara = New TextBox()
        Button1 = New Button()
        btnTambahAcara = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        Button12 = New Button()
        Button13 = New Button()
        Button14 = New Button()
        Button15 = New Button()
        Button16 = New Button()
        Button17 = New Button()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        Panel2 = New Panel()
        SplitContainer1 = New SplitContainer()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel1.SuspendLayout()
        CType(pbUtama, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(13), CByte(64), CByte(41))
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(btnHome)
        Panel1.Controls.Add(btnTentang)
        Panel1.Controls.Add(btnProfile)
        Panel1.Controls.Add(btnAgenda)
        Panel1.Controls.Add(btnKeluar)
        Panel1.Controls.Add(pbUtama)
        Panel1.Location = New Point(-1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(284, 699)
        Panel1.TabIndex = 5
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(250), CByte(200), CByte(8))
        Panel3.Location = New Point(0, 224)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(20, 51)
        Panel3.TabIndex = 10
        ' 
        ' btnHome
        ' 
        btnHome.FlatAppearance.BorderSize = 0
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHome.ForeColor = Color.White
        btnHome.Image = CType(resources.GetObject("btnHome.Image"), Image)
        btnHome.Location = New Point(3, 138)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(281, 51)
        btnHome.TabIndex = 12
        btnHome.Text = "   Home"
        btnHome.TextImageRelation = TextImageRelation.ImageBeforeText
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' btnTentang
        ' 
        btnTentang.FlatAppearance.BorderSize = 0
        btnTentang.FlatStyle = FlatStyle.Flat
        btnTentang.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTentang.ForeColor = Color.White
        btnTentang.Image = CType(resources.GetObject("btnTentang.Image"), Image)
        btnTentang.Location = New Point(7, 413)
        btnTentang.Name = "btnTentang"
        btnTentang.Size = New Size(277, 51)
        btnTentang.TabIndex = 11
        btnTentang.Text = "   Tentang"
        btnTentang.TextImageRelation = TextImageRelation.ImageBeforeText
        btnTentang.UseVisualStyleBackColor = True
        ' 
        ' btnProfile
        ' 
        btnProfile.FlatAppearance.BorderSize = 0
        btnProfile.FlatStyle = FlatStyle.Flat
        btnProfile.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnProfile.ForeColor = Color.White
        btnProfile.Image = CType(resources.GetObject("btnProfile.Image"), Image)
        btnProfile.Location = New Point(4, 321)
        btnProfile.Name = "btnProfile"
        btnProfile.Size = New Size(277, 51)
        btnProfile.TabIndex = 10
        btnProfile.Text = "   Profile"
        btnProfile.TextImageRelation = TextImageRelation.ImageBeforeText
        btnProfile.UseVisualStyleBackColor = True
        ' 
        ' btnAgenda
        ' 
        btnAgenda.FlatAppearance.BorderSize = 0
        btnAgenda.FlatStyle = FlatStyle.Flat
        btnAgenda.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAgenda.ForeColor = Color.White
        btnAgenda.Image = CType(resources.GetObject("btnAgenda.Image"), Image)
        btnAgenda.Location = New Point(4, 224)
        btnAgenda.Name = "btnAgenda"
        btnAgenda.Size = New Size(277, 51)
        btnAgenda.TabIndex = 8
        btnAgenda.Text = "   Kegiatan"
        btnAgenda.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAgenda.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.BackColor = Color.FromArgb(CByte(250), CByte(200), CByte(8))
        btnKeluar.FlatAppearance.BorderSize = 0
        btnKeluar.FlatStyle = FlatStyle.Flat
        btnKeluar.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKeluar.ForeColor = Color.White
        btnKeluar.Image = CType(resources.GetObject("btnKeluar.Image"), Image)
        btnKeluar.Location = New Point(1, 647)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(283, 51)
        btnKeluar.TabIndex = 5
        btnKeluar.Text = "   Logout"
        btnKeluar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnKeluar.UseVisualStyleBackColor = False
        ' 
        ' pbUtama
        ' 
        pbUtama.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pbUtama.Image = CType(resources.GetObject("pbUtama.Image"), Image)
        pbUtama.Location = New Point(70, 12)
        pbUtama.Name = "pbUtama"
        pbUtama.Size = New Size(141, 78)
        pbUtama.SizeMode = PictureBoxSizeMode.StretchImage
        pbUtama.TabIndex = 0
        pbUtama.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(812, 138)
        Button4.Name = "Button4"
        Button4.Size = New Size(0, 0)
        Button4.TabIndex = 9
        Button4.Text = "Buka PDF"
        Button4.TextAlign = ContentAlignment.BottomCenter
        Button4.UseVisualStyleBackColor = True
        ' 
        ' btnBrosur1
        ' 
        btnBrosur1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBrosur1.ForeColor = Color.White
        btnBrosur1.Location = New Point(360, 138)
        btnBrosur1.Name = "btnBrosur1"
        btnBrosur1.Size = New Size(0, 0)
        btnBrosur1.TabIndex = 8
        btnBrosur1.Text = "Buka PDF"
        btnBrosur1.TextAlign = ContentAlignment.BottomCenter
        btnBrosur1.UseVisualStyleBackColor = True
        ' 
        ' tbCariAcara
        ' 
        tbCariAcara.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbCariAcara.Location = New Point(302, 56)
        tbCariAcara.Multiline = True
        tbCariAcara.Name = "tbCariAcara"
        tbCariAcara.PlaceholderText = "Masukan Kegiatan"
        tbCariAcara.Size = New Size(718, 34)
        tbCariAcara.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(13), CByte(64), CByte(41))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(739, 56)
        Button1.Name = "Button1"
        Button1.Size = New Size(83, 34)
        Button1.TabIndex = 11
        Button1.Text = "Cari"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnTambahAcara
        ' 
        btnTambahAcara.BackColor = Color.FromArgb(CByte(13), CByte(64), CByte(41))
        btnTambahAcara.FlatStyle = FlatStyle.Flat
        btnTambahAcara.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTambahAcara.ForeColor = SystemColors.ButtonHighlight
        btnTambahAcara.Location = New Point(828, 56)
        btnTambahAcara.Name = "btnTambahAcara"
        btnTambahAcara.Size = New Size(83, 34)
        btnTambahAcara.TabIndex = 12
        btnTambahAcara.Text = "Tambah"
        btnTambahAcara.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(812, 193)
        Button2.Name = "Button2"
        Button2.Size = New Size(0, 0)
        Button2.TabIndex = 17
        Button2.Text = "Buka PDF"
        Button2.TextAlign = ContentAlignment.BottomCenter
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(360, 193)
        Button3.Name = "Button3"
        Button3.Size = New Size(0, 0)
        Button3.TabIndex = 16
        Button3.Text = "Buka PDF"
        Button3.TextAlign = ContentAlignment.BottomCenter
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = Color.White
        Button6.Location = New Point(302, 331)
        Button6.Name = "Button6"
        Button6.Size = New Size(0, 0)
        Button6.TabIndex = 19
        Button6.Text = "Buka PDF"
        Button6.TextAlign = ContentAlignment.BottomCenter
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.White
        Button5.Location = New Point(812, 254)
        Button5.Name = "Button5"
        Button5.Size = New Size(0, 0)
        Button5.TabIndex = 24
        Button5.Text = "Buka PDF"
        Button5.TextAlign = ContentAlignment.BottomCenter
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button7.ForeColor = Color.White
        Button7.Location = New Point(360, 254)
        Button7.Name = "Button7"
        Button7.Size = New Size(0, 0)
        Button7.TabIndex = 23
        Button7.Text = "Buka PDF"
        Button7.TextAlign = ContentAlignment.BottomCenter
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button8.ForeColor = Color.White
        Button8.Location = New Point(812, 199)
        Button8.Name = "Button8"
        Button8.Size = New Size(0, 0)
        Button8.TabIndex = 21
        Button8.Text = "Buka PDF"
        Button8.TextAlign = ContentAlignment.BottomCenter
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button9.ForeColor = Color.White
        Button9.Location = New Point(360, 199)
        Button9.Name = "Button9"
        Button9.Size = New Size(0, 0)
        Button9.TabIndex = 20
        Button9.Text = "Buka PDF"
        Button9.TextAlign = ContentAlignment.BottomCenter
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button12
        ' 
        Button12.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button12.ForeColor = Color.White
        Button12.Location = New Point(812, 321)
        Button12.Name = "Button12"
        Button12.Size = New Size(0, 0)
        Button12.TabIndex = 31
        Button12.Text = "Buka PDF"
        Button12.TextAlign = ContentAlignment.BottomCenter
        Button12.UseVisualStyleBackColor = True
        ' 
        ' Button13
        ' 
        Button13.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button13.ForeColor = Color.White
        Button13.Location = New Point(360, 321)
        Button13.Name = "Button13"
        Button13.Size = New Size(0, 0)
        Button13.TabIndex = 30
        Button13.Text = "Buka PDF"
        Button13.TextAlign = ContentAlignment.BottomCenter
        Button13.UseVisualStyleBackColor = True
        ' 
        ' Button14
        ' 
        Button14.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button14.ForeColor = Color.White
        Button14.Location = New Point(812, 315)
        Button14.Name = "Button14"
        Button14.Size = New Size(0, 0)
        Button14.TabIndex = 29
        Button14.Text = "Buka PDF"
        Button14.TextAlign = ContentAlignment.BottomCenter
        Button14.UseVisualStyleBackColor = True
        ' 
        ' Button15
        ' 
        Button15.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button15.ForeColor = Color.White
        Button15.Location = New Point(360, 315)
        Button15.Name = "Button15"
        Button15.Size = New Size(0, 0)
        Button15.TabIndex = 28
        Button15.Text = "Buka PDF"
        Button15.TextAlign = ContentAlignment.BottomCenter
        Button15.UseVisualStyleBackColor = True
        ' 
        ' Button16
        ' 
        Button16.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button16.ForeColor = Color.White
        Button16.Location = New Point(812, 260)
        Button16.Name = "Button16"
        Button16.Size = New Size(0, 0)
        Button16.TabIndex = 26
        Button16.Text = "Buka PDF"
        Button16.TextAlign = ContentAlignment.BottomCenter
        Button16.UseVisualStyleBackColor = True
        ' 
        ' Button17
        ' 
        Button17.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button17.ForeColor = Color.White
        Button17.Location = New Point(360, 260)
        Button17.Name = "Button17"
        Button17.Size = New Size(0, 0)
        Button17.TabIndex = 25
        Button17.Text = "Buka PDF"
        Button17.TextAlign = ContentAlignment.BottomCenter
        Button17.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(250), CByte(200), CByte(8))
        GroupBox1.Location = New Point(1163, 138)
        GroupBox1.MaximumSize = New Size(0, 7)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(0, 7)
        GroupBox1.TabIndex = 55
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(13), CByte(64), CByte(41))
        Label1.Location = New Point(7, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 28)
        Label1.TabIndex = 7
        Label1.Text = "Kegiatan !!!"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(250), CByte(200), CByte(8))
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(280, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1080, 45)
        Panel2.TabIndex = 6
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(FlowLayoutPanel1)
        SplitContainer1.Panel2.Controls.Add(Button1)
        SplitContainer1.Panel2.Controls.Add(btnTambahAcara)
        SplitContainer1.Size = New Size(1209, 699)
        SplitContainer1.SplitterDistance = 283
        SplitContainer1.TabIndex = 56
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Location = New Point(15, 109)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(895, 587)
        FlowLayoutPanel1.TabIndex = 28
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(239), CByte(245), CByte(235))
        ClientSize = New Size(1209, 699)
        Controls.Add(GroupBox1)
        Controls.Add(Button12)
        Controls.Add(Button13)
        Controls.Add(Button14)
        Controls.Add(Button15)
        Controls.Add(Button16)
        Controls.Add(Button17)
        Controls.Add(Button5)
        Controls.Add(Button7)
        Controls.Add(Button8)
        Controls.Add(Button9)
        Controls.Add(Button6)
        Controls.Add(Button2)
        Controls.Add(Button3)
        Controls.Add(tbCariAcara)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(Button4)
        Controls.Add(btnBrosur1)
        Controls.Add(SplitContainer1)
        Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        Panel1.ResumeLayout(False)
        CType(pbUtama, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnKeluar As Button
    Friend WithEvents pbUtama As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents btnBrosur1 As Button
    Friend WithEvents tbCariAcara As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnTambahAcara As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnHome As Button
    Friend WithEvents btnTentang As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnAgenda As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
