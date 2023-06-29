Imports System.Data.SqlClient
Public Class FRM_Edit_Item_Penjualan
    Dim kodebarangawal As String
    Dim qtyawal As Decimal
    Dim discrpawal As Long
    Dim subtotalawal As Long
    Dim hargajualawal As Long
    Dim totalqty, g1, g2 As Decimal
    Private Sub FRM_Edit_Item_Penjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'dgvBarang.Visible = False
        'txtKodePenjualan.Text = FRM_Penjualan.txtKodePenjualan.Text
        'txtNo.Text = FRM_Penjualan.dgvPenjualan.GetData(FRM_Penjualan.dgvPenjualan.RowSel, 1)
        'txtKodeBarang.Text = FRM_Penjualan.dgvPenjualan.GetData(FRM_Penjualan.dgvPenjualan.RowSel, 2)
        'kodebarangawal = txtKodeBarang.Text
        'txtNamaBarang.Text = FRM_Penjualan.dgvPenjualan.GetData(FRM_Penjualan.dgvPenjualan.RowSel, 3)
        'txtHargaJual.Text = CLng(FRM_Penjualan.dgvPenjualan.GetData(FRM_Penjualan.dgvPenjualan.RowSel, 4)).ToString("C0")
        'hargajualawal = CLng(txtHargaJual.Text)
        'txtQty.Text = FRM_Penjualan.dgvPenjualan.GetData(FRM_Penjualan.dgvPenjualan.RowSel, 5)
        'qtyawal = CDec(txtQty.Text)
        'txtDiscPersen.Text = FRM_Penjualan.dgvPenjualan.GetData(FRM_Penjualan.dgvPenjualan.RowSel, 6)
        'txtDiscRupiah.Text = CLng(FRM_Penjualan.dgvPenjualan.GetData(FRM_Penjualan.dgvPenjualan.RowSel, 7)).ToString("C0")
        'discrpawal = CLng(txtDiscRupiah.Text)
        'txtSubtotal.Text = CLng(FRM_Penjualan.dgvPenjualan.GetData(FRM_Penjualan.dgvPenjualan.RowSel, 8)).ToString("C0")
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
                    cekdata = TbL_Harga_CustomerTableAdapter.CekData(FRM_Penjualan.txtCustomer.Text, txtKodeBarang.Text)
                Catch ex As Exception
                    cekdata = 0
                End Try
                If cekdata = 1 Then
                    hargabaru = TbL_Harga_CustomerTableAdapter.HargaJual(FRM_Penjualan.txtCustomer.Text, txtKodeBarang.Text)
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
            TbL_Penjualan_DetailTableAdapter.DeleterPerItem(txtKodePenjualan.Text, txtNo.Text)
            Me.TbL_Alokasi_PenjualanTableAdapter.DeletePerItem(txtKodePenjualan.Text, txtKodeBarang.Text)
            Me.TbL_BarangTableAdapter.UpdateQty(qtyawal, txtKodeBarang.Text)
            If qtyawal = g1 Then
                Me.TbL_BarangTableAdapter.UpdateQtyG1(g1, txtKodeBarang.Text)
            Else
                Me.TbL_BarangTableAdapter.UpdateQtyG1(g1, txtKodeBarang.Text)
                Me.TbL_BarangTableAdapter.UpdateQtyG2(g2, txtKodeBarang.Text)
            End If
        Else
            TbL_Penjualan_DetailTableAdapter.DeleterPerItem(txtKodePenjualan.Text, txtNo.Text)
            TbL_Alokasi_PenjualanTableAdapter.UpdateG1(CDec(txtQty.Text) - qtyawal, txtKodePenjualan.Text, txtKodeBarang.Text)
            Me.TbL_BarangTableAdapter.UpdateQty(qtyawal, txtKodeBarang.Text)
            Me.TbL_BarangTableAdapter.UpdateQtyG1(qtyawal, txtKodeBarang.Text)
        End If
    End Sub

    Sub warehouse()
        Try
            Dim cekdata As Integer
            Try
                cekdata = TbL_Alokasi_PenjualanTableAdapter.CekKodePenjualanKodeBarang(txtKodePenjualan.Text, txtKodeBarang.Text)
            Catch ex As Exception
                cekdata = 0
            End Try
            If cekdata = 0 Then
                TbL_Alokasi_PenjualanTableAdapter.InsertQuery(txtKodePenjualan.Text, txtKodeBarang.Text, txtQty.Text, txtQty.Text, 0)
            Else
                TbL_Alokasi_PenjualanTableAdapter.UpdateG1(txtQty.Text, txtKodePenjualan.Text, txtKodeBarang.Text)
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
        sql = "SELECT Total_Qty, G1, G2 FROM TBL_Alokasi_Penjualan WHERE Kode_Penjualan='" & FRM_Penjualan.txtKodePenjualan.Text & "' AND Kode_Barang='" & kodebarangawal & "'"
        cmd = New SqlCommand(sql, cn)
        reader = cmd.ExecuteReader
        reader.Read()
        totalqty = reader(0)
        g1 = reader(1)
        g2 = reader(2)
        reader.Close()
        cn.Close()
        Dim posisi As Integer = CInt(FRM_Penjualan.BindingNavigatorPositionItem.Text)
        Dim jlhitem As Integer
        Dim totalqtyjual As Decimal
        Dim totalharga As Long
        If txtKodeBarang.Text = kodebarangawal Then
            If CDec(txtQty.Text) <> qtyawal Then
                If CDec(txtQty.Text) = 0 Then
                    If MessageBox.Show("Item penjualan akan dihapus dari database, yakin untuk melanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        RestoreItemQtyNol()
                    End If
                Else
                    TbL_Penjualan_DetailTableAdapter.UpdateQuery(CLng(txtHargaJual.Text), CDec(txtQty.Text), CDec(txtDiscPersen.Text), CLng(txtDiscRupiah.Text), CLng(txtSubtotal.Text), txtKodePenjualan.Text, txtNo.Text)
                    TbL_BarangTableAdapter.UpdateQty(qtyawal - CDec(txtQty.Text), txtKodeBarang.Text)
                    TbL_BarangTableAdapter.UpdateQtyG1(qtyawal - CDec(txtQty.Text), txtKodeBarang.Text)
                    TbL_Alokasi_PenjualanTableAdapter.UpdateG1(CDec(txtQty.Text) - qtyawal, txtKodePenjualan.Text, txtKodeBarang.Text)
                End If
            ElseIf CLng(txtHargaJual.Text) <> hargajualawal Or CLng(txtDiscRupiah.Text) <> discrpawal Or CLng(txtSubtotal.Text) <> subtotalawal Then
                'Me.TbL_Penjualan_HeaderTableAdapter.UpdateQuery(FRM_Penjualan.txtCustomer.Text, FRM_Penjualan.dtpTanggal.Value, jlhitem, totalqtyjual, totalharga, FRM_Penjualan.txtKodeSales.Text, txtNoBon.Text, txtKodePenjualan.Text)
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
                    TbL_Penjualan_DetailTableAdapter.UpdateQuery2(txtKodeBarang.Text, CLng(txtHargaJual.Text), CDec(txtQty.Text), CDec(txtDiscPersen.Text), CLng(txtDiscRupiah.Text), CLng(txtSubtotal.Text), txtKodePenjualan.Text, txtNo.Text)
                    Me.TbL_Alokasi_PenjualanTableAdapter.DeletePerItem(txtKodePenjualan.Text, kodebarangawal)
                    Me.TbL_BarangTableAdapter.UpdateQty(qtyawal, kodebarangawal)
                    If qtyawal = g1 Then
                        Me.TbL_BarangTableAdapter.UpdateQtyG1(g1, kodebarangawal)
                    Else
                        Me.TbL_BarangTableAdapter.UpdateQtyG1(g1, kodebarangawal)
                        Me.TbL_BarangTableAdapter.UpdateQtyG2(g2, kodebarangawal)
                    End If
                Else
                    TbL_Penjualan_DetailTableAdapter.UpdateQuery2(txtKodeBarang.Text, CLng(txtHargaJual.Text), CDec(txtQty.Text), CDec(txtDiscPersen.Text), CLng(txtDiscRupiah.Text), CLng(txtSubtotal.Text), txtKodePenjualan.Text, txtNo.Text)
                    TbL_Alokasi_PenjualanTableAdapter.UpdateG1(qtyawal * -1, txtKodePenjualan.Text, kodebarangawal)
                    Me.TbL_BarangTableAdapter.UpdateQty(qtyawal, kodebarangawal)
                    Me.TbL_BarangTableAdapter.UpdateQtyG1(qtyawal, kodebarangawal)
                End If
                'end here

                warehouse()
                Me.TbL_BarangTableAdapter.UpdateQty(txtQty.Text * -1, txtKodeBarang.Text)
                Me.TbL_BarangTableAdapter.UpdateQtyG1(txtQty.Text * -1, txtKodeBarang.Text)
                'cek harga default dengan harga customer
                Dim cekharga As Long = txtHargaJual.Text
                Try
                    cekdata = Me.TbL_Harga_CustomerTableAdapter.CekData(FRM_Penjualan.txtCustomer.Text, txtKodeBarang.Text)
                Catch ex As Exception
                    cekdata = 0
                End Try
                If cekdata = 0 Then
                    TbL_Harga_CustomerTableAdapter.InsertQuery(FRM_Penjualan.txtCustomer.Text, txtKodeBarang.Text, cekharga)
                Else
                    If hargabaru <> cekharga Then
                        TbL_Harga_CustomerTableAdapter.UpdateHargaJual(cekharga, FRM_Penjualan.txtCustomer.Text, txtKodeBarang.Text)
                    End If
                End If
            Else
                MessageBox.Show("Kode Barang tidak terdaftar pada database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtKodeBarang.Clear()
                Me.txtKodeBarang.Focus()
            End If
        End If
        Try
            jlhitem = Me.TbL_Penjualan_DetailTableAdapter.BanyakItem(txtKodePenjualan.Text)
        Catch ex As Exception
            jlhitem = 0
        End Try
        Try
            totalqtyjual = Me.TbL_Penjualan_DetailTableAdapter.TotalQty(txtKodePenjualan.Text)
        Catch ex As Exception
            totalqtyjual = 0
        End Try
        Try
            totalharga = Me.TbL_Penjualan_DetailTableAdapter.TotalHarga(txtKodePenjualan.Text)
        Catch ex As Exception
            totalharga = 0
        End Try
        TbL_Penjualan_HeaderTableAdapter.UpdateItemQtyHarga(jlhitem, totalqtyjual, totalharga, txtKodePenjualan.Text)
        If FRM_Penjualan.txtJenisPmb.Text = "KREDIT" Then
            Dim sisabayar As Long = totalharga - CLng(FRM_Penjualan.txtPmb.Text)
            TbL_Penjualan_HeaderTableAdapter.UpdatePembayaran("KREDIT", CLng(FRM_Penjualan.txtPmb.Text), sisabayar, FRM_Penjualan.txtNoBon.Text, FRM_Penjualan.txtBiayaLain.Text, FRM_Penjualan.txtDiskon.Text, txtKodePenjualan.Text)
            TbL_PiutangTableAdapter.UpdateTotalPiutang(totalharga, txtKodePenjualan.Text)
            Dim sisahutang As Long
            Try
                sisahutang = TbL_PiutangTableAdapter.GetSisaPiutang(txtKodePenjualan.Text)
            Catch ex As Exception
                sisahutang = 0
            End Try
            If sisahutang <= 0 Then
                TbL_PiutangTableAdapter.UpdateStatus("L", txtKodePenjualan.Text)
            Else
                TbL_PiutangTableAdapter.UpdateStatus("BL", txtKodePenjualan.Text)
            End If
        ElseIf FRM_Penjualan.txtJenisPmb.Text = "CASH" Then
            TbL_Penjualan_HeaderTableAdapter.UpdatePembayaran("CASH", totalharga, 0, FRM_Penjualan.txtNoBon.Text, FRM_Penjualan.txtBiayaLain.Text, FRM_Penjualan.txtDiskon.Text, txtKodePenjualan.Text)
        End If
        FRM_Penjualan.TBL_Penjualan_HeaderTableAdapter.Fill(FRM_Penjualan.Db_POS_CNDataSet.TBL_Penjualan_Header)
        FRM_Penjualan.TbL_Penjualan_DetailTableAdapter.Fill(FRM_Penjualan.Db_POS_CNDataSet.TBL_Penjualan_Detail)
        FRM_Penjualan.Query_PenjualanTableAdapter.Fill(FRM_Penjualan.Db_POS_CNDataSet.Query_Penjualan)
        FRM_Penjualan.TBLPenjualanHeaderBindingSource.Position = posisi - 1
        MessageBox.Show("Data item penjualan berhasil diedit", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        tutupform(Me)
    End Sub
End Class