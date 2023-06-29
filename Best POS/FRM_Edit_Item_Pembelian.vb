Imports System.Data.SqlClient
Public Class FRM_Edit_Item_Pembelian
    Dim kodebarangawal As String
    Dim qtyawal As Decimal
    Dim discrpawal As Long
    Dim subtotalawal As Long
    Dim hargajualawal As Long
    Dim totalqty, g1, g2 As Decimal
    Private Sub FRM_Edit_Item_Penjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'dgvBarang.Visible = False
        'txtKodepembelian.Text = FRM_Pembelian.txtKodePembelian.Text
        'txtNo.Text = FRM_Pembelian.dgvPembelian.GetData(FRM_Pembelian.dgvPembelian.RowSel, 1)
        'txtKodeBarang.Text = FRM_Pembelian.dgvPembelian.GetData(FRM_Pembelian.dgvPembelian.RowSel, 2)
        'kodebarangawal = txtKodeBarang.Text
        'txtNamaBarang.Text = FRM_Pembelian.dgvPembelian.GetData(FRM_Pembelian.dgvPembelian.RowSel, 3)
        'txtHargaJual.Text = CLng(FRM_Pembelian.dgvPembelian.GetData(FRM_Pembelian.dgvPembelian.RowSel, 4)).ToString("C0")
        'hargajualawal = CLng(txtHargaJual.Text)
        'txtQty.Text = FRM_Pembelian.dgvPembelian.GetData(FRM_Pembelian.dgvPembelian.RowSel, 5)
        'qtyawal = CDec(txtQty.Text)
        'txtDiscPersen.Text = FRM_Pembelian.dgvPembelian.GetData(FRM_Pembelian.dgvPembelian.RowSel, 6)
        'txtDiscRupiah.Text = CLng(FRM_Pembelian.dgvPembelian.GetData(FRM_Pembelian.dgvPembelian.RowSel, 7)).ToString("C0")
        'discrpawal = CLng(txtDiscRupiah.Text)
        'txtSubtotal.Text = CLng(FRM_Pembelian.dgvPembelian.GetData(FRM_Pembelian.dgvPembelian.RowSel, 8)).ToString("C0")
        'subtotalawal = CLng(txtSubtotal.Text)
    End Sub

    Private Sub txtKodeBarang_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKodeBarang.KeyDown
        Try
            Dim katakunci As String
            If e.KeyValue = 13 Then
                If txtKodeBarang.Text = "" Then
                    Me.TbL_BarangTableAdapter.Fill(Db_POS_CNDataSet.TBL_Barang)
                ElseIf Mid(txtKodeBarang.Text, 1, 1) = "*" And Mid(txtKodeBarang.Text, Len(txtKodeBarang.Text), 1) = "*" Then
                    katakunci = Mid(txtKodeBarang.Text, 2, Len(txtKodeBarang.Text) - 2)
                    Me.TbL_BarangTableAdapter.FillByNamaBarang(Db_POS_CNDataSet.TBL_Barang, katakunci)
                ElseIf txtKodeBarang.Text <> "" Then
                    katakunci = Me.txtKodeBarang.Text
                    Me.TbL_BarangTableAdapter.FillByKodeBarang(Db_POS_CNDataSet.TBL_Barang, katakunci)
                End If
                Me.dgvBarang.Visible = True
                Me.dgvBarang.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.ToString, "Error")
        End Try
    End Sub

    Private Sub dgvBarang_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvBarang.KeyDown
        Dim cekdata As Integer
        Dim hargabaru As Long
        Try
            If e.KeyValue = 13 Then
                txtKodeBarang.Text = dgvBarang.GetData(dgvBarang.RowSel, 1)
                If txtKodeBarang.Text <> kodebarangawal Then
                    txtQty.Clear()
                    txtDiscPersen.Text = 0
                    txtDiscRupiah.Text = 0
                    txtSubtotal.Text = 0
                End If
                txtNamaBarang.Text = dgvBarang.GetData(dgvBarang.RowSel, 2)
                dgvBarang.Visible = False
                Try
                    cekdata = TbL_Harga_SupplierTableAdapter.CekData(FRM_Penjualan.txtCustomer.Text, txtKodeBarang.Text)
                Catch ex As Exception
                    cekdata = 0
                End Try
                If cekdata = 1 Then
                    hargabaru = TbL_Harga_SupplierTableAdapter.HargaBeli(FRM_Penjualan.txtCustomer.Text, txtKodeBarang.Text)
                    txtHargaJual.Text = hargabaru.ToString("C0")
                Else
                    txtHargaJual.Text = CLng(dgvBarang.GetData(dgvBarang.RowSel, 5)).ToString("C0")
                End If
                txtQty.Focus()
            End If
            If e.KeyCode = Keys.Escape Then
                dgvBarang.Visible = False
                txtKodeBarang.Clear()
                txtKodeBarang.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.ToString, "Error")
        End Try
    End Sub

    Private Sub txtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged, txtHargaJual.TextChanged
        Try
            Dim totalhargadetail As Long = (txtQty.Text * txtHargaJual.Text) - (txtDiscRupiah.Text * txtQty.Text)
            txtSubtotal.Text = CLng(totalhargadetail).ToString("C0")
        Catch
            txtSubtotal.Text = 0
        End Try
    End Sub

    Private Sub txtDiscPersen_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiscPersen.KeyPress, txtQty.KeyPress, txtDiscRupiah.KeyPress, txtHargaJual.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Or e.KeyChar = Chr(46) Or e.KeyChar = Chr(44) Then
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtDiscPersen_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDiscPersen.KeyUp
        Try
            Try
                txtDiscRupiah.Text = txtDiscPersen.Text / 100 * txtHargaJual.Text
                Dim totalhargadetail As Long = (txtQty.Text * txtHargaJual.Text) - (txtDiscRupiah.Text * txtQty.Text)
                txtSubtotal.Text = CLng(totalhargadetail).ToString("C0")
            Catch
                txtDiscRupiah.Text = 0
                Dim totalhargadetail As Long = (txtQty.Text * txtHargaJual.Text)
                txtSubtotal.Text = CLng(totalhargadetail).ToString("C0")
            End Try
        Catch
            txtDiscPersen.Text = 0
            txtDiscRupiah.Text = 0
            Dim totalhargadetail As Long = (txtQty.Text * txtHargaJual.Text)
            txtSubtotal.Text = CLng(totalhargadetail).ToString("C0")
        End Try
    End Sub

    Private Sub txtDiscPersen_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiscPersen.Leave
        Try
            If txtDiscPersen.Text = "" Then
                txtDiscPersen.Text = 0
                txtDiscRupiah.Text = 0
            End If
        Catch ex As Exception
            txtDiscPersen.Text = 0
            txtDiscRupiah.Text = 0
        End Try
    End Sub

    Private Sub txtDiscRupiah_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiscRupiah.Leave
        Try
            If txtDiscRupiah.Text <> "" Then
                txtDiscRupiah.Text = CLng(txtDiscRupiah.Text).ToString("C0")
            Else
                txtDiscRupiah.Text = 0
            End If
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.ToString, "Error")
        End Try
    End Sub

    Private Sub txtDiscRupiah_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDiscRupiah.KeyUp
        Try
            Try
                txtDiscPersen.Text = txtDiscRupiah.Text / txtHargaJual.Text * 100
                Dim totalhargadetail As Long = (txtQty.Text * txtHargaJual.Text) - (txtDiscRupiah.Text * txtQty.Text)
                txtSubtotal.Text = CLng(totalhargadetail).ToString("C0")
            Catch ex As Exception
                txtDiscPersen.Text = 0
                Dim totalhargadetail As Long = (txtQty.Text * txtHargaJual.Text)
                txtSubtotal.Text = CLng(totalhargadetail).ToString("C0")
            End Try
        Catch
            txtDiscPersen.Text = 0
            txtDiscRupiah.Text = 0
            Dim totalhargadetail As Long = (txtQty.Text * txtHargaJual.Text)
            txtSubtotal.Text = CLng(totalhargadetail).ToString("C0")
        End Try
    End Sub

    Private Sub txtHargaJual_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHargaJual.Leave
        Try
            If txtSubtotal.Text <> "" Then
                txtSubtotal.Text = CLng(txtSubtotal.Text).ToString("C0")
            Else
                txtSubtotal.Text = 0
            End If
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.ToString, "Error")
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        tutupform(Me)
    End Sub

    Sub RestoreItemQtyNol()
        If totalqty = qtyawal Then
            TbL_Pembelian_DetailTableAdapter.DeletePerItem(txtKodePembelian.Text, txtNo.Text)
            Me.TbL_Alokasi_pembelianTableAdapter.DeletePerItem(txtKodePembelian.Text, txtKodeBarang.Text)
            Me.TbL_BarangTableAdapter.UpdateQty(qtyawal * -1, txtKodeBarang.Text)
            If qtyawal = g1 Then
                Me.TbL_BarangTableAdapter.UpdateQtyG1(g1 * -1, txtKodeBarang.Text)
            Else
                Me.TbL_BarangTableAdapter.UpdateQtyG1(g1 * -1, txtKodeBarang.Text)
                Me.TbL_BarangTableAdapter.UpdateQtyG2(g2 * -1, txtKodeBarang.Text)
            End If
        Else
            TbL_Pembelian_DetailTableAdapter.DeletePerItem(txtKodePembelian.Text, txtNo.Text)
            TbL_Alokasi_pembelianTableAdapter.UpdateG1(CDec(txtQty.Text) - qtyawal, txtKodePembelian.Text, txtKodeBarang.Text)
            Me.TbL_BarangTableAdapter.UpdateQty(qtyawal * -1, txtKodeBarang.Text)
            Me.TbL_BarangTableAdapter.UpdateQtyG1(qtyawal * -1, txtKodeBarang.Text)
        End If
    End Sub

    Sub warehouse()
        Try
            Dim cekdata As Integer
            Try
                cekdata = TbL_Alokasi_PembelianTableAdapter.CekKodePembelianKodeBarang(txtKodePembelian.Text, txtKodeBarang.Text)
            Catch ex As Exception
                cekdata = 0
            End Try
            If cekdata = 0 Then
                TbL_Alokasi_PembelianTableAdapter.InsertQuery(txtKodePembelian.Text, txtKodeBarang.Text, txtQty.Text, txtQty.Text, 0)
            Else
                TbL_Alokasi_PembelianTableAdapter.UpdateG1(txtQty.Text, txtKodePembelian.Text, txtKodeBarang.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("Error :" & ex.ToString(), "Error")
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtKodeBarang.Text = kodebarangawal And CLng(txtHargaJual.Text) = hargajualawal And CDec(txtQty.Text) = qtyawal And CLng(txtSubtotal.Text) = subtotalawal Then
            tutupform(Me)
            Exit Sub
        End If
        koneksi()
        sql = "SELECT Total_Qty, G1, G2 FROM TBL_Alokasi_Pembelian WHERE Kode_Pembelian='" & FRM_Pembelian.txtKodePembelian.Text & "' AND Kode_Barang='" & kodebarangawal & "'"
        cmd = New SqlCommand(sql, cn)
        reader = cmd.ExecuteReader
        reader.Read()
        totalqty = reader(0)
        g1 = reader(1)
        g2 = reader(2)
        reader.Close()
        cn.Close()
        Dim posisi As Integer = CInt(FRM_Pembelian.BindingNavigatorPositionItem.Text)
        Dim jlhitem As Integer
        Dim totalqtyjual As Decimal
        Dim totalharga As Long
        If txtKodeBarang.Text = kodebarangawal Then
            If CDec(txtQty.Text) <> qtyawal Then
                If CDec(txtQty.Text) = 0 Then
                    If MessageBox.Show("Item pembelian akan dihapus dari database, yakin untuk melanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        RestoreItemQtyNol()
                    End If
                Else
                    TbL_Pembelian_DetailTableAdapter.UpdateQuery(CLng(txtHargaJual.Text), CDec(txtQty.Text), CDec(txtDiscPersen.Text), CLng(txtDiscRupiah.Text), CLng(txtSubtotal.Text), txtKodePembelian.Text, txtNo.Text)
                    TbL_BarangTableAdapter.UpdateQty(CDec(txtQty.Text) - qtyawal, txtKodeBarang.Text)
                    TbL_BarangTableAdapter.UpdateQtyG1(CDec(txtQty.Text) - qtyawal, txtKodeBarang.Text)
                    TbL_Alokasi_PembelianTableAdapter.UpdateG1(CDec(txtQty.Text) - qtyawal, txtKodePembelian.Text, txtKodeBarang.Text)
                End If
            ElseIf CLng(txtHargaJual.Text) <> hargajualawal Or CLng(txtDiscRupiah.Text) <> discrpawal Or CLng(txtSubtotal.Text) <> subtotalawal Then
                Me.TbL_Pembelian_HeaderTableAdapter.UpdateQuery(FRM_Pembelian.txtNoFakturSup.Text, FRM_Pembelian.txtCustomer.Text, FRM_Pembelian.dtpTanggal.Value, jlhitem, totalqtyjual, totalharga, FRM_Pembelian.txtKodePembelian.Text)
            End If
        Else
            Dim cekkode As Integer = Me.TbL_BarangTableAdapter.CekKodeBarang(txtKodeBarang.Text)
            If txtDiscPersen.Text = "" Or txtDiscRupiah.Text = "" Then
                txtDiscPersen.Text = 0
                txtDiscRupiah.Text = 0
            End If
            If cekkode = 1 Then
                Dim cekdata As Integer
                Dim hargabaru As Long

                'start here
                If totalqty = qtyawal Then
                    TbL_Pembelian_DetailTableAdapter.UpdateQuery2(txtKodeBarang.Text, CLng(txtHargaJual.Text), CDec(txtQty.Text), CDec(txtDiscPersen.Text), CLng(txtDiscRupiah.Text), CLng(txtSubtotal.Text), txtKodePembelian.Text, txtNo.Text)
                    Me.TbL_Alokasi_PembelianTableAdapter.DeletePerItem(txtKodePembelian.Text, kodebarangawal)
                    Me.TbL_BarangTableAdapter.UpdateQty(qtyawal * -1, kodebarangawal)
                    If qtyawal = g1 Then
                        Me.TbL_BarangTableAdapter.UpdateQtyG1(g1 * -1, kodebarangawal)
                    Else
                        Me.TbL_BarangTableAdapter.UpdateQtyG1(g1 * -1, kodebarangawal)
                        Me.TbL_BarangTableAdapter.UpdateQtyG2(g2 * -1, kodebarangawal)
                    End If
                Else
                    TbL_Pembelian_DetailTableAdapter.UpdateQuery2(txtKodeBarang.Text, CLng(txtHargaJual.Text), CDec(txtQty.Text), CDec(txtDiscPersen.Text), CLng(txtDiscRupiah.Text), CLng(txtSubtotal.Text), txtKodePembelian.Text, txtNo.Text)
                    TbL_Alokasi_PembelianTableAdapter.UpdateG1(qtyawal * -1, txtKodePembelian.Text, kodebarangawal)
                    Me.TbL_BarangTableAdapter.UpdateQty(qtyawal * -1, kodebarangawal)
                    Me.TbL_BarangTableAdapter.UpdateQtyG1(qtyawal * -1, kodebarangawal)
                End If
                'end here

                warehouse()
                Me.TbL_BarangTableAdapter.UpdateQty(txtQty.Text, txtKodeBarang.Text)
                Me.TbL_BarangTableAdapter.UpdateQtyG1(txtQty.Text, txtKodeBarang.Text)
                'cek harga default dengan harga customer
                Dim cekharga As Long = txtHargaJual.Text
                Try
                    cekdata = Me.TbL_Harga_SupplierTableAdapter.CekData(FRM_Pembelian.txtCustomer.Text, txtKodeBarang.Text)
                Catch ex As Exception
                    cekdata = 0
                End Try
                If cekdata = 0 Then
                    TbL_Harga_SupplierTableAdapter.InsertQuery(FRM_Pembelian.txtCustomer.Text, txtKodeBarang.Text, cekharga)
                Else
                    If hargabaru <> cekharga Then
                        TbL_Harga_SupplierTableAdapter.UpdateHargaBeli(cekharga, FRM_Pembelian.txtCustomer.Text, txtKodeBarang.Text)
                    End If
                End If
            Else
                MessageBox.Show("Kode Barang tidak terdaftar pada database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtKodeBarang.Clear()
                Me.txtKodeBarang.Focus()
            End If
        End If
        Try
            jlhitem = Me.TbL_Pembelian_DetailTableAdapter.BanyakItem(txtKodePembelian.Text)
        Catch ex As Exception
            jlhitem = 0
        End Try
        Try
            totalqtyjual = Me.TbL_Pembelian_DetailTableAdapter.TotalQty(txtKodePembelian.Text)
        Catch ex As Exception
            totalqtyjual = 0
        End Try
        Try
            totalharga = Me.TbL_Pembelian_DetailTableAdapter.TotalHarga(txtKodePembelian.Text)
        Catch ex As Exception
            totalharga = 0
        End Try
        TbL_Pembelian_HeaderTableAdapter.UpdateItemQtyHarga(jlhitem, totalqtyjual, totalharga, txtKodePembelian.Text)
        If FRM_Pembelian.txtJenisPmb.Text = "KREDIT" Then
            Dim sisabayar As Long = totalharga - CLng(FRM_Pembelian.txtPmb.Text)
            TbL_Pembelian_HeaderTableAdapter.UpdatePembayaran("KREDIT", CLng(FRM_Pembelian.txtPmb.Text), sisabayar, txtKodePembelian.Text)
            TbL_HutangTableAdapter.UpdateTotalHutang(totalharga, txtKodePembelian.Text)
            Dim sisahutang As Long
            Try
                sisahutang = TbL_HutangTableAdapter.GetSisaHutang(txtKodePembelian.Text)
            Catch ex As Exception
                sisahutang = 0
            End Try
            If sisahutang <= 0 Then
                TbL_HutangTableAdapter.UpdateStatus("L", txtKodePembelian.Text)
            Else
                TbL_HutangTableAdapter.UpdateStatus("BL", txtKodePembelian.Text)
            End If
        ElseIf FRM_Pembelian.txtJenisPmb.Text = "CASH" Then
            TbL_Pembelian_HeaderTableAdapter.UpdatePembayaran("CASH", totalharga, 0, txtKodePembelian.Text)
        End If
        FRM_Pembelian.TBL_Pembelian_HeaderTableAdapter.Fill(FRM_Pembelian.Db_POS_CNDataSet.TBL_Pembelian_Header)
        FRM_Pembelian.TBL_Pembelian_DetailTableAdapter.Fill(FRM_Pembelian.Db_POS_CNDataSet.TBL_Pembelian_Detail)
        FRM_Pembelian.Query_PembelianTableAdapter.Fill(FRM_Pembelian.Db_POS_CNDataSet.Query_Pembelian)
        FRM_Pembelian.TBLPembelianHeaderBindingSource.Position = posisi - 1
        MessageBox.Show("Data item pembelian berhasil diedit", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        tutupform(Me)
    End Sub
End Class