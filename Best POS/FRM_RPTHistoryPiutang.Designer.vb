<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_RPTHistoryPiutang
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
        Me.dtpAkhir = New System.Windows.Forms.DateTimePicker()
        Me.crvPembelian = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnTampil = New System.Windows.Forms.Button()
        Me.TBL_CustomerTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_CustomerTableAdapter()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpAwal = New System.Windows.Forms.DateTimePicker()
        Me.VwRptCashKreditTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.VwRptCashKreditTableAdapter()
        Me.Db_POS_CNDataSet = New Best_POS.db_POS_CNDataSet()
        Me.VwRptHistoryPiutangTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.VwRptHistoryPiutangTableAdapter()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Db_POS_CNDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpAkhir
        '
        Me.dtpAkhir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAkhir.Location = New System.Drawing.Point(124, 12)
        Me.dtpAkhir.Name = "dtpAkhir"
        Me.dtpAkhir.Size = New System.Drawing.Size(88, 20)
        Me.dtpAkhir.TabIndex = 2
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
        Me.crvPembelian.Size = New System.Drawing.Size(784, 506)
        Me.crvPembelian.TabIndex = 1
        Me.crvPembelian.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'btnTampil
        '
        Me.btnTampil.Location = New System.Drawing.Point(400, 12)
        Me.btnTampil.Name = "btnTampil"
        Me.btnTampil.Size = New System.Drawing.Size(75, 23)
        Me.btnTampil.TabIndex = 8
        Me.btnTampil.Text = "Tampil"
        Me.btnTampil.UseVisualStyleBackColor = True
        '
        'TBL_CustomerTableAdapter
        '
        Me.TBL_CustomerTableAdapter.ClearBeforeFill = True
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpAkhir)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpAwal)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.crvPembelian)
        Me.SplitContainer1.Size = New System.Drawing.Size(784, 561)
        Me.SplitContainer1.SplitterDistance = 51
        Me.SplitContainer1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(107, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "-"
        '
        'dtpAwal
        '
        Me.dtpAwal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAwal.Location = New System.Drawing.Point(12, 12)
        Me.dtpAwal.Name = "dtpAwal"
        Me.dtpAwal.Size = New System.Drawing.Size(88, 20)
        Me.dtpAwal.TabIndex = 0
        '
        'VwRptCashKreditTableAdapter
        '
        Me.VwRptCashKreditTableAdapter.ClearBeforeFill = True
        '
        'Db_POS_CNDataSet
        '
        Me.Db_POS_CNDataSet.DataSetName = "db_POS_CNDataSet"
        Me.Db_POS_CNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwRptHistoryPiutangTableAdapter
        '
        Me.VwRptHistoryPiutangTableAdapter.ClearBeforeFill = True
        '
        'FRM_RPTHistoryPiutang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FRM_RPTHistoryPiutang"
        Me.Text = "Form Laporan Rekap History Piutang"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Db_POS_CNDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtpAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents crvPembelian As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnTampil As System.Windows.Forms.Button
    Friend WithEvents TBL_CustomerTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_CustomerTableAdapter
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents VwRptCashKreditTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.VwRptCashKreditTableAdapter
    Friend WithEvents Db_POS_CNDataSet As Best_POS.db_POS_CNDataSet
    Friend WithEvents VwRptHistoryPiutangTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.VwRptHistoryPiutangTableAdapter
End Class
