Public Class FRM_RPTTagihan

    Private Sub btnTampil_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTampil.Click
        Dim rep As RPT_Tagihan
        rep = New RPT_Tagihan
        Dim dtstok As DataTable
        dtstok = VwRptTagihanTableAdapter.GetData(dtpAwal.Value, dtpAkhir.Value)
        rep.DataDefinition.FormulaFields("Header").Text = "'" & "Laporan Tagihab Tanggal " & dtpAwal.Value.ToString("dd-MMM-yy") & " s.d " & dtpAkhir.Value.ToString("dd-MMM-yy") & "'"
        rep.SetDataSource(dtstok)
        crvPembelian.ReportSource = rep
    End Sub

    Private Sub FRM_RPTTagihan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpAwal.Value = Now
        dtpAkhir.Value = Now
    End Sub
End Class