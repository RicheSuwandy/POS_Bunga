Imports System.Data.SqlClient
Public Class FRM_PIUTANG
    Sub HitungTotalBayar(ByVal mytextbox As TextBox)
        Try
            If IsNumeric(mytextbox.Text) Then
                txtTotalBayar.Text = CLng(CLng(txtBayar1.Text) + CLng(txtBayar2.Text) + CLng(txtBayar3.Text) + CLng(txtBayar4.Text) + CLng(txtBayar5.Text) + CLng(txtBayar6.Text) + CLng(txtBayar7.Text) + CLng(txtBayar8.Text) + CLng(txtBayar9.Text) + CLng(txtBayar10.Text)).ToString("C0")
                txtSisaPiutang.Text = CLng(txtTotalPiutang.Text - txtTotalBayar.Text - txtTotalRetur.Text).ToString("C0")
            End If
            If txtSisaPiutang.Text <= 0 Then
                txtStatus.Text = "L"
            Else
                txtStatus.Text = "BL"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function LoadDataPiutang() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim strcon As String
        Dim sqlCon As SqlConnection
        Dim strQuery As String

        strQuery = "Select * From TBL_Piutang Where Kode_Penjualan = '" & txtNoFaktur.Text & "'"
        strcon = My.Settings.db_POS_CNConnectionString()
        sqlCon = New SqlConnection(strcon)
        da = New SqlDataAdapter(strQuery, sqlCon)
        da.Fill(dt)

        Return dt
    End Function

    Private Sub FRM_Piutang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_POS_CNDataSet.TBL_Piutang' table. You can move, or remove it, as needed.
        Me.TBL_PiutangTableAdapter.FillDataByNoBon(Me.Db_POS_CNDataSet.TBL_Piutang)

        'Me.TBL_PiutangTableAdapter.FillDataByNoBon(Me.Db_POS_CNDataSet.TBL_Piutang)
    End Sub

    Private Sub txtBayar1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBayar1.TextChanged
        HitungTotalBayar(txtBayar1)
    End Sub

    Private Sub txtBayar2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBayar2.TextChanged
        HitungTotalBayar(txtBayar2)
    End Sub

    Private Sub txtBayar3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBayar3.TextChanged
        HitungTotalBayar(txtBayar3)
    End Sub

    Private Sub txtBayar4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBayar4.TextChanged
        HitungTotalBayar(txtBayar4)
    End Sub

    Private Sub txtBayar5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBayar5.TextChanged
        HitungTotalBayar(txtBayar5)
    End Sub

    Private Sub txtBayar6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBayar6.TextChanged
        HitungTotalBayar(txtBayar6)
    End Sub

    Private Sub txtBayar7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBayar7.TextChanged
        HitungTotalBayar(txtBayar7)
    End Sub

    Private Sub txtBayar8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBayar8.TextChanged
        HitungTotalBayar(txtBayar8)
    End Sub

    Private Sub txtBayar9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBayar9.TextChanged
        HitungTotalBayar(txtBayar9)
    End Sub

    Private Sub txtBayar10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBayar10.TextChanged
        HitungTotalBayar(txtBayar10)
    End Sub

    Private Sub tsSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSimpan.Click
        If BindingNavigatorPositionItem.Text > 0 Then
            TBL_PiutangTableAdapter.UpdateAll1(txtTotalBayar.Text, txtSisaPiutang.Text, dtpTanggal.Value, dtpTgl1.Value, txtBayar1.Text, dtpTgl2.Value, txtBayar2.Text, dtpTgl3.Value, txtBayar3.Text, dtpTgl4.Value, txtBayar4.Text, dtpTgl5.Value, txtBayar5.Text, dtpTgl6.Value, txtBayar6.Text, dtpTgl7.Text, txtBayar7.Text, dtpTgl8.Value, txtBayar8.Text, dtpTgl9.Value, txtBayar9.Text, dtpTgl10.Value, txtBayar10.Text, txtStatus.Text, txtNoFaktur.Text)
            Me.TBL_PiutangTableAdapter.FillDataByNoBon(Me.Db_POS_CNDataSet.TBL_Piutang)
        Else
            MessageBox.Show("Anda berada di record 0")
        End If
    End Sub

    Private Sub tsRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsRefresh.Click
        Me.TBL_PiutangTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Piutang)
    End Sub

    Private Sub tsBL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsBL.Click
        Me.TBL_PiutangTableAdapter.FillByStatus(Me.Db_POS_CNDataSet.TBL_Piutang, "BL")
    End Sub

    Private Sub tsL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsL.Click
        Me.TBL_PiutangTableAdapter.FillByStatus(Me.Db_POS_CNDataSet.TBL_Piutang, "L")
    End Sub

    Private Sub txtKataKunci_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKataKunci.KeyDown
        If e.KeyValue = 13 Then
            If txtKataKunci.Text <> "" Then
                If cboKriteria.Text = "No Faktur" Then
                    Me.TBL_PiutangTableAdapter.FillByKodePenjualan(Db_POS_CNDataSet.TBL_Piutang, Me.txtKataKunci.Text)
                Else
                    Me.TBL_PiutangTableAdapter.FillByNoBon(Db_POS_CNDataSet.TBL_Piutang, Me.txtKataKunci.Text)
                End If
            Else
                Me.TBL_PiutangTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Piutang)
            End If
        End If
    End Sub

    Private Sub FRM_Piutang_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub txtNoFaktur_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoFaktur.TextChanged
        Dim dt As New DataTable
        dt = LoadDataPiutang()
        If dt.Rows.Count > 0 Then
            For Each dr As DataRow In dt.Rows
                txtBayar1.Text = FormatCurrency(IIf(IsDBNull(dr.Item("Pembayaran_1")), 0, dr.Item("Pembayaran_1")), 2, TriState.True)
                dtpTgl1.Value = IIf(IsDBNull(dr.Item("Tgl_1")), Now, dr.Item("Tgl_1"))

                txtBayar2.Text = FormatCurrency(IIf(IsDBNull(dr.Item("Pembayaran_2")), 0, dr.Item("Pembayaran_2")), 2, TriState.True)
                dtpTgl2.Value = IIf(IsDBNull(dr.Item("Tgl_2")), Now, dr.Item("Tgl_2"))

                txtBayar3.Text = FormatCurrency(IIf(IsDBNull(dr.Item("Pembayaran_3")), 0, dr.Item("Pembayaran_3")), 2, TriState.True)
                dtpTgl3.Value = IIf(IsDBNull(dr.Item("Tgl_3")), Now, dr.Item("Tgl_3"))

                txtBayar4.Text = FormatCurrency(IIf(IsDBNull(dr.Item("Pembayaran_4")), 0, dr.Item("Pembayaran_4")), 2, TriState.True)
                dtpTgl4.Value = IIf(IsDBNull(dr.Item("Tgl_4")), Now, dr.Item("Tgl_4"))

                txtBayar5.Text = FormatCurrency(IIf(IsDBNull(dr.Item("Pembayaran_5")), 0, dr.Item("Pembayaran_5")), 2, TriState.True)
                dtpTgl5.Value = IIf(IsDBNull(dr.Item("Tgl_5")), Now, dr.Item("Tgl_5"))

                txtBayar6.Text = FormatCurrency(IIf(IsDBNull(dr.Item("Pembayaran_6")), 0, dr.Item("Pembayaran_6")), 2, TriState.True)
                dtpTgl6.Value = IIf(IsDBNull(dr.Item("Tgl_6")), Now, dr.Item("Tgl_6"))

                txtBayar7.Text = FormatCurrency(IIf(IsDBNull(dr.Item("Pembayaran_7")), 0, dr.Item("Pembayaran_7")), 2, TriState.True)
                dtpTgl7.Value = IIf(IsDBNull(dr.Item("Tgl_7")), Now, dr.Item("Tgl_7"))

                txtBayar8.Text = FormatCurrency(IIf(IsDBNull(dr.Item("Pembayaran_8")), 0, dr.Item("Pembayaran_8")), 2, TriState.True)
                dtpTgl8.Value = IIf(IsDBNull(dr.Item("Tgl_1")), Now, dr.Item("Tgl_1"))

                txtBayar9.Text = FormatCurrency(IIf(IsDBNull(dr.Item("Pembayaran_9")), 0, dr.Item("Pembayaran_9")), 2, TriState.True)
                dtpTgl9.Value = IIf(IsDBNull(dr.Item("Tgl_9")), Now, dr.Item("Tgl_9"))

                txtBayar10.Text = FormatCurrency(IIf(IsDBNull(dr.Item("Pembayaran_10")), 0, dr.Item("Pembayaran_10")), 2, TriState.True)
                dtpTgl10.Value = IIf(IsDBNull(dr.Item("Tgl_10")), Now, dr.Item("Tgl_10"))

            Next
        End If
    End Sub
End Class
