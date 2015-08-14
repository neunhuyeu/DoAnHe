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