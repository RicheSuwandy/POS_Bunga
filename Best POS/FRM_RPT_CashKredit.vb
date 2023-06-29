Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FRM_RPT_CashKredit

    Private Sub btnTampil_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTampil.Click
        Dim rep As RPT_CashKredit
        rep = New RPT_CashKredit
        Dim dtstok As DataTable
        dtstok = VwRptCashKreditTableAdapter.GetData(cboCustomer.Text, dtpAwal.Value, dtpAkhir.Value)
        rep.DataDefinition.FormulaFields("Header").Text = "'" & "Laporan Penjualan " & cboCustomer.Text & " Tanggal " & dtpAwal.Value.ToString("dd-MMM-yy") & " s.d " & dtpAkhir.Value.ToString("dd-MMM-yy") & "'"
        rep.SetDataSource(dtstok)
        crvPembelian.ReportSource = rep
    End Sub

    Private Sub FRM_RPT_CashKredit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpAwal.Value = Now
        dtpAkhir.Value = Now
    End Sub
End Class