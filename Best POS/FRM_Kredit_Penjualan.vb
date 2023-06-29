Public Class FRM_Kredit_Penjualan
    Dim totalharga As Long
    Public Sub FRM_Kredit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim jt As Date
        jt = DateAdd(DateInterval.Day, 90, FRM_Penjualan.dtpTanggal.Value)
        dtpBayar.Value = jt
        txtDP.Text = 0
        totalharga = FRM_Penjualan.txtTotalHarga.Text
        txtKodePenjualan.Text = FRM_Penjualan.txtKodePenjualan.Text
        txtTotalHarga.Text = totalharga.ToString("C0")
        txtSisa.Text = totalharga.ToString("C0")
        txtNoBon.Text = FRM_Penjualan.txtNoBon.Text
        Dim cek As Integer
        Try
            cek = TbL_PiutangTableAdapter.CekKodePenjualan(txtKodePenjualan.Text)
        Catch ex As Exception
            cek = 0
        End Try
        If cek = 1 Then
            Dim tgl As Date = TbL_PiutangTableAdapter.TglPenagihan(txtKodePenjualan.Text)
            sisapmbjual = TbL_PiutangTableAdapter.TotalPiutang(txtKodePenjualan.Text)
            txtSisa.Text = sisapmbjual.ToString("C0")
            txtDP.Text = totalharga - sisapmbjual.ToString("C0")
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
                Dim cek As Integer = TbL_PiutangTableAdapter.CekKodePenjualan(txtKodePenjualan.Text)
                If cek = 0 Then
                    TbL_PiutangTableAdapter.InsertQuery(txtKodePenjualan.Text, CLng(txtSisa.Text), dtpBayar.Value, 0, 0, CLng(txtSisa.Text), txtNoBon.Text)
                Else
                    TbL_PiutangTableAdapter.UpdateQuery(CLng(txtSisa.Text), dtpBayar.Value, 0, 0, CLng(txtSisa.Text), txtKodePenjualan.Text)
                End If
                jenispmbjual = "KREDIT"
                pmbjual = CDec(txtDP.Text)
                sisapmbjual = CDec(txtSisa.Text)
                TbL_Penjualan_HeaderTableAdapter.UpdatePembayaran(jenispmbjual, pmbjual, sisapmbjual, FRM_Penjualan.txtNoBon.Text, FRM_Penjualan.txtBiayaLain.Text, FRM_Penjualan.txtDiskon.Text, txtKodePenjualan.Text)
                FRM_Penjualan.btnAdd.Enabled = False
                FRM_Penjualan.btnReset.Enabled = False
                FRM_Penjualan.txtJenisPmb.Text = jenispmbjual
                FRM_Penjualan.txtPmb.Text = pmbjual.ToString("C0")
                FRM_Penjualan.txtSisa.Text = sisapmbjual.ToString("C0")
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
            pmbjual = CDec(txtDP.Text)
            sisapmbjual = totalharga - pmbjual
            txtSisa.Text = sisapmbjual.ToString("C0")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FRM_Kredit_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class