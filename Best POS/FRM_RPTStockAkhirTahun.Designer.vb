﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_RPTStockAkhirTahun
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
        Me.crvPembelian = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.RptStockAkhirTahun = New Best_POS.db_POS_CNDataSetTableAdapters.RPTStockAkhirTahun()
        Me.SuspendLayout()
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
        Me.crvPembelian.Size = New System.Drawing.Size(784, 561)
        Me.crvPembelian.TabIndex = 2
        Me.crvPembelian.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'RptStockAkhirTahun
        '
        Me.RptStockAkhirTahun.ClearBeforeFill = True
        '
        'FRM_RPTStockAkhirTahun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.crvPembelian)
        Me.Name = "FRM_RPTStockAkhirTahun"
        Me.Text = "Form Laporan Stock Akhir Tahun"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvPembelian As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents RptStockAkhirTahun As Best_POS.db_POS_CNDataSetTableAdapters.RPTStockAkhirTahun
End Class
