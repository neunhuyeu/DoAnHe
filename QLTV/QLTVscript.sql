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
		DELETE FROM NHAXUATBAN WHERE MaNXB=@MaNXB
	end

create proc sp_LayDanhSachPM
as
	begin
		SELECT MaPhieu, MaDG, NgayMuon, MaNV FROM PHIEUMUON
	end

create proc sp_LayDSPM
as
	begin
		SELECT MaPhieu, MaDG, NgayMuon, MaNV FROM PHIEUMUON
	end

create proc sp_LayDSLuotMuon
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

create proc sp_LayDSMuonQuaHan
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

create proc sp_LayDSSachChuaDuocMuon
as
	begin
		SELECT  SACH.MaSach, SACH.TenSach, TACGIA.HoTenTG, THELOAI.TenTL, NHAXUATBAN.TenNXB, 
		SACH.SoTrang, SACH.Gia, SACH.SoLuong, SACH.NgayNhap FROM SACH 
		INNER JOIN TACGIA ON SACH.MaTG = TACGIA.MaTG 
		INNER JOIN THELOAI ON SACH.MaTL = THELOAI.MaTL 
		INNER JOIN NHAXUATBAN ON SACH.MaNXB = NHAXUATBAN.MaNXB 
		WHERE (SACH.MaSach NOT IN (SELECT MaSach FROM CT_PHIEUMUON))
	end


create proc sp_ThemPM
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

create proc sp_SuaPM
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

create proc sp_XoaPM
(
	@MaPhieu char(6)
)
as
	begin
		DELETE FROM PHIEUMUON WHERE MaPhieu=@MaPhieu
	end

create proc sp_LayDanhSachSach
as
	begin
		SELECT MaSach, TenSach, NoiDungTT, SoTrang, Gia, SoLuong, NgayNhap, MaNXB, MaTG, MaTL, 
		(CASE TinhTrang WHEN 'true' THEN N'Sách Mới' ELSE N'Sách Cũ' END) AS TinhTrang FROM SACH
	end

create proc sp_LayDSSReport
as
	begin
		SELECT MaSach, TenSach, SoTrang, Gia, SoLuong, NgayNhap, TinhTrang FROM SACH
	end


create proc sp_LayDSSach
as
	begin
		SELECT MaSach, TenSach FROM SACH
	end

create proc sp_LayDSSachTheoPM
(
	@MaPhieu char(6)
)
as
	begin
		SELECT MaPhieu, MaSach FROM CT_PHIEUMUON WHERE MaPhieu=@MaPhieu
	end

create proc sp_ThemSach
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

create proc sp_SuaSach
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

create proc sp_XoaSach
(
	@MaSach char(8)
)
as
	begin
		DELETE FROM SACH WHERE MaSach=@MaSach
	end

create proc sp_TimKiemSach
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


create proc sp_LayDanhSachTacGia
as
	begin
		SELECT * FROM TACGIA
	end

create proc sp_LayDSTG
as
	begin 
		SELECT MaTG, HoTenTG FROM TACGIA
	end

create proc sp_ThemTG
(
	@MaTG char(6), @HoTenTG nvarchar(30), @DiaChiTG nvarchar(100), @DienThoaiTG char(11)
)
as
	begin
		INSERT INTO TACGIA (MaTG, HoTenTG, DiaChiTG, DienThoaiTG)
		VALUES (@MaTG, @HoTenTG, @DiaChiTG, @DienThoaiTG)
	end

create proc sp_SuaTG
(
	@MaTG char(6), 
	@HoTenTG nvarchar(30), 
	@DiaChiTG nvarchar(100), 
	@DienThoaiTG char(11)
)
as
	begin
		UPDATE TACGIA SET HoTenTG=@HoTenTG, DiaChiTG=@DiaChiTG, DienThoaiTG=@DienThoaiTG WHERE MaTG=@MaTG
	end

create proc sp_XoaTG
(
	@MaTG char(6)
)
as
	begin
		DELETE FROM TACGIA WHERE MaTG=@MaTG
	end