Public Class FRM_Barang_Detail
    Dim status As String = "update"
    Sub CekNamaBarang()
        If txtKodeBarang.Text = "" Then
            txtNamaBarang.Text = ""
        Else
            txtNamaBarang.Text = TbL_BarangTableAdapter.LoadNamaBarang(txtKodeBarang.Text)
        End If
    End Sub
    Private Sub FRM_Barang_Detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_POS_CNDataSet.TBL_Barang_Detail' table. You can move, or remove it, as needed.
        Me.TBL_Barang_DetailTableAdapter.FillByKodeBarang(Me.Db_POS_CNDataSet.TBL_Barang_Detail, FRM_Barang.txtKodeBarang.Text)
    End Sub

    Private Sub tsTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsTambah.Click
        'TBLBarangDetailBindingSource.AddNew()
        'BindingNavigatorPositionItem.Enabled = False
        'BindingNavigatorMovePreviousItem.Enabled = False
        'BindingNavigatorMoveFirstItem.Enabled = False
        tsTambah.Enabled = False
        tsHapus.Enabled = False
        tsRefresh.Text = "&Batal"
        txtKodeBarang.Text = FRM_Barang.txtKodeBarang.Text
        txtNamaBarang.Text = FRM_Barang.txtNamaBarang.Text
        Try
            Dim iddetail As Integer = CInt(TBL_Barang_DetailTableAdapter.IDBarangBaru)
            If iddetail = 0 Then iddetail = 1
            txtIdDetail.Text = iddetail
        Catch ex As Exception
            txtIdDetail.Text = 1
        End Try
        txtQtyDetail.ReadOnly = False
        txtNamaDetail.Focus()
        status = "simpan"
    End Sub

    Private Sub tsSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSimpan.Click
        If txtNamaDetail.Text = "" Then
            MessageBox.Show("Kolom bertanda * wajib diisi", "Error!", MessageBoxButtons.OK)
            txtNamaDetail.Focus()
        Else
            'BindingNavigatorPositionItem.Enabled = True
            'BindingNavigatorMovePreviousItem.Enabled = True
            'BindingNavigatorMoveFirstItem.Enabled = True
            If status = "simpan" Then
                TBL_Barang_DetailTableAdapter.InsertQuery(txtIdDetail.Text, txtKodeBarang.Text, txtNamaDetail.Text, txtQtyDetail.Text)
                TbL_BarangTableAdapter.UpdateQty(txtQtyDetail.Text, txtKodeBarang.Text)
                TbL_BarangTableAdapter.UpdateStokAwal(txtQtyDetail.Text, txtKodeBarang.Text)
                status = "update"
            Else
                TBL_Barang_DetailTableAdapter.UpdateQuery(txtNamaDetail.Text, txtQtyDetail.Text, txtIdDetail.Text)
            End If
            tsTambah.Enabled = True
            tsHapus.Enabled = True
            txtQtyDetail.ReadOnly = True
            Me.TBL_Barang_DetailTableAdapter.FillByKodeBarang(Me.Db_POS_CNDataSet.TBL_Barang_Detail, FRM_Barang.txtKodeBarang.Text)
            tsRefresh.Text = "&Refresh"
            txtNamaDetail.Focus()
        End If
    End Sub

    Private Sub tsHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsHapus.Click
        If txtIdDetail.Text <> "" Then
            Dim cekbeli As Integer = Me.TbL_Pembelian_DetailTableAdapter.CekIDBarangDetail(txtIdDetail.Text)
            Dim cekjual As Integer = Me.TbL_Penjualan_DetailTableAdapter.CekIDBarangDetail(txtIdDetail.Text)
            If cekbeli > 0 Or cekjual > 0 Then
                MessageBox.Show("ID Detail telah digunakan di pembelian/penjualan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If MessageBox.Show("Apakah anda yakin akan menghapus detail barang?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    TBL_Barang_DetailTableAdapter.DeleteQuery(txtIdDetail.Text)
                    TbL_BarangTableAdapter.UpdateQty(txtQtyDetail.Text * -1, txtKodeBarang.Text)
                    TbL_BarangTableAdapter.UpdateStokAwal(txtQtyDetail.Text * -1, txtKodeBarang.Text)
                    Me.TBLBarangDetailBindingSource.RemoveAt(CInt(BindingNavigatorPositionItem.Text) - 1)
                    Me.BindingNavigatorPositionItem.Enabled = True
                    Me.BindingNavigatorMovePreviousItem.Enabled = True
                    Me.BindingNavigatorMoveFirstItem.Enabled = True
                Catch ex As Exception
                    MessageBox.Show("Error : " & ex.ToString, "Error")
                End Try
            End If
        End If
    End Sub

    Private Sub tsRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsRefresh.Click
        Me.TBL_Barang_DetailTableAdapter.FillByKodeBarang(Me.Db_POS_CNDataSet.TBL_Barang_Detail, FRM_Barang.txtKodeBarang.Text)
        tsTambah.Enabled = True
        tsSimpan.Enabled = True
        tsHapus.Enabled = True
        txtQtyDetail.ReadOnly = True
        status = "update"
        Me.tsRefresh.Text = "&Refresh"
    End Sub

    Private Sub FRM_Barang_Detail_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FRM_Barang.tsRefresh_Click(Nothing, Nothing)
    End Sub

    Private Sub txtKodeBarang_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKodeBarang.TextChanged
        CekNamaBarang()
    End Sub

End Class