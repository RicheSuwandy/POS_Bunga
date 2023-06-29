Public Class FRM_RPT_Barang

    Private Sub FRM_RPT_Barang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rep As RPT_Barang_Detail
        rep = New RPT_Barang_Detail
        Dim dtstok As DataTable
        dtstok = QueryLaporanBarangTableAdapter.GetData()
        rep.SetDataSource(dtstok)
        crvBarang.ReportSource = rep
    End Sub
End Class