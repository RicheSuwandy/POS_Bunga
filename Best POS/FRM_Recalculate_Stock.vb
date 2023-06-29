Imports System.Data.SqlClient
Public Class FRM_Recalculate_Stock
    Dim kodebarang, kodebarangrekalkulasi As String
    Dim banyak As Integer
    Dim stokawal, stokakhir, qty, g1, g2, totalbeli, totalbelig1, totalbelig2, totaljual, totaljualg1, totaljualg2, totalreturbeli, totalreturbelig1, totalreturbelig2, totalreturjual, totalreturjualg1, totalreturjualg2, g1akhir, g2akhir As Decimal
    Dim tambahprogress As Decimal
    Sub HitungG1G2()
        Try
            totalbelig1 = TbL_Alokasi_PembelianTableAdapter.TotalG1Rekalkulasi(kodebarang)
        Catch ex As Exception
            totalbelig1 = 0
        End Try
        Try
            totalbelig2 = TbL_Alokasi_PembelianTableAdapter.TotalG2Rekalkulasi(kodebarang)
        Catch ex As Exception
            totalbelig2 = 0
        End Try
        Try
            totaljualg1 = TbL_Alokasi_PenjualanTableAdapter.TotalG1Rekalkulasi(kodebarang)
        Catch ex As Exception
            totaljualg1 = 0
        End Try
        Try
            totaljualg2 = TbL_Alokasi_PenjualanTableAdapter.TotalG2Rekalkulasi(kodebarang)
        Catch ex As Exception
            totaljualg2 = 0
        End Try
        Try
            totalreturbelig1 = TbL_Retur_Pembelian_DetailTableAdapter.TotalG1Rekalkulasi(kodebarang)
        Catch ex As Exception
            totalreturbelig1 = 0
        End Try
        Try
            totalreturbelig2 = TbL_Retur_Pembelian_DetailTableAdapter.TotalG2Rekalkulasi(kodebarang)
        Catch ex As Exception
            totalreturbelig2 = 0
        End Try
        Try
            totalreturjualg1 = TbL_Retur_Penjualan_DetailTableAdapter.TotalG1Rekalkulasi(kodebarang)
        Catch ex As Exception
            totalreturjualg1 = 0
        End Try
        Try
            totalreturjualg2 = TbL_Retur_Penjualan_DetailTableAdapter.TotalG2Rekalkulasi(kodebarang)
        Catch ex As Exception
            totalreturjualg2 = 0
        End Try
        g1akhir = stokawal + totalbelig1 - totalreturbelig1 - totaljualg1 + totalreturjualg1
        g2akhir = totalbelig2 - totalreturbelig2 - totaljualg2 + totalreturjualg2
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            banyak = TbL_BarangTableAdapter.BanyakBarang()
        Catch ex As Exception
            banyak = 0
        End Try
        If banyak > 0 Then
            tambahprogress = 100 / banyak
            koneksi()
            sql = "SELECT Kode_Barang, Nama_Barang, Stok_Awal, Qty, G1, G2 FROM TBL_Barang"
            cmd = New SqlCommand(sql, cn)
            reader = cmd.ExecuteReader
            While reader.Read
                kodebarang = reader(0)
                stokawal = reader(2)
                qty = reader(3)
                g1 = reader(4)
                g2 = reader(5)
                Try
                    totalbeli = TbL_Pembelian_DetailTableAdapter.TotalQtyRekalkulasi(kodebarang)
                Catch ex As Exception
                    totalbeli = 0
                End Try
                Try
                    totaljual = TbL_Penjualan_DetailTableAdapter.TotalQtyRekalkulasi(kodebarang)
                Catch ex As Exception
                    totaljual = 0
                End Try
                Try
                    totalreturbeli = TbL_Retur_Pembelian_DetailTableAdapter.TotalQtyReturKalkulasi(kodebarang)
                Catch ex As Exception
                    totalreturbeli = 0
                End Try
                Try
                    totalreturjual = TbL_Retur_Penjualan_DetailTableAdapter.TotalQtyReturKalkulasi(kodebarang)
                Catch ex As Exception
                    totalreturjual = 0
                End Try
                stokakhir = stokawal + totalbeli - totalreturbeli - totaljual + totalreturjual
                If stokakhir <> qty And stokakhir <> g1 + g2 Or stokakhir = qty And stokakhir <> g1 + g2 Then
                    HitungG1G2()
                    TbL_BarangTableAdapter.UpdateQtyG1G2(stokakhir, g1akhir, g2akhir, kodebarang)
                    kodebarangrekalkulasi = kodebarangrekalkulasi & kodebarang & " "
                ElseIf stokakhir <> qty And stokakhir = g1 + g2 Then
                    TbL_BarangTableAdapter.SetQty(stokakhir, kodebarang)
                    kodebarangrekalkulasi = kodebarangrekalkulasi & kodebarang & " "
                End If
                ProgressBar1.Value += tambahprogress
                Threading.Thread.Sleep(1)
            End While
            ProgressBar1.Value = 100
            reader.Close()
            cn.Close()
            If kodebarangrekalkulasi = "" Then
                MessageBox.Show("Proses Rekalkulasi stok barang selesai dilakukan" & vbCrLf & "Tidak ditemukan kode barang yang memerlukan penyesuaian", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Proses Rekalkulasi stok barang selesai dilakukan" & vbCrLf & " Ditemukan kode barang penyesuaian sbb :" & vbCrLf & kodebarangrekalkulasi & vbCrLf & "Lakukan opname stok secara manual terhadap kode barang tersebut untuk menjamin kesesuaian stok fisik dengan stok di komputer", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Tabel barang kosong, proses rekalkulasi tidak dilakukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        tutupform(Me)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        tutupform(Me)
    End Sub
End Class