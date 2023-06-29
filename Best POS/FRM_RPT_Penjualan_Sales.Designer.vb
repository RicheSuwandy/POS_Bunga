<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_RPT_Penjualan_Sales
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnTampil = New System.Windows.Forms.Button()
        Me.cboSales = New System.Windows.Forms.ComboBox()
        Me.TBLSalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_POS_CNDataSet = New Best_POS.db_POS_CNDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpAkhir = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpAwal = New System.Windows.Forms.DateTimePicker()
        Me.crvPembelian = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Query_Laporan_PenjualanTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.Query_Laporan_PenjualanTableAdapter()
        Me.TBL_SalesTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_SalesTableAdapter()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.TBLSalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_POS_CNDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnTampil)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cboSales)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpAkhir)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpAwal)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.crvPembelian)
        Me.SplitContainer1.Size = New System.Drawing.Size(958, 500)
        Me.SplitContainer1.SplitterDistance = 46
        Me.SplitContainer1.TabIndex = 0
        '
        'btnTampil
        '
        Me.btnTampil.Location = New System.Drawing.Point(670, 13)
        Me.btnTampil.Name = "btnTampil"
        Me.btnTampil.Size = New System.Drawing.Size(75, 23)
        Me.btnTampil.TabIndex = 8
        Me.btnTampil.Text = "Tampil"
        Me.btnTampil.UseVisualStyleBackColor = True
        '
        'cboSales
        '
        Me.cboSales.DataSource = Me.TBLSalesBindingSource
        Me.cboSales.DisplayMember = "Nama_Sales"
        Me.cboSales.FormattingEnabled = True
        Me.cboSales.Location = New System.Drawing.Point(512, 15)
        Me.cboSales.Name = "cboSales"
        Me.cboSales.Size = New System.Drawing.Size(152, 21)
        Me.cboSales.TabIndex = 7
        Me.cboSales.ValueMember = "Kode_Sales"
        '
        'TBLSalesBindingSource
        '
        Me.TBLSalesBindingSource.DataMember = "TBL_Sales"
        Me.TBLSalesBindingSource.DataSource = Me.Db_POS_CNDataSet
        '
        'Db_POS_CNDataSet
        '
        Me.Db_POS_CNDataSet.DataSetName = "db_POS_CNDataSet"
        Me.Db_POS_CNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(461, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Sales"
        '
        'dtpAkhir
        '
        Me.dtpAkhir.Location = New System.Drawing.Point(234, 12)
        Me.dtpAkhir.Name = "dtpAkhir"
        Me.dtpAkhir.Size = New System.Drawing.Size(200, 20)
        Me.dtpAkhir.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(218, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "-"
        '
        'dtpAwal
        '
        Me.dtpAwal.Location = New System.Drawing.Point(12, 12)
        Me.dtpAwal.Name = "dtpAwal"
        Me.dtpAwal.Size = New System.Drawing.Size(200, 20)
        Me.dtpAwal.TabIndex = 0
        '
        'crvPembelian
        '
        Me.crvPembelian.ActiveViewIndex = -1
        Me.crvPembelian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvPembelian.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvPembelian.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvPembelian.Location = New System.Drawing.Point(0, 0)
        Me.crvPembelian.Name = "crvPembelian"
        Me.crvPembelian.ShowGroupTreeButton = False
        Me.crvPembelian.ShowLogo = False
        Me.crvPembelian.Size = New System.Drawing.Size(958, 450)
        Me.crvPembelian.TabIndex = 1
        Me.crvPembelian.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Query_Laporan_PenjualanTableAdapter
        '
        Me.Query_Laporan_PenjualanTableAdapter.ClearBeforeFill = True
        '
        'TBL_SalesTableAdapter
        '
        Me.TBL_SalesTableAdapter.ClearBeforeFill = True
        '
        'FRM_RPT_Penjualan_Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 500)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_RPT_Penjualan_Sales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form Laporan Penjualan per Sales"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.TBLSalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_POS_CNDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dtpAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents crvPembelian As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Db_POS_CNDataSet As Best_POS.db_POS_CNDataSet
    Friend WithEvents Query_Laporan_PenjualanTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.Query_Laporan_PenjualanTableAdapter
    Friend WithEvents btnTampil As System.Windows.Forms.Button
    Friend WithEvents cboSales As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBLSalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_SalesTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_SalesTableAdapter
End Class
