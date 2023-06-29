Public Class FRM_RPT_Penjualan_Sales

    Private Sub FRM_RPT_Pembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TBL_SalesTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Sales)
        dtpAwal.Value = Now
        dtpAkhir.Value = Now
    End Sub

    Private Sub btnTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTampil.Click
        Dim rep As RPT_Penjualan
        rep = New RPT_Penjualan
        Dim dtstok As DataTable
        dtstok = Query_Laporan_PenjualanTableAdapter.GetDataByKodeSales("", dtpAwal.Value, dtpAkhir.Value, cboSales.SelectedValue)
        rep.SetDataSource(dtstok)
        crvPembelian.ReportSource = rep
    End Sub
End Class