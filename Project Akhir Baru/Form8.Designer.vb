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
        panelPaket = New Panel()
        btnHome = New Button()
        Label1 = New Label()
        lblTotalHarga = New Label()
        lblHargaTotalPaket = New Label()
        DataGridViewPaket = New DataGridView()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn5 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn6 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn7 = New DataGridViewTextBoxColumn()
        lblNamaPaket = New Label()
        Label59 = New Label()
        lblTotalTambahan = New Label()
        panelTambahan = New Panel()
        btnCetakPDF = New Button()
        lblTotalSemua = New Label()
        lblTotalHargaSemua = New Label()
        DataGridViewTambahan = New DataGridView()
        colNamaPaket = New DataGridViewTextBoxColumn()
        colIsiPaket = New DataGridViewTextBoxColumn()
        colQty = New DataGridViewTextBoxColumn()
        colTotalTambahan = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        lblTotalHargaTambahan = New Label()
        Label12 = New Label()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(SplitContainer2, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer2.Panel1.SuspendLayout()
        SplitContainer2.Panel2.SuspendLayout()
        SplitContainer2.SuspendLayout()
        panelPaket.SuspendLayout()
        CType(DataGridViewPaket, ComponentModel.ISupportInitialize).BeginInit()
        panelTambahan.SuspendLayout()
        CType(DataGridViewTambahan, ComponentModel.ISupportInitialize).BeginInit()
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
        SplitContainer1.Panel2.Controls.Add(lblTotalTambahan)
        SplitContainer1.Panel2.Controls.Add(panelTambahan)
        SplitContainer1.Panel2.Controls.Add(lblTotalHargaTambahan)
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
        SplitContainer2.Panel1.Controls.Add(panelPaket)
        ' 
        ' SplitContainer2.Panel2
        ' 
        SplitContainer2.Panel2.AutoScroll = True
        SplitContainer2.Panel2.Controls.Add(lblTotalHarga)
        SplitContainer2.Panel2.Controls.Add(lblHargaTotalPaket)
        SplitContainer2.Panel2.Controls.Add(DataGridViewPaket)
        SplitContainer2.Panel2.Controls.Add(lblNamaPaket)
        SplitContainer2.Panel2.Controls.Add(Label59)
        SplitContainer2.Size = New Size(1209, 360)
        SplitContainer2.SplitterDistance = 41
        SplitContainer2.TabIndex = 0
        ' 
        ' panelPaket
        ' 
        panelPaket.BackColor = Color.FromArgb(CByte(250), CByte(200), CByte(8))
        panelPaket.Controls.Add(btnHome)
        panelPaket.Controls.Add(Label1)
        panelPaket.Dock = DockStyle.Top
        panelPaket.Location = New Point(0, 0)
        panelPaket.Name = "panelPaket"
        panelPaket.Size = New Size(1209, 45)
        panelPaket.TabIndex = 1
        ' 
        ' btnHome
        ' 
        btnHome.FlatAppearance.BorderSize = 0
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        ' lblTotalHarga
        ' 
        lblTotalHarga.AutoSize = True
        lblTotalHarga.BackColor = Color.FromArgb(CByte(13), CByte(64), CByte(41))
        lblTotalHarga.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        lblTotalHarga.ForeColor = Color.White
        lblTotalHarga.Location = New Point(976, 3)
        lblTotalHarga.Name = "lblTotalHarga"
        lblTotalHarga.Size = New Size(79, 31)
        lblTotalHarga.TabIndex = 28
        lblTotalHarga.Text = "Total :"
        ' 
        ' lblHargaTotalPaket
        ' 
        lblHargaTotalPaket.AutoSize = True
        lblHargaTotalPaket.BackColor = Color.FromArgb(CByte(13), CByte(64), CByte(41))
        lblHargaTotalPaket.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        lblHargaTotalPaket.ForeColor = Color.White
        lblHargaTotalPaket.Location = New Point(1050, 3)
        lblHargaTotalPaket.Name = "lblHargaTotalPaket"
        lblHargaTotalPaket.Size = New Size(91, 31)
        lblHargaTotalPaket.TabIndex = 27
        lblHargaTotalPaket.Text = "[harga]"
        ' 
        ' DataGridViewPaket
        ' 
        DataGridViewPaket.BackgroundColor = Color.FromArgb(CByte(239), CByte(245), CByte(235))
        DataGridViewPaket.BorderStyle = BorderStyle.None
        DataGridViewPaket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewPaket.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn5, DataGridViewTextBoxColumn6, DataGridViewTextBoxColumn7})
        DataGridViewPaket.Dock = DockStyle.Top
        DataGridViewPaket.Location = New Point(0, 39)
        DataGridViewPaket.Name = "DataGridViewPaket"
        DataGridViewPaket.RightToLeft = RightToLeft.No
        DataGridViewPaket.RowHeadersWidth = 51
        DataGridViewPaket.Size = New Size(1209, 274)
        DataGridViewPaket.TabIndex = 26
        ' 
        ' DataGridViewTextBoxColumn4
        ' 
        DataGridViewTextBoxColumn4.FillWeight = 50F
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
        DataGridViewTextBoxColumn5.Width = 810
        ' 
        ' DataGridViewTextBoxColumn6
        ' 
        DataGridViewTextBoxColumn6.HeaderText = "Qty"
        DataGridViewTextBoxColumn6.MinimumWidth = 6
        DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        DataGridViewTextBoxColumn6.Width = 125
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
        ' lblNamaPaket
        ' 
        lblNamaPaket.AutoSize = True
        lblNamaPaket.BackColor = Color.FromArgb(CByte(13), CByte(64), CByte(41))
        lblNamaPaket.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        lblNamaPaket.ForeColor = Color.White
        lblNamaPaket.Location = New Point(84, 1)
        lblNamaPaket.Name = "lblNamaPaket"
        lblNamaPaket.Size = New Size(155, 31)
        lblNamaPaket.TabIndex = 22
        lblNamaPaket.Text = "[nama paket]"
        ' 
        ' Label59
        ' 
        Label59.BackColor = Color.FromArgb(CByte(13), CByte(64), CByte(41))
        Label59.BorderStyle = BorderStyle.Fixed3D
        Label59.Dock = DockStyle.Top
        Label59.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label59.ForeColor = Color.White
        Label59.Location = New Point(0, 0)
        Label59.Name = "Label59"
        Label59.Size = New Size(1209, 39)
        Label59.TabIndex = 21
        Label59.Text = "  Detail"
        ' 
        ' lblTotalTambahan
        ' 
        lblTotalTambahan.AutoSize = True
        lblTotalTambahan.BackColor = Color.FromArgb(CByte(13), CByte(64), CByte(41))
        lblTotalTambahan.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        lblTotalTambahan.ForeColor = Color.White
        lblTotalTambahan.Location = New Point(976, 3)
        lblTotalTambahan.Name = "lblTotalTambahan"
        lblTotalTambahan.Size = New Size(79, 31)
        lblTotalTambahan.TabIndex = 30
        lblTotalTambahan.Text = "Total :"
        ' 
        ' panelTambahan
        ' 
        panelTambahan.BorderStyle = BorderStyle.Fixed3D
        panelTambahan.Controls.Add(btnCetakPDF)
        panelTambahan.Controls.Add(lblTotalSemua)
        panelTambahan.Controls.Add(lblTotalHargaSemua)
        panelTambahan.Controls.Add(DataGridViewTambahan)
        panelTambahan.Location = New Point(0, 42)
        panelTambahan.Name = "panelTambahan"
        panelTambahan.Size = New Size(1209, 263)
        panelTambahan.TabIndex = 26
        ' 
        ' btnCetakPDF
        ' 
        btnCetakPDF.BackColor = Color.FromArgb(CByte(13), CByte(64), CByte(41))
        btnCetakPDF.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCetakPDF.ForeColor = Color.White
        btnCetakPDF.Location = New Point(825, 226)
        btnCetakPDF.Name = "btnCetakPDF"
        btnCetakPDF.Size = New Size(94, 29)
        btnCetakPDF.TabIndex = 31
        btnCetakPDF.Text = "Cetak PDF"
        btnCetakPDF.UseVisualStyleBackColor = False
        ' 
        ' lblTotalSemua
        ' 
        lblTotalSemua.AutoSize = True
        lblTotalSemua.BackColor = Color.Transparent
        lblTotalSemua.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        lblTotalSemua.ForeColor = Color.FromArgb(CByte(13), CByte(64), CByte(41))
        lblTotalSemua.Location = New Point(974, 221)
        lblTotalSemua.Name = "lblTotalSemua"
        lblTotalSemua.Size = New Size(79, 31)
        lblTotalSemua.TabIndex = 30
        lblTotalSemua.Text = "Total :"
        ' 
        ' lblTotalHargaSemua
        ' 
        lblTotalHargaSemua.AutoSize = True
        lblTotalHargaSemua.BackColor = Color.Transparent
        lblTotalHargaSemua.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        lblTotalHargaSemua.ForeColor = Color.FromArgb(CByte(13), CByte(64), CByte(41))
        lblTotalHargaSemua.Location = New Point(1050, 219)
        lblTotalHargaSemua.Name = "lblTotalHargaSemua"
        lblTotalHargaSemua.Size = New Size(91, 31)
        lblTotalHargaSemua.TabIndex = 29
        lblTotalHargaSemua.Text = "[harga]"
        ' 
        ' DataGridViewTambahan
        ' 
        DataGridViewTambahan.BackgroundColor = Color.FromArgb(CByte(239), CByte(245), CByte(235))
        DataGridViewTambahan.BorderStyle = BorderStyle.None
        DataGridViewTambahan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewTambahan.Columns.AddRange(New DataGridViewColumn() {colNamaPaket, colIsiPaket, colQty, colTotalTambahan, DataGridViewTextBoxColumn3})
        DataGridViewTambahan.Dock = DockStyle.Top
        DataGridViewTambahan.Location = New Point(0, 0)
        DataGridViewTambahan.Name = "DataGridViewTambahan"
        DataGridViewTambahan.RightToLeft = RightToLeft.No
        DataGridViewTambahan.RowHeadersWidth = 51
        DataGridViewTambahan.Size = New Size(1205, 213)
        DataGridViewTambahan.TabIndex = 25
        ' 
        ' colNamaPaket
        ' 
        colNamaPaket.FillWeight = 50F
        colNamaPaket.HeaderText = "Paket"
        colNamaPaket.MinimumWidth = 6
        colNamaPaket.Name = "colNamaPaket"
        colNamaPaket.Width = 200
        ' 
        ' colIsiPaket
        ' 
        colIsiPaket.HeaderText = "Isi Paket"
        colIsiPaket.MinimumWidth = 6
        colIsiPaket.Name = "colIsiPaket"
        colIsiPaket.Width = 685
        ' 
        ' colQty
        ' 
        colQty.HeaderText = "Qty"
        colQty.MinimumWidth = 6
        colQty.Name = "colQty"
        colQty.Width = 125
        ' 
        ' colTotalTambahan
        ' 
        colTotalTambahan.HeaderText = "Total"
        colTotalTambahan.MinimumWidth = 6
        colTotalTambahan.Name = "colTotalTambahan"
        colTotalTambahan.Width = 125
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
        ' lblTotalHargaTambahan
        ' 
        lblTotalHargaTambahan.AutoSize = True
        lblTotalHargaTambahan.BackColor = Color.FromArgb(CByte(13), CByte(64), CByte(41))
        lblTotalHargaTambahan.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        lblTotalHargaTambahan.ForeColor = Color.White
        lblTotalHargaTambahan.Location = New Point(1050, 3)
        lblTotalHargaTambahan.Name = "lblTotalHargaTambahan"
        lblTotalHargaTambahan.Size = New Size(91, 31)
        lblTotalHargaTambahan.TabIndex = 29
        lblTotalHargaTambahan.Text = "[harga]"
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
        Label12.Size = New Size(1209, 39)
        Label12.TabIndex = 25
        Label12.Text = "  Detail Tambahan"
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(239), CByte(245), CByte(235))
        ClientSize = New Size(1209, 669)
        Controls.Add(SplitContainer1)
        Name = "Form8"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form8"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        SplitContainer2.Panel1.ResumeLayout(False)
        SplitContainer2.Panel2.ResumeLayout(False)
        SplitContainer2.Panel2.PerformLayout()
        CType(SplitContainer2, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer2.ResumeLayout(False)
        panelPaket.ResumeLayout(False)
        panelPaket.PerformLayout()
        CType(DataGridViewPaket, ComponentModel.ISupportInitialize).EndInit()
        panelTambahan.ResumeLayout(False)
        panelTambahan.PerformLayout()
        CType(DataGridViewTambahan, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents panelPaket As Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents lblNamaPaket As Label
    Friend WithEvents btnCetakPDF As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents panelTambahan As Panel
    Friend WithEvents DataGridViewTambahan As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents DataGridViewPaket As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents lblTotalHarga As Label
    Friend WithEvents lblHargaTotalPaket As Label
    Friend WithEvents lblTotalTambahan As Label
    Friend WithEvents lblTotalHargaTambahan As Label
    Friend WithEvents colNamaPaket As DataGridViewTextBoxColumn
    Friend WithEvents colIsiPaket As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colTotalTambahan As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents lblTotalHargaSemua As Label
    Friend WithEvents lblTotalSemua As Label
End Class
