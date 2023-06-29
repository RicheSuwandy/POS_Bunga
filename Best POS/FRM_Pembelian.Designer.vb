<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Pembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Pembelian))
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle43 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle44 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle45 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.bnPembelian = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TBLPembelianHeaderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.tsHapus = New System.Windows.Forms.ToolStripButton()
        Me.tsSimpan = New System.Windows.Forms.ToolStripButton()
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
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtJumlahItem = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKodePembelian = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotalHarga = New System.Windows.Forms.Label()
        Me.lblKembali = New System.Windows.Forms.Label()
        Me.TBLPembelianHeaderQueryPembelianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvSupplier = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.TBLSupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLBarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_BarangTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_BarangTableAdapter()
        Me.dgvBarang = New System.Windows.Forms.DataGridView()
        Me.KodeBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.G2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatuanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Harga_Beli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotalQty = New System.Windows.Forms.TextBox()
        Me.TbL_Alokasi_PenjualanTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Alokasi_PenjualanTableAdapter()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNoFakturSup = New System.Windows.Forms.TextBox()
        Me.TBL_SupplierTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_SupplierTableAdapter()
        Me.TBL_Pembelian_HeaderTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Pembelian_HeaderTableAdapter()
        Me.TBLPembelianDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_Pembelian_DetailTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Pembelian_DetailTableAdapter()
        Me.Query_PembelianTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.Query_PembelianTableAdapter()
        Me.TbL_Alokasi_PembelianTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Alokasi_PembelianTableAdapter()
        Me.dgvCustomer = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.TbL_Harga_SupplierTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Harga_SupplierTableAdapter()
        Me.TbL_HutangTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_HutangTableAdapter()
        Me.TbL_Retur_Pembelian_HeaderTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Retur_Pembelian_HeaderTableAdapter()
        Me.TbL_Retur_Pembelian_DetailTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Retur_Pembelian_DetailTableAdapter()
        Me.btnAsc = New System.Windows.Forms.Button()
        Me.TBLBarangDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_Barang_DetailTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Barang_DetailTableAdapter()
        Me.dgvBarangDetail = New System.Windows.Forms.DataGridView()
        Me.IDBarangDetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarangDetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBLPembelianHeaderQueryPembelianBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLPembelianHeaderQueryPembelianBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvPembelian = New System.Windows.Forms.DataGridView()
        Me.NoBarisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeBarangDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarangDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDBarangDetailDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarangDetailDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaBeliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyBeliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiskonPersenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiskonRpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBLPembelianHeaderQueryPembelianBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtNama = New System.Windows.Forms.TextBox()
        CType(Me.bnPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnPembelian.SuspendLayout()
        CType(Me.TBLPembelianHeaderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbPOSCNDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_POS_CNDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtTotalBayar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalHarga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.TBLPembelianHeaderQueryPembelianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLPembelianDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBarangDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBarangDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLPembelianHeaderQueryPembelianBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLPembelianHeaderQueryPembelianBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLPembelianHeaderQueryPembelianBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bnPembelian
        '
        Me.bnPembelian.AddNewItem = Nothing
        Me.bnPembelian.BindingSource = Me.TBLPembelianHeaderBindingSource
        Me.bnPembelian.CountItem = Me.BindingNavigatorCountItem
        Me.bnPembelian.DeleteItem = Nothing
        Me.bnPembelian.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.tsTambah, Me.tsHapus, Me.tsSimpan, Me.tsRefresh, Me.tsWareHouse, Me.tsCetak, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.txtKataKunci, Me.cboKriteria, Me.ToolStripSeparator3})
        Me.bnPembelian.Location = New System.Drawing.Point(0, 0)
        Me.bnPembelian.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnPembelian.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnPembelian.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnPembelian.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnPembelian.Name = "bnPembelian"
        Me.bnPembelian.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.bnPembelian.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnPembelian.Size = New System.Drawing.Size(1494, 33)
        Me.bnPembelian.TabIndex = 54
        Me.bnPembelian.Text = "BindingNavigator1"
        '
        'TBLPembelianHeaderBindingSource
        '
        Me.TBLPembelianHeaderBindingSource.DataMember = "TBL_Pembelian_Header"
        Me.TBLPembelianHeaderBindingSource.DataSource = Me.DbPOSCNDataSetBindingSource
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 30)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 30)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 30)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(73, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 30)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 30)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'tsTambah
        '
        Me.tsTambah.Image = CType(resources.GetObject("tsTambah.Image"), System.Drawing.Image)
        Me.tsTambah.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsTambah.Name = "tsTambah"
        Me.tsTambah.Size = New System.Drawing.Size(66, 30)
        Me.tsTambah.Text = "&Add"
        '
        'tsHapus
        '
        Me.tsHapus.Image = CType(resources.GetObject("tsHapus.Image"), System.Drawing.Image)
        Me.tsHapus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsHapus.Name = "tsHapus"
        Me.tsHapus.Size = New System.Drawing.Size(82, 30)
        Me.tsHapus.Text = "&Delete"
        '
        'tsSimpan
        '
        Me.tsSimpan.Image = CType(resources.GetObject("tsSimpan.Image"), System.Drawing.Image)
        Me.tsSimpan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSimpan.Name = "tsSimpan"
        Me.tsSimpan.Size = New System.Drawing.Size(69, 30)
        Me.tsSimpan.Text = "&Save"
        '
        'tsRefresh
        '
        Me.tsRefresh.Image = CType(resources.GetObject("tsRefresh.Image"), System.Drawing.Image)
        Me.tsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsRefresh.Name = "tsRefresh"
        Me.tsRefresh.Size = New System.Drawing.Size(90, 30)
        Me.tsRefresh.Text = "&Refresh"
        '
        'tsWareHouse
        '
        Me.tsWareHouse.Image = CType(resources.GetObject("tsWareHouse.Image"), System.Drawing.Image)
        Me.tsWareHouse.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsWareHouse.Name = "tsWareHouse"
        Me.tsWareHouse.Size = New System.Drawing.Size(120, 30)
        Me.tsWareHouse.Text = "&Warehouse"
        Me.tsWareHouse.Visible = False
        '
        'tsCetak
        '
        Me.tsCetak.Image = CType(resources.GetObject("tsCetak.Image"), System.Drawing.Image)
        Me.tsCetak.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsCetak.Name = "tsCetak"
        Me.tsCetak.Size = New System.Drawing.Size(68, 30)
        Me.tsCetak.Text = "&Print"
        Me.tsCetak.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Image = CType(resources.GetObject("ToolStripLabel1.Image"), System.Drawing.Image)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(80, 30)
        Me.ToolStripLabel1.Text = "Search"
        '
        'txtKataKunci
        '
        Me.txtKataKunci.Name = "txtKataKunci"
        Me.txtKataKunci.Size = New System.Drawing.Size(148, 33)
        '
        'cboKriteria
        '
        Me.cboKriteria.Items.AddRange(New Object() {"No Faktur", "No Faktur Supplier"})
        Me.cboKriteria.Name = "cboKriteria"
        Me.cboKriteria.Size = New System.Drawing.Size(121, 33)
        Me.cboKriteria.Sorted = True
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 33)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtSisa)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.txtPmb)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.txtJenisPmb)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Location = New System.Drawing.Point(26, 872)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(1074, 82)
        Me.GroupBox3.TabIndex = 437
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Keterangan"
        '
        'txtSisa
        '
        Me.txtSisa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLPembelianHeaderBindingSource, "Sisa_Pembayaran", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C0"))
        Me.txtSisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSisa.Location = New System.Drawing.Point(760, 34)
        Me.txtSisa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSisa.Name = "txtSisa"
        Me.txtSisa.ReadOnly = True
        Me.txtSisa.Size = New System.Drawing.Size(246, 26)
        Me.txtSisa.TabIndex = 5
        Me.txtSisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(705, 38)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(46, 20)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "Sisa"
        '
        'txtPmb
        '
        Me.txtPmb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLPembelianHeaderBindingSource, "Pembayaran", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C0"))
        Me.txtPmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPmb.Location = New System.Drawing.Point(458, 34)
        Me.txtPmb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPmb.Name = "txtPmb"
        Me.txtPmb.ReadOnly = True
        Me.txtPmb.Size = New System.Drawing.Size(236, 26)
        Me.txtPmb.TabIndex = 3
        Me.txtPmb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(288, 38)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(156, 20)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Pembayaran / DP"
        '
        'txtJenisPmb
        '
        Me.txtJenisPmb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLPembelianHeaderBindingSource, "Jenis_Pembayaran", True))
        Me.txtJenisPmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJenisPmb.Location = New System.Drawing.Point(177, 34)
        Me.txtJenisPmb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtJenisPmb.Name = "txtJenisPmb"
        Me.txtJenisPmb.ReadOnly = True
        Me.txtJenisPmb.Size = New System.Drawing.Size(100, 26)
        Me.txtJenisPmb.TabIndex = 1
        Me.txtJenisPmb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(4, 38)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(163, 20)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Jenis Pembayaran"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboCash)
        Me.GroupBox2.Controls.Add(Me.btnCetakFaktur)
        Me.GroupBox2.Controls.Add(Me.btnKredit)
        Me.GroupBox2.Controls.Add(Me.txtTotalBayar)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 788)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(1442, 75)
        Me.GroupBox2.TabIndex = 436
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pembayaran"
        '
        'cboCash
        '
        Me.cboCash.AutoSize = True
        Me.cboCash.Enabled = False
        Me.cboCash.Location = New System.Drawing.Point(18, 35)
        Me.cboCash.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboCash.Name = "cboCash"
        Me.cboCash.Size = New System.Drawing.Size(111, 24)
        Me.cboCash.TabIndex = 421
        Me.cboCash.Text = "CASH [F3]"
        Me.cboCash.UseVisualStyleBackColor = True
        '
        'btnCetakFaktur
        '
        Me.btnCetakFaktur.Location = New System.Drawing.Point(291, 31)
        Me.btnCetakFaktur.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCetakFaktur.Name = "btnCetakFaktur"
        Me.btnCetakFaktur.Size = New System.Drawing.Size(208, 35)
        Me.btnCetakFaktur.TabIndex = 420
        Me.btnCetakFaktur.Text = "CETAK FAKTUR [F5]"
        Me.btnCetakFaktur.UseVisualStyleBackColor = True
        '
        'btnKredit
        '
        Me.btnKredit.Enabled = False
        Me.btnKredit.Location = New System.Drawing.Point(141, 31)
        Me.btnKredit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnKredit.Name = "btnKredit"
        Me.btnKredit.Size = New System.Drawing.Size(129, 35)
        Me.btnKredit.TabIndex = 418
        Me.btnKredit.Text = "KREDIT [F4]"
        Me.btnKredit.UseVisualStyleBackColor = True
        '
        'txtTotalBayar
        '
        Me.txtTotalBayar.BackColor = System.Drawing.Color.Bisque
        Me.txtTotalBayar.DataType = GetType(Decimal)
        Me.txtTotalBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalBayar.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtTotalBayar.Location = New System.Drawing.Point(1143, 25)
        Me.txtTotalBayar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotalBayar.Name = "txtTotalBayar"
        Me.txtTotalBayar.Size = New System.Drawing.Size(288, 33)
        Me.txtTotalBayar.TabIndex = 405
        Me.txtTotalBayar.Tag = Nothing
        Me.txtTotalBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1014, 34)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 25)
        Me.Label13.TabIndex = 95
        Me.Label13.Text = "Bayar [F6]"
        '
        'txtTotalHarga
        '
        Me.txtTotalHarga.BackColor = System.Drawing.Color.Bisque
        Me.txtTotalHarga.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBLPembelianHeaderBindingSource, "Total_Harga", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C0"))
        Me.txtTotalHarga.DataType = GetType(Decimal)
        Me.txtTotalHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalHarga.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtTotalHarga.Location = New System.Drawing.Point(1166, 738)
        Me.txtTotalHarga.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotalHarga.Name = "txtTotalHarga"
        Me.txtTotalHarga.ReadOnly = True
        Me.txtTotalHarga.Size = New System.Drawing.Size(291, 33)
        Me.txtTotalHarga.TabIndex = 433
        Me.txtTotalHarga.Tag = Nothing
        Me.txtTotalHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(1161, 714)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(108, 20)
        Me.Label16.TabIndex = 432
        Me.Label16.Text = "Total Harga"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(21, 714)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 20)
        Me.Label18.TabIndex = 423
        Me.Label18.Text = "Banyak Item"
        '
        'txtJumlahItem
        '
        Me.txtJumlahItem.BackColor = System.Drawing.Color.Bisque
        Me.txtJumlahItem.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLPembelianHeaderBindingSource, "Jumlah_Item", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"))
        Me.txtJumlahItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlahItem.Location = New System.Drawing.Point(22, 738)
        Me.txtJumlahItem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtJumlahItem.Name = "txtJumlahItem"
        Me.txtJumlahItem.ReadOnly = True
        Me.txtJumlahItem.Size = New System.Drawing.Size(91, 35)
        Me.txtJumlahItem.TabIndex = 421
        Me.txtJumlahItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Location = New System.Drawing.Point(22, 229)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1444, 154)
        Me.GroupBox1.TabIndex = 420
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item"
        '
        'txtNamaDetail
        '
        Me.txtNamaDetail.Enabled = False
        Me.txtNamaDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaDetail.Location = New System.Drawing.Point(224, 95)
        Me.txtNamaDetail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNamaDetail.Name = "txtNamaDetail"
        Me.txtNamaDetail.ReadOnly = True
        Me.txtNamaDetail.Size = New System.Drawing.Size(138, 30)
        Me.txtNamaDetail.TabIndex = 306
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Enabled = False
        Me.txtNamaBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaBarang.Location = New System.Drawing.Point(21, 97)
        Me.txtNamaBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.ReadOnly = True
        Me.txtNamaBarang.Size = New System.Drawing.Size(192, 30)
        Me.txtNamaBarang.TabIndex = 305
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(219, 28)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(86, 20)
        Me.Label17.TabIndex = 304
        Me.Label17.Text = "ID Detail *"
        '
        'txtIdDetail
        '
        Me.txtIdDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdDetail.Location = New System.Drawing.Point(224, 52)
        Me.txtIdDetail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtIdDetail.Name = "txtIdDetail"
        Me.txtIdDetail.Size = New System.Drawing.Size(138, 30)
        Me.txtIdDetail.TabIndex = 83
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(536, 28)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(30, 20)
        Me.Label23.TabIndex = 302
        Me.Label23.Text = "F2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(880, 28)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 20)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "Total"
        '
        'txtTotalDetail
        '
        Me.txtTotalDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDetail.Location = New System.Drawing.Point(885, 52)
        Me.txtTotalDetail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotalDetail.Name = "txtTotalDetail"
        Me.txtTotalDetail.Size = New System.Drawing.Size(238, 30)
        Me.txtTotalDetail.TabIndex = 88
        '
        'txtDiskonRpDetail
        '
        Me.txtDiskonRpDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiskonRpDetail.Location = New System.Drawing.Point(728, 52)
        Me.txtDiskonRpDetail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDiskonRpDetail.Name = "txtDiskonRpDetail"
        Me.txtDiskonRpDetail.ReadOnly = True
        Me.txtDiskonRpDetail.Size = New System.Drawing.Size(146, 30)
        Me.txtDiskonRpDetail.TabIndex = 87
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(723, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Diskon Rp"
        '
        'txtDiskonPersenDetail
        '
        Me.txtDiskonPersenDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiskonPersenDetail.Location = New System.Drawing.Point(646, 54)
        Me.txtDiskonPersenDetail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDiskonPersenDetail.Name = "txtDiskonPersenDetail"
        Me.txtDiskonPersenDetail.ReadOnly = True
        Me.txtDiskonPersenDetail.Size = New System.Drawing.Size(70, 30)
        Me.txtDiskonPersenDetail.TabIndex = 86
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(1256, 54)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(112, 35)
        Me.btnReset.TabIndex = 90
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(642, 26)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 20)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Diskon %"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(129, 28)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 20)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "F1"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(1134, 54)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(112, 35)
        Me.btnAdd.TabIndex = 89
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(440, 28)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 20)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "Harga Beli *"
        '
        'txtHargaJual
        '
        Me.txtHargaJual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHargaJual.Location = New System.Drawing.Point(444, 52)
        Me.txtHargaJual.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtHargaJual.Name = "txtHargaJual"
        Me.txtHargaJual.Size = New System.Drawing.Size(192, 30)
        Me.txtHargaJual.TabIndex = 85
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(372, 28)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 20)
        Me.Label11.TabIndex = 88
        Me.Label11.Text = "Qty *"
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(372, 52)
        Me.txtQty.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.ReadOnly = True
        Me.txtQty.Size = New System.Drawing.Size(61, 30)
        Me.txtQty.TabIndex = 84
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 28)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 20)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "Kode Barang *"
        '
        'txtBarcodeBarang
        '
        Me.txtBarcodeBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcodeBarang.Location = New System.Drawing.Point(21, 52)
        Me.txtBarcodeBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBarcodeBarang.Name = "txtBarcodeBarang"
        Me.txtBarcodeBarang.ReadOnly = True
        Me.txtBarcodeBarang.Size = New System.Drawing.Size(192, 30)
        Me.txtBarcodeBarang.TabIndex = 82
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(676, 194)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 428
        Me.Label6.Text = "Enter"
        '
        'dtpTanggal
        '
        Me.dtpTanggal.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBLPembelianHeaderBindingSource, "Tanggal_Beli", True))
        Me.dtpTanggal.Location = New System.Drawing.Point(234, 146)
        Me.dtpTanggal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(298, 26)
        Me.dtpTanggal.TabIndex = 414
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 191)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 25)
        Me.Label4.TabIndex = 417
        Me.Label4.Text = "Kode Supplier *"
        '
        'txtCustomer
        '
        Me.txtCustomer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLPembelianHeaderBindingSource, "Kode_Supplier", True))
        Me.txtCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomer.Location = New System.Drawing.Point(234, 186)
        Me.txtCustomer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.ReadOnly = True
        Me.txtCustomer.Size = New System.Drawing.Size(218, 30)
        Me.txtCustomer.TabIndex = 414
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 151)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 25)
        Me.Label3.TabIndex = 416
        Me.Label3.Text = "Tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 25)
        Me.Label2.TabIndex = 415
        Me.Label2.Text = "No Faktur *"
        '
        'txtKodePembelian
        '
        Me.txtKodePembelian.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLPembelianHeaderBindingSource, "Kode_Pembelian", True))
        Me.txtKodePembelian.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodePembelian.Location = New System.Drawing.Point(234, 60)
        Me.txtKodePembelian.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtKodePembelian.Name = "txtKodePembelian"
        Me.txtKodePembelian.ReadOnly = True
        Me.txtKodePembelian.Size = New System.Drawing.Size(224, 30)
        Me.txtKodePembelian.TabIndex = 412
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.lblTotalHarga)
        Me.Panel1.Controls.Add(Me.lblKembali)
        Me.Panel1.Location = New System.Drawing.Point(742, 60)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(724, 117)
        Me.Panel1.TabIndex = 429
        '
        'lblTotalHarga
        '
        Me.lblTotalHarga.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotalHarga.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLPembelianHeaderBindingSource, "Total_Harga", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C0"))
        Me.lblTotalHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalHarga.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblTotalHarga.Location = New System.Drawing.Point(159, 32)
        Me.lblTotalHarga.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalHarga.Name = "lblTotalHarga"
        Me.lblTotalHarga.Size = New System.Drawing.Size(555, 57)
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
        Me.lblKembali.Location = New System.Drawing.Point(4, 6)
        Me.lblKembali.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKembali.Name = "lblKembali"
        Me.lblKembali.Size = New System.Drawing.Size(97, 29)
        Me.lblKembali.TabIndex = 401
        Me.lblKembali.Text = "TOTAL"
        '
        'TBLPembelianHeaderQueryPembelianBindingSource
        '
        Me.TBLPembelianHeaderQueryPembelianBindingSource.DataMember = "TBL_Pembelian_Header_Query_Pembelian"
        Me.TBLPembelianHeaderQueryPembelianBindingSource.DataSource = Me.TBLPembelianHeaderBindingSource
        '
        'dgvSupplier
        '
        Me.dgvSupplier.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.dgvSupplier.AllowEditing = False
        Me.dgvSupplier.AllowFiltering = True
        Me.dgvSupplier.ColumnInfo = resources.GetString("dgvSupplier.ColumnInfo")
        Me.dgvSupplier.DataSource = Me.TBLSupplierBindingSource
        Me.dgvSupplier.Location = New System.Drawing.Point(234, 229)
        Me.dgvSupplier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvSupplier.Name = "dgvSupplier"
        Me.dgvSupplier.Rows.Count = 1
        Me.dgvSupplier.Rows.DefaultSize = 19
        Me.dgvSupplier.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.dgvSupplier.Size = New System.Drawing.Size(1090, 379)
        Me.dgvSupplier.TabIndex = 439
        Me.dgvSupplier.Visible = False
        Me.dgvSupplier.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'TBLSupplierBindingSource
        '
        Me.TBLSupplierBindingSource.DataMember = "TBL_Supplier"
        Me.TBLSupplierBindingSource.DataSource = Me.DbPOSCNDataSetBindingSource
        '
        'TBLBarangBindingSource
        '
        Me.TBLBarangBindingSource.DataMember = "TBL_Barang"
        Me.TBLBarangBindingSource.DataSource = Me.DbPOSCNDataSetBindingSource
        '
        'TBL_BarangTableAdapter
        '
        Me.TBL_BarangTableAdapter.ClearBeforeFill = True
        '
        'dgvBarang
        '
        Me.dgvBarang.AllowUserToAddRows = False
        Me.dgvBarang.AllowUserToDeleteRows = False
        Me.dgvBarang.AutoGenerateColumns = False
        Me.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeBarangDataGridViewTextBoxColumn, Me.NamaBarangDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn, Me.G1, Me.G2, Me.SatuanDataGridViewTextBoxColumn, Me.Harga_Beli})
        Me.dgvBarang.DataSource = Me.TBLBarangBindingSource
        Me.dgvBarang.Location = New System.Drawing.Point(44, 369)
        Me.dgvBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvBarang.MultiSelect = False
        Me.dgvBarang.Name = "dgvBarang"
        Me.dgvBarang.ReadOnly = True
        Me.dgvBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBarang.Size = New System.Drawing.Size(1134, 242)
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
        DataGridViewCellStyle37.Format = "N2"
        DataGridViewCellStyle37.NullValue = "0"
        Me.G1.DefaultCellStyle = DataGridViewCellStyle37
        Me.G1.HeaderText = "Gudang 1"
        Me.G1.Name = "G1"
        Me.G1.ReadOnly = True
        '
        'G2
        '
        Me.G2.DataPropertyName = "G2"
        DataGridViewCellStyle38.Format = "N2"
        DataGridViewCellStyle38.NullValue = "0"
        Me.G2.DefaultCellStyle = DataGridViewCellStyle38
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
        'Harga_Beli
        '
        Me.Harga_Beli.DataPropertyName = "Harga_Beli"
        DataGridViewCellStyle39.Format = "C0"
        DataGridViewCellStyle39.NullValue = "0"
        Me.Harga_Beli.DefaultCellStyle = DataGridViewCellStyle39
        Me.Harga_Beli.HeaderText = "Harga Beli"
        Me.Harga_Beli.Name = "Harga_Beli"
        Me.Harga_Beli.ReadOnly = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(154, 714)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 20)
        Me.Label7.TabIndex = 443
        Me.Label7.Text = "Total Qty"
        '
        'txtTotalQty
        '
        Me.txtTotalQty.BackColor = System.Drawing.Color.Bisque
        Me.txtTotalQty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLPembelianHeaderBindingSource, "Total_Qty", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"))
        Me.txtTotalQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalQty.Location = New System.Drawing.Point(156, 738)
        Me.txtTotalQty.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotalQty.Name = "txtTotalQty"
        Me.txtTotalQty.ReadOnly = True
        Me.txtTotalQty.Size = New System.Drawing.Size(204, 35)
        Me.txtTotalQty.TabIndex = 442
        Me.txtTotalQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TbL_Alokasi_PenjualanTableAdapter
        '
        Me.TbL_Alokasi_PenjualanTableAdapter.ClearBeforeFill = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(18, 108)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(192, 25)
        Me.Label14.TabIndex = 445
        Me.Label14.Text = "No Faktur Supplier"
        '
        'txtNoFakturSup
        '
        Me.txtNoFakturSup.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLPembelianHeaderBindingSource, "No_Faktur", True))
        Me.txtNoFakturSup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoFakturSup.Location = New System.Drawing.Point(234, 103)
        Me.txtNoFakturSup.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNoFakturSup.Name = "txtNoFakturSup"
        Me.txtNoFakturSup.Size = New System.Drawing.Size(224, 30)
        Me.txtNoFakturSup.TabIndex = 413
        '
        'TBL_SupplierTableAdapter
        '
        Me.TBL_SupplierTableAdapter.ClearBeforeFill = True
        '
        'TBL_Pembelian_HeaderTableAdapter
        '
        Me.TBL_Pembelian_HeaderTableAdapter.ClearBeforeFill = True
        '
        'TBLPembelianDetailBindingSource
        '
        Me.TBLPembelianDetailBindingSource.DataMember = "TBL_Pembelian_Detail"
        Me.TBLPembelianDetailBindingSource.DataSource = Me.DbPOSCNDataSetBindingSource
        '
        'TBL_Pembelian_DetailTableAdapter
        '
        Me.TBL_Pembelian_DetailTableAdapter.ClearBeforeFill = True
        '
        'Query_PembelianTableAdapter
        '
        Me.Query_PembelianTableAdapter.ClearBeforeFill = True
        '
        'TbL_Alokasi_PembelianTableAdapter
        '
        Me.TbL_Alokasi_PembelianTableAdapter.ClearBeforeFill = True
        '
        'dgvCustomer
        '
        Me.dgvCustomer.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.dgvCustomer.AllowEditing = False
        Me.dgvCustomer.AllowFiltering = True
        Me.dgvCustomer.ColumnInfo = resources.GetString("dgvCustomer.ColumnInfo")
        Me.dgvCustomer.DataSource = Me.TBLSupplierBindingSource
        Me.dgvCustomer.Location = New System.Drawing.Point(156, 143)
        Me.dgvCustomer.Name = "dgvCustomer"
        Me.dgvCustomer.Rows.Count = 1
        Me.dgvCustomer.Rows.DefaultSize = 19
        Me.dgvCustomer.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.dgvCustomer.Size = New System.Drawing.Size(728, 230)
        Me.dgvCustomer.TabIndex = 439
        Me.dgvCustomer.Visible = False
        Me.dgvCustomer.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'TbL_Harga_SupplierTableAdapter
        '
        Me.TbL_Harga_SupplierTableAdapter.ClearBeforeFill = True
        '
        'TbL_HutangTableAdapter
        '
        Me.TbL_HutangTableAdapter.ClearBeforeFill = True
        '
        'TbL_Retur_Pembelian_HeaderTableAdapter
        '
        Me.TbL_Retur_Pembelian_HeaderTableAdapter.ClearBeforeFill = True
        '
        'TbL_Retur_Pembelian_DetailTableAdapter
        '
        Me.TbL_Retur_Pembelian_DetailTableAdapter.ClearBeforeFill = True
        '
        'btnAsc
        '
        Me.btnAsc.BackColor = System.Drawing.SystemColors.Control
        Me.btnAsc.Cursor = System.Windows.Forms.Cursors.UpArrow
        Me.btnAsc.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsc.Location = New System.Drawing.Point(108, 358)
        Me.btnAsc.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAsc.Name = "btnAsc"
        Me.btnAsc.Size = New System.Drawing.Size(30, 28)
        Me.btnAsc.TabIndex = 450
        Me.btnAsc.Text = "..."
        Me.btnAsc.UseVisualStyleBackColor = False
        Me.btnAsc.Visible = False
        '
        'TBLBarangDetailBindingSource
        '
        Me.TBLBarangDetailBindingSource.DataMember = "TBL_Barang_Detail"
        Me.TBLBarangDetailBindingSource.DataSource = Me.Db_POS_CNDataSet
        '
        'TBL_Barang_DetailTableAdapter
        '
        Me.TBL_Barang_DetailTableAdapter.ClearBeforeFill = True
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
        Me.dgvBarangDetail.Location = New System.Drawing.Point(246, 369)
        Me.dgvBarangDetail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvBarangDetail.Name = "dgvBarangDetail"
        Me.dgvBarangDetail.ReadOnly = True
        Me.dgvBarangDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBarangDetail.Size = New System.Drawing.Size(537, 242)
        Me.dgvBarangDetail.TabIndex = 451
        Me.dgvBarangDetail.Visible = False
        '
        'IDBarangDetailDataGridViewTextBoxColumn
        '
        Me.IDBarangDetailDataGridViewTextBoxColumn.DataPropertyName = "ID_Barang_Detail"
        Me.IDBarangDetailDataGridViewTextBoxColumn.HeaderText = "ID Detail"
        Me.IDBarangDetailDataGridViewTextBoxColumn.Name = "IDBarangDetailDataGridViewTextBoxColumn"
        Me.IDBarangDetailDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDBarangDetailDataGridViewTextBoxColumn.Width = 88
        '
        'NamaBarangDetailDataGridViewTextBoxColumn
        '
        Me.NamaBarangDetailDataGridViewTextBoxColumn.DataPropertyName = "Nama_Barang_Detail"
        Me.NamaBarangDetailDataGridViewTextBoxColumn.HeaderText = "Nama Barang Detail"
        Me.NamaBarangDetailDataGridViewTextBoxColumn.Name = "NamaBarangDetailDataGridViewTextBoxColumn"
        Me.NamaBarangDetailDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamaBarangDetailDataGridViewTextBoxColumn.Width = 161
        '
        'QtyDataGridViewTextBoxColumn1
        '
        Me.QtyDataGridViewTextBoxColumn1.DataPropertyName = "Qty"
        DataGridViewCellStyle40.Format = "N2"
        DataGridViewCellStyle40.NullValue = "0"
        Me.QtyDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle40
        Me.QtyDataGridViewTextBoxColumn1.HeaderText = "Qty"
        Me.QtyDataGridViewTextBoxColumn1.Name = "QtyDataGridViewTextBoxColumn1"
        Me.QtyDataGridViewTextBoxColumn1.ReadOnly = True
        Me.QtyDataGridViewTextBoxColumn1.Width = 58
        '
        'TBLPembelianHeaderQueryPembelianBindingSource1
        '
        Me.TBLPembelianHeaderQueryPembelianBindingSource1.DataMember = "TBL_Pembelian_Header_Query_Pembelian"
        Me.TBLPembelianHeaderQueryPembelianBindingSource1.DataSource = Me.TBLPembelianHeaderBindingSource
        '
        'TBLPembelianHeaderQueryPembelianBindingSource2
        '
        Me.TBLPembelianHeaderQueryPembelianBindingSource2.DataMember = "TBL_Pembelian_Header_Query_Pembelian"
        Me.TBLPembelianHeaderQueryPembelianBindingSource2.DataSource = Me.TBLPembelianHeaderBindingSource
        '
        'dgvPembelian
        '
        Me.dgvPembelian.AllowUserToAddRows = False
        Me.dgvPembelian.AllowUserToDeleteRows = False
        Me.dgvPembelian.AutoGenerateColumns = False
        Me.dgvPembelian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPembelian.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoBarisDataGridViewTextBoxColumn, Me.KodeBarangDataGridViewTextBoxColumn1, Me.NamaBarangDataGridViewTextBoxColumn1, Me.IDBarangDetailDataGridViewTextBoxColumn1, Me.NamaBarangDetailDataGridViewTextBoxColumn1, Me.HargaBeliDataGridViewTextBoxColumn, Me.QtyBeliDataGridViewTextBoxColumn, Me.DiskonPersenDataGridViewTextBoxColumn, Me.DiskonRpDataGridViewTextBoxColumn, Me.SubtotalDataGridViewTextBoxColumn})
        Me.dgvPembelian.DataSource = Me.TBLPembelianHeaderQueryPembelianBindingSource3
        Me.dgvPembelian.Location = New System.Drawing.Point(22, 391)
        Me.dgvPembelian.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvPembelian.Name = "dgvPembelian"
        Me.dgvPembelian.ReadOnly = True
        Me.dgvPembelian.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPembelian.Size = New System.Drawing.Size(1444, 317)
        Me.dgvPembelian.TabIndex = 452
        '
        'NoBarisDataGridViewTextBoxColumn
        '
        Me.NoBarisDataGridViewTextBoxColumn.DataPropertyName = "No_Baris"
        Me.NoBarisDataGridViewTextBoxColumn.HeaderText = "No"
        Me.NoBarisDataGridViewTextBoxColumn.Name = "NoBarisDataGridViewTextBoxColumn"
        Me.NoBarisDataGridViewTextBoxColumn.ReadOnly = True
        Me.NoBarisDataGridViewTextBoxColumn.Width = 54
        '
        'KodeBarangDataGridViewTextBoxColumn1
        '
        Me.KodeBarangDataGridViewTextBoxColumn1.DataPropertyName = "Kode_Barang"
        Me.KodeBarangDataGridViewTextBoxColumn1.HeaderText = "Kode Barang"
        Me.KodeBarangDataGridViewTextBoxColumn1.Name = "KodeBarangDataGridViewTextBoxColumn1"
        Me.KodeBarangDataGridViewTextBoxColumn1.ReadOnly = True
        Me.KodeBarangDataGridViewTextBoxColumn1.Width = 116
        '
        'NamaBarangDataGridViewTextBoxColumn1
        '
        Me.NamaBarangDataGridViewTextBoxColumn1.DataPropertyName = "Nama_Barang"
        Me.NamaBarangDataGridViewTextBoxColumn1.HeaderText = "Nama Barang"
        Me.NamaBarangDataGridViewTextBoxColumn1.Name = "NamaBarangDataGridViewTextBoxColumn1"
        Me.NamaBarangDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NamaBarangDataGridViewTextBoxColumn1.Width = 121
        '
        'IDBarangDetailDataGridViewTextBoxColumn1
        '
        Me.IDBarangDetailDataGridViewTextBoxColumn1.DataPropertyName = "ID_Barang_Detail"
        Me.IDBarangDetailDataGridViewTextBoxColumn1.HeaderText = "ID Detail"
        Me.IDBarangDetailDataGridViewTextBoxColumn1.Name = "IDBarangDetailDataGridViewTextBoxColumn1"
        Me.IDBarangDetailDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDBarangDetailDataGridViewTextBoxColumn1.Width = 88
        '
        'NamaBarangDetailDataGridViewTextBoxColumn1
        '
        Me.NamaBarangDetailDataGridViewTextBoxColumn1.DataPropertyName = "Nama_Barang_Detail"
        Me.NamaBarangDetailDataGridViewTextBoxColumn1.HeaderText = "Nama Barang Detail"
        Me.NamaBarangDetailDataGridViewTextBoxColumn1.Name = "NamaBarangDetailDataGridViewTextBoxColumn1"
        Me.NamaBarangDetailDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NamaBarangDetailDataGridViewTextBoxColumn1.Width = 161
        '
        'HargaBeliDataGridViewTextBoxColumn
        '
        Me.HargaBeliDataGridViewTextBoxColumn.DataPropertyName = "Harga_Beli"
        DataGridViewCellStyle41.Format = "N0"
        DataGridViewCellStyle41.NullValue = "0"
        Me.HargaBeliDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle41
        Me.HargaBeliDataGridViewTextBoxColumn.HeaderText = "Harga Beli"
        Me.HargaBeliDataGridViewTextBoxColumn.Name = "HargaBeliDataGridViewTextBoxColumn"
        Me.HargaBeliDataGridViewTextBoxColumn.ReadOnly = True
        Me.HargaBeliDataGridViewTextBoxColumn.Width = 99
        '
        'QtyBeliDataGridViewTextBoxColumn
        '
        Me.QtyBeliDataGridViewTextBoxColumn.DataPropertyName = "Qty_Beli"
        DataGridViewCellStyle42.Format = "N2"
        DataGridViewCellStyle42.NullValue = "0"
        Me.QtyBeliDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle42
        Me.QtyBeliDataGridViewTextBoxColumn.HeaderText = "Qty Beli"
        Me.QtyBeliDataGridViewTextBoxColumn.Name = "QtyBeliDataGridViewTextBoxColumn"
        Me.QtyBeliDataGridViewTextBoxColumn.ReadOnly = True
        Me.QtyBeliDataGridViewTextBoxColumn.Width = 81
        '
        'DiskonPersenDataGridViewTextBoxColumn
        '
        Me.DiskonPersenDataGridViewTextBoxColumn.DataPropertyName = "Diskon_Persen"
        DataGridViewCellStyle43.Format = "N2"
        DataGridViewCellStyle43.NullValue = "0"
        Me.DiskonPersenDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle43
        Me.DiskonPersenDataGridViewTextBoxColumn.HeaderText = "Disk. %"
        Me.DiskonPersenDataGridViewTextBoxColumn.Name = "DiskonPersenDataGridViewTextBoxColumn"
        Me.DiskonPersenDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiskonPersenDataGridViewTextBoxColumn.Width = 80
        '
        'DiskonRpDataGridViewTextBoxColumn
        '
        Me.DiskonRpDataGridViewTextBoxColumn.DataPropertyName = "Diskon_Rp"
        DataGridViewCellStyle44.Format = "N0"
        DataGridViewCellStyle44.NullValue = "0"
        Me.DiskonRpDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle44
        Me.DiskonRpDataGridViewTextBoxColumn.HeaderText = "Disk. Rp"
        Me.DiskonRpDataGridViewTextBoxColumn.Name = "DiskonRpDataGridViewTextBoxColumn"
        Me.DiskonRpDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiskonRpDataGridViewTextBoxColumn.Width = 87
        '
        'SubtotalDataGridViewTextBoxColumn
        '
        Me.SubtotalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal"
        DataGridViewCellStyle45.Format = "N0"
        DataGridViewCellStyle45.NullValue = "0"
        Me.SubtotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle45
        Me.SubtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.Name = "SubtotalDataGridViewTextBoxColumn"
        Me.SubtotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubtotalDataGridViewTextBoxColumn.Width = 94
        '
        'TBLPembelianHeaderQueryPembelianBindingSource3
        '
        Me.TBLPembelianHeaderQueryPembelianBindingSource3.DataMember = "TBL_Pembelian_Header_Query_Pembelian"
        Me.TBLPembelianHeaderQueryPembelianBindingSource3.DataSource = Me.TBLPembelianHeaderBindingSource
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(464, 186)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.ReadOnly = True
        Me.txtNama.Size = New System.Drawing.Size(208, 30)
        Me.txtNama.TabIndex = 453
        '
        'FRM_Pembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1494, 980)
        Me.Controls.Add(Me.dgvBarangDetail)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.dgvSupplier)
        Me.Controls.Add(Me.dgvBarang)
        Me.Controls.Add(Me.btnAsc)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtNoFakturSup)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTotalQty)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtTotalHarga)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtJumlahItem)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpTanggal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKodePembelian)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bnPembelian)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvPembelian)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "FRM_Pembelian"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Pembelian"
        CType(Me.bnPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnPembelian.ResumeLayout(False)
        Me.bnPembelian.PerformLayout()
        CType(Me.TBLPembelianHeaderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TBLPembelianHeaderQueryPembelianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLPembelianDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBarangDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBarangDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLPembelianHeaderQueryPembelianBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLPembelianHeaderQueryPembelianBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLPembelianHeaderQueryPembelianBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bnPembelian As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Label16 As System.Windows.Forms.Label
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKodePembelian As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTotalHarga As System.Windows.Forms.Label
    Friend WithEvents lblKembali As System.Windows.Forms.Label
    Friend WithEvents dgvSupplier As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Db_POS_CNDataSet As Best_POS.db_POS_CNDataSet
    Friend WithEvents DbPOSCNDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBLBarangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_BarangTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_BarangTableAdapter
    Friend WithEvents dgvBarang As System.Windows.Forms.DataGridView
    Friend WithEvents tsCetak As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotalQty As System.Windows.Forms.TextBox
    Friend WithEvents cboCash As System.Windows.Forms.CheckBox
    Friend WithEvents tsWareHouse As System.Windows.Forms.ToolStripButton
    Friend WithEvents TbL_Alokasi_PenjualanTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Alokasi_PenjualanTableAdapter
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNoFakturSup As System.Windows.Forms.TextBox
    Friend WithEvents TBLSupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_SupplierTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_SupplierTableAdapter
    Friend WithEvents TBLPembelianHeaderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_Pembelian_HeaderTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Pembelian_HeaderTableAdapter
    Friend WithEvents TBLPembelianDetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_Pembelian_DetailTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Pembelian_DetailTableAdapter
    Friend WithEvents TBLPembelianHeaderQueryPembelianBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Query_PembelianTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.Query_PembelianTableAdapter
    Friend WithEvents TbL_Alokasi_PembelianTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Alokasi_PembelianTableAdapter
    Friend WithEvents dgvCustomer As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents TbL_Harga_SupplierTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Harga_SupplierTableAdapter
    Friend WithEvents TbL_HutangTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_HutangTableAdapter
    Friend WithEvents TbL_Retur_Pembelian_HeaderTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Retur_Pembelian_HeaderTableAdapter
    Friend WithEvents KodeBarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents G1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents G2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SatuanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Harga_Beli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TbL_Retur_Pembelian_DetailTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Retur_Pembelian_DetailTableAdapter
    Friend WithEvents btnAsc As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtIdDetail As System.Windows.Forms.TextBox
    Friend WithEvents TBLBarangDetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_Barang_DetailTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Barang_DetailTableAdapter
    Friend WithEvents dgvBarangDetail As System.Windows.Forms.DataGridView
    Friend WithEvents IDBarangDetailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarangDetailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TBLPembelianHeaderQueryPembelianBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TBLPembelianHeaderQueryPembelianBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents dgvPembelian As System.Windows.Forms.DataGridView
    Friend WithEvents TBLPembelianHeaderQueryPembelianBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents NoBarisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodeBarangDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarangDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDBarangDetailDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarangDetailDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargaBeliDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyBeliDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiskonPersenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiskonRpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubtotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaDetail As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaBarang As System.Windows.Forms.TextBox
End Class
