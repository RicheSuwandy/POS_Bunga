Public Class FRM_Gudang

    Private Sub FRM_Gudang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim banyakgudang As Byte
        Dim gudang1 As String
        Dim gudang2 As String
        Try
            banyakgudang = TbL_GudangTableAdapter.BanyakGudang()
        Catch ex As Exception
            banyakgudang = 0
        End Try
        If banyakgudang = 0 Then
            TbL_GudangTableAdapter.InsertQuery(1, "Gudang Utama", "Utama")
            TbL_GudangTableAdapter.InsertQuery(2, "Gudang Kedua", "Kedua")
        End If
        gudang1 = TbL_GudangTableAdapter.NamaGudang(1)
        gudang2 = TbL_GudangTableAdapter.NamaGudang(2)
        txtGudang1.Text = gudang1
        txtGudang2.Text = gudang2
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        TbL_GudangTableAdapter.UpdateQuery(txtGudang1.Text, "Utama", txtKode1.Text)
        TbL_GudangTableAdapter.UpdateQuery(txtGudang2.Text, "Kedua", txtKode2.Text)
        Me.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class