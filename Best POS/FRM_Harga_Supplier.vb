Public Class FRM_Harga_Supplier

    Private Sub FRM_Harga_Supplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_POS_CNDataSet.Query_Harga_Supplier' table. You can move, or remove it, as needed.
        Me.Query_Harga_SupplierTableAdapter.Fill(Me.Db_POS_CNDataSet.Query_Harga_Supplier)

    End Sub
End Class