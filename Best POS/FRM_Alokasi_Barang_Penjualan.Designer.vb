﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Alokasi_Barang_Penjualan
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Alokasi_Barang_Penjualan))
        Me.cfgAlokasi = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.QueryAlokasiPenjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_POS_CNDataSet = New Best_POS.db_POS_CNDataSet()
        Me.TbL_BarangTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_BarangTableAdapter()
        Me.Query_Alokasi_PenjualanTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.Query_Alokasi_PenjualanTableAdapter()
        Me.TbL_Alokasi_PenjualanTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Alokasi_PenjualanTableAdapter()
        CType(Me.cfgAlokasi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QueryAlokasiPenjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_POS_CNDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cfgAlokasi
        '
        Me.cfgAlokasi.ColumnInfo = resources.GetString("cfgAlokasi.ColumnInfo")
        Me.cfgAlokasi.DataSource = Me.QueryAlokasiPenjualanBindingSource
        Me.cfgAlokasi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cfgAlokasi.Location = New System.Drawing.Point(0, 0)
        Me.cfgAlokasi.Name = "cfgAlokasi"
        Me.cfgAlokasi.Rows.Count = 1
        Me.cfgAlokasi.Rows.DefaultSize = 19
        Me.cfgAlokasi.Size = New System.Drawing.Size(642, 262)
        Me.cfgAlokasi.TabIndex = 0
        Me.cfgAlokasi.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'QueryAlokasiPenjualanBindingSource
        '
        Me.QueryAlokasiPenjualanBindingSource.DataMember = "Query_Alokasi_Penjualan"
        Me.QueryAlokasiPenjualanBindingSource.DataSource = Me.Db_POS_CNDataSet
        '
        'Db_POS_CNDataSet
        '
        Me.Db_POS_CNDataSet.DataSetName = "db_POS_CNDataSet"
        Me.Db_POS_CNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbL_BarangTableAdapter
        '
        Me.TbL_BarangTableAdapter.ClearBeforeFill = True
        '
        'Query_Alokasi_PenjualanTableAdapter
        '
        Me.Query_Alokasi_PenjualanTableAdapter.ClearBeforeFill = True
        '
        'TbL_Alokasi_PenjualanTableAdapter
        '
        Me.TbL_Alokasi_PenjualanTableAdapter.ClearBeforeFill = True
        '
        'FRM_Alokasi_Barang_Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 262)
        Me.Controls.Add(Me.cfgAlokasi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_Alokasi_Barang_Penjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form Alokasi Gudang"
        CType(Me.cfgAlokasi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QueryAlokasiPenjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_POS_CNDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cfgAlokasi As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Db_POS_CNDataSet As Best_POS.db_POS_CNDataSet
    Friend WithEvents QueryAlokasiPenjualanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Query_Alokasi_PenjualanTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.Query_Alokasi_PenjualanTableAdapter
    Friend WithEvents TbL_BarangTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_BarangTableAdapter
    Friend WithEvents TbL_Alokasi_PenjualanTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Alokasi_PenjualanTableAdapter
End Class
