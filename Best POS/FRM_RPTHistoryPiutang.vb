Public Class FRM_RPTHistoryPiutang

    Private Sub btnTampil_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTampil.Click
        Dim rep As RPT_HistoryPiutang
        rep = New RPT_HistoryPiutang
        Dim dtstok As DataTable
        dtstok = VwRptHistoryPiutangTableAdapter.GetData(dtpAwal.Value, dtpAkhir.Value)
        rep.DataDefinition.FormulaFields("Header").Text = "'" & "Laporan Piutang Customer Tanggal " & dtpAwal.Value.ToString("dd-MMM-yy") & " s.d " & dtpAkhir.Value.ToString("dd-MMM-yy") & "'"
        rep.SetDataSource(dtstok)
        crvPembelian.ReportSource = rep
    End Sub

    Private Sub FRM_RPTHistoryPiutang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpAwal.Value = Now
        dtpAkhir.Value = Now
    End Sub
End Class