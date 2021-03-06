USE [QLTV]
GO
/****** Object:  StoredProcedure [dbo].[sp]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp]
(
	@MaPhieu char(6), 
	@MaDG char(6), 
	@NgayMuon datetime, 
	@MaNV char(6)
)
as
	begin
		UPDATE PHIEUMUON SET MaDG=@MaDG, NgayMuon=@NgayMuon, MaNV=@MaNV WHERE MaPhieu=@MaPhieu		
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_DoiMatKhau]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DoiMatKhau]
(
	@MatKhau varchar(10),
	@MaNV char(6)
)
as
	begin
		UPDATE NHANVIEN SET MatKhau=@MatKhau WHERE MaNV=@MaNV
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDanhSachCTPM]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayDanhSachCTPM]
as	
	begin
		SELECT MaPhieu, MaSach, HanTra FROM CT_PHIEUMUON
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDanhSachDocGia]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayDanhSachDocGia]
as
	begin
		SELECT MaDG, HoTenDG, EmailDG, (CASE GioiTinhDG WHEN 'true' THEN N'Nam' ELSE N'Nữ' END) AS GioiTinhDG, NgaySinhDG, DiaChiDG, DienThoaiDG, NgayLamThe, NgayHetHan, (CASE HoatDong WHEN 'true' THEN N'Đang Hoạt động' ELSE N'Đã Hết hạn' END) AS HoatDong FROM DOCGIA
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDanhSachNhanVien]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayDanhSachNhanVien]
as
	begin
		SELECT  MaNV, HoTenNV, (CASE GioiTinhNV WHEN 'true' THEN N'Nam' ELSE N'Nữ' END) 
		AS GioiTinhNV, NgaySinhNV, DienThoaiNV, DiaChiNV, EmailNV, NgayVaoLam, MatKhau, 
		(CASE QuyenHan WHEN 'true' THEN N'Quản Lý' ELSE N'Nhân Viên' END) 
		AS QuyenHan FROM NHANVIEN
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDanhSachNXB]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayDanhSachNXB]
as
	begin 
		SELECT MaNXB, TenNXB, DiaChiNXB, DienThoaiNXB, Website FROM NHAXUATBAN
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDanhSachPM]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayDanhSachPM]
as
	begin
		SELECT MaPhieu, MaDG, NgayMuon, MaNV FROM PHIEUMUON
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDanhSachSach]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayDanhSachSach]
as
	begin
		SELECT MaSach, TenSach, NoiDungTT, SoTrang, Gia, SoLuong, NgayNhap, MaNXB, MaTG, MaTL, 
		(CASE TinhTrang WHEN 'true' THEN N'Sách Mới' ELSE N'Sách Cũ' END) AS TinhTrang FROM SACH
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDanhSachTacGia]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayDanhSachTacGia]
as
	begin
		SELECT * FROM TACGIA
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDanhSachTRASACH]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayDanhSachTRASACH]
as
	begin
		SELECT MaPhieu, MaSach, MaNV, NgayTra, PhatHuHong, PhatQuaHan FROM TRASACH
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDSDG]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayDSDG]
as 
	begin
		SELECT MaDG, HoTenDG FROM DOCGIA
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_Laydsdocgia]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Laydsdocgia]
as
	begin
		SELECT MaDG, HoTenDG, EmailDG, GioiTinhDG, NgaySinhDG, DiaChiDG, DienThoaiDG, NgayLamThe, NgayHetHan, HoatDong FROM DOCGIA
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDSLuotMuon]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayDSLuotMuon]
as
	begin
		SELECT CT_PHIEUMUON.MaSach, SACH.TenSach, SACH.Gia, SACH.SoLuong, THELOAI.TenTL, TACGIA.HoTenTG, 
		COUNT(CT_PHIEUMUON.MaSach) AS TongLuotMuon 
		FROM CT_PHIEUMUON INNER JOIN PHIEUMUON ON CT_PHIEUMUON.MaPhieu = PHIEUMUON.MaPhieu 
		INNER JOIN SACH ON CT_PHIEUMUON.MaSach = SACH.MaSach INNER JOIN THELOAI ON SACH.MaTL = THELOAI.MaTL 
		INNER JOIN TACGIA ON SACH.MaTG = TACGIA.MaTG 
		WHERE (SACH.MaSach IN (SELECT MaSach FROM CT_PHIEUMUON AS CT_PHIEUMUON_1)) 
		GROUP BY CT_PHIEUMUON.MaSach, SACH.TenSach, SACH.Gia, SACH.SoLuong, THELOAI.TenTL, TACGIA.HoTenTG
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDSMuonQuaHan]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayDSMuonQuaHan]
as
	begin
		SELECT PHIEUMUON.MaPhieu, CT_PHIEUMUON.MaSach, SACH.TenSach, TACGIA.HoTenTG, 
		DOCGIA.MaDG, DOCGIA.HoTenDG, DOCGIA.DiaChiDG, PHIEUMUON.NgayMuon, CT_PHIEUMUON.HanTra, TRASACH.NgayTra, 
		DATEDIFF(day, TRASACH.NgayTra, CT_PHIEUMUON.HanTra) AS SONGAYQUAHAN FROM PHIEUMUON 
		INNER JOIN  CT_PHIEUMUON ON PHIEUMUON.MaPhieu = CT_PHIEUMUON.MaPhieu 
		INNER JOIN DOCGIA ON PHIEUMUON.MaDG = DOCGIA.MaDG 
		INNER JOIN SACH ON CT_PHIEUMUON.MaSach = SACH.MaSach 
		INNER JOIN TACGIA ON SACH.MaTG = TACGIA.MaTG 
		INNER JOIN TRASACH ON PHIEUMUON.MaPhieu = TRASACH.MaPhieu AND SACH.MaSach = TRASACH.MaSach 
		WHERE (TRASACH.NgayTra - CT_PHIEUMUON.HanTra > 0) OR (GETDATE() - CT_PHIEUMUON.HanTra > 0) AND (TRASACH.NgayTra IS NULL) 
		ORDER BY PHIEUMUON.MaPhieu, CT_PHIEUMUON.MaSach, SACH.TenSach, TACGIA.HoTenTG, DOCGIA.MaDG, 
		DOCGIA.HoTenDG, DOCGIA.DiaChiDG, PHIEUMUON.NgayMuon, CT_PHIEUMUON.HanTra, TRASACH.NgayTra
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDSNV]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayDSNV]
as 
	begin
		SELECT MaNV, HoTenNV FROM NHANVIEN
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDSNXB]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayDSNXB]
as
	begin
		SELECT MaNXB, TenNXB FROM NHAXUATBAN
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDSPM]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayDSPM]
as
	begin
		SELECT MaPhieu, MaDG, NgayMuon, MaNV FROM PHIEUMUON
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDSSach]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayDSSach]
as
	begin
		SELECT MaSach, TenSach FROM SACH
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDSSachChuaDuocMuon]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayDSSachChuaDuocMuon]
as
	begin
		SELECT  SACH.MaSach, SACH.TenSach, TACGIA.HoTenTG, THELOAI.TenTL, NHAXUATBAN.TenNXB, 
		SACH.SoTrang, SACH.Gia, SACH.SoLuong, SACH.NgayNhap FROM SACH 
		INNER JOIN TACGIA ON SACH.MaTG = TACGIA.MaTG 
		INNER JOIN THELOAI ON SACH.MaTL = THELOAI.MaTL 
		INNER JOIN NHAXUATBAN ON SACH.MaNXB = NHAXUATBAN.MaNXB 
		WHERE (SACH.MaSach NOT IN (SELECT MaSach FROM CT_PHIEUMUON))
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDSSachTheoPM]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayDSSachTheoPM]
(
	@MaPhieu char(6)
)
as
	begin
		SELECT MaPhieu, MaSach FROM CT_PHIEUMUON WHERE MaPhieu=@MaPhieu
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDSSReport]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayDSSReport]
as
	begin
		SELECT MaSach, TenSach, SoTrang, Gia, SoLuong, NgayNhap, TinhTrang FROM SACH
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDSTG]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayDSTG]
as
	begin 
		SELECT MaTG, HoTenTG FROM TACGIA
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDSTL]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayDSTL]
as
	begin
		SELECT MaTL, TenTL FROM THELOAI
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayThongTinBanThan]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayThongTinBanThan]
(
	@MaNV char(6)
)
as
	begin
		SELECT  MaNV, HoTenNV, (CASE GioiTinhNV WHEN 'true' THEN N'Nam' ELSE N'Nữ' END) 
		AS GioiTinhNV, NgaySinhNV, DienThoaiNV, DiaChiNV, EmailNV, NgayVaoLam, MatKhau, 
		(CASE QuyenHan WHEN 'true' THEN N'Quản Lý' ELSE N'Nhân Viên' END) 
		AS QuyenHan FROM NHANVIEN WHERE MaNV=@MaNV
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayTTDangNhap]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayTTDangNhap]
(
	@MaNV char(6)
)
as
	begin
		SELECT MaNV, MatKhau, QuyenHan FROM NHANVIEN WHERE MaNV=@MaNV
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaCTPM]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SuaCTPM]
(
	@maphieu char(6),
	@masach char(8),
	@hantra datetime
)
as
	begin
		UPDATE CT_PHIEUMUON SET MaSach=@masach, HanTra=@hantra WHERE MaPhieu=@maphieu
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaDG]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SuaDG]
(
	@MaDG char(6), 
	@HoTenDG nvarchar(30), 
	@EmailDG nvarchar(30), 
	@GioiTinhDG bit, 
	@NgaySinhDG datetime, 
	@DiaChiDG nvarchar(100), 
	@DienThoaiDG char(11), 
	@NgayLamThe datetime, 
	@NgayHetHan datetime, 
	@HoatDong bit

)
as
	begin
		UPDATE DOCGIA SET HoTenDG=@HoTenDG, EmailDG=@EmailDG, GioiTinhDG=@GioiTinhDG, 
		NgaySinhDG=@NgaySinhDG, DiaChiDG=@DiaChiDG, DienThoaiDG=@DienThoaiDG, 
		NgayLamThe=@NgayLamThe, NgayHetHan=@NgayHetHan, HoatDong=@HoatDong WHERE MaDG=@MaDG
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaNV]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SuaNV]
(
	@MaNV char(6), 
	@HoTenNV nvarchar(30), 
	@GioiTinhNV bit, 
	@NgaySinhNV datetime, 
	@DienThoaiNV char(11), 
	@DiaChiNV nvarchar(100), 
	@EmailNV nchar(30), 
	@NgayVaoLam datetime, 
	@MatKhau varchar(10), 
	@QuyenHan bit
)
as
	begin
		UPDATE NHANVIEN SET HoTenNV=@HoTenNV, GioiTinhNV=@GioiTinhNV, NgaySinhNV=@NgaySinhNV, DienThoaiNV=@DienThoaiNV, 
		DiaChiNV=@DiaChiNV, EmailNV=@EmailNV, NgayVaoLam=@NgayVaoLam, MatKhau=@MatKhau, QuyenHan=@QuyenHan WHERE MaNV=@MaNV
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaNXB]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SuaNXB]
(
	@MaNXB char(6), 
	@TenNXB nvarchar(100), 
	@DiaChiNXB nvarchar(100), 
	@DienThoaiNXB char(11), 
	@Website char(50)
)
as
	begin
		UPDATE NHAXUATBAN SET TenNXB=@TenNXB, DiaChiNXB=@DiaChiNXB, DienThoaiNXB=@DienThoaiNXB, Website=@Website WHERE MaNXB=@MaNXB
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaPM]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SuaPM]
(
	@MaPhieu char(6), 
	@MaDG char(6), 
	@NgayMuon datetime, 
	@MaNV char(6)
)
as
	begin
		UPDATE PHIEUMUON SET MaDG=@MaDG, NgayMuon=@NgayMuon, MaNV=@MaNV WHERE MaPhieu=@MaPhieu		
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaPT]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SuaPT]
(
	@MaPhieu char(6), 
	@MaSach char(8), 
	@MaNV char(6),  
	@NgayTra datetime, 
	@PhatHuHong bigint, 
	@PhatQuaHan bigint
)
as
	begin
		UPDATE TRASACH SET MaSach=@MaSach, MaNV=@MaNV, NgayTra=@NgayTra, PhatHuHong=@PhatHuHong, PhatQuaHan=@PhatQuaHan WHERE MaPhieu=@MaPhieu
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaSach]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SuaSach]
(
	@MaSach char(8), 
	@TenSach nvarchar(100), 
	@NoiDungTT nvarchar(300), 
	@SoTrang int, 
	@Gia bigint, 
	@SoLuong int , 
	@NgayNhap datetime, 
	@MaNXB char(6), 
	@MaTG char(6), 
	@MaTL char(6), 
	@TinhTrang bit
)
as
	begin
		UPDATE SACH SET TenSach=@TenSach, NoiDungTT=@NoiDungTT, SoTrang=@SoTrang, Gia=@Gia, SoLuong=@SoLuong,
		NgayNhap=@NgayNhap, MaNXB=@MaNXB, MaTG=@MaTG, MaTL=@MaTL, TinhTrang=@TinhTrang WHERE MaSach=@MaSach
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaTG]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SuaTG]
(
	@MaTG char(6), @HoTenTG nvarchar(30), @DiaChiTG nvarchar(100), @DienThoaiTG char(11)
)
as
	begin
		UPDATE TACGIA SET HoTenTG=@HoTenTG, DiaChiTG=@DiaChiTG, DienThoaiTG=@DienThoaiTG WHERE MaTG=@MaTG
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaTL]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SuaTL]
(
	@MaTL char(6), 
	@TenTL nvarchar(100), 
	@GhiChu nvarchar(500)
)
as
	begin
		UPDATE THELOAI SET TenTL=@TenTL, GhiChu=@GhiChu WHERE MaTL=@MaTL
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemCTPM]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemCTPM]
(
	@maphieu char(6),
	@masach char(8),
	@hantra datetime
)
as
	begin
		INSERT INTO CT_PHIEUMUON (MaPhieu, MaSach, HanTra) 
		VALUES (@maphieu,@masach,@hantra)
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemDG]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemDG]
(
	@MaDG char(6), 
	@HoTenDG nvarchar(30), 
	@EmailDG nvarchar(30), 
	@GioiTinhDG bit, 
	@NgaySinhDG datetime, 
	@DiaChiDG nvarchar(100), 
	@DienThoaiDG char(11), 
	@NgayLamThe datetime, 
	@NgayHetHan datetime, 
	@HoatDong bit

)
as
	begin
		INSERT INTO DOCGIA (MaDG, HoTenDG, EmailDG, GioiTinhDG, NgaySinhDG, DiaChiDG, DienThoaiDG, NgayLamThe, NgayHetHan, HoatDong)
		VALUES(@MaDG, @HoTenDG, @EmailDG, @GioiTinhDG, @NgaySinhDG, @DiaChiDG, @DienThoaiDG, @NgayLamThe, @NgayHetHan, @HoatDong)
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemNV]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemNV]
(
	@MaNV char(6), 
	@HoTenNV nvarchar(30), 
	@GioiTinhNV bit, 
	@NgaySinhNV datetime, 
	@DienThoaiNV char(11), 
	@DiaChiNV nvarchar(100), 
	@EmailNV nchar(30), 
	@NgayVaoLam datetime, 
	@MatKhau varchar(10), 
	@QuyenHan bit
)
as
	begin
		INSERT INTO NHANVIEN (MaNV, HoTenNV, GioiTinhNV, NgaySinhNV, DienThoaiNV, DiaChiNV, EmailNV, NgayVaoLam, MatKhau, QuyenHan)
        VALUES(@MaNV, @HoTenNV, @GioiTinhNV, @NgaySinhNV, @DienThoaiNV, @DiaChiNV, @EmailNV, @NgayVaoLam, @MatKhau, @QuyenHan)
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemNXB]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemNXB]
(
	@MaNXB char(6), 
	@TenNXB nvarchar(100), 
	@DiaChiNXB nvarchar(100), 
	@DienThoaiNXB char(11), 
	@Website char(50)
)
as
	begin
		INSERT INTO NHAXUATBAN (MaNXB, TenNXB, DiaChiNXB, DienThoaiNXB, Website)
		VALUES (@MaNXB, @TenNXB, @DiaChiNXB, @DienThoaiNXB, @Website)
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemPM]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemPM]
(
	@MaPhieu char(6), 
	@MaDG char(6), 
	@NgayMuon datetime, 
	@MaNV char(6)
)
as
	begin
		INSERT INTO PHIEUMUON (MaPhieu, MaDG, NgayMuon, MaNV)
		VALUES (@MaPhieu, @MaDG, @NgayMuon, @MaNV)
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemPT]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemPT]
(
	@MaPhieu char(6), 
	@MaSach char(8), 
	@MaNV char(6),  
	@NgayTra datetime, 
	@PhatHuHong bigint, 
	@PhatQuaHan bigint
)
as
	begin
		INSERT INTO TRASACH (MaPhieu, MaSach, MaNV, NgayTra, PhatHuHong, PhatQuaHan)
		VALUES (@MaPhieu, @MaSach, @MaNV, @NgayTra, @PhatHuHong, @PhatQuaHan)
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemSach]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemSach]
(
	@MaSach char(8), 
	@TenSach nvarchar(100), 
	@NoiDungTT nvarchar(300), 
	@SoTrang int, 
	@Gia bigint, 
	@SoLuong int , 
	@NgayNhap datetime, 
	@MaNXB char(6), 
	@MaTG char(6), 
	@MaTL char(6), 
	@TinhTrang bit
)
as
	begin
		INSERT INTO SACH (MaSach, TenSach, NoiDungTT, SoTrang, Gia, SoLuong, NgayNhap, MaNXB, MaTG, MaTL, TinhTrang)
		VALUES (@MaSach, @TenSach, @NoiDungTT, @SoTrang, @Gia, @SoLuong, @NgayNhap, @MaNXB, @MaTG, @MaTL, @TinhTrang)
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemTG]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemTG]
(
	@MaTG char(6), @HoTenTG nvarchar(30), @DiaChiTG nvarchar(100), @DienThoaiTG char(11)
)
as
	begin
		INSERT INTO TACGIA (MaTG, HoTenTG, DiaChiTG, DienThoaiTG)
		VALUES (@MaTG, @HoTenTG, @DiaChiTG, @DienThoaiTG)
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemTL]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemTL]
(
	@MaTL char(6), 
	@TenTL nvarchar(100), 
	@GhiChu nvarchar(500)
)
as
	begin
		INSERT INTO THELOAI (MaTL, TenTL, GhiChu)
		VALUES (@MaTL, @TenTL, @GhiChu)
	end	
GO
/****** Object:  StoredProcedure [dbo].[sp_TimKiemDG]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_TimKiemDG]
(
	@DieuKien nvarchar(50),
	@TieuChi nvarchar(50)
)
as
	begin
		SELECT MaDG, HoTenDG, EmailDG, (CASE GioiTinhDG WHEN 'true' THEN N'Nam' ELSE N'Nữ' END) 
		AS GioiTinhDG, NgaySinhDG, DiaChiDG, DienThoaiDG, NgayLamThe, NgayHetHan, 
		(CASE HoatDong WHEN 'true' THEN N'Đang Hoạt động' ELSE N'Đã Hết hạn' END) 
		AS HoatDong FROM DOCGIA WHERE @DieuKien LIKE @TieuChi
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_TimKiemSach]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_TimKiemSach]
(
	@DieuKien nvarchar(50),
	@TieuChi nvarchar(50)
)
as
	begin
		SELECT MaSach, TenSach, NoiDungTT, SoTrang, Gia, SoLuong, NgayNhap, MaNXB, MaTG, MaTL, 
		(CASE TinhTrang WHEN 'true' THEN N'Sách Mới' ELSE N'Sách Cũ' END) AS TinhTrang FROM SACH 
		WHERE @DieuKien LIKE @TieuChi
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_XemDanhSachNhanVien]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_XemDanhSachNhanVien]
as
	begin
		SELECT  MaNV, HoTenNV, (CASE GioiTinhNV WHEN 'true' THEN N'Nam' ELSE N'Nữ' END) 
		AS GioiTinhNV, NgaySinhNV, DienThoaiNV, DiaChiNV, EmailNV, NgayVaoLam, 
		(CASE QuyenHan WHEN 'true' THEN N'Quản Lý' ELSE N'Nhân Viên' END) 
		AS QuyenHan FROM NHANVIEN
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaCTPM]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_XoaCTPM]
(
	@maphieu char(6)
)
as
	begin
		DELETE FROM CT_PHIEUMUON WHERE MaPhieu=@maphieu
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaDG]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_XoaDG]
(
	@MaDG char(6)
)
as
	begin
		DELETE FROM DOCGIA WHERE MaDG=@MaDG
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaNV]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_XoaNV]
(
	@MaNV char(6)
)
as
	begin
		DELETE FROM NHANVIEN WHERE MaNV=@MaNV
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaNXB]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_XoaNXB]
(
	@MaNXB char(6)
)
as
	begin
		DELETE FROM NHAXUATBAN WHERE MaNXB=@MaNXB
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaPM]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_XoaPM]
(
	@MaPhieu char(6)
)
as
	begin
		DELETE FROM PHIEUMUON WHERE MaPhieu=@MaPhieu
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaPT]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_XoaPT]
(
	@MaSach char(8)
)
as
	begin
		DELETE FROM TRASACH WHERE MaSach=@MaSach
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaSach]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_XoaSach]
(
	@MaSach char(8)
)
as
	begin
		DELETE FROM SACH WHERE MaSach=@MaSach
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaTG]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_XoaTG]
(
	@MaTG char(6)
)
as
	begin
		DELETE FROM TACGIA WHERE MaTG=@MaTG
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaTL]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_XoaTL]
(
	@MaTL char(6) 
)
as
	begin
		DELETE FROM THELOAI WHERE MaTL=@MaTL
	end
GO
/****** Object:  StoredProcedure [dbo].[store_timkiem]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[store_timkiem] 
	-- Add the parameters for the stored procedure here
@MaSach char(8),
@TenSach nvarchar(100),
@Ndtt nvarchar(300),
@MaTG char(6),
@MaTL char(6),
@MaNXB char(6)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from SACH where MaSach like '%'+@MaSach+'%'
						 and TenSach like '%'+@TenSach+'%'
						 and NoiDungTT like '%'+@Ndtt+'%'
						 and MaTG like '%'+@MaTG+'%'
						 and MaTL like '%'+@MaTL+'%'
						 and MaNXB like '%'+@MaNXB+'%'
						
END

GO
/****** Object:  StoredProcedure [dbo].[SuaCTPM]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SuaCTPM]
(
	@maphieu char(6),
	@masach char(8),
	@hantra datetime
)
as
	begin
		UPDATE CT_PHIEUMUON SET MaSach=@masach, HanTra=@hantra WHERE MaPhieu=@maphieu
	end
GO
/****** Object:  Table [dbo].[CT_PHIEUMUON]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_PHIEUMUON](
	[MaPhieu] [char](6) NOT NULL,
	[MaSach] [char](8) NOT NULL,
	[HanTra] [datetime] NOT NULL,
 CONSTRAINT [PK_CT_PHIEUMUON] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DOCGIA]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DOCGIA](
	[MaDG] [char](6) NOT NULL,
	[HoTenDG] [nvarchar](30) NOT NULL,
	[EmailDG] [nvarchar](30) NULL,
	[GioiTinhDG] [bit] NULL,
	[NgaySinhDG] [datetime] NULL,
	[DiaChiDG] [nvarchar](100) NULL,
	[DienThoaiDG] [char](11) NULL,
	[NgayLamThe] [datetime] NULL,
	[NgayHetHan] [datetime] NULL,
	[HoatDong] [bit] NULL,
 CONSTRAINT [PK_DOCGIA] PRIMARY KEY CLUSTERED 
(
	[MaDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [char](6) NOT NULL,
	[HoTenNV] [nvarchar](30) NOT NULL,
	[GioiTinhNV] [bit] NULL,
	[NgaySinhNV] [datetime] NOT NULL,
	[DienThoaiNV] [char](11) NULL,
	[DiaChiNV] [nvarchar](100) NULL,
	[EmailNV] [nchar](30) NULL,
	[NgayVaoLam] [datetime] NOT NULL,
	[MatKhau] [varchar](10) NULL,
	[QuyenHan] [bit] NOT NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHAXUATBAN]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHAXUATBAN](
	[MaNXB] [char](6) NOT NULL,
	[TenNXB] [nvarchar](100) NOT NULL,
	[DiaChiNXB] [nvarchar](100) NULL,
	[DienThoaiNXB] [char](11) NULL,
	[Website] [char](50) NULL,
 CONSTRAINT [PK_NHAXUATBAN] PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUMUON]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUMUON](
	[MaPhieu] [char](6) NOT NULL,
	[MaDG] [char](6) NOT NULL,
	[NgayMuon] [datetime] NOT NULL,
	[MaNV] [char](6) NOT NULL,
 CONSTRAINT [PK_PHIEUMUON_1] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SACH]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SACH](
	[MaSach] [char](8) NOT NULL,
	[TenSach] [nvarchar](100) NOT NULL,
	[NoiDungTT] [nvarchar](300) NULL,
	[SoTrang] [int] NULL,
	[Gia] [bigint] NULL,
	[SoLuong] [int] NULL,
	[NgayNhap] [datetime] NULL,
	[MaNXB] [char](6) NOT NULL,
	[MaTG] [char](6) NOT NULL,
	[MaTL] [char](6) NOT NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_SACH_1] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TACGIA]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TACGIA](
	[MaTG] [char](6) NOT NULL,
	[HoTenTG] [nvarchar](30) NOT NULL,
	[DiaChiTG] [nvarchar](100) NULL,
	[DienThoaiTG] [char](11) NULL,
 CONSTRAINT [PK_TACGIA] PRIMARY KEY CLUSTERED 
(
	[MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THELOAI]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[THELOAI](
	[MaTL] [char](6) NOT NULL,
	[TenTL] [nvarchar](100) NOT NULL,
	[GhiChu] [nvarchar](500) NULL,
 CONSTRAINT [PK_THELOAI] PRIMARY KEY CLUSTERED 
(
	[MaTL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TRASACH]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TRASACH](
	[MaPhieu] [char](6) NOT NULL,
	[MaSach] [char](8) NOT NULL,
	[MaNV] [char](6) NOT NULL,
	[NgayTra] [datetime] NOT NULL,
	[PhatHuHong] [bigint] NULL,
	[PhatQuaHan] [bigint] NULL,
 CONSTRAINT [PK_TRASACH_1] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[MuonSachQuaHan]    Script Date: 8/15/2015 10:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[MuonSachQuaHan]
AS
SELECT     TOP (100) PERCENT dbo.PHIEUMUON.MaPhieu, dbo.CT_PHIEUMUON.MaSach, dbo.SACH.TenSach, dbo.TACGIA.HoTenTG, dbo.DOCGIA.MaDG, dbo.DOCGIA.HoTenDG, dbo.DOCGIA.DiaChiDG, dbo.PHIEUMUON.NgayMuon, dbo.CT_PHIEUMUON.HanTra, dbo.TRASACH.NgayTra, DATEDIFF(day, dbo.TRASACH.NgayTra, dbo.CT_PHIEUMUON.HanTra) AS SONGAYQUAHAN
FROM         dbo.PHIEUMUON INNER JOIN
                      dbo.CT_PHIEUMUON ON dbo.PHIEUMUON.MaPhieu = dbo.CT_PHIEUMUON.MaPhieu INNER JOIN
                      dbo.DOCGIA ON dbo.PHIEUMUON.MaDG = dbo.DOCGIA.MaDG INNER JOIN
                      dbo.SACH ON dbo.CT_PHIEUMUON.MaSach = dbo.SACH.MaSach INNER JOIN
                      dbo.TACGIA ON dbo.SACH.MaTG = dbo.TACGIA.MaTG INNER JOIN
                      dbo.TRASACH ON dbo.PHIEUMUON.MaPhieu = dbo.TRASACH.MaPhieu AND dbo.SACH.MaSach = dbo.TRASACH.MaSach
WHERE     (dbo.TRASACH.NgayTra - dbo.CT_PHIEUMUON.HanTra > 0) OR
                      (GETDATE() - dbo.CT_PHIEUMUON.HanTra > 0) AND (dbo.TRASACH.NgayTra IS NULL)
ORDER BY dbo.PHIEUMUON.MaPhieu, dbo.CT_PHIEUMUON.MaSach, dbo.SACH.TenSach, dbo.TACGIA.HoTenTG, dbo.DOCGIA.MaDG, dbo.DOCGIA.HoTenDG, dbo.DOCGIA.DiaChiDG, dbo.PHIEUMUON.NgayMuon, dbo.CT_PHIEUMUON.HanTra, dbo.TRASACH.NgayTra

GO
ALTER TABLE [dbo].[CT_PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUMUON_PHIEUMUON] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PHIEUMUON] ([MaPhieu])
GO
ALTER TABLE [dbo].[CT_PHIEUMUON] CHECK CONSTRAINT [FK_CT_PHIEUMUON_PHIEUMUON]
GO
ALTER TABLE [dbo].[CT_PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUMUON_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[CT_PHIEUMUON] CHECK CONSTRAINT [FK_CT_PHIEUMUON_SACH]
GO
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUON_DOCGIA] FOREIGN KEY([MaDG])
REFERENCES [dbo].[DOCGIA] ([MaDG])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK_PHIEUMUON_DOCGIA]
GO
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUON_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK_PHIEUMUON_NHANVIEN]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_NHAXUATBAN] FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NHAXUATBAN] ([MaNXB])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_NHAXUATBAN]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_TACGIA] FOREIGN KEY([MaTG])
REFERENCES [dbo].[TACGIA] ([MaTG])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_TACGIA]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_THELOAI] FOREIGN KEY([MaTL])
REFERENCES [dbo].[THELOAI] ([MaTL])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_THELOAI]
GO
ALTER TABLE [dbo].[TRASACH]  WITH CHECK ADD  CONSTRAINT [FK_TRASACH_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[TRASACH] CHECK CONSTRAINT [FK_TRASACH_NHANVIEN]
GO
ALTER TABLE [dbo].[TRASACH]  WITH CHECK ADD  CONSTRAINT [FK_TRASACH_PHIEUMUON] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PHIEUMUON] ([MaPhieu])
GO
ALTER TABLE [dbo].[TRASACH] CHECK CONSTRAINT [FK_TRASACH_PHIEUMUON]
GO
ALTER TABLE [dbo].[TRASACH]  WITH CHECK ADD  CONSTRAINT [FK_TRASACH_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[TRASACH] CHECK CONSTRAINT [FK_TRASACH_SACH]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[52] 4[4] 2[21] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "PHIEUMUON"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 126
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CT_PHIEUMUON"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 111
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "DOCGIA"
            Begin Extent = 
               Top = 6
               Left = 434
               Bottom = 126
               Right = 594
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SACH"
            Begin Extent = 
               Top = 6
               Left = 632
               Bottom = 126
               Right = 792
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TACGIA"
            Begin Extent = 
               Top = 114
               Left = 236
               Bottom = 234
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TRASACH"
            Begin Extent = 
               Top = 126
               Left = 38
               Bottom = 246
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
        ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'MuonSachQuaHan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N' Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'MuonSachQuaHan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'MuonSachQuaHan'
GO
