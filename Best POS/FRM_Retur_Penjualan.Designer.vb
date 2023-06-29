<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Retur_Penjualan
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Retur_Penjualan))
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.bnReturPenjualan = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TBLReturPenjualanHeaderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_POS_CNDataSet = New Best_POS.db_POS_CNDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsTambah = New System.Windows.Forms.ToolStripButton()
        Me.tsSimpan = New System.Windows.Forms.ToolStripButton()
        Me.tsHapus = New System.Windows.Forms.ToolStripButton()
        Me.tsRefresh = New System.Windows.Forms.ToolStripButton()
        Me.tsCetak = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtKataKunci = New System.Windows.Forms.ToolStripTextBox()
        Me.cboKriteria = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKodeRetur = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoFaktur = New System.Windows.Forms.TextBox()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIdDetail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtDiskonRpDetail = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDiskonPersenDetail = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtHargaJual = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBarcodeBarang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalQty = New System.Windows.Forms.TextBox()
        Me.TBLReturPenjualanHeaderQueryReturPenjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QueryReturPenjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtTotalHarga = New C1.Win.C1Input.C1TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtJumlahItem = New System.Windows.Forms.TextBox()
        Me.cfgFaktur = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.QueryKodePenjualanReturBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLBarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_BarangTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_BarangTableAdapter()
        Me.QueryPenjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Query_PenjualanTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.Query_PenjualanTableAdapter()
        Me.Query_Kode_Penjualan_ReturTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.Query_Kode_Penjualan_ReturTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.TbL_Retur_Penjualan_DetailTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Retur_Penjualan_DetailTableAdapter()
        Me.TbL_Penjualan_DetailTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Penjualan_DetailTableAdapter()
        Me.TBL_Retur_Penjualan_HeaderTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Retur_Penjualan_HeaderTableAdapter()
        Me.Query_Retur_PenjualanTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.Query_Retur_PenjualanTableAdapter()
        Me.TbL_PiutangTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_PiutangTableAdapter()
        Me.dgvBarang = New System.Windows.Forms.DataGridView()
        Me.NoBarisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDBarangDetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarangDetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaJualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyJualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiskonPersenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiskonRpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPenjualan = New System.Windows.Forms.DataGridView()
        Me.NoBarisDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeBarangDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarangDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDBarangDetailDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarangDetailDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaJualDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyReturDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiskonPersenDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiskonRpDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbL_Barang_DetailTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Barang_DetailTableAdapter()
        CType(Me.bnReturPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnReturPenjualan.SuspendLayout()
        CType(Me.TBLReturPenjualanHeaderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_POS_CNDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TBLReturPenjualanHeaderQueryReturPenjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QueryReturPenjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalHarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cfgFaktur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QueryKodePenjualanReturBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QueryPenjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bnReturPenjualan
        '
        Me.bnReturPenjualan.AddNewItem = Nothing
        Me.bnReturPenjualan.BindingSource = Me.TBLReturPenjualanHeaderBindingSource
        Me.bnReturPenjualan.CountItem = Me.BindingNavigatorCountItem
        Me.bnReturPenjualan.DeleteItem = Nothing
        Me.bnReturPenjualan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.tsTambah, Me.tsSimpan, Me.tsHapus, Me.tsRefresh, Me.tsCetak, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.txtKataKunci, Me.cboKriteria, Me.ToolStripSeparator3})
        Me.bnReturPenjualan.Location = New System.Drawing.Point(0, 0)
        Me.bnReturPenjualan.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnReturPenjualan.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnReturPenjualan.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnReturPenjualan.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnReturPenjualan.Name = "bnReturPenjualan"
        Me.bnReturPenjualan.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnReturPenjualan.Size = New System.Drawing.Size(993, 25)
        Me.bnReturPenjualan.TabIndex = 55
        Me.bnReturPenjualan.Text = "BindingNavigator1"
        '
        'TBLReturPenjualanHeaderBindingSource
        '
        Me.TBLReturPenjualanHeaderBindingSource.DataMember = "TBL_Retur_Penjualan_Header"
        Me.TBLReturPenjualanHeaderBindingSource.DataSource = Me.Db_POS_CNDataSet
        '
        'Db_POS_CNDataSet
        '
        Me.Db_POS_CNDataSet.DataSetName = "db_POS_CNDataSet"
        Me.Db_POS_CNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsTambah
        '
        Me.tsTambah.Image = CType(resources.GetObject("tsTambah.Image"), System.Drawing.Image)
        Me.tsTambah.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsTambah.Name = "tsTambah"
        Me.tsTambah.Size = New System.Drawing.Size(49, 22)
        Me.tsTambah.Text = "&Add"
        '
        'tsSimpan
        '
        Me.tsSimpan.Image = CType(resources.GetObject("tsSimpan.Image"), System.Drawing.Image)
        Me.tsSimpan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSimpan.Name = "tsSimpan"
        Me.tsSimpan.Size = New System.Drawing.Size(51, 22)
        Me.tsSimpan.Text = "&Save"
        '
        'tsHapus
        '
        Me.tsHapus.Image = CType(resources.GetObject("tsHapus.Image"), System.Drawing.Image)
        Me.tsHapus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsHapus.Name = "tsHapus"
        Me.tsHapus.Size = New System.Drawing.Size(60, 22)
        Me.tsHapus.Text = "&Delete"
        '
        'tsRefresh
        '
        Me.tsRefresh.Image = CType(resources.GetObject("tsRefresh.Image"), System.Drawing.Image)
        Me.tsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsRefresh.Name = "tsRefresh"
        Me.tsRefresh.Size = New System.Drawing.Size(66, 22)
        Me.tsRefresh.Text = "&Refresh"
        '
        'tsCetak
        '
        Me.tsCetak.Image = CType(resources.GetObject("tsCetak.Image"), System.Drawing.Image)
        Me.tsCetak.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsCetak.Name = "tsCetak"
        Me.tsCetak.Size = New System.Drawing.Size(52, 22)
        Me.tsCetak.Text = "&Print"
        Me.tsCetak.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Image = CType(resources.GetObject("ToolStripLabel1.Image"), System.Drawing.Image)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(58, 22)
        Me.ToolStripLabel1.Text = "Search"
        '
        'txtKataKunci
        '
        Me.txtKataKunci.Name = "txtKataKunci"
        Me.txtKataKunci.Size = New System.Drawing.Size(100, 25)
        '
        'cboKriteria
        '
        Me.cboKriteria.Items.AddRange(New Object() {"Kode Retur", "No Faktur"})
        Me.cboKriteria.Name = "cboKriteria"
        Me.cboKriteria.Size = New System.Drawing.Size(121, 25)
        Me.cboKriteria.Sorted = True
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Retur *"
        '
        'txtKodeRetur
        '
        Me.txtKodeRetur.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLReturPenjualanHeaderBindingSource, "Kode_Retur", True))
        Me.txtKodeRetur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeRetur.Location = New System.Drawing.Point(156, 39)
        Me.txtKodeRetur.Name = "txtKodeRetur"
        Me.txtKodeRetur.ReadOnly = True
        Me.txtKodeRetur.Size = New System.Drawing.Size(151, 22)
        Me.txtKodeRetur.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "No Faktur *"
        '
        'txtNoFaktur
        '
        Me.txtNoFaktur.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLReturPenjualanHeaderBindingSource, "Kode_Penjualan", True))
        Me.txtNoFaktur.Enabled = False
        Me.txtNoFaktur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoFaktur.Location = New System.Drawing.Point(156, 67)
        Me.txtNoFaktur.Name = "txtNoFaktur"
        Me.txtNoFaktur.Size = New System.Drawing.Size(151, 22)
        Me.txtNoFaktur.TabIndex = 4
        '
        'dtpTanggal
        '
        Me.dtpTanggal.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBLReturPenjualanHeaderBindingSource, "Tanggal_Retur", True))
        Me.dtpTanggal.Location = New System.Drawing.Point(156, 95)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(200, 20)
        Me.dtpTanggal.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tanggal"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtIdDetail)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtSubtotal)
        Me.GroupBox1.Controls.Add(Me.txtDiskonRpDetail)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtDiskonPersenDetail)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtHargaJual)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.txtNo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtQty)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtBarcodeBarang)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 149)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(963, 76)
        Me.GroupBox1.TabIndex = 422
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(198, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 318
        Me.Label7.Text = "ID Detail *"
        '
        'txtIdDetail
        '
        Me.txtIdDetail.Enabled = False
        Me.txtIdDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdDetail.Location = New System.Drawing.Point(198, 32)
        Me.txtIdDetail.Name = "txtIdDetail"
        Me.txtIdDetail.Size = New System.Drawing.Size(59, 22)
        Me.txtIdDetail.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(619, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 316
        Me.Label9.Text = "Subtotal"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Enabled = False
        Me.txtSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotal.Location = New System.Drawing.Point(622, 32)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(160, 22)
        Me.txtSubtotal.TabIndex = 17
        '
        'txtDiskonRpDetail
        '
        Me.txtDiskonRpDetail.Enabled = False
        Me.txtDiskonRpDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiskonRpDetail.Location = New System.Drawing.Point(517, 32)
        Me.txtDiskonRpDetail.Name = "txtDiskonRpDetail"
        Me.txtDiskonRpDetail.Size = New System.Drawing.Size(99, 22)
        Me.txtDiskonRpDetail.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(514, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 315
        Me.Label10.Text = "Diskon Rp"
        '
        'txtDiskonPersenDetail
        '
        Me.txtDiskonPersenDetail.Enabled = False
        Me.txtDiskonPersenDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiskonPersenDetail.Location = New System.Drawing.Point(463, 33)
        Me.txtDiskonPersenDetail.Name = "txtDiskonPersenDetail"
        Me.txtDiskonPersenDetail.Size = New System.Drawing.Size(48, 22)
        Me.txtDiskonPersenDetail.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(460, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 13)
        Me.Label14.TabIndex = 314
        Me.Label14.Text = "Diskon %"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(325, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 313
        Me.Label15.Text = "Harga Jual"
        '
        'txtHargaJual
        '
        Me.txtHargaJual.Enabled = False
        Me.txtHargaJual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHargaJual.Location = New System.Drawing.Point(328, 32)
        Me.txtHargaJual.Name = "txtHargaJual"
        Me.txtHargaJual.Size = New System.Drawing.Size(129, 22)
        Me.txtHargaJual.TabIndex = 14
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(847, 32)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(57, 23)
        Me.btnReset.TabIndex = 19
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 304
        Me.Label6.Text = "No *"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(788, 32)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(54, 23)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtNo
        '
        Me.txtNo.Enabled = False
        Me.txtNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNo.Location = New System.Drawing.Point(15, 32)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(42, 22)
        Me.txtNo.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(263, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 88
        Me.Label11.Text = "Qty Retur *"
        '
        'txtQty
        '
        Me.txtQty.Enabled = False
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(263, 32)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(59, 22)
        Me.txtQty.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(60, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 13)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "Kode Barang"
        '
        'txtBarcodeBarang
        '
        Me.txtBarcodeBarang.Enabled = False
        Me.txtBarcodeBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcodeBarang.Location = New System.Drawing.Point(63, 32)
        Me.txtBarcodeBarang.Name = "txtBarcodeBarang"
        Me.txtBarcodeBarang.Size = New System.Drawing.Size(129, 22)
        Me.txtBarcodeBarang.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(103, 470)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 450
        Me.Label4.Text = "Total Qty"
        '
        'txtTotalQty
        '
        Me.txtTotalQty.BackColor = System.Drawing.Color.Bisque
        Me.txtTotalQty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLReturPenjualanHeaderBindingSource, "Total_Qty", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"))
        Me.txtTotalQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalQty.Location = New System.Drawing.Point(104, 486)
        Me.txtTotalQty.Name = "txtTotalQty"
        Me.txtTotalQty.ReadOnly = True
        Me.txtTotalQty.Size = New System.Drawing.Size(137, 26)
        Me.txtTotalQty.TabIndex = 449
        Me.txtTotalQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBLReturPenjualanHeaderQueryReturPenjualanBindingSource
        '
        Me.TBLReturPenjualanHeaderQueryReturPenjualanBindingSource.DataMember = "TBL_Retur_Penjualan_Header_Query_Retur_Penjualan"
        Me.TBLReturPenjualanHeaderQueryReturPenjualanBindingSource.DataSource = Me.TBLReturPenjualanHeaderBindingSource
        '
        'QueryReturPenjualanBindingSource
        '
        Me.QueryReturPenjualanBindingSource.DataMember = "Query_Retur_Penjualan"
        Me.QueryReturPenjualanBindingSource.DataSource = Me.Db_POS_CNDataSet
        '
        'txtTotalHarga
        '
        Me.txtTotalHarga.BackColor = System.Drawing.Color.Bisque
        Me.txtTotalHarga.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBLReturPenjualanHeaderBindingSource, "Total_Harga", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C0"))
        Me.txtTotalHarga.DataType = GetType(Decimal)
        Me.txtTotalHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalHarga.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtTotalHarga.Location = New System.Drawing.Point(777, 486)
        Me.txtTotalHarga.Name = "txtTotalHarga"
        Me.txtTotalHarga.ReadOnly = True
        Me.txtTotalHarga.Size = New System.Drawing.Size(194, 26)
        Me.txtTotalHarga.TabIndex = 447
        Me.txtTotalHarga.Tag = Nothing
        Me.txtTotalHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(774, 470)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 13)
        Me.Label16.TabIndex = 446
        Me.Label16.Text = "Total Harga"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(14, 470)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(77, 13)
        Me.Label18.TabIndex = 445
        Me.Label18.Text = "Banyak Item"
        '
        'txtJumlahItem
        '
        Me.txtJumlahItem.BackColor = System.Drawing.Color.Bisque
        Me.txtJumlahItem.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLReturPenjualanHeaderBindingSource, "Jumlah_Item", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"))
        Me.txtJumlahItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlahItem.Location = New System.Drawing.Point(15, 486)
        Me.txtJumlahItem.Name = "txtJumlahItem"
        Me.txtJumlahItem.ReadOnly = True
        Me.txtJumlahItem.Size = New System.Drawing.Size(62, 26)
        Me.txtJumlahItem.TabIndex = 444
        Me.txtJumlahItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cfgFaktur
        '
        Me.cfgFaktur.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.cfgFaktur.AllowEditing = False
        Me.cfgFaktur.AllowFiltering = True
        Me.cfgFaktur.ColumnInfo = resources.GetString("cfgFaktur.ColumnInfo")
        Me.cfgFaktur.DataSource = Me.QueryKodePenjualanReturBindingSource
        Me.cfgFaktur.Location = New System.Drawing.Point(156, 88)
        Me.cfgFaktur.Name = "cfgFaktur"
        Me.cfgFaktur.Rows.Count = 1
        Me.cfgFaktur.Rows.DefaultSize = 19
        Me.cfgFaktur.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.cfgFaktur.Size = New System.Drawing.Size(622, 230)
        Me.cfgFaktur.TabIndex = 451
        Me.cfgFaktur.Visible = False
        Me.cfgFaktur.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'QueryKodePenjualanReturBindingSource
        '
        Me.QueryKodePenjualanReturBindingSource.DataMember = "Query_Kode_Penjualan_Retur"
        Me.QueryKodePenjualanReturBindingSource.DataSource = Me.Db_POS_CNDataSet
        '
        'TBLBarangBindingSource
        '
        Me.TBLBarangBindingSource.DataMember = "TBL_Barang"
        Me.TBLBarangBindingSource.DataSource = Me.Db_POS_CNDataSet
        '
        'TBL_BarangTableAdapter
        '
        Me.TBL_BarangTableAdapter.ClearBeforeFill = True
        '
        'QueryPenjualanBindingSource
        '
        Me.QueryPenjualanBindingSource.DataMember = "Query_Penjualan"
        Me.QueryPenjualanBindingSource.DataSource = Me.Db_POS_CNDataSet
        '
        'Query_PenjualanTableAdapter
        '
        Me.Query_PenjualanTableAdapter.ClearBeforeFill = True
        '
        'Query_Kode_Penjualan_ReturTableAdapter
        '
        Me.Query_Kode_Penjualan_ReturTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Keterangan"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLReturPenjualanHeaderBindingSource, "Keterangan", True))
        Me.txtKeterangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeterangan.Location = New System.Drawing.Point(156, 121)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(682, 22)
        Me.txtKeterangan.TabIndex = 8
        '
        'TbL_Retur_Penjualan_DetailTableAdapter
        '
        Me.TbL_Retur_Penjualan_DetailTableAdapter.ClearBeforeFill = True
        '
        'TbL_Penjualan_DetailTableAdapter
        '
        Me.TbL_Penjualan_DetailTableAdapter.ClearBeforeFill = True
        '
        'TBL_Retur_Penjualan_HeaderTableAdapter
        '
        Me.TBL_Retur_Penjualan_HeaderTableAdapter.ClearBeforeFill = True
        '
        'Query_Retur_PenjualanTableAdapter
        '
        Me.Query_Retur_PenjualanTableAdapter.ClearBeforeFill = True
        '
        'TbL_PiutangTableAdapter
        '
        Me.TbL_PiutangTableAdapter.ClearBeforeFill = True
        '
        'dgvBarang
        '
        Me.dgvBarang.AllowUserToAddRows = False
        Me.dgvBarang.AllowUserToDeleteRows = False
        Me.dgvBarang.AutoGenerateColumns = False
        Me.dgvBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoBarisDataGridViewTextBoxColumn, Me.KodeBarangDataGridViewTextBoxColumn, Me.NamaBarangDataGridViewTextBoxColumn, Me.IDBarangDetailDataGridViewTextBoxColumn, Me.NamaBarangDetailDataGridViewTextBoxColumn, Me.HargaJualDataGridViewTextBoxColumn, Me.QtyJualDataGridViewTextBoxColumn, Me.DiskonPersenDataGridViewTextBoxColumn, Me.DiskonRpDataGridViewTextBoxColumn, Me.SubtotalDataGridViewTextBoxColumn})
        Me.dgvBarang.DataSource = Me.QueryPenjualanBindingSource
        Me.dgvBarang.Location = New System.Drawing.Point(30, 203)
        Me.dgvBarang.Name = "dgvBarang"
        Me.dgvBarang.ReadOnly = True
        Me.dgvBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBarang.Size = New System.Drawing.Size(898, 183)
        Me.dgvBarang.TabIndex = 452
        Me.dgvBarang.Visible = False
        '
        'NoBarisDataGridViewTextBoxColumn
        '
        Me.NoBarisDataGridViewTextBoxColumn.DataPropertyName = "No_Baris"
        Me.NoBarisDataGridViewTextBoxColumn.HeaderText = "No"
        Me.NoBarisDataGridViewTextBoxColumn.Name = "NoBarisDataGridViewTextBoxColumn"
        Me.NoBarisDataGridViewTextBoxColumn.ReadOnly = True
        Me.NoBarisDataGridViewTextBoxColumn.Width = 46
        '
        'KodeBarangDataGridViewTextBoxColumn
        '
        Me.KodeBarangDataGridViewTextBoxColumn.DataPropertyName = "Kode_Barang"
        Me.KodeBarangDataGridViewTextBoxColumn.HeaderText = "Kode Barang"
        Me.KodeBarangDataGridViewTextBoxColumn.Name = "KodeBarangDataGridViewTextBoxColumn"
        Me.KodeBarangDataGridViewTextBoxColumn.ReadOnly = True
        Me.KodeBarangDataGridViewTextBoxColumn.Width = 87
        '
        'NamaBarangDataGridViewTextBoxColumn
        '
        Me.NamaBarangDataGridViewTextBoxColumn.DataPropertyName = "Nama_Barang"
        Me.NamaBarangDataGridViewTextBoxColumn.HeaderText = "Nama Barang"
        Me.NamaBarangDataGridViewTextBoxColumn.Name = "NamaBarangDataGridViewTextBoxColumn"
        Me.NamaBarangDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamaBarangDataGridViewTextBoxColumn.Width = 89
        '
        'IDBarangDetailDataGridViewTextBoxColumn
        '
        Me.IDBarangDetailDataGridViewTextBoxColumn.DataPropertyName = "ID_Barang_Detail"
        Me.IDBarangDetailDataGridViewTextBoxColumn.HeaderText = "ID Detail"
        Me.IDBarangDetailDataGridViewTextBoxColumn.Name = "IDBarangDetailDataGridViewTextBoxColumn"
        Me.IDBarangDetailDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDBarangDetailDataGridViewTextBoxColumn.Width = 68
        '
        'NamaBarangDetailDataGridViewTextBoxColumn
        '
        Me.NamaBarangDetailDataGridViewTextBoxColumn.DataPropertyName = "Nama_Barang_Detail"
        Me.NamaBarangDetailDataGridViewTextBoxColumn.HeaderText = "Nama Barang Detail"
        Me.NamaBarangDetailDataGridViewTextBoxColumn.Name = "NamaBarangDetailDataGridViewTextBoxColumn"
        Me.NamaBarangDetailDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamaBarangDetailDataGridViewTextBoxColumn.Width = 116
        '
        'HargaJualDataGridViewTextBoxColumn
        '
        Me.HargaJualDataGridViewTextBoxColumn.DataPropertyName = "Harga_Jual"
        DataGridViewCellStyle31.Format = "N0"
        DataGridViewCellStyle31.NullValue = "0"
        Me.HargaJualDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle31
        Me.HargaJualDataGridViewTextBoxColumn.HeaderText = "Harga Jual"
        Me.HargaJualDataGridViewTextBoxColumn.Name = "HargaJualDataGridViewTextBoxColumn"
        Me.HargaJualDataGridViewTextBoxColumn.ReadOnly = True
        Me.HargaJualDataGridViewTextBoxColumn.Width = 77
        '
        'QtyJualDataGridViewTextBoxColumn
        '
        Me.QtyJualDataGridViewTextBoxColumn.DataPropertyName = "Qty_Jual"
        DataGridViewCellStyle32.Format = "N2"
        DataGridViewCellStyle32.NullValue = "0"
        Me.QtyJualDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle32
        Me.QtyJualDataGridViewTextBoxColumn.HeaderText = "Qty Jual"
        Me.QtyJualDataGridViewTextBoxColumn.Name = "QtyJualDataGridViewTextBoxColumn"
        Me.QtyJualDataGridViewTextBoxColumn.ReadOnly = True
        Me.QtyJualDataGridViewTextBoxColumn.Width = 65
        '
        'DiskonPersenDataGridViewTextBoxColumn
        '
        Me.DiskonPersenDataGridViewTextBoxColumn.DataPropertyName = "Diskon_Persen"
        DataGridViewCellStyle33.Format = "N2"
        DataGridViewCellStyle33.NullValue = "0"
        Me.DiskonPersenDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle33
        Me.DiskonPersenDataGridViewTextBoxColumn.HeaderText = "Disk. %"
        Me.DiskonPersenDataGridViewTextBoxColumn.Name = "DiskonPersenDataGridViewTextBoxColumn"
        Me.DiskonPersenDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiskonPersenDataGridViewTextBoxColumn.Width = 62
        '
        'DiskonRpDataGridViewTextBoxColumn
        '
        Me.DiskonRpDataGridViewTextBoxColumn.DataPropertyName = "Diskon_Rp"
        DataGridViewCellStyle34.Format = "N0"
        DataGridViewCellStyle34.NullValue = "0"
        Me.DiskonRpDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle34
        Me.DiskonRpDataGridViewTextBoxColumn.HeaderText = "Disk. Rp."
        Me.DiskonRpDataGridViewTextBoxColumn.Name = "DiskonRpDataGridViewTextBoxColumn"
        Me.DiskonRpDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiskonRpDataGridViewTextBoxColumn.Width = 70
        '
        'SubtotalDataGridViewTextBoxColumn
        '
        Me.SubtotalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal"
        DataGridViewCellStyle35.Format = "N0"
        DataGridViewCellStyle35.NullValue = "0"
        Me.SubtotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle35
        Me.SubtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.Name = "SubtotalDataGridViewTextBoxColumn"
        Me.SubtotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubtotalDataGridViewTextBoxColumn.Width = 71
        '
        'dgvPenjualan
        '
        Me.dgvPenjualan.AllowUserToAddRows = False
        Me.dgvPenjualan.AllowUserToDeleteRows = False
        Me.dgvPenjualan.AutoGenerateColumns = False
        Me.dgvPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPenjualan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoBarisDataGridViewTextBoxColumn1, Me.KodeBarangDataGridViewTextBoxColumn1, Me.NamaBarangDataGridViewTextBoxColumn1, Me.IDBarangDetailDataGridViewTextBoxColumn1, Me.NamaBarangDetailDataGridViewTextBoxColumn1, Me.HargaJualDataGridViewTextBoxColumn1, Me.QtyReturDataGridViewTextBoxColumn, Me.DiskonPersenDataGridViewTextBoxColumn1, Me.DiskonRpDataGridViewTextBoxColumn1, Me.SubtotalDataGridViewTextBoxColumn1})
        Me.dgvPenjualan.DataSource = Me.TBLReturPenjualanHeaderQueryReturPenjualanBindingSource
        Me.dgvPenjualan.Location = New System.Drawing.Point(17, 232)
        Me.dgvPenjualan.Name = "dgvPenjualan"
        Me.dgvPenjualan.ReadOnly = True
        Me.dgvPenjualan.Size = New System.Drawing.Size(961, 235)
        Me.dgvPenjualan.TabIndex = 453
        '
        'NoBarisDataGridViewTextBoxColumn1
        '
        Me.NoBarisDataGridViewTextBoxColumn1.DataPropertyName = "No_Baris"
        Me.NoBarisDataGridViewTextBoxColumn1.HeaderText = "No"
        Me.NoBarisDataGridViewTextBoxColumn1.Name = "NoBarisDataGridViewTextBoxColumn1"
        '
        'KodeBarangDataGridViewTextBoxColumn1
        '
        Me.KodeBarangDataGridViewTextBoxColumn1.DataPropertyName = "Kode_Barang"
        Me.KodeBarangDataGridViewTextBoxColumn1.HeaderText = "Kode Barang"
        Me.KodeBarangDataGridViewTextBoxColumn1.Name = "KodeBarangDataGridViewTextBoxColumn1"
        '
        'NamaBarangDataGridViewTextBoxColumn1
        '
        Me.NamaBarangDataGridViewTextBoxColumn1.DataPropertyName = "Nama_Barang"
        Me.NamaBarangDataGridViewTextBoxColumn1.HeaderText = "Nama Barang"
        Me.NamaBarangDataGridViewTextBoxColumn1.Name = "NamaBarangDataGridViewTextBoxColumn1"
        '
        'IDBarangDetailDataGridViewTextBoxColumn1
        '
        Me.IDBarangDetailDataGridViewTextBoxColumn1.DataPropertyName = "ID_Barang_Detail"
        Me.IDBarangDetailDataGridViewTextBoxColumn1.HeaderText = "ID Detail"
        Me.IDBarangDetailDataGridViewTextBoxColumn1.Name = "IDBarangDetailDataGridViewTextBoxColumn1"
        '
        'NamaBarangDetailDataGridViewTextBoxColumn1
        '
        Me.NamaBarangDetailDataGridViewTextBoxColumn1.DataPropertyName = "Nama_Barang_Detail"
        Me.NamaBarangDetailDataGridViewTextBoxColumn1.HeaderText = "Nama Barang Detail"
        Me.NamaBarangDetailDataGridViewTextBoxColumn1.Name = "NamaBarangDetailDataGridViewTextBoxColumn1"
        '
        'HargaJualDataGridViewTextBoxColumn1
        '
        Me.HargaJualDataGridViewTextBoxColumn1.DataPropertyName = "Harga_Jual"
        DataGridViewCellStyle36.Format = "N0"
        DataGridViewCellStyle36.NullValue = "0"
        Me.HargaJualDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle36
        Me.HargaJualDataGridViewTextBoxColumn1.HeaderText = "Harga Jual"
        Me.HargaJualDataGridViewTextBoxColumn1.Name = "HargaJualDataGridViewTextBoxColumn1"
        Me.HargaJualDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'QtyReturDataGridViewTextBoxColumn
        '
        Me.QtyReturDataGridViewTextBoxColumn.DataPropertyName = "Qty_Retur"
        DataGridViewCellStyle37.Format = "N2"
        DataGridViewCellStyle37.NullValue = "0"
        Me.QtyReturDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle37
        Me.QtyReturDataGridViewTextBoxColumn.HeaderText = "Qty Retur"
        Me.QtyReturDataGridViewTextBoxColumn.Name = "QtyReturDataGridViewTextBoxColumn"
        Me.QtyReturDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiskonPersenDataGridViewTextBoxColumn1
        '
        Me.DiskonPersenDataGridViewTextBoxColumn1.DataPropertyName = "Diskon_Persen"
        DataGridViewCellStyle38.Format = "N2"
        DataGridViewCellStyle38.NullValue = "0"
        Me.DiskonPersenDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle38
        Me.DiskonPersenDataGridViewTextBoxColumn1.HeaderText = "Disk. %"
        Me.DiskonPersenDataGridViewTextBoxColumn1.Name = "DiskonPersenDataGridViewTextBoxColumn1"
        Me.DiskonPersenDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DiskonRpDataGridViewTextBoxColumn1
        '
        Me.DiskonRpDataGridViewTextBoxColumn1.DataPropertyName = "Diskon_Rp"
        DataGridViewCellStyle39.Format = "N0"
        DataGridViewCellStyle39.NullValue = "0"
        Me.DiskonRpDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle39
        Me.DiskonRpDataGridViewTextBoxColumn1.HeaderText = "Disk. Rp."
        Me.DiskonRpDataGridViewTextBoxColumn1.Name = "DiskonRpDataGridViewTextBoxColumn1"
        Me.DiskonRpDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'SubtotalDataGridViewTextBoxColumn1
        '
        Me.SubtotalDataGridViewTextBoxColumn1.DataPropertyName = "Subtotal"
        DataGridViewCellStyle40.Format = "N0"
        DataGridViewCellStyle40.NullValue = "0"
        Me.SubtotalDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle40
        Me.SubtotalDataGridViewTextBoxColumn1.HeaderText = "Subtotal"
        Me.SubtotalDataGridViewTextBoxColumn1.Name = "SubtotalDataGridViewTextBoxColumn1"
        Me.SubtotalDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TbL_Barang_DetailTableAdapter
        '
        Me.TbL_Barang_DetailTableAdapter.ClearBeforeFill = True
        '
        'FRM_Retur_Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 525)
        Me.Controls.Add(Me.dgvBarang)
        Me.Controls.Add(Me.cfgFaktur)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotalQty)
        Me.Controls.Add(Me.txtTotalHarga)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtJumlahItem)
        Me.Controls.Add(Me.dtpTanggal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNoFaktur)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKodeRetur)
        Me.Controls.Add(Me.bnReturPenjualan)
        Me.Controls.Add(Me.dgvPenjualan)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FRM_Retur_Penjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form Retur Penjualan"
        CType(Me.bnReturPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnReturPenjualan.ResumeLayout(False)
        Me.bnReturPenjualan.PerformLayout()
        CType(Me.TBLReturPenjualanHeaderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_POS_CNDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TBLReturPenjualanHeaderQueryReturPenjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QueryReturPenjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalHarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cfgFaktur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QueryKodePenjualanReturBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QueryPenjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bnReturPenjualan As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsTambah As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSimpan As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsHapus As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsCetak As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtKataKunci As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents cboKriteria As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKodeRetur As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoFaktur As System.Windows.Forms.TextBox
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtBarcodeBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTotalQty As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalHarga As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtJumlahItem As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents txtDiskonRpDetail As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDiskonPersenDetail As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtHargaJual As System.Windows.Forms.TextBox
    Friend WithEvents cfgFaktur As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Db_POS_CNDataSet As Best_POS.db_POS_CNDataSet
    Friend WithEvents TBLBarangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_BarangTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_BarangTableAdapter
    Friend WithEvents QueryPenjualanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Query_PenjualanTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.Query_PenjualanTableAdapter
    Friend WithEvents QueryKodePenjualanReturBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Query_Kode_Penjualan_ReturTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.Query_Kode_Penjualan_ReturTableAdapter
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents TbL_Retur_Penjualan_DetailTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Retur_Penjualan_DetailTableAdapter
    Friend WithEvents TbL_Penjualan_DetailTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Penjualan_DetailTableAdapter
    Friend WithEvents TBLReturPenjualanHeaderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_Retur_Penjualan_HeaderTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Retur_Penjualan_HeaderTableAdapter
    Friend WithEvents QueryReturPenjualanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Query_Retur_PenjualanTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.Query_Retur_PenjualanTableAdapter
    Friend WithEvents TBLReturPenjualanHeaderQueryReturPenjualanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbL_PiutangTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_PiutangTableAdapter
    Friend WithEvents dgvBarang As System.Windows.Forms.DataGridView
    Friend WithEvents NoBarisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodeBarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDBarangDetailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarangDetailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargaJualDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyJualDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiskonPersenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiskonRpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubtotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvPenjualan As System.Windows.Forms.DataGridView
    Friend WithEvents NoBarisDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodeBarangDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarangDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDBarangDetailDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarangDetailDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargaJualDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyReturDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiskonPersenDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiskonRpDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubtotalDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtIdDetail As System.Windows.Forms.TextBox
    Friend WithEvents TbL_Barang_DetailTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Barang_DetailTableAdapter
End Class
