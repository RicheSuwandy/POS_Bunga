<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Edit_Item_Pembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Edit_Item_Pembelian))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDiscRupiah = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDiscPersen = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtKodePembelian = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHargaJual = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKodeBarang = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.TbL_BarangTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_BarangTableAdapter()
        Me.dgvBarang = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.TBLBarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_POS_CNDataSet = New Best_POS.db_POS_CNDataSet()
        Me.TbL_Harga_SupplierTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Harga_SupplierTableAdapter()
        Me.TbL_Alokasi_PembelianTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Alokasi_PembelianTableAdapter()
        Me.TbL_Pembelian_DetailTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Pembelian_DetailTableAdapter()
        Me.TbL_Pembelian_HeaderTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Pembelian_HeaderTableAdapter()
        Me.TbL_HutangTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_HutangTableAdapter()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_POS_CNDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 246)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "Subtotal"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotal.Location = New System.Drawing.Point(114, 241)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(118, 22)
        Me.txtSubtotal.TabIndex = 67
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 218)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "Disc Rupiah"
        '
        'txtDiscRupiah
        '
        Me.txtDiscRupiah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscRupiah.Location = New System.Drawing.Point(114, 213)
        Me.txtDiscRupiah.Name = "txtDiscRupiah"
        Me.txtDiscRupiah.Size = New System.Drawing.Size(118, 22)
        Me.txtDiscRupiah.TabIndex = 66
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "Disc %"
        '
        'txtDiscPersen
        '
        Me.txtDiscPersen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscPersen.Location = New System.Drawing.Point(114, 185)
        Me.txtDiscPersen.Name = "txtDiscPersen"
        Me.txtDiscPersen.Size = New System.Drawing.Size(53, 22)
        Me.txtDiscPersen.TabIndex = 64
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(201, 269)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 70
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(114, 269)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 69
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Kode Penjualan"
        '
        'txtKodePembelian
        '
        Me.txtKodePembelian.Enabled = False
        Me.txtKodePembelian.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodePembelian.Location = New System.Drawing.Point(114, 17)
        Me.txtKodePembelian.Name = "txtKodePembelian"
        Me.txtKodePembelian.Size = New System.Drawing.Size(104, 22)
        Me.txtKodePembelian.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Qty Jual"
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(114, 157)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(75, 22)
        Me.txtQty.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Harga Jual"
        '
        'txtHargaJual
        '
        Me.txtHargaJual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHargaJual.Location = New System.Drawing.Point(114, 129)
        Me.txtHargaJual.Name = "txtHargaJual"
        Me.txtHargaJual.Size = New System.Drawing.Size(118, 22)
        Me.txtHargaJual.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Nama Barang"
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaBarang.Location = New System.Drawing.Point(114, 101)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.ReadOnly = True
        Me.txtNamaBarang.Size = New System.Drawing.Size(233, 22)
        Me.txtNamaBarang.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Kode Barang"
        '
        'txtKodeBarang
        '
        Me.txtKodeBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeBarang.Location = New System.Drawing.Point(114, 73)
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.Size = New System.Drawing.Size(104, 22)
        Me.txtKodeBarang.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "No"
        '
        'txtNo
        '
        Me.txtNo.Enabled = False
        Me.txtNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNo.Location = New System.Drawing.Point(114, 45)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(42, 22)
        Me.txtNo.TabIndex = 54
        '
        'TbL_BarangTableAdapter
        '
        Me.TbL_BarangTableAdapter.ClearBeforeFill = True
        '
        'dgvBarang
        '
        Me.dgvBarang.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.dgvBarang.AllowEditing = False
        Me.dgvBarang.AllowFiltering = True
        Me.dgvBarang.ColumnInfo = resources.GetString("dgvBarang.ColumnInfo")
        Me.dgvBarang.DataSource = Me.TBLBarangBindingSource
        Me.dgvBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvBarang.Location = New System.Drawing.Point(114, 95)
        Me.dgvBarang.Name = "dgvBarang"
        Me.dgvBarang.Rows.Count = 1
        Me.dgvBarang.Rows.DefaultSize = 17
        Me.dgvBarang.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.dgvBarang.Size = New System.Drawing.Size(413, 122)
        Me.dgvBarang.StyleInfo = resources.GetString("dgvBarang.StyleInfo")
        Me.dgvBarang.TabIndex = 440
        Me.dgvBarang.Visible = False
        Me.dgvBarang.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'TBLBarangBindingSource
        '
        Me.TBLBarangBindingSource.DataMember = "TBL_Barang"
        Me.TBLBarangBindingSource.DataSource = Me.Db_POS_CNDataSet
        '
        'Db_POS_CNDataSet
        '
        Me.Db_POS_CNDataSet.DataSetName = "db_POS_CNDataSet"
        Me.Db_POS_CNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbL_Harga_SupplierTableAdapter
        '
        Me.TbL_Harga_SupplierTableAdapter.ClearBeforeFill = True
        '
        'TbL_Alokasi_PembelianTableAdapter
        '
        Me.TbL_Alokasi_PembelianTableAdapter.ClearBeforeFill = True
        '
        'TbL_Pembelian_DetailTableAdapter
        '
        Me.TbL_Pembelian_DetailTableAdapter.ClearBeforeFill = True
        '
        'TbL_Pembelian_HeaderTableAdapter
        '
        Me.TbL_Pembelian_HeaderTableAdapter.ClearBeforeFill = True
        '
        'TbL_HutangTableAdapter
        '
        Me.TbL_HutangTableAdapter.ClearBeforeFill = True
        '
        'FRM_Edit_Item_Pembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 306)
        Me.Controls.Add(Me.dgvBarang)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDiscRupiah)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDiscPersen)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtKodePembelian)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtHargaJual)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNamaBarang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKodeBarang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_Edit_Item_Pembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Edit Item Penjualan"
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_POS_CNDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDiscRupiah As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDiscPersen As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtKodePembelian As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtHargaJual As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNamaBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKodeBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    Friend WithEvents TbL_BarangTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_BarangTableAdapter
    Friend WithEvents dgvBarang As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents TBLBarangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Db_POS_CNDataSet As Best_POS.db_POS_CNDataSet
    Friend WithEvents TbL_Harga_SupplierTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Harga_SupplierTableAdapter
    Friend WithEvents TbL_Alokasi_PembelianTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Alokasi_PembelianTableAdapter
    Friend WithEvents TbL_Pembelian_DetailTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Pembelian_DetailTableAdapter
    Friend WithEvents TbL_Pembelian_HeaderTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Pembelian_HeaderTableAdapter
    Friend WithEvents TbL_HutangTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_HutangTableAdapter
End Class
