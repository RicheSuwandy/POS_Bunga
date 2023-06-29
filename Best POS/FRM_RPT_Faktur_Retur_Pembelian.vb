Public Class FRM_RPT_Faktur_Retur_Pembelian

    Private Sub FRM_RPT_Faktur_Pembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rep As RPT_Faktur_Retur_Pembelian
        rep = New RPT_Faktur_Retur_Pembelian
        Dim dtstok As DataTable
        dtstok = Query_Laporan_Retur_PembelianTableAdapter.GetDataByKodeRetur(FRM_Retur_Pembelian.txtKodeRetur.Text)
        rep.SetDataSource(dtstok)
        crvPembelian.ReportSource = rep
    End Sub
End Class