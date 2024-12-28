# Dreaw
Draw together. Dream together
## Tính năng

- Vẽ chung thời gian thực.
- Đăng nhập/Đăng ký người dùng.
- Hỗ trợ nhiều phòng vẽ (Room).
- Chuyển đổi hình ảnh sang văn bản (OCR).

## Cách cài đặt

### Yêu cầu hệ thống:
- .NET 6.0 hoặc cao hơn.
- Python 3.12 (đúng phiên bản này)

# Hướng dẫn sử dụng dự án
Dự án này bao gồm hai server (Flask và ASP.NET Core) và yêu cầu cấu hình cơ sở dữ liệu trước khi khởi chạy. Làm theo các bước bên dưới để cài đặt và chạy dự án:

## Hướng dẫn

### 1. Clone repository về máy
Sao chép repository từ GitHub về máy cục bộ:
```bash
git clone https://github.com/Hac1es/NT106-DoAn.git
cd NT106-DoAn
```

### 2. Cài đặt dependencies cho Python
Dự án sử dụng các thư viện Python được liệt kê trong tệp requirements.txt. Chạy lệnh sau để cài đặt:
```bash
pip install -r requirements.txt
```

### 3. Tạo cơ sở dữ liệu
Dựa vào nội dung trong tệp Database.txt, sử dụng SSMS để tạo CSDL.

### 4. Sửa địa chỉ IP
Vào CoreApp, tìm các địa chỉ **192.168.45.212** và thay bằng IP hiện tại của máy bạn (hoặc **127.0.0.1**, nếu muốn nghịch:D)

### 5. Thứ tự khởi chạy dự án
#### Chạy tệp app.py trong thư mục để khởi động server Flask:
```bash
python app.py
```
#### Sử dụng Visual Studio hoặc CLI để chạy phần C#. Mình sử dụng Visual Studio:
- Chọn **Server** làm Startup Project
- Sau đó, mở bao nhiêu debug instance CoreApp tùy bạn (CoreApp nhé, DrawingData không chạy được)
- Lưu ý: Vì vài vấn đề với SkiaSharp, nên không mở cùng lúc nhiều instance CoreApp trong một cửa số VS được. Bạn cần mở nhiều cửa sổ VS để có thể thử tính năng vẽ chung (tốt nhất là nên thử với nhiều máy trong LAN)

### 6. Have Fun! 🎉
