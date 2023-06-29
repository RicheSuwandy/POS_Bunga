Public Class FRM_RPT_Penjualan_Customer

    Private Sub FRM_RPT_Pembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_POS_CNDataSet.TBL_Customer' table. You can move, or remove it, as needed.
        Me.TBL_CustomerTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Customer)
        'TODO: This line of code loads data into the 'Db_POS_CNDataSet.TBL_Supplier' table. You can move, or remove it, as needed.
        dtpAwal.Value = Now
        dtpAkhir.Value = Now
    End Sub

    Private Sub btnTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTampil.Click
        Dim rep As RPT_Penjualan
        rep = New RPT_Penjualan
        Dim dtstok As DataTable
        dtstok = Query_Laporan_PenjualanTableAdapter.GetDataByKodeCustomer("", dtpAwal.Value, dtpAkhir.Value, cboCustomer.SelectedValue)
        rep.SetDataSource(dtstok)
        crvPembelian.ReportSource = rep
    End Sub
End Class