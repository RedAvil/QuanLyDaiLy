# Quản Lý Đại Lý

**Giới thiệu nhóm**

   >Mã nhóm: 19                                                                                                                          
   20424100 - Đỗ Tuấn Kiệt </br>
   21424087 - Nguyễn Đức Tài </br>
   21424040 -	Trần Thị Cẩm Nhung
   
 **Giới thiệu ứng dụng**
 
 >Trong thời đại tin học phát triển cực kỳ nhanh chóng như hiện nay, các công ty hoặc đại lý lớn muốn có sự quản lý các công ty con, đại lý con một cách hiệu quả và nhanh chóng để tăng hiệu quả kinh tế. Nắm bắt được nhu cầu và xu thế ấy, phần mềm quản lý các đại lý đã ra đời nhằm đáp ứng đầy đủ và kịp thời các nhu cầu mà các công ty, đại lý lớn đang cần.

**Môi trường và công nghệ sử dụng**

- OS: Windows 10
- IDE: Visual Studio.
- Language: C#.
- Database: SQL Server. 
- Framework: DevExpress UI.

**Chức năng và mô tả**

|**Tên chức năng**         |                                        **Mô tả**                                 |
|--------------------------|----------------------------------------------------------------------------------|
|Tiếp nhận đại lý| Nhận hồ sơ đại lý lưu thông tin đại lý vào cơ sở dữ liệu|
|Lập phiếu xuất hàng| Lập phiếu xuất hàng theo tháng tính tổng tiền |
|Tra cứu đại lý | Tra cứu đại lý theo tên |
|Lập phiếu thu tiền| Lập phiếu thu tiền đại lý|
|Lập báo cáo tháng| Lập báo cáo công nợ và doanh số theo tháng|
|Thay đổi qui định| Cho phép người dùng thay đổi các thông tin: số lượng đại lý, mặt hàng,đơn vị tính, tiền nợ tối đa|

**Quy định**

- QĐ1: Có 2 loại đại lý (1, 2 ). Có 20 quận. Trong mỗi quận có tối đa 4 đại lý. </br>
- QĐ2: Có 5 mặt hàng, 3 đơn vị tính. Đại lý loại 1 có tiền nợ tối đa 20.000, loại 2 tối đa 50.000. </br>
- QĐ4: Số tiền thu không vượt quá số tiền đại lý đang nợ. </br>
- QĐ6: Người dùng có thể thay đổi các qui định như sau: </br>
  + QĐ6.1: Thay đổi số lượng các loại đại lý, số các đại lý tối đa trong quận. </br>
  + QĐ6.2: Thay đổi số lượng mặt hàng cùng với đơn vị tính và đơn giá bán, tiền nợ tối đa cuả từng loại đại lý.