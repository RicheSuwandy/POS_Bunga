Public Class FRM_Alokasi_Barang_Penjualan
    Dim awalg1, awalg2, akhirg1, akhirg2, totalqty, selisihg1, selisihg2 As Decimal
    Dim kodebarang As String
    Private Sub FRM_Alokasi_Barang_Penjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cfgAlokasi.AllowEditing = False
        'TODO: This line of code loads data into the 'Db_POS_CNDataSet.Query_Alokasi_Penjualan' table. You can move, or remove it, as needed.
        Me.Query_Alokasi_PenjualanTableAdapter.FillByKodePenjualan(Me.Db_POS_CNDataSet.Query_Alokasi_Penjualan, FRM_Penjualan.txtKodePenjualan.Text)
    End Sub

    Private Sub FRM_Alokasi_Barang_Penjualan_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub cfgAlokasi_AfterEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles cfgAlokasi.AfterEdit
        Try
            akhirg1 = cfgAlokasi.GetData(cfgAlokasi.RowSel, 4)
            If akhirg1 > totalqty Then
                MessageBox.Show("Qty Gudang tidak boleh melebihi Total Qty")
                cfgAlokasi.SetData(cfgAlokasi.RowSel, 4, awalg1)
            Else
                akhirg2 = totalqty - akhirg1
                cfgAlokasi.SetData(cfgAlokasi.RowSel, 5, akhirg2)
                selisihg1 = awalg1 - akhirg1
                selisihg2 = awalg2 - akhirg2
                TbL_BarangTableAdapter.UpdateQtyG1(selisihg1, kodebarang)
                TbL_BarangTableAdapter.UpdateQtyG2(selisihg2, kodebarang)
                TbL_Alokasi_PenjualanTableAdapter.UpdateG1G2(akhirg1, akhirg2, FRM_Penjualan.txtKodePenjualan.Text, kodebarang)
            End If
        Catch ex As Exception
            MessageBox.Show("Error :" & ex.ToString(), "Error")
        End Try
    End Sub

    Private Sub cfgAlokasi_ChangeEdit(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cfgAlokasi.ChangeEdit
        If cfgAlokasi.ColSel = 4 Then
            totalqty = cfgAlokasi.GetData(cfgAlokasi.RowSel, 3)
            awalg1 = cfgAlokasi.GetData(cfgAlokasi.RowSel, 4)
            awalg2 = cfgAlokasi.GetData(cfgAlokasi.RowSel, 5)
            kodebarang = cfgAlokasi.GetData(cfgAlokasi.RowSel, 1)
        End If
    End Sub

    Private Sub cfgAlokasi_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cfgAlokasi.KeyDown
        cfgAlokasi.AllowEditing = True
    End Sub

    Private Sub cfgAlokasi_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cfgAlokasi.KeyUp
        cfgAlokasi.AllowEditing = False
    End Sub
End Class