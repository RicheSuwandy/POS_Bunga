Imports System.Data.SqlClient
Public Class FRM_Pembelian
    Dim status As String
    Dim diskonpersen As Decimal
    Dim diskonrupiah As Long
    Dim hargabaru As Long
    Dim hargadefault As Long
    Dim kodebarang As String
    Dim cekdata As Integer
    Dim kuanti As Decimal
    Dim cekcash As Boolean

    Sub nonaktifdetail()
        txtBarcodeBarang.Enabled = False
        txtIdDetail.Enabled = False
        txtQty.Enabled = False
        txtDiskonPersenDetail.Enabled = False
        txtDiskonRpDetail.Enabled = False
        txtTotalDetail.Enabled = False
        txtHargaJual.Enabled = False
        btnAdd.Enabled = False
        btnReset.Enabled = False
    End Sub

    Sub aktifdetail()
        txtBarcodeBarang.Enabled = True
        txtIdDetail.Enabled = True
        txtQty.Enabled = True
        txtDiskonPersenDetail.Enabled = True
        txtDiskonRpDetail.Enabled = True
        txtTotalDetail.Enabled = True
        txtHargaJual.Enabled = True
        btnAdd.Enabled = True
        btnReset.Enabled = True
        txtCustomer.Enabled = True
    End Sub

    Sub cekNamaSupplier()
        If txtCustomer.Text = "" Then
            txtNama.Text = ""
        Else
            txtNama.Text = TBL_SupplierTableAdapter.LoadNama(txtCustomer.Text)
        End If
    End Sub

    Sub cekNamaBarangDetail()
        If txtIdDetail.Text = "" Or txtBarcodeBarang.Text = "" Then
            txtNamaDetail.Text = ""
        ElseIf IsNumeric(txtIdDetail.Text) Then
            txtNamaDetail.Text = TBL_Barang_DetailTableAdapter.LoadNamaDetail(txtIdDetail.Text)
        End If
    End Sub

    Sub CekNamaBarang()
        If txtBarcodeBarang.Text = "" Then
            txtNamaBarang.Text = ""
        Else
            txtNamaBarang.Text = TBL_BarangTableAdapter.LoadNamaBarang(txtBarcodeBarang.Text)
        End If
    End Sub

    Sub warehouse()
        Try
            Dim cekdata As Integer
            koneksi()
            Try
                cekdata = TbL_Alokasi_pembelianTableAdapter.CekKodepembelianKodeBarang(txtKodepembelian.Text, txtBarcodeBarang.Text)
            Catch ex As Exception
                cekdata = 0
            End Try
            'If cekdata = 0 Then
            '    sql = "SELECT Kode_Barang, Sum(Qty_Jual) FROM TBL_pembelian_Detail WHERE Kode_pembelian='" & txtKodepembelian.Text & "' GROUP BY Kode_Barang"
            '    cmd = New SqlCommand(sql, cn)
            '    cmd.ExecuteNonQuery()
            '    reader = cmd.ExecuteReader()
            '    While reader.Read
            '        TbL_Alokasi_pembelianTableAdapter.InsertQuery(txtKodepembelian.Text, reader(0), reader(1), reader(1), 0)
            '    End While
            'End If
            'reader.Close()
            'cn.Close()
            If cekdata = 0 Then
                TbL_Alokasi_pembelianTableAdapter.InsertQuery(txtKodepembelian.Text, txtBarcodeBarang.Text, txtQty.Text, txtQty.Text, 0)
            Else
                TbL_Alokasi_pembelianTableAdapter.UpdateG1(txtQty.Text, txtKodepembelian.Text, txtBarcodeBarang.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("Error :" & ex.ToString(), "Error")
        End Try
    End Sub
    Private Sub txtCustomer_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCustomer.KeyDown
        Try
            Dim katakunci As String
            If e.KeyValue = 13 Then
                If txtCustomer.Text = "" Then
                    Me.TBL_SupplierTableAdapter.Fill(Db_POS_CNDataSet.TBL_Supplier)
                ElseIf Mid(txtCustomer.Text, 1, 1) = "*" And Mid(txtCustomer.Text, Len(txtCustomer.Text), 1) = "*" Then
                    katakunci = Mid(txtCustomer.Text, 2, Len(txtCustomer.Text) - 2)
                    Me.TBL_SupplierTableAdapter.FillByKodeSupplier(Db_POS_CNDataSet.TBL_Supplier, katakunci)
                Else
                    katakunci = Me.txtCustomer.Text
                    Me.TBL_SupplierTableAdapter.FillByNama(Db_POS_CNDataSet.TBL_Supplier, katakunci)
                End If
                Me.dgvSupplier.Visible = True
                Me.dgvSupplier.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.ToString, "Error")
        End Try
        If e.KeyCode = Keys.Tab Then
            txtBarcodeBarang.Focus()
        End If
    End Sub

    Private Sub dgvCustomer_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvSupplier.KeyDown
        Try
            If e.KeyValue = 13 Then
                txtCustomer.Text = dgvSupplier.GetData(dgvSupplier.RowSel, 1)
                txtNama.Text = dgvSupplier.GetData(dgvSupplier.RowSel, 2)
                Me.dgvSupplier.Visible = False
                txtBarcodeBarang.Focus()
            End If
            If e.KeyCode = Keys.Escape Then
                dgvSupplier.Visible = False
                txtCustomer.Clear()
                txtCustomer.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.ToString, "Error")
        End Try
    End Sub

    Private Sub FRM_Pembelian_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        tsRefresh.PerformClick()
    End Sub

    Private Sub FRM_pembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_POS_CNDataSet.TBL_Barang_Detail' table. You can move, or remove it, as needed.
        Me.TBL_Barang_DetailTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Barang_Detail)
        'TODO: This line of code loads data into the 'Db_POS_CNDataSet.Query_Pembelian' table. You can move, or remove it, as needed.
        Me.Query_PembelianTableAdapter.Fill(Me.Db_POS_CNDataSet.Query_Pembelian)
        'TODO: This line of code loads data into the 'Db_POS_CNDataSet.TBL_Pembelian_Detail' table. You can move, or remove it, as needed.
        Me.TBL_Pembelian_DetailTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Pembelian_Detail)
        'TODO: This line of code loads data into the 'Db_POS_CNDataSet.TBL_Pembelian_Header' table. You can move, or remove it, as needed.
        Me.TBL_Pembelian_HeaderTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Pembelian_Header)
        'TODO: This line of code loads data into the 'Db_POS_CNDataSet.TBL_Supplier' table. You can move, or remove it, as needed.
        Me.TBL_SupplierTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Supplier)
        'TODO: This line of code loads data into the 'Db_POS_CNDataSet.TBL_Supplier' table. You can move, or remove it, as needed.
        Me.TBL_SupplierTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Supplier)
        Me.TBL_Pembelian_HeaderTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Pembelian_Header)
        Me.TBL_Pembelian_DetailTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Pembelian_Detail)
        Me.TBL_BarangTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Barang)
        Me.Query_PembelianTableAdapter.Fill(Me.Db_POS_CNDataSet.Query_Pembelian)
        'dgvBarang.RowTemplate.Height = 75
        cekNamaSupplier()
        nonaktifdetail()
        status = "update"
        cekcash = False
    End Sub

    Private Sub txtBarcodeBarang_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarcodeBarang.KeyDown
        Try
            Dim katakunci As String
            If e.KeyValue = 13 Then
                If txtBarcodeBarang.Text = "" Then
                    Me.TBL_BarangTableAdapter.Fill(Db_POS_CNDataSet.TBL_Barang)
                ElseIf Mid(txtBarcodeBarang.Text, 1, 1) = "*" And Mid(txtBarcodeBarang.Text, Len(txtBarcodeBarang.Text), 1) = "*" Then
                    katakunci = Mid(txtBarcodeBarang.Text, 2, Len(txtBarcodeBarang.Text) - 2)
                    Me.TBL_BarangTableAdapter.FillByKodeBarang(Db_POS_CNDataSet.TBL_Barang, katakunci)
                ElseIf txtBarcodeBarang.Text <> "" Then
                    katakunci = Me.txtBarcodeBarang.Text
                    Me.TBL_BarangTableAdapter.FillByNamaBarang(Db_POS_CNDataSet.TBL_Barang, katakunci)
                End If
                Me.dgvBarang.Visible = True
                Me.dgvBarang.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.ToString, "Error")
        End Try
    End Sub

    Private Sub tsTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsTambah.Click
        cboCash.Enabled = True
        cekcash = False
        cboCash.Checked = False
        jenispmbbeli = ""
        pmbbeli = 0
        sisapmbbeli = 0
        diskonpersen = 0
        diskonrupiah = 0
        cekdata = 0
        btnKredit.Enabled = True
        btnAdd.Enabled = True
        Me.TBL_Pembelian_HeaderTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Pembelian_Header)
        TBLPembelianHeaderBindingSource.AddNew()
        Me.BindingNavigatorPositionItem.Enabled = False
        Me.BindingNavigatorMovePreviousItem.Enabled = False
        Me.BindingNavigatorMoveFirstItem.Enabled = False
        dtpTanggal.Value = Now
        Me.tsCetak.Enabled = False
        btnCetakFaktur.Enabled = False
        status = "simpan"
        Dim blnthn As String = Now.ToString("MMyy")
        Try
            Dim kodepembelian As Integer = CInt(Me.TBL_Pembelian_HeaderTableAdapter.KodePembelianBaru(blnthn))
            Me.txtKodePembelian.Text = "PMB-" & blnthn & Format(kodepembelian, "00000")
        Catch ex As Exception
            Me.txtKodePembelian.Text = "PMB-" & blnthn & "00001"
        End Try
        Try
            Me.TBL_Pembelian_HeaderTableAdapter.TambahPembelian(Me.txtKodepembelian.Text)
        Catch ex As Exception
            MessageBox.Show("Gagal menambahkan kode pembelian ke database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.txtCustomer.ReadOnly = False
        Me.txtBarcodeBarang.ReadOnly = False
        Me.txtQty.ReadOnly = False
        Me.txtDiskonPersenDetail.ReadOnly = False
        Me.txtDiskonRpDetail.ReadOnly = False
        Me.btnAdd.Enabled = True
        Me.txtJumlahItem.ReadOnly = False
        txtBarcodeBarang.Clear()
        txtQty.Text = 0
        txtHargaJual.Text = 0
        txtDiskonPersenDetail.Text = 0
        txtDiskonRpDetail.Text = 0
        txtTotalDetail.Text = 0
        txtJumlahItem.Text = 0
        txtTotalQty.Text = 0
        setnol(txtTotalHarga)
        txtTotalBayar.Text = 0
        Me.txtNoFakturSup.Focus()
        tsTambah.Enabled = False
        tsHapus.Enabled = False
        tsWareHouse.Enabled = False
        tsRefresh.Text = "&Batal"
        'dgvpembelian.AllowDelete = True
        aktifdetail()
    End Sub

    Private Sub dgvBarang_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvBarang.KeyDown
        Try
            If e.KeyValue = 13 Then
                Dim rowindeks As Integer = Me.dgvBarang.CurrentCell.RowIndex
                txtBarcodeBarang.Text = dgvBarang.Item(0, rowindeks).Value
                Me.dgvBarang.Visible = False
                Try
                    cekdata = Me.TbL_Harga_SupplierTableAdapter.CekData(txtCustomer.Text, txtBarcodeBarang.Text)
                Catch ex As Exception
                    cekdata = 0
                End Try
                If cekdata = 1 Then
                    hargabaru = Me.TbL_Harga_SupplierTableAdapter.HargaBeli(txtCustomer.Text, txtBarcodeBarang.Text)
                    txtHargaJual.Text = hargabaru.ToString("C0")
                Else
                    txtHargaJual.Text = CLng(dgvBarang.Item(6, rowindeks).Value).ToString("C0")
                End If
                txtTotalDetail.Text = CLng(txtHargaJual.Text).ToString("C0")
                txtIdDetail.Focus()
            End If
            If e.KeyCode = Keys.Escape Then
                dgvBarang.Visible = False
                txtBarcodeBarang.Clear()
                txtBarcodeBarang.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.ToString, "Error")
        End Try
    End Sub

    Private Sub txtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged, txtHargaJual.TextChanged
        Try
            Dim totalhargadetail As Long = (txtQty.Text * txtHargaJual.Text) - (txtDiskonRpDetail.Text * txtQty.Text)
            txtTotalDetail.Text = CLng(totalhargadetail).ToString("C0")
        Catch
            txtTotalDetail.Text = 0
        End Try
    End Sub

    Private Sub txtDiskonPersenDetail_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiskonPersenDetail.Leave
        Try
            If txtDiskonPersenDetail.Text = "" Then
                txtDiskonPersenDetail.Text = 0
                txtDiskonRpDetail.Text = 0
            End If
        Catch ex As Exception
            txtDiskonPersenDetail.Text = 0
            txtDiskonRpDetail.Text = 0
        End Try
    End Sub

    Private Sub txtDiskonPersenDetail_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiskonPersenDetail.KeyPress, txtQty.KeyPress, txtHargaJual.KeyPress, txtDiskonRpDetail.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Or e.KeyChar = Chr(46) Or e.KeyChar = Chr(44) Then
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtDiskonPersenDetail_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDiskonPersenDetail.KeyUp
        Try
            Try
                txtDiskonRpDetail.Text = txtDiskonPersenDetail.Text / 100 * txtHargaJual.Text
                Dim totalhargadetail As Long = (txtQty.Text * txtHargaJual.Text) - (txtDiskonRpDetail.Text * txtQty.Text)
                txtTotalDetail.Text = CLng(totalhargadetail).ToString("C0")
            Catch
                txtDiskonRpDetail.Text = 0
                Dim totalhargadetail As Decimal = (txtQty.Text * txtHargaJual.Text)
                txtTotalDetail.Text = CLng(totalhargadetail).ToString("C0")
            End Try
        Catch
            txtDiskonPersenDetail.Text = 0
            txtDiskonRpDetail.Text = 0
            Dim totalhargadetail As Long = (txtQty.Text * txtHargaJual.Text)
            txtTotalDetail.Text = CLng(totalhargadetail).ToString("C0")
        End Try
    End Sub

    Private Sub txtDiskonRpDetail_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiskonRpDetail.Leave
        Try
            If txtDiskonRpDetail.Text <> "" Then
                txtDiskonRpDetail.Text = CDec(txtDiskonRpDetail.Text).ToString("C2")
            Else
                txtDiskonRpDetail.Text = 0
            End If
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.ToString, "Error")
        End Try
    End Sub

    Private Sub txtDiskonRpDetail_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiskonRpDetail.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Or e.KeyChar = Chr(46) Or e.KeyChar = Chr(44) Then
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtDiskonRpDetail_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDiskonRpDetail.KeyUp
        Try
            Try
                txtDiskonPersenDetail.Text = txtDiskonRpDetail.Text / txtHargaJual.Text * 100
                Dim totalhargadetail As Long = (txtQty.Text * txtHargaJual.Text) - (txtDiskonRpDetail.Text * txtQty.Text)
                txtTotalDetail.Text = CLng(totalhargadetail).ToString("C0")
            Catch ex As Exception
                txtDiskonPersenDetail.Text = 0
                Dim totalhargadetail As Long = (txtQty.Text * txtHargaJual.Text)
                txtTotalDetail.Text = CLng(totalhargadetail).ToString("C0")
            End Try
        Catch
            txtDiskonPersenDetail.Text = 0
            txtDiskonRpDetail.Text = 0
            Dim totalhargadetail As Long = (txtQty.Text * txtHargaJual.Text)
            txtTotalDetail.Text = CLng(totalhargadetail).ToString("C0")
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtBarcodeBarang.Text <> "" And txtIdDetail.Text <> "" And txtQty.Text <> "" And CDec(txtQty.Text) > 0 And txtKodePembelian.Text <> "" And txtCustomer.Text <> "" And txtHargaJual.Text <> "" Then
            Dim nobaris As Integer
            Dim cekkode As Integer = Me.TBL_BarangTableAdapter.CekKodeBarang(txtBarcodeBarang.Text)
            If txtDiskonPersenDetail.Text = "" Or txtDiskonRpDetail.Text = "" Then
                txtDiskonPersenDetail.Text = 0
                txtDiskonRpDetail.Text = 0
            End If
            If cekkode = 1 Then
                Dim jlhitem As Integer
                Dim totalqty As Decimal
                Dim totalharga As Long
                Dim kodebeli As String = txtKodePembelian.Text
                Try
                    nobaris = Me.TBL_Pembelian_DetailTableAdapter.NoBarisBaru(Me.txtKodePembelian.Text)
                    If nobaris = 0 Then nobaris = 1
                Catch ex As Exception
                    nobaris = 1
                End Try
                Me.TBL_Pembelian_DetailTableAdapter.InsertQuery(txtKodePembelian.Text, nobaris, txtBarcodeBarang.Text, txtIdDetail.Text, txtHargaJual.Text, txtQty.Text, txtDiskonPersenDetail.Text, txtDiskonRpDetail.Text, txtTotalDetail.Text)
                Try
                    jlhitem = Me.TBL_Pembelian_DetailTableAdapter.BanyakItem(txtKodePembelian.Text)
                Catch ex As Exception
                    jlhitem = 0
                End Try
                Try
                    totalqty = Me.TBL_Pembelian_DetailTableAdapter.TotalQty(txtKodePembelian.Text)
                Catch ex As Exception
                    totalqty = 0
                End Try
                Try
                    totalharga = Me.TBL_Pembelian_DetailTableAdapter.TotalHarga(txtKodePembelian.Text)
                Catch ex As Exception
                    totalharga = 0
                End Try
                warehouse()
                Me.TBL_BarangTableAdapter.UpdateQty(txtQty.Text, txtBarcodeBarang.Text)
                Me.TBL_BarangTableAdapter.UpdateQtyG1(txtQty.Text, txtBarcodeBarang.Text)
                Me.TBL_Barang_DetailTableAdapter.UpdateQty(txtQty.Text, txtIdDetail.Text)
                Me.TBL_Pembelian_HeaderTableAdapter.UpdateQuery(txtNoFakturSup.Text, txtCustomer.Text, dtpTanggal.Value, jlhitem, totalqty, totalharga, txtKodePembelian.Text)
                'cek harga default dengan harga / customer
                Dim cekharga As Long = txtHargaJual.Text
                Try
                    cekdata = Me.TbL_Harga_SupplierTableAdapter.CekData(txtCustomer.Text, txtBarcodeBarang.Text)
                Catch ex As Exception
                    cekdata = 0
                End Try
                If cekdata = 0 Then
                    TbL_Harga_SupplierTableAdapter.InsertQuery(txtCustomer.Text, txtBarcodeBarang.Text, cekharga)
                Else
                    If hargabaru <> cekharga Then
                        TbL_Harga_SupplierTableAdapter.UpdateHargaBeli(cekharga, txtCustomer.Text, txtBarcodeBarang.Text)
                    End If
                End If
                lblKembali.Text = "TOTAL"
                'reset textbox
                txtBarcodeBarang.Clear()
                txtIdDetail.Clear()
                txtQty.Text = 0
                txtHargaJual.Text = 0
                txtDiskonPersenDetail.Text = 0
                txtDiskonRpDetail.Text = 0
                txtTotalDetail.Text = 0
                Me.txtBarcodeBarang.Focus()
                txtQty.ReadOnly = False
                Me.TBL_Pembelian_HeaderTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Pembelian_Header)
                Me.TBL_Pembelian_DetailTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Pembelian_Detail)
                Me.Query_PembelianTableAdapter.Fill(Me.Db_POS_CNDataSet.Query_Pembelian)
                TBLPembelianHeaderBindingSource.Position = TBLPembelianHeaderBindingSource.Find("Kode_Pembelian", kodebeli)
            Else
                MessageBox.Show("Kode Barang tidak terdaftar pada database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtBarcodeBarang.Clear()
                Me.txtBarcodeBarang.Focus()
            End If
        Else
            MessageBox.Show("Kolom bertanda * wajib diisi", "Error")
        End If
    End Sub

    Private Sub tsSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSimpan.Click
        If status = "update" Then
            If txtCustomer.Text <> "" Then
                Me.TBL_Pembelian_HeaderTableAdapter.UpdateFakturSupTgl(txtNoFakturSup.Text, txtCustomer.Text, dtpTanggal.Value, txtKodePembelian.Text)
            Else
                MessageBox.Show("Kolom bertanda * wajib diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If jenispmbbeli <> "" Then
                If txtCustomer.Text <> "" And txtKodePembelian.Text <> "" Then
                    'Try
                    Me.TBL_Pembelian_HeaderTableAdapter.UpdatePembayaran(txtJenisPmb.Text, txtPmb.Text, txtSisa.Text, txtKodePembelian.Text)
                    'Catch ex As Exception
                    '    MessageBox.Show("Gagal simpan ke database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'End Try
                    If jenispmbbeli = "CASH" Then
                        Me.TbL_HutangTableAdapter.DeleteQuery(txtKodePembelian.Text)
                    End If
                    Me.BindingNavigatorPositionItem.Enabled = True
                    Me.BindingNavigatorMovePreviousItem.Enabled = True
                    Me.BindingNavigatorMoveFirstItem.Enabled = True
                    tsTambah.Enabled = True
                    tsHapus.Enabled = True
                    tsRefresh.Enabled = True
                    tsCetak.Enabled = True
                    tsWareHouse.Enabled = True
                    btnCetakFaktur.Enabled = True
                    Me.tsRefresh.Text = "&Refresh"
                    Me.txtBarcodeBarang.Focus()
                    dgvPembelian.AllowUserToDeleteRows = False
                    nonaktifdetail()
                    cekcash = False
                    cboCash.Enabled = False
                    cboCash.Checked = False
                    jenispmbbeli = ""
                    pmbbeli = 0
                    sisapmbbeli = 0
                    cboCash.Enabled = False
                    btnKredit.Enabled = False
                    status = "update"
                Else
                    MessageBox.Show("Kolom bertanda * wajib diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Tentukan jenis pembayaran", "Error")
            End If
        End If
    End Sub
    Sub HapusSemuaItemPasok()
        If dgvPembelian.Rows.Count > 0 Then
            Dim nobaris As Integer
            Dim kodebarang As String
            Dim qtybeli As Decimal
            Dim iddetail As Integer
            For i As Integer = 0 To dgvPembelian.RowCount - 1
                nobaris = dgvPembelian.Rows(i).Cells(0).Value
                kodebarang = dgvPembelian.Rows(i).Cells(1).Value
                qtybeli = dgvPembelian.Rows(i).Cells(6).Value
                iddetail = dgvPembelian.Rows(i).Cells(3).Value
                Me.TBL_BarangTableAdapter.UpdateQty(qtybeli * -1, kodebarang)
                Me.TBL_Barang_DetailTableAdapter.UpdateQty(qtybeli * -1, iddetail)
            Next
        End If
    End Sub

    Sub RestoreG1G2()
        Dim cekdata As Integer
        koneksi()
        Try
            cekdata = TbL_Alokasi_pembelianTableAdapter.CekKodepembelian(txtKodepembelian.Text)
        Catch ex As Exception
            cekdata = 0
        End Try
        If cekdata > 0 Then
            sql = "SELECT Kode_Barang, G1, G2 FROM TBL_Alokasi_pembelian WHERE Kode_pembelian='" & txtKodepembelian.Text & "'"
            koneksi()
            cmd = New SqlCommand(sql, cn)
            reader = cmd.ExecuteReader()
            While reader.Read
                TBL_BarangTableAdapter.UpdateQtyG1(reader(1) * -1, reader(0))
                TBL_BarangTableAdapter.UpdateQtyG2(reader(2) * -1, reader(0))
            End While
            reader.Close()
            cn.Close()
        End If
    End Sub

    Private Sub tsHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsHapus.Click
        If BindingNavigatorPositionItem.Text <> 0 Then
            Dim cekhapus As Integer
            Try
                cekhapus = TbL_Retur_Pembelian_HeaderTableAdapter.CekKodePembelian(txtKodePembelian.Text)
            Catch ex As Exception
                cekhapus = 0
            End Try
            If cekhapus = 0 Then
                If MessageBox.Show("Yakin akan menghapus data pembelian dengan kode : " & Me.txtKodePembelian.Text & " ?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.Yes Then
                    HapusSemuaItemPasok()
                    RestoreG1G2()
                    dgvPembelian.AllowUserToDeleteRows = False
                    nonaktifdetail()
                    cboCash.Enabled = False
                    jenispmbbeli = ""
                    pmbbeli = 0
                    sisapmbbeli = 0
                    cekcash = False
                    cboCash.Enabled = False
                    cboCash.Checked = False
                    btnKredit.Enabled = False
                    status = "update"
                    Me.TBL_Pembelian_DetailTableAdapter.DeleteQuery(txtKodePembelian.Text)
                    Me.TBL_Pembelian_HeaderTableAdapter.DeleteQuery(txtKodePembelian.Text)
                    Me.TbL_HutangTableAdapter.DeleteQuery(txtKodePembelian.Text)
                    Me.TbL_Alokasi_PembelianTableAdapter.DeleteQuery(txtKodePembelian.Text)
                    Me.TBLPembelianHeaderBindingSource.RemoveAt(CInt(BindingNavigatorPositionItem.Text) - 1)
                    Me.BindingNavigatorPositionItem.Enabled = True
                    Me.BindingNavigatorMovePreviousItem.Enabled = True
                    Me.BindingNavigatorMoveFirstItem.Enabled = True
                End If
            Else
                MessageBox.Show("Data pembelian tidak dapat dihapus, kode pembelian telah dipakai di retur pembelian")
            End If
        Else
            MessageBox.Show("Anda telah berada di record 0", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub tsRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsRefresh.Click
        If tsRefresh.Text = "&Refresh" Then
            Me.TBL_Pembelian_HeaderTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Pembelian_Header)
            Me.TBL_Pembelian_DetailTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Pembelian_Detail)
            Me.Query_PembelianTableAdapter.Fill(Me.Db_POS_CNDataSet.Query_Pembelian)
            tsTambah.Enabled = True
            tsSimpan.Enabled = True
            tsHapus.Enabled = True
            tsRefresh.Text = "&Refresh"
            tsRefresh.Enabled = True
            lblKembali.Text = "TOTAL"
        Else
            If MessageBox.Show("Yakin akan membatalkan data pembelian dengan kode : " & Me.txtKodepembelian.Text & " ?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.Yes Then
                HapusSemuaItemPasok()
                RestoreG1G2()
                Me.TBL_Pembelian_DetailTableAdapter.DeleteQuery(txtKodepembelian.Text)
                Me.TBL_Pembelian_HeaderTableAdapter.DeleteQuery(txtKodepembelian.Text)
                Me.TbL_HutangTableAdapter.DeleteQuery(txtKodePembelian.Text)
                Me.TbL_Alokasi_pembelianTableAdapter.DeleteQuery(txtKodepembelian.Text)
                Me.TBLPembelianHeaderBindingSource.RemoveAt(CInt(BindingNavigatorPositionItem.Text) - 1)
                Me.BindingNavigatorPositionItem.Enabled = True
                Me.BindingNavigatorMovePreviousItem.Enabled = True
                Me.BindingNavigatorMoveFirstItem.Enabled = True
                tsRefresh.Text = "&Refresh"
                tsTambah.Enabled = True
                tsHapus.Enabled = True
                dgvSupplier.Visible = False
                dgvBarang.Visible = False
                tsWareHouse.Enabled = True
                txtBarcodeBarang.Clear()
                txtQty.Clear()
                txtHargaJual.Clear()
                txtDiskonPersenDetail.Clear()
                txtDiskonRpDetail.Clear()
                txtTotalDetail.Clear()
                txtIdDetail.Clear()
                cekcash = False
                cboCash.Enabled = False
                cboCash.Checked = False
                btnKredit.Enabled = False
                nonaktifdetail()
            End If
        End If
        Me.tsCetak.Enabled = True
        btnCetakFaktur.Enabled = True
    End Sub

    Private Sub cboCash_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCash.CheckedChanged
        If cekcash Then
            nonaktifdetail()
            If cboCash.Checked Then
                btnKredit.Enabled = False
                txtJenisPmb.Text = "CASH"
                txtPmb.Text = txtTotalHarga.Text
                txtSisa.Text = 0
                jenispmbbeli = "CASH"
            Else
                Dim cek As Integer
                Try
                    cek = TbL_HutangTableAdapter.CekKodePembelian(txtKodePembelian.Text)
                Catch ex As Exception
                    cek = 0
                End Try
                If cek = 1 Then
                    Dim tgl As Date = TbL_HutangTableAdapter.TglPenagihan(txtKodePembelian.Text)
                    sisapmbbeli = TbL_HutangTableAdapter.TotalHutang(txtKodePembelian.Text)
                    txtSisa.Text = sisapmbbeli.ToString("C0")
                    txtPmb.Text = (txtTotalHarga.Text - sisapmbbeli).ToString("C0")
                Else
                    txtPmb.Text = 0
                    txtSisa.Text = txtTotalHarga.Text
                End If
                btnKredit.Enabled = True
                txtJenisPmb.Text = "KREDIT"
                jenispmbbeli = "KREDIT"
            End If
        End If
    End Sub

    Private Sub txtTotalBayar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTotalBayar.KeyDown
        If e.KeyValue = 13 Then
            lblKembali.Text = "KEMBALI"
            txtTotalBayar.Text = CLng(txtTotalBayar.Text).ToString("C0")
            If CDec(txtTotalBayar.Text) >= CDec(txtTotalHarga.Text) Then
                lblKembali.Visible = True
                lblTotalHarga.Text = CLng(CLng(txtTotalBayar.Text) - CLng(txtTotalHarga.Text)).ToString("C0")
            Else
                MessageBox.Show("Total yang dibayar tidak mencukupi", "Warning")
            End If
        End If
    End Sub

    Private Sub txtTotalBayar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotalBayar.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Or e.KeyChar = Chr(46) Or e.KeyChar = Chr(44) Then
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub FRM_pembelian_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            txtBarcodeBarang.Focus()
        ElseIf e.KeyCode = Keys.F2 Then
            txtHargaJual.Focus()
        ElseIf e.KeyCode = Keys.F3 Then
            If cboCash.Enabled = True Then
                cekcash = True
                If cboCash.Checked Then
                    cboCash.Checked = False
                Else
                    cboCash.Checked = True
                End If
                cboCash_CheckedChanged(Nothing, Nothing)
            End If
        ElseIf e.KeyCode = Keys.F4 Then
            If btnKredit.Enabled = True Then
                nonaktifdetail()
                FRM_Kredit_Pembelian.ShowDialog()
            End If
        ElseIf e.KeyCode = Keys.F5 Then
            If btnCetakFaktur.Enabled = True Then
                tsCetak_Click(Nothing, Nothing)
            End If
        ElseIf e.KeyCode = Keys.F6 Then
            txtTotalBayar.Focus()
        ElseIf (e.Control AndAlso (e.KeyCode = Keys.Right)) Then
            BindingNavigatorMoveNextItem.PerformClick()
        ElseIf (e.Control AndAlso (e.KeyCode = Keys.Left)) Then
            BindingNavigatorMovePreviousItem.PerformClick()
        ElseIf (e.Shift AndAlso (e.KeyCode = Keys.Right)) Then
            BindingNavigatorMoveLastItem.PerformClick()
        ElseIf (e.Shift AndAlso (e.KeyCode = Keys.Left)) Then
            BindingNavigatorMoveFirstItem.PerformClick()
        End If


    End Sub

    Private Sub btnKredit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKredit.Click
        nonaktifdetail()
        FRM_Kredit_Pembelian.ShowDialog()
    End Sub

    Private Sub txtTotalBayar_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalBayar.Leave
        lblKembali.Text = "TOTAL"
    End Sub

    Private Sub dgvpembelian_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Delete Then
            If txtBarcodeBarang.Enabled = True Then
                If dgvPembelian.Rows.Count > 0 Then
                    If MessageBox.Show("Yakin akan menghapus item pembelian?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        Dim nobaris As Integer
                        Dim kodebarang As String
                        Dim qtyjual As Decimal
                        Dim iddetail As Integer
                        Dim qtyalokasi As Decimal
                        Dim jlhitem As Integer
                        Dim totalqty As Decimal
                        Dim totalharga As Long
                        Dim rowindeks As Integer = Me.dgvPembelian.CurrentCell.RowIndex
                        nobaris = dgvPembelian.Item(0, rowindeks).Value
                        kodebarang = dgvPembelian.Item(1, rowindeks).Value
                        qtyjual = dgvPembelian.Item(6, rowindeks).Value
                        iddetail = dgvPembelian.Item(3, rowindeks).Value


                        Me.TBL_BarangTableAdapter.UpdateQty(qtyjual * -1, kodebarang)
                        Me.TBL_Barang_DetailTableAdapter.UpdateQty(qtyjual * -1, iddetail)
                        Me.TBL_Pembelian_DetailTableAdapter.DeletePerItem(txtKodePembelian.Text, nobaris)
                        Dim kodebeli As String = txtKodePembelian.Text
                        Try
                            jlhitem = Me.TBL_Pembelian_DetailTableAdapter.BanyakItem(txtKodePembelian.Text)
                        Catch ex As Exception
                            jlhitem = 0
                        End Try
                        Try
                            totalqty = Me.TBL_Pembelian_DetailTableAdapter.TotalQty(txtKodePembelian.Text)
                        Catch ex As Exception
                            totalqty = 0
                        End Try
                        Try
                            totalharga = Me.TBL_Pembelian_DetailTableAdapter.TotalHarga(txtKodePembelian.Text)
                        Catch ex As Exception
                            totalharga = 0
                        End Try
                        Me.TbL_Alokasi_PembelianTableAdapter.UpdateG1(qtyjual * -1, txtKodePembelian.Text, kodebarang)
                        Try
                            qtyalokasi = TbL_Alokasi_PembelianTableAdapter.G1Value(txtKodePembelian.Text, kodebarang)
                        Catch ex As Exception
                            qtyalokasi = 0
                        End Try
                        If qtyalokasi = 0 Then
                            TbL_Alokasi_PembelianTableAdapter.DeletePerItem(txtKodePembelian.Text, kodebarang)
                        End If
                        Me.TBL_Pembelian_HeaderTableAdapter.UpdateItemQtyHarga(jlhitem, totalqty, totalharga, txtKodePembelian.Text)
                        Me.TBL_Pembelian_HeaderTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Pembelian_Header)
                        Me.TBL_Pembelian_DetailTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Pembelian_Detail)
                        Me.Query_PembelianTableAdapter.Fill(Me.Db_POS_CNDataSet.Query_Pembelian)
                        TBLPembelianHeaderBindingSource.Position = TBLPembelianHeaderBindingSource.Find("Kode_Pembelian", kodebeli)
                    End If
                End If
            Else
                MessageBox.Show("Item pembelian tidak dapat dihapus", "Error")
            End If
        End If
    End Sub

    Private Sub tsWareHouse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsWareHouse.Click
        If BindingNavigatorPositionItem.Text <> 0 Then
            FRM_Alokasi_Barang_Pembelian.ShowDialog()
        Else
            MessageBox.Show("Anda telah berada di record 0", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cboCash_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cboCash.MouseDown
        cekcash = True
    End Sub

    Private Sub txtKataKunci_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKataKunci.KeyDown
        If e.KeyValue = 13 Then
            If txtKataKunci.Text <> "" Then
                If cboKriteria.Text = "No Faktur" Then
                    Me.TBL_Pembelian_HeaderTableAdapter.FillByKodePembelian(Me.Db_POS_CNDataSet.TBL_Pembelian_Header, txtKataKunci.Text)
                ElseIf cboKriteria.Text = "No Faktur Supplier" Then
                    Me.TBL_Pembelian_HeaderTableAdapter.FillByNoFaktur(Me.Db_POS_CNDataSet.TBL_Pembelian_Header, txtKataKunci.Text)
                End If
            Else
                Me.TBL_Pembelian_HeaderTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Pembelian_Header)
            End If
        End If
    End Sub

    Private Sub tsCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsCetak.Click
        If BindingNavigatorPositionItem.Text <> 0 Then
            FRM_RPT_Faktur_Pembelian.ShowDialog()
        Else
            MessageBox.Show("Anda telah berada di record 0", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCetakFaktur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetakFaktur.Click
        tsCetak_Click(Nothing, Nothing)
    End Sub

    Private Sub dgvPembelian_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If dgvPembelian.Rows.Count > 0 Then
            If peditpembelian = 1 Then
                Dim koderetur As String
                Dim ceknobaris As Integer
                Try
                    koderetur = TbL_Retur_Pembelian_HeaderTableAdapter.GetKodeReturByKodePembelian(txtKodePembelian.Text)
                Catch ex As Exception
                    koderetur = ""
                End Try
                If koderetur <> "" Then
                    Try
                        Dim rowindeks As Integer = Me.dgvPembelian.CurrentCell.RowIndex
                        ceknobaris = TbL_Retur_Pembelian_DetailTableAdapter.CekKodeReturNoBaris(koderetur, dgvPembelian.Item(0, rowindeks).Value)
                    Catch ex As Exception
                        ceknobaris = 0
                    End Try
                End If
                If koderetur = "" Or ceknobaris = 0 Then
                    FRM_Edit_Item_Pembelian.ShowDialog()
                Else
                    MessageBox.Show("Item pembelian tidak bisa diedit, item pembelian telah digunakan pada retur pembelian", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Anda tidak memiliki hak akses untuk mengedit item pembelian", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub btnAsc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsc.Click
        'Dim cekrefresh As Boolean = False
        'If dgvPembelian2.Rows.Count > 0 Then
        '    For i As Integer = 1 To dgvPembelian2.RowCount - 1
        '        If dgvPembelian.GetData(i, 1) <> i Then
        '            cekrefresh = True
        '            TBL_Pembelian_DetailTableAdapter.UpdateNoBaris(i, txtKodePembelian.Text, dgvPembelian.GetData(i, 1))
        '            Dim koderetur As String
        '            Try
        '                koderetur = TbL_Retur_Pembelian_HeaderTableAdapter.GetKodeReturByKodePembelian(txtKodePembelian.Text)
        '            Catch ex As Exception
        '                koderetur = ""
        '            End Try
        '            If koderetur <> "" Then
        '                Dim cekno As Integer
        '                Try
        '                    cekno = TbL_Retur_Pembelian_DetailTableAdapter.CekKodeReturNoBaris(koderetur, dgvPembelian.GetData(i, 1))
        '                Catch ex As Exception
        '                    cekno = 0
        '                End Try
        '                If cekno = 1 Then
        '                    TbL_Retur_Pembelian_DetailTableAdapter.UpdateNoBaris(i, koderetur, dgvPembelian.GetData(i, 1))
        '                End If
        '            End If
        '        End If
        '    Next
        '    If cekrefresh Then
        '        Dim kodebeli As String = txtKodePembelian.Text
        '        Me.TBL_Pembelian_HeaderTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Pembelian_Header)
        '        Me.TBL_Pembelian_DetailTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Pembelian_Detail)
        '        Me.Query_PembelianTableAdapter.Fill(Me.Db_POS_CNDataSet.Query_Pembelian)
        '        TBLPembelianHeaderBindingSource.Position = TBLPembelianHeaderBindingSource.Find("Kode_Pembelian", kodebeli)
        '    End If
        'End If
    End Sub

    Private Sub txtIdDetail_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIdDetail.KeyDown
        Dim katakunci As String
        Try
            If Trim(txtBarcodeBarang.Text) <> "" Then
                If e.KeyValue = 13 Then
                    If txtIdDetail.Text = "" Then
                        Me.TBL_Barang_DetailTableAdapter.FillByKodeBarang(Db_POS_CNDataSet.TBL_Barang_Detail, txtBarcodeBarang.Text)
                    ElseIf Mid(txtIdDetail.Text, 1, 1) = "*" And Mid(txtIdDetail.Text, Len(txtIdDetail.Text), 1) = "*" Then
                        katakunci = Mid(txtIdDetail.Text, 2, Len(txtIdDetail.Text) - 2)
                        Me.TBL_Barang_DetailTableAdapter.FillByIDDetail(Db_POS_CNDataSet.TBL_Barang_Detail, katakunci)
                    Else
                        katakunci = txtIdDetail.Text
                        Me.TBL_Barang_DetailTableAdapter.FillByNamaBarangDetail(Db_POS_CNDataSet.TBL_Barang_Detail, katakunci, txtBarcodeBarang.Text)
                    End If
                    Me.dgvBarangDetail.Visible = True
                    Me.dgvBarangDetail.Focus()
                End If
            Else
                txtBarcodeBarang.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.ToString, "Error")
        End Try
    End Sub


    Private Sub dgvBarangDetail_ColumnHeaderCellChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewColumnEventArgs) Handles dgvBarangDetail.ColumnHeaderCellChanged

    End Sub

    Private Sub dgvBarangDetail_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvBarangDetail.KeyDown
        Try
            If e.KeyValue = 13 Then
                Dim rowindeks As Integer = Me.dgvBarangDetail.CurrentCell.RowIndex
                txtIdDetail.Text = dgvBarangDetail.Item(0, rowindeks).Value
                txtNamaDetail.Text = dgvBarangDetail.Item(1, rowindeks).Value
                Me.dgvBarangDetail.Visible = False
                txtQty.Focus()
            End If
            If e.KeyCode = Keys.Escape Then
                dgvBarangDetail.Visible = False
                txtIdDetail.Clear()
                txtIdDetail.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.ToString, "Error")
        End Try
    End Sub

    Private Sub txtCustomer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomer.TextChanged
        cekNamaSupplier()
    End Sub

    Private Sub txtBarcodeBarang_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcodeBarang.TextChanged
        CekNamaBarang()
        Dim rowIndex As Integer = 1
        For Each row As DataGridViewRow In dgvBarang.Rows
            If row.Cells(1).Value.ToString.Equals(txtBarcodeBarang.Text) Then
                rowIndex = row.Index
                Exit Sub
            End If
        Next
    End Sub

    Private Sub txtIdDetail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdDetail.TextChanged
        cekNamaBarangDetail()
    End Sub

    Private Sub txtNamaBarang_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNamaBarang.KeyDown
        AddHandler txtBarcodeBarang.KeyDown, AddressOf txtBarcodeBarang_KeyDown
    End Sub

    Private Sub dgvSupplier_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvSupplier.DoubleClick
        txtCustomer.Text = dgvSupplier.GetData(dgvSupplier.RowSel, 1)
        txtNama.Text = dgvSupplier.GetData(dgvSupplier.RowSel, 2)
        Me.dgvSupplier.Visible = False
        txtBarcodeBarang.Focus()
    End Sub

    Private Sub dgvBarang_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBarang.CellDoubleClick
        Dim rowindeks As Integer = Me.dgvBarang.CurrentCell.RowIndex
        txtBarcodeBarang.Text = dgvBarang.Item(0, rowindeks).Value
        Me.dgvBarang.Visible = False
        Try
            cekdata = Me.TbL_Harga_SupplierTableAdapter.CekData(txtCustomer.Text, txtBarcodeBarang.Text)
        Catch ex As Exception
            cekdata = 0
        End Try
        If cekdata = 1 Then
            hargabaru = Me.TbL_Harga_SupplierTableAdapter.HargaBeli(txtCustomer.Text, txtBarcodeBarang.Text)
            txtHargaJual.Text = hargabaru.ToString("C0")
        Else
            txtHargaJual.Text = CLng(dgvBarang.Item(6, rowindeks).Value).ToString("C0")
        End If
        txtTotalDetail.Text = CLng(txtHargaJual.Text).ToString("C0")
        txtIdDetail.Focus()
    End Sub

    Private Sub dgvBarangDetail_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBarangDetail.CellDoubleClick
        Dim rowindeks As Integer = Me.dgvBarangDetail.CurrentCell.RowIndex
        txtIdDetail.Text = dgvBarangDetail.Item(0, rowindeks).Value
        txtNamaDetail.Text = dgvBarangDetail.Item(1, rowindeks).Value
        Me.dgvBarangDetail.Visible = False
        txtQty.Focus()
    End Sub

    'Private Sub txtCustomer_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtCustomer.MouseClick
    '    Dim katakunci As String
    '    If txtCustomer.Text = "" Then
    '        'Me.TBL_SupplierTableAdapter.Fill(Db_POS_CNDataSet.TBL_Supplier)
    '    ElseIf Mid(txtCustomer.Text, 1, 1) = "*" And Mid(txtCustomer.Text, Len(txtCustomer.Text), 1) = "*" Then
    '        katakunci = Mid(txtCustomer.Text, 2, Len(txtCustomer.Text) - 2)
    '        Me.TBL_SupplierTableAdapter.FillByNama(Db_POS_CNDataSet.TBL_Supplier, katakunci)
    '    Else
    '        katakunci = Me.txtCustomer.Text
    '        Me.TBL_SupplierTableAdapter.FillByKodeSupplier(Db_POS_CNDataSet.TBL_Supplier, katakunci)
    '    End If
    '    Me.dgvSupplier.Visible = True
    '    Me.dgvSupplier.Focus()
    'End Sub
End Class