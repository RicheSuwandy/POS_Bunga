<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Barang_Detail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Barang_Detail))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.bnCustomer = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.dgvBarangDetail = New System.Windows.Forms.DataGridView()
        Me.KodeBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDBarangDetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarangDetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBLBarangDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_POS_CNDataSet = New Best_POS.db_POS_CNDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKodeBarang = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdDetail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNamaDetail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQtyDetail = New System.Windows.Forms.TextBox()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.TBL_Barang_DetailTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Barang_DetailTableAdapter()
        Me.TbL_BarangTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_BarangTableAdapter()
        Me.TbL_Pembelian_DetailTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Pembelian_DetailTableAdapter()
        Me.TbL_Penjualan_DetailTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Penjualan_DetailTableAdapter()
        CType(Me.bnCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnCustomer.SuspendLayout()
        CType(Me.dgvBarangDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBarangDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_POS_CNDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bnCustomer
        '
        Me.bnCustomer.AddNewItem = Nothing
        Me.bnCustomer.CountItem = Me.BindingNavigatorCountItem
        Me.bnCustomer.DeleteItem = Nothing
        Me.bnCustomer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.tsTambah, Me.tsSimpan, Me.tsHapus, Me.tsRefresh, Me.ToolStripSeparator1})
        Me.bnCustomer.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.bnCustomer.Location = New System.Drawing.Point(0, 0)
        Me.bnCustomer.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnCustomer.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnCustomer.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnCustomer.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnCustomer.Name = "bnCustomer"
        Me.bnCustomer.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.bnCustomer.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnCustomer.Size = New System.Drawing.Size(857, 27)
        Me.bnCustomer.TabIndex = 55
        Me.bnCustomer.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'tsTambah
        '
        Me.tsTambah.Image = CType(resources.GetObject("tsTambah.Image"), System.Drawing.Image)
        Me.tsTambah.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsTambah.Name = "tsTambah"
        Me.tsTambah.Size = New System.Drawing.Size(57, 24)
        Me.tsTambah.Text = "&Add"
        '
        'tsSimpan
        '
        Me.tsSimpan.Image = CType(resources.GetObject("tsSimpan.Image"), System.Drawing.Image)
        Me.tsSimpan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSimpan.Name = "tsSimpan"
        Me.tsSimpan.Size = New System.Drawing.Size(60, 24)
        Me.tsSimpan.Text = "&Save"
        '
        'tsHapus
        '
        Me.tsHapus.Image = CType(resources.GetObject("tsHapus.Image"), System.Drawing.Image)
        Me.tsHapus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsHapus.Name = "tsHapus"
        Me.tsHapus.Size = New System.Drawing.Size(73, 24)
        Me.tsHapus.Text = "&Delete"
        '
        'tsRefresh
        '
        Me.tsRefresh.Image = CType(resources.GetObject("tsRefresh.Image"), System.Drawing.Image)
        Me.tsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsRefresh.Name = "tsRefresh"
        Me.tsRefresh.Size = New System.Drawing.Size(78, 24)
        Me.tsRefresh.Text = "&Refresh"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'dgvBarangDetail
        '
        Me.dgvBarangDetail.AllowUserToAddRows = False
        Me.dgvBarangDetail.AllowUserToDeleteRows = False
        Me.dgvBarangDetail.AutoGenerateColumns = False
        Me.dgvBarangDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvBarangDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBarangDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeBarangDataGridViewTextBoxColumn, Me.IDBarangDetailDataGridViewTextBoxColumn, Me.NamaBarangDetailDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn})
        Me.dgvBarangDetail.DataSource = Me.TBLBarangDetailBindingSource
        Me.dgvBarangDetail.Location = New System.Drawing.Point(40, 198)
        Me.dgvBarangDetail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvBarangDetail.Name = "dgvBarangDetail"
        Me.dgvBarangDetail.ReadOnly = True
        Me.dgvBarangDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBarangDetail.Size = New System.Drawing.Size(781, 284)
        Me.dgvBarangDetail.TabIndex = 56
        '
        'KodeBarangDataGridViewTextBoxColumn
        '
        Me.KodeBarangDataGridViewTextBoxColumn.DataPropertyName = "Kode_Barang"
        Me.KodeBarangDataGridViewTextBoxColumn.HeaderText = "Kode Barang"
        Me.KodeBarangDataGridViewTextBoxColumn.Name = "KodeBarangDataGridViewTextBoxColumn"
        Me.KodeBarangDataGridViewTextBoxColumn.ReadOnly = True
        Me.KodeBarangDataGridViewTextBoxColumn.Width = 106
        '
        'IDBarangDetailDataGridViewTextBoxColumn
        '
        Me.IDBarangDetailDataGridViewTextBoxColumn.DataPropertyName = "ID_Barang_Detail"
        Me.IDBarangDetailDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDBarangDetailDataGridViewTextBoxColumn.Name = "IDBarangDetailDataGridViewTextBoxColumn"
        Me.IDBarangDetailDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDBarangDetailDataGridViewTextBoxColumn.Width = 46
        '
        'NamaBarangDetailDataGridViewTextBoxColumn
        '
        Me.NamaBarangDetailDataGridViewTextBoxColumn.DataPropertyName = "Nama_Barang_Detail"
        Me.NamaBarangDetailDataGridViewTextBoxColumn.HeaderText = "Nama Barang Detail"
        Me.NamaBarangDetailDataGridViewTextBoxColumn.Name = "NamaBarangDetailDataGridViewTextBoxColumn"
        Me.NamaBarangDetailDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamaBarangDetailDataGridViewTextBoxColumn.Width = 146
        '
        'QtyDataGridViewTextBoxColumn
        '
        Me.QtyDataGridViewTextBoxColumn.DataPropertyName = "Qty"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.QtyDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.QtyDataGridViewTextBoxColumn.HeaderText = "Qty"
        Me.QtyDataGridViewTextBoxColumn.Name = "QtyDataGridViewTextBoxColumn"
        Me.QtyDataGridViewTextBoxColumn.ReadOnly = True
        Me.QtyDataGridViewTextBoxColumn.Width = 55
        '
        'TBLBarangDetailBindingSource
        '
        Me.TBLBarangDetailBindingSource.DataMember = "TBL_Barang_Detail"
        Me.TBLBarangDetailBindingSource.DataSource = Me.Db_POS_CNDataSet
        '
        'Db_POS_CNDataSet
        '
        Me.Db_POS_CNDataSet.DataSetName = "db_POS_CNDataSet"
        Me.Db_POS_CNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 20)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Kode Barang *"
        '
        'txtKodeBarang
        '
        Me.txtKodeBarang.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLBarangDetailBindingSource, "Kode_Barang", True))
        Me.txtKodeBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeBarang.Location = New System.Drawing.Point(280, 60)
        Me.txtKodeBarang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.ReadOnly = True
        Me.txtKodeBarang.Size = New System.Drawing.Size(198, 26)
        Me.txtKodeBarang.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 98)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 20)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "ID Barang Detail *"
        '
        'txtIdDetail
        '
        Me.txtIdDetail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLBarangDetailBindingSource, "ID_Barang_Detail", True))
        Me.txtIdDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdDetail.Location = New System.Drawing.Point(280, 94)
        Me.txtIdDetail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIdDetail.Name = "txtIdDetail"
        Me.txtIdDetail.ReadOnly = True
        Me.txtIdDetail.Size = New System.Drawing.Size(128, 26)
        Me.txtIdDetail.TabIndex = 68
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 133)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 20)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Nama Barang Detail"
        '
        'txtNamaDetail
        '
        Me.txtNamaDetail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLBarangDetailBindingSource, "Nama_Barang_Detail", True))
        Me.txtNamaDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaDetail.Location = New System.Drawing.Point(280, 130)
        Me.txtNamaDetail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNamaDetail.Name = "txtNamaDetail"
        Me.txtNamaDetail.Size = New System.Drawing.Size(472, 26)
        Me.txtNamaDetail.TabIndex = 70
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 167)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 20)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Qty"
        '
        'txtQtyDetail
        '
        Me.txtQtyDetail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLBarangDetailBindingSource, "Qty", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"))
        Me.txtQtyDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtyDetail.Location = New System.Drawing.Point(280, 164)
        Me.txtQtyDetail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtQtyDetail.Name = "txtQtyDetail"
        Me.txtQtyDetail.ReadOnly = True
        Me.txtQtyDetail.Size = New System.Drawing.Size(128, 26)
        Me.txtQtyDetail.TabIndex = 72
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Enabled = False
        Me.txtNamaBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaBarang.Location = New System.Drawing.Point(488, 61)
        Me.txtNamaBarang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.ReadOnly = True
        Me.txtNamaBarang.Size = New System.Drawing.Size(264, 26)
        Me.txtNamaBarang.TabIndex = 74
        '
        'TBL_Barang_DetailTableAdapter
        '
        Me.TBL_Barang_DetailTableAdapter.ClearBeforeFill = True
        '
        'TbL_BarangTableAdapter
        '
        Me.TbL_BarangTableAdapter.ClearBeforeFill = True
        '
        'TbL_Pembelian_DetailTableAdapter
        '
        Me.TbL_Pembelian_DetailTableAdapter.ClearBeforeFill = True
        '
        'TbL_Penjualan_DetailTableAdapter
        '
        Me.TbL_Penjualan_DetailTableAdapter.ClearBeforeFill = True
        '
        'FRM_Barang_Detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 514)
        Me.Controls.Add(Me.txtNamaBarang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtQtyDetail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNamaDetail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIdDetail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKodeBarang)
        Me.Controls.Add(Me.dgvBarangDetail)
        Me.Controls.Add(Me.bnCustomer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_Barang_Detail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Detail Barang"
        CType(Me.bnCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnCustomer.ResumeLayout(False)
        Me.bnCustomer.PerformLayout()
        CType(Me.dgvBarangDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBarangDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_POS_CNDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bnCustomer As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents dgvBarangDetail As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKodeBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIdDetail As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNamaDetail As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtQtyDetail As System.Windows.Forms.TextBox
    Friend WithEvents Db_POS_CNDataSet As Best_POS.db_POS_CNDataSet
    Friend WithEvents TBLBarangDetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_Barang_DetailTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Barang_DetailTableAdapter
    Friend WithEvents KodeBarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDBarangDetailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarangDetailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TbL_BarangTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_BarangTableAdapter
    Friend WithEvents TbL_Pembelian_DetailTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Pembelian_DetailTableAdapter
    Friend WithEvents TbL_Penjualan_DetailTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Penjualan_DetailTableAdapter
    Friend WithEvents txtNamaBarang As System.Windows.Forms.TextBox
End Class
