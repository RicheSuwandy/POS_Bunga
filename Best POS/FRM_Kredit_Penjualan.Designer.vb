<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Kredit_Penjualan
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
        Me.txtSisa = New System.Windows.Forms.TextBox()
        Me.txtTotalHarga = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpBayar = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKodePenjualan = New System.Windows.Forms.TextBox()
        Me.TbL_PiutangTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_PiutangTableAdapter()
        Me.TbL_Penjualan_HeaderTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Penjualan_HeaderTableAdapter()
        Me.txtDP = New C1.Win.C1Input.C1TextBox()
        Me.txtNoBon = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.txtDP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSisa
        '
        Me.txtSisa.Location = New System.Drawing.Point(102, 121)
        Me.txtSisa.Name = "txtSisa"
        Me.txtSisa.ReadOnly = True
        Me.txtSisa.Size = New System.Drawing.Size(129, 20)
        Me.txtSisa.TabIndex = 80
        '
        'txtTotalHarga
        '
        Me.txtTotalHarga.Location = New System.Drawing.Point(102, 69)
        Me.txtTotalHarga.Name = "txtTotalHarga"
        Me.txtTotalHarga.ReadOnly = True
        Me.txtTotalHarga.Size = New System.Drawing.Size(129, 20)
        Me.txtTotalHarga.TabIndex = 78
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Sisa"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(189, 183)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 83
        Me.Button2.Text = "&Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(102, 183)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 82
        Me.Button1.Text = "&Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpBayar
        '
        Me.dtpBayar.Location = New System.Drawing.Point(102, 147)
        Me.dtpBayar.Name = "dtpBayar"
        Me.dtpBayar.Size = New System.Drawing.Size(169, 20)
        Me.dtpBayar.TabIndex = 81
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Tgl Penagihan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "DP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Total Harga"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "No Faktur"
        '
        'txtKodePenjualan
        '
        Me.txtKodePenjualan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodePenjualan.Location = New System.Drawing.Point(102, 15)
        Me.txtKodePenjualan.Name = "txtKodePenjualan"
        Me.txtKodePenjualan.ReadOnly = True
        Me.txtKodePenjualan.Size = New System.Drawing.Size(129, 22)
        Me.txtKodePenjualan.TabIndex = 77
        '
        'TbL_PiutangTableAdapter
        '
        Me.TbL_PiutangTableAdapter.ClearBeforeFill = True
        '
        'TbL_Penjualan_HeaderTableAdapter
        '
        Me.TbL_Penjualan_HeaderTableAdapter.ClearBeforeFill = True
        '
        'txtDP
        '
        Me.txtDP.DataType = GetType(Decimal)
        Me.txtDP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDP.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtDP.Location = New System.Drawing.Point(102, 95)
        Me.txtDP.Name = "txtDP"
        Me.txtDP.Size = New System.Drawing.Size(129, 18)
        Me.txtDP.TabIndex = 406
        Me.txtDP.Tag = Nothing
        '
        'txtNoBon
        '
        Me.txtNoBon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoBon.Location = New System.Drawing.Point(102, 41)
        Me.txtNoBon.Name = "txtNoBon"
        Me.txtNoBon.ReadOnly = True
        Me.txtNoBon.Size = New System.Drawing.Size(129, 22)
        Me.txtNoBon.TabIndex = 77
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "No. Bon"
        '
        'FRM_Kredit_Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 220)
        Me.Controls.Add(Me.txtDP)
        Me.Controls.Add(Me.txtSisa)
        Me.Controls.Add(Me.txtTotalHarga)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtpBayar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNoBon)
        Me.Controls.Add(Me.txtKodePenjualan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FRM_Kredit_Penjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form Pembayaran Kredit"
        CType(Me.txtDP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSisa As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalHarga As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtpBayar As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKodePenjualan As System.Windows.Forms.TextBox
    Friend WithEvents TbL_PiutangTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_PiutangTableAdapter
    Friend WithEvents TbL_Penjualan_HeaderTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Penjualan_HeaderTableAdapter
    Friend WithEvents txtDP As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtNoBon As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
