<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Utama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Utama))
        Me.msBestPos = New System.Windows.Forms.MenuStrip()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BiayaOperasionalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FakturPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HutangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FakturPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PiutangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryHargaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HargaCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HargaSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanStokBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPembelianPerTanggalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPembelianPerSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RekapanLaporanPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPenjualanPerPeriodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPenjualanPerCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPenjualanPerSalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPenjualanSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPenjualanCashKreditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanReturToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanReturPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanReturPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanHutangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LaporanPiutangToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPiutangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanTagihanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanLabaKotorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanLabaRugiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LaporanStockAkhirTahunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsBestPos = New System.Windows.Forms.ToolStrip()
        Me.tsbUser = New System.Windows.Forms.ToolStripButton()
        Me.tsbBarang = New System.Windows.Forms.ToolStripButton()
        Me.tsbPembelian = New System.Windows.Forms.ToolStripButton()
        Me.tsbPenjualan = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHutang = New System.Windows.Forms.ToolStripButton()
        Me.tsbPiutang = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TbL_UserTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_UserTableAdapter()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelCompanyName = New System.Windows.Forms.Label()
        Me.TextBoxDescription = New System.Windows.Forms.Label()
        Me.LabelCopyright = New System.Windows.Forms.Label()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.LabelProductName = New System.Windows.Forms.Label()
        Me.DGVNoftification = New System.Windows.Forms.DataGridView()
        Me.msBestPos.SuspendLayout()
        Me.tsBestPos.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVNoftification, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'msBestPos
        '
        Me.msBestPos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.UserManagementToolStripMenuItem, Me.BiayaOperasionalToolStripMenuItem, Me.BarangToolStripMenuItem, Me.PembelianToolStripMenuItem, Me.PenjualanToolStripMenuItem, Me.HistoryHargaToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.msBestPos.Location = New System.Drawing.Point(0, 0)
        Me.msBestPos.Name = "msBestPos"
        Me.msBestPos.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.msBestPos.Size = New System.Drawing.Size(1282, 28)
        Me.msBestPos.TabIndex = 2
        Me.msBestPos.Text = "MenuStrip1"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.UserToolStripMenuItem.Image = CType(resources.GetObject("UserToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.UserToolStripMenuItem.Text = "Aplikasi"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(125, 24)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(125, 24)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'UserManagementToolStripMenuItem
        '
        Me.UserManagementToolStripMenuItem.Image = CType(resources.GetObject("UserManagementToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UserManagementToolStripMenuItem.Name = "UserManagementToolStripMenuItem"
        Me.UserManagementToolStripMenuItem.Size = New System.Drawing.Size(158, 24)
        Me.UserManagementToolStripMenuItem.Text = "User Management"
        '
        'BiayaOperasionalToolStripMenuItem
        '
        Me.BiayaOperasionalToolStripMenuItem.Image = CType(resources.GetObject("BiayaOperasionalToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BiayaOperasionalToolStripMenuItem.Name = "BiayaOperasionalToolStripMenuItem"
        Me.BiayaOperasionalToolStripMenuItem.Size = New System.Drawing.Size(157, 24)
        Me.BiayaOperasionalToolStripMenuItem.Text = "Biaya Operasional"
        Me.BiayaOperasionalToolStripMenuItem.Visible = False
        '
        'BarangToolStripMenuItem
        '
        Me.BarangToolStripMenuItem.Image = CType(resources.GetObject("BarangToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        Me.BarangToolStripMenuItem.Size = New System.Drawing.Size(84, 24)
        Me.BarangToolStripMenuItem.Text = "Barang"
        '
        'PembelianToolStripMenuItem
        '
        Me.PembelianToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FakturPembelianToolStripMenuItem, Me.ReturPembelianToolStripMenuItem, Me.SupplierToolStripMenuItem, Me.HutangToolStripMenuItem})
        Me.PembelianToolStripMenuItem.Image = CType(resources.GetObject("PembelianToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PembelianToolStripMenuItem.Name = "PembelianToolStripMenuItem"
        Me.PembelianToolStripMenuItem.Size = New System.Drawing.Size(106, 24)
        Me.PembelianToolStripMenuItem.Text = "Pembelian"
        '
        'FakturPembelianToolStripMenuItem
        '
        Me.FakturPembelianToolStripMenuItem.Name = "FakturPembelianToolStripMenuItem"
        Me.FakturPembelianToolStripMenuItem.Size = New System.Drawing.Size(190, 24)
        Me.FakturPembelianToolStripMenuItem.Text = "Faktur Pembelian"
        '
        'ReturPembelianToolStripMenuItem
        '
        Me.ReturPembelianToolStripMenuItem.Name = "ReturPembelianToolStripMenuItem"
        Me.ReturPembelianToolStripMenuItem.Size = New System.Drawing.Size(190, 24)
        Me.ReturPembelianToolStripMenuItem.Text = "Retur Pembelian"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(190, 24)
        Me.SupplierToolStripMenuItem.Text = "Supplier"
        '
        'HutangToolStripMenuItem
        '
        Me.HutangToolStripMenuItem.Name = "HutangToolStripMenuItem"
        Me.HutangToolStripMenuItem.Size = New System.Drawing.Size(190, 24)
        Me.HutangToolStripMenuItem.Text = "Hutang"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FakturPenjualanToolStripMenuItem, Me.ReturPenjualanToolStripMenuItem, Me.SalesToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.PiutangToolStripMenuItem})
        Me.PenjualanToolStripMenuItem.Image = CType(resources.GetObject("PenjualanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(100, 24)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'FakturPenjualanToolStripMenuItem
        '
        Me.FakturPenjualanToolStripMenuItem.Name = "FakturPenjualanToolStripMenuItem"
        Me.FakturPenjualanToolStripMenuItem.Size = New System.Drawing.Size(184, 24)
        Me.FakturPenjualanToolStripMenuItem.Text = "Faktur Penjualan"
        '
        'ReturPenjualanToolStripMenuItem
        '
        Me.ReturPenjualanToolStripMenuItem.Name = "ReturPenjualanToolStripMenuItem"
        Me.ReturPenjualanToolStripMenuItem.Size = New System.Drawing.Size(184, 24)
        Me.ReturPenjualanToolStripMenuItem.Text = "Retur Penjualan"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(184, 24)
        Me.SalesToolStripMenuItem.Text = "Sales"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(184, 24)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'PiutangToolStripMenuItem
        '
        Me.PiutangToolStripMenuItem.Name = "PiutangToolStripMenuItem"
        Me.PiutangToolStripMenuItem.Size = New System.Drawing.Size(184, 24)
        Me.PiutangToolStripMenuItem.Text = "Piutang"
        '
        'HistoryHargaToolStripMenuItem
        '
        Me.HistoryHargaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HargaCustomerToolStripMenuItem, Me.HargaSupplierToolStripMenuItem})
        Me.HistoryHargaToolStripMenuItem.Image = CType(resources.GetObject("HistoryHargaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HistoryHargaToolStripMenuItem.Name = "HistoryHargaToolStripMenuItem"
        Me.HistoryHargaToolStripMenuItem.Size = New System.Drawing.Size(129, 24)
        Me.HistoryHargaToolStripMenuItem.Text = "History Harga"
        Me.HistoryHargaToolStripMenuItem.Visible = False
        '
        'HargaCustomerToolStripMenuItem
        '
        Me.HargaCustomerToolStripMenuItem.Name = "HargaCustomerToolStripMenuItem"
        Me.HargaCustomerToolStripMenuItem.Size = New System.Drawing.Size(186, 24)
        Me.HargaCustomerToolStripMenuItem.Text = "Harga Customer"
        '
        'HargaSupplierToolStripMenuItem
        '
        Me.HargaSupplierToolStripMenuItem.Name = "HargaSupplierToolStripMenuItem"
        Me.HargaSupplierToolStripMenuItem.Size = New System.Drawing.Size(186, 24)
        Me.HargaSupplierToolStripMenuItem.Text = "Harga Supplier"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanStokBarangToolStripMenuItem, Me.LaporanPembelianToolStripMenuItem, Me.LaporanPenjualanToolStripMenuItem, Me.LaporanReturToolStripMenuItem, Me.LaporanHutangToolStripMenuItem, Me.ToolStripMenuItem1, Me.LaporanPiutangToolStripMenuItem1, Me.LaporanPiutangToolStripMenuItem, Me.LaporanTagihanToolStripMenuItem, Me.LaporanLabaKotorToolStripMenuItem, Me.LaporanLabaRugiToolStripMenuItem, Me.ToolStripMenuItem2, Me.LaporanStockAkhirTahunToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Image = CType(resources.GetObject("LaporanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(91, 24)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanStokBarangToolStripMenuItem
        '
        Me.LaporanStokBarangToolStripMenuItem.Name = "LaporanStokBarangToolStripMenuItem"
        Me.LaporanStokBarangToolStripMenuItem.Size = New System.Drawing.Size(252, 24)
        Me.LaporanStokBarangToolStripMenuItem.Text = "Laporan Stok Barang"
        '
        'LaporanPembelianToolStripMenuItem
        '
        Me.LaporanPembelianToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanPembelianPerTanggalToolStripMenuItem, Me.LaporanPembelianPerSupplierToolStripMenuItem, Me.RekapanLaporanPembelianToolStripMenuItem})
        Me.LaporanPembelianToolStripMenuItem.Name = "LaporanPembelianToolStripMenuItem"
        Me.LaporanPembelianToolStripMenuItem.Size = New System.Drawing.Size(252, 24)
        Me.LaporanPembelianToolStripMenuItem.Text = "Laporan Pembelian"
        '
        'LaporanPembelianPerTanggalToolStripMenuItem
        '
        Me.LaporanPembelianPerTanggalToolStripMenuItem.Name = "LaporanPembelianPerTanggalToolStripMenuItem"
        Me.LaporanPembelianPerTanggalToolStripMenuItem.Size = New System.Drawing.Size(288, 24)
        Me.LaporanPembelianPerTanggalToolStripMenuItem.Text = "Laporan Pembelian Per Periode"
        '
        'LaporanPembelianPerSupplierToolStripMenuItem
        '
        Me.LaporanPembelianPerSupplierToolStripMenuItem.Name = "LaporanPembelianPerSupplierToolStripMenuItem"
        Me.LaporanPembelianPerSupplierToolStripMenuItem.Size = New System.Drawing.Size(288, 24)
        Me.LaporanPembelianPerSupplierToolStripMenuItem.Text = "Laporan Pembelian Per Supplier"
        '
        'RekapanLaporanPembelianToolStripMenuItem
        '
        Me.RekapanLaporanPembelianToolStripMenuItem.Name = "RekapanLaporanPembelianToolStripMenuItem"
        Me.RekapanLaporanPembelianToolStripMenuItem.Size = New System.Drawing.Size(288, 24)
        Me.RekapanLaporanPembelianToolStripMenuItem.Text = "Rekapan Laporan Pembelian"
        '
        'LaporanPenjualanToolStripMenuItem
        '
        Me.LaporanPenjualanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanPenjualanPerPeriodeToolStripMenuItem, Me.LaporanPenjualanPerCustomerToolStripMenuItem, Me.LaporanPenjualanPerSalesToolStripMenuItem, Me.LaporanPenjualanSummaryToolStripMenuItem, Me.LaporanPenjualanCashKreditToolStripMenuItem})
        Me.LaporanPenjualanToolStripMenuItem.Name = "LaporanPenjualanToolStripMenuItem"
        Me.LaporanPenjualanToolStripMenuItem.Size = New System.Drawing.Size(252, 24)
        Me.LaporanPenjualanToolStripMenuItem.Text = "Laporan Penjualan"
        '
        'LaporanPenjualanPerPeriodeToolStripMenuItem
        '
        Me.LaporanPenjualanPerPeriodeToolStripMenuItem.Name = "LaporanPenjualanPerPeriodeToolStripMenuItem"
        Me.LaporanPenjualanPerPeriodeToolStripMenuItem.Size = New System.Drawing.Size(290, 24)
        Me.LaporanPenjualanPerPeriodeToolStripMenuItem.Text = "Laporan Penjualan Per Periode"
        '
        'LaporanPenjualanPerCustomerToolStripMenuItem
        '
        Me.LaporanPenjualanPerCustomerToolStripMenuItem.Name = "LaporanPenjualanPerCustomerToolStripMenuItem"
        Me.LaporanPenjualanPerCustomerToolStripMenuItem.Size = New System.Drawing.Size(290, 24)
        Me.LaporanPenjualanPerCustomerToolStripMenuItem.Text = "Laporan Penjualan Per Customer"
        '
        'LaporanPenjualanPerSalesToolStripMenuItem
        '
        Me.LaporanPenjualanPerSalesToolStripMenuItem.Name = "LaporanPenjualanPerSalesToolStripMenuItem"
        Me.LaporanPenjualanPerSalesToolStripMenuItem.Size = New System.Drawing.Size(290, 24)
        Me.LaporanPenjualanPerSalesToolStripMenuItem.Text = "Laporan Penjualan Per Sales"
        '
        'LaporanPenjualanSummaryToolStripMenuItem
        '
        Me.LaporanPenjualanSummaryToolStripMenuItem.Name = "LaporanPenjualanSummaryToolStripMenuItem"
        Me.LaporanPenjualanSummaryToolStripMenuItem.Size = New System.Drawing.Size(290, 24)
        Me.LaporanPenjualanSummaryToolStripMenuItem.Text = "Laporan Penjualan Summary"
        '
        'LaporanPenjualanCashKreditToolStripMenuItem
        '
        Me.LaporanPenjualanCashKreditToolStripMenuItem.Name = "LaporanPenjualanCashKreditToolStripMenuItem"
        Me.LaporanPenjualanCashKreditToolStripMenuItem.Size = New System.Drawing.Size(290, 24)
        Me.LaporanPenjualanCashKreditToolStripMenuItem.Text = "Laporan Penjualan Cash / Kredit"
        '
        'LaporanReturToolStripMenuItem
        '
        Me.LaporanReturToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanReturPembelianToolStripMenuItem, Me.LaporanReturPenjualanToolStripMenuItem})
        Me.LaporanReturToolStripMenuItem.Name = "LaporanReturToolStripMenuItem"
        Me.LaporanReturToolStripMenuItem.Size = New System.Drawing.Size(252, 24)
        Me.LaporanReturToolStripMenuItem.Text = "Laporan Retur"
        '
        'LaporanReturPembelianToolStripMenuItem
        '
        Me.LaporanReturPembelianToolStripMenuItem.Name = "LaporanReturPembelianToolStripMenuItem"
        Me.LaporanReturPembelianToolStripMenuItem.Size = New System.Drawing.Size(244, 24)
        Me.LaporanReturPembelianToolStripMenuItem.Text = "Laporan Retur Pembelian"
        '
        'LaporanReturPenjualanToolStripMenuItem
        '
        Me.LaporanReturPenjualanToolStripMenuItem.Name = "LaporanReturPenjualanToolStripMenuItem"
        Me.LaporanReturPenjualanToolStripMenuItem.Size = New System.Drawing.Size(244, 24)
        Me.LaporanReturPenjualanToolStripMenuItem.Text = "Laporan Retur Penjualan"
        '
        'LaporanHutangToolStripMenuItem
        '
        Me.LaporanHutangToolStripMenuItem.Name = "LaporanHutangToolStripMenuItem"
        Me.LaporanHutangToolStripMenuItem.Size = New System.Drawing.Size(252, 24)
        Me.LaporanHutangToolStripMenuItem.Text = "Laporan Hutang"
        Me.LaporanHutangToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(249, 6)
        '
        'LaporanPiutangToolStripMenuItem1
        '
        Me.LaporanPiutangToolStripMenuItem1.Name = "LaporanPiutangToolStripMenuItem1"
        Me.LaporanPiutangToolStripMenuItem1.Size = New System.Drawing.Size(252, 24)
        Me.LaporanPiutangToolStripMenuItem1.Text = "Laporan Piutang"
        '
        'LaporanPiutangToolStripMenuItem
        '
        Me.LaporanPiutangToolStripMenuItem.Name = "LaporanPiutangToolStripMenuItem"
        Me.LaporanPiutangToolStripMenuItem.Size = New System.Drawing.Size(252, 24)
        Me.LaporanPiutangToolStripMenuItem.Text = "Laporan Piutang"
        Me.LaporanPiutangToolStripMenuItem.Visible = False
        '
        'LaporanTagihanToolStripMenuItem
        '
        Me.LaporanTagihanToolStripMenuItem.Name = "LaporanTagihanToolStripMenuItem"
        Me.LaporanTagihanToolStripMenuItem.Size = New System.Drawing.Size(252, 24)
        Me.LaporanTagihanToolStripMenuItem.Text = "Laporan Tagihan"
        '
        'LaporanLabaKotorToolStripMenuItem
        '
        Me.LaporanLabaKotorToolStripMenuItem.Name = "LaporanLabaKotorToolStripMenuItem"
        Me.LaporanLabaKotorToolStripMenuItem.Size = New System.Drawing.Size(252, 24)
        Me.LaporanLabaKotorToolStripMenuItem.Text = "Laporan Laba Kotor"
        '
        'LaporanLabaRugiToolStripMenuItem
        '
        Me.LaporanLabaRugiToolStripMenuItem.Name = "LaporanLabaRugiToolStripMenuItem"
        Me.LaporanLabaRugiToolStripMenuItem.Size = New System.Drawing.Size(252, 24)
        Me.LaporanLabaRugiToolStripMenuItem.Text = "Laporan Laba Rugi"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(249, 6)
        '
        'LaporanStockAkhirTahunToolStripMenuItem
        '
        Me.LaporanStockAkhirTahunToolStripMenuItem.Name = "LaporanStockAkhirTahunToolStripMenuItem"
        Me.LaporanStockAkhirTahunToolStripMenuItem.Size = New System.Drawing.Size(252, 24)
        Me.LaporanStockAkhirTahunToolStripMenuItem.Text = "Laporan Stock Akhir Tahun"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        Me.AboutToolStripMenuItem.Visible = False
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(61, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        Me.ExitToolStripMenuItem.Visible = False
        '
        'tsBestPos
        '
        Me.tsBestPos.CanOverflow = False
        Me.tsBestPos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsBestPos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbUser, Me.tsbBarang, Me.tsbPembelian, Me.tsbPenjualan, Me.ToolStripSeparator5, Me.tsbHutang, Me.tsbPiutang, Me.ToolStripSeparator1, Me.tsbExit, Me.ToolStripSeparator2})
        Me.tsBestPos.Location = New System.Drawing.Point(0, 28)
        Me.tsBestPos.Name = "tsBestPos"
        Me.tsBestPos.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.tsBestPos.Size = New System.Drawing.Size(1282, 83)
        Me.tsBestPos.TabIndex = 6
        Me.tsBestPos.Text = "ToolStrip1"
        '
        'tsbUser
        '
        Me.tsbUser.AutoSize = False
        Me.tsbUser.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.tsbUser.Image = CType(resources.GetObject("tsbUser.Image"), System.Drawing.Image)
        Me.tsbUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbUser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbUser.Margin = New System.Windows.Forms.Padding(0, 1, 10, 2)
        Me.tsbUser.Name = "tsbUser"
        Me.tsbUser.Size = New System.Drawing.Size(120, 80)
        Me.tsbUser.Text = "User Management"
        Me.tsbUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsbUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbBarang
        '
        Me.tsbBarang.AutoSize = False
        Me.tsbBarang.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.tsbBarang.Image = CType(resources.GetObject("tsbBarang.Image"), System.Drawing.Image)
        Me.tsbBarang.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbBarang.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBarang.Name = "tsbBarang"
        Me.tsbBarang.Size = New System.Drawing.Size(120, 80)
        Me.tsbBarang.Text = "Informasi Barang"
        Me.tsbBarang.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsbBarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbPembelian
        '
        Me.tsbPembelian.AutoSize = False
        Me.tsbPembelian.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.tsbPembelian.Image = CType(resources.GetObject("tsbPembelian.Image"), System.Drawing.Image)
        Me.tsbPembelian.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbPembelian.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPembelian.Margin = New System.Windows.Forms.Padding(5, 1, 0, 2)
        Me.tsbPembelian.Name = "tsbPembelian"
        Me.tsbPembelian.Size = New System.Drawing.Size(120, 80)
        Me.tsbPembelian.Text = "Faktur Pembelian"
        Me.tsbPembelian.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsbPembelian.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbPenjualan
        '
        Me.tsbPenjualan.AutoSize = False
        Me.tsbPenjualan.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.tsbPenjualan.Image = CType(resources.GetObject("tsbPenjualan.Image"), System.Drawing.Image)
        Me.tsbPenjualan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbPenjualan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPenjualan.Margin = New System.Windows.Forms.Padding(5, 1, 0, 2)
        Me.tsbPenjualan.Name = "tsbPenjualan"
        Me.tsbPenjualan.Size = New System.Drawing.Size(120, 80)
        Me.tsbPenjualan.Text = "Faktur Penjualan"
        Me.tsbPenjualan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsbPenjualan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 83)
        '
        'tsbHutang
        '
        Me.tsbHutang.AutoSize = False
        Me.tsbHutang.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.tsbHutang.Image = CType(resources.GetObject("tsbHutang.Image"), System.Drawing.Image)
        Me.tsbHutang.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbHutang.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHutang.Margin = New System.Windows.Forms.Padding(5, 1, 0, 2)
        Me.tsbHutang.Name = "tsbHutang"
        Me.tsbHutang.Size = New System.Drawing.Size(120, 80)
        Me.tsbHutang.Text = "Hutang"
        Me.tsbHutang.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsbHutang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbPiutang
        '
        Me.tsbPiutang.AutoSize = False
        Me.tsbPiutang.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.tsbPiutang.Image = CType(resources.GetObject("tsbPiutang.Image"), System.Drawing.Image)
        Me.tsbPiutang.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbPiutang.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPiutang.Margin = New System.Windows.Forms.Padding(5, 1, 0, 2)
        Me.tsbPiutang.Name = "tsbPiutang"
        Me.tsbPiutang.Size = New System.Drawing.Size(120, 80)
        Me.tsbPiutang.Text = "Piutang"
        Me.tsbPiutang.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsbPiutang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 83)
        '
        'tsbExit
        '
        Me.tsbExit.AutoSize = False
        Me.tsbExit.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.tsbExit.Image = CType(resources.GetObject("tsbExit.Image"), System.Drawing.Image)
        Me.tsbExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExit.Name = "tsbExit"
        Me.tsbExit.Size = New System.Drawing.Size(120, 80)
        Me.tsbExit.Text = "Keluar Program"
        Me.tsbExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 83)
        '
        'TbL_UserTableAdapter
        '
        Me.TbL_UserTableAdapter.ClearBeforeFill = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 111)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.DGVNoftification)
        Me.SplitContainer2.Size = New System.Drawing.Size(1282, 442)
        Me.SplitContainer2.SplitterDistance = 891
        Me.SplitContainer2.TabIndex = 11
        Me.SplitContainer2.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.LabelCompanyName)
        Me.GroupBox1.Controls.Add(Me.TextBoxDescription)
        Me.GroupBox1.Controls.Add(Me.LabelCopyright)
        Me.GroupBox1.Controls.Add(Me.LabelVersion)
        Me.GroupBox1.Controls.Add(Me.LabelProductName)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 212)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(885, 227)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        '
        'LabelCompanyName
        '
        Me.LabelCompanyName.AutoSize = True
        Me.LabelCompanyName.Location = New System.Drawing.Point(10, 120)
        Me.LabelCompanyName.Name = "LabelCompanyName"
        Me.LabelCompanyName.Size = New System.Drawing.Size(108, 17)
        Me.LabelCompanyName.TabIndex = 1
        Me.LabelCompanyName.Text = "Company Name"
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.Location = New System.Drawing.Point(10, 150)
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.Size = New System.Drawing.Size(869, 61)
        Me.TextBoxDescription.TabIndex = 0
        Me.TextBoxDescription.Text = "Description"
        '
        'LabelCopyright
        '
        Me.LabelCopyright.AutoSize = True
        Me.LabelCopyright.Location = New System.Drawing.Point(10, 90)
        Me.LabelCopyright.Name = "LabelCopyright"
        Me.LabelCopyright.Size = New System.Drawing.Size(68, 17)
        Me.LabelCopyright.TabIndex = 0
        Me.LabelCopyright.Text = "Copyright"
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Location = New System.Drawing.Point(10, 60)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(56, 17)
        Me.LabelVersion.TabIndex = 0
        Me.LabelVersion.Text = "Version"
        '
        'LabelProductName
        '
        Me.LabelProductName.AutoSize = True
        Me.LabelProductName.Location = New System.Drawing.Point(10, 30)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(98, 17)
        Me.LabelProductName.TabIndex = 0
        Me.LabelProductName.Text = "Product Name"
        '
        'DGVNoftification
        '
        Me.DGVNoftification.AllowUserToAddRows = False
        Me.DGVNoftification.AllowUserToDeleteRows = False
        Me.DGVNoftification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVNoftification.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVNoftification.Location = New System.Drawing.Point(0, 0)
        Me.DGVNoftification.Name = "DGVNoftification"
        Me.DGVNoftification.ReadOnly = True
        Me.DGVNoftification.RowTemplate.Height = 24
        Me.DGVNoftification.Size = New System.Drawing.Size(387, 442)
        Me.DGVNoftification.TabIndex = 10
        '
        'FRM_Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1282, 553)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.tsBestPos)
        Me.Controls.Add(Me.msBestPos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FRM_Utama"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":: Best POS ::"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.msBestPos.ResumeLayout(False)
        Me.msBestPos.PerformLayout()
        Me.tsBestPos.ResumeLayout(False)
        Me.tsBestPos.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVNoftification, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msBestPos As System.Windows.Forms.MenuStrip
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsBestPos As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbUser As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbBarang As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbPembelian As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbPiutang As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbPenjualan As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbHutang As System.Windows.Forms.ToolStripButton
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FakturPembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HutangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FakturPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PiutangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistoryHargaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HargaCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HargaSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturPembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanStokBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPembelianPerTanggalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPembelianPerSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPenjualanPerPeriodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPenjualanPerCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPenjualanPerSalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanReturToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanReturPembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanReturPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanHutangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPiutangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TbL_UserTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_UserTableAdapter
    Friend WithEvents BiayaOperasionalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanLabaRugiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPenjualanSummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPenjualanCashKreditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPiutangToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanLabaKotorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanTagihanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LaporanStockAkhirTahunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RekapanLaporanPembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelCompanyName As System.Windows.Forms.Label
    Friend WithEvents TextBoxDescription As System.Windows.Forms.Label
    Friend WithEvents LabelCopyright As System.Windows.Forms.Label
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents LabelProductName As System.Windows.Forms.Label
    Friend WithEvents DGVNoftification As System.Windows.Forms.DataGridView
End Class
