USE [QL_SinhVien]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 5/23/2020 7:06:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSV] [char](12) NULL,
	[TenSV] [nvarchar](50) NOT NULL,
	[MaLop] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [nvarchar](5) NOT NULL,
	[CMND] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [MaLop], [NgaySinh], [GioiTinh], [CMND]) VALUES (N'2001170054  ', N'Đinh Hoàng Hiếu', N'08DHTH2', CAST(0xAB230B00 AS Date), N'Nam', N'281226243')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [MaLop], [NgaySinh], [GioiTinh], [CMND]) VALUES (N'200170019   ', N'Nguyễn Tú Nguyên', N'08DHTH4', CAST(0xA9230B00 AS Date), N'Nữ', N'151318633')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [MaLop], [NgaySinh], [GioiTinh], [CMND]) VALUES (N'2001170043  ', N'Đào Trần Thanh Đông', N'08DHTH4', CAST(0xF3230B00 AS Date), N'Nam', N'128132132')
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [MaLop], [NgaySinh], [GioiTinh], [CMND]) VALUES (N'2001170023  ', N'Diệp Chấn Đạt', N'08DHTH4', CAST(0x4A230B00 AS Date), N'Nam', N'151325453')
