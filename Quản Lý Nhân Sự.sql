--Tạo database
create database QLNS
go

--Sử dụng database
use QLNS
go

--Tạo bảng
--bảng tài khoản
create table tb_TaiKhoan
(
	TenTK varchar(50) primary key,
	MatKhau varchar(50) not null,
	LoaiTK int
)
go

--bảng nhân viên
create table tb_NhanVien
(
	MaNV varchar(20) primary key,
	HoTen nvarchar(50) not null,
	GioiTinh nvarchar(5),
	NgaySinh Date,
	CCCD varchar(12),
	DiaChi nvarchar(50),
	SoDienThoai varchar(11),
	Email varchar(50),
	TenTK varchar(50),
	MaPhongBan varchar(20),
	MaChucVu varchar(20),
	MaTDHV varchar(20)
)
go

--bảng phòng ban
create table tb_PhongBan
(
	MaPhongBan varchar(20) primary key,
	TenPhongBan nvarchar(50),
	SoPhong int,
	SDTPB varchar(11)
)
go

--bảng chức vụ
create table tb_ChucVu
(
	MaChucVu varchar(20) primary key,
	TenChucVu nvarchar(50)
)
go
--bảng trình độ học vấn
create table tb_TrinhDoHocVan
(
	MaTDHV varchar(20) primary key,
	TenTDHV nvarchar(50),
	ChuyenNganh nvarchar(50)
)
go
--bảng hợp đồng lao động
create table tb_HopDongLaoDong
(
	MaHD varchar(20) primary key,
	LoaiHD nvarchar(50),
	NgayBatDau date,
	NgayKetThuc date,
	NgayKy date,
	SoLanKy varchar(5),
	NoiDung nvarchar(max),
	ThoiHan nvarchar(50),
	HeSoLuong float,
	MaNV varchar(20)
)
go
--bảng bảo hiểm
create table tb_BaoHiem
(
	MaBH varchar(20) primary key,
	SoBH varchar(20),
	NgayCap datetime,
	NoiCap nvarchar(50),
	MaNV varchar(20)
)
go
--bảng khen thưởng kỷ luật
create table tb_KhenThuongVaKyLuat
(
	ID int primary key,
	MaKTVKL varchar(20),
	NoiDung nvarchar(max),
	Ngay datetime,
	Loai nvarchar(20),
	MaNV varchar(20)
)
go
--bảng chấm công
create table tb_BangChamCong
(
	MaCong varchar(20) primary key,
	MaNV varchar(20),
	HoTen nvarchar(50),
	MaChucVu varchar(20),
	D1 nvarchar(10),
	D2 nvarchar(10),
	D3 nvarchar(10),
	D4 nvarchar(10),
	D5 nvarchar(10),
	D6 nvarchar(10),
	D7 nvarchar(10),
	D8 nvarchar(10),
	D9 nvarchar(10),
	D10 nvarchar(10),
	D11 nvarchar(10),
	D12 nvarchar(10),
	D13 nvarchar(10),
	D14 nvarchar(10),
	D15 nvarchar(10),
	D16 nvarchar(10),
	D17 nvarchar(10),
	D18 nvarchar(10),
	D19 nvarchar(10),
	D20 nvarchar(10),
	D21 nvarchar(10),
	D22 nvarchar(10),
	D23 nvarchar(10),
	D24 nvarchar(10),
	D25 nvarchar(10),
	D26 nvarchar(10),
	D27 nvarchar(10),
	D28 nvarchar(10),
	D29 nvarchar(10),
	D30 nvarchar(10),
	D31 nvarchar(10),
	NgayNghi float,
	TongNgayCong float
)
go


--Khóa ngoại
alter table tb_NhanVien add constraint FK_NVTK foreign key (TenTK) references tb_TaiKhoan(TenTK)
alter table tb_NhanVien add constraint FK_NVPB foreign key (MaPhongBan) references tb_PhongBan(MaPhongBan)
alter table tb_NhanVien add constraint FK_NVCV foreign key (MaChucVu) references tb_ChucVu(MaChucVu)
alter table tb_NhanVien add constraint FK_NVTDHV foreign key (MaTDHV) references tb_TrinhDoHocVan(MaTDHV)
alter table tb_BangChamCong add constraint FK_BCCNV foreign key (MaNV) references tb_NhanVien(MaNV)
alter table tb_BaoHiem add constraint FK_BHNV foreign key (MaNV) references tb_NhanVien(MaNV)
alter table tb_HopDongLaoDong add constraint FK_HDLDNV foreign key (MaNV) references tb_NhanVien(MaNV)
alter table tb_KhenThuongVaKyLuat add constraint FK_KTKLNV foreign key (MaNV) references tb_NhanVien(MaNV)
go


--Các dữ liệu store

--Bảng nhân viên(thêm, xóa, sửa, gọi, tìm)
--Tìm nhân viên
create proc sp_tbNhanVien_Tim
	@MaNV varchar(20)
as
select * from tb_NhanVien where MaNV like '%'+@MaNV+'%'
go
--Thêm nhân viên
create proc sp_tbNhanVien_Them
	@MaNV varchar(20),
	@HoTen nvarchar(50),
	@GioiTinh nvarchar(5),
	@NgaySinh Date,
	@CCCD nvarchar(50),
	@DiaChi nvarchar(50),
	@SoDienThoai varchar(11),
	@Email varchar(50),
	@MaPhongBan varchar(20),
	@MaChucVu varchar(20),
	@MaTDHV varchar(20)
as
insert into tb_NhanVien (MaNV,HoTen,GioiTinh,NgaySinh,CCCD,DiaChi,SoDienThoai,Email,MaPhongBan,MaChucVu,MaTDHV)
values (@MaNV,@HoTen,@GioiTinh,@NgaySinh,@CCCD,@DiaChi,@SoDienThoai,@Email,@MaPhongBan,@MaChucVu,@MaTDHV)
go
--Xóa Nhân viên
create proc sp_tbNhanVien_Xoa
@MANV nvarchar(10)
as
delete from tb_NhanVien where MaNV=@MANV
go
--Sửa nhân viên
create proc sp_tbNhanVien_Sua
	@MaNV varchar(20),
	@HoTen nvarchar(50),
	@GioiTinh nvarchar(5),
	@NgaySinh Date,
	@CCCD nvarchar(50),
	@DiaChi nvarchar(50),
	@SoDienThoai varchar(11),
	@Email varchar(50),
	@MaPhongBan varchar(20),
	@MaChucVu varchar(20),
	@MaTDHV varchar(20)
	as
	update tb_NhanVien
	set HoTen = @HoTen
	,GioiTinh = @GioiTinh 
	,NgaySinh = @NgaySinh
	,CCCD = @CCCD
	,DiaChi = @DiaChi
	,SoDienThoai =@SoDienThoai
	,Email = @Email
	,MaPhongBan = @MaPhongBan
	,MaChucVu = @MaChucVu
	,MaTDHV = @MaTDHV
	where MaNV = @MaNV
go
--Gọi 
create proc sp_tbNhanVien_Goi
as
select MaNV,HoTen,GioiTinh,NgaySinh,CCCD,DiaChi,SoDienThoai,Email,MaPhongBan,MaChucVu,MaTDHV from tb_NhanVien
go
--Bảng Trình độ học vấn(thêm, xóa, sửa, gọi)
--Thêm
create proc sp_tbTrinhDoHocVan_Them
	@MaTDHV varchar(20),
	@TenTDHV nvarchar(50),
	@ChuyenNganh nvarchar(50)
as
insert into tb_TrinhDoHocVan(MaTDHV,TenTDHV,ChuyenNganh)
values(@MaTDHV,@TenTDHV,@ChuyenNganh)
go
--Xóa
create proc sp_tbTrinhDoHocVan_Xoa
	@MaTDHV varchar(20)
as
delete from tb_TrinhDoHocVan where MaTDHV=@MaTDHV
go
--Sửa
create proc sp_tbTrinhDoHocVan_Sua
	@MaTDHV varchar(20),
	@TenTDHV nvarchar(50),
	@ChuyenNganh nvarchar(50)
	as
	update tb_TrinhDoHocVan
	set TenTDHV = @TenTDHV,
	ChuyenNganh = @ChuyenNganh
	where MaTDHV = @MaTDHV
go
--Gọi
create proc sp_tbTrinhDoHocVan_Goi
as
select * from tb_TrinhDoHocVan
go

--Bảng chấm công(thêm, xóa, sửa, gọi)
--gọi
create proc sp_tbBangChamCong_Goi
as
select * from tb_BangChamCong
go

--Bảng phòng ban(thêm, xóa, sửa, gọi)
--thêm
create proc sp_tbPhongBan_Them
	@MaPhongBan varchar(20),
	@TenPhongBan nvarchar(50),
	@SoPhong int,
	@SDTPB varchar(11)
as
insert into tb_PhongBan(MaPhongBan,TenPhongBan,SoPhong,SDTPB)
values(@MaPhongBan,@TenPhongBan,@SoPhong,@SDTPB)
go
--xóa
create proc sp_tbPhongBan_Xoa
	@MaPhongBan varchar(20)
as
delete from tb_PhongBan where MaPhongBan=@MaPhongBan
go
--sửa
create proc sp_tbPhongBan_Sua
	@MaPhongBan varchar(20),
	@TenPhongBan nvarchar(50),
	@SoPhong int,
	@SDTPB varchar(11)
as
update tb_PhongBan
	set TenPhongBan=@TenPhongBan,
	SoPhong=@SoPhong,
	SDTPB=@SDTPB
	where MaPhongBan = @MaPhongBan
go
--gọi
create proc sp_tbPhongBan_Goi
as
select * from tb_PhongBan
go

--Bảng khen thưởng và kỷ luật(thêm, xóa, sửa, gọi)
--thêm
create proc sp_tbKhenThuongVaKyLuat_Them
	@ID int,
	@MaKTVKL varchar(20),
	@NoiDung nvarchar(max),
	@Ngay datetime,
	@Loai nvarchar(20),
	@MaNV varchar(20)
as
insert into tb_KhenThuongVaKyLuat(ID,MaKTVKL,NoiDung,Ngay,Loai,MaNV)
values (@ID,@MaKTVKL,@NoiDung,@Ngay,@Loai,@MaNV)
go
--xóa
create proc sp_tbKhenThuongVaKyLuat_Xoa
	@ID int
as
delete from tb_KhenThuongVaKyLuat where ID=@ID;
go
--sửa
create proc sp_tbKhenThuongVaKyLuat_Sua
	@ID int,
	@MaKTVKL varchar(20),
	@NoiDung nvarchar(max),
	@Ngay datetime,
	@Loai nvarchar(20),
	@MaNV varchar(20)
as
update tb_KhenThuongVaKyLuat
	set MaKTVKL=@MaKTVKL,
	NoiDung=@NoiDung,
	Ngay=@Ngay,
	Loai=@Loai,
	MaNV=@MaNV
	where ID=@ID
go
--gọi 
create proc sp_tbKhenThuongVaKyLuat_Goi
as
select * from tb_KhenThuongVaKyLuat
go

--Bảng hợp đồng lao động(thêm, xóa, sửa, gọi)
--thêm
create proc sp_tbHopDongLaoDong_Them
	@MaHD varchar(20),
	@LoaiHD nvarchar(50),
	@NgayBatDau datetime,
	@NgayKetThuc datetime,
	@NgayKy datetime,
	@SoLanKy varchar(5),
	@NoiDung nvarchar(max),
	@ThoiHan nvarchar(50),
	@HeSoLuong float,
	@MaNV varchar(20)
as
insert into tb_HopDongLaoDong(MaHD,LoaiHD,NgayBatDau,NgayKetThuc,NgayKy,SoLanKy,NoiDung,ThoiHan,HeSoLuong,MaNV)
values (@MaHD,@LoaiHD,@NgayBatDau,@NgayKetThuc,@NgayKy,@SoLanKy,@NoiDung,@ThoiHan,@HeSoLuong,@MaNV)
go
--xóa
create proc sp_tbHopDongLaoDong_Xoa
	@MaHD varchar(20)
as
delete from tb_HopDongLaoDong where MaHD=@MaHD
go
--sửa
create proc sp_tbHopDongLaoDong_Sua
	@MaHD varchar(20),
	@LoaiHD nvarchar(50),
	@NgayBatDau datetime,
	@NgayKetThuc datetime,
	@NgayKy datetime,
	@SoLanKy varchar(5),
	@NoiDung nvarchar(max),
	@ThoiHan nvarchar(50),
	@HeSoLuong float,
	@MaNV varchar(20)
as
update tb_HopDongLaoDong
	set LoaiHD=@LoaiHD,
	NgayBatDau=@NgayBatDau,
	NgayKetThuc=@NgayKetThuc,
	NgayKy=@NgayKy,
	SoLanKy=@SoLanKy,
	NoiDung=@NoiDung,
	ThoiHan=@ThoiHan,
	HeSoLuong=@HeSoLuong,
	MaNV=@MaNV
	where MaHD = @MaHD
go
--gọi
create proc sp_tbHopDongLaoDong_Goi
as
select * from tb_HopDongLaoDong
go

--Bảng chức vụ(thêm, xóa, sửa, gọi)
--thêm
create proc sp_tbChucVu_Them
	@MaChucVu varchar(20),
	@TenChucVu nvarchar(50)
as
insert into tb_ChucVu(MaChucVu,TenChucVu)
values (@MaChucVu,@TenChucVu)
go
--xóa
create proc sp_tbChucVu_Xoa
	@MaChucVu varchar(20)
as
delete from tb_ChucVu where MaChucVu=@MaChucVu
go
--sửa
create proc sp_tbChucVu_Sua
	@MaChucVu varchar(20),
	@TenChucVu nvarchar(50)
as
update tb_ChucVu
	set TenChucVu=@TenChucVu
	where MaChucVu=@MaChucVu
go
--gọi
create proc sp_tbChucVu_Goi
as
select * from tb_ChucVu
go

--Bảng bảo hiểm(thêm, xóa, sửa, gọi)
--thêm
create proc sp_tbBaoHiem_Them
	@MaBH varchar(20),
	@SoBH varchar(20),
	@NgayCap datetime,
	@NoiCap nvarchar(50),
	@MaNV varchar(20)
as
insert into tb_BaoHiem(MaBH,SoBH,NgayCap,NoiCap,MaNV)
values (@MaBH,@SoBH,@NgayCap,@NoiCap,@MaNV)
go
--xóa
create proc sp_tbBaoHiem_Xoa
	@MaBH varchar(20)
as
delete from tb_BaoHiem where MaBH=@MaBH
go
--sửa
create proc sp_tbBaoHiem_Sua
	@MaBH varchar(20),
	@SoBH varchar(20),
	@NgayCap datetime,
	@NoiCap nvarchar(50),
	@MaNV varchar(20)
as
update tb_BaoHiem
	set SoBH=@SoBH,
	NgayCap=@NgayCap,
	NoiCap=@NoiCap,
	MaNV=@MaNV
	where MaBH=@MaBH
go
--gọi
create proc sp_tbBaoHiem_Goi
as
select * from tb_BaoHiem
go                           


/*
Chèn dữ liệu cho mỗi phòng ban
*/
--Bảng bảo hiểm
insert into tb_BaoHiem (MaBH, SoBH,NgayCap,NoiCap,MaNV)
values('01','222113957','2019/12/24',N'Sơn La',null),
	('02','111113957','2015/01/30',N'Tây Ninh',null),	
	('03','333113957','2016/03/12',N'Nghệ An',null)
go

--Bảng chức vụ
insert into tb_ChucVu (MaChucVu,TenChucVu)
values('01',N'Kỹ sư phần mềm'),
	('02',N'Marketing'),
	('03',N'Thiết kế')
go

--Bảng hợp động lao động
insert into tb_HopDongLaoDong(MaHD,LoaiHD,NgayBatDau,NgayKetThuc,NgayKy,SoLanKy,NoiDung,ThoiHan,HeSoLuong,MaNV)
values('01',N'Xác định thời hạn','2019/4/12','2022/4/12','2019/4/08','1',null,N'36 Tháng','2.1',null),
	('02',N'Thời vụ','2018/2/09','2019/2/12','2019/2/07','1',null,N'12 Tháng','1',null),
	('03',N'Xác định thời hạn','2020/7/25','2022/7/25','2020/6/20','1',null,N'24 Tháng','1.5',null)
go

--Bảng khen thưởng và kỷ luật
insert into tb_KhenThuongVaKyLuat(ID,MaKTVKL,NoiDung,Ngay,Loai,MaNV)
values('01','1001',N'Xuất xắc trong công việc','2023/6/12',N'Khen thưởng',null),
	('02','104',N'Cá nhân xuất xắc nhất trong giải','2022/7/08',N'Khen thưởng',null),
	('03','103',N'Thưởng lương tháng 13','2022/3/21',N'Khen thưởng',null),
	('04','102',N'Đi làm muộn quá nhiều','2022/8/23',N'Kỷ luật',null)
go

--Bảng nhân viên
insert into tb_NhanVien(MaNV,HoTen,GioiTinh,NgaySinh,CCCD,DiaChi,SoDienThoai,Email,TenTK,MaPhongBan,MaChucVu,MaTDHV)
values('2201',N'Trần Thị Thủy',N'Nữ','1992/8/27','985762464751',N'TP.Hồ Chí Minh','0937248521',null,null,null,null,null),
	('2202',N'Thạch Trang ',N'Nữ','1994/2/12','123524642332',N'Đà Nẵng','0937248521',null,null,null,null,null),
	('2203',N'Hồ Cao Thắng',N'Nam','1999/10/12','455731236893',N'Phú Yên','0937248521',null,null,null,null,null),
	('2204',N'Trần Đình Nam',N'Nam','2002/7/1','0602020266e',N'Huế','0395541678',null,null,null,null,null),
	('2205',N'Ngô Minh Hiền',N'Nữ','1998/5/12','455731236893',N'Tây Ninh','093975321',null,null,'01','01','02'),
	('2206',N'Nguyễn Hoài Bảo',N'Nam','2000/3/12','98234567534',N'Ninh Thuận','0986431521',null,null,'01','01','01')
go

--Bảng phòng ban
insert into tb_PhongBan(MaPhongBan,TenPhongBan,SoPhong,SDTPB)
values('01',N'Kế toán','101','03245678274'),
	('02',N'Thiết kế','204','0314567895'),
	('03',N'IT','301','0723456982')
go

--Bảng tài khoản
insert into tb_TaiKhoan(TenTK,MatKhau,LoaiTK)
values('admin','123',0),
	('phuquy','123',1),
	('thanhtrung','123',2)
go

--Bảng trình độ học vấn
insert into tb_TrinhDoHocVan(MaTDHV,TenTDHV,ChuyenNganh)
values('01',N'Cao Đẳng',N'Quản trị hệ thống máy tính'),
	('02',N'Đại Học',N'Marketing'),
	('03',N'Thạc Sĩ',N'Quản lý nhân sự')
go

--Tìm theo mã hợp đồng
create proc timtheoma(@mahd nvarchar(20))
as
select*from tb_HopDongLaoDong hd,tb_NhanVien nv
where hd.MaNV=nv.MaNV and hd.MaHD=@mahd
go
