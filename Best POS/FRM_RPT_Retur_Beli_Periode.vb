Public Class FRM_RPT_Retur_Beli_Periode

    Private Sub FRM_RPT_Pembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpAwal.Value = Now
        dtpAkhir.Value = Now
    End Sub

    Private Sub btnTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTampil.Click
        Dim rep As RPT_Retur_Beli
        rep = New RPT_Retur_Beli
        Dim dtstok As DataTable
        dtstok = Query_Laporan_Retur_PembelianTableAdapter.GetDataByTanggal(dtpAwal.Value, dtpAkhir.Value)
        rep.SetDataSource(dtstok)
        crvPembelian.ReportSource = rep
    End Sub
End Class