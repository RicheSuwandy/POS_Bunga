<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Penjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Penjualan))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.bnPenjualan = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TBLPenjualanHeaderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbPOSCNDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.tsWareHouse = New System.Windows.Forms.ToolStripButton()
        Me.tsCetak = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtKataKunci = New System.Windows.Forms.ToolStripTextBox()
        Me.cboKriteria = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtSisa = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtPmb = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtJenisPmb = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboCash = New System.Windows.Forms.CheckBox()
        Me.btnCetakFaktur = New System.Windows.Forms.Button()
        Me.btnKredit = New System.Windows.Forms.Button()
        Me.txtTotalBayar = New C1.Win.C1Input.C1TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTotalHarga = New C1.Win.C1Input.C1TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtJumlahItem = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvCustomer = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.TBLCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.nudHargaJualPersen = New System.Windows.Forms.NumericUpDown()
        Me.txtNamaDetail = New System.Windows.Forms.TextBox()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtIdDetail = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalDetail = New System.Windows.Forms.TextBox()
        Me.txtDiskonRpDetail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDiskonPersenDetail = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtHargaJual = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBarcodeBarang = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cfgSales = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.TBLSalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKodePenjualan = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotalHarga = New System.Windows.Forms.Label()
        Me.lblKembali = New System.Windows.Forms.Label()
        Me.TBLPenjualanHeaderQueryPenjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLPenjualanHeaderTBLPenjualanDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLBarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvBarang = New System.Windows.Forms.DataGridView()
        Me.KodeBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.G2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatuanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaJualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBLPenjualanDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotalQty = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtKodeSales = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAsc = New System.Windows.Forms.Button()
        Me.dgvBarangDetail = New System.Windows.Forms.DataGridView()
        Me.IDBarangDetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarangDetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBLBarangDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvPenjualan = New System.Windows.Forms.DataGridView()
        Me.NoBarisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeBarangDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarangDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDBarangDetailDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarangDetailDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaJualDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyJualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiskonPersenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiskonRpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBLPenjualanHeaderQueryPenjualanBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNoBon = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtBiayaLain = New C1.Win.C1Input.C1TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtDiskon = New C1.Win.C1Input.C1TextBox()
        Me.TBLPenjualanHeaderBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TbL_CustomerTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_CustomerTableAdapter()
        Me.TBL_BarangTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_BarangTableAdapter()
        Me.TbL_Harga_CustomerTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Harga_CustomerTableAdapter()
        Me.TbL_Penjualan_DetailTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Penjualan_DetailTableAdapter()
        Me.TBL_Penjualan_HeaderTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Penjualan_HeaderTableAdapter()
        Me.Query_PenjualanTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.Query_PenjualanTableAdapter()
        Me.TbL_PiutangTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_PiutangTableAdapter()
        Me.TbL_Alokasi_PenjualanTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Alokasi_PenjualanTableAdapter()
        Me.TbL_Retur_Penjualan_HeaderTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Retur_Penjualan_HeaderTableAdapter()
        Me.TBL_SalesTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_SalesTableAdapter()
        Me.TbL_Retur_Penjualan_DetailTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Retur_Penjualan_DetailTableAdapter()
        Me.TBL_Barang_DetailTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Barang_DetailTableAdapter()
        CType(Me.bnPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnPenjualan.SuspendLayout()
        CType(Me.TBLPenjualanHeaderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbPOSCNDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_POS_CNDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtTotalBayar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalHarga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHargaJualPersen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cfgSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLSalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TBLPenjualanHeaderQueryPenjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLPenjualanHeaderTBLPenjualanDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLPenjualanDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.dgvBarangDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBarangDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLPenjualanHeaderQueryPenjualanBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBiayaLain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiskon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLPenjualanHeaderBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bnPenjualan
        '
        Me.bnPenjualan.AddNewItem = Nothing
        Me.bnPenjualan.BindingSource = Me.TBLPenjualanHeaderBindingSource
        Me.bnPenjualan.CountItem = Me.BindingNavigatorCountItem
        Me.bnPenjualan.DeleteItem = Nothing
        Me.bnPenjualan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.tsTambah, Me.tsSimpan, Me.tsHapus, Me.tsRefresh, Me.tsWareHouse, Me.tsCetak, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.txtKataKunci, Me.cboKriteria, Me.ToolStripSeparator3})
        Me.bnPenjualan.Location = New System.Drawing.Point(0, 0)
        Me.bnPenjualan.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnPenjualan.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnPenjualan.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnPenjualan.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnPenjualan.Name = "bnPenjualan"
        Me.bnPenjualan.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.bnPenjualan.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnPenjualan.Size = New System.Drawing.Size(1328, 28)
        Me.bnPenjualan.TabIndex = 54
        Me.bnPenjualan.Text = "BindingNavigator1"
        '
        'TBLPenjualanHeaderBindingSource
        '
        Me.TBLPenjualanHeaderBindingSource.DataMember = "TBL_Penjualan_Header"
        Me.TBLPenjualanHeaderBindingSource.DataSource = Me.DbPOSCNDataSetBindingSource
        '
        'DbPOSCNDataSetBindingSource
        '
        Me.DbPOSCNDataSetBindingSource.DataSource = Me.Db_POS_CNDataSet
        Me.DbPOSCNDataSetBindingSource.Position = 0
        '
        'Db_POS_CNDataSet
        '
        Me.Db_POS_CNDataSet.DataSetName = "db_POS_CNDataSet"
        Me.Db_POS_CNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 25)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 25)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 25)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 28)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 25)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 25)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 28)
        '
        'tsTambah
        '
        Me.tsTambah.Image = CType(resources.GetObject("tsTambah.Image"), System.Drawing.Image)
        Me.tsTambah.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsTambah.Name = "tsTambah"
        Me.tsTambah.Size = New System.Drawing.Size(57, 25)
        Me.tsTambah.Text = "&Add"
        '
        'tsSimpan
        '
        Me.tsSimpan.Image = CType(resources.GetObject("tsSimpan.Image"), System.Drawing.Image)
        Me.tsSimpan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSimpan.Name = "tsSimpan"
        Me.tsSimpan.Size = New System.Drawing.Size(60, 25)
        Me.tsSimpan.Text = "&Save"
        '
        'tsHapus
        '
        Me.tsHapus.Image = CType(resources.GetObject("tsHapus.Image"), System.Drawing.Image)
        Me.tsHapus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsHapus.Name = "tsHapus"
        Me.tsHapus.Size = New System.Drawing.Size(73, 25)
        Me.tsHapus.Text = "&Delete"
        '
        'tsRefresh
        '
        Me.tsRefresh.Image = CType(resources.GetObject("tsRefresh.Image"), System.Drawing.Image)
        Me.tsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsRefresh.Name = "tsRefresh"
        Me.tsRefresh.Size = New System.Drawing.Size(78, 25)
        Me.tsRefresh.Text = "&Refresh"
        '
        'tsWareHouse
        '
        Me.tsWareHouse.Image = CType(resources.GetObject("tsWareHouse.Image"), System.Drawing.Image)
        Me.tsWareHouse.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsWareHouse.Name = "tsWareHouse"
        Me.tsWareHouse.Size = New System.Drawing.Size(102, 25)
        Me.tsWareHouse.Text = "&Warehouse"
        Me.tsWareHouse.Visible = False
        '
        'tsCetak
        '
        Me.tsCetak.Image = CType(resources.GetObject("tsCetak.Image"), System.Drawing.Image)
        Me.tsCetak.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsCetak.Name = "tsCetak"
        Me.tsCetak.Size = New System.Drawing.Size(59, 25)
        Me.tsCetak.Text = "&Print"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Image = CType(resources.GetObject("ToolStripLabel1.Image"), System.Drawing.Image)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(69, 25)
        Me.ToolStripLabel1.Text = "Search"
        '
        'txtKataKunci
        '
        Me.txtKataKunci.Name = "txtKataKunci"
        Me.txtKataKunci.Size = New System.Drawing.Size(132, 28)
        '
        'cboKriteria
        '
        Me.cboKriteria.Items.AddRange(New Object() {"No Faktur", "No. Bon"})
        Me.cboKriteria.Name = "cboKriteria"
        Me.cboKriteria.Size = New System.Drawing.Size(108, 28)
        Me.cboKriteria.Sorted = True
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 28)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtSisa)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.txtPmb)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.txtJenisPmb)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Location = New System.Drawing.Point(23, 683)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(393, 66)
        Me.GroupBox3.TabIndex = 437
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Keterangan"
        Me.GroupBox3.Visible = False
        '
        'txtSisa
        '
        Me.txtSisa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLPenjualanHeaderBindingSource, "Sisa_Pembayaran", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C0"))
        Me.txtSisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSisa.Location = New System.Drawing.Point(157, 27)
        Me.txtSisa.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSisa.Name = "txtSisa"
        Me.txtSisa.ReadOnly = True
        Me.txtSisa.Size = New System.Drawing.Size(219, 23)
        Me.txtSisa.TabIndex = 5
        Me.txtSisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(108, 30)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(39, 17)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "Sisa"
        '
        'txtPmb
        '
        Me.txtPmb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLPenjualanHeaderBindingSource, "Pembayaran", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C0"))
        Me.txtPmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPmb.Location = New System.Drawing.Point(157, 27)
        Me.txtPmb.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPmb.Name = "txtPmb"
        Me.txtPmb.ReadOnly = True
        Me.txtPmb.Size = New System.Drawing.Size(210, 23)
        Me.txtPmb.TabIndex = 3
        Me.txtPmb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(6, 30)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(134, 17)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Pembayaran / DP"
        '
        'txtJenisPmb
        '
        Me.txtJenisPmb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLPenjualanHeaderBindingSource, "Jenis_Pembayaran", True))
        Me.txtJenisPmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJenisPmb.Location = New System.Drawing.Point(157, 27)
        Me.txtJenisPmb.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJenisPmb.Name = "txtJenisPmb"
        Me.txtJenisPmb.ReadOnly = True
        Me.txtJenisPmb.Size = New System.Drawing.Size(89, 23)
        Me.txtJenisPmb.TabIndex = 1
        Me.txtJenisPmb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(4, 30)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(141, 17)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Jenis Pembayaran"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboCash)
        Me.GroupBox2.Controls.Add(Me.btnCetakFaktur)
        Me.GroupBox2.Controls.Add(Me.btnKredit)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 628)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(449, 47)
        Me.GroupBox2.TabIndex = 436
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'cboCash
        '
        Me.cboCash.AutoSize = True
        Me.cboCash.Enabled = False
        Me.cboCash.Location = New System.Drawing.Point(12, 17)
        Me.cboCash.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCash.Name = "cboCash"
        Me.cboCash.Size = New System.Drawing.Size(95, 21)
        Me.cboCash.TabIndex = 421
        Me.cboCash.Text = "CASH [F3]"
        Me.cboCash.UseVisualStyleBackColor = True
        Me.cboCash.Visible = False
        '
        'btnCetakFaktur
        '
        Me.btnCetakFaktur.Location = New System.Drawing.Point(255, 14)
        Me.btnCetakFaktur.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCetakFaktur.Name = "btnCetakFaktur"
        Me.btnCetakFaktur.Size = New System.Drawing.Size(185, 28)
        Me.btnCetakFaktur.TabIndex = 420
        Me.btnCetakFaktur.Text = "CETAK FAKTUR [F5]"
        Me.btnCetakFaktur.UseVisualStyleBackColor = True
        Me.btnCetakFaktur.Visible = False
        '
        'btnKredit
        '
        Me.btnKredit.Enabled = False
        Me.btnKredit.Location = New System.Drawing.Point(121, 14)
        Me.btnKredit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnKredit.Name = "btnKredit"
        Me.btnKredit.Size = New System.Drawing.Size(115, 28)
        Me.btnKredit.TabIndex = 418
        Me.btnKredit.Text = "KREDIT [F4]"
        Me.btnKredit.UseVisualStyleBackColor = True
        Me.btnKredit.Visible = False
        '
        'txtTotalBayar
        '
        Me.txtTotalBayar.BackColor = System.Drawing.Color.Bisque
        Me.txtTotalBayar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBLPenjualanHeaderBindingSource, "Pembayaran", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C2"))
        Me.txtTotalBayar.DataType = GetType(Decimal)
        Me.txtTotalBayar.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtTotalBayar.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtTotalBayar.DisplayFormat.NullText = "0"
        Me.txtTotalBayar.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtTotalBayar.EditFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtTotalBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalBayar.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtTotalBayar.Location = New System.Drawing.Point(1036, 698)
        Me.txtTotalBayar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalBayar.Name = "txtTotalBayar"
        Me.txtTotalBayar.Size = New System.Drawing.Size(260, 28)
        Me.txtTotalBayar.TabIndex = 405
        Me.txtTotalBayar.Tag = Nothing
        Me.txtTotalBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(842, 703)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 20)
        Me.Label13.TabIndex = 95
        Me.Label13.Text = "Total Bayar"
        '
        'txtTotalHarga
        '
        Me.txtTotalHarga.BackColor = System.Drawing.Color.Bisque
        Me.txtTotalHarga.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBLPenjualanHeaderBindingSource, "Total_Harga", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C2"))
        Me.txtTotalHarga.DataType = GetType(Decimal)
        Me.txtTotalHarga.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtTotalHarga.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtTotalHarga.DisplayFormat.NullText = "0"
        Me.txtTotalHarga.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtTotalHarga.EditFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtTotalHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalHarga.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtTotalHarga.Location = New System.Drawing.Point(1036, 588)
        Me.txtTotalHarga.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalHarga.Name = "txtTotalHarga"
        Me.txtTotalHarga.ReadOnly = True
        Me.txtTotalHarga.Size = New System.Drawing.Size(259, 28)
        Me.txtTotalHarga.TabIndex = 433
        Me.txtTotalHarga.Tag = Nothing
        Me.txtTotalHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(19, 571)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 17)
        Me.Label18.TabIndex = 423
        Me.Label18.Text = "Banyak Item"
        '
        'txtJumlahItem
        '
        Me.txtJumlahItem.BackColor = System.Drawing.Color.Bisque
        Me.txtJumlahItem.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLPenjualanHeaderBindingSource, "Jumlah_Item", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"))
        Me.txtJumlahItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlahItem.Location = New System.Drawing.Point(20, 590)
        Me.txtJumlahItem.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJumlahItem.Name = "txtJumlahItem"
        Me.txtJumlahItem.ReadOnly = True
        Me.txtJumlahItem.Size = New System.Drawing.Size(81, 30)
        Me.txtJumlahItem.TabIndex = 421
        Me.txtJumlahItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvCustomer)
        Me.GroupBox1.Controls.Add(Me.nudHargaJualPersen)
        Me.GroupBox1.Controls.Add(Me.txtNamaDetail)
        Me.GroupBox1.Controls.Add(Me.txtNamaBarang)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtIdDetail)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtTotalDetail)
        Me.GroupBox1.Controls.Add(Me.txtDiskonRpDetail)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDiskonPersenDetail)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtHargaJual)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtQty)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtBarcodeBarang)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 183)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1284, 119)
        Me.GroupBox1.TabIndex = 420
        Me.GroupBox1.TabStop = False
        '
        'dgvCustomer
        '
        Me.dgvCustomer.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.dgvCustomer.AllowEditing = False
        Me.dgvCustomer.AllowFiltering = True
        Me.dgvCustomer.ColumnInfo = resources.GetString("dgvCustomer.ColumnInfo")
        Me.dgvCustomer.DataSource = Me.TBLCustomerBindingSource
        Me.dgvCustomer.Location = New System.Drawing.Point(188, 0)
        Me.dgvCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCustomer.Name = "dgvCustomer"
        Me.dgvCustomer.Rows.Count = 1
        Me.dgvCustomer.Rows.DefaultSize = 19
        Me.dgvCustomer.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.dgvCustomer.Size = New System.Drawing.Size(969, 282)
        Me.dgvCustomer.TabIndex = 449
        Me.dgvCustomer.Visible = False
        Me.dgvCustomer.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'TBLCustomerBindingSource
        '
        Me.TBLCustomerBindingSource.DataMember = "TBL_Customer"
        Me.TBLCustomerBindingSource.DataSource = Me.DbPOSCNDataSetBindingSource
        '
        'nudHargaJualPersen
        '
        Me.nudHargaJualPersen.DecimalPlaces = 2
        Me.nudHargaJualPersen.Location = New System.Drawing.Point(397, 78)
        Me.nudHargaJualPersen.Name = "nudHargaJualPersen"
        Me.nudHargaJualPersen.Size = New System.Drawing.Size(82, 22)
        Me.nudHargaJualPersen.TabIndex = 309
        '
        'txtNamaDetail
        '
        Me.txtNamaDetail.Enabled = False
        Me.txtNamaDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaDetail.Location = New System.Drawing.Point(199, 78)
        Me.txtNamaDetail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNamaDetail.Name = "txtNamaDetail"
        Me.txtNamaDetail.ReadOnly = True
        Me.txtNamaDetail.Size = New System.Drawing.Size(123, 26)
        Me.txtNamaDetail.TabIndex = 308
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Enabled = False
        Me.txtNamaBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaBarang.Location = New System.Drawing.Point(19, 78)
        Me.txtNamaBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.ReadOnly = True
        Me.txtNamaBarang.Size = New System.Drawing.Size(171, 26)
        Me.txtNamaBarang.TabIndex = 307
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(195, 22)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 17)
        Me.Label17.TabIndex = 306
        Me.Label17.Text = "ID Detail *"
        '
        'txtIdDetail
        '
        Me.txtIdDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdDetail.Location = New System.Drawing.Point(199, 42)
        Me.txtIdDetail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdDetail.Name = "txtIdDetail"
        Me.txtIdDetail.Size = New System.Drawing.Size(123, 26)
        Me.txtIdDetail.TabIndex = 81
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(478, 22)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(26, 17)
        Me.Label23.TabIndex = 302
        Me.Label23.Text = "F2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(786, 22)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 17)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "Total"
        '
        'txtTotalDetail
        '
        Me.txtTotalDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDetail.Location = New System.Drawing.Point(789, 42)
        Me.txtTotalDetail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalDetail.Name = "txtTotalDetail"
        Me.txtTotalDetail.Size = New System.Drawing.Size(212, 26)
        Me.txtTotalDetail.TabIndex = 87
        '
        'txtDiskonRpDetail
        '
        Me.txtDiskonRpDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiskonRpDetail.Location = New System.Drawing.Point(649, 42)
        Me.txtDiskonRpDetail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiskonRpDetail.Name = "txtDiskonRpDetail"
        Me.txtDiskonRpDetail.ReadOnly = True
        Me.txtDiskonRpDetail.Size = New System.Drawing.Size(130, 26)
        Me.txtDiskonRpDetail.TabIndex = 86
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(645, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Diskon Rp"
        '
        'txtDiskonPersenDetail
        '
        Me.txtDiskonPersenDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiskonPersenDetail.Location = New System.Drawing.Point(578, 43)
        Me.txtDiskonPersenDetail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiskonPersenDetail.Name = "txtDiskonPersenDetail"
        Me.txtDiskonPersenDetail.ReadOnly = True
        Me.txtDiskonPersenDetail.Size = New System.Drawing.Size(63, 26)
        Me.txtDiskonPersenDetail.TabIndex = 85
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(1118, 43)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 28)
        Me.btnReset.TabIndex = 89
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(573, 21)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 17)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Diskon %"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(115, 22)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 17)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "F1"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(1011, 43)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 28)
        Me.btnAdd.TabIndex = 88
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(393, 22)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 17)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "Harga Jual *"
        '
        'txtHargaJual
        '
        Me.txtHargaJual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHargaJual.Location = New System.Drawing.Point(397, 42)
        Me.txtHargaJual.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHargaJual.Name = "txtHargaJual"
        Me.txtHargaJual.Size = New System.Drawing.Size(171, 26)
        Me.txtHargaJual.TabIndex = 84
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(333, 22)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 17)
        Me.Label11.TabIndex = 88
        Me.Label11.Text = "Qty *"
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(333, 42)
        Me.txtQty.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.ReadOnly = True
        Me.txtQty.Size = New System.Drawing.Size(55, 26)
        Me.txtQty.TabIndex = 83
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(14, 22)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 17)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "Kode Barang *"
        '
        'txtBarcodeBarang
        '
        Me.txtBarcodeBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcodeBarang.Location = New System.Drawing.Point(19, 42)
        Me.txtBarcodeBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBarcodeBarang.Name = "txtBarcodeBarang"
        Me.txtBarcodeBarang.ReadOnly = True
        Me.txtBarcodeBarang.Size = New System.Drawing.Size(171, 26)
        Me.txtBarcodeBarang.TabIndex = 80
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(484, 80)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(20, 17)
        Me.Label24.TabIndex = 310
        Me.Label24.Text = "%"
        '
        'cfgSales
        '
        Me.cfgSales.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.cfgSales.AllowEditing = False
        Me.cfgSales.AllowFiltering = True
        Me.cfgSales.ColumnInfo = resources.GetString("cfgSales.ColumnInfo")
        Me.cfgSales.DataSource = Me.TBLSalesBindingSource
        Me.cfgSales.Location = New System.Drawing.Point(208, 183)
        Me.cfgSales.Margin = New System.Windows.Forms.Padding(4)
        Me.cfgSales.Name = "cfgSales"
        Me.cfgSales.Rows.Count = 1
        Me.cfgSales.Rows.DefaultSize = 19
        Me.cfgSales.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.cfgSales.Size = New System.Drawing.Size(969, 282)
        Me.cfgSales.TabIndex = 447
        Me.cfgSales.Visible = False
        Me.cfgSales.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'TBLSalesBindingSource
        '
        Me.TBLSalesBindingSource.DataMember = "TBL_Sales"
        Me.TBLSalesBindingSource.DataSource = Me.Db_POS_CNDataSet
        '
        'dtpTanggal
        '
        Me.dtpTanggal.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBLPenjualanHeaderBindingSource, "Tanggal_Jual", True))
        Me.dtpTanggal.Location = New System.Drawing.Point(208, 82)
        Me.dtpTanggal.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(265, 22)
        Me.dtpTanggal.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 118)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Kode Customer *"
        '
        'txtCustomer
        '
        Me.txtCustomer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLPenjualanHeaderBindingSource, "Kode_Customer", True))
        Me.txtCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomer.Location = New System.Drawing.Point(208, 114)
        Me.txtCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(157, 26)
        Me.txtCustomer.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 86)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 52)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No Faktur *"
        '
        'txtKodePenjualan
        '
        Me.txtKodePenjualan.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLPenjualanHeaderBindingSource, "Kode_Penjualan", True))
        Me.txtKodePenjualan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodePenjualan.Location = New System.Drawing.Point(208, 48)
        Me.txtKodePenjualan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKodePenjualan.Name = "txtKodePenjualan"
        Me.txtKodePenjualan.ReadOnly = True
        Me.txtKodePenjualan.Size = New System.Drawing.Size(200, 26)
        Me.txtKodePenjualan.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.lblTotalHarga)
        Me.Panel1.Controls.Add(Me.lblKembali)
        Me.Panel1.Location = New System.Drawing.Point(772, 48)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(532, 94)
        Me.Panel1.TabIndex = 429
        '
        'lblTotalHarga
        '
        Me.lblTotalHarga.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotalHarga.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLPenjualanHeaderBindingSource, "Total_Harga", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C0"))
        Me.lblTotalHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalHarga.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblTotalHarga.Location = New System.Drawing.Point(128, 26)
        Me.lblTotalHarga.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalHarga.Name = "lblTotalHarga"
        Me.lblTotalHarga.Size = New System.Drawing.Size(394, 46)
        Me.lblTotalHarga.TabIndex = 402
        Me.lblTotalHarga.Text = "0"
        Me.lblTotalHarga.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblKembali
        '
        Me.lblKembali.AutoSize = True
        Me.lblKembali.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKembali.ForeColor = System.Drawing.Color.Chartreuse
        Me.lblKembali.Location = New System.Drawing.Point(4, 5)
        Me.lblKembali.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKembali.Name = "lblKembali"
        Me.lblKembali.Size = New System.Drawing.Size(84, 25)
        Me.lblKembali.TabIndex = 401
        Me.lblKembali.Text = "TOTAL"
        '
        'TBLPenjualanHeaderQueryPenjualanBindingSource
        '
        Me.TBLPenjualanHeaderQueryPenjualanBindingSource.DataMember = "TBL_Penjualan_Header_Query_Penjualan"
        Me.TBLPenjualanHeaderQueryPenjualanBindingSource.DataSource = Me.TBLPenjualanHeaderBindingSource
        '
        'TBLPenjualanHeaderTBLPenjualanDetailBindingSource
        '
        Me.TBLPenjualanHeaderTBLPenjualanDetailBindingSource.DataMember = "TBL_Penjualan_Header_TBL_Penjualan_Detail"
        Me.TBLPenjualanHeaderTBLPenjualanDetailBindingSource.DataSource = Me.TBLPenjualanHeaderBindingSource
        '
        'TBLBarangBindingSource
        '
        Me.TBLBarangBindingSource.DataMember = "TBL_Barang"
        Me.TBLBarangBindingSource.DataSource = Me.DbPOSCNDataSetBindingSource
        '
        'dgvBarang
        '
        Me.dgvBarang.AllowUserToAddRows = False
        Me.dgvBarang.AllowUserToDeleteRows = False
        Me.dgvBarang.AutoGenerateColumns = False
        Me.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeBarangDataGridViewTextBoxColumn, Me.NamaBarangDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn, Me.G1, Me.G2, Me.SatuanDataGridViewTextBoxColumn, Me.HargaJualDataGridViewTextBoxColumn})
        Me.dgvBarang.DataSource = Me.TBLBarangBindingSource
        Me.dgvBarang.Location = New System.Drawing.Point(39, 295)
        Me.dgvBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvBarang.MultiSelect = False
        Me.dgvBarang.Name = "dgvBarang"
        Me.dgvBarang.ReadOnly = True
        Me.dgvBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBarang.Size = New System.Drawing.Size(1032, 272)
        Me.dgvBarang.TabIndex = 441
        Me.dgvBarang.Visible = False
        '
        'KodeBarangDataGridViewTextBoxColumn
        '
        Me.KodeBarangDataGridViewTextBoxColumn.DataPropertyName = "Kode_Barang"
        Me.KodeBarangDataGridViewTextBoxColumn.HeaderText = "Kode"
        Me.KodeBarangDataGridViewTextBoxColumn.Name = "KodeBarangDataGridViewTextBoxColumn"
        Me.KodeBarangDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamaBarangDataGridViewTextBoxColumn
        '
        Me.NamaBarangDataGridViewTextBoxColumn.DataPropertyName = "Nama_Barang"
        Me.NamaBarangDataGridViewTextBoxColumn.HeaderText = "Nama"
        Me.NamaBarangDataGridViewTextBoxColumn.Name = "NamaBarangDataGridViewTextBoxColumn"
        Me.NamaBarangDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QtyDataGridViewTextBoxColumn
        '
        Me.QtyDataGridViewTextBoxColumn.DataPropertyName = "Qty"
        Me.QtyDataGridViewTextBoxColumn.HeaderText = "Qty"
        Me.QtyDataGridViewTextBoxColumn.Name = "QtyDataGridViewTextBoxColumn"
        Me.QtyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'G1
        '
        Me.G1.DataPropertyName = "G1"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.G1.DefaultCellStyle = DataGridViewCellStyle1
        Me.G1.HeaderText = "Gudang 1"
        Me.G1.Name = "G1"
        Me.G1.ReadOnly = True
        '
        'G2
        '
        Me.G2.DataPropertyName = "G2"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.G2.DefaultCellStyle = DataGridViewCellStyle2
        Me.G2.HeaderText = "Gudang 2"
        Me.G2.Name = "G2"
        Me.G2.ReadOnly = True
        '
        'SatuanDataGridViewTextBoxColumn
        '
        Me.SatuanDataGridViewTextBoxColumn.DataPropertyName = "Satuan"
        Me.SatuanDataGridViewTextBoxColumn.HeaderText = "Satuan"
        Me.SatuanDataGridViewTextBoxColumn.Name = "SatuanDataGridViewTextBoxColumn"
        Me.SatuanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HargaJualDataGridViewTextBoxColumn
        '
        Me.HargaJualDataGridViewTextBoxColumn.DataPropertyName = "Harga_Jual"
        DataGridViewCellStyle3.Format = "C0"
        DataGridViewCellStyle3.NullValue = "0"
        Me.HargaJualDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.HargaJualDataGridViewTextBoxColumn.HeaderText = "Harga Jual"
        Me.HargaJualDataGridViewTextBoxColumn.Name = "HargaJualDataGridViewTextBoxColumn"
        Me.HargaJualDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TBLPenjualanDetailBindingSource
        '
        Me.TBLPenjualanDetailBindingSource.DataMember = "TBL_Penjualan_Detail"
        Me.TBLPenjualanDetailBindingSource.DataSource = Me.DbPOSCNDataSetBindingSource
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(137, 571)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 17)
        Me.Label7.TabIndex = 443
        Me.Label7.Text = "Total Qty"
        '
        'txtTotalQty
        '
        Me.txtTotalQty.BackColor = System.Drawing.Color.Bisque
        Me.txtTotalQty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLPenjualanHeaderBindingSource, "Total_Qty", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"))
        Me.txtTotalQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalQty.Location = New System.Drawing.Point(139, 590)
        Me.txtTotalQty.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalQty.Name = "txtTotalQty"
        Me.txtTotalQty.ReadOnly = True
        Me.txtTotalQty.Size = New System.Drawing.Size(182, 30)
        Me.txtTotalQty.TabIndex = 442
        Me.txtTotalQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(457, 155)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 17)
        Me.Label14.TabIndex = 446
        Me.Label14.Text = "Enter"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 153)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 20)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Kode Sales *"
        '
        'txtKodeSales
        '
        Me.txtKodeSales.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLPenjualanHeaderBindingSource, "Kode_Sales", True))
        Me.txtKodeSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeSales.Location = New System.Drawing.Point(208, 149)
        Me.txtKodeSales.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKodeSales.Name = "txtKodeSales"
        Me.txtKodeSales.Size = New System.Drawing.Size(240, 26)
        Me.txtKodeSales.TabIndex = 8
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SortToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(106, 28)
        '
        'SortToolStripMenuItem
        '
        Me.SortToolStripMenuItem.Name = "SortToolStripMenuItem"
        Me.SortToolStripMenuItem.Size = New System.Drawing.Size(105, 24)
        Me.SortToolStripMenuItem.Text = "Sort"
        '
        'btnAsc
        '
        Me.btnAsc.BackColor = System.Drawing.SystemColors.Control
        Me.btnAsc.Cursor = System.Windows.Forms.Cursors.UpArrow
        Me.btnAsc.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsc.Location = New System.Drawing.Point(93, 286)
        Me.btnAsc.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAsc.Name = "btnAsc"
        Me.btnAsc.Size = New System.Drawing.Size(27, 22)
        Me.btnAsc.TabIndex = 449
        Me.btnAsc.Text = "..."
        Me.btnAsc.UseVisualStyleBackColor = False
        Me.btnAsc.Visible = False
        '
        'dgvBarangDetail
        '
        Me.dgvBarangDetail.AllowUserToAddRows = False
        Me.dgvBarangDetail.AllowUserToDeleteRows = False
        Me.dgvBarangDetail.AutoGenerateColumns = False
        Me.dgvBarangDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvBarangDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBarangDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDBarangDetailDataGridViewTextBoxColumn, Me.NamaBarangDetailDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn1})
        Me.dgvBarangDetail.DataSource = Me.TBLBarangDetailBindingSource
        Me.dgvBarangDetail.Location = New System.Drawing.Point(221, 295)
        Me.dgvBarangDetail.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvBarangDetail.Name = "dgvBarangDetail"
        Me.dgvBarangDetail.ReadOnly = True
        Me.dgvBarangDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBarangDetail.Size = New System.Drawing.Size(612, 185)
        Me.dgvBarangDetail.TabIndex = 450
        Me.dgvBarangDetail.Visible = False
        '
        'IDBarangDetailDataGridViewTextBoxColumn
        '
        Me.IDBarangDetailDataGridViewTextBoxColumn.DataPropertyName = "ID_Barang_Detail"
        Me.IDBarangDetailDataGridViewTextBoxColumn.HeaderText = "ID Detail"
        Me.IDBarangDetailDataGridViewTextBoxColumn.Name = "IDBarangDetailDataGridViewTextBoxColumn"
        Me.IDBarangDetailDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDBarangDetailDataGridViewTextBoxColumn.Width = 79
        '
        'NamaBarangDetailDataGridViewTextBoxColumn
        '
        Me.NamaBarangDetailDataGridViewTextBoxColumn.DataPropertyName = "Nama_Barang_Detail"
        Me.NamaBarangDetailDataGridViewTextBoxColumn.HeaderText = "Nama Barang Detail"
        Me.NamaBarangDetailDataGridViewTextBoxColumn.Name = "NamaBarangDetailDataGridViewTextBoxColumn"
        Me.NamaBarangDetailDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamaBarangDetailDataGridViewTextBoxColumn.Width = 146
        '
        'QtyDataGridViewTextBoxColumn1
        '
        Me.QtyDataGridViewTextBoxColumn1.DataPropertyName = "Qty"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.QtyDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle4
        Me.QtyDataGridViewTextBoxColumn1.HeaderText = "Qty"
        Me.QtyDataGridViewTextBoxColumn1.Name = "QtyDataGridViewTextBoxColumn1"
        Me.QtyDataGridViewTextBoxColumn1.ReadOnly = True
        Me.QtyDataGridViewTextBoxColumn1.Width = 55
        '
        'TBLBarangDetailBindingSource
        '
        Me.TBLBarangDetailBindingSource.DataMember = "TBL_Barang_Detail"
        Me.TBLBarangDetailBindingSource.DataSource = Me.Db_POS_CNDataSet
        '
        'dgvPenjualan
        '
        Me.dgvPenjualan.AllowUserToAddRows = False
        Me.dgvPenjualan.AllowUserToDeleteRows = False
        Me.dgvPenjualan.AutoGenerateColumns = False
        Me.dgvPenjualan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPenjualan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoBarisDataGridViewTextBoxColumn, Me.KodeBarangDataGridViewTextBoxColumn1, Me.NamaBarangDataGridViewTextBoxColumn1, Me.IDBarangDetailDataGridViewTextBoxColumn1, Me.NamaBarangDetailDataGridViewTextBoxColumn1, Me.HargaJualDataGridViewTextBoxColumn1, Me.QtyJualDataGridViewTextBoxColumn, Me.DiskonPersenDataGridViewTextBoxColumn, Me.DiskonRpDataGridViewTextBoxColumn, Me.SubtotalDataGridViewTextBoxColumn})
        Me.dgvPenjualan.DataSource = Me.TBLPenjualanHeaderQueryPenjualanBindingSource1
        Me.dgvPenjualan.Location = New System.Drawing.Point(20, 326)
        Me.dgvPenjualan.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvPenjualan.Name = "dgvPenjualan"
        Me.dgvPenjualan.ReadOnly = True
        Me.dgvPenjualan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPenjualan.Size = New System.Drawing.Size(1284, 242)
        Me.dgvPenjualan.TabIndex = 451
        '
        'NoBarisDataGridViewTextBoxColumn
        '
        Me.NoBarisDataGridViewTextBoxColumn.DataPropertyName = "No_Baris"
        Me.NoBarisDataGridViewTextBoxColumn.HeaderText = "No"
        Me.NoBarisDataGridViewTextBoxColumn.Name = "NoBarisDataGridViewTextBoxColumn"
        Me.NoBarisDataGridViewTextBoxColumn.ReadOnly = True
        Me.NoBarisDataGridViewTextBoxColumn.Width = 51
        '
        'KodeBarangDataGridViewTextBoxColumn1
        '
        Me.KodeBarangDataGridViewTextBoxColumn1.DataPropertyName = "Kode_Barang"
        Me.KodeBarangDataGridViewTextBoxColumn1.HeaderText = "Kode Barang"
        Me.KodeBarangDataGridViewTextBoxColumn1.Name = "KodeBarangDataGridViewTextBoxColumn1"
        Me.KodeBarangDataGridViewTextBoxColumn1.ReadOnly = True
        Me.KodeBarangDataGridViewTextBoxColumn1.Width = 106
        '
        'NamaBarangDataGridViewTextBoxColumn1
        '
        Me.NamaBarangDataGridViewTextBoxColumn1.DataPropertyName = "Nama_Barang"
        Me.NamaBarangDataGridViewTextBoxColumn1.HeaderText = "Nama Barang"
        Me.NamaBarangDataGridViewTextBoxColumn1.Name = "NamaBarangDataGridViewTextBoxColumn1"
        Me.NamaBarangDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NamaBarangDataGridViewTextBoxColumn1.Width = 110
        '
        'IDBarangDetailDataGridViewTextBoxColumn1
        '
        Me.IDBarangDetailDataGridViewTextBoxColumn1.DataPropertyName = "ID_Barang_Detail"
        Me.IDBarangDetailDataGridViewTextBoxColumn1.HeaderText = "ID Detail"
        Me.IDBarangDetailDataGridViewTextBoxColumn1.Name = "IDBarangDetailDataGridViewTextBoxColumn1"
        Me.IDBarangDetailDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDBarangDetailDataGridViewTextBoxColumn1.Width = 79
        '
        'NamaBarangDetailDataGridViewTextBoxColumn1
        '
        Me.NamaBarangDetailDataGridViewTextBoxColumn1.DataPropertyName = "Nama_Barang_Detail"
        Me.NamaBarangDetailDataGridViewTextBoxColumn1.HeaderText = "Nama Barang Detail"
        Me.NamaBarangDetailDataGridViewTextBoxColumn1.Name = "NamaBarangDetailDataGridViewTextBoxColumn1"
        Me.NamaBarangDetailDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NamaBarangDetailDataGridViewTextBoxColumn1.Width = 146
        '
        'HargaJualDataGridViewTextBoxColumn1
        '
        Me.HargaJualDataGridViewTextBoxColumn1.DataPropertyName = "Harga_Jual"
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = "0"
        Me.HargaJualDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle5
        Me.HargaJualDataGridViewTextBoxColumn1.HeaderText = "Harga Jual"
        Me.HargaJualDataGridViewTextBoxColumn1.Name = "HargaJualDataGridViewTextBoxColumn1"
        Me.HargaJualDataGridViewTextBoxColumn1.ReadOnly = True
        Me.HargaJualDataGridViewTextBoxColumn1.Width = 94
        '
        'QtyJualDataGridViewTextBoxColumn
        '
        Me.QtyJualDataGridViewTextBoxColumn.DataPropertyName = "Qty_Jual"
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0"
        Me.QtyJualDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.QtyJualDataGridViewTextBoxColumn.HeaderText = "Qty Jual"
        Me.QtyJualDataGridViewTextBoxColumn.Name = "QtyJualDataGridViewTextBoxColumn"
        Me.QtyJualDataGridViewTextBoxColumn.ReadOnly = True
        Me.QtyJualDataGridViewTextBoxColumn.Width = 78
        '
        'DiskonPersenDataGridViewTextBoxColumn
        '
        Me.DiskonPersenDataGridViewTextBoxColumn.DataPropertyName = "Diskon_Persen"
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = "0"
        Me.DiskonPersenDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.DiskonPersenDataGridViewTextBoxColumn.HeaderText = "Disk. %"
        Me.DiskonPersenDataGridViewTextBoxColumn.Name = "DiskonPersenDataGridViewTextBoxColumn"
        Me.DiskonPersenDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiskonPersenDataGridViewTextBoxColumn.Width = 74
        '
        'DiskonRpDataGridViewTextBoxColumn
        '
        Me.DiskonRpDataGridViewTextBoxColumn.DataPropertyName = "Diskon_Rp"
        DataGridViewCellStyle8.Format = "N0"
        DataGridViewCellStyle8.NullValue = "0"
        Me.DiskonRpDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.DiskonRpDataGridViewTextBoxColumn.HeaderText = "Disk. Rp"
        Me.DiskonRpDataGridViewTextBoxColumn.Name = "DiskonRpDataGridViewTextBoxColumn"
        Me.DiskonRpDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiskonRpDataGridViewTextBoxColumn.Width = 79
        '
        'SubtotalDataGridViewTextBoxColumn
        '
        Me.SubtotalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal"
        DataGridViewCellStyle9.Format = "N0"
        DataGridViewCellStyle9.NullValue = "0"
        Me.SubtotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.SubtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.Name = "SubtotalDataGridViewTextBoxColumn"
        Me.SubtotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubtotalDataGridViewTextBoxColumn.Width = 85
        '
        'TBLPenjualanHeaderQueryPenjualanBindingSource1
        '
        Me.TBLPenjualanHeaderQueryPenjualanBindingSource1.DataMember = "TBL_Penjualan_Header_Query_Penjualan"
        Me.TBLPenjualanHeaderQueryPenjualanBindingSource1.DataSource = Me.TBLPenjualanHeaderBindingSource
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(375, 114)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.ReadOnly = True
        Me.txtNama.Size = New System.Drawing.Size(185, 26)
        Me.txtNama.TabIndex = 455
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(564, 121)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 17)
        Me.Label6.TabIndex = 454
        Me.Label6.Text = "Enter"
        '
        'txtNoBon
        '
        Me.txtNoBon.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLPenjualanHeaderBindingSource, "NoBon", True))
        Me.txtNoBon.Location = New System.Drawing.Point(552, 48)
        Me.txtNoBon.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNoBon.Name = "txtNoBon"
        Me.txtNoBon.Size = New System.Drawing.Size(214, 22)
        Me.txtNoBon.TabIndex = 456
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(420, 50)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(115, 20)
        Me.Label19.TabIndex = 457
        Me.Label19.Text = "No. Pesanan"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(842, 666)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(98, 20)
        Me.Label25.TabIndex = 95
        Me.Label25.Text = "Biaya Lain"
        '
        'txtBiayaLain
        '
        Me.txtBiayaLain.BackColor = System.Drawing.Color.Bisque
        Me.txtBiayaLain.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBLPenjualanHeaderBindingSource, "Biaya_Lain", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C2"))
        Me.txtBiayaLain.DataType = GetType(Decimal)
        Me.txtBiayaLain.DisplayFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtBiayaLain.DisplayFormat.NullText = "0"
        Me.txtBiayaLain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBiayaLain.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtBiayaLain.Location = New System.Drawing.Point(1036, 662)
        Me.txtBiayaLain.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBiayaLain.Name = "txtBiayaLain"
        Me.txtBiayaLain.Size = New System.Drawing.Size(260, 28)
        Me.txtBiayaLain.TabIndex = 405
        Me.txtBiayaLain.Tag = Nothing
        Me.txtBiayaLain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(842, 628)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(67, 20)
        Me.Label26.TabIndex = 95
        Me.Label26.Text = "Diskon"
        '
        'txtDiskon
        '
        Me.txtDiskon.BackColor = System.Drawing.Color.Bisque
        Me.txtDiskon.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBLPenjualanHeaderBindingSource1, "Diskon", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C2"))
        Me.txtDiskon.DataType = GetType(Decimal)
        Me.txtDiskon.DisplayFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtDiskon.DisplayFormat.NullText = "0"
        Me.txtDiskon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiskon.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtDiskon.Location = New System.Drawing.Point(1036, 624)
        Me.txtDiskon.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiskon.Name = "txtDiskon"
        Me.txtDiskon.Size = New System.Drawing.Size(260, 28)
        Me.txtDiskon.TabIndex = 405
        Me.txtDiskon.Tag = Nothing
        Me.txtDiskon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBLPenjualanHeaderBindingSource1
        '
        Me.TBLPenjualanHeaderBindingSource1.DataMember = "TBL_Penjualan_Header"
        Me.TBLPenjualanHeaderBindingSource1.DataSource = Me.Db_POS_CNDataSet
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(842, 593)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(108, 20)
        Me.Label16.TabIndex = 95
        Me.Label16.Text = "Total Harga"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(972, 703)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(49, 20)
        Me.Label27.TabIndex = 95
        Me.Label27.Text = "[Rp.]"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(972, 628)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(49, 20)
        Me.Label28.TabIndex = 95
        Me.Label28.Text = "[Rp.]"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(972, 593)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(49, 20)
        Me.Label29.TabIndex = 95
        Me.Label29.Text = "[Rp.]"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(972, 666)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(49, 20)
        Me.Label30.TabIndex = 95
        Me.Label30.Text = "[Rp.]"
        '
        'TbL_CustomerTableAdapter
        '
        Me.TbL_CustomerTableAdapter.ClearBeforeFill = True
        '
        'TBL_BarangTableAdapter
        '
        Me.TBL_BarangTableAdapter.ClearBeforeFill = True
        '
        'TbL_Harga_CustomerTableAdapter
        '
        Me.TbL_Harga_CustomerTableAdapter.ClearBeforeFill = True
        '
        'TbL_Penjualan_DetailTableAdapter
        '
        Me.TbL_Penjualan_DetailTableAdapter.ClearBeforeFill = True
        '
        'TBL_Penjualan_HeaderTableAdapter
        '
        Me.TBL_Penjualan_HeaderTableAdapter.ClearBeforeFill = True
        '
        'Query_PenjualanTableAdapter
        '
        Me.Query_PenjualanTableAdapter.ClearBeforeFill = True
        '
        'TbL_PiutangTableAdapter
        '
        Me.TbL_PiutangTableAdapter.ClearBeforeFill = True
        '
        'TbL_Alokasi_PenjualanTableAdapter
        '
        Me.TbL_Alokasi_PenjualanTableAdapter.ClearBeforeFill = True
        '
        'TbL_Retur_Penjualan_HeaderTableAdapter
        '
        Me.TbL_Retur_Penjualan_HeaderTableAdapter.ClearBeforeFill = True
        '
        'TBL_SalesTableAdapter
        '
        Me.TBL_SalesTableAdapter.ClearBeforeFill = True
        '
        'TbL_Retur_Penjualan_DetailTableAdapter
        '
        Me.TbL_Retur_Penjualan_DetailTableAdapter.ClearBeforeFill = True
        '
        'TBL_Barang_DetailTableAdapter
        '
        Me.TBL_Barang_DetailTableAdapter.ClearBeforeFill = True
        '
        'FRM_Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1328, 784)
        Me.Controls.Add(Me.cfgSales)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtBiayaLain)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtDiskon)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.txtTotalBayar)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtNoBon)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvBarangDetail)
        Me.Controls.Add(Me.dgvBarang)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTotalQty)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtTotalHarga)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtJumlahItem)
        Me.Controls.Add(Me.dtpTanggal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKodePenjualan)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bnPenjualan)
        Me.Controls.Add(Me.btnAsc)
        Me.Controls.Add(Me.dgvPenjualan)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtKodeSales)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FRM_Penjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form Penjualan"
        CType(Me.bnPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnPenjualan.ResumeLayout(False)
        Me.bnPenjualan.PerformLayout()
        CType(Me.TBLPenjualanHeaderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbPOSCNDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_POS_CNDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtTotalBayar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalHarga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHargaJualPersen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cfgSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLSalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TBLPenjualanHeaderQueryPenjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLPenjualanHeaderTBLPenjualanDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLPenjualanDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.dgvBarangDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBarangDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLPenjualanHeaderQueryPenjualanBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBiayaLain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiskon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLPenjualanHeaderBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bnPenjualan As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtKataKunci As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents cboKriteria As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSisa As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtPmb As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtJenisPmb As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCetakFaktur As System.Windows.Forms.Button
    Friend WithEvents btnKredit As System.Windows.Forms.Button
    Friend WithEvents txtTotalBayar As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTotalHarga As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtJumlahItem As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotalDetail As System.Windows.Forms.TextBox
    Friend WithEvents txtDiskonRpDetail As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDiskonPersenDetail As System.Windows.Forms.TextBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtHargaJual As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtBarcodeBarang As System.Windows.Forms.TextBox
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKodePenjualan As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTotalHarga As System.Windows.Forms.Label
    Friend WithEvents lblKembali As System.Windows.Forms.Label
    Friend WithEvents TbL_CustomerTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_CustomerTableAdapter
    Friend WithEvents Db_POS_CNDataSet As Best_POS.db_POS_CNDataSet
    Friend WithEvents TBLCustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DbPOSCNDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBLBarangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_BarangTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_BarangTableAdapter
    Friend WithEvents TbL_Harga_CustomerTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Harga_CustomerTableAdapter
    Friend WithEvents dgvBarang As System.Windows.Forms.DataGridView
    Friend WithEvents TbL_Penjualan_DetailTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Penjualan_DetailTableAdapter
    Friend WithEvents TBLPenjualanHeaderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_Penjualan_HeaderTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Penjualan_HeaderTableAdapter
    Friend WithEvents TBLPenjualanDetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tsCetak As System.Windows.Forms.ToolStripButton
    Friend WithEvents TBLPenjualanHeaderTBLPenjualanDetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotalQty As System.Windows.Forms.TextBox
    Friend WithEvents TBLPenjualanHeaderQueryPenjualanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Query_PenjualanTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.Query_PenjualanTableAdapter
    Friend WithEvents cboCash As System.Windows.Forms.CheckBox
    Friend WithEvents TbL_PiutangTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_PiutangTableAdapter
    Friend WithEvents tsWareHouse As System.Windows.Forms.ToolStripButton
    Friend WithEvents TbL_Alokasi_PenjualanTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Alokasi_PenjualanTableAdapter
    Friend WithEvents TbL_Retur_Penjualan_HeaderTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Retur_Penjualan_HeaderTableAdapter
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtKodeSales As System.Windows.Forms.TextBox
    Friend WithEvents cfgSales As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents TBLSalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_SalesTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_SalesTableAdapter
    Friend WithEvents KodeBarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents G1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents G2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SatuanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargaJualDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TbL_Retur_Penjualan_DetailTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Retur_Penjualan_DetailTableAdapter
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SortToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAsc As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtIdDetail As System.Windows.Forms.TextBox
    Friend WithEvents dgvBarangDetail As System.Windows.Forms.DataGridView
    Friend WithEvents TBLBarangDetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_Barang_DetailTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Barang_DetailTableAdapter
    Friend WithEvents IDBarangDetailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarangDetailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvPenjualan As System.Windows.Forms.DataGridView
    Friend WithEvents NoBarisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodeBarangDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarangDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDBarangDetailDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarangDetailDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargaJualDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyJualDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiskonPersenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiskonRpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubtotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TBLPenjualanHeaderQueryPenjualanBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNamaDetail As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaBarang As System.Windows.Forms.TextBox
    Friend WithEvents dgvCustomer As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtNoBon As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents nudHargaJualPersen As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtBiayaLain As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtDiskon As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TBLPenjualanHeaderBindingSource1 As System.Windows.Forms.BindingSource
End Class
