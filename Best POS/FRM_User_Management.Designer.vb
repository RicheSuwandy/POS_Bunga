<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_User_Management
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_User_Management))
        Me.cfgUser = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.TBLUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_POS_CNDataSet = New Best_POS.db_POS_CNDataSet()
        Me.bnUser = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.tsHapus = New System.Windows.Forms.ToolStripButton()
        Me.tsChangePass = New System.Windows.Forms.ToolStripButton()
        Me.tsResetPass = New System.Windows.Forms.ToolStripButton()
        Me.tsHakAkses = New System.Windows.Forms.ToolStripButton()
        Me.TBL_UserTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_UserTableAdapter()
        CType(Me.cfgUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_POS_CNDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bnUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnUser.SuspendLayout()
        Me.SuspendLayout()
        '
        'cfgUser
        '
        Me.cfgUser.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.cfgUser.AllowEditing = False
        Me.cfgUser.AllowFiltering = True
        Me.cfgUser.ColumnInfo = "2,1,0,0,0,95,Columns:1{Width:527;Name:""Username"";Caption:""Username"";Style:""DataTy" & _
            "pe:System.String;TextAlign:LeftCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.cfgUser.DataSource = Me.TBLUserBindingSource
        Me.cfgUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cfgUser.Location = New System.Drawing.Point(0, 25)
        Me.cfgUser.Name = "cfgUser"
        Me.cfgUser.Rows.Count = 1
        Me.cfgUser.Rows.DefaultSize = 19
        Me.cfgUser.Size = New System.Drawing.Size(594, 415)
        Me.cfgUser.TabIndex = 4
        Me.cfgUser.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'TBLUserBindingSource
        '
        Me.TBLUserBindingSource.DataMember = "TBL_User"
        Me.TBLUserBindingSource.DataSource = Me.Db_POS_CNDataSet
        '
        'Db_POS_CNDataSet
        '
        Me.Db_POS_CNDataSet.DataSetName = "db_POS_CNDataSet"
        Me.Db_POS_CNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bnUser
        '
        Me.bnUser.AddNewItem = Nothing
        Me.bnUser.BindingSource = Me.TBLUserBindingSource
        Me.bnUser.CountItem = Me.BindingNavigatorCountItem
        Me.bnUser.DeleteItem = Nothing
        Me.bnUser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.tsTambah, Me.tsHapus, Me.tsChangePass, Me.tsResetPass, Me.tsHakAkses})
        Me.bnUser.Location = New System.Drawing.Point(0, 0)
        Me.bnUser.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnUser.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnUser.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnUser.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnUser.Name = "bnUser"
        Me.bnUser.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnUser.Size = New System.Drawing.Size(594, 25)
        Me.bnUser.TabIndex = 3
        Me.bnUser.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsTambah
        '
        Me.tsTambah.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsTambah.Image = CType(resources.GetObject("tsTambah.Image"), System.Drawing.Image)
        Me.tsTambah.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsTambah.Name = "tsTambah"
        Me.tsTambah.Size = New System.Drawing.Size(55, 22)
        Me.tsTambah.Text = "&Tambah"
        '
        'tsHapus
        '
        Me.tsHapus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsHapus.Image = CType(resources.GetObject("tsHapus.Image"), System.Drawing.Image)
        Me.tsHapus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsHapus.Name = "tsHapus"
        Me.tsHapus.Size = New System.Drawing.Size(45, 22)
        Me.tsHapus.Text = "&Hapus"
        '
        'tsChangePass
        '
        Me.tsChangePass.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsChangePass.Image = CType(resources.GetObject("tsChangePass.Image"), System.Drawing.Image)
        Me.tsChangePass.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsChangePass.Name = "tsChangePass"
        Me.tsChangePass.Size = New System.Drawing.Size(105, 22)
        Me.tsChangePass.Text = "&Change Password"
        '
        'tsResetPass
        '
        Me.tsResetPass.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsResetPass.Image = CType(resources.GetObject("tsResetPass.Image"), System.Drawing.Image)
        Me.tsResetPass.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsResetPass.Name = "tsResetPass"
        Me.tsResetPass.Size = New System.Drawing.Size(92, 22)
        Me.tsResetPass.Text = "&Reset Password"
        '
        'tsHakAkses
        '
        Me.tsHakAkses.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsHakAkses.Image = CType(resources.GetObject("tsHakAkses.Image"), System.Drawing.Image)
        Me.tsHakAkses.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsHakAkses.Name = "tsHakAkses"
        Me.tsHakAkses.Size = New System.Drawing.Size(65, 22)
        Me.tsHakAkses.Text = "&Hak Akses"
        '
        'TBL_UserTableAdapter
        '
        Me.TBL_UserTableAdapter.ClearBeforeFill = True
        '
        'FRM_User_Management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 440)
        Me.Controls.Add(Me.cfgUser)
        Me.Controls.Add(Me.bnUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FRM_User_Management"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form User Management"
        CType(Me.cfgUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_POS_CNDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bnUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnUser.ResumeLayout(False)
        Me.bnUser.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cfgUser As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents bnUser As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents tsHapus As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsChangePass As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsResetPass As System.Windows.Forms.ToolStripButton
    Friend WithEvents Db_POS_CNDataSet As Best_POS.db_POS_CNDataSet
    Friend WithEvents TBLUserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_UserTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_UserTableAdapter
    Friend WithEvents tsHakAkses As System.Windows.Forms.ToolStripButton
End Class
