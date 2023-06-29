Imports System.Data.SqlClient
Public Class FRM_Akses_Recalculate

    Private Sub FRM_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtpassword.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tutupform(Me)
    End Sub

    Private Sub txtuser_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtpassword.Text = "Best POS Application" Then
            FRM_Recalculate_Stock.ShowDialog()
            tutupform(Me)
        Else
            MessageBox.Show("Password yang Anda masukkan salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class