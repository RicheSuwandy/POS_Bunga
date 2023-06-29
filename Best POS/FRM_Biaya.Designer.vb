<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Biaya
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Biaya))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbL_RPT_Laba_RugiTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_RPT_Laba_RugiTableAdapter()
        Me.Db_POS_CNDataSet = New Best_POS.db_POS_CNDataSet()
        Me.TBLRPTLabaRugiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        'Me.txtBiayaOperasional = New C1.Win.C1Input.C1TextBox()
        'Me.txtGajiKaryawan = New C1.Win.C1Input.C1TextBox()
        'Me.txtBiayaLain2 = New C1.Win.C1Input.C1TextBox()
        CType(Me.Db_POS_CNDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLRPTLabaRugiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBiayaOperasional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGajiKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBiayaLain2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(224, 102)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 40
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(143, 102)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 39
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Biaya Operasional"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Gaji Karyawan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Biaya Lain-Lain"
        '
        'TbL_RPT_Laba_RugiTableAdapter
        '
        Me.TbL_RPT_Laba_RugiTableAdapter.ClearBeforeFill = True
        '
        'Db_POS_CNDataSet
        '
        Me.Db_POS_CNDataSet.DataSetName = "db_POS_CNDataSet"
        Me.Db_POS_CNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBLRPTLabaRugiBindingSource
        '
        Me.TBLRPTLabaRugiBindingSource.DataMember = "TBL_RPT_Laba_Rugi"
        Me.TBLRPTLabaRugiBindingSource.DataSource = Me.Db_POS_CNDataSet
        '
        'txtBiayaOperasional
        '
        Me.txtBiayaOperasional.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBLRPTLabaRugiBindingSource, "Biaya_Operasional", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C0"))
        Me.txtBiayaOperasional.DataType = GetType(Decimal)
        Me.txtBiayaOperasional.DisableOnNoData = False
        Me.txtBiayaOperasional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBiayaOperasional.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtBiayaOperasional.Location = New System.Drawing.Point(143, 15)
        Me.txtBiayaOperasional.Name = "txtBiayaOperasional"
        Me.txtBiayaOperasional.Size = New System.Drawing.Size(156, 20)
        Me.txtBiayaOperasional.TabIndex = 73
        Me.txtBiayaOperasional.Tag = Nothing
        '
        'txtGajiKaryawan
        '
        Me.txtGajiKaryawan.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBLRPTLabaRugiBindingSource, "Gaji_Karyawan", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C0"))
        Me.txtGajiKaryawan.DataType = GetType(Decimal)
        Me.txtGajiKaryawan.DisableOnNoData = False
        Me.txtGajiKaryawan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGajiKaryawan.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtGajiKaryawan.Location = New System.Drawing.Point(143, 41)
        Me.txtGajiKaryawan.Name = "txtGajiKaryawan"
        Me.txtGajiKaryawan.Size = New System.Drawing.Size(156, 20)
        Me.txtGajiKaryawan.TabIndex = 74
        Me.txtGajiKaryawan.Tag = Nothing
        '
        'txtBiayaLain2
        '
        Me.txtBiayaLain2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TBLRPTLabaRugiBindingSource, "Biaya_Lain2", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C0"))
        Me.txtBiayaLain2.DataType = GetType(Decimal)
        Me.txtBiayaLain2.DisableOnNoData = False
        Me.txtBiayaLain2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBiayaLain2.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtBiayaLain2.Location = New System.Drawing.Point(143, 67)
        Me.txtBiayaLain2.Name = "txtBiayaLain2"
        Me.txtBiayaLain2.Size = New System.Drawing.Size(156, 20)
        Me.txtBiayaLain2.TabIndex = 75
        Me.txtBiayaLain2.Tag = Nothing
        '
        'FRM_Biaya
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 140)
        Me.Controls.Add(Me.txtBiayaLain2)
        Me.Controls.Add(Me.txtGajiKaryawan)
        Me.Controls.Add(Me.txtBiayaOperasional)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FRM_Biaya"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form Biaya Bulanan"
        CType(Me.Db_POS_CNDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLRPTLabaRugiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBiayaOperasional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGajiKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBiayaLain2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TbL_RPT_Laba_RugiTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_RPT_Laba_RugiTableAdapter
    Friend WithEvents TBLRPTLabaRugiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Db_POS_CNDataSet As Best_POS.db_POS_CNDataSet
    Friend WithEvents txtBiayaOperasional As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtGajiKaryawan As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtBiayaLain2 As C1.Win.C1Input.C1TextBox
End Class
