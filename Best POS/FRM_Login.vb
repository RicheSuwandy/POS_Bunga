Imports System.Data.SqlClient
Public Class FRM_Login

    Private Sub FRM_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtuser.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tutupform(Me)
    End Sub

    Private Sub txtuser_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtuser.KeyDown, txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        Dim ceklogin As Integer
        'Try
        ceklogin = CInt(TbL_UserTableAdapter.CekLogin(txtuser.Text, txtpassword.Text).Value)
        'Catch ex As Exception
        '    ceklogin = 0
        'End Try
        If ceklogin = 1 Then
            curuser = txtuser.Text
            sql = "SELECT P_Hak_Akses, P_Tambah_User, P_Hapus_User, P_Reset_Password, P_Barang, P_Faktur_Pembelian, P_Retur_Pembelian, " _
            & "P_Supplier, P_Hutang, P_Faktur_Penjualan, P_Retur_Penjualan, P_Sales, P_Customer, P_Piutang, P_Harga_Customer, P_Harga_Supplier, P_Lap_Stok_Barang, " _
            & "P_Lap_Pembelian_Per_Tanggal, P_Lap_Pembelian_Per_Supplier, P_Lap_Penjualan_Per_Tanggal, P_Lap_Penjualan_Per_Customer, P_Lap_Penjualan_Per_Sales, " _
            & "P_Lap_Retur_Pembelian, P_Lap_Retur_Penjualan, P_Lap_Hutang, P_Lap_Piutang, P_Lap_Laba_Rugi, P_Biaya_Operasional, P_Edit_Penjualan, P_Edit_Pembelian " _
            & "FROM TBL_User WHERE Username='" & curuser & "'"
            koneksi()
            cmd = New SqlCommand(sql, cn)
            reader = cmd.ExecuteReader()
            While reader.Read
                phakakses = reader(0)
                ptambahuser = reader(1)
                phapususer = reader(2)
                presetpass = reader(3)
                pbarang = reader(4)
                pfakbeli = reader(5)
                preturbeli = reader(6)
                psupplier = reader(7)
                phutang = reader(8)
                pfakjual = reader(9)
                preturjual = reader(10)
                psales = reader(11)
                pcustomer = reader(12)
                ppiutang = reader(13)
                phargacustomer = reader(14)
                phargasupplier = reader(15)
                plapstok = reader(16)
                plapbeliperiode = reader(17)
                plapbelisupplier = reader(18)
                plapjualperiode = reader(19)
                plapjualcustomer = reader(20)
                plapjualsales = reader(21)
                plapreturbeli = reader(22)
                plapreturjual = reader(23)
                plaphutang = reader(24)
                plappiutang = reader(25)
                plaplabarugi = reader(26)
                pbiayaoperasional = reader(27)
                peditpenjualan = reader(28)
                peditpembelian = reader(29)
            End While
            setvisible2(1, FRM_Utama.UserManagementToolStripMenuItem)
            setvisible(1, FRM_Utama.tsbUser)
            setvisible(phakakses, FRM_User_Management.tsHakAkses)
            setvisible(ptambahuser, FRM_User_Management.tsTambah)
            setvisible(phapususer, FRM_User_Management.tsHapus)
            setvisible(presetpass, FRM_User_Management.tsResetPass)
            setvisible(pbarang, FRM_Utama.tsbBarang)
            setvisible2(pbarang, FRM_Utama.BarangToolStripMenuItem)
            If pfakbeli = 0 And preturbeli = 0 And psupplier = 0 And phutang = 0 Then
                setvisible(0, FRM_Utama.tsbPembelian)
                setvisible2(0, FRM_Utama.PembelianToolStripMenuItem)
                setvisible(0, FRM_Utama.tsbHutang)
            Else
                setvisible2(1, FRM_Utama.PembelianToolStripMenuItem)
                setvisible(pfakbeli, FRM_Utama.tsbPembelian)
                setvisible2(pfakbeli, FRM_Utama.FakturPembelianToolStripMenuItem)
                setvisible2(preturbeli, FRM_Utama.ReturPembelianToolStripMenuItem)
                setvisible2(psupplier, FRM_Utama.SupplierToolStripMenuItem)
                setvisible2(phutang, FRM_Utama.HutangToolStripMenuItem)
                setvisible(phutang, FRM_Utama.tsbHutang)
            End If
            If pfakjual = 0 And preturjual = 0 And psales = 0 And pcustomer = 0 And ppiutang = 0 Then
                setvisible(0, FRM_Utama.tsbPenjualan)
                setvisible2(0, FRM_Utama.PenjualanToolStripMenuItem)
                setvisible(0, FRM_Utama.tsbPiutang)
            Else
                setvisible2(1, FRM_Utama.PenjualanToolStripMenuItem)
                setvisible(pfakjual, FRM_Utama.tsbPenjualan)
                setvisible2(pfakjual, FRM_Utama.FakturPenjualanToolStripMenuItem)
                setvisible2(preturjual, FRM_Utama.ReturPenjualanToolStripMenuItem)
                setvisible2(psales, FRM_Utama.SalesToolStripMenuItem)
                setvisible2(pcustomer, FRM_Utama.CustomerToolStripMenuItem)
                setvisible2(ppiutang, FRM_Utama.PiutangToolStripMenuItem)
                setvisible(ppiutang, FRM_Utama.tsbPiutang)
            End If
            If phargacustomer = 0 And phargasupplier = 0 Then
                setvisible2(0, FRM_Utama.HistoryHargaToolStripMenuItem)
            Else
                setvisible2(1, FRM_Utama.HistoryHargaToolStripMenuItem)
                setvisible2(phargacustomer, FRM_Utama.HargaCustomerToolStripMenuItem)
                setvisible2(phargasupplier, FRM_Utama.HargaSupplierToolStripMenuItem)
            End If
            setvisible2(pbiayaoperasional, FRM_Utama.BiayaOperasionalToolStripMenuItem)
            If plapstok = 0 And plapbeliperiode = 0 And plapbelisupplier = 0 And plapjualperiode = 0 And plapjualcustomer = 0 And plapjualsales = 0 And plapreturbeli = 0 And plapreturjual = 0 And plaphutang = 0 And plappiutang = 0 And plaplabarugi = 0 Then
                setvisible2(0, FRM_Utama.LaporanToolStripMenuItem)
            Else
                setvisible2(1, FRM_Utama.LaporanToolStripMenuItem)
                setvisible2(plapstok, FRM_Utama.LaporanStokBarangToolStripMenuItem)
                If plapbeliperiode = 0 And plapbelisupplier = 0 Then
                    setvisible2(0, FRM_Utama.LaporanPembelianToolStripMenuItem)
                Else
                    setvisible2(1, FRM_Utama.LaporanPembelianToolStripMenuItem)
                    setvisible2(plapbeliperiode, FRM_Utama.LaporanPembelianPerTanggalToolStripMenuItem)
                    setvisible2(plapbelisupplier, FRM_Utama.LaporanPembelianPerSupplierToolStripMenuItem)
                End If
                If plapjualperiode = 0 And plapjualcustomer = 0 And plapjualsales = 0 Then
                    setvisible2(0, FRM_Utama.LaporanPenjualanToolStripMenuItem)
                Else
                    setvisible2(1, FRM_Utama.LaporanPenjualanToolStripMenuItem)
                    setvisible2(plapjualperiode, FRM_Utama.LaporanPenjualanPerPeriodeToolStripMenuItem)
                    setvisible2(plapjualcustomer, FRM_Utama.LaporanPenjualanPerCustomerToolStripMenuItem)
                    setvisible2(plapjualsales, FRM_Utama.LaporanPenjualanPerSalesToolStripMenuItem)
                End If
                If plapreturbeli = 0 And plapreturjual = 0 Then
                    setvisible2(0, FRM_Utama.LaporanReturToolStripMenuItem)
                Else
                    setvisible2(1, FRM_Utama.LaporanReturToolStripMenuItem)
                    setvisible2(plapreturbeli, FRM_Utama.LaporanReturPembelianToolStripMenuItem)
                    setvisible2(plapreturjual, FRM_Utama.LaporanReturPenjualanToolStripMenuItem)
                End If
                setvisible2(plaphutang, FRM_Utama.LaporanHutangToolStripMenuItem)
                setvisible2(plappiutang, FRM_Utama.LaporanPiutangToolStripMenuItem)
                setvisible2(plaplabarugi, FRM_Utama.LaporanLabaRugiToolStripMenuItem)
            End If
            FRM_Utama.LoginToolStripMenuItem.Visible = False
            FRM_Utama.LogoutToolStripMenuItem.Visible = True
            txtuser.Clear()
            txtpassword.Clear()
            Me.Close()
            Me.Dispose()
        Else
            MessageBox.Show("Username atau password salah", "Error", MessageBoxButtons.OK)
            txtuser.Clear()
            txtpassword.Clear()
            txtuser.Focus()
        End If
    End Sub
End Class