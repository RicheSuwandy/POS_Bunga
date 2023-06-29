<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_RPT_Barang
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
        Me.crvBarang = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TbL_BarangTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_BarangTableAdapter()
        Me.QueryLaporanBarangTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.QueryLaporanBarangTableAdapter()
        Me.SuspendLayout()
        '
        'crvBarang
        '
        Me.crvBarang.ActiveViewIndex = -1
        Me.crvBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvBarang.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvBarang.Location = New System.Drawing.Point(0, 0)
        Me.crvBarang.Name = "crvBarang"
        Me.crvBarang.ShowGroupTreeButton = False
        Me.crvBarang.ShowLogo = False
        Me.crvBarang.Size = New System.Drawing.Size(857, 476)
        Me.crvBarang.TabIndex = 0
        Me.crvBarang.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'TbL_BarangTableAdapter
        '
        Me.TbL_BarangTableAdapter.ClearBeforeFill = True
        '
        'QueryLaporanBarangTableAdapter
        '
        Me.QueryLaporanBarangTableAdapter.ClearBeforeFill = True
        '
        'FRM_RPT_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 476)
        Me.Controls.Add(Me.crvBarang)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FRM_RPT_Barang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Stok barang"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvBarang As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TbL_BarangTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_BarangTableAdapter
    Friend WithEvents QueryLaporanBarangTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.QueryLaporanBarangTableAdapter
End Class
