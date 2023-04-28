use TRA1
go

--loaisp--
insert into Loaisp (Maloaisp, Tenloaisp) values (N'L01', N'Trà xanh Thái Nguyên' )
insert into Loaisp (Maloaisp, Tenloaisp) values (N'L02', N'Trà Ô long' )
insert into Loaisp (Maloaisp, Tenloaisp) values (N'L03', N'Trà Shan Tuyết' )
insert into Loaisp (Maloaisp, Tenloaisp) values (N'L04', N'Trà sen' )
insert into Loaisp (Maloaisp, Tenloaisp) values (N'L05', N'Trà lai' )
insert into Loaisp (Maloaisp, Tenloaisp) values (N'L06', N'Trà thảo duợc' )
insert into Loaisp (Maloaisp, Tenloaisp) values (N'L07', N'Dụng cục pha trà' )
insert into Loaisp (Maloaisp, Tenloaisp) values (N'L08', N'Nước pha trà' )

--thuong hieu--
insert into Thuonghieu (Math, Tenth) values (N'H01', N'Trà Tân Cuong Xanh')
insert into Thuonghieu (Math, Tenth) values (N'H02', N'Trà Sen Tây Hà')
insert into Thuonghieu (Math, Tenth) values (N'H03', N'Trà Lộc Tân')

--khach hang--
insert into Khachhang (MaKH, TenKH, Diachi, SDT, Username_khach,Password_khach) values (N'K01', N'Toàn', N'Huế', 098651, N'toan', N'12345')
insert into Khachhang (MaKH, TenKH, Diachi, SDT, Username_khach,Password_khach) values (N'K02', N'Đức', N'Nghệ An', 098651, N'Duc', N'12345')
insert into Khachhang (MaKH, TenKH, Diachi, SDT, Username_khach,Password_khach) values (N'K03', N'Thảo', N'Quảng Bình', 098651, N'thao', N'12345')
insert into Khachhang (MaKH, TenKH, Diachi, SDT, Username_khach,Password_khach) values (N'K04', N'Thuyên', N'Bắc Ninh', 098651, N'thuyen', N'12345')

--hoa don ban--

 insert into Hoadonban(SoHDB, Ngayban, Tongtien, MaKH) values (N'HD01',  N'12-07-2022', 500000, N'K01')
 insert into Hoadonban(SoHDB, Ngayban, Tongtien, MaKH) values (N'HD02',  N'12-05-2023', 500000, N'K02')
 insert into Hoadonban(SoHDB, Ngayban, Tongtien, MaKH) values (N'HD03',  N'12-03-2023', 500000, N'K03')
 insert into Hoadonban(SoHDB, Ngayban, Tongtien, MaKH) values (N'HD04',  N'12-08-2022', 500000, N'K04')

 
 --admin--

insert into Admin (Username, Password) values (N'ngoduong', N'120722')
insert into Admin (Username, Password) values (N'PhamPhuc', N'120722')
insert into Admin (Username, Password) values (N'DinhSy', N'120722')
insert into Admin (Username, Password) values (N'LeTinh', N'120722')

--San Pham--

insert into Sanpham (MaSP,TenSP,Giaban, Mota, Trongluong, Cachpha, AnhSP, Ngaytao, Maloaisp, Math,Username) values 
(N'SP01', N'Trà San Tuyết', 50000, N'Sản phẩm đạt chuẩn vế sinh an toàn thực phẩm', N'200g', 
N'Cho 1-2 nắm trà( khoảng 20-30gram) vào nước ấm( khoảng 85 độ C) từ 150-200 ml, để trà 4-6 phút', N'sentuyet.png', N'12-04-2023',N'L03', N'H01', N'ngoduong')
insert into Sanpham (MaSP,TenSP,Giaban, Mota, Trongluong, Cachpha, AnhSP, Ngaytao, Maloaisp, Math,Username) values 
(N'SP02', N'Trà Búp', 50000, N'Sản phẩm đạt chuẩn vế sinh an toàn thực phẩm', N'200g', 
N'Cho 1-2 nắm trà( khoảng 20-30gram) vào nước ấm( khoảng 85 độ C) từ 150-200 ml, để trà 4-6 phút', N'trabup.png', N'12-04-2023',N'L04', N'H02', N'DinhSy')
insert into Sanpham (MaSP,TenSP,Giaban, Mota, Trongluong, Cachpha, AnhSP, Ngaytao, Maloaisp, Math,Username) values 
(N'SP03', N'Trà ôlong', 50000, N'Sản phẩm đạt chuẩn vế sinh an toàn thực phẩm', N'200g', 
N'Cho 1-2 nắm trà( khoảng 20-30gram) vào nước ấm( khoảng 85 độ C) từ 150-200 ml, để trà 4-6 phút', N'traolog.png', N'12-04-2023',N'L01', N'H03', N'PhamPhuc')
insert into Sanpham (MaSP,TenSP,Giaban, Mota, Trongluong, Cachpha, AnhSP, Ngaytao, Maloaisp, Math,Username) values 
(N'SP04', N'Trà San Tuyết', 50000, N'Sản phẩm đạt chuẩn vế sinh an toàn thực phẩm', N'200g', 
N'Cho 1-2 nắm trà( khoảng 20-30gram) vào nước ấm( khoảng 85 độ C) từ 150-200 ml, để trà 4-6 phút', N'sentuyet.png', N'12-04-2023',N'L03', N'H01', N'ngoduong')
insert into Sanpham (MaSP,TenSP,Giaban, Mota, Trongluong, Cachpha, AnhSP, Ngaytao, Maloaisp, Math,Username) values 
(N'SP05', N'Trà Búp', 50000, N'Sản phẩm đạt chuẩn vế sinh an toàn thực phẩm', N'200g', 
N'Cho 1-2 nắm trà( khoảng 20-30gram) vào nước ấm( khoảng 85 độ C) từ 150-200 ml, để trà 4-6 phút', N'trabup.png', N'12-04-2023',N'L04', N'H02', N'DinhSy')
insert into Sanpham (MaSP,TenSP,Giaban, Mota, Trongluong, Cachpha, AnhSP, Ngaytao, Maloaisp, Math,Username) values 
(N'SP06', N'Trà ôlong', 50000, N'Sản phẩm đạt chuẩn vế sinh an toàn thực phẩm', N'200g', 
N'Cho 1-2 nắm trà( khoảng 20-30gram) vào nước ấm( khoảng 85 độ C) từ 150-200 ml, để trà 4-6 phút', N'traolog.png', N'12-04-2023',N'L01', N'H03', N'PhamPhuc')
insert into Sanpham (MaSP,TenSP,Giaban, Mota, Trongluong, Cachpha, AnhSP, Ngaytao, Maloaisp, Math,Username) values 
(N'SP07', N'Trà San Tuyết', 50000, N'Sản phẩm đạt chuẩn vế sinh an toàn thực phẩm', N'200g', 
N'Cho 1-2 nắm trà( khoảng 20-30gram) vào nước ấm( khoảng 85 độ C) từ 150-200 ml, để trà 4-6 phút', N'sentuyet.png', N'12-04-2023',N'L03', N'H01', N'ngoduong')
insert into Sanpham (MaSP,TenSP,Giaban, Mota, Trongluong, Cachpha, AnhSP, Ngaytao, Maloaisp, Math,Username) values 
(N'SP08', N'Trà Búp', 50000, N'Sản phẩm đạt chuẩn vế sinh an toàn thực phẩm', N'200g', 
N'Cho 1-2 nắm trà( khoảng 20-30gram) vào nước ấm( khoảng 85 độ C) từ 150-200 ml, để trà 4-6 phút', N'trabup.png', N'12-04-2023',N'L04', N'H02', N'DinhSy')
insert into Sanpham (MaSP,TenSP,Giaban, Mota, Trongluong, Cachpha, AnhSP, Ngaytao, Maloaisp, Math,Username) values 
(N'SP09', N'Trà ôlong', 50000, N'Sản phẩm đạt chuẩn vế sinh an toàn thực phẩm', N'200g', 
N'Cho 1-2 nắm trà( khoảng 20-30gram) vào nước ấm( khoảng 85 độ C) từ 150-200 ml, để trà 4-6 phút', N'traolog.png', N'12-04-2023',N'L01', N'H03', N'PhamPhuc')
insert into Sanpham (MaSP,TenSP,Giaban, Mota, Trongluong, Cachpha, AnhSP, Ngaytao, Maloaisp, Math,Username) values 
(N'SP10', N'Trà San Tuyết', 50000, N'Sản phẩm đạt chuẩn vế sinh an toàn thực phẩm', N'200g', 
N'Cho 1-2 nắm trà( khoảng 20-30gram) vào nước ấm( khoảng 85 độ C) từ 150-200 ml, để trà 4-6 phút', N'sentuyet.png', N'12-04-2023',N'L03', N'H01', N'ngoduong')
insert into Sanpham (MaSP,TenSP,Giaban, Mota, Trongluong, Cachpha, AnhSP, Ngaytao, Maloaisp, Math,Username) values 
(N'SP11', N'Trà Búp', 50000, N'Sản phẩm đạt chuẩn vế sinh an toàn thực phẩm', N'200g', 
N'Cho 1-2 nắm trà( khoảng 20-30gram) vào nước ấm( khoảng 85 độ C) từ 150-200 ml, để trà 4-6 phút', N'trabup.png', N'12-04-2023',N'L04', N'H02', N'DinhSy')
insert into Sanpham (MaSP,TenSP,Giaban, Mota, Trongluong, Cachpha, AnhSP, Ngaytao, Maloaisp, Math,Username) values 
(N'SP12', N'Trà ôlong', 50000, N'Sản phẩm đạt chuẩn vế sinh an toàn thực phẩm', N'200g', 
N'Cho 1-2 nắm trà( khoảng 20-30gram) vào nước ấm( khoảng 85 độ C) từ 150-200 ml, để trà 4-6 phút', N'traolog.png', N'12-04-2023',N'L01', N'H03', N'PhamPhuc')
insert into Sanpham (MaSP,TenSP,Giaban, Mota, Trongluong, Cachpha, AnhSP, Ngaytao, Maloaisp, Math,Username) values 
(N'SP13', N'Trà ôlong', 50000, N'Sản phẩm đạt chuẩn vế sinh an toàn thực phẩm', N'200g', 
N'Cho 1-2 nắm trà( khoảng 20-30gram) vào nước ấm( khoảng 85 độ C) từ 150-200 ml, để trà 4-6 phút', N'traolog.png', N'12-04-2023',N'L02', N'H02', N'PhamPhuc')

--TIN TUC--


insert into Tintuc (MaTT, Tieude, Gioithieu, AnhTT, ngaytaott,Username) values (N'T01',N'Văn hóa uống trà của người Việt câu chuyện xưa và nay', N'Trà xanh thái nguyên được phổ biến là một thức uống đã quen thuộc từ bao đời nay, cây chề tháy nguyên, Phú thọ yên bái m lầm đồng ... là nguyền gốc cho ra những sản phẩm có chất lượng cao.',
N'TINTUC_01.jpg',N'12-05-2023',N'ngoduong' )
insert into Tintuc (MaTT, Tieude, Gioithieu, AnhTT, ngaytaott,Username) values (N'T02',N'Chè xanh Thái Nguyên ướp hoa nhài', N'Ở Việt Nam có rất nhiều nơi trồng hoa nhài, đây là loại hoa nở tới 6 tháng / năm nen hoa nhài tự nhiên được sử dụng để ướp trà rất nhiều và ướp trà với hoa nhài vớ giá thành rẻ hơn so với ướp bông hoa sẽ Tây Hồ',
N'TINTUC_05.jpg',N'13-05-2023',N'DinhSy')
insert into Tintuc (MaTT, Tieude, Gioithieu, AnhTT, ngaytaott,Username) values (N'T03',N'Cách bảo quản trà Shan Tuyết để giữ được hương thơm', N'Chè là loại thức uống dễ mất hương và vị nhất, cũng đễ hút những mùi hương khác lạ khiến chè mất dần đi mùi hơi vị ban đầu. Bảo quản chè là việc hết sức quan trọng mà mõi người uống chè phải biết',
N'TINTUC_03.jpg',N'13-05-2023',N'LeTinh')
insert into Tintuc (MaTT, Tieude, Gioithieu, AnhTT, ngaytaott,Username) values (N'T04',N'Văn hóa uống trà của người Việt câu chuyện xưa và nay', N'Trà xanh thái nguyên được phổ biến là một thức uống đã quen thuộc từ bao đời nay, cây chề tháy nguyên, Phú thọ yên bái m lầm đồng ... là nguyền gốc cho ra những sản phẩm có chất lượng cao.',
N'TINTUC_01.jpg',N'12-05-2023',N'ngoduong' )
insert into Tintuc (MaTT, Tieude, Gioithieu, AnhTT, ngaytaott,Username) values (N'T05',N'Chè xanh Thái Nguyên ướp hoa nhài', N'Ở Việt Nam có rất nhiều nơi trồng hoa nhài, đây là loại hoa nở tới 6 tháng / năm nen hoa nhài tự nhiên được sử dụng để ướp trà rất nhiều và ướp trà với hoa nhài vớ giá thành rẻ hơn so với ướp bông hoa sẽ Tây Hồ',
N'TINTUC_05.jpg',N'13-05-2023',N'DinhSy')
insert into Tintuc (MaTT, Tieude, Gioithieu, AnhTT, ngaytaott,Username) values (N'T06',N'Cách bảo quản trà Shan Tuyết để giữ được hương thơm', N'Chè là loại thức uống dễ mất hương và vị nhất, cũng đễ hút những mùi hương khác lạ khiến chè mất dần đi mùi hơi vị ban đầu. Bảo quản chè là việc hết sức quan trọng mà mõi người uống chè phải biết',
N'TINTUC_03.jpg',N'13-05-2023',N'LeTinh')
insert into Tintuc (MaTT, Tieude, Gioithieu, AnhTT, ngaytaott,Username) values (N'T07',N'Văn hóa uống trà của người Việt câu chuyện xưa và nay', N'Trà xanh thái nguyên được phổ biến là một thức uống đã quen thuộc từ bao đời nay, cây chề tháy nguyên, Phú thọ yên bái m lầm đồng ... là nguyền gốc cho ra những sản phẩm có chất lượng cao.',
N'TINTUC_01.jpg',N'12-05-2023',N'ngoduong' )
insert into Tintuc (MaTT, Tieude, Gioithieu, AnhTT, ngaytaott,Username) values (N'T08',N'Chè xanh Thái Nguyên ướp hoa nhài', N'Ở Việt Nam có rất nhiều nơi trồng hoa nhài, đây là loại hoa nở tới 6 tháng / năm nen hoa nhài tự nhiên được sử dụng để ướp trà rất nhiều và ướp trà với hoa nhài vớ giá thành rẻ hơn so với ướp bông hoa sẽ Tây Hồ',
N'TINTUC_05.jpg',N'13-05-2023',N'DinhSy')
insert into Tintuc (MaTT, Tieude, Gioithieu, AnhTT, ngaytaott,Username) values (N'T09',N'Cách bảo quản trà Shan Tuyết để giữ được hương thơm', N'Chè là loại thức uống dễ mất hương và vị nhất, cũng đễ hút những mùi hương khác lạ khiến chè mất dần đi mùi hơi vị ban đầu. Bảo quản chè là việc hết sức quan trọng mà mõi người uống chè phải biết',
N'TINTUC_03.jpg',N'13-05-2023',N'LeTinh')


--Nghenhan--


insert into Nghenhan (MaNN, Tennghenhan,AnhNN, Thongtin, Username) values (N'NN01', N'Nn.Nguyễn Cao Sơn',N'professional-tea-1.png',N'Nguyễn Cao Sơn được chọn làm đại diện quảng bá vă hóa Trà Việt tại ngôi nhà di sản 87 Mã Mây, Hà Nội',N'ngoduong')
insert into Nghenhan (MaNN, Tennghenhan,AnhNN, Thongtin, Username) values (N'NN02', N'Nn.Hướng Anh Sướng',N'professional-tea-2.png',N'Truyền nhân đời thứ 6 của đông trà Trường Xuân, Hà Nội chia sẻ về nghệ thuật trà đạo, lĩnh vực mà giành cả nửa cuộc đời nghiên cứu mộ cách đam mê',N'ngoduong')
insert into Nghenhan (MaNN, Tennghenhan,AnhNN, Thongtin, Username) values (N'NN03', N'Nn.Nguyên Thị Dần',N'professional-tea-3.png',N'Vẫn tự tay chọn hoa, tách gao, thực hiện từng công đọan ướp trà sen. Cũng chính bời nghiện trà, bởi yêu nghề nên cô thếu nữ Hà thành năm xưa vẫn say hương vị sen Tây Hồ ',N'DinhSy')
insert into Nghenhan (MaNN, Tennghenhan,AnhNN, Thongtin, Username) values (N'NN04', N'Nn.Nguyễn Hoài Linh',N'professional-tea-4.png',N'Vô địch thế giới trong cuộc th Tea Master Cup International 2018 về pha trà được tổ chức tại Huế',N'PhamPhuc')
insert into Nghenhan (MaNN, Tennghenhan,AnhNN, Thongtin, Username) values (N'NN05', N'Nn.Viên Trân',N'professional-tea-5.png',N'Sinh ra và lớn lên trong một gia đình quý tộc phong kiên, trong một môi trường mà việc uống trà và trà cực ngon, cực thượng hạng là điều không bao giờ thiếu trong nhà',N'ngoduong')

--chitiethdb--


insert into Chitiethdb (SoHDB, MaSP,SL,Giamua) values (N'HD01', N'SP01', 4, 50000)
insert into Chitiethdb (SoHDB, MaSP,SL,Giamua) values (N'HD02', N'SP02', 5, 50000)
insert into Chitiethdb (SoHDB, MaSP,SL,Giamua) values (N'HD03', N'SP03', 6, 50000)
insert into Chitiethdb (SoHDB, MaSP,SL,Giamua) values (N'HD04', N'SP04', 6, 50000)

