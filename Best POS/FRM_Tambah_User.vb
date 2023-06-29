Public Class FRM_Tambah_User

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cekuser As Integer
        Try
            cekuser = TbL_UserTableAdapter.CekUsername(txtuser.Text)
        Catch ex As Exception
            cekuser = 0
        End Try
        If cekuser = 0 Then
            If txtpassword.Text = txtConfirm.Text Then
                TbL_UserTableAdapter.InsertQuery(txtuser.Text, txtpassword.Text)
                FRM_User_Management.TBL_UserTableAdapter.Fill(FRM_User_Management.Db_POS_CNDataSet.TBL_User)
                Me.txtuser.Clear()
                Me.txtpassword.Clear()
                Me.txtConfirm.Clear()
                Me.txtuser.Focus()
            Else
                MessageBox.Show("Password dan Confirm Password tidak sama", "Error", MessageBoxButtons.OK)
                txtpassword.Focus()
            End If
        Else
            MessageBox.Show("Username telah terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtuser.Clear()
            txtuser.Focus()
        End If
    End Sub

    Private Sub FRM_Tambah_User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtuser.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tutupform(Me)
    End Sub
End Class