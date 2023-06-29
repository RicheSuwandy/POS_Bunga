Public Class FRM_Customer
    Dim status As String = "update"
    Private Sub FRM_Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_POS_CNDataSet.TBL_Customer' table. You can move, or remove it, as needed.
        Me.TBL_CustomerTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Customer)
        txtKodeCust.ReadOnly = True
        
    End Sub

    Private Sub tsTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsTambah.Click
        TBLCustomerBindingSource.AddNew()
        BindingNavigatorPositionItem.Enabled = False
        BindingNavigatorMovePreviousItem.Enabled = False
        BindingNavigatorMoveFirstItem.Enabled = False
        tsTambah.Enabled = False
        tsHapus.Enabled = False
        tsRefresh.Text = "&Batal"
        Try
            Dim kodecustomer As Integer = CInt(TBL_CustomerTableAdapter.KodeCustomerBaru)
            If kodecustomer = 0 Then kodecustomer = 1
            txtKodeCust.Text = "CST-" & kodecustomer.ToString("000000")
        Catch ex As Exception
            txtKodeCust.Text = "CST-000001"
        End Try
        txtNamaCust.Focus()
        status = "simpan"
    End Sub

    Private Sub tsSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSimpan.Click
        If txtKodeCust.Text = "" Or txtNamaCust.Text = "" Then
            MessageBox.Show("Kolom bertanda * wajib diisi", "Error!", MessageBoxButtons.OK)
            txtNamaCust.Focus()
        Else
            BindingNavigatorPositionItem.Enabled = True
            BindingNavigatorMovePreviousItem.Enabled = True
            BindingNavigatorMoveFirstItem.Enabled = True
            If status = "simpan" Then
                TBL_CustomerTableAdapter.InsertQuery(txtKodeCust.Text, txtNamaCust.Text, txtAlamat.Text, txtKota.Text, txtTelepon.Text, txtHP.Text, txtFax.Text)
                status = "update"
            Else
                TBL_CustomerTableAdapter.UpdateQuery(txtNamaCust.Text, txtAlamat.Text, txtKota.Text, txtTelepon.Text, txtHP.Text, txtFax.Text, txtKodeCust.Text)
            End If
            tsTambah.Enabled = True
            tsHapus.Enabled = True
            Dim posisi As Integer = CInt(BindingNavigatorPositionItem.Text)
            Me.TBL_CustomerTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Customer)
            TBLCustomerBindingSource.Position = posisi - 1
            tsRefresh.Text = "&Refresh"
        End If
    End Sub

    Private Sub tsHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsHapus.Click
        If txtKodeCust.Text <> "" Then
            Dim cekcust As Integer = TbL_Penjualan_HeaderTableAdapter.CekKodeCustomer(txtKodeCust.Text)
            If cekcust = 0 Then
                If MessageBox.Show("Apakah anda yakin akan menghapus Customer dengan kode : " & txtKodeCust.Text & "?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Try
                        TBL_CustomerTableAdapter.DeleteQuery(txtKodeCust.Text)
                        Me.TBLCustomerBindingSource.RemoveAt(CInt(BindingNavigatorPositionItem.Text) - 1)
                        Me.BindingNavigatorPositionItem.Enabled = True
                        Me.BindingNavigatorMovePreviousItem.Enabled = True
                        Me.BindingNavigatorMoveFirstItem.Enabled = True
                    Catch ex As Exception
                        MessageBox.Show("Error : " & ex.ToString, "Error")
                    End Try
                End If
            Else
                MessageBox.Show("Customer tidak dapat dihapus, Kode customer telah dipakai di Penjualan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub tsRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsRefresh.Click
        Me.TBL_CustomerTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Customer)
        tsTambah.Enabled = True
        tsSimpan.Enabled = True
        tsHapus.Enabled = True
        status = "update"
        Me.tsRefresh.Text = "&Refresh"
    End Sub

    Private Sub txtKataKunci_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKataKunci.KeyDown
        If e.KeyValue = 13 Then
            If txtKataKunci.Text <> "" Then
                If cboKriteria.Text = "Kode Customer" Then
                    Me.TBL_CustomerTableAdapter.FillByKodeCustomer(Db_POS_CNDataSet.TBL_Customer, Me.txtKataKunci.Text)
                ElseIf cboKriteria.Text = "Nama Customer" Then
                    Me.TBL_CustomerTableAdapter.FillByNamaCustomer(Db_POS_CNDataSet.TBL_Customer, Me.txtKataKunci.Text)
                End If
            Else
                Me.TBL_CustomerTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Customer)
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