USE [DB_POS_CN_Riche]
GO
/****** Object:  Table [dbo].[TBL_User]    Script Date: 09/05/2020 03:31:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_User](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NULL,
	[P_Hak_Akses] [int] NULL,
	[P_Tambah_User] [int] NULL,
	[P_Hapus_User] [int] NULL,
	[P_Reset_Password] [int] NULL,
	[P_Barang] [int] NULL,
	[P_Faktur_Pembelian] [int] NULL,
	[P_Retur_Pembelian] [int] NULL,
	[P_Supplier] [int] NULL,
	[P_Hutang] [int] NULL,
	[P_Faktur_Penjualan] [int] NULL,
	[P_Retur_Penjualan] [int] NULL,
	[P_Sales] [int] NULL,
	[P_Customer] [int] NULL,
	[P_Piutang] [int] NULL,
	[P_Harga_Customer] [int] NULL,
	[P_Harga_Supplier] [int] NULL,
	[P_Lap_Stok_Barang] [int] NULL,
	[P_Lap_Pembelian_Per_Tanggal] [int] NULL,
	[P_Lap_Pembelian_Per_Supplier] [int] NULL,
	[P_Lap_Penjualan_Per_Tanggal] [int] NULL,
	[P_Lap_Penjualan_Per_Customer] [int] NULL,
	[P_Lap_Penjualan_Per_Sales] [int] NULL,
	[P_Lap_Retur_Pembelian] [int] NULL,
	[P_Lap_Retur_Penjualan] [int] NULL,
	[P_Lap_Hutang] [int] NULL,
	[P_Lap_Piutang] [int] NULL,
	[P_Lap_Laba_Rugi] [int] NULL,
	[P_Biaya_Operasional] [int] NULL,
	[P_Edit_Penjualan] [int] NULL,
	[P_Edit_Pembelian] [int] NULL,
 CONSTRAINT [PK_TBL_User] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_Supplier]    Script Date: 09/05/2020 03:31:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Supplier](
	[Kode_Supplier] [varchar](20) NOT NULL,
	[Nama_Supplier] [varchar](50) NULL,
	[Alamat] [varchar](max) NULL,
	[Kota] [varchar](50) NULL,
	[Telepon] [varchar](50) NULL,
	[HP] [varchar](50) NULL,
	[Fax] [varchar](50) NULL,
 CONSTRAINT [PK_TBL_Supplier] PRIMARY KEY CLUSTERED 
(
	[Kode_Supplier] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_Sales]    Script Date: 09/05/2020 03:31:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Sales](
	[Kode_Sales] [varchar](20) NOT NULL,
	[Nama_Sales] [varchar](50) NULL,
	[Alamat] [varchar](max) NULL,
	[Kota] [varchar](50) NULL,
	[Telepon] [varchar](50) NULL,
	[HP] [varchar](50) NULL,
	[Fax] [varchar](50) NULL,
 CONSTRAINT [PK_TBL_Sales] PRIMARY KEY CLUSTERED 
(
	[Kode_Sales] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_RPT_Laba_Rugi]    Script Date: 09/05/2020 03:31:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_RPT_Laba_Rugi](
	[Biaya_Operasional] [money] NULL,
	[Gaji_Karyawan] [money] NULL,
	[Biaya_Lain2] [money] NULL,
	[Total_Pembelian] [money] NULL,
	[Total_Retur_Pembelian] [money] NULL,
	[Total_Penjualan] [money] NULL,
	[Total_Retur_Penjualan] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Retur_Penjualan_Header]    Script Date: 09/05/2020 03:31:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Retur_Penjualan_Header](
	[Kode_Retur] [varchar](20) NOT NULL,
	[Kode_Penjualan] [varchar](20) NULL,
	[Tanggal_Retur] [date] NULL,
	[Jumlah_Item] [int] NULL,
	[Total_Qty] [int] NULL,
	[Total_Harga] [money] NULL,
	[Keterangan] [varchar](max) NULL,
 CONSTRAINT [PK_TBL_Retur_Penjualan_Header] PRIMARY KEY CLUSTERED 
(
	[Kode_Retur] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_Retur_Penjualan_Detail]    Script Date: 09/05/2020 03:31:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Retur_Penjualan_Detail](
	[Kode_Retur] [varchar](20) NULL,
	[No_Baris] [int] NULL,
	[Kode_Barang] [varchar](20) NULL,
	[ID_Barang_Detail] [int] NULL,
	[Harga_Jual] [money] NULL,
	[Qty_Retur] [decimal](18, 2) NULL,
	[Diskon_Persen] [decimal](18, 2) NULL,
	[Diskon_Rp] [money] NULL,
	[Subtotal] [money] NULL,
	[G1] [decimal](18, 2) NULL,
	[G2] [decimal](18, 2) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_Retur_Pembelian_Header]    Script Date: 09/05/2020 03:31:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Retur_Pembelian_Header](
	[Kode_Retur] [varchar](20) NOT NULL,
	[Kode_Pembelian] [varchar](20) NULL,
	[Tanggal_Retur] [date] NULL,
	[Jumlah_Item] [int] NULL,
	[Total_Qty] [int] NULL,
	[Total_Harga] [money] NULL,
	[Keterangan] [varchar](max) NULL,
 CONSTRAINT [PK_TBL_Retur_Pembelian] PRIMARY KEY CLUSTERED 
(
	[Kode_Retur] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_Retur_Pembelian_Detail]    Script Date: 09/05/2020 03:31:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Retur_Pembelian_Detail](
	[Kode_Retur] [varchar](20) NULL,
	[No_Baris] [int] NULL,
	[Kode_Barang] [varchar](20) NULL,
	[ID_Barang_Detail] [int] NULL,
	[Harga_Jual] [money] NULL,
	[Qty_Retur] [decimal](18, 2) NULL,
	[Diskon_Persen] [decimal](18, 2) NULL,
	[Diskon_Rp] [money] NULL,
	[Subtotal] [money] NULL,
	[G1] [decimal](18, 2) NULL,
	[G2] [decimal](18, 2) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_Piutang]    Script Date: 09/05/2020 03:31:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Piutang](
	[Kode_Penjualan] [varchar](20) NULL,
	[Total_Piutang] [money] NULL,
	[Total_Retur] [money] NULL,
	[Total_Pembayaran] [money] NULL,
	[Sisa_Piutang] [money] NULL,
	[Tgl_Penagihan] [date] NULL,
	[Tgl_1] [varchar](50) NULL,
	[Pembayaran_1] [money] NULL,
	[Tgl_2] [varchar](50) NULL,
	[Pembayaran_2] [money] NULL,
	[Tgl_3] [varchar](50) NULL,
	[Pembayaran_3] [money] NULL,
	[Tgl_4] [varchar](50) NULL,
	[Pembayaran_4] [money] NULL,
	[Tgl_5] [varchar](50) NULL,
	[Pembayaran_5] [money] NULL,
	[Tgl_6] [varchar](50) NULL,
	[Pembayaran_6] [money] NULL,
	[Tgl_7] [varchar](50) NULL,
	[Pembayaran_7] [money] NULL,
	[Tgl_8] [varchar](50) NULL,
	[Pembayaran_8] [money] NULL,
	[Tgl_9] [varchar](50) NULL,
	[Pembayaran_9] [money] NULL,
	[Tgl_10] [varchar](50) NULL,
	[Pembayaran_10] [money] NULL,
	[Status] [varchar](20) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_Penjualan_Header]    Script Date: 09/05/2020 03:31:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Penjualan_Header](
	[Kode_Penjualan] [varchar](20) NOT NULL,
	[Kode_Customer] [varchar](20) NULL,
	[Kode_Sales] [varchar](20) NULL,
	[Tanggal_Jual] [date] NULL,
	[Jumlah_Item] [int] NULL,
	[Total_Qty] [int] NULL,
	[Total_Harga] [money] NULL,
	[Jenis_Pembayaran] [varchar](20) NULL,
	[Pembayaran] [money] NULL,
	[Sisa_Pembayaran] [money] NULL,
 CONSTRAINT [PK_TBL_Penjualan_Header] PRIMARY KEY CLUSTERED 
(
	[Kode_Penjualan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_Penjualan_Detail]    Script Date: 09/05/2020 03:31:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Penjualan_Detail](
	[Kode_Penjualan] [varchar](20) NULL,
	[No_Baris] [int] NULL,
	[Kode_Barang] [varchar](20) NULL,
	[ID_Barang_Detail] [int] NULL,
	[Harga_Jual] [money] NULL,
	[Qty_Jual] [decimal](18, 2) NULL,
	[Diskon_Persen] [decimal](18, 2) NULL,
	[Diskon_Rp] [money] NULL,
	[Subtotal] [money] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_Pembelian_Header]    Script Date: 09/05/2020 03:31:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Pembelian_Header](
	[Kode_Pembelian] [varchar](20) NOT NULL,
	[No_Faktur] [varchar](20) NULL,
	[Kode_Supplier] [varchar](20) NULL,
	[Tanggal_Beli] [date] NULL,
	[Jumlah_Item] [int] NULL,
	[Total_Qty] [int] NULL,
	[Total_Harga] [money] NULL,
	[Jenis_Pembayaran] [varchar](20) NULL,
	[Pembayaran] [money] NULL,
	[Sisa_Pembayaran] [money] NULL,
 CONSTRAINT [PK_TBL_Pembelian_Header] PRIMARY KEY CLUSTERED 
(
	[Kode_Pembelian] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_Pembelian_Detail]    Script Date: 09/05/2020 03:31:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Pembelian_Detail](
	[Kode_Pembelian] [varchar](20) NULL,
	[No_Baris] [int] NULL,
	[Kode_Barang] [varchar](20) NULL,
	[ID_Barang_Detail] [int] NULL,
	[Harga_Beli] [money] NULL,
	[Qty_Beli] [decimal](18, 2) NULL,
	[Diskon_Persen] [decimal](18, 2) NULL,
	[Diskon_Rp] [money] NULL,
	[Subtotal] [money] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_Hutang]    Script Date: 09/05/2020 03:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Hutang](
	[Kode_Pembelian] [varchar](20) NULL,
	[Total_Hutang] [money] NULL,
	[Total_Retur] [money] NULL,
	[Total_Pembayaran] [money] NULL,
	[Sisa_Hutang] [money] NULL,
	[Tgl_Penagihan] [date] NULL,
	[Tgl_1] [varchar](50) NULL,
	[Pembayaran_1] [money] NULL,
	[Tgl_2] [varchar](50) NULL,
	[Pembayaran_2] [money] NULL,
	[Tgl_3] [varchar](50) NULL,
	[Pembayaran_3] [money] NULL,
	[Tgl_4] [varchar](50) NULL,
	[Pembayaran_4] [money] NULL,
	[Tgl_5] [varchar](50) NULL,
	[Pembayaran_5] [money] NULL,
	[Tgl_6] [varchar](50) NULL,
	[Pembayaran_6] [money] NULL,
	[Tgl_7] [varchar](50) NULL,
	[Pembayaran_7] [money] NULL,
	[Tgl_8] [varchar](50) NULL,
	[Pembayaran_8] [money] NULL,
	[Tgl_9] [varchar](50) NULL,
	[Pembayaran_9] [money] NULL,
	[Tgl_10] [varchar](50) NULL,
	[Pembayaran_10] [money] NULL,
	[Status] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_Harga_Supplier]    Script Date: 09/05/2020 03:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Harga_Supplier](
	[Kode_Supplier] [varchar](20) NULL,
	[Kode_Barang] [varchar](20) NULL,
	[Harga_Beli] [money] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_Harga_Customer]    Script Date: 09/05/2020 03:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Harga_Customer](
	[Kode_Customer] [varchar](20) NULL,
	[Kode_Barang] [varchar](20) NULL,
	[Harga_Jual] [money] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_Gudang]    Script Date: 09/05/2020 03:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Gudang](
	[Kode_Gudang] [int] NOT NULL,
	[Nama_Gudang] [varchar](50) NULL,
	[Jenis_Gudang] [varchar](50) NULL,
 CONSTRAINT [PK_TBL_Gudang] PRIMARY KEY CLUSTERED 
(
	[Kode_Gudang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_Customer]    Script Date: 09/05/2020 03:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Customer](
	[Kode_Customer] [varchar](20) NOT NULL,
	[Nama_Customer] [varchar](50) NULL,
	[Alamat] [varchar](max) NULL,
	[Kota] [varchar](50) NULL,
	[Telepon] [varchar](50) NULL,
	[HP] [varchar](50) NULL,
	[Fax] [varchar](50) NULL,
 CONSTRAINT [PK_TBL_Customer] PRIMARY KEY CLUSTERED 
(
	[Kode_Customer] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_Barang_Detail]    Script Date: 09/05/2020 03:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Barang_Detail](
	[ID_Barang_Detail] [int] NOT NULL,
	[Kode_Barang] [varchar](20) NULL,
	[Nama_Barang_Detail] [varchar](200) NULL,
	[Qty] [decimal](18, 2) NULL,
 CONSTRAINT [PK_TBL_Barang_Detail] PRIMARY KEY CLUSTERED 
(
	[ID_Barang_Detail] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_Barang]    Script Date: 09/05/2020 03:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Barang](
	[Kode_Barang] [varchar](20) NOT NULL,
	[Nama_Barang] [varchar](50) NULL,
	[Stok_Awal] [decimal](18, 2) NULL,
	[Qty] [decimal](18, 2) NULL,
	[Satuan] [varchar](20) NULL,
	[Harga_Beli] [money] NULL,
	[Harga_Jual] [money] NULL,
	[Foto] [varbinary](max) NULL,
	[G1] [decimal](18, 2) NULL,
	[G2] [decimal](18, 2) NULL,
	[Part_No] [varchar](200) NULL,
 CONSTRAINT [PK_TBL_Barang] PRIMARY KEY CLUSTERED 
(
	[Kode_Barang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_Alokasi_Penjualan]    Script Date: 09/05/2020 03:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Alokasi_Penjualan](
	[Kode_Penjualan] [varchar](20) NOT NULL,
	[Kode_Barang] [varchar](20) NOT NULL,
	[Total_Qty] [decimal](18, 2) NULL,
	[G1] [decimal](18, 2) NULL,
	[G2] [decimal](18, 2) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_Alokasi_Pembelian]    Script Date: 09/05/2020 03:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Alokasi_Pembelian](
	[Kode_Pembelian] [varchar](20) NOT NULL,
	[Kode_Barang] [varchar](20) NOT NULL,
	[Total_Qty] [decimal](18, 2) NULL,
	[G1] [decimal](18, 2) NULL,
	[G2] [decimal](18, 2) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF_TBL_User_P_User_Management]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_User_Management]  DEFAULT ((0)) FOR [P_Hak_Akses]
GO
/****** Object:  Default [DF_TBL_User_P_Tambah_User]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_Tambah_User]  DEFAULT ((0)) FOR [P_Tambah_User]
GO
/****** Object:  Default [DF_TBL_User_P_Hapus_User]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_Hapus_User]  DEFAULT ((0)) FOR [P_Hapus_User]
GO
/****** Object:  Default [DF_TBL_User_P_Reset_Password]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_Reset_Password]  DEFAULT ((0)) FOR [P_Reset_Password]
GO
/****** Object:  Default [DF_TBL_User_P_Barang]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_Barang]  DEFAULT ((0)) FOR [P_Barang]
GO
/****** Object:  Default [DF_TBL_User_P_Faktur_Pembelian]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_Faktur_Pembelian]  DEFAULT ((0)) FOR [P_Faktur_Pembelian]
GO
/****** Object:  Default [DF_TBL_User_P_Retur_Pembelian]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_Retur_Pembelian]  DEFAULT ((0)) FOR [P_Retur_Pembelian]
GO
/****** Object:  Default [DF_TBL_User_P_Supplier]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_Supplier]  DEFAULT ((0)) FOR [P_Supplier]
GO
/****** Object:  Default [DF_TBL_User_P_Hutang]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_Hutang]  DEFAULT ((0)) FOR [P_Hutang]
GO
/****** Object:  Default [DF_TBL_User_P_Faktur_Penjualan]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_Faktur_Penjualan]  DEFAULT ((0)) FOR [P_Faktur_Penjualan]
GO
/****** Object:  Default [DF_TBL_User_P_Retur_Penjualan]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_Retur_Penjualan]  DEFAULT ((0)) FOR [P_Retur_Penjualan]
GO
/****** Object:  Default [DF_TBL_User_P_Sales]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_Sales]  DEFAULT ((0)) FOR [P_Sales]
GO
/****** Object:  Default [DF_TBL_User_P_Customer]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_Customer]  DEFAULT ((0)) FOR [P_Customer]
GO
/****** Object:  Default [DF_TBL_User_P_Piutang]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_Piutang]  DEFAULT ((0)) FOR [P_Piutang]
GO
/****** Object:  Default [DF_TBL_User_P_Harga_Customer]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_Harga_Customer]  DEFAULT ((0)) FOR [P_Harga_Customer]
GO
/****** Object:  Default [DF_TBL_User_P_Harga_Supplier]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_Harga_Supplier]  DEFAULT ((0)) FOR [P_Harga_Supplier]
GO
/****** Object:  Default [DF_TBL_User_P_Lap_Stok_Barang]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_Lap_Stok_Barang]  DEFAULT ((0)) FOR [P_Lap_Stok_Barang]
GO
/****** Object:  Default [DF_TBL_User_P_Lap_Pembelian_Per_Tanggal]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_Lap_Pembelian_Per_Tanggal]  DEFAULT ((0)) FOR [P_Lap_Pembelian_Per_Tanggal]
GO
/****** Object:  Default [DF_TBL_User_P_Lap_Pembelian_Per_Supplier]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_Lap_Pembelian_Per_Supplier]  DEFAULT ((0)) FOR [P_Lap_Pembelian_Per_Supplier]
GO
/****** Object:  Default [DF_TBL_User_P_Lap_Penjualan_Per_Tanggal]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_Lap_Penjualan_Per_Tanggal]  DEFAULT ((0)) FOR [P_Lap_Penjualan_Per_Tanggal]
GO
/****** Object:  Default [DF_TBL_User_P_Lap_Penjualan_Per_Customer]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_Lap_Penjualan_Per_Customer]  DEFAULT ((0)) FOR [P_Lap_Penjualan_Per_Customer]
GO
/****** Object:  Default [DF_TBL_User_P_Lap_Penjualan_Per_Sales]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_Lap_Penjualan_Per_Sales]  DEFAULT ((0)) FOR [P_Lap_Penjualan_Per_Sales]
GO
/****** Object:  Default [DF_TBL_User_P_Lap_Retur_Pembelian]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_Lap_Retur_Pembelian]  DEFAULT ((0)) FOR [P_Lap_Retur_Pembelian]
GO
/****** Object:  Default [DF_TBL_User_P_Lap_Retur_Penjualan]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_Lap_Retur_Penjualan]  DEFAULT ((0)) FOR [P_Lap_Retur_Penjualan]
GO
/****** Object:  Default [DF_TBL_User_P_Lap_Hutang]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_Lap_Hutang]  DEFAULT ((0)) FOR [P_Lap_Hutang]
GO
/****** Object:  Default [DF_TBL_User_P_Lap_Piutang]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_Lap_Piutang]  DEFAULT ((0)) FOR [P_Lap_Piutang]
GO
/****** Object:  Default [DF_TBL_User_P_Lap_Laba_Rugi]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_Lap_Laba_Rugi]  DEFAULT ((0)) FOR [P_Lap_Laba_Rugi]
GO
/****** Object:  Default [DF_TBL_User_P_Biaya_Operasional]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_Biaya_Operasional]  DEFAULT ((0)) FOR [P_Biaya_Operasional]
GO
/****** Object:  Default [DF_TBL_User_P_Edit_Penjualan]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_Edit_Penjualan]  DEFAULT ((0)) FOR [P_Edit_Penjualan]
GO
/****** Object:  Default [DF_TBL_User_P_Edit_Pembelian]    Script Date: 09/05/2020 03:31:50 ******/
ALTER TABLE [dbo].[TBL_User] ADD  CONSTRAINT [DF_TBL_User_P_Edit_Pembelian]  DEFAULT ((0)) FOR [P_Edit_Pembelian]
GO
