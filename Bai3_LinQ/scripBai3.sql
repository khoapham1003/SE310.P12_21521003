Create DATABASE LinQSE310;
use LinQSE310;

create table SanPham
(
 MaSP NVARCHAR(4),
 TenSP NVARCHAR(30),
 SoLuong Float,
 DonGia Float,
 XuatXu NVARCHAR(30),
 NgayHetHan Datetime,
);
INSERT INTO SanPham (MaSP, TenSP, SoLuong, DonGia, XuatXu, NgayHetHan)
VALUES ('SP01', 'San pham A', 100, 20000, 'Viet Nam', '2024-12-31');


