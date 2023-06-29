Public Class FRM_Utama

    Private Sub BarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangToolStripMenuItem.Click, tsbBarang.Click
        FRM_Barang.MdiParent = Me
        FRM_Barang.Show()
        FRM_Barang.AutoSize = True
        FRM_Barang.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_Barang.BringToFront()
    End Sub

    Private Sub tsbPembelian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPembelian.Click, FakturPembelianToolStripMenuItem.Click
        FRM_Pembelian.MdiParent = Me
        FRM_Pembelian.Show()
        FRM_Pembelian.AutoSize = True
        FRM_Pembelian.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_Pembelian.BringToFront()
    End Sub

    Private Sub tsbPenjualan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPenjualan.Click, FakturPenjualanToolStripMenuItem.Click
        FRM_Penjualan.MdiParent = Me
        FRM_Penjualan.Show()
        'FRM_Penjualan.AutoSize = True
        'FRM_Penjualan.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_Penjualan.BringToFront()
    End Sub

    Private Sub tsbHutang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbHutang.Click, HutangToolStripMenuItem.Click
        FRM_Hutang.MdiParent = Me
        FRM_Hutang.Show()
        FRM_Hutang.AutoSize = True
        FRM_Hutang.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_Hutang.BringToFront()
    End Sub

    Private Sub tsbPiutang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPiutang.Click, PiutangToolStripMenuItem.Click
        FRM_PIUTANG.MdiParent = Me
        FRM_PIUTANG.Show()
        FRM_PIUTANG.AutoSize = True
        FRM_PIUTANG.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_Piutang.BringToFront()
    End Sub

    Private Sub tsbExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExit.Click, ExitToolStripMenuItem.Click
        MessageBox.Show("Backup lah database secara berkala", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Application.Exit()
    End Sub

    Private Sub FRM_Utama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Dim cekkosong As Integer
        Try
            cekkosong = TbL_UserTableAdapter.CekKosong
        Catch ex As Exception
            cekkosong = 0
        End Try
        If cekkosong = 0 Then
            TbL_UserTableAdapter.InsertQuery("Admin", "Admin")
            TbL_UserTableAdapter.UpdatePriviledge(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, "Admin")
        End If
        logout()
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Me.TextBoxDescription.Text = My.Application.Info.Description
        FRM_Login.ShowDialog()
    End Sub

    Private Sub FRM_Utama_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F12 Then
            If tsBestPos.Visible = False Then
                tsBestPos.Visible = True
            Else
                tsBestPos.Visible = False
            End If
        ElseIf e.KeyCode = Keys.F11 Then
            FRM_Akses_Recalculate.ShowDialog()
        End If
    End Sub

    Private Sub ReturPembelianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturPembelianToolStripMenuItem.Click
        FRM_Retur_Pembelian.MdiParent = Me
        FRM_Retur_Pembelian.Show()
        FRM_Retur_Pembelian.AutoSize = True
        FRM_Retur_Pembelian.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_Retur_Pembelian.BringToFront()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierToolStripMenuItem.Click
        FRM_Supplier.MdiParent = Me
        FRM_Supplier.Show()
        FRM_Supplier.AutoSize = True
        FRM_Supplier.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_Supplier.BringToFront()
    End Sub

    Private Sub ReturPenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturPenjualanToolStripMenuItem.Click
        FRM_Retur_Penjualan.MdiParent = Me
        FRM_Retur_Penjualan.Show()
        FRM_Retur_Penjualan.AutoSize = True
        FRM_Retur_Penjualan.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_Retur_Penjualan.BringToFront()
    End Sub

    Private Sub SalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesToolStripMenuItem.Click
        FRM_Sales.MdiParent = Me
        FRM_Sales.Show()
        FRM_Sales.AutoSize = True
        FRM_Sales.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_Sales.BringToFront()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        FRM_Customer.MdiParent = Me
        FRM_Customer.Show()
        FRM_Customer.AutoSize = True
        FRM_Customer.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_Customer.BringToFront()
    End Sub

    Private Sub LaporanStokBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanStokBarangToolStripMenuItem.Click
        FRM_RPT_Barang.MdiParent = Me
        FRM_RPT_Barang.Show()
        FRM_RPT_Barang.AutoSize = True
        FRM_RPT_Barang.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_RPT_Barang.BringToFront()
    End Sub

    Private Sub HargaCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HargaCustomerToolStripMenuItem.Click
        FRM_Harga_Customer.MdiParent = Me
        FRM_Harga_Customer.Show()
        FRM_Harga_Customer.AutoSize = True
        FRM_Harga_Customer.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_Harga_Supplier.BringToFront()
    End Sub

    Private Sub HargaSupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HargaSupplierToolStripMenuItem.Click
        FRM_Harga_Supplier.MdiParent = Me
        FRM_Harga_Supplier.Show()
        FRM_Harga_Supplier.AutoSize = True
        FRM_Harga_Supplier.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_Harga_Supplier.BringToFront()
    End Sub

    Private Sub tsbUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbUser.Click, UserManagementToolStripMenuItem.Click
        FRM_User_Management.MdiParent = Me
        FRM_User_Management.Show()
        FRM_User_Management.AutoSize = True
        FRM_User_Management.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_User_Management.BringToFront()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        tutupsemuaform()
        logout()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        FRM_Login.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub LaporanPembelianPerTanggalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPembelianPerTanggalToolStripMenuItem.Click
        FRM_RPT_Pembelian_Periode.MdiParent = Me
        FRM_RPT_Pembelian_Periode.Show()
        FRM_RPT_Pembelian_Periode.AutoSize = True
        FRM_RPT_Pembelian_Periode.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_RPT_Pembelian_Periode.BringToFront()
    End Sub

    Private Sub LaporanPembelianPerSupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPembelianPerSupplierToolStripMenuItem.Click
        FRM_RPT_Pembelian_Supplier.MdiParent = Me
        FRM_RPT_Pembelian_Supplier.Show()
        FRM_RPT_Pembelian_Supplier.AutoSize = True
        FRM_RPT_Pembelian_Supplier.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_RPT_Pembelian_Supplier.BringToFront()
    End Sub

    Private Sub LaporanPenjualanPerPeriodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPenjualanPerPeriodeToolStripMenuItem.Click
        FRM_RPT_Penjualan_Periode.MdiParent = Me
        FRM_RPT_Penjualan_Periode.Show()
        FRM_RPT_Penjualan_Periode.AutoSize = True
        FRM_RPT_Penjualan_Periode.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_RPT_Penjualan_Periode.BringToFront()
    End Sub

    Private Sub LaporanPenjualanPerCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPenjualanPerCustomerToolStripMenuItem.Click
        FRM_RPT_Penjualan_Customer.MdiParent = Me
        FRM_RPT_Penjualan_Customer.Show()
        FRM_RPT_Penjualan_Customer.AutoSize = True
        FRM_RPT_Penjualan_Customer.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_RPT_Penjualan_Customer.BringToFront()
    End Sub

    Private Sub LaporanPenjualanPerSalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPenjualanPerSalesToolStripMenuItem.Click
        FRM_RPT_Penjualan_Sales.MdiParent = Me
        FRM_RPT_Penjualan_Sales.Show()
        FRM_RPT_Penjualan_Sales.AutoSize = True
        FRM_RPT_Penjualan_Sales.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_RPT_Penjualan_Sales.BringToFront()
    End Sub

    Private Sub LaporanReturPembelianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanReturPembelianToolStripMenuItem.Click
        FRM_RPT_Retur_Beli_Periode.MdiParent = Me
        FRM_RPT_Retur_Beli_Periode.Show()
        FRM_RPT_Retur_Beli_Periode.AutoSize = True
        FRM_RPT_Retur_Beli_Periode.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_RPT_Retur_Beli_Periode.BringToFront()
    End Sub

    Private Sub LaporanReturPenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanReturPenjualanToolStripMenuItem.Click
        FRM_RPT_Retur_Jual_Periode.MdiParent = Me
        FRM_RPT_Retur_Jual_Periode.Show()
        FRM_RPT_Retur_Jual_Periode.AutoSize = True
        FRM_RPT_Retur_Jual_Periode.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_RPT_Retur_Jual_Periode.BringToFront()
    End Sub

    Private Sub LaporanHutangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanHutangToolStripMenuItem.Click
        FRM_RPT_Hutang.MdiParent = Me
        FRM_RPT_Hutang.Show()
        FRM_RPT_Hutang.AutoSize = True
        FRM_RPT_Hutang.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_RPT_Hutang.BringToFront()
    End Sub

    Private Sub LaporanPiutangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPiutangToolStripMenuItem.Click
        FRM_RPT_Piutang.MdiParent = Me
        FRM_RPT_Piutang.Show()
        FRM_RPT_Piutang.AutoSize = True
        FRM_RPT_Piutang.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_RPT_Piutang.BringToFront()
    End Sub

    Private Sub BiayaOperasionalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BiayaOperasionalToolStripMenuItem.Click
        'FRM_Biaya.MdiParent = Me
        'FRM_Biaya.Show()
        'FRM_Biaya.AutoSize = True
        'FRM_Biaya.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        'FRM_Biaya.BringToFront()
    End Sub

    Private Sub LaporanLabaRugiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanLabaRugiToolStripMenuItem.Click
        FRM_RPT_Laba_Rugi.MdiParent = Me
        FRM_RPT_Laba_Rugi.Show()
        FRM_RPT_Laba_Rugi.AutoSize = True
        FRM_RPT_Laba_Rugi.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_RPT_Laba_Rugi.BringToFront()
    End Sub

    Private Sub LaporanPenjualanCashKreditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPenjualanCashKreditToolStripMenuItem.Click
        FRM_RPT_CashKredit.MdiParent = Me
        FRM_RPT_CashKredit.Show()
        FRM_RPT_CashKredit.AutoSize = True
        FRM_RPT_CashKredit.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_RPT_CashKredit.BringToFront()
    End Sub

    Private Sub LaporanPiutangToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPiutangToolStripMenuItem1.Click
        FRM_RPTHistoryPiutang.MdiParent = Me
        FRM_RPTHistoryPiutang.Show()
        FRM_RPTHistoryPiutang.AutoSize = True
        FRM_RPTHistoryPiutang.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_RPTHistoryPiutang.BringToFront()
    End Sub

    Private Sub LaporanLabaKotorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanLabaKotorToolStripMenuItem.Click
        FRM_RPTLabaKotor.MdiParent = Me
        FRM_RPTLabaKotor.Show()
        FRM_RPTLabaKotor.AutoSize = True
        FRM_RPTLabaKotor.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_RPTLabaKotor.BringToFront()
    End Sub

    Private Sub LaporanTagihanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanTagihanToolStripMenuItem.Click
        FRM_RPTTagihan.MdiParent = Me
        FRM_RPTTagihan.Show()
        FRM_RPTTagihan.AutoSize = True
        FRM_RPTTagihan.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_RPTTagihan.BringToFront()
    End Sub

    Private Sub LaporanStockAkhirTahunToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanStockAkhirTahunToolStripMenuItem.Click
        FRM_RPTStockAkhirTahun.MdiParent = Me
        FRM_RPTStockAkhirTahun.Show()
        FRM_RPTStockAkhirTahun.AutoSize = True
        FRM_RPTStockAkhirTahun.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_RPTStockAkhirTahun.BringToFront()
    End Sub

    Private Sub RekapanLaporanPembelianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RekapanLaporanPembelianToolStripMenuItem.Click
        FRM_RPT_Pembelian_Rekapan.MdiParent = Me
        FRM_RPT_Pembelian_Rekapan.Show()
        FRM_RPT_Pembelian_Rekapan.AutoSize = True
        FRM_RPT_Pembelian_Rekapan.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        FRM_RPT_Pembelian_Rekapan.BringToFront()

    End Sub
End Class