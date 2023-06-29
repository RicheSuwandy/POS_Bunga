Public Class FRM_RPT_Laba_Rugi

    Private Sub FRM_RPT_Laba_Rugi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpAwal.Value = Now
        dtpAkhir.Value = Now
    End Sub

    Private Sub btnTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTampil.Click
        Dim totalbeli As Long
        Dim totaljual As Long
        Dim returbeli As Long
        Dim returjual As Long
        Try
            totalbeli = TbL_Pembelian_HeaderTableAdapter.TotalHargaPerTanggal(dtpAwal.Value, dtpAkhir.Value)
        Catch ex As Exception
            totalbeli = 0
        End Try
        Try
            totaljual = TbL_Penjualan_HeaderTableAdapter.TotalHargaPerPeriode(dtpAwal.Value, dtpAkhir.Value)
        Catch ex As Exception
            totaljual = 0
        End Try
        Try
            returbeli = TbL_Retur_Pembelian_HeaderTableAdapter.TotalHargaPerPeriode(dtpAwal.Value, dtpAkhir.Value)
        Catch ex As Exception
            returbeli = 0
        End Try
        Try
            returjual = TbL_Retur_Penjualan_HeaderTableAdapter.TotalHargaPerPeriode(dtpAwal.Value, dtpAkhir.Value)
        Catch ex As Exception
            returjual = 0
        End Try
        TbL_RPT_Laba_RugiTableAdapter.UpdateTotal(totalbeli, returbeli, totaljual, returjual)
        Dim rep As RPT_Laba_Rugi
        rep = New RPT_Laba_Rugi
        Dim dtstok As DataTable = TbL_RPT_Laba_RugiTableAdapter.GetData()
        rep.SetDataSource(dtstok)
        crvPembelian.ReportSource = rep
    End Sub
End Class