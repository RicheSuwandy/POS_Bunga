Public Class FRM_RPTLabaKotor
    Private Sub btnTampil_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTampil.Click
        Dim rep As RPT_LabaKotor
        rep = New RPT_LabaKotor
        Dim dtstok As DataTable
        dtstok = VwRptLabaKotorTableAdapter.GetData(dtpAwal.Value, dtpAkhir.Value, cboCustomer.Text)
        rep.DataDefinition.FormulaFields("Header").Text = "'" & "Laporan Laba Kotor Tanggal " & dtpAwal.Value.ToString("dd-MMM-yy") & " s.d " & dtpAkhir.Value.ToString("dd-MMM-yy") & " Penjualan " & cboCustomer.Text & "'"
        rep.SetDataSource(dtstok)
        crvPembelian.ReportSource = rep
    End Sub
End Class