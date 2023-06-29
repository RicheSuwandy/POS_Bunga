Public Class FRM_RPT_Faktur_Penjualan

    Private Sub FRM_RPT_Faktur_Pembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rep As RPT_Faktur_Penjualan
        rep = New RPT_Faktur_Penjualan
        Dim dtstok As DataTable
        dtstok = Query_Laporan_PenjualanTableAdapter.GetDataByKodePenjualan(Terbilang(FRM_Penjualan.txtTotalHarga.Text) & " rupiah", FRM_Penjualan.txtKodePenjualan.Text)
        rep.SetDataSource(dtstok)
        crvPembelian.ReportSource = rep
    End Sub
End Class