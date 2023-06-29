Public Class FRM_RPTStockAkhirTahun

    Private Sub FRM_RPTStockAkhirTahun_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rep As RPT_StockAkhirTahun
        rep = New RPT_StockAkhirTahun
        Dim dtstok As DataTable
        dtstok = RptStockAkhirTahun.GetData()
        rep.DataDefinition.FormulaFields("Header").Text = "'" & "STOCK AKHIR TAHUN " & Now.ToString("yyyy") & "'"
        rep.SetDataSource(dtstok)
        crvPembelian.ReportSource = rep
    End Sub
End Class