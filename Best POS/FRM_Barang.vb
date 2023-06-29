Imports System.IO
Public Class FRM_Barang
    Dim arrImage() As Byte
    Dim status As String = "update"
    'Sub TampilSubTotal()
    '    'cfgBarang.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.AboveData
    '    'cfgBarang.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, 0, 4)
    '    'cfgBarang.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, 0, 5)
    '    'cfgBarang.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, 0, 6)
    '    'cfgBarang.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum, 0, 0, 7)
    'End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_POS_CNDataSet.TBL_Barang' table. You can move, or remove it, as needed.
        Me.TBL_BarangTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Barang)
        txtGudang1.ReadOnly = True
        txtGudang2.ReadOnly = True
        Me.cboKriteria.SelectedIndex = 0
        btnUpload.Visible = False
        btnDelete.Visible = True
        'cboBarcodeOption.SelectedIndex = 1
        txtKodeBarang.ReadOnly = True
    End Sub

    Private Sub tsTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsTambah.Click
        TBLBarangBindingSource.AddNew()
        BindingNavigatorPositionItem.Enabled = False
        BindingNavigatorMovePreviousItem.Enabled = False
        BindingNavigatorMoveFirstItem.Enabled = False
        txtKodeBarang.Clear()
        txtNamaBarang.Clear()
        txtQty.Text = 0
        txtStokAwal.Text = 0
        txtGudang1.ReadOnly = False
        txtHargaBeli.Text = 0
        txtHargaJual.Text = 0
        tsTambah.Enabled = False
        tsHapus.Enabled = False
        tsRefresh.Text = "&Batal"
        btnUbah.Visible = False
        btnUpload.Visible = True
        status = "simpan"
        btnDelete.Visible = False
        Try
            Dim barcodebarang As Integer = CInt(TBL_BarangTableAdapter.KodeBarangBaru)
            txtKodeBarang.Text = "B-" & barcodebarang.ToString("000000")
            txtKodeBarang.ReadOnly = True
            txtNamaBarang.Focus()
        Catch ex As Exception
            txtKodeBarang.Text = "B-000001"
        End Try
        txtNamaBarang.Focus()
    End Sub

    Private Sub tsSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSimpan.Click
        If txtKodeBarang.Text = "" Or txtNamaBarang.Text = "" Or txtQty.Text = "" Or txtStokAwal.Text = "" Then
            MessageBox.Show("Kolom bertanda * wajib diisi", "Error!", MessageBoxButtons.OK)
            txtKodeBarang.Focus()
        Else
            'Try
            'TBLBarangBindingSource.EndEdit()
            BindingNavigatorPositionItem.Enabled = True
            BindingNavigatorMovePreviousItem.Enabled = True
            BindingNavigatorMoveFirstItem.Enabled = True
            txtQty.ReadOnly = True
            If status = "simpan" Then
                'Try
                If PBFoto1.Image Is Nothing Then
                    TBL_BarangTableAdapter.InsertQuery(txtKodeBarang.Text, txtNamaBarang.Text, txtPartNo.Text, txtStokAwal.Text, txtQty.Text, cboSatuan.Text, txtHargaBeli.Text, txtHargaJual.Text, txtGudang1.Text, txtGudang2.Text)
                Else
                    TBL_BarangTableAdapter.InsertQueryFull(txtKodeBarang.Text, txtNamaBarang.Text, txtPartNo.Text, txtQty.Text, txtStokAwal.Text, cboSatuan.Text, txtHargaBeli.Text, txtHargaJual.Text, arrImage, txtGudang1.Text, txtGudang2.Text)
                End If
                btnUpload.Visible = False
                txtKodeBarang.ReadOnly = True
                txtQty.ReadOnly = True
                status = "update"
                'Catch ex As Exception
                'MessageBox.Show("Gagal simpan ke database", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'End Try
            Else
                TBL_BarangTableAdapter.UpdateQuery(txtNamaBarang.Text, txtPartNo.Text, cboSatuan.Text, txtHargaBeli.Text, txtHargaJual.Text, txtKodeBarang.Text)
            End If
            btnUbah.Visible = True
            btnUpload.Visible = False
            btnDelete.Visible = True
            tsTambah.Enabled = True
            tsHapus.Enabled = True
            Dim posisi As Integer = CInt(BindingNavigatorPositionItem.Text)
            Me.TBL_BarangTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Barang)
            TBLBarangBindingSource.Position = posisi - 1
            tsRefresh.Text = "&Refresh"
            txtKodeBarang.ReadOnly = True
            txtGudang1.ReadOnly = True
            ' Catch ex As Exception
            'MessageBox.Show("Gagal simpan ke database" & vbCrLf & ex.ToString, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' End Try
        End If
    End Sub

    Private Sub tsHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsHapus.Click
        If txtKodeBarang.Text <> "" Then
            Dim cekbeli As Integer = Me.TbL_Pembelian_DetailTableAdapter.CekKodeBarang(txtKodeBarang.Text)
            Dim cekjual As Integer = Me.TbL_Penjualan_DetailTableAdapter.CekKodeBarang(txtKodeBarang.Text)
            Dim cekdetail As Integer = Me.TbL_Barang_DetailTableAdapter.CekKodeBarang(txtKodeBarang.Text)
            If cekbeli = 0 And cekjual = 0 And cekdetail = 0 Then
                If MessageBox.Show("Apakah anda yakin akan menghapus barang dengan barcode : " & txtKodeBarang.Text & "?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Try
                        TBL_BarangTableAdapter.DeleteQuery(txtKodeBarang.Text)
                        Me.TBLBarangBindingSource.RemoveAt(CInt(BindingNavigatorPositionItem.Text) - 1)
                        Me.BindingNavigatorPositionItem.Enabled = True
                        Me.BindingNavigatorMovePreviousItem.Enabled = True
                        Me.BindingNavigatorMoveFirstItem.Enabled = True
                        Me.TBL_BarangTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Barang)
                    Catch ex As Exception
                        MessageBox.Show("Error : " & ex.ToString, "Error")
                    End Try
                End If
            Else
                MessageBox.Show("Barang tidak dapat dihapus, Kode barang telah dipakai di Pembelian / Penjualan atau terdapat detail barang", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Public Sub tsRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsRefresh.Click
        Dim kodebarang As String = txtKodeBarang.Text
        Me.TBL_BarangTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Barang)
        tsTambah.Enabled = True
        tsSimpan.Enabled = True
        tsHapus.Enabled = True
        txtKodeBarang.ReadOnly = True
        status = "update"
        btnUpload.Visible = False
        btnDelete.Visible = True
        btnUbah.Visible = True
        Me.tsRefresh.Text = "&Refresh"
        txtGudang1.ReadOnly = True
        TBLBarangBindingSource.Position = TBLBarangBindingSource.Find("Kode_Barang", kodebarang)
    End Sub

    Private Sub btnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUbah.Click
        With OpenFileDialog1
            .InitialDirectory = "D:\"
            .Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg"
            .FilterIndex = 4
        End With

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            With PBFoto1
                .Image = Image.FromFile(OpenFileDialog1.FileName)
                .SizeMode = PictureBoxSizeMode.StretchImage
            End With
            Dim ms As MemoryStream
            ms = New MemoryStream
            PBFoto1.Image.Save(ms, PBFoto1.Image.RawFormat)
            arrImage = ms.GetBuffer
            ms.Close()

            Try
                TBL_BarangTableAdapter.UpdateFoto(arrImage, txtKodeBarang.Text)
            Catch ex As Exception
                MessageBox.Show("Gagal menyimpan foto", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Dim posisi As Integer = CInt(Me.BindingNavigatorPositionItem.Text)
            Me.TBL_BarangTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Barang)
            TBLBarangBindingSource.Position = posisi - 1
        End If
    End Sub

    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        With OpenFileDialog1
            .InitialDirectory = "D:\"
            .Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg"
            .FilterIndex = 4
        End With

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            With PBFoto1
                .Image = Image.FromFile(OpenFileDialog1.FileName)
                .SizeMode = PictureBoxSizeMode.StretchImage
            End With
            Dim ms As New MemoryStream
            PBFoto1.Image.Save(ms, PBFoto1.Image.RawFormat)
            arrImage = ms.GetBuffer
            ms.Close()
        End If
    End Sub

    Private Sub txtKataKunci_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKataKunci.KeyDown
        If e.KeyValue = 13 Then
            If txtKataKunci.Text <> "" Then
                If cboKriteria.Text = "Kode Barang" Then
                    Me.TBL_BarangTableAdapter.FillByKodeBarang(Db_POS_CNDataSet.TBL_Barang, Me.txtKataKunci.Text)
                ElseIf cboKriteria.Text = "Nama Barang" Then
                    Me.TBL_BarangTableAdapter.FillByNamaBarang(Db_POS_CNDataSet.TBL_Barang, Me.txtKataKunci.Text)
                End If
            Else
                Me.TBL_BarangTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Barang)
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If txtKodeBarang.Text <> "" Then
            Dim posisi As Integer = Me.BindingNavigatorPositionItem.Text
            Me.TBL_BarangTableAdapter.NullFoto(txtKodeBarang.Text)
            Me.TBL_BarangTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Barang)
            Me.TBLBarangBindingSource.Position = posisi - 1
        End If
    End Sub

    Private Sub txtStokAwal_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStokAwal.KeyUp
        txtQty.Text = txtStokAwal.Text
        txtGudang1.Text = txtStokAwal.Text
        txtGudang2.Text = 0
    End Sub

    Private Sub txtGudang1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGudang1.KeyUp
        Try
            If CDec(txtGudang1.Text) > CDec(txtStokAwal.Text) Then
                MessageBox.Show(txtGudang1.Text & " " & txtStokAwal.Text)
                txtGudang1.Text = 0
                txtGudang2.Text = 0
            Else
                txtGudang2.Text = txtStokAwal.Text - txtGudang1.Text
            End If
        Catch ex As Exception
            txtGudang1.Text = 0
            txtGudang2.Text = 0
        End Try
    End Sub

    Private Sub FRM_Barang_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.TBL_BarangTableAdapter.FillBy(Me.Db_POS_CNDataSet.TBL_Barang)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        FRM_Barang_Detail.ShowDialog()
    End Sub
End Class
