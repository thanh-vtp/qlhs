CREATE DATABASE Quanlythongtinhocsinh
GO
USE Quanlythongtinhocsinh
GO

create table Lop
(
Lop nvarchar(4) not null primary key
)

create table Hocsinh
(
MSHS varchar(8) primary key not null,
Ten nvarchar(30) not null,
GioiTinh nvarchar(5) not null,
NgaySinh date,
DiaChi nvarchar(20) not null,
SDT varchar(10) not null,
Lop nvarchar(4) foreign key references Lop(Lop)
)


/*7*/
insert into Lop
values
('10A1'),('10A2'),('10A3'),
('11A1'),('11A2'),('11A3'),
('12A1'),('12A2'),('12A3')

/*10*/
/* Thêm học sinh */
insert into Hocsinh
values
('62131900',N'Trần Thị Mỹ Duyên',N'Nữ','2002-04-05',N'Cam Ranh-Khánh Hòa','0341236456','10A1'),
('62131901',N'Phạm Nguyễn Duy Phúc',N'Nam','2002-01-13',N'Cam Ranh-Khánh Hòa','0332338867','10A2'),
('62131902',N'Phạm Nguyễn Duy Hảo',N'Nam','2002-01-13',N'Cam Ranh-Khánh Hòa','0377768635','10A3'),
('62131903',N'Nguyễn Thị Thanh Thúy',N'Nữ','2001-11-20',N'Cam Ranh-Khánh Hòa','0383456789','11A1'),
('62131904',N'Võ Trần Phương Thanh',N'Nam','2001-11-08',N'Cam Lâm-Khánh Hòa','0345938625','11A2'),
('62131905',N'Huỳnh Mai Thanh Nhã',N'Nữ','2000-04-10',N'Cam Ranh-Khánh Hòa','0387894566','12A1'),
('62131906',N'Nguyễn Đinh Gia Cường',N'Nam','2000-02-02',N'Cam Ranh-Khánh Hòa','0364562258','12A2'),
('62131907',N'Phùng Thị Mỹ Tâm',N'Nữ','2000-10-30',N'Cam Lâm-Khánh Hòa','0301020028','12A3'),
('62131908',N'Trần Quốc Huy',N'Nam','2002-08-08',N'Cam Lâm-Khánh Hòa','0333789456','10A1'),
('62131909',N'Trần Minh Tuấn',N'Nam','2001-07-07',N'Cam Lâm-Khánh Hòa','0387534466','11A3')


/*Xóa học sinh*/
delete from  Hocsinh
where MSHS = 'Mã số học sinh'

/*Sửa thông tin học sinh*/
update Hocsinh
set Ten = N'Tên học sinh'
	GioiTinh = N'Giới Tính',
	NgaySinh = 'Ngày Sinh',
	DiaChi = N'Địa Chỉ'
	SDT = 'Số điện thọai'
	Lop = 'Lớp'
where MSHS = 'Mã số học sinh'

/* Tìm kiếm Học sinh */
select * from Hocsinh
where	MSHS = 'Mã số học sinh'
		Ten like N'%Tên học sinh%'
		GioiTinh = N'Giới Tính',
		NgaySinh = 'Ngày Sinh',
		DiaChi like N'%Địa Chỉ%'
		SDT = 'Số điện thọai'
		Lop = 'Lớp'


/*Tìm thông tin học sinh mshs 62131904*/
select * from Hocsinh
where	MSHS = '62131904'
		and Ten like N'%thanh%'
		and GioiTinh = N'Nam'
		and NgaySinh ='2001-11-08'
		and DiaChi like N'%cam lâm%'
		and SDT = '0345938625'
		and Lop = '11A2'



delete Lop
delete Hocsinh

drop table Lop
drop table Hocsinh