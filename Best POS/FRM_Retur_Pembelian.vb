Public Class FRM_Retur_Pembelian
    Dim status As String
    Dim diskonpersen As Decimal
    Dim diskonrupiah As Double
    Dim hargabaru As Long
    Dim hargadefault As Long
    Dim kodebarang As String
    Dim cekdata As Integer
    Dim kuanti As Decimal
    Dim qtyawal As Decimal

    Sub nonaktifdetail()
        txtNo.Enabled = False
        txtQty.Enabled = False
        btnAdd.Enabled = False
        btnReset.Enabled = False
    End Sub

    Sub aktifdetail()
        txtNo.Enabled = True
        txtQty.Enabled = True
        btnAdd.Enabled = True
        btnReset.Enabled = True
    End Sub
    Private Sub FRM_Retur_pembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TBL_Retur_Pembelian_HeaderTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Retur_Pembelian_Header)
        Me.TbL_Retur_Pembelian_DetailTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Retur_Pembelian_Detail)
        Me.Query_Retur_PembelianTableAdapter.Fill(Me.Db_POS_CNDataSet.Query_Retur_Pembelian)
        status = "update"
        nonaktifdetail()
        'tsCetak.Visible = False
    End Sub

    Private Sub txtNoFaktur_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNoFaktur.KeyDown
        Try
            If e.KeyValue = 13 Then
                If dgvpembelian.Rows.Count <= 1 Then
                    Me.Query_Kode_Pembelian_ReturTableAdapter.Fill(Me.Db_POS_CNDataSet.Query_Kode_Pembelian_Retur)
                    Me.cfgFaktur.Visible = True
                    Me.cfgFaktur.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.ToString, "Error")
        End Try
    End Sub

    Private Sub cfgFaktur_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cfgFaktur.KeyDown
        Try
            If e.KeyValue = 13 Then
                txtNoFaktur.Text = cfgFaktur.GetData(cfgFaktur.RowSel, 1)
                Me.cfgFaktur.Visible = False
                dtpTanggal.Focus()
            End If
            If e.KeyCode = Keys.Escape Then
                cfgFaktur.Visible = False
                txtNoFaktur.Clear()
                txtNoFaktur.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.ToString, "Error")
        End Try
    End Sub

    Private Sub txtNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNo.KeyDown
        Try
            If e.KeyValue = 13 Then
                Me.Query_PembelianTableAdapter.FillByKodePembelian(Me.Db_POS_CNDataSet.Query_Pembelian, txtNoFaktur.Text)
                Me.dgvBarang.Visible = True
                Me.dgvBarang.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.ToString, "Error")
        End Try
    End Sub

    Private Sub dgvBarang_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvBarang.KeyDown
        Try
            If e.KeyValue = 13 Then
                If dgvBarang.Rows.Count > 0 Then
                    Dim rowindeks As Integer = Me.dgvBarang.CurrentCell.RowIndex
                    Dim nobaris As String = dgvBarang.Item(0, rowindeks).Value
                    Dim cekdata As Integer
                    Try
                        cekdata = TbL_Retur_Pembelian_DetailTableAdapter.CekKodeReturNoBaris(txtKodeRetur.Text, nobaris)
                    Catch ex As Exception
                        cekdata = 0
                    End Try
                    If cekdata = 0 Then
                        txtNo.Text = nobaris
                        txtBarcodeBarang.Text = dgvBarang.Item(1, rowindeks).Value
                        txtIdDetail.Text = dgvBarang.Item(3, rowindeks).Value
                        txtHargaJual.Text = CLng(dgvBarang.Item(5, rowindeks).Value).ToString("C0")
                        txtDiskonPersenDetail.Text = CDec(dgvBarang.Item(7, rowindeks).Value).ToString("N2")
                        txtDiskonRpDetail.Text = CLng(dgvBarang.Item(8, rowindeks).Value).ToString("C0")
                        qtyawal = dgvBarang.Item(6, rowindeks).Value
                        txtQty.Focus()
                    Else
                        MessageBox.Show("Kode Barang sudah terpakai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtNo.Focus()
                    End If
                    Me.dgvBarang.Visible = False
                End If
            End If
            If e.KeyCode = Keys.Escape Then
                dgvBarang.Visible = False
                txtNo.Clear()
                txtNo.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.ToString, "Error")
        End Try
    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Or e.KeyChar = Chr(46) Or e.KeyChar = Chr(44) Then
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged
        If IsNumeric(txtQty.Text) Then
            If txtQty.Text = 0 Then
                MessageBox.Show("Qty retur harus > 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtQty.Clear()
            ElseIf txtQty.Text <= qtyawal Then
                
                txtSubtotal.Text = CLng(txtQty.Text * (txtHargaJual.Text - txtDiskonRpDetail.Text)).ToString("C0")
            Else
                MessageBox.Show("Qty retur tidak boleh > " & qtyawal, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtQty.Clear()
                
                txtSubtotal.Clear()
            End If
        Else
            txtQty.Clear()
            txtSubtotal.Clear()
        End If
    End Sub

    'Private Sub txtG1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If IsNumeric(txtQty.Text) Then
    '        If IsNumeric(txtG1.Text) Then
    '            If txtG1.Text <= txtQty.Text Then
    '                txtG2.Text = txtQty.Text - txtG1.Text
    '            End If
    '        End If
    '    Else
    '        MessageBox.Show("Masukkan qty retur", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        txtG1.Clear()
    '        txtQty.Focus()
    '    End If
    'End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtNo.Text <> "" And txtQty.Text <> "" And txtNoFaktur.Text <> "" Then
            Dim cekdata As Integer
            Try
                cekdata = TbL_Retur_Pembelian_DetailTableAdapter.CekKodeReturNoBaris(txtKodeRetur.Text, txtNo.Text)
            Catch ex As Exception
                cekdata = 0
            End Try
            If cekdata = 0 Then
                qtyawal = Me.TbL_Pembelian_DetailTableAdapter.GetMaxQty(txtNoFaktur.Text, txtNo.Text)
                If txtQty.Text <= qtyawal Then
                    Dim posisi As Integer = CInt(Me.BindingNavigatorPositionItem.Text)
                    Dim jlhitem As Integer
                    Dim totalqty As Decimal
                    Dim totalharga As Long
                    Me.TbL_Retur_Pembelian_DetailTableAdapter.InsertQuery(txtKodeRetur.Text, txtNo.Text, txtBarcodeBarang.Text, txtIdDetail.Text, txtHargaJual.Text, txtQty.Text, txtDiskonPersenDetail.Text, txtDiskonRpDetail.Text, txtSubtotal.Text, 0, 0)
                    Me.TBL_BarangTableAdapter.UpdateQty(txtQty.Text * -1, txtBarcodeBarang.Text)
                    Me.TbL_Barang_DetailTableAdapter.UpdateQty(txtQty.Text * -1, txtIdDetail.Text)
                    
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
                    txtNoFaktur.Enabled = False
                    TBL_Retur_Pembelian_HeaderTableAdapter.UpdateKodePembelianTglKet(txtNoFaktur.Text, dtpTanggal.Value, txtKeterangan.Text, txtKodeRetur.Text)
                    TBL_Retur_Pembelian_HeaderTableAdapter.UpdateItemQtyHarga(jlhitem, totalqty, totalharga, txtKodeRetur.Text)
                    TbL_HutangTableAdapter.UpdateRetur(totalharga, txtNoFaktur.Text)
                    Dim sisahutang As Long
                    Try
                        sisahutang = TbL_HutangTableAdapter.GetSisaHutang(txtNoFaktur.Text)
                    Catch ex As Exception
                        sisahutang = 0
                    End Try
                    If sisahutang <= 0 Then
                        TbL_HutangTableAdapter.UpdateStatus("L", txtNoFaktur.Text)
                    Else
                        TbL_HutangTableAdapter.UpdateStatus("BL", txtNoFaktur.Text)
                    End If
                    Me.TBL_Retur_Pembelian_HeaderTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Retur_Pembelian_Header)
                    Me.TbL_Retur_Pembelian_DetailTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Retur_Pembelian_Detail)
                    Me.Query_Retur_PembelianTableAdapter.Fill(Me.Db_POS_CNDataSet.Query_Retur_Pembelian)
                    txtNo.Clear()
                    txtBarcodeBarang.Clear()
                    txtQty.Clear()
                    txtHargaJual.Clear()
                    txtDiskonPersenDetail.Clear()
                    txtDiskonRpDetail.Clear()
                    txtSubtotal.Clear()
                    TBLReturPembelianHeaderBindingSource.Position = posisi - 1
                    txtNo.Focus()
                Else
                    MessageBox.Show("Qty retur tidak boleh > " & qtyawal, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Kode Barang sudah terpakai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Kolom bertanda * wajib diisi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub tsTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsTambah.Click
        TBLReturPembelianHeaderBindingSource.AddNew()
        txtNoFaktur.Enabled = True
        cekdata = 0
        Me.BindingNavigatorPositionItem.Enabled = False
        Me.BindingNavigatorMovePreviousItem.Enabled = False
        Me.BindingNavigatorMoveFirstItem.Enabled = False
        dtpTanggal.Value = Now
        Me.tsCetak.Enabled = False
        status = "simpan"
        Dim koderetur As Integer
        Try
            koderetur = TBL_Retur_Pembelian_HeaderTableAdapter.KodeReturBaru()
        Catch ex As Exception
            koderetur = 1
        End Try
        txtKodeRetur.Text = "RTB-" & koderetur.ToString("000000")
        Try
            Me.TBL_Retur_Pembelian_HeaderTableAdapter.TambahRetur(txtKodeRetur.Text)
        Catch ex As Exception
            MessageBox.Show("Gagal menambahkan kode retur pembelian ke database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        txtBarcodeBarang.Clear()
        txtNoFaktur.Enabled = True
        tsTambah.Enabled = False
        tsHapus.Enabled = False
        tsRefresh.Text = "&Batal"
        txtNoFaktur.Focus()
        aktifdetail()
        'dgvpembelian.AllowDelete = True
        status = "insert"
    End Sub

    Private Sub tsSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSimpan.Click
        If status = "update" Then
            If txtNoFaktur.Text <> "" Then
                TBL_Retur_Pembelian_HeaderTableAdapter.UpdateKodePembelianTglKet(txtNoFaktur.Text, dtpTanggal.Value, txtKeterangan.Text, txtKodeRetur.Text)
            Else
                MessageBox.Show("Kolom bertanda * wajib diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If txtKodeRetur.Text <> "" And txtNoFaktur.Text <> "" Then
                Dim posisi As Integer = Me.BindingNavigatorPositionItem.Text
                Me.BindingNavigatorPositionItem.Enabled = True
                Me.BindingNavigatorMovePreviousItem.Enabled = True
                Me.BindingNavigatorMoveFirstItem.Enabled = True
                tsTambah.Enabled = True
                tsHapus.Enabled = True
                tsRefresh.Enabled = True
                tsCetak.Enabled = True
                Me.tsRefresh.Text = "&Refresh"
                Me.txtBarcodeBarang.Focus()
                dgvPembelian.AllowUserToDeleteRows = False
                nonaktifdetail()
                jenispmbjual = ""
                pmbjual = 0
                sisapmbjual = 0
                status = "update"
                'Me.TBL_pembelian_HeaderTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_pembelian_Header)
                'Me.TbL_pembelian_DetailTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_pembelian_Detail)
                'Me.Query_pembelianTableAdapter.Fill(Me.Db_POS_CNDataSet.Query_pembelian)
                'TBLpembelianHeaderBindingSource.Position = posisi - 1
            Else
                MessageBox.Show("Kolom bertanda * wajib diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Sub HapusSemuaItemPasok()
        If dgvPembelian.Rows.Count > 0 Then
            Dim nobaris As Integer
            Dim kodebarang As String
            Dim qtyretur As Decimal
            Dim iddetail As Integer
            For i As Integer = 0 To dgvPembelian.RowCount - 1
                nobaris = dgvPembelian.Rows(i).Cells(0).Value
                kodebarang = dgvPembelian.Rows(i).Cells(1).Value
                qtyretur = dgvPembelian.Rows(i).Cells(6).Value
                iddetail = dgvPembelian.Rows(i).Cells(3).Value
                Me.TBL_BarangTableAdapter.UpdateQty(qtyretur, kodebarang)
                Me.TbL_Barang_DetailTableAdapter.UpdateQty(qtyretur, iddetail)
            Next
        End If
    End Sub

    Private Sub tsHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsHapus.Click
        If BindingNavigatorPositionItem.Text <> 0 Then
            If MessageBox.Show("Yakin akan menghapus data retur pembelian dengan kode : " & txtKodeRetur.Text & " ?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.Yes Then
                HapusSemuaItemPasok()
                Me.TbL_HutangTableAdapter.UpdateRetur(0, txtNoFaktur.Text)
                dgvPembelian.AllowUserToDeleteRows = False
                nonaktifdetail()
                status = "update"
                TbL_Retur_pembelian_DetailTableAdapter.DeleteQuery(txtKodeRetur.Text)
                TBL_Retur_Pembelian_HeaderTableAdapter.DeleteQuery(txtKodeRetur.Text)
                Me.TBLReturPembelianHeaderBindingSource.RemoveAt(CInt(BindingNavigatorPositionItem.Text) - 1)
                Me.BindingNavigatorPositionItem.Enabled = True
                Me.BindingNavigatorMovePreviousItem.Enabled = True
                Me.BindingNavigatorMoveFirstItem.Enabled = True
            End If
        Else
            MessageBox.Show("Anda telah berada di record 0", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub tsRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsRefresh.Click
        If tsRefresh.Text = "&Refresh" Then
            Me.TBL_Retur_Pembelian_HeaderTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Retur_Pembelian_Header)
            Me.TbL_Retur_pembelian_DetailTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Retur_Pembelian_Detail)
            Me.Query_Retur_PembelianTableAdapter.Fill(Me.Db_POS_CNDataSet.Query_Retur_Pembelian)
            tsTambah.Enabled = True
            tsSimpan.Enabled = True
            tsHapus.Enabled = True
            tsRefresh.Text = "&Refresh"
            tsRefresh.Enabled = True
        Else
            If MessageBox.Show("Yakin akan membatalkan data retur pembelian dengan kode : " & Me.txtKodeRetur.Text & " ?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.Yes Then
                HapusSemuaItemPasok()
                Me.TbL_HutangTableAdapter.UpdateRetur(0, txtNoFaktur.Text)
                TbL_Retur_pembelian_DetailTableAdapter.DeleteQuery(txtKodeRetur.Text)
                TBL_Retur_Pembelian_HeaderTableAdapter.DeleteQuery(txtKodeRetur.Text)
                Me.TBLReturPembelianHeaderBindingSource.RemoveAt(CInt(BindingNavigatorPositionItem.Text) - 1)
                Me.BindingNavigatorPositionItem.Enabled = True
                Me.BindingNavigatorMovePreviousItem.Enabled = True
                Me.BindingNavigatorMoveFirstItem.Enabled = True
                tsRefresh.Text = "&Refresh"
                tsTambah.Enabled = True
                tsHapus.Enabled = True
                cfgFaktur.Visible = False
                dgvBarang.Visible = False
                txtBarcodeBarang.Clear()
                txtQty.Clear()
                txtHargaJual.Clear()
                txtDiskonPersenDetail.Clear()
                txtDiskonRpDetail.Clear()
                txtSubtotal.Clear()
                nonaktifdetail()
            End If
        End If
        Me.tsCetak.Enabled = True
    End Sub

    Private Sub txtKataKunci_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKataKunci.KeyDown
        If e.KeyValue = 13 Then
            If txtKataKunci.Text <> "" Then
                If cboKriteria.Text = "Kode Retur" Then
                    Me.TBL_Retur_Pembelian_HeaderTableAdapter.FillByKodeRetur(Me.Db_POS_CNDataSet.TBL_Retur_Pembelian_Header, txtKataKunci.Text)
                ElseIf cboKriteria.Text = "No Faktur" Then
                    Me.TBL_Retur_Pembelian_HeaderTableAdapter.FillByKodePembelian(Me.Db_POS_CNDataSet.TBL_Retur_Pembelian_Header, txtKataKunci.Text)
                End If
            Else
                Me.TBL_Retur_Pembelian_HeaderTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Retur_Pembelian_Header)
            End If
        End If
    End Sub

    Private Sub FRM_Retur_Pembelian_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub dgvPembelian_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If e.KeyCode = Keys.Delete Then
        '    If txtNo.Enabled = True Then
        '        If dgvPembelian.Rows.Count > 1 Then
        '            If MessageBox.Show("Yakin akan menghapus item retur pembelian?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
        '                Dim nobaris As Integer
        '                Dim kodebarang As String
        '                Dim qtyretur As Decimal
        '                Dim qtyg1 As Decimal
        '                Dim qtyg2 As Decimal
        '                Dim jlhitem As Integer
        '                Dim totalqty As Decimal
        '                Dim totalharga As Long
        '                nobaris = dgvPembelian.GetData(dgvPembelian.RowSel, 1)
        '                kodebarang = dgvPembelian.GetData(dgvPembelian.RowSel, 2)
        '                qtyretur = dgvPembelian.GetData(dgvPembelian.RowSel, 5)
        '                qtyg1 = dgvPembelian.GetData(dgvPembelian.RowSel, 6)
        '                qtyg2 = dgvPembelian.GetData(dgvPembelian.RowSel, 7)
        '                Me.TBL_BarangTableAdapter.UpdateQty(qtyretur, kodebarang)
        '                Me.TBL_BarangTableAdapter.UpdateQtyG1(qtyg1, kodebarang)
        '                Me.TBL_BarangTableAdapter.UpdateQtyG2(qtyg2, kodebarang)
        '                Me.TbL_Retur_Pembelian_DetailTableAdapter.DeletePerItem(txtKodeRetur.Text, nobaris)
        '                Dim posisi As Integer = CInt(Me.BindingNavigatorPositionItem.Text)
        '                Try
        '                    jlhitem = TbL_Retur_Pembelian_DetailTableAdapter.BanyakItem(txtKodeRetur.Text)
        '                Catch ex As Exception
        '                    jlhitem = 0
        '                End Try
        '                Try
        '                    totalqty = TbL_Retur_Pembelian_DetailTableAdapter.TotalQty(txtKodeRetur.Text)
        '                Catch ex As Exception
        '                    totalqty = 0
        '                End Try
        '                Try
        '                    totalharga = TbL_Retur_Pembelian_DetailTableAdapter.TotalHarga(txtKodeRetur.Text)
        '                Catch ex As Exception
        '                    totalharga = 0
        '                End Try
        '                TBL_Retur_Pembelian_HeaderTableAdapter.UpdateItemQtyHarga(jlhitem, totalqty, totalharga, txtKodeRetur.Text)
        '                Me.TbL_HutangTableAdapter.UpdateRetur(totalharga, txtNoFaktur.Text)
        '                Me.TBL_Retur_Pembelian_HeaderTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Retur_Pembelian_Header)
        '                Me.TbL_Retur_Pembelian_DetailTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Retur_Pembelian_Detail)
        '                Me.Query_Retur_PembelianTableAdapter.Fill(Me.Db_POS_CNDataSet.Query_Retur_Pembelian)
        '                TBLReturPembelianHeaderBindingSource.Position = posisi - 1
        '            End If
        '        End If
        '    Else
        '        MessageBox.Show("Item retur pembelian tidak dapat dihapus", "Error")
        '    End If
        'End If
    End Sub

    Private Sub dgvPembelian_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If dgvPembelian.Rows.Count > 1 And tsTambah.Enabled = True Then
            FRM_Edit_Retur_Pembelian.ShowDialog()
        End If
    End Sub

    Private Sub tsCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsCetak.Click
        If BindingNavigatorPositionItem.Text <> 0 Then
            FRM_RPT_Faktur_Retur_Pembelian.ShowDialog()
        Else
            MessageBox.Show("Anda telah berada di record 0", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class