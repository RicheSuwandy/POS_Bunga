Public Class FRM_Biaya

    Private Sub FRM_Biaya_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TbL_RPT_Laba_RugiTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_RPT_Laba_Rugi)
        Dim banyakdata As Integer
        Try
            banyakdata = TbL_RPT_Laba_RugiTableAdapter.BanyakData()
        Catch ex As Exception
            banyakdata = 0
        End Try
        If banyakdata = 0 Then
            TbL_RPT_Laba_RugiTableAdapter.InsertQuery(0, 0, 0, 0, 0, 0, 0)
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Me.TbL_RPT_Laba_RugiTableAdapter.UpdateBiaya(txtBiayaOperasional.Text, txtGajiKaryawan.Text, txtBiayaLain2.Text)
            MessageBox.Show("Data berhasil disimpan ke database", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Data gagal disimpan ke database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        tutupform(Me)
    End Sub
End Class