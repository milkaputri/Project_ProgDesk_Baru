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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        tbNamaPengguna = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        tbKataSandi = New TextBox()
        llReset = New LinkLabel()
        btnMasuk = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(299, 450)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(13), CByte(64), CByte(41))
        Label2.Location = New Point(327, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(442, 86)
        Label2.TabIndex = 2
        Label2.Text = "SELAMAT DATANG DI ""H'NEY"" ORGANIZER"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(136), CByte(159), CByte(132))
        Label3.Location = New Point(327, 111)
        Label3.Name = "Label3"
        Label3.Size = New Size(213, 17)
        Label3.TabIndex = 3
        Label3.Text = "*Silahkan masuk dengan akun anda"
        ' 
        ' tbNamaPengguna
        ' 
        tbNamaPengguna.ForeColor = Color.Black
        tbNamaPengguna.Location = New Point(327, 194)
        tbNamaPengguna.Name = "tbNamaPengguna"
        tbNamaPengguna.PlaceholderText = "Masukan username"
        tbNamaPengguna.Size = New Size(442, 27)
        tbNamaPengguna.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(136), CByte(159), CByte(132))
        Label4.Location = New Point(327, 171)
        Label4.Name = "Label4"
        Label4.Size = New Size(123, 20)
        Label4.TabIndex = 5
        Label4.Text = "Nama Pengguna"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(136), CByte(159), CByte(132))
        Label5.Location = New Point(327, 243)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 20)
        Label5.TabIndex = 7
        Label5.Text = "Kata Sandi"
        ' 
        ' tbKataSandi
        ' 
        tbKataSandi.ForeColor = Color.Black
        tbKataSandi.Location = New Point(327, 266)
        tbKataSandi.Name = "tbKataSandi"
        tbKataSandi.PasswordChar = "*"c
        tbKataSandi.PlaceholderText = "Masukan Kata Sandi"
        tbKataSandi.Size = New Size(442, 27)
        tbKataSandi.TabIndex = 6
        ' 
        ' llReset
        ' 
        llReset.AutoSize = True
        llReset.LinkColor = Color.Green
        llReset.Location = New Point(327, 318)
        llReset.Name = "llReset"
        llReset.Size = New Size(45, 20)
        llReset.TabIndex = 8
        llReset.TabStop = True
        llReset.Text = "Reset"
        ' 
        ' btnMasuk
        ' 
        btnMasuk.BackColor = Color.FromArgb(CByte(13), CByte(64), CByte(41))
        btnMasuk.FlatStyle = FlatStyle.Flat
        btnMasuk.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMasuk.ForeColor = SystemColors.ButtonHighlight
        btnMasuk.Location = New Point(675, 380)
        btnMasuk.Name = "btnMasuk"
        btnMasuk.Size = New Size(94, 29)
        btnMasuk.TabIndex = 9
        btnMasuk.Text = "Masuk"
        btnMasuk.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(239), CByte(245), CByte(235))
        ClientSize = New Size(800, 450)
        Controls.Add(btnMasuk)
        Controls.Add(llReset)
        Controls.Add(Label5)
        Controls.Add(tbKataSandi)
        Controls.Add(Label4)
        Controls.Add(tbNamaPengguna)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        KeyPreview = True
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "H'ney Wedding Organizer"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbNamaPengguna As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbKataSandi As TextBox
    Friend WithEvents llReset As LinkLabel
    Friend WithEvents btnMasuk As Button

End Class
