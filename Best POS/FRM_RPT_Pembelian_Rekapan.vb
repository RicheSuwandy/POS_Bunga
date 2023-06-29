Public Class FRM_RPT_Pembelian_Rekapan

    Private Sub FRM_RPT_Pembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_POS_CNDataSet.TBL_Supplier' table. You can move, or remove it, as needed.
        'Me.TBL_SupplierTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Supplier)
        dtpAwal.Value = Format(Now, "yyyy-MM-dd")
        dtpAkhir.Value = Format(Now, "yyyy-MM-dd")
    End Sub

    Private Sub btnTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTampil.Click
        Dim rep As rptPembelianRekapan
        rep = New rptPembelianRekapan
        Dim dtstok As DataTable
        dtstok = Query_Rekapan_PembelianTableAdapter.GetData(CDate(Format(dtpAwal.Value, "yyyy-MM-dd")), CDate(Format(dtpAkhir.Value, "yyyy-MM-dd")))
        rep.SetDataSource(dtstok)
        crvPembelian.ReportSource = rep
    End Sub
End Class