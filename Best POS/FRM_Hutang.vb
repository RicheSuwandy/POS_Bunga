Public Class FRM_Hutang
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
    Private Sub FRM_Piutang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_POS_CNDataSet.TBL_Hutang' table. You can move, or remove it, as needed.
        Me.TBL_HutangTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Hutang)
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
            TBL_HutangTableAdapter.UpdateAll1(txtTotalBayar.Text, txtSisaPiutang.Text, dtpTanggal.Value, txtTgl1.Text, txtBayar1.Text, txtTgl2.Text, txtBayar2.Text, txtTgl3.Text, txtBayar3.Text, txtTgl4.Text, txtBayar4.Text, txtTgl5.Text, txtBayar5.Text, txtTgl6.Text, txtBayar6.Text, txtTgl7.Text, txtBayar7.Text, txtTgl8.Text, txtBayar8.Text, txtTgl9.Text, txtBayar9.Text, txtTgl10.Text, txtBayar10.Text, txtStatus.Text, txtNoFaktur.Text)
        Else
            MessageBox.Show("Anda berada di record 0")
        End If
    End Sub

    Private Sub tsRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsRefresh.Click
        Me.TBL_HutangTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Hutang)
    End Sub

    Private Sub tsBL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsBL.Click
        Me.TBL_HutangTableAdapter.FillByStatus(Me.Db_POS_CNDataSet.TBL_Hutang, "BL")
    End Sub

    Private Sub tsL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsL.Click
        Me.TBL_HutangTableAdapter.FillByStatus(Me.Db_POS_CNDataSet.TBL_Hutang, "L")
    End Sub

    Private Sub txtKataKunci_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKataKunci.KeyDown
        If e.KeyValue = 13 Then
            If txtKataKunci.Text <> "" Then
                If cboKriteria.Text = "No Faktur" Then
                    Me.TBL_HutangTableAdapter.FillByKodePembelian(Db_POS_CNDataSet.TBL_Hutang, Me.txtKataKunci.Text)
                End If
            Else
                Me.TBL_HutangTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_Hutang)
            End If
        End If
    End Sub

    Private Sub FRM_Hutang_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
End Class