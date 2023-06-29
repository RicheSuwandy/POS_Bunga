Public Class FRM_RPT_Faktur_Pembelian

    Private Sub FRM_RPT_Faktur_Pembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rep As RPT_Faktur_Pembelian
        rep = New RPT_Faktur_Pembelian
        Dim dtstok As DataTable
        dtstok = Query_Laporan_PembelianTableAdapter.GetDataByKodePembelian(Terbilang(FRM_Pembelian.txtTotalHarga.Text) & " rupiah", FRM_Pembelian.txtKodePembelian.Text)
        rep.SetDataSource(dtstok)
        crvPembelian.ReportSource = rep
    End Sub
End Class