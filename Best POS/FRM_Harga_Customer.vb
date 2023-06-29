Public Class FRM_Harga_Customer

    Private Sub FRM_Harga_Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_POS_CNDataSet.Query_Harga_Customer' table. You can move, or remove it, as needed.
        Me.Query_Harga_CustomerTableAdapter.Fill(Me.Db_POS_CNDataSet.Query_Harga_Customer)

    End Sub
End Class