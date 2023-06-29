Public Class FRM_Supplier
    Dim status As String = "update"
    Private Sub FRM_Supplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_POS_CNDataSet.TBL_Supplier' table. You can move, or remove it, as needed.
        Me.TBL_SupplierTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Supplier)
        txtKodeSup.ReadOnly = True
    End Sub

    Private Sub tsTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsTambah.Click
        TBLSupplierBindingSource.AddNew()
        BindingNavigatorPositionItem.Enabled = False
        BindingNavigatorMovePreviousItem.Enabled = False
        BindingNavigatorMoveFirstItem.Enabled = False
        tsTambah.Enabled = False
        tsHapus.Enabled = False
        tsRefresh.Text = "&Batal"
        Try
            Dim kodesupplier As Integer = CInt(TBL_SupplierTableAdapter.KodeSupplierBaru)
            If kodesupplier = 0 Then kodesupplier = 1
            txtKodeSup.Text = "SPL-" & kodesupplier.ToString("000000")
        Catch ex As Exception
            txtKodeSup.Text = "SPL-000001"
        End Try
        txtNamaSup.Focus()
        status = "simpan"
    End Sub

    Private Sub tsSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSimpan.Click
        If txtKodeSup.Text = "" Or txtNamaSup.Text = "" Then
            MessageBox.Show("Kolom bertanda * wajib diisi", "Error!", MessageBoxButtons.OK)
            txtNamaSup.Focus()
        Else
            BindingNavigatorPositionItem.Enabled = True
            BindingNavigatorMovePreviousItem.Enabled = True
            BindingNavigatorMoveFirstItem.Enabled = True
            If status = "simpan" Then
                TBL_SupplierTableAdapter.InsertQuery(txtKodeSup.Text, txtNamaSup.Text, txtAlamat.Text, txtKota.Text, txtTelepon.Text, txtHP.Text, txtFax.Text)
                status = "update"
            Else
                TBL_SupplierTableAdapter.UpdateQuery(txtNamaSup.Text, txtAlamat.Text, txtKota.Text, txtTelepon.Text, txtHP.Text, txtFax.Text, txtKodeSup.Text)
            End If
            tsTambah.Enabled = True
            tsHapus.Enabled = True
            Dim posisi As Integer = CInt(BindingNavigatorPositionItem.Text)
            Me.TBL_SupplierTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Supplier)
            TBLSupplierBindingSource.Position = posisi - 1
            tsRefresh.Text = "&Refresh"
        End If
    End Sub

    Private Sub tsHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsHapus.Click
        If txtKodeSup.Text <> "" Then
            Dim cekcust As Integer = TbL_Pembelian_HeaderTableAdapter.CekKodeSupplier(txtKodeSup.Text)
            If cekcust = 0 Then
                If MessageBox.Show("Apakah anda yakin akan menghapus supplier dengan kode : " & txtKodeSup.Text & "?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Try
                        TBL_SupplierTableAdapter.DeleteQuery(txtKodeSup.Text)
                        Me.TBLSupplierBindingSource.RemoveAt(CInt(BindingNavigatorPositionItem.Text) - 1)
                        Me.BindingNavigatorPositionItem.Enabled = True
                        Me.BindingNavigatorMovePreviousItem.Enabled = True
                        Me.BindingNavigatorMoveFirstItem.Enabled = True
                    Catch ex As Exception
                        MessageBox.Show("Error : " & ex.ToString, "Error")
                    End Try
                End If
            Else
                MessageBox.Show("supplier tidak dapat dihapus, Kode supplier telah dipakai di Pembelian", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub tsRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsRefresh.Click
        Me.TBL_SupplierTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Supplier)
        tsTambah.Enabled = True
        tsSimpan.Enabled = True
        tsHapus.Enabled = True
        status = "update"
        Me.tsRefresh.Text = "&Refresh"
    End Sub

    Private Sub txtKataKunci_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKataKunci.KeyDown
        If e.KeyValue = 13 Then
            If txtKataKunci.Text <> "" Then
                If cboKriteria.Text = "Kode Supplier" Then
                    Me.TBL_SupplierTableAdapter.FillByKodeSupplier(Db_POS_CNDataSet.TBL_Supplier, Me.txtKataKunci.Text)
                ElseIf cboKriteria.Text = "Nama Supplier" Then
                    Me.TBL_SupplierTableAdapter.FillByNama(Db_POS_CNDataSet.TBL_Supplier, Me.txtKataKunci.Text)
                End If
            Else
                Me.TBL_SupplierTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Supplier)
            End If
        End If
    End Sub

    Private Sub FRM_Supplier_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.Control AndAlso (e.KeyCode = Keys.Right)) Then
            BindingNavigatorMoveNextItem.PerformClick()
        ElseIf (e.Control AndAlso (e.KeyCode = Keys.Left)) Then
            BindingNavigatorMovePreviousItem.PerformClick()
        ElseIf (e.Shift AndAlso (e.KeyCode = Keys.Right)) Then
            BindingNavigatorMoveLastItem.PerformClick()
        ElseIf (e.Shift AndAlso (e.KeyCode = Keys.Left)) Then
            BindingNavigatorMoveFirstItem.PerformClick()
        End If
    End Sub
End Class