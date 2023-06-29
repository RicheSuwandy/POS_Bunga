Public Class FRM_Kredit_Pembelian
    Dim totalharga As Long
    Public Sub FRM_Kredit_Pembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim jt As Date
        jt = DateAdd(DateInterval.Day, 90, FRM_Pembelian.dtpTanggal.Value)
        dtpBayar.Value = jt
        txtDP.Text = 0
        totalharga = FRM_Pembelian.txtTotalHarga.Text
        txtKodepembelian.Text = FRM_Pembelian.txtKodePembelian.Text
        txtTotalHarga.Text = totalharga.ToString("C0")
        txtSisa.Text = totalharga.ToString("C0")
        Dim cek As Integer
        Try
            cek = TbL_hutangTableAdapter.CekKodepembelian(txtKodepembelian.Text)
        Catch ex As Exception
            cek = 0
        End Try
        If cek = 1 Then
            Dim tgl As Date = TbL_hutangTableAdapter.TglPenagihan(txtKodepembelian.Text)
            sisapmbbeli = TbL_HutangTableAdapter.TotalHutang(txtKodePembelian.Text)
            txtSisa.Text = sisapmbbeli.ToString("C0")
            txtDP.Text = totalharga - sisapmbbeli.ToString("C0")
            dtpBayar.Value = tgl
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub FRM_Kredit_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        txtDP.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If CDec(txtDP.Text) < totalharga Then
                Dim cek As Integer = TbL_hutangTableAdapter.CekKodepembelian(txtKodepembelian.Text)
                If cek = 0 Then
                    TbL_HutangTableAdapter.InsertQuery(txtKodePembelian.Text, CLng(txtSisa.Text), dtpBayar.Value, 0, 0, CLng(txtSisa.Text))
                Else
                    TbL_HutangTableAdapter.UpdateQuery(CLng(txtSisa.Text), dtpBayar.Value, 0, 0, CLng(txtSisa.Text), txtKodePembelian.Text)
                End If
                jenispmbbeli = "KREDIT"
                pmbbeli = CDec(txtDP.Text)
                sisapmbbeli = CDec(txtSisa.Text)
                TbL_Pembelian_HeaderTableAdapter.UpdatePembayaran(jenispmbbeli, pmbbeli, sisapmbbeli, txtKodePembelian.Text)
                FRM_Pembelian.btnAdd.Enabled = False
                FRM_Pembelian.btnReset.Enabled = False
                FRM_Pembelian.txtJenisPmb.Text = jenispmbbeli
                FRM_Pembelian.txtPmb.Text = pmbbeli.ToString("C0")
                FRM_Pembelian.txtSisa.Text = sisapmbbeli.ToString("C0")
                Me.Close()
                Me.Dispose()
            Else
                MessageBox.Show("DP harus lebih kecil dari Total Harga", "Error")
            End If
        Catch ex As Exception
            MessageBox.Show("Masukkan nominal DP", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDP_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDP.KeyUp
        Try
            pmbbeli = CDec(txtDP.Text)
            sisapmbbeli = totalharga - pmbbeli
            txtSisa.Text = sisapmbbeli.ToString("C0")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FRM_Kredit_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class