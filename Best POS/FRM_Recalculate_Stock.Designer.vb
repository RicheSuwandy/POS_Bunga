<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Recalculate_Stock
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Recalculate_Stock))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TbL_BarangTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_BarangTableAdapter()
        Me.TbL_Alokasi_PembelianTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Alokasi_PembelianTableAdapter()
        Me.TbL_Alokasi_PenjualanTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Alokasi_PenjualanTableAdapter()
        Me.TbL_Pembelian_DetailTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Pembelian_DetailTableAdapter()
        Me.TbL_Penjualan_DetailTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Penjualan_DetailTableAdapter()
        Me.TbL_Retur_Pembelian_DetailTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Retur_Pembelian_DetailTableAdapter()
        Me.TbL_Retur_Penjualan_DetailTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Retur_Penjualan_DetailTableAdapter()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(1, 117)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(419, 41)
        Me.ProgressBar1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(123, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 31)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Yes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(397, 43)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Program akan melakukan proses rekalkulasi stok barang, yakin untuk melanjutkan :"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(217, 65)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 31)
        Me.Button3.TabIndex = 37
        Me.Button3.Text = "   &Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TbL_BarangTableAdapter
        '
        Me.TbL_BarangTableAdapter.ClearBeforeFill = True
        '
        'TbL_Alokasi_PembelianTableAdapter
        '
        Me.TbL_Alokasi_PembelianTableAdapter.ClearBeforeFill = True
        '
        'TbL_Alokasi_PenjualanTableAdapter
        '
        Me.TbL_Alokasi_PenjualanTableAdapter.ClearBeforeFill = True
        '
        'TbL_Pembelian_DetailTableAdapter
        '
        Me.TbL_Pembelian_DetailTableAdapter.ClearBeforeFill = True
        '
        'TbL_Penjualan_DetailTableAdapter
        '
        Me.TbL_Penjualan_DetailTableAdapter.ClearBeforeFill = True
        '
        'TbL_Retur_Pembelian_DetailTableAdapter
        '
        Me.TbL_Retur_Pembelian_DetailTableAdapter.ClearBeforeFill = True
        '
        'TbL_Retur_Penjualan_DetailTableAdapter
        '
        Me.TbL_Retur_Penjualan_DetailTableAdapter.ClearBeforeFill = True
        '
        'FRM_Recalculate_Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 158)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_Recalculate_Stock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Recalculate Stok Barang"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TbL_BarangTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_BarangTableAdapter
    Friend WithEvents TbL_Alokasi_PembelianTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Alokasi_PembelianTableAdapter
    Friend WithEvents TbL_Alokasi_PenjualanTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Alokasi_PenjualanTableAdapter
    Friend WithEvents TbL_Pembelian_DetailTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Pembelian_DetailTableAdapter
    Friend WithEvents TbL_Penjualan_DetailTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Penjualan_DetailTableAdapter
    Friend WithEvents TbL_Retur_Pembelian_DetailTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Retur_Pembelian_DetailTableAdapter
    Friend WithEvents TbL_Retur_Penjualan_DetailTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Retur_Penjualan_DetailTableAdapter
End Class
