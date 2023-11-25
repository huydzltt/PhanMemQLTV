use master
go
create database MHHDL_KhoaLuanQLTV
go
use MHHDL_KhoaLuanQLTV
go

-- Tạo bảng Tài khoản thủ thư
create table tblThuThu
(
	MaTT varchar(10) constraint pk_tblThuThu primary key,
	TenTT nvarchar(30),
	GioiTinhTT nvarchar(5),
	NgaySinhTT varchar(10),
	SoDienThoaiTT nvarchar(12),
	DiaChiTT nvarchar(50),
	GhiChu nvarchar(30),
	TenTaiKhoanTT varchar(10),
	MatKhauTT varchar(20),
)
go

--drop table tblThuThu
--go
-- Tạo bảng Nhân Viên
CREATE TABLE tblNhanVien
(	
	MaNV varchar(10) constraint pk_tblNhanVien primary key,
	TenNV nvarchar(30),
	GioiTinhNV nvarchar(3),
	NgaySinhNV varchar(10),
	SoDienThoaiNV nvarchar(12),
	DiaChiNV nvarchar(50),
	LoaiNV nvarchar(20),
	GhiChu nvarchar(30),
)
GO

--drop table tblNhanVien

-- Tạo bảng Nhà Xuất Bản
CREATE TABLE tblNhaXuatBan
(
	MaNXB varchar(10) constraint pk_tblNhaXuatBan primary key,
	TenNXB nvarchar(30),
	Email varchar(30),
	SoDienThoaiNXB nvarchar(12),
	SoFax nvarchar(12),
	DiaChiNXB nvarchar(50),
	TrangThai nvarchar(15),
	GhiChu nvarchar(30),		
)
GO

---------Tạo bảng Độc Giả
create table tblDocGia
(
	MaDG varchar(10) constraint pk_tblDocGia primary key,
	TenDG nvarchar(30),
	GioiTinhDG nvarchar(5),
	NgaySinhDG varchar(10),
	SoDienThoaiDG nvarchar(12),
	DiaChiDG nvarchar(50),
	LoaiDG nvarchar(20),
	GhiChu nvarchar(30),
	TenTaiKhoanDG varchar(10),
	MatKhauDG varchar(20),
)
go

-- drop table tblDocGia

-- Tạo bảng Sách
create table tblSach
(
	MaSach varchar(10) constraint pk_tblSach primary key,
	TenSach nvarchar(50),
	ChuDe nvarchar(30),
	TacGia nvarchar(30),
	MaNXB VARCHAR(10),
	NamXB int,
	SLNhap int,
	DonGia int,
	TinhTrang nvarchar(20),
	Ghichu nvarchar(30),
	CONSTRAINT fk_tblSach_tblNhaXuatBan FOREIGN KEY(MaNXB) REFERENCES tblNhaXuatBan(MaNXB),
)
go
--drop table tblSach


-- Tạo bản Mượn Trả
create table tblHSPhieuMuon
(
	MaPhieu varchar(10),
	MaDG varchar(10),
	MaSach varchar(10),
	NgayMuon varchar(10),
	NgayTra varchar(10),
	SLMuon int,
	TinhTrang nvarchar(20),
	GhiChu nvarchar(75),
	constraint pk_tblMuonTra primary key(MaPhieu),
	constraint fk_tblMuonTra_tblDocGia foreign key(MaDG) references tblDocGia(MaDG),
	constraint fk_tblMuonTra_tblSach foreign key(MaSach) references tblSach(MaSach),
)
go
--drop table tblHSPhieuMuon

-- Tao bang Nhat ky hoat dong
--create table tblNhatKyHoatDong
--(
--	id int primary key,
--	ThoiGian datetime,
--	NguoiTao nvarchar(100),
--	TaiKhoan nvarchar(100),
--	ThaoTac nvarchar(100)
--)
--go
--drop table tblHSPhieuMuon

--- Insert du lieu.

---Chèn dữ liệu bảng tblNhaXuatBan
insert into tblNhaXuatBan values ('NXB001',N'NXB Kim Đồng','nxbkimdong@gmail.com','1900571595','0243822906',N'Hai Bà Trưng - Hà Nội',N'Đang cung cấp','')
insert into tblNhaXuatBan values ('NXB002',N'NXB Trẻ','nxbtre@gmail.com','1900581782','04 35123395',N'Đống Đa - Hà Nội',N'Đang cung cấp','')
insert into tblNhaXuatBan values ('NXB003',N'NXB Giáo Dục','nxbgiaoduc@gmail.com','1900745842','024 39422010',N'Trần Hưng Đạo - Hà Nội',N'Đang cung cấp','')
insert into tblNhaXuatBan values ('NXB004',N'NXB Thanh Niên','nxbthanhnien@gmail.com','1900547957','0382413213',N'64 Bà Triệu - Hà Nội',N'Đang cung cấp','')
insert into tblNhaXuatBan values ('NXB005',N'NXB Hội Nhà Văn','nxbhoinhavan@gmail.com','1900124543','024 38222135',N'65 Nguyễn Du - Hà Nội',N'Đang cung cấp','')
insert into tblNhaXuatBan values ('NXB006',N'NXB Tư Pháp','nxbtp@moj.gov.vn','190062632073','062 63220742',N'Hoàn Kiếm - Hà Nội',N'Đang cung cấp','')
insert into tblNhaXuatBan values ('NXB007',N'NXB Thông tin và Truyền Thông','nxbthongtinvatt@gmail.com','028.35127750','028.35127751',N'Trần Duy Hưng - Hà Nội',N'Đang cung cấp','')

go

-- Chèn dữ liệu bảng tblSach
insert into tblSach values ('MS001',N'Lập trình Windown',N'Lập trình',N'Nguyễn Xuân Nam',N'NXB001','2000','100','50000',N'Mới','')
insert into tblSach values ('MS002',N'Lập trình Web',N'Lập trình',N'Lê Hồng Nhân',N'NXB001','2001','100','50000',N'Mới','')
insert into tblSach values ('MS003',N'Lập trình HDT',N'Lập trình',N'Nguyễn Đức Phương',N'NXB003','2002','100','30000',N'Mới','')
insert into tblSach values ('MS004',N'Lập trình SQL',N'Lập trình',N'Nguyễn Xuân Nam',N'NXB005','2004','100','40000',N'Mới','')
insert into tblSach values ('MS005',N'Thiết bị công nghệ hiện đại',N'Công nghệ',N'Trần Xuân Bách',N'NXB005','2004','100','60000',N'Mới','')
insert into tblSach values ('MS006',N'Khoa học quanh ta',N'Công nghệ',N'Trần Văn Chung',N'NXB004','2002','100','40000',N'Mới','')
insert into tblSach values ('MS007',N'Úng dụng công nghệ',N'Công nghệ',N'Nguyễn Hoài Nhâm',N'NXB002','2009','100','50000',N'Mới','')
insert into tblSach values ('MS008',N'Bạn và Tôi',N'Tiểu thuyết',N'Lệ Thu',N'NXB006','2007','100','50000',N'Mới','')
insert into tblSach values ('MS009',N'Ngày Ấy',N'Tiểu thuyết',N'Nguyễn Hoài Nhớ',N'NXB005','2010','100','40000',N'Mới','')
insert into tblSach values ('MS010',N'Tôi đi tìm tôi',N'Tiểu thuyết',N'Phạm Đức',N'NXB002','2004','100','20000',N'Mới','')
---------------


-- Chèn dữ liệu bảng tblDocGia
insert into tblDocGia values ('DG001',N'Nguyễn Hải Nam',N'Nam','1999/05/2003','0334633324',N'75 Thuỷ Nguyên, Hải Phòng',N'Nhà báo','...','DG001','123')
insert into tblDocGia values ('DG002',N'Huỳnh Thanh Hải',N'Nam','1999/05/2002','035693224',N'115 Nguyễn Oanh, Gò Vấp',N'Nhà phê bình','...','DG002','123')
insert into tblDocGia values ('DG003',N'Trần Thanh Hương',N'Nữ','1999/08/2005','035478695',N'115 Lê Văn Thọ, Gò Vấp',N'Sinh Viên','...','DG003','123')
insert into tblDocGia values ('DG004',N'Trần Nam',N'Nam','11/03/1998','0364551224',N'115 Hồ Thị Hương, Tân Bình',N'Nhân viên','...','DG004','123')
insert into tblDocGia values ('DG005',N'Nguyễn Trãi',N'Nam','23/10/1999','0384688824',N'119 Lê Đức Thọ, Gò Vấp',N'Nhà văn','...','DG005','123')
insert into tblDocGia values ('DG006',N'Nguyễn Xuân Phúc',N'Nam','15/10/1998','0374693111',N'113 Lê Duẩn, Q1',N'Bình thường','...','DG006','123')
insert into tblDocGia values ('DG007',N'Phạm Nguyễn Gia Hân',N'Nữ','20/11/1997','036393224',N'784 Nguyễn Kiệm, Gò Vấp',N'Bình thường','...','DG007','123')
insert into tblDocGia values ('DG008',N'Lê Chí Trung',N'Nam','08/03/1999','0354697754',N'988 Quang Trung, Gò Vấp',N'Bình thường','...','DG008','123')
insert into tblDocGia values ('DG009',N'Lê Nguyễn Hồng Ngọc',N'Nữ','20/11/1999','0374694444',N'115 QL1, Q12',N'Bình thường','...','DG009','123')
insert into tblDocGia values ('DG010',N'Nguyễn Vũ Hoàng',N'Nam','15/01/1999','0365693224',N'111 Hà Huy Giáp, Q12',N'Bình thường','...','DG010','123')

--delete from tblSach

-- Chèn dữ liệu bảng tblHSPhieuMuon
insert into tblHSPhieuMuon values ('MP001','DG001','MS001','01/01/2023','21/01/2021','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP002','DG001','MS002','01/01/2023','21/01/2021','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP003','DG002','MS005','02/01/2023','22/01/2021','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP004','DG003','MS002','02/01/2023 ','22/01/2021','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP005','DG004','MS007','01/12/2021','21/12/2021','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP006','DG004','MS003','01/12/2021','21/12/2021','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP007','DG004','MS004','02/12/2021','22/12/2021','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP008','DG007','MS009','01/12/2021','21/12/2021','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP009','DG008','MS010','04/12/2021','24/12/2021','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP010','DG006','MS006','04/12/2021','12/01/2021','1',N'Mới','...')

---Chèn dữ liệu băng tblNhanVien
insert into tblNhanVien values ('NV001',N'Đào Hữu Hoa','Nam','12/01/1999','0357546532',N'Hà Nội',N'Ngôi sao','')
insert into tblNhanVien values ('NV002',N'Nguyễn Xuân Nam','Nam','1999/06/02','0357546532',N'Hà Nội',N'Độc đoán','')
insert into tblNhanVien values ('NV003',N'Nguyễn Phương Linh',N'Nữ','1999/08/02','0355876523',N'Hải Phòng',N'Nhanh nhạy','')


-- Chèn dữ liệu bảng tblThuThu
insert into tblThuThu values ('TT001',N'Nguyễn Đức Hiếu',N'Nam','09/12/1999','0359978022',N'Hạ Long - Quảng Ninh','','TT001','123')
insert into tblThuThu values ('TT002',N'Nguyễn Minh Quang',N'Nam','08/08/2003','0345487547',N'Uông Bí - Quảng Ninh','','TT002','123')


---select MaNXB, TenNXB from tblNhaXuatBan


---SELECT CONVERT(VARCHAR(10), GETDATE(), 103) AS [DD/MM/YYYY]

---MaNhaXuatBan
---TenNhaXuatBan
---Email
---SoDienThoaiNXB
---TrangThai 


-- có ngày hẹn trả
-- Chèn dữ liệu bảng tblHSPhieuMuon
/*
insert into tblHSPhieuMuon values ('MP003','DG002','MS005','02/01/2017','22/01/2017','22/01/2017','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP004','DG003','MS002','02/01/2017','22/01/2017','22/01/2017','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP005','DG004','MS007','01/12/2016','21/12/2016','21/12/2016','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP006','DG004','MS003','01/12/2016','21/12/2016','21/12/2016','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP007','DG004','MS004','02/12/2016','22/12/2016','22/12/2016','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP008','DG007','MS009','01/12/2017','21/12/2016','21/12/2016','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP009','DG008','MS010','04/12/2017','24/12/2016','24/12/2016','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP010','DG006','MS006','04/12/2017','12/01/2017','12/01/2017','1',N'Mới','...')
--delete from tblMuonTra
*/

--delete from tblDangNhap


/*
-- QL Sách

-- Load Sách
select MaSach, TenSach, TenTG, TenCD, TenNXB, SLNhap, SLCon, DonGia, TinhTrang from tblSach, tblTacGia, tblNhaXuatBan, tblChuDeSach where tblSach.MaTG=tblTacGia.MaTG and tblSach.MaCD=tblChuDeSach.MaCD and tblSach.MaNXB=tblNhaXuatBan.MaNXB
-- Tìm kiếm 
select MaSach, TenSach, TenTG, TenCD, TenNXB, SLNhap, SLCon, DonGia, TinhTrang from tblSach, tblTacGia, tblNhaXuatBan, tblChuDeSach where tblSach.MaTG=tblTacGia.MaTG and tblSach.MaCD=tblChuDeSach.MaCD and tblSach.MaNXB=tblNhaXuatBan.MaNXB and TenCD like N'%Lập%'

delete from tblSach where MaSach='MS0012'

select count(MaSach) as TongSLDauSach, sum(SLNhap) as TongSLSach, sum(SLCon) as TongSLCon, sum(DonGia) as TongGiaTriSach from tblSach

update tblSach set SLCon='75' where MaSach='MS011'

-- QL Độc Giả
select * from tblDocGia

delete from tblDocGia where MaDG='DG010'

select count(MaDG) as TongSLDG from tblDocGia


-- QL Mượn Trả

select * from tblMuonTra

select sum(SLMuon) as Tong from tblMuonTra where MaDG='DG001' group by MaDG

update tblMuonTra set NgayMuon='11/01/2017', NgayTra='31/01/2017' where MaPhieu='MP014'

select sum(SLMuon) as Tong from tblMuonTra

select (count(distinct(MaDG))) as TongSLDGMuon from tblMuonTra


--
select *
from tblMuonTra 

where substring(NgayTra,7,4) <  SUBSTRING(cast(GETDATE() as varchar),8,5)

and substring(NgayTra,4,2) < 13
and substring(NgayTra,1,2) < 22


-- tốt
-- SL DG quá Hạn
SELECT count(distinct(MaDG)) as TongSLQuaHan from tblMuonTra where CONVERT (datetime, NgayTra, 103) < getdate()

-- DS DG Quá Hạn
SELECT MaDG, count(SLMuon) as 'SL Sách Mượn' from tblMuonTra where CONVERT (datetime, NgayTra, 103) <= getdate() group by MaDG

-- SL SÁch quá hạn
SELECT count(SLMuon) as TongSLQuaHan 
from tblMuonTra 
where CONVERT (datetime, NgayTra, 103) <= getdate()

-- DS SÁch quá hạn
SELECT MaSach, count(SLMuon)
from tblMuonTra 
where CONVERT (datetime, NgayTra, 103) <= getdate()
group by MaSach

----------------

select *
from tblMuonTra 

where substring(NgayTra,1,2) <= 22

and substring(NgayTra,4,2) <= 01
and substring(NgayTra,7,4) <=  SUBSTRING(cast(GETDATE() as varchar),8,5)

and DateTime(substring(NgayTra,7,4),substring(NgayTra,4,2),substring(NgayTra,1,2))

------
select SUBSTRING(cast(GETDATE() as varchar),9,5) as nam


select substring(NgayTra,7,4) as Nam 
from tblMuonTra 

where substring(NgayTra,1,2) < 11


--group by MaPhieu 

-- SL chủ đề

select count(MaCD) as TongSLCD from tblChuDeSach

-- SL NXB 
select count(MaNXB) as TongSLNXB from tblNhaXuatBan

-- SL tác giả

select count(MaTG) as TongSLTG from tblTacGia

*/
