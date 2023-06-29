<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Harga_Supplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Harga_Supplier))
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.QueryHargaSupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_POS_CNDataSet = New Best_POS.db_POS_CNDataSet()
        Me.QueryHargaCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Query_Harga_CustomerTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.Query_Harga_CustomerTableAdapter()
        Me.Query_Harga_SupplierTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.Query_Harga_SupplierTableAdapter()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QueryHargaSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_POS_CNDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QueryHargaCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.AllowEditing = False
        Me.C1FlexGrid1.ColumnInfo = resources.GetString("C1FlexGrid1.ColumnInfo")
        Me.C1FlexGrid1.DataSource = Me.QueryHargaSupplierBindingSource
        Me.C1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1FlexGrid1.Location = New System.Drawing.Point(0, 0)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.Count = 1
        Me.C1FlexGrid1.Rows.DefaultSize = 19
        Me.C1FlexGrid1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.C1FlexGrid1.Size = New System.Drawing.Size(718, 385)
        Me.C1FlexGrid1.TabIndex = 0
        Me.C1FlexGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'QueryHargaSupplierBindingSource
        '
        Me.QueryHargaSupplierBindingSource.DataMember = "Query_Harga_Supplier"
        Me.QueryHargaSupplierBindingSource.DataSource = Me.Db_POS_CNDataSet
        '
        'Db_POS_CNDataSet
        '
        Me.Db_POS_CNDataSet.DataSetName = "db_POS_CNDataSet"
        Me.Db_POS_CNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QueryHargaCustomerBindingSource
        '
        Me.QueryHargaCustomerBindingSource.DataMember = "Query_Harga_Customer"
        Me.QueryHargaCustomerBindingSource.DataSource = Me.Db_POS_CNDataSet
        '
        'Query_Harga_CustomerTableAdapter
        '
        Me.Query_Harga_CustomerTableAdapter.ClearBeforeFill = True
        '
        'Query_Harga_SupplierTableAdapter
        '
        Me.Query_Harga_SupplierTableAdapter.ClearBeforeFill = True
        '
        'FRM_Harga_Supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 385)
        Me.Controls.Add(Me.C1FlexGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FRM_Harga_Supplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form History Harga Supplier"
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QueryHargaSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_POS_CNDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QueryHargaCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Db_POS_CNDataSet As Best_POS.db_POS_CNDataSet
    Friend WithEvents QueryHargaCustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Query_Harga_CustomerTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.Query_Harga_CustomerTableAdapter
    Friend WithEvents QueryHargaSupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Query_Harga_SupplierTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.Query_Harga_SupplierTableAdapter
End Class
