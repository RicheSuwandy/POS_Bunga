﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Customer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Customer))
        Me.bnCustomer = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TBLCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_POS_CNDataSet = New Best_POS.db_POS_CNDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsTambah = New System.Windows.Forms.ToolStripButton()
        Me.tsSimpan = New System.Windows.Forms.ToolStripButton()
        Me.tsHapus = New System.Windows.Forms.ToolStripButton()
        Me.tsRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtKataKunci = New System.Windows.Forms.ToolStripTextBox()
        Me.cboKriteria = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKodeCust = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNamaCust = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKota = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTelepon = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHP = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.cfgCustomer = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.TBL_CustomerTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_CustomerTableAdapter()
        Me.TbL_Penjualan_HeaderTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_Penjualan_HeaderTableAdapter()
        CType(Me.bnCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnCustomer.SuspendLayout()
        CType(Me.TBLCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_POS_CNDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cfgCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bnCustomer
        '
        Me.bnCustomer.AddNewItem = Nothing
        Me.bnCustomer.BindingSource = Me.TBLCustomerBindingSource
        Me.bnCustomer.CountItem = Me.BindingNavigatorCountItem
        Me.bnCustomer.DeleteItem = Nothing
        Me.bnCustomer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.tsTambah, Me.tsSimpan, Me.tsHapus, Me.tsRefresh, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.txtKataKunci, Me.cboKriteria, Me.ToolStripSeparator3})
        Me.bnCustomer.Location = New System.Drawing.Point(0, 0)
        Me.bnCustomer.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnCustomer.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnCustomer.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnCustomer.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnCustomer.Name = "bnCustomer"
        Me.bnCustomer.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.bnCustomer.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnCustomer.Size = New System.Drawing.Size(1324, 33)
        Me.bnCustomer.TabIndex = 54
        Me.bnCustomer.Text = "BindingNavigator1"
        '
        'TBLCustomerBindingSource
        '
        Me.TBLCustomerBindingSource.DataMember = "TBL_Customer"
        Me.TBLCustomerBindingSource.DataSource = Me.Db_POS_CNDataSet
        '
        'Db_POS_CNDataSet
        '
        Me.Db_POS_CNDataSet.DataSetName = "db_POS_CNDataSet"
        Me.Db_POS_CNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 30)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 30)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 30)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(73, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 30)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 30)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'tsTambah
        '
        Me.tsTambah.Image = CType(resources.GetObject("tsTambah.Image"), System.Drawing.Image)
        Me.tsTambah.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsTambah.Name = "tsTambah"
        Me.tsTambah.Size = New System.Drawing.Size(66, 30)
        Me.tsTambah.Text = "&Add"
        '
        'tsSimpan
        '
        Me.tsSimpan.Image = CType(resources.GetObject("tsSimpan.Image"), System.Drawing.Image)
        Me.tsSimpan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSimpan.Name = "tsSimpan"
        Me.tsSimpan.Size = New System.Drawing.Size(69, 30)
        Me.tsSimpan.Text = "&Save"
        '
        'tsHapus
        '
        Me.tsHapus.Image = CType(resources.GetObject("tsHapus.Image"), System.Drawing.Image)
        Me.tsHapus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsHapus.Name = "tsHapus"
        Me.tsHapus.Size = New System.Drawing.Size(82, 30)
        Me.tsHapus.Text = "&Delete"
        '
        'tsRefresh
        '
        Me.tsRefresh.Image = CType(resources.GetObject("tsRefresh.Image"), System.Drawing.Image)
        Me.tsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsRefresh.Name = "tsRefresh"
        Me.tsRefresh.Size = New System.Drawing.Size(90, 30)
        Me.tsRefresh.Text = "&Refresh"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Image = CType(resources.GetObject("ToolStripLabel1.Image"), System.Drawing.Image)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(80, 30)
        Me.ToolStripLabel1.Text = "Search"
        '
        'txtKataKunci
        '
        Me.txtKataKunci.Name = "txtKataKunci"
        Me.txtKataKunci.Size = New System.Drawing.Size(148, 33)
        '
        'cboKriteria
        '
        Me.cboKriteria.Items.AddRange(New Object() {"Kode Customer", "Nama Customer"})
        Me.cboKriteria.Name = "cboKriteria"
        Me.cboKriteria.Size = New System.Drawing.Size(180, 33)
        Me.cboKriteria.Sorted = True
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 33)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 25)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Kode Customer *"
        '
        'txtKodeCust
        '
        Me.txtKodeCust.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLCustomerBindingSource, "Kode_Customer", True))
        Me.txtKodeCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeCust.Location = New System.Drawing.Point(255, 65)
        Me.txtKodeCust.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtKodeCust.Name = "txtKodeCust"
        Me.txtKodeCust.Size = New System.Drawing.Size(210, 30)
        Me.txtKodeCust.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 112)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 25)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Nama Customer *"
        '
        'txtNamaCust
        '
        Me.txtNamaCust.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLCustomerBindingSource, "Nama_Customer", True))
        Me.txtNamaCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaCust.Location = New System.Drawing.Point(255, 108)
        Me.txtNamaCust.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNamaCust.Name = "txtNamaCust"
        Me.txtNamaCust.Size = New System.Drawing.Size(310, 30)
        Me.txtNamaCust.TabIndex = 68
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 155)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 25)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Alamat"
        '
        'txtAlamat
        '
        Me.txtAlamat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLCustomerBindingSource, "Alamat", True))
        Me.txtAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamat.Location = New System.Drawing.Point(255, 151)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(367, 95)
        Me.txtAlamat.TabIndex = 70
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 262)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 25)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Kota"
        '
        'txtKota
        '
        Me.txtKota.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLCustomerBindingSource, "Kota", True))
        Me.txtKota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKota.Location = New System.Drawing.Point(255, 257)
        Me.txtKota.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtKota.Name = "txtKota"
        Me.txtKota.Size = New System.Drawing.Size(271, 30)
        Me.txtKota.TabIndex = 72
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 305)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 25)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Telepon"
        '
        'txtTelepon
        '
        Me.txtTelepon.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLCustomerBindingSource, "Telepon", True))
        Me.txtTelepon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelepon.Location = New System.Drawing.Point(255, 300)
        Me.txtTelepon.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTelepon.Name = "txtTelepon"
        Me.txtTelepon.Size = New System.Drawing.Size(254, 30)
        Me.txtTelepon.TabIndex = 74
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 348)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 25)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "HP"
        '
        'txtHP
        '
        Me.txtHP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLCustomerBindingSource, "HP", True))
        Me.txtHP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHP.Location = New System.Drawing.Point(255, 343)
        Me.txtHP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtHP.Name = "txtHP"
        Me.txtHP.Size = New System.Drawing.Size(254, 30)
        Me.txtHP.TabIndex = 76
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 391)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 25)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Fax"
        '
        'txtFax
        '
        Me.txtFax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLCustomerBindingSource, "Fax", True))
        Me.txtFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax.Location = New System.Drawing.Point(255, 386)
        Me.txtFax.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(254, 30)
        Me.txtFax.TabIndex = 78
        '
        'cfgCustomer
        '
        Me.cfgCustomer.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.cfgCustomer.AllowEditing = False
        Me.cfgCustomer.AllowFiltering = True
        Me.cfgCustomer.ColumnInfo = resources.GetString("cfgCustomer.ColumnInfo")
        Me.cfgCustomer.DataSource = Me.TBLCustomerBindingSource
        Me.cfgCustomer.Location = New System.Drawing.Point(36, 429)
        Me.cfgCustomer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cfgCustomer.Name = "cfgCustomer"
        Me.cfgCustomer.Rows.Count = 1
        Me.cfgCustomer.Rows.DefaultSize = 19
        Me.cfgCustomer.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.cfgCustomer.Size = New System.Drawing.Size(1250, 481)
        Me.cfgCustomer.StyleInfo = resources.GetString("cfgCustomer.StyleInfo")
        Me.cfgCustomer.TabIndex = 80
        Me.cfgCustomer.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'TBL_CustomerTableAdapter
        '
        Me.TBL_CustomerTableAdapter.ClearBeforeFill = True
        '
        'TbL_Penjualan_HeaderTableAdapter
        '
        Me.TbL_Penjualan_HeaderTableAdapter.ClearBeforeFill = True
        '
        'FRM_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1324, 942)
        Me.Controls.Add(Me.cfgCustomer)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtHP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTelepon)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtKota)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNamaCust)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKodeCust)
        Me.Controls.Add(Me.bnCustomer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "FRM_Customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form Customer"
        CType(Me.bnCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnCustomer.ResumeLayout(False)
        Me.bnCustomer.PerformLayout()
        CType(Me.TBLCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_POS_CNDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cfgCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bnCustomer As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsTambah As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSimpan As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsHapus As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtKataKunci As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents cboKriteria As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKodeCust As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNamaCust As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtKota As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTelepon As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtHP As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents cfgCustomer As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Db_POS_CNDataSet As Best_POS.db_POS_CNDataSet
    Friend WithEvents TBLCustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_CustomerTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_CustomerTableAdapter
    Friend WithEvents TbL_Penjualan_HeaderTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_Penjualan_HeaderTableAdapter
End Class
