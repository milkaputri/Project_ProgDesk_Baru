<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        SplitContainer1 = New SplitContainer()
        SplitContainer2 = New SplitContainer()
        Panel1 = New Panel()
        btnHome = New Button()
        Label1 = New Label()
        lblNamaPaket = New Label()
        Label59 = New Label()
        Label12 = New Label()
        Panel2 = New Panel()
        DataGridView1 = New DataGridView()
        DataGridView2 = New DataGridView()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn5 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn6 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn7 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        colIsiPaket = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(SplitContainer2, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer2.Panel1.SuspendLayout()
        SplitContainer2.Panel2.SuspendLayout()
        SplitContainer2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        SplitContainer1.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(SplitContainer2)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.AutoScroll = True
        SplitContainer1.Panel2.Controls.Add(Panel2)
        SplitContainer1.Panel2.Controls.Add(Label12)
        SplitContainer1.Size = New Size(1209, 669)
        SplitContainer1.SplitterDistance = 360
        SplitContainer1.TabIndex = 0
        ' 
        ' SplitContainer2
        ' 
        SplitContainer2.Dock = DockStyle.Fill
        SplitContainer2.Location = New Point(0, 0)
        SplitContainer2.Name = "SplitContainer2"
        SplitContainer2.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer2.Panel1
        ' 
        SplitContainer2.Panel1.Controls.Add(Panel1)
        ' 
        ' SplitContainer2.Panel2
        ' 
        SplitContainer2.Panel2.AutoScroll = True
        SplitContainer2.Panel2.Controls.Add(DataGridView2)
        SplitContainer2.Panel2.Controls.Add(lblNamaPaket)
        SplitContainer2.Panel2.Controls.Add(Label59)
        SplitContainer2.Size = New Size(1209, 360)
        SplitContainer2.SplitterDistance = 41
        SplitContainer2.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(250), CByte(200), CByte(8))
        Panel1.Controls.Add(btnHome)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1209, 45)
        Panel1.TabIndex = 1
        ' 
        ' btnHome
        ' 
        btnHome.FlatAppearance.BorderSize = 0
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHome.ForeColor = Color.FromArgb(CByte(250), CByte(200), CByte(8))
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
        Label1.Location = New Point(14, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 33)
        Label1.TabIndex = 3
        Label1.Text = "Detail"
        ' 
        ' lblNamaPaket
        ' 
        lblNamaPaket.AutoSize = True
        lblNamaPaket.BackColor = Color.FromArgb(CByte(13), CByte(64), CByte(41))
        lblNamaPaket.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        lblNamaPaket.ForeColor = Color.White
        lblNamaPaket.Location = New Point(149, 1)
        lblNamaPaket.Name = "lblNamaPaket"
        lblNamaPaket.Size = New Size(155, 31)
        lblNamaPaket.TabIndex = 22
        lblNamaPaket.Text = "[nama paket]"
        ' 
        ' Label59
        ' 
        Label59.BackColor = Color.FromArgb(CByte(13), CByte(64), CByte(41))
        Label59.BorderStyle = BorderStyle.Fixed3D
        Label59.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label59.ForeColor = Color.White
        Label59.Location = New Point(0, 0)
        Label59.Name = "Label59"
        Label59.Size = New Size(1188, 39)
        Label59.TabIndex = 21
        Label59.Text = "  Detail Paket"
        ' 
        ' Label12
        ' 
        Label12.BackColor = Color.FromArgb(CByte(13), CByte(64), CByte(41))
        Label12.BorderStyle = BorderStyle.Fixed3D
        Label12.Dock = DockStyle.Top
        Label12.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.White
        Label12.Location = New Point(0, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(1188, 39)
        Label12.TabIndex = 25
        Label12.Text = "  Detail Tambahan"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(DataGridView1)
        Panel2.Location = New Point(14, 42)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1162, 412)
        Panel2.TabIndex = 26
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(239), CByte(245), CByte(235))
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, colIsiPaket, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3})
        DataGridView1.Location = New Point(14, 15)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RightToLeft = RightToLeft.No
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1146, 372)
        DataGridView1.TabIndex = 25
        ' 
        ' DataGridView2
        ' 
        DataGridView2.BackgroundColor = Color.FromArgb(CByte(239), CByte(245), CByte(235))
        DataGridView2.BorderStyle = BorderStyle.None
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn5, DataGridViewTextBoxColumn6, DataGridViewTextBoxColumn7})
        DataGridView2.Location = New Point(14, 42)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RightToLeft = RightToLeft.No
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(1174, 372)
        DataGridView2.TabIndex = 26
        ' 
        ' DataGridViewTextBoxColumn4
        ' 
        DataGridViewTextBoxColumn4.FillWeight = 50.0F
        DataGridViewTextBoxColumn4.HeaderText = "Item"
        DataGridViewTextBoxColumn4.MinimumWidth = 6
        DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        DataGridViewTextBoxColumn4.Width = 200
        ' 
        ' DataGridViewTextBoxColumn5
        ' 
        DataGridViewTextBoxColumn5.HeaderText = "Isi Item"
        DataGridViewTextBoxColumn5.MinimumWidth = 6
        DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        DataGridViewTextBoxColumn5.Width = 820
        ' 
        ' DataGridViewTextBoxColumn6
        ' 
        DataGridViewTextBoxColumn6.HeaderText = "Qty"
        DataGridViewTextBoxColumn6.MinimumWidth = 6
        DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        ' 
        ' DataGridViewTextBoxColumn7
        ' 
        DataGridViewTextBoxColumn7.HeaderText = "Id"
        DataGridViewTextBoxColumn7.MinimumWidth = 6
        DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        DataGridViewTextBoxColumn7.ReadOnly = True
        DataGridViewTextBoxColumn7.Visible = False
        DataGridViewTextBoxColumn7.Width = 125
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.FillWeight = 50.0F
        DataGridViewTextBoxColumn1.HeaderText = "Paket"
        DataGridViewTextBoxColumn1.MinimumWidth = 6
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.Width = 200
        ' 
        ' colIsiPaket
        ' 
        colIsiPaket.HeaderText = "Isi Paket"
        colIsiPaket.MinimumWidth = 6
        colIsiPaket.Name = "colIsiPaket"
        colIsiPaket.Width = 820
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.HeaderText = "Qty"
        DataGridViewTextBoxColumn2.MinimumWidth = 6
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.HeaderText = "Id"
        DataGridViewTextBoxColumn3.MinimumWidth = 6
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        DataGridViewTextBoxColumn3.ReadOnly = True
        DataGridViewTextBoxColumn3.Visible = False
        DataGridViewTextBoxColumn3.Width = 125
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(239), CByte(245), CByte(235))
        ClientSize = New Size(1209, 669)
        Controls.Add(SplitContainer1)
        Name = "Form8"
        Text = "Form8"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        SplitContainer2.Panel1.ResumeLayout(False)
        SplitContainer2.Panel2.ResumeLayout(False)
        SplitContainer2.Panel2.PerformLayout()
        CType(SplitContainer2, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents lblNamaPaket As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents colIsiPaket As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
