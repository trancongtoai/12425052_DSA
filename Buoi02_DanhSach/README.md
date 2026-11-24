# Buổi 02 – Danh sách

Họ tên: Trần Công Toại · MSV: 12425052

## Bài đã làm
- **Bài 1 (Mảng một chiều):**
  - Câu a: Nhập mảng
  - Câu b: Hiển thị mảng
  - Câu c: Chèn phần tử `x` vào vị trí `k`
- **Bài 2 (Struct Nhân viên):**
  - Câu a: Tính tổng thực lĩnh tháng của các nhân viên
  - Câu b: Tìm nhân viên có lương cơ bản thấp nhất
  - Câu c: Đếm số nhân viên có mức thưởng `>= 1.200.000`
  - Câu d: Sắp xếp danh sách tăng dần theo phòng ban, giảm dần theo mã nhân viên
  - Câu e: Cập nhật tăng lương cơ bản thêm 5%
- **Bài 3 (Ma trận vuông):**
  - Câu a: Tính tổng các phần tử của ma trận
  - Câu b: Tìm giá trị dương nhỏ nhất
  - Câu c: Tính tổng các phần tử trên đường chéo phụ
  - Câu d: Kiểm tra đường chéo chính có tăng dần hay không
- **Bài 4 (Danh sách liên kết đơn - `pHead`):**
  - Câu a: Đếm số phần tử có giá trị bằng `x`
  - Câu b: Tìm phần tử dương nhỏ nhất
  - Câu c: Xóa phần tử có giá trị `x` xuất hiện đầu tiên
- **Bài 5 (Danh sách liên kết đơn - `l`):**
  - Câu a: Tìm phần tử lớn nhất
  - Câu b: Tính tổng các phần tử
  - Câu c: Đếm số lượng số nguyên tố
  - Câu d: Đếm số lượng số âm, số dương và số bằng 0
  - Câu e: Đếm số lượng phần tử bằng `x`
  - Câu f: Tìm phần tử dương nhỏ nhất

## Cách chạy
```
dotnet run --project Buoi02_DanhSach
```

## Kết quả chạy
```
=== CHẠY BÀI 1 ===
Nhập số phần tử n:4
Nhập phần tử a[0]:10
Nhập phần tử a[1]:20
Nhập phần tử a[2]:30
Nhập phần tử a[3]:40
Danh sách vừa nhập:
10 20 30 40
Nhập giá trị x cần chèn: 99
Nhập vị trí k cần chèn (0 <= k <= 4): 2
Danh sách sau khi chèn: 10 20 99 30 40

=== CHẠY BÀI 2 ===
Nhập số lượng nhân viên: 3
Nhập thông tin nhân viên thứ 1:
Mã nhân viên: NV01
Họ và tên: An
Năm sinh: 2000
Phòng ban: IT
Lương cơ bản: 5000000
Thưởng: 1500000
Nhập thông tin nhân viên thứ 2:
Mã nhân viên: NV03
Họ và tên: Binh
Năm sinh: 1999
Phòng ban: IT
Lương cơ bản: 4000000
Thưởng: 800000
Nhập thông tin nhân viên thứ 3:
Mã nhân viên: NV02
Họ và tên: Cuong
Năm sinh: 2001
Phòng ban: HC
Lương cơ bản: 6000000
Thưởng: 1200000
a. Tổng thực lĩnh tháng của tất cả nhân viên: 18500000
b. Danh sách nhân viên có lương cơ bản thấp nhất (4000000):
NV03 - Binh - IT - Lương CB: 4000000
c. Số lượng nhân viên có thưởng >= 1200000: 2
d. Danh sách nhân viên sau khi sắp xếp:
NV02 - Cuong - Phòng: HC - Thực lĩnh: 7200000
NV03 - Binh - Phòng: IT - Thực lĩnh: 4800000
NV01 - An - Phòng: IT - Thực lĩnh: 6500000
e. Danh sách nhân viên sau khi cập nhật tăng 5% lương:
NV02 - Cuong - Năm sinh: 2001 - Phòng: HC - Lương CB mới: 6300000 - Thưởng: 1200000
NV03 - Binh - Năm sinh: 1999 - Phòng: IT - Lương CB mới: 4200000 - Thưởng: 800000
NV01 - An - Năm sinh: 2000 - Phòng: IT - Lương CB mới: 5250000 - Thưởng: 1500000

=== CHẠY BÀI 3 ===
Nhập cấp n của ma trận vuông (0 <= n < 100): 3
a[0,0] = 1
a[0,1] = -2
a[0,2] = 3
a[1,0] = 4
a[1,1] = 5
a[1,2] = 6
a[2,0] = 7
a[2,1] = 8
a[2,2] = 9
a. Tổng tất cả các phần tử của ma trận: 41
b. Giá trị dương nhỏ nhất của ma trận: 1
c. Tổng các phần tử trên đường chéo phụ: 15
d. Đường chéo chính tăng dần: True

=== CHẠY BÀI 4 ===
Nhập số lượng phần tử: 5
Nhập phần tử thứ 1: -4
Nhập phần tử thứ 2: 7
Nhập phần tử thứ 3: 2
Nhập phần tử thứ 4: 7
Nhập phần tử thứ 5: 9
Nhập giá trị x: 7
a. Số phần tử bằng 7: 2
b. Phần tử dương nhỏ nhất: 2
c. Danh sách sau khi xóa phần tử 7 đầu tiên: -4 2 7 9

=== CHẠY BÀI 5 ===
Nhập số phần tử của danh sách l: 6
Nhập phần tử thứ 1: -3
Nhập phần tử thứ 2: 0
Nhập phần tử thứ 3: 2
Nhập phần tử thứ 4: 5
Nhập phần tử thứ 5: 7
Nhập phần tử thứ 6: 5
a. Phần tử lớn nhất: 7
b. Tổng các phần tử: 16
c. Số lượng số nguyên tố: 4
d. Số âm: 1, Số dương: 4, Số bằng 0: 1
Nhập giá trị x cần đếm: 5
e. Số lượng phần tử bằng 5: 2
f. Phần tử dương nhỏ nhất: 2

Đã chạy xong cả 5 bài!

```
