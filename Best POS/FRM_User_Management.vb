Public Class FRM_User_Management

    Private Sub FRM_User_Management_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_POS_CNDataSet.TBL_User' table. You can move, or remove it, as needed.
        Me.TBL_UserTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_User)
    End Sub

    Private Sub tsHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsHapus.Click
        Dim username As String = cfgUser.GetData(cfgUser.RowSel, 1)
        If MessageBox.Show("Yakin akan menghapus Username : " & username & "?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.TBL_UserTableAdapter.DeleteQuery(username)
            Me.TBL_UserTableAdapter.Fill(Me.Db_POS_CNDataSet.TBL_User)
        End If
    End Sub

    Private Sub tsChangePass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsChangePass.Click
        Dim username As String
        Try
            username = cfgUser.GetData(cfgUser.RowSel, 1)
        Catch ex As Exception
            username = ""
        End Try
        If username <> "" Then
            FRM_Ubah_Password.lblUser.Text = username
            FRM_Ubah_Password.ShowDialog()
        End If
    End Sub

    Private Sub tsTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsTambah.Click
        FRM_Tambah_User.ShowDialog()
    End Sub

    Private Sub tsResetPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsResetPass.Click
        Dim username As String
        Try
            username = cfgUser.GetData(cfgUser.RowSel, 1)
        Catch ex As Exception
            username = ""
        End Try
        If username <> "" Then
            FRM_Reset_Password.lblUser.Text = username
            FRM_Reset_Password.ShowDialog()
        End If
    End Sub

    Private Sub tsHakAkses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsHakAkses.Click
        Dim username As String
        Try
            username = cfgUser.GetData(cfgUser.RowSel, 1)
        Catch ex As Exception
            username = ""
        End Try
        If username <> "" Then
            FRM_Hak_Akses.lblUser.Text = username
            FRM_Hak_Akses.ShowDialog()
        End If
    End Sub
End Class