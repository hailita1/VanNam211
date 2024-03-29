USE [TestKiemTra]
GO
/****** Object:  Table [dbo].[CongViec]    Script Date: 11/24/2019 2:31:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongViec](
	[MCV] [nvarchar](50) NOT NULL,
	[TenCV] [nvarchar](50) NULL,
	[MucLuong] [float] NULL,
	[Anh] [nvarchar](500) NULL,
 CONSTRAINT [PK_CongViec] PRIMARY KEY CLUSTERED 
(
	[MCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/24/2019 2:31:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [nvarchar](50) NOT NULL,
	[TenNhanVien] [nvarchar](50) NULL,
	[MCV] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CongViec] ([MCV], [TenCV], [MucLuong], [Anh]) VALUES (N'cc', N'cc', 212, N'C:\Users\haili\Downloads\Tai Lieu\messi.jpg')
INSERT [dbo].[CongViec] ([MCV], [TenCV], [MucLuong], [Anh]) VALUES (N'NVBH', N'123', 1000, N'C:\Users\haili\Downloads\Tai Lieu\messi.jpg')
INSERT [dbo].[CongViec] ([MCV], [TenCV], [MucLuong], [Anh]) VALUES (N'NVCSKH', N'Nhân Viên Chăm Sóc Khách Hàng', 100000, N'C:\Users\haili\Downloads\Tai Lieu\wer1560930494.jpg')
INSERT [dbo].[CongViec] ([MCV], [TenCV], [MucLuong], [Anh]) VALUES (N'NVVS', N'Nhân Viên Vệ Sinh', 10, N'C:\Users\haili\Downloads\Tai Lieu\messi.jpg')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [MCV]) VALUES (N'01', N'Minh', N'NVBH')
