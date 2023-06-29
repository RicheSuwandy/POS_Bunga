<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Hak_Akses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Hak_Akses))
        Me.lblUser = New System.Windows.Forms.Label()
        Me.TBLUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_POS_CNDataSet = New Best_POS.db_POS_CNDataSet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkHakAkses = New System.Windows.Forms.CheckBox()
        Me.chkResetPassword = New System.Windows.Forms.CheckBox()
        Me.chkHapusUser = New System.Windows.Forms.CheckBox()
        Me.chkTambahUser = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkBarang = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkHutang = New System.Windows.Forms.CheckBox()
        Me.chkSupplier = New System.Windows.Forms.CheckBox()
        Me.chkReturBeli = New System.Windows.Forms.CheckBox()
        Me.chkFakturBeli = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkPiutang = New System.Windows.Forms.CheckBox()
        Me.chkCustomer = New System.Windows.Forms.CheckBox()
        Me.chkSales = New System.Windows.Forms.CheckBox()
        Me.chkReturJual = New System.Windows.Forms.CheckBox()
        Me.chkFakturJual = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chkHargaSupplier = New System.Windows.Forms.CheckBox()
        Me.chkHargaCustomer = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.chkLapLabaRugi = New System.Windows.Forms.CheckBox()
        Me.chkLapPiutang = New System.Windows.Forms.CheckBox()
        Me.chkLapHutang = New System.Windows.Forms.CheckBox()
        Me.chkLapReturJual = New System.Windows.Forms.CheckBox()
        Me.chkLapReturBeli = New System.Windows.Forms.CheckBox()
        Me.chkLapJualSales = New System.Windows.Forms.CheckBox()
        Me.chkLapJualCustomer = New System.Windows.Forms.CheckBox()
        Me.chkLapJualPeriode = New System.Windows.Forms.CheckBox()
        Me.chkLapBeliSupplier = New System.Windows.Forms.CheckBox()
        Me.chkLapBeliPeriode = New System.Windows.Forms.CheckBox()
        Me.chkLapBarang = New System.Windows.Forms.CheckBox()
        Me.TBL_UserTableAdapter = New Best_POS.db_POS_CNDataSetTableAdapters.TBL_UserTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.chkBiayaOperasional = New System.Windows.Forms.CheckBox()
        Me.chkEditFakturBeli = New System.Windows.Forms.CheckBox()
        Me.chkEditFakturJual = New System.Windows.Forms.CheckBox()
        CType(Me.TBLUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_POS_CNDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLUserBindingSource, "Username", True))
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(91, 19)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(63, 13)
        Me.lblUser.TabIndex = 36
        Me.lblUser.Text = "Username"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Username :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkHakAkses)
        Me.GroupBox1.Controls.Add(Me.chkResetPassword)
        Me.GroupBox1.Controls.Add(Me.chkHapusUser)
        Me.GroupBox1.Controls.Add(Me.chkTambahUser)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(162, 122)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Management"
        '
        'chkHakAkses
        '
        Me.chkHakAkses.AutoSize = True
        Me.chkHakAkses.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Hak_Akses", True))
        Me.chkHakAkses.Location = New System.Drawing.Point(15, 98)
        Me.chkHakAkses.Name = "chkHakAkses"
        Me.chkHakAkses.Size = New System.Drawing.Size(78, 17)
        Me.chkHakAkses.TabIndex = 3
        Me.chkHakAkses.Text = "Hak Akses"
        Me.chkHakAkses.UseVisualStyleBackColor = True
        '
        'chkResetPassword
        '
        Me.chkResetPassword.AutoSize = True
        Me.chkResetPassword.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Reset_Password", True))
        Me.chkResetPassword.Location = New System.Drawing.Point(15, 75)
        Me.chkResetPassword.Name = "chkResetPassword"
        Me.chkResetPassword.Size = New System.Drawing.Size(128, 17)
        Me.chkResetPassword.TabIndex = 2
        Me.chkResetPassword.Text = "Reset Password User"
        Me.chkResetPassword.UseVisualStyleBackColor = True
        '
        'chkHapusUser
        '
        Me.chkHapusUser.AutoSize = True
        Me.chkHapusUser.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Hapus_User", True))
        Me.chkHapusUser.Location = New System.Drawing.Point(15, 52)
        Me.chkHapusUser.Name = "chkHapusUser"
        Me.chkHapusUser.Size = New System.Drawing.Size(82, 17)
        Me.chkHapusUser.TabIndex = 1
        Me.chkHapusUser.Text = "Hapus User"
        Me.chkHapusUser.UseVisualStyleBackColor = True
        '
        'chkTambahUser
        '
        Me.chkTambahUser.AutoSize = True
        Me.chkTambahUser.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Tambah_User", True))
        Me.chkTambahUser.Location = New System.Drawing.Point(15, 29)
        Me.chkTambahUser.Name = "chkTambahUser"
        Me.chkTambahUser.Size = New System.Drawing.Size(90, 17)
        Me.chkTambahUser.TabIndex = 0
        Me.chkTambahUser.Text = "Tambah User"
        Me.chkTambahUser.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkBarang)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 244)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(162, 51)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Stok Barang"
        '
        'chkBarang
        '
        Me.chkBarang.AutoSize = True
        Me.chkBarang.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Barang", True))
        Me.chkBarang.Location = New System.Drawing.Point(15, 25)
        Me.chkBarang.Name = "chkBarang"
        Me.chkBarang.Size = New System.Drawing.Size(60, 17)
        Me.chkBarang.TabIndex = 0
        Me.chkBarang.Text = "Barang"
        Me.chkBarang.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkEditFakturBeli)
        Me.GroupBox3.Controls.Add(Me.chkHutang)
        Me.GroupBox3.Controls.Add(Me.chkSupplier)
        Me.GroupBox3.Controls.Add(Me.chkReturBeli)
        Me.GroupBox3.Controls.Add(Me.chkFakturBeli)
        Me.GroupBox3.Location = New System.Drawing.Point(192, 54)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(162, 147)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pembelian"
        '
        'chkHutang
        '
        Me.chkHutang.AutoSize = True
        Me.chkHutang.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Hutang", True))
        Me.chkHutang.Location = New System.Drawing.Point(15, 98)
        Me.chkHutang.Name = "chkHutang"
        Me.chkHutang.Size = New System.Drawing.Size(61, 17)
        Me.chkHutang.TabIndex = 3
        Me.chkHutang.Text = "Hutang"
        Me.chkHutang.UseVisualStyleBackColor = True
        '
        'chkSupplier
        '
        Me.chkSupplier.AutoSize = True
        Me.chkSupplier.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Supplier", True))
        Me.chkSupplier.Location = New System.Drawing.Point(15, 75)
        Me.chkSupplier.Name = "chkSupplier"
        Me.chkSupplier.Size = New System.Drawing.Size(64, 17)
        Me.chkSupplier.TabIndex = 2
        Me.chkSupplier.Text = "Supplier"
        Me.chkSupplier.UseVisualStyleBackColor = True
        '
        'chkReturBeli
        '
        Me.chkReturBeli.AutoSize = True
        Me.chkReturBeli.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Retur_Pembelian", True))
        Me.chkReturBeli.Location = New System.Drawing.Point(15, 52)
        Me.chkReturBeli.Name = "chkReturBeli"
        Me.chkReturBeli.Size = New System.Drawing.Size(104, 17)
        Me.chkReturBeli.TabIndex = 1
        Me.chkReturBeli.Text = "Retur Pembelian"
        Me.chkReturBeli.UseVisualStyleBackColor = True
        '
        'chkFakturBeli
        '
        Me.chkFakturBeli.AutoSize = True
        Me.chkFakturBeli.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Faktur_Pembelian", True))
        Me.chkFakturBeli.Location = New System.Drawing.Point(15, 29)
        Me.chkFakturBeli.Name = "chkFakturBeli"
        Me.chkFakturBeli.Size = New System.Drawing.Size(108, 17)
        Me.chkFakturBeli.TabIndex = 0
        Me.chkFakturBeli.Text = "Faktur Pembelian"
        Me.chkFakturBeli.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkEditFakturJual)
        Me.GroupBox4.Controls.Add(Me.chkPiutang)
        Me.GroupBox4.Controls.Add(Me.chkCustomer)
        Me.GroupBox4.Controls.Add(Me.chkSales)
        Me.GroupBox4.Controls.Add(Me.chkReturJual)
        Me.GroupBox4.Controls.Add(Me.chkFakturJual)
        Me.GroupBox4.Location = New System.Drawing.Point(192, 212)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(162, 175)
        Me.GroupBox4.TabIndex = 40
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Penjualan"
        '
        'chkPiutang
        '
        Me.chkPiutang.AutoSize = True
        Me.chkPiutang.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Piutang", True))
        Me.chkPiutang.Location = New System.Drawing.Point(15, 121)
        Me.chkPiutang.Name = "chkPiutang"
        Me.chkPiutang.Size = New System.Drawing.Size(62, 17)
        Me.chkPiutang.TabIndex = 4
        Me.chkPiutang.Text = "Piutang"
        Me.chkPiutang.UseVisualStyleBackColor = True
        '
        'chkCustomer
        '
        Me.chkCustomer.AutoSize = True
        Me.chkCustomer.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Customer", True))
        Me.chkCustomer.Location = New System.Drawing.Point(15, 98)
        Me.chkCustomer.Name = "chkCustomer"
        Me.chkCustomer.Size = New System.Drawing.Size(70, 17)
        Me.chkCustomer.TabIndex = 3
        Me.chkCustomer.Text = "Customer"
        Me.chkCustomer.UseVisualStyleBackColor = True
        '
        'chkSales
        '
        Me.chkSales.AutoSize = True
        Me.chkSales.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Sales", True))
        Me.chkSales.Location = New System.Drawing.Point(15, 75)
        Me.chkSales.Name = "chkSales"
        Me.chkSales.Size = New System.Drawing.Size(52, 17)
        Me.chkSales.TabIndex = 2
        Me.chkSales.Text = "Sales"
        Me.chkSales.UseVisualStyleBackColor = True
        '
        'chkReturJual
        '
        Me.chkReturJual.AutoSize = True
        Me.chkReturJual.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Retur_Penjualan", True))
        Me.chkReturJual.Location = New System.Drawing.Point(15, 52)
        Me.chkReturJual.Name = "chkReturJual"
        Me.chkReturJual.Size = New System.Drawing.Size(102, 17)
        Me.chkReturJual.TabIndex = 1
        Me.chkReturJual.Text = "Retur Penjualan"
        Me.chkReturJual.UseVisualStyleBackColor = True
        '
        'chkFakturJual
        '
        Me.chkFakturJual.AutoSize = True
        Me.chkFakturJual.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Faktur_Penjualan", True))
        Me.chkFakturJual.Location = New System.Drawing.Point(15, 29)
        Me.chkFakturJual.Name = "chkFakturJual"
        Me.chkFakturJual.Size = New System.Drawing.Size(106, 17)
        Me.chkFakturJual.TabIndex = 0
        Me.chkFakturJual.Text = "Faktur Penjualan"
        Me.chkFakturJual.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkHargaSupplier)
        Me.GroupBox5.Controls.Add(Me.chkHargaCustomer)
        Me.GroupBox5.Location = New System.Drawing.Point(24, 301)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(162, 76)
        Me.GroupBox5.TabIndex = 41
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "History Harga"
        '
        'chkHargaSupplier
        '
        Me.chkHargaSupplier.AutoSize = True
        Me.chkHargaSupplier.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Harga_Supplier", True))
        Me.chkHargaSupplier.Location = New System.Drawing.Point(15, 48)
        Me.chkHargaSupplier.Name = "chkHargaSupplier"
        Me.chkHargaSupplier.Size = New System.Drawing.Size(96, 17)
        Me.chkHargaSupplier.TabIndex = 1
        Me.chkHargaSupplier.Text = "Harga Supplier"
        Me.chkHargaSupplier.UseVisualStyleBackColor = True
        '
        'chkHargaCustomer
        '
        Me.chkHargaCustomer.AutoSize = True
        Me.chkHargaCustomer.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Harga_Customer", True))
        Me.chkHargaCustomer.Location = New System.Drawing.Point(15, 25)
        Me.chkHargaCustomer.Name = "chkHargaCustomer"
        Me.chkHargaCustomer.Size = New System.Drawing.Size(102, 17)
        Me.chkHargaCustomer.TabIndex = 0
        Me.chkHargaCustomer.Text = "Harga Customer"
        Me.chkHargaCustomer.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.chkLapLabaRugi)
        Me.GroupBox6.Controls.Add(Me.chkLapPiutang)
        Me.GroupBox6.Controls.Add(Me.chkLapHutang)
        Me.GroupBox6.Controls.Add(Me.chkLapReturJual)
        Me.GroupBox6.Controls.Add(Me.chkLapReturBeli)
        Me.GroupBox6.Controls.Add(Me.chkLapJualSales)
        Me.GroupBox6.Controls.Add(Me.chkLapJualCustomer)
        Me.GroupBox6.Controls.Add(Me.chkLapJualPeriode)
        Me.GroupBox6.Controls.Add(Me.chkLapBeliSupplier)
        Me.GroupBox6.Controls.Add(Me.chkLapBeliPeriode)
        Me.GroupBox6.Controls.Add(Me.chkLapBarang)
        Me.GroupBox6.Location = New System.Drawing.Point(360, 54)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(162, 290)
        Me.GroupBox6.TabIndex = 42
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Laporan"
        '
        'chkLapLabaRugi
        '
        Me.chkLapLabaRugi.AutoSize = True
        Me.chkLapLabaRugi.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Lap_Laba_Rugi", True))
        Me.chkLapLabaRugi.Location = New System.Drawing.Point(15, 259)
        Me.chkLapLabaRugi.Name = "chkLapLabaRugi"
        Me.chkLapLabaRugi.Size = New System.Drawing.Size(75, 17)
        Me.chkLapLabaRugi.TabIndex = 47
        Me.chkLapLabaRugi.Text = "Laba Rugi"
        Me.chkLapLabaRugi.UseVisualStyleBackColor = True
        '
        'chkLapPiutang
        '
        Me.chkLapPiutang.AutoSize = True
        Me.chkLapPiutang.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Lap_Piutang", True))
        Me.chkLapPiutang.Location = New System.Drawing.Point(15, 236)
        Me.chkLapPiutang.Name = "chkLapPiutang"
        Me.chkLapPiutang.Size = New System.Drawing.Size(62, 17)
        Me.chkLapPiutang.TabIndex = 46
        Me.chkLapPiutang.Text = "Piutang"
        Me.chkLapPiutang.UseVisualStyleBackColor = True
        '
        'chkLapHutang
        '
        Me.chkLapHutang.AutoSize = True
        Me.chkLapHutang.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Lap_Hutang", True))
        Me.chkLapHutang.Location = New System.Drawing.Point(15, 213)
        Me.chkLapHutang.Name = "chkLapHutang"
        Me.chkLapHutang.Size = New System.Drawing.Size(61, 17)
        Me.chkLapHutang.TabIndex = 45
        Me.chkLapHutang.Text = "Hutang"
        Me.chkLapHutang.UseVisualStyleBackColor = True
        '
        'chkLapReturJual
        '
        Me.chkLapReturJual.AutoSize = True
        Me.chkLapReturJual.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Lap_Retur_Penjualan", True))
        Me.chkLapReturJual.Location = New System.Drawing.Point(15, 190)
        Me.chkLapReturJual.Name = "chkLapReturJual"
        Me.chkLapReturJual.Size = New System.Drawing.Size(102, 17)
        Me.chkLapReturJual.TabIndex = 44
        Me.chkLapReturJual.Text = "Retur Penjualan"
        Me.chkLapReturJual.UseVisualStyleBackColor = True
        '
        'chkLapReturBeli
        '
        Me.chkLapReturBeli.AutoSize = True
        Me.chkLapReturBeli.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Lap_Retur_Pembelian", True))
        Me.chkLapReturBeli.Location = New System.Drawing.Point(15, 167)
        Me.chkLapReturBeli.Name = "chkLapReturBeli"
        Me.chkLapReturBeli.Size = New System.Drawing.Size(104, 17)
        Me.chkLapReturBeli.TabIndex = 43
        Me.chkLapReturBeli.Text = "Retur Pembelian"
        Me.chkLapReturBeli.UseVisualStyleBackColor = True
        '
        'chkLapJualSales
        '
        Me.chkLapJualSales.AutoSize = True
        Me.chkLapJualSales.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Lap_Penjualan_Per_Sales", True))
        Me.chkLapJualSales.Location = New System.Drawing.Point(15, 144)
        Me.chkLapJualSales.Name = "chkLapJualSales"
        Me.chkLapJualSales.Size = New System.Drawing.Size(121, 17)
        Me.chkLapJualSales.TabIndex = 5
        Me.chkLapJualSales.Text = "Penjualan Per Sales"
        Me.chkLapJualSales.UseVisualStyleBackColor = True
        '
        'chkLapJualCustomer
        '
        Me.chkLapJualCustomer.AutoSize = True
        Me.chkLapJualCustomer.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Lap_Penjualan_Per_Customer", True))
        Me.chkLapJualCustomer.Location = New System.Drawing.Point(15, 121)
        Me.chkLapJualCustomer.Name = "chkLapJualCustomer"
        Me.chkLapJualCustomer.Size = New System.Drawing.Size(139, 17)
        Me.chkLapJualCustomer.TabIndex = 4
        Me.chkLapJualCustomer.Text = "Penjualan Per Customer"
        Me.chkLapJualCustomer.UseVisualStyleBackColor = True
        '
        'chkLapJualPeriode
        '
        Me.chkLapJualPeriode.AutoSize = True
        Me.chkLapJualPeriode.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Lap_Penjualan_Per_Tanggal", True))
        Me.chkLapJualPeriode.Location = New System.Drawing.Point(15, 98)
        Me.chkLapJualPeriode.Name = "chkLapJualPeriode"
        Me.chkLapJualPeriode.Size = New System.Drawing.Size(131, 17)
        Me.chkLapJualPeriode.TabIndex = 3
        Me.chkLapJualPeriode.Text = "Penjualan Per Periode"
        Me.chkLapJualPeriode.UseVisualStyleBackColor = True
        '
        'chkLapBeliSupplier
        '
        Me.chkLapBeliSupplier.AutoSize = True
        Me.chkLapBeliSupplier.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Lap_Pembelian_Per_Supplier", True))
        Me.chkLapBeliSupplier.Location = New System.Drawing.Point(15, 75)
        Me.chkLapBeliSupplier.Name = "chkLapBeliSupplier"
        Me.chkLapBeliSupplier.Size = New System.Drawing.Size(135, 17)
        Me.chkLapBeliSupplier.TabIndex = 2
        Me.chkLapBeliSupplier.Text = "Pembelian Per Supplier"
        Me.chkLapBeliSupplier.UseVisualStyleBackColor = True
        '
        'chkLapBeliPeriode
        '
        Me.chkLapBeliPeriode.AutoSize = True
        Me.chkLapBeliPeriode.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Lap_Pembelian_Per_Tanggal", True))
        Me.chkLapBeliPeriode.Location = New System.Drawing.Point(15, 52)
        Me.chkLapBeliPeriode.Name = "chkLapBeliPeriode"
        Me.chkLapBeliPeriode.Size = New System.Drawing.Size(133, 17)
        Me.chkLapBeliPeriode.TabIndex = 1
        Me.chkLapBeliPeriode.Text = "Pembelian Per Periode"
        Me.chkLapBeliPeriode.UseVisualStyleBackColor = True
        '
        'chkLapBarang
        '
        Me.chkLapBarang.AutoSize = True
        Me.chkLapBarang.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Lap_Stok_Barang", True))
        Me.chkLapBarang.Location = New System.Drawing.Point(15, 29)
        Me.chkLapBarang.Name = "chkLapBarang"
        Me.chkLapBarang.Size = New System.Drawing.Size(85, 17)
        Me.chkLapBarang.TabIndex = 0
        Me.chkLapBarang.Text = "Stok Barang"
        Me.chkLapBarang.UseVisualStyleBackColor = True
        '
        'TBL_UserTableAdapter
        '
        Me.TBL_UserTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(447, 391)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "&Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(360, 391)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "&Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.chkBiayaOperasional)
        Me.GroupBox7.Location = New System.Drawing.Point(24, 182)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(162, 56)
        Me.GroupBox7.TabIndex = 42
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Operasional"
        '
        'chkBiayaOperasional
        '
        Me.chkBiayaOperasional.AutoSize = True
        Me.chkBiayaOperasional.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Biaya_Operasional", True))
        Me.chkBiayaOperasional.Location = New System.Drawing.Point(15, 25)
        Me.chkBiayaOperasional.Name = "chkBiayaOperasional"
        Me.chkBiayaOperasional.Size = New System.Drawing.Size(111, 17)
        Me.chkBiayaOperasional.TabIndex = 0
        Me.chkBiayaOperasional.Text = "Biaya Operasional"
        Me.chkBiayaOperasional.UseVisualStyleBackColor = True
        '
        'chkEditFakturBeli
        '
        Me.chkEditFakturBeli.AutoSize = True
        Me.chkEditFakturBeli.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Edit_Pembelian", True))
        Me.chkEditFakturBeli.Location = New System.Drawing.Point(15, 121)
        Me.chkEditFakturBeli.Name = "chkEditFakturBeli"
        Me.chkEditFakturBeli.Size = New System.Drawing.Size(77, 17)
        Me.chkEditFakturBeli.TabIndex = 4
        Me.chkEditFakturBeli.Text = "Edit Faktur"
        Me.chkEditFakturBeli.UseVisualStyleBackColor = True
        '
        'chkEditFakturJual
        '
        Me.chkEditFakturJual.AutoSize = True
        Me.chkEditFakturJual.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBLUserBindingSource, "P_Edit_Pembelian", True))
        Me.chkEditFakturJual.Location = New System.Drawing.Point(15, 144)
        Me.chkEditFakturJual.Name = "chkEditFakturJual"
        Me.chkEditFakturJual.Size = New System.Drawing.Size(77, 17)
        Me.chkEditFakturJual.TabIndex = 45
        Me.chkEditFakturJual.Text = "Edit Faktur"
        Me.chkEditFakturJual.UseVisualStyleBackColor = True
        '
        'FRM_Hak_Akses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 440)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FRM_Hak_Akses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form Hak Akses"
        CType(Me.TBLUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_POS_CNDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkResetPassword As System.Windows.Forms.CheckBox
    Friend WithEvents chkHapusUser As System.Windows.Forms.CheckBox
    Friend WithEvents chkTambahUser As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkBarang As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkFakturBeli As System.Windows.Forms.CheckBox
    Friend WithEvents chkHutang As System.Windows.Forms.CheckBox
    Friend WithEvents chkSupplier As System.Windows.Forms.CheckBox
    Friend WithEvents chkReturBeli As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCustomer As System.Windows.Forms.CheckBox
    Friend WithEvents chkSales As System.Windows.Forms.CheckBox
    Friend WithEvents chkReturJual As System.Windows.Forms.CheckBox
    Friend WithEvents chkFakturJual As System.Windows.Forms.CheckBox
    Friend WithEvents chkPiutang As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents chkHargaSupplier As System.Windows.Forms.CheckBox
    Friend WithEvents chkHargaCustomer As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents chkLapBeliPeriode As System.Windows.Forms.CheckBox
    Friend WithEvents chkLapBarang As System.Windows.Forms.CheckBox
    Friend WithEvents chkLapBeliSupplier As System.Windows.Forms.CheckBox
    Friend WithEvents chkLapPiutang As System.Windows.Forms.CheckBox
    Friend WithEvents chkLapHutang As System.Windows.Forms.CheckBox
    Friend WithEvents chkLapReturJual As System.Windows.Forms.CheckBox
    Friend WithEvents chkLapReturBeli As System.Windows.Forms.CheckBox
    Friend WithEvents chkLapJualSales As System.Windows.Forms.CheckBox
    Friend WithEvents chkLapJualCustomer As System.Windows.Forms.CheckBox
    Friend WithEvents chkLapJualPeriode As System.Windows.Forms.CheckBox
    Friend WithEvents Db_POS_CNDataSet As Best_POS.db_POS_CNDataSet
    Friend WithEvents TBLUserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_UserTableAdapter As Best_POS.db_POS_CNDataSetTableAdapters.TBL_UserTableAdapter
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chkHakAkses As System.Windows.Forms.CheckBox
    Friend WithEvents chkLapLabaRugi As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents chkBiayaOperasional As System.Windows.Forms.CheckBox
    Friend WithEvents chkEditFakturBeli As System.Windows.Forms.CheckBox
    Friend WithEvents chkEditFakturJual As System.Windows.Forms.CheckBox
End Class
