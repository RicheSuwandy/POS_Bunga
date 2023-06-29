Public Class FRM_Ubah_Password

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ceklogin As Integer
        Try
            ceklogin = CInt(TbL_UserTableAdapter.CekLogin(lblUser.Text, txtold.Text).Value)
        Catch ex As Exception
            ceklogin = 0
        End Try
        If ceklogin = 1 Then
            If txtnew.Text = txtconfirm.Text Then
                TbL_UserTableAdapter.UpdatePassword(txtnew.Text, lblUser.Text)
                MessageBox.Show("Password berhasil diubah", "Konfirmasi", MessageBoxButtons.OK)
                Me.Close()
                Me.Dispose()
            Else
                MessageBox.Show("Password dan Confirm Password tidak sama", "Error", MessageBoxButtons.OK)
                txtnew.Focus()
            End If
        Else
            MessageBox.Show("Password lama salah", "Error", MessageBoxButtons.OK)
            txtold.Focus()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tutupform(Me)
    End Sub
End Class