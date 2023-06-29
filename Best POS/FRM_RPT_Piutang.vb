Public Class FRM_RPT_Piutang

    Private Sub FRM_RPT_Pembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpAwal.Value = Now
        dtpAkhir.Value = Now
    End Sub

    Private Sub btnTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTampil.Click
        If cboStatus.Text = "BL" Or cboStatus.Text = "L" Then
            Dim rep As RPT_Piutang
            rep = New RPT_Piutang
            Dim dtstok As DataTable
            dtstok = Query_Laporan_PiutangTableAdapter.GetDataByTglTagihStatus(dtpAwal.Value, dtpAkhir.Value, cboStatus.Text)
            rep.SetDataSource(dtstok)
            crvPembelian.ReportSource = rep
        Else
            MessageBox.Show("Harap masukkan status BL atau L", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class