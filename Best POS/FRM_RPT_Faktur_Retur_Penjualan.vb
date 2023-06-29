Public Class FRM_RPT_Faktur_Retur_Penjualan

    Private Sub FRM_RPT_Faktur_Pembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rep As RPT_Faktur_Retur_Penjualan
        rep = New RPT_Faktur_Retur_Penjualan
        Dim dtstok As DataTable
        dtstok = Query_Laporan_Retur_PenjualanTableAdapter.GetDataByKodeRetur(FRM_Retur_Penjualan.txtKodeRetur.Text)
        rep.SetDataSource(dtstok)
        crvPembelian.ReportSource = rep
    End Sub
End Class