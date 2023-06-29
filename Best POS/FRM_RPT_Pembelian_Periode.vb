Public Class FRM_RPT_Pembelian_Periode

    Private Sub FRM_RPT_Pembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_POS_CNDataSet.TBL_Supplier' table. You can move, or remove it, as needed.
        Me.TBL_SupplierTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Supplier)
        dtpAwal.Value = Now
        dtpAkhir.Value = Now
    End Sub

    Private Sub btnTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTampil.Click
        Dim rep As RPT_Pembelian
        rep = New RPT_Pembelian
        Dim dtstok As DataTable
        dtstok = Query_Laporan_PembelianTableAdapter.GetDataByTgl("", dtpAwal.Value, dtpAkhir.Value)
        rep.SetDataSource(dtstok)
        crvPembelian.ReportSource = rep
    End Sub
End Class