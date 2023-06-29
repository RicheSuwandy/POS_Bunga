Public Class FRM_Edit_Retur_Pembelian
    Dim maxqty As Integer
    Dim qtyawal As Integer
    Dim g1awal As Integer
    Dim g2awal As Integer
    Private Sub FRM_Edit_Retur_Pembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'txtKodeRetur.Text = FRM_Retur_Pembelian.txtKodeRetur.Text
        'txtNo.Text = FRM_Retur_Pembelian.dgvPembelian.GetData(FRM_Retur_Pembelian.dgvPembelian.RowSel, 1)
        'maxqty = TbL_Pembelian_DetailTableAdapter.GetMaxQty(FRM_Retur_Pembelian.txtNoFaktur.Text, txtNo.Text)
        'txtKodeBarang.Text = FRM_Retur_Pembelian.dgvPembelian.GetData(FRM_Retur_Pembelian.dgvPembelian.RowSel, 2)
        'txtNamaBarang.Text = FRM_Retur_Pembelian.dgvPembelian.GetData(FRM_Retur_Pembelian.dgvPembelian.RowSel, 3)
        'txtHargaJual.Text = CLng(FRM_Retur_Pembelian.dgvPembelian.GetData(FRM_Retur_Pembelian.dgvPembelian.RowSel, 4)).ToString("C0")
        'txtQty.Text = FRM_Retur_Pembelian.dgvPembelian.GetData(FRM_Retur_Pembelian.dgvPembelian.RowSel, 5)
        'qtyawal = txtQty.Text
        'txtG1.Text = FRM_Retur_Pembelian.dgvPembelian.GetData(FRM_Retur_Pembelian.dgvPembelian.RowSel, 6)
        'g1awal = txtG1.Text
        'txtG2.Text = FRM_Retur_Pembelian.dgvPembelian.GetData(FRM_Retur_Pembelian.dgvPembelian.RowSel, 7)
        'g2awal = txtG2.Text
        'txtDiscPersen.Text = FRM_Retur_Pembelian.dgvPembelian.GetData(FRM_Retur_Pembelian.dgvPembelian.RowSel, 8)
        'txtDiscRupiah.Text = CLng(FRM_Retur_Pembelian.dgvPembelian.GetData(FRM_Retur_Pembelian.dgvPembelian.RowSel, 9)).ToString("C0")
        'txtSubtotal.Text = CLng(FRM_Retur_Pembelian.dgvPembelian.GetData(FRM_Retur_Pembelian.dgvPembelian.RowSel, 10)).ToString("C0")
    End Sub

    Private Sub txtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged
        On Error Resume Next
        If IsNumeric(txtQty.Text) Then
            If txtQty.Text < 0 Then
                MessageBox.Show("Qty retur harus >= 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtQty.Clear()
            ElseIf txtQty.Text <= maxqty Then
                txtG1.Text = 0
                txtG2.Text = txtQty.Text
                txtSubtotal.Text = CLng(txtQty.Text * (txtHargaJual.Text - txtDiscRupiah.Text)).ToString("C0")
            Else
                MessageBox.Show("Qty retur tidak boleh > " & maxqty, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtQty.Clear()
                txtG1.Clear()
                txtG2.Clear()
                txtSubtotal.Clear()
            End If
        Else
            txtQty.Clear()
            txtG1.Clear()
            txtG2.Clear()
            txtSubtotal.Clear()
        End If
    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress, txtG1.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Or e.KeyChar = Chr(46) Or e.KeyChar = Chr(44) Then
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtG1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtG1.KeyUp
        'If IsNumeric(txtQty.Text) Then
        If IsNumeric(txtG1.Text) Then
            If CDec(txtG1.Text) > CDec(txtQty.Text) Then
                txtG1.Text = 0
                txtG2.Text = txtQty.Text
            ElseIf CDec(txtG1.Text) <= CDec(txtQty.Text) Then
                txtG2.Text = txtQty.Text - txtG1.Text
            End If
        End If
        'Else
        '    MessageBox.Show("Masukkan qty retur", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtG1.Clear()
        '    txtQty.Focus()
        'End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim jlhitem As Integer
        Dim totalqty As Decimal
        Dim totalharga As Long
        Dim posisi As Integer
        Dim cekquantity As Boolean
        If CDec(txtQty.Text) = CDec(txtG1.Text) + CDec(txtG2.Text) Then
            cekquantity = True
        Else
            cekquantity = False
        End If
        If txtQty.Text <> "" And txtG1.Text <> "" And txtG2.Text <> "" And cekquantity Then
            If txtQty.Text > 0 Then
                TbL_Retur_Pembelian_DetailTableAdapter.UpdateQtyRetur(txtQty.Text, txtG1.Text, txtG2.Text, txtSubtotal.Text, txtKodeRetur.Text, txtNo.Text)
                Me.TbL_BarangTableAdapter.UpdateQty(qtyawal - txtQty.Text, txtKodeBarang.Text)
                Me.TbL_BarangTableAdapter.UpdateQtyG1(g1awal - txtG1.Text, txtKodeBarang.Text)
                Me.TbL_BarangTableAdapter.UpdateQtyG2(g2awal - txtG2.Text, txtKodeBarang.Text)
                MessageBox.Show("Data berhasil disimpan ke database", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtQty.Text = 0 Then
                If MessageBox.Show("Item retur pembelian akan dihapus dari database, yakin untuk melanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    TbL_Retur_Pembelian_DetailTableAdapter.DeletePerItem(txtKodeRetur.Text, txtNo.Text)
                    Me.TbL_BarangTableAdapter.UpdateQty(qtyawal, txtKodeBarang.Text)
                    Me.TbL_BarangTableAdapter.UpdateQtyG1(g1awal, txtKodeBarang.Text)
                    Me.TbL_BarangTableAdapter.UpdateQtyG2(g2awal, txtKodeBarang.Text)
                    MessageBox.Show("Data item retur pembelian berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
            posisi = CInt(FRM_Retur_Pembelian.BindingNavigatorPositionItem.Text)
            Try
                jlhitem = TbL_Retur_Pembelian_DetailTableAdapter.BanyakItem(txtKodeRetur.Text)
            Catch ex As Exception
                jlhitem = 0
            End Try
            Try
                totalqty = TbL_Retur_Pembelian_DetailTableAdapter.TotalQty(txtKodeRetur.Text)
            Catch ex As Exception
                totalqty = 0
            End Try
            Try
                totalharga = TbL_Retur_Pembelian_DetailTableAdapter.TotalHarga(txtKodeRetur.Text)
            Catch ex As Exception
                totalharga = 0
            End Try
            TbL_Retur_Pembelian_HeaderTableAdapter.UpdateItemQtyHarga(jlhitem, totalqty, totalharga, txtKodeRetur.Text)
            TbL_HutangTableAdapter.UpdateRetur(totalharga, FRM_Retur_Pembelian.txtNoFaktur.Text)
            Dim sisahutang As Long
            Try
                sisahutang = TbL_HutangTableAdapter.GetSisaHutang(FRM_Retur_Pembelian.txtNoFaktur.Text)
            Catch ex As Exception
                sisahutang = 0
            End Try
            If sisahutang <= 0 Then
                TbL_HutangTableAdapter.UpdateStatus("L", FRM_Retur_Pembelian.txtNoFaktur.Text)
            Else
                TbL_HutangTableAdapter.UpdateStatus("BL", FRM_Retur_Pembelian.txtNoFaktur.Text)
            End If
            FRM_Retur_Pembelian.TBL_Retur_Pembelian_HeaderTableAdapter.Fill(FRM_Retur_Pembelian.Db_POS_CNDataSet.TBL_Retur_Pembelian_Header)
            FRM_Retur_Pembelian.TbL_Retur_Pembelian_DetailTableAdapter.Fill(FRM_Retur_Pembelian.Db_POS_CNDataSet.TBL_Retur_Pembelian_Detail)
            FRM_Retur_Pembelian.Query_Retur_PembelianTableAdapter.Fill(FRM_Retur_Pembelian.Db_POS_CNDataSet.Query_Retur_Pembelian)
            FRM_Retur_Pembelian.TBLReturPembelianHeaderBindingSource.Position = posisi - 1
            tutupform(Me)
        Else
            MessageBox.Show("Qty retur harus > 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        tutupform(Me)
    End Sub
End Class