Public Class FRM_Hak_Akses

    Private Sub FRM_Hak_Akses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_POS_CNDataSet.TBL_User' table. You can move, or remove it, as needed.
        Me.TBL_UserTableAdapter.FillByUsername(Me.Db_POS_CNDataSet.TBL_User, lblUser.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tutupform(Me)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            TBL_UserTableAdapter.UpdatePriviledge(chkTambahUser.CheckState, chkHapusUser.CheckState, chkResetPassword.CheckState, chkBarang.CheckState, chkFakturBeli.CheckState, chkReturBeli.CheckState, chkSupplier.CheckState, chkHutang.CheckState, chkFakturJual.CheckState, chkReturJual.CheckState, chkSales.CheckState, chkCustomer.CheckState, chkPiutang.CheckState, chkHargaCustomer.CheckState, chkHargaSupplier.CheckState, chkLapBarang.CheckState, chkLapBeliPeriode.CheckState, chkLapBeliSupplier.CheckState, chkLapJualPeriode.CheckState, chkLapJualCustomer.CheckState, chkLapJualSales.CheckState, chkLapReturBeli.CheckState, chkLapReturJual.CheckState, chkLapHutang.CheckState, chkLapPiutang.CheckState, chkHakAkses.CheckState, chkLapLabaRugi.CheckState, chkBiayaOperasional.CheckState, chkEditFakturJual.CheckState, chkEditFakturBeli.CheckState, lblUser.Text)
            MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Data gagal disimpan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class