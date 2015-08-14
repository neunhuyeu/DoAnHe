use qltv
go

create proc sp_LayDanhSachCTPM
as	
	begin
		SELECT MaPhieu, MaSach, HanTra FROM CT_PHIEUMUON
	end


create proc sp_ThemCTPM
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

create proc sp_SuaCTPM
(
	@maphieu char(6),
	@masach char(8),
	@hantra datetime
)
as
	begin
		UPDATE CT_PHIEUMUON SET MaSach=@masach, HanTra=@hantra WHERE MaPhieu=@maphieu
	end


create proc sp_XoaCTPM
(
	@maphieu char(6)
)
as
	begin
		DELETE FROM CT_PHIEUMUON WHERE MaPhieu=@maphieu
	end

create proc sp_LayDanhSachDocGia
as
	begin
		SELECT MaDG, HoTenDG, EmailDG, (CASE GioiTinhDG WHEN 'true' THEN N'Nam' ELSE N'Nữ' END) AS GioiTinhDG, NgaySinhDG, DiaChiDG, DienThoaiDG, NgayLamThe, NgayHetHan, (CASE HoatDong WHEN 'true' THEN N'Đang Hoạt động' ELSE N'Đã Hết hạn' END) AS HoatDong FROM DOCGIA
	end

create proc sp_Laydsdocgia
as
	begin
		SELECT MaDG, HoTenDG, EmailDG, GioiTinhDG, NgaySinhDG, DiaChiDG, DienThoaiDG, NgayLamThe, NgayHetHan, HoatDong FROM DOCGIA
	end

create proc sp_LayDSDG
as 
	begin
		SELECT MaDG, HoTenDG FROM DOCGIA
	end

create proc sp_ThemDG
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

create proc sp_SuaDG
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

create proc sp_XoaDG
(
	@MaDG char(6)
)
as
	begin
		DELETE FROM DOCGIA WHERE MaDG=@MaDG
	end

create proc sp_TimKiemDG
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

create proc sp_LayDanhSachNhanVien
as
	begin
		SELECT  MaNV, HoTenNV, (CASE GioiTinhNV WHEN 'true' THEN N'Nam' ELSE N'Nữ' END) 
		AS GioiTinhNV, NgaySinhNV, DienThoaiNV, DiaChiNV, EmailNV, NgayVaoLam, MatKhau, 
		(CASE QuyenHan WHEN 'true' THEN N'Quản Lý' ELSE N'Nhân Viên' END) 
		AS QuyenHan FROM NHANVIEN
	end

create proc sp_XemDanhSachNhanVien
as
	begin
		SELECT  MaNV, HoTenNV, (CASE GioiTinhNV WHEN 'true' THEN N'Nam' ELSE N'Nữ' END) 
		AS GioiTinhNV, NgaySinhNV, DienThoaiNV, DiaChiNV, EmailNV, NgayVaoLam, 
		(CASE QuyenHan WHEN 'true' THEN N'Quản Lý' ELSE N'Nhân Viên' END) 
		AS QuyenHan FROM NHANVIEN
	end

create proc sp_LayThongTinBanThan
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

create proc sp_LayTTDangNhap
(
	@MaNV char(6)
)
as
	begin
		SELECT MaNV, MatKhau, QuyenHan FROM NHANVIEN WHERE MaNV=@MaNV
	end

create proc sp_DoiMatKhau
(
	@MatKhau varchar(10),
	@MaNV char(6)
)
as
	begin
		UPDATE NHANVIEN SET MatKhau=@MatKhau WHERE MaNV=@MaNV
	end

create proc sp_LayDSNV
as 
	begin
		SELECT MaNV, HoTenNV FROM NHANVIEN
	end

create proc sp_ThemNV
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

create proc sp_SuaNV
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

create proc sp_XoaNV
(
	@MaNV char(6)
)
as
	begin
		DELETE FROM NHANVIEN WHERE MaNV=@MaNV
	end

create proc sp_LayDanhSachNXB
as
	begin 
		SELECT MaNXB, TenNXB, DiaChiNXB, DienThoaiNXB, Website FROM NHAXUATBAN
	end

create proc sp_LayDSNXB
as
	begin
		SELECT MaNXB, TenNXB FROM NHAXUATBAN
	end

create proc sp_ThemNXB
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

create proc sp_SuaNXB
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

create proc sp_XoaNXB
(
	@MaNXB char(6)
)
as
	begin
		DELETE FROM NHAXUATBAN WHERE MaNXB='" + MaNXB + "'"
	end