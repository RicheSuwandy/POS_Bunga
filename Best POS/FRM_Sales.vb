Public Class FRM_Sales
    Dim status As String = "update"
    Private Sub FRM_Sales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_POS_CNDataSet.TBL_Sales' table. You can move, or remove it, as needed.
        Me.TBL_SalesTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Sales)
        txtKodeSales.ReadOnly = True
    End Sub

    Private Sub tsTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsTambah.Click
        TBLSalesBindingSource.AddNew()
        BindingNavigatorPositionItem.Enabled = False
        BindingNavigatorMovePreviousItem.Enabled = False
        BindingNavigatorMoveFirstItem.Enabled = False
        tsTambah.Enabled = False
        tsHapus.Enabled = False
        tsRefresh.Text = "&Batal"
        Try
            Dim kodesales As Integer = CInt(TBL_SalesTableAdapter.KodeSalesBaru)
            txtKodeSales.Text = "SLS-" & kodesales.ToString("000000")
        Catch ex As Exception
            txtKodeSales.Text = "SLS-000001"
        End Try
        txtNamaSales.Focus()
        status = "simpan"
    End Sub

    Private Sub tsSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSimpan.Click
        If txtKodeSales.Text = "" Or txtNamaSales.Text = "" Then
            MessageBox.Show("Kolom bertanda * wajib diisi", "Error!", MessageBoxButtons.OK)
            txtNamaSales.Focus()
        Else
            BindingNavigatorPositionItem.Enabled = True
            BindingNavigatorMovePreviousItem.Enabled = True
            BindingNavigatorMoveFirstItem.Enabled = True
            If status = "simpan" Then
                TBL_SalesTableAdapter.InsertQuery(txtKodeSales.Text, txtNamaSales.Text, txtAlamat.Text, txtKota.Text, txtTelepon.Text, txtHP.Text, txtFax.Text)
                status = "update"
            Else
                TBL_SalesTableAdapter.UpdateQuery(txtNamaSales.Text, txtAlamat.Text, txtKota.Text, txtTelepon.Text, txtHP.Text, txtFax.Text, txtKodeSales.Text)
            End If
            tsTambah.Enabled = True
            tsHapus.Enabled = True
            Dim posisi As Integer = CInt(BindingNavigatorPositionItem.Text)
            Me.TBL_SalesTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Sales)
            TBLSalesBindingSource.Position = posisi - 1
            tsRefresh.Text = "&Refresh"
        End If
    End Sub

    Private Sub tsHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsHapus.Click
        If txtKodeSales.Text <> "" Then
            Dim cekcust As Integer = TbL_Penjualan_HeaderTableAdapter.CekKodesales(txtKodeSales.Text)
            If cekcust = 0 Then
                If MessageBox.Show("Apakah anda yakin akan menghapus sales dengan kode : " & txtKodeSales.Text & "?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Try
                        TBL_SalesTableAdapter.DeleteQuery(txtKodeSales.Text)
                        Me.TBLSalesBindingSource.RemoveAt(CInt(BindingNavigatorPositionItem.Text) - 1)
                        Me.BindingNavigatorPositionItem.Enabled = True
                        Me.BindingNavigatorMovePreviousItem.Enabled = True
                        Me.BindingNavigatorMoveFirstItem.Enabled = True
                    Catch ex As Exception
                        MessageBox.Show("Error : " & ex.ToString, "Error")
                    End Try
                End If
            Else
                MessageBox.Show("Sales tidak dapat dihapus, Kode sales telah dipakai di Penjualan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub tsRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsRefresh.Click
        TBL_SalesTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Sales)
        tsTambah.Enabled = True
        tsSimpan.Enabled = True
        tsHapus.Enabled = True
        status = "update"
        Me.tsRefresh.Text = "&Refresh"
    End Sub

    Private Sub txtKataKunci_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKataKunci.KeyDown
        If e.KeyValue = 13 Then
            If txtKataKunci.Text <> "" Then
                If cboKriteria.Text = "Kode Sales" Then
                    Me.TBL_SalesTableAdapter.FillByKodeSales(Db_POS_CNDataSet.TBL_Sales, Me.txtKataKunci.Text)
                ElseIf cboKriteria.Text = "Nama Sales" Then
                    Me.TBL_SalesTableAdapter.FillByNamaSales(Db_POS_CNDataSet.TBL_Sales, Me.txtKataKunci.Text)
                End If
            Else
                Me.TBL_SalesTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Sales)
            End If
        End If
    End Sub

    Private Sub FRM_Customer_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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