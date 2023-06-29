Imports System.Data.SqlClient
Module Module1
    Public curuser As String = ""
    Public phakakses, ptambahuser, phapususer, presetpass, pbarang, pfakbeli, preturbeli, psupplier, phutang, pfakjual, preturjual, psales, pcustomer, ppiutang, phargacustomer, phargasupplier, plapstok, plapbeliperiode, plapbelisupplier, plapjualperiode, plapjualcustomer, plapjualsales, plapreturbeli, plapreturjual, plaphutang, plappiutang, plaplabarugi, pbiayaoperasional, peditpenjualan, peditpembelian As Integer
    Public jenispmbbeli As String
    Public pmbbeli As Double
    Public sisapmbbeli As Double
    Public jenispmbjual As String
    Public pmbjual As Double
    Public sisapmbjual As Double
    Public cn As SqlConnection
    Public cnstr As String
    Public sql As String
    Public cmd As SqlCommand
    Public reader As SqlDataReader
    Public Sub setnol(ByRef kotakteks As C1.Win.C1Input.C1TextBox)
        kotakteks.ReadOnly = False
        kotakteks.Text = 0
        kotakteks.ReadOnly = True
    End Sub
    Public Sub setteks(ByRef kotakteks As C1.Win.C1Input.C1TextBox, ByVal angka As String)
        kotakteks.ReadOnly = False
        kotakteks.Text = angka
        kotakteks.ReadOnly = True
    End Sub
    Public Sub koneksi()
        Try
            cnstr = My.Settings.db_POS_CNConnectionString
            cn = New SqlConnection(cnstr)
            cn.Open()
        Catch ex As Exception
            MessageBox.Show("Koneksi ke database gagal", "Error")
        End Try
    End Sub
    Public Sub tutupform(ByVal myform As Form)
        myform.Close()
        myform.Dispose()
    End Sub
    Public Sub tutupsemuaform()
        tutupform(FRM_Barang)
        tutupform(FRM_Alokasi_Barang_Pembelian)
        tutupform(FRM_Alokasi_Barang_Penjualan)
        tutupform(FRM_Gudang)
        tutupform(FRM_Customer)
        tutupform(FRM_Hak_Akses)
        tutupform(FRM_Harga_Customer)
        tutupform(FRM_Harga_Supplier)
        tutupform(FRM_Hutang)
        'tutupform(txtNoBon)
        tutupform(FRM_Kredit_Pembelian)
        tutupform(FRM_Kredit_Penjualan)
        tutupform(FRM_RPT_Faktur_Pembelian)
        tutupform(FRM_RPT_Pembelian_Rekapan)
        tutupform(FRM_RPT_Pembelian_Supplier)
        tutupform(FRM_Edit_Item_Pembelian)
        tutupform(FRM_Edit_Item_Penjualan)
        tutupform(FRM_Edit_Retur_Pembelian)
        tutupform(FRM_Edit_Retur_Penjualan)
        tutupform(FRM_Pembelian)
        tutupform(FRM_Penjualan)
        tutupform(FRM_RPT_Penjualan_Customer)
        tutupform(FRM_RPT_Penjualan_Periode)
        tutupform(FRM_RPT_Penjualan_Sales)
        tutupform(FRM_Reset_Password)
        tutupform(FRM_Retur_Pembelian)
        tutupform(FRM_Retur_Penjualan)
        tutupform(FRM_RPT_Retur_Beli_Periode)
        tutupform(FRM_RPT_Retur_Jual_Periode)
        tutupform(FRM_RPT_Barang)
        tutupform(FRM_RPT_Hutang)
        tutupform(FRM_RPT_Piutang)
        tutupform(FRM_Sales)
        tutupform(FRM_Supplier)
        tutupform(FRM_Tambah_User)
        tutupform(FRM_Ubah_Password)
        tutupform(FRM_User_Management)
        'tutupform(FRM_Biaya)
        tutupform(FRM_RPT_Laba_Rugi)
        tutupform(AboutBox1)
    End Sub
    Public Sub logout()
        FRM_Utama.LogoutToolStripMenuItem.Visible = False
        FRM_Utama.LoginToolStripMenuItem.Visible = True
        FRM_Utama.UserManagementToolStripMenuItem.Visible = False
        FRM_Utama.BarangToolStripMenuItem.Visible = False
        FRM_Utama.PembelianToolStripMenuItem.Visible = False
        FRM_Utama.PenjualanToolStripMenuItem.Visible = False
        FRM_Utama.HistoryHargaToolStripMenuItem.Visible = False
        FRM_Utama.LaporanToolStripMenuItem.Visible = False
        FRM_Utama.BiayaOperasionalToolStripMenuItem.Visible = False
        FRM_Utama.tsbUser.Visible = False
        FRM_Utama.tsbBarang.Visible = False
        FRM_Utama.tsbPembelian.Visible = False
        FRM_Utama.tsbPenjualan.Visible = False
        FRM_Utama.tsbHutang.Visible = False
        FRM_Utama.tsbPiutang.Visible = False
    End Sub
    Public Sub setvisible(ByVal nilai As Integer, ByVal mycontrol As ToolStripButton)
        If nilai = 1 Then
            mycontrol.Visible = True
        Else
            mycontrol.Visible = False
        End If
    End Sub
    Public Sub setvisible2(ByVal nilai As Integer, ByVal mycontrol As ToolStripMenuItem)
        If nilai = 1 Then
            mycontrol.Visible = True
        Else
            mycontrol.Visible = False
        End If
    End Sub
    Function Terbilang(ByVal myNum As Double) As String
        Dim myString As String() = {"", "satu", "dua", "tiga", "empat", "lima", "enam", "tujuh", "delapan", "sembilan", "sepuluh", "sebelas"}
        Dim myTmpString As String = ""
        Select Case myNum
            Case Is < 12
                myTmpString = myString(myNum)
            Case Is < 20
                myTmpString = Terbilang(myNum - 10) + " " + "belas"
            Case Is < 100
                If Microsoft.VisualBasic.Right(myNum, 1) > 0 Then
                    myTmpString = Terbilang(Int(myNum / 10)) + " " + "puluh" + " " + Terbilang(myNum Mod 10)
                Else
                    myTmpString = Terbilang(Int(myNum / 10)) + " " + "puluh"
                End If
            Case Is < 200
                myTmpString = "seratus" + " " + Terbilang(myNum - 100)
            Case Is < 1000
                myTmpString = Terbilang(Int(myNum / 100)) + " " + "ratus" + " " + Terbilang(myNum Mod 100)
            Case Is < 2000
                myTmpString = "seribu" + " " + Terbilang(myNum - 1000)
            Case Is < 1000000
                myTmpString = Terbilang(Int(myNum / 1000)) + " " + "ribu" + " " + Terbilang(myNum Mod 1000)
            Case Is < 1000000000
                myTmpString = Terbilang(Int(myNum / 1000000)) + " " + "juta" + " " + Terbilang(myNum Mod 1000000)
            Case Is < 1000000000000
                myTmpString = Terbilang(Int(myNum / 1000000000)) + " " + "milyar" + " " + Terbilang(myNum Mod 1000000000)
            Case Is < 1000000000000000
                myTmpString = Terbilang(Int(myNum / 1000000000000)) + " " + "trilyun" + " " + Terbilang(myNum Mod 1000000000000)
        End Select
        Return myTmpString
    End Function
End Module
