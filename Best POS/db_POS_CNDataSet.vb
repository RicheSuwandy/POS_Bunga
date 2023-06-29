Partial Class db_POS_CNDataSet
    Partial Class TBL_Pembelian_HeaderDataTable

        Private Sub TBL_Pembelian_HeaderDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.Kode_SupplierColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
