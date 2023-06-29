<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Hutang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Hutang))
        Me.bnHutang = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TBLHutangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.tsSimpan = New System.Windows.Forms.ToolStripButton()
        Me.tsRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtKataKunci = New System.Windows.Forms.ToolStripTextBox()
        Me.cboKriteria = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsBL = New System.Windows.Forms.ToolStripButton()
        Me.tsL = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoFaktur = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalPiutang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalRetur = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTgl10 = New System.Windows.Forms.TextBox()
        Me.txtTgl9 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtBayar10 = New C1.Win.C1Input.C1TextBox()
        Me.txtBayar9 = New C1.Win.C1Input.C1TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtTgl8 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtBayar8 = New C1.Win.C1Input.C1TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtTgl7 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtBayar7 = New C1.Win.C1Input.C1TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtTgl6 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtBayar6 = New C1.Win.C1Input.C1TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTgl5 = New System.Windows.Forms.TextBox()
        Me.txtTgl4 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBayar5 = New C1.Win.C1Input.C1TextBox()
        Me.txtBayar4 = New C1.Win.C1Input.C1TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTgl3 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBayar3 = New C1.Win.C1Input.C1TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTgl2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBayar2 = New C1.Win.C1Input.C1TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTgl1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBayar1 = New C1.Win.C1Input.C1TextBox()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtTotalBayar = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtSisaPiutang = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.dgvPenjualan = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.TBL_HutangTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_HutangTableAdapter()
        CType(Me.bnHutang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnHutang.SuspendLayout()
        CType(Me.TBLHutangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_POS_CNDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtBayar10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBayar9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBayar8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBayar7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBayar6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBayar5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBayar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBayar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBayar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBayar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bnHutang
        '
        Me.bnHutang.AddNewItem = Nothing
        Me.bnHutang.BindingSource = Me.TBLHutangBindingSource
        Me.bnHutang.CountItem = Me.BindingNavigatorCountItem
        Me.bnHutang.DeleteItem = Nothing
        Me.bnHutang.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.tsSimpan, Me.tsRefresh, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.txtKataKunci, Me.cboKriteria, Me.ToolStripSeparator3, Me.tsBL, Me.tsL})
        Me.bnHutang.Location = New System.Drawing.Point(0, 0)
        Me.bnHutang.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnHutang.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnHutang.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnHutang.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnHutang.Name = "bnHutang"
        Me.bnHutang.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnHutang.Size = New System.Drawing.Size(996, 25)
        Me.bnHutang.TabIndex = 56
        Me.bnHutang.Text = "BindingNavigator1"
        '
        'TBLHutangBindingSource
        '
        Me.TBLHutangBindingSource.DataMember = "TBL_Hutang"
        Me.TBLHutangBindingSource.DataSource = Me.Db_POS_CNDataSet
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
        'tsSimpan
        '
        Me.tsSimpan.Image = CType(resources.GetObject("tsSimpan.Image"), System.Drawing.Image)
        Me.tsSimpan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSimpan.Name = "tsSimpan"
        Me.tsSimpan.Size = New System.Drawing.Size(51, 22)
        Me.tsSimpan.Text = "&Save"
        '
        'tsRefresh
        '
        Me.tsRefresh.Image = CType(resources.GetObject("tsRefresh.Image"), System.Drawing.Image)
        Me.tsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsRefresh.Name = "tsRefresh"
        Me.tsRefresh.Size = New System.Drawing.Size(66, 22)
        Me.tsRefresh.Text = "&Refresh"
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
        Me.cboKriteria.Items.AddRange(New Object() {"No Faktur"})
        Me.cboKriteria.Name = "cboKriteria"
        Me.cboKriteria.Size = New System.Drawing.Size(121, 25)
        Me.cboKriteria.Sorted = True
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tsBL
        '
        Me.tsBL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsBL.Image = CType(resources.GetObject("tsBL.Image"), System.Drawing.Image)
        Me.tsBL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBL.Name = "tsBL"
        Me.tsBL.Size = New System.Drawing.Size(24, 22)
        Me.tsBL.Text = "&BL"
        '
        'tsL
        '
        Me.tsL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsL.Image = CType(resources.GetObject("tsL.Image"), System.Drawing.Image)
        Me.tsL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsL.Name = "tsL"
        Me.tsL.Size = New System.Drawing.Size(23, 22)
        Me.tsL.Text = "&L"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No Faktur *"
        '
        'txtNoFaktur
        '
        Me.txtNoFaktur.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLHutangBindingSource, "Kode_Pembelian", True))
        Me.txtNoFaktur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoFaktur.Location = New System.Drawing.Point(156, 39)
        Me.txtNoFaktur.Name = "txtNoFaktur"
        Me.txtNoFaktur.ReadOnly = True
        Me.txtNoFaktur.Size = New System.Drawing.Size(151, 22)
        Me.txtNoFaktur.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 16)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Total Hutang *"
        '
        'txtTotalPiutang
        '
        Me.txtTotalPiutang.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLHutangBindingSource, "Total_Hutang", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C0"))
        Me.txtTotalPiutang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPiutang.Location = New System.Drawing.Point(156, 67)
        Me.txtTotalPiutang.Name = "txtTotalPiutang"
        Me.txtTotalPiutang.ReadOnly = True
        Me.txtTotalPiutang.Size = New System.Drawing.Size(151, 22)
        Me.txtTotalPiutang.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 16)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Total Retur *"
        '
        'txtTotalRetur
        '
        Me.txtTotalRetur.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLHutangBindingSource, "Total_Retur", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C0"))
        Me.txtTotalRetur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalRetur.Location = New System.Drawing.Point(156, 95)
        Me.txtTotalRetur.Name = "txtTotalRetur"
        Me.txtTotalRetur.ReadOnly = True
        Me.txtTotalRetur.Size = New System.Drawing.Size(151, 22)
        Me.txtTotalRetur.TabIndex = 60
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtTgl10)
        Me.GroupBox1.Controls.Add(Me.txtTgl9)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtBayar10)
        Me.GroupBox1.Controls.Add(Me.txtBayar9)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtTgl8)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtBayar8)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txtTgl7)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txtBayar7)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.txtTgl6)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.txtBayar6)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtTgl5)
        Me.GroupBox1.Controls.Add(Me.txtTgl4)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtBayar5)
        Me.GroupBox1.Controls.Add(Me.txtBayar4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtTgl3)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtBayar3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtTgl2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtBayar2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtTgl1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtBayar1)
        Me.GroupBox1.Location = New System.Drawing.Point(376, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(517, 236)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "History Pembayaran"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(272, 186)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 13)
        Me.Label15.TabIndex = 91
        Me.Label15.Text = "Keterangan 10"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(272, 146)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 13)
        Me.Label16.TabIndex = 99
        Me.Label16.Text = "Keterangan 9"
        '
        'txtTgl10
        '
        Me.txtTgl10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLHutangBindingSource, "Tgl_10", True))
        Me.txtTgl10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTgl10.Location = New System.Drawing.Point(275, 202)
        Me.txtTgl10.Name = "txtTgl10"
        Me.txtTgl10.Size = New System.Drawing.Size(88, 20)
        Me.txtTgl10.TabIndex = 82
        '
        'txtTgl9
        '
        Me.txtTgl9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLHutangBindingSource, "Tgl_9", True))
        Me.txtTgl9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTgl9.Location = New System.Drawing.Point(275, 162)
        Me.txtTgl9.Name = "txtTgl9"
        Me.txtTgl9.Size = New System.Drawing.Size(88, 20)
        Me.txtTgl9.TabIndex = 80
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(366, 186)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 13)
        Me.Label17.TabIndex = 89
        Me.Label17.Text = "Pembayaran 10"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(366, 146)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 13)
        Me.Label18.TabIndex = 98
        Me.Label18.Text = "Pembayaran 9"
        '
        'txtBayar10
        '
        Me.txtBayar10.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBLHutangBindingSource, "Pembayaran_10", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C0"))
        Me.txtBayar10.DataType = GetType(Decimal)
        Me.txtBayar10.DisableOnNoData = False
        Me.txtBayar10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBayar10.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtBayar10.Location = New System.Drawing.Point(369, 202)
        Me.txtBayar10.Name = "txtBayar10"
        Me.txtBayar10.Size = New System.Drawing.Size(129, 18)
        Me.txtBayar10.TabIndex = 83
        Me.txtBayar10.Tag = Nothing
        '
        'txtBayar9
        '
        Me.txtBayar9.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBLHutangBindingSource, "Pembayaran_9", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C0"))
        Me.txtBayar9.DataType = GetType(Decimal)
        Me.txtBayar9.DisableOnNoData = False
        Me.txtBayar9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBayar9.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtBayar9.Location = New System.Drawing.Point(369, 162)
        Me.txtBayar9.Name = "txtBayar9"
        Me.txtBayar9.Size = New System.Drawing.Size(129, 18)
        Me.txtBayar9.TabIndex = 81
        Me.txtBayar9.Tag = Nothing
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(272, 105)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 13)
        Me.Label19.TabIndex = 95
        Me.Label19.Text = "Keterangan 8"
        '
        'txtTgl8
        '
        Me.txtTgl8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLHutangBindingSource, "Tgl_8", True))
        Me.txtTgl8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTgl8.Location = New System.Drawing.Point(275, 121)
        Me.txtTgl8.Name = "txtTgl8"
        Me.txtTgl8.Size = New System.Drawing.Size(88, 20)
        Me.txtTgl8.TabIndex = 78
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(366, 105)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 13)
        Me.Label20.TabIndex = 94
        Me.Label20.Text = "Pembayaran 8"
        '
        'txtBayar8
        '
        Me.txtBayar8.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBLHutangBindingSource, "Pembayaran_8", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C0"))
        Me.txtBayar8.DataType = GetType(Decimal)
        Me.txtBayar8.DisableOnNoData = False
        Me.txtBayar8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBayar8.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtBayar8.Location = New System.Drawing.Point(369, 121)
        Me.txtBayar8.Name = "txtBayar8"
        Me.txtBayar8.Size = New System.Drawing.Size(129, 18)
        Me.txtBayar8.TabIndex = 79
        Me.txtBayar8.Tag = Nothing
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(272, 62)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(71, 13)
        Me.Label21.TabIndex = 90
        Me.Label21.Text = "Keterangan 7"
        '
        'txtTgl7
        '
        Me.txtTgl7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLHutangBindingSource, "Tgl_7", True))
        Me.txtTgl7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTgl7.Location = New System.Drawing.Point(275, 78)
        Me.txtTgl7.Name = "txtTgl7"
        Me.txtTgl7.Size = New System.Drawing.Size(88, 20)
        Me.txtTgl7.TabIndex = 76
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(366, 62)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(75, 13)
        Me.Label22.TabIndex = 88
        Me.Label22.Text = "Pembayaran 7"
        '
        'txtBayar7
        '
        Me.txtBayar7.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBLHutangBindingSource, "Pembayaran_7", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C0"))
        Me.txtBayar7.DataType = GetType(Decimal)
        Me.txtBayar7.DisableOnNoData = False
        Me.txtBayar7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBayar7.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtBayar7.Location = New System.Drawing.Point(369, 78)
        Me.txtBayar7.Name = "txtBayar7"
        Me.txtBayar7.Size = New System.Drawing.Size(129, 18)
        Me.txtBayar7.TabIndex = 77
        Me.txtBayar7.Tag = Nothing
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(272, 22)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(71, 13)
        Me.Label23.TabIndex = 83
        Me.Label23.Text = "Keterangan 6"
        '
        'txtTgl6
        '
        Me.txtTgl6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLHutangBindingSource, "Tgl_6", True))
        Me.txtTgl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTgl6.Location = New System.Drawing.Point(275, 38)
        Me.txtTgl6.Name = "txtTgl6"
        Me.txtTgl6.Size = New System.Drawing.Size(88, 20)
        Me.txtTgl6.TabIndex = 74
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(366, 22)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(75, 13)
        Me.Label24.TabIndex = 82
        Me.Label24.Text = "Pembayaran 6"
        '
        'txtBayar6
        '
        Me.txtBayar6.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBLHutangBindingSource, "Pembayaran_6", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C0"))
        Me.txtBayar6.DataType = GetType(Decimal)
        Me.txtBayar6.DisableOnNoData = False
        Me.txtBayar6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBayar6.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtBayar6.Location = New System.Drawing.Point(369, 38)
        Me.txtBayar6.Name = "txtBayar6"
        Me.txtBayar6.Size = New System.Drawing.Size(129, 18)
        Me.txtBayar6.TabIndex = 75
        Me.txtBayar6.Tag = Nothing
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 186)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 13)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "Keterangan 5"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 146)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 79
        Me.Label11.Text = "Keterangan 4"
        '
        'txtTgl5
        '
        Me.txtTgl5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLHutangBindingSource, "Tgl_5", True))
        Me.txtTgl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTgl5.Location = New System.Drawing.Point(19, 202)
        Me.txtTgl5.Name = "txtTgl5"
        Me.txtTgl5.Size = New System.Drawing.Size(88, 20)
        Me.txtTgl5.TabIndex = 72
        '
        'txtTgl4
        '
        Me.txtTgl4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLHutangBindingSource, "Tgl_4", True))
        Me.txtTgl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTgl4.Location = New System.Drawing.Point(19, 162)
        Me.txtTgl4.Name = "txtTgl4"
        Me.txtTgl4.Size = New System.Drawing.Size(88, 20)
        Me.txtTgl4.TabIndex = 70
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(110, 186)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 13)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "Pembayaran 5"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(110, 146)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 78
        Me.Label12.Text = "Pembayaran 4"
        '
        'txtBayar5
        '
        Me.txtBayar5.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBLHutangBindingSource, "Pembayaran_5", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C0"))
        Me.txtBayar5.DataType = GetType(Decimal)
        Me.txtBayar5.DisableOnNoData = False
        Me.txtBayar5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBayar5.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtBayar5.Location = New System.Drawing.Point(113, 202)
        Me.txtBayar5.Name = "txtBayar5"
        Me.txtBayar5.Size = New System.Drawing.Size(129, 18)
        Me.txtBayar5.TabIndex = 73
        Me.txtBayar5.Tag = Nothing
        '
        'txtBayar4
        '
        Me.txtBayar4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBLHutangBindingSource, "Pembayaran_4", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C0"))
        Me.txtBayar4.DataType = GetType(Decimal)
        Me.txtBayar4.DisableOnNoData = False
        Me.txtBayar4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBayar4.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtBayar4.Location = New System.Drawing.Point(113, 162)
        Me.txtBayar4.Name = "txtBayar4"
        Me.txtBayar4.Size = New System.Drawing.Size(129, 18)
        Me.txtBayar4.TabIndex = 71
        Me.txtBayar4.Tag = Nothing
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Keterangan 3"
        '
        'txtTgl3
        '
        Me.txtTgl3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLHutangBindingSource, "Tgl_3", True))
        Me.txtTgl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTgl3.Location = New System.Drawing.Point(19, 121)
        Me.txtTgl3.Name = "txtTgl3"
        Me.txtTgl3.Size = New System.Drawing.Size(88, 20)
        Me.txtTgl3.TabIndex = 68
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(110, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "Pembayaran 3"
        '
        'txtBayar3
        '
        Me.txtBayar3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBLHutangBindingSource, "Pembayaran_3", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C0"))
        Me.txtBayar3.DataType = GetType(Decimal)
        Me.txtBayar3.DisableOnNoData = False
        Me.txtBayar3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBayar3.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtBayar3.Location = New System.Drawing.Point(113, 121)
        Me.txtBayar3.Name = "txtBayar3"
        Me.txtBayar3.Size = New System.Drawing.Size(129, 18)
        Me.txtBayar3.TabIndex = 69
        Me.txtBayar3.Tag = Nothing
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Keterangan 2"
        '
        'txtTgl2
        '
        Me.txtTgl2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLHutangBindingSource, "Tgl_2", True))
        Me.txtTgl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTgl2.Location = New System.Drawing.Point(19, 78)
        Me.txtTgl2.Name = "txtTgl2"
        Me.txtTgl2.Size = New System.Drawing.Size(88, 20)
        Me.txtTgl2.TabIndex = 66
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(110, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Pembayaran 2"
        '
        'txtBayar2
        '
        Me.txtBayar2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBLHutangBindingSource, "Pembayaran_2", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C0"))
        Me.txtBayar2.DataType = GetType(Decimal)
        Me.txtBayar2.DisableOnNoData = False
        Me.txtBayar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBayar2.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtBayar2.Location = New System.Drawing.Point(113, 78)
        Me.txtBayar2.Name = "txtBayar2"
        Me.txtBayar2.Size = New System.Drawing.Size(129, 18)
        Me.txtBayar2.TabIndex = 67
        Me.txtBayar2.Tag = Nothing
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Keterangan 1"
        '
        'txtTgl1
        '
        Me.txtTgl1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLHutangBindingSource, "Tgl_1", True))
        Me.txtTgl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTgl1.Location = New System.Drawing.Point(19, 38)
        Me.txtTgl1.Name = "txtTgl1"
        Me.txtTgl1.Size = New System.Drawing.Size(88, 20)
        Me.txtTgl1.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(110, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Pembayaran 1"
        '
        'txtBayar1
        '
        Me.txtBayar1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBLHutangBindingSource, "Pembayaran_1", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C2"))
        Me.txtBayar1.DataType = GetType(Decimal)
        Me.txtBayar1.DisableOnNoData = False
        Me.txtBayar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBayar1.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtBayar1.Location = New System.Drawing.Point(113, 38)
        Me.txtBayar1.Name = "txtBayar1"
        Me.txtBayar1.Size = New System.Drawing.Size(129, 18)
        Me.txtBayar1.TabIndex = 65
        Me.txtBayar1.Tag = Nothing
        '
        'dtpTanggal
        '
        Me.dtpTanggal.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBLHutangBindingSource, "Tgl_Penagihan", True))
        Me.dtpTanggal.Location = New System.Drawing.Point(156, 123)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(200, 20)
        Me.dtpTanggal.TabIndex = 63
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 16)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Tanggal Tagih"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(12, 156)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(136, 16)
        Me.Label25.TabIndex = 64
        Me.Label25.Text = "Total Pembayaran"
        '
        'txtTotalBayar
        '
        Me.txtTotalBayar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLHutangBindingSource, "Total_Pembayaran", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C0"))
        Me.txtTotalBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalBayar.Location = New System.Drawing.Point(156, 153)
        Me.txtTotalBayar.Name = "txtTotalBayar"
        Me.txtTotalBayar.ReadOnly = True
        Me.txtTotalBayar.Size = New System.Drawing.Size(151, 22)
        Me.txtTotalBayar.TabIndex = 65
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(12, 185)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(92, 16)
        Me.Label26.TabIndex = 66
        Me.Label26.Text = "Sisa Hutang"
        '
        'txtSisaPiutang
        '
        Me.txtSisaPiutang.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLHutangBindingSource, "Sisa_Hutang", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C0"))
        Me.txtSisaPiutang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSisaPiutang.Location = New System.Drawing.Point(156, 182)
        Me.txtSisaPiutang.Name = "txtSisaPiutang"
        Me.txtSisaPiutang.ReadOnly = True
        Me.txtSisaPiutang.Size = New System.Drawing.Size(151, 22)
        Me.txtSisaPiutang.TabIndex = 67
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(12, 213)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(51, 16)
        Me.Label27.TabIndex = 68
        Me.Label27.Text = "Status"
        '
        'txtStatus
        '
        Me.txtStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLHutangBindingSource, "Status", True))
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(156, 210)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(151, 22)
        Me.txtStatus.TabIndex = 69
        '
        'dgvPenjualan
        '
        Me.dgvPenjualan.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.dgvPenjualan.AllowEditing = False
        Me.dgvPenjualan.AllowFiltering = True
        Me.dgvPenjualan.ColumnInfo = resources.GetString("dgvPenjualan.ColumnInfo")
        Me.dgvPenjualan.DataSource = Me.TBLHutangBindingSource
        Me.dgvPenjualan.Location = New System.Drawing.Point(15, 281)
        Me.dgvPenjualan.Name = "dgvPenjualan"
        Me.dgvPenjualan.Rows.Count = 1
        Me.dgvPenjualan.Rows.DefaultSize = 19
        Me.dgvPenjualan.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.dgvPenjualan.Size = New System.Drawing.Size(963, 300)
        Me.dgvPenjualan.TabIndex = 439
        Me.dgvPenjualan.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'TBL_HutangTableAdapter
        '
        Me.TBL_HutangTableAdapter.ClearBeforeFill = True
        '
        'FRM_Hutang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 593)
        Me.Controls.Add(Me.dgvPenjualan)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.txtSisaPiutang)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtTotalBayar)
        Me.Controls.Add(Me.dtpTanggal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTotalRetur)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTotalPiutang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNoFaktur)
        Me.Controls.Add(Me.bnHutang)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FRM_Hutang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form Hutang"
        CType(Me.bnHutang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnHutang.ResumeLayout(False)
        Me.bnHutang.PerformLayout()
        CType(Me.TBLHutangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_POS_CNDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtBayar10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBayar9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBayar8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBayar7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBayar6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBayar5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBayar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBayar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBayar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBayar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bnHutang As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsSimpan As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtKataKunci As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents cboKriteria As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoFaktur As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTotalPiutang As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTotalRetur As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBayar1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTgl1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTgl4 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtBayar4 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTgl3 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtBayar3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTgl2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBayar2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtTgl10 As System.Windows.Forms.TextBox
    Friend WithEvents txtTgl9 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtBayar10 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtBayar9 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtTgl8 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtBayar8 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtTgl7 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtBayar7 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtTgl6 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtBayar6 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTgl5 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtBayar5 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtTotalBayar As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtSisaPiutang As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents tsBL As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsL As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvPenjualan As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Db_POS_CNDataSet As Best_POS.db_POS_CNDataSet
    Friend WithEvents TBLHutangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_HutangTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_HutangTableAdapter
End Class
