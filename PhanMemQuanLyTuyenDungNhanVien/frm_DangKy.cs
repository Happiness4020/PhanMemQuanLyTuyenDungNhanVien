using MongoDB.Driver.Core.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyTuyenDungNhanVien
{
    public partial class frm_DangKy : Form
    {

        // Thay đổi connectionString cho phù hợp với MongoDB của bạn
        private readonly string connectionString = "mongodb://localhost:27017";
        private readonly string databaseName = "QLTuyenDungNhanVien"; // Tên cơ sở dữ liệu
       
        public frm_DangKy()
        {
            InitializeComponent();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem các trường đã được điền đầy đủ chưa
            if (string.IsNullOrEmpty(txt_DangNhap.Text) ||
                string.IsNullOrEmpty(txt_MatKhau.Text) ||
                string.IsNullOrEmpty(txt_XacNhanMK.Text) ||
                string.IsNullOrEmpty(txt_Email.Text) ||
                string.IsNullOrEmpty(txt_HoTen.Text) ||
                string.IsNullOrEmpty(txtDiaChi.Text) ||
                string.IsNullOrEmpty(txtSDT.Text) ||
                string.IsNullOrEmpty((string)cbxGioiTinh.SelectedItem) ||
                dateNgaySinh.Value == null ||
                dateNgayVaoLam.Value == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra mật khẩu xác nhận
            if (txt_MatKhau.Text != txt_XacNhanMK.Text)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra số điện thoại
            if (!KiemTraSoDienThoai(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập 10 chữ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra ngày tháng
            if (!KiemTraNgayThang(dateNgaySinh.Value, dateNgayVaoLam.Value))
            {
                MessageBox.Show("Ngày sinh hoặc ngày vào làm không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi hàm đăng ký
            RegisterUser(txt_DangNhap.Text, txt_MatKhau.Text, txt_Email.Text, txt_HoTen.Text, dateNgaySinh.Value.ToString("dd/MM/yyyy"),
                (string)cbxGioiTinh.SelectedItem, txtDiaChi.Text, txtSDT.Text, dateNgayVaoLam.Value.ToString("dd/MM/yyyy"));
        }

        private bool KiemTraSoDienThoai(string sdt)
        {
            // Kiểm tra xem số điện thoại có đủ 10 chữ số và chỉ chứa số
            return sdt.Length == 10 && long.TryParse(sdt, out _);
        }


        private bool KiemTraNgayThang(DateTime ngaySinh, DateTime ngayVaoLam)
        {
            // Kiểm tra nếu ngày sinh không phải là ngày trong tương lai
            if (ngaySinh > DateTime.Now)
            {
                return false;
            }

            // Kiểm tra nếu ngày vào làm không phải là ngày trong tương lai
            if (ngayVaoLam > DateTime.Now)
            {
                return false;
            }

            return true;
        }



        private void RegisterUser(string username, string password, string email, string fullname, string birthDate, string gender, string address, string phone, string Ngayvaolam)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            var collection = database.GetCollection<NhanVien>("NhanVien");

            // Kiểm tra xem tên đăng nhập đã tồn tại chưa
            var existingUser = collection.Find(u => u.TaiKhoan.Username == username).FirstOrDefault();
            if (existingUser != null)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng tài khoản mới
            var newAccount = new TaiKhoan
            (
                username: username,
                matkhau: password,
                quyentruycap: "nhanVien", // Có thể thay đổi tùy thuộc vào vai trò
                ngaytaotaikhoan: DateTime.Now.ToString("dd/MM/yyyy"),
                trangthai: "hoatDong"
            );

            // Tạo đối tượng người dùng mới
            var newUser = new NhanVien
            (
                hoten: fullname,
                ngaysinh: birthDate,
                gioitinh: gender,
                diachi: address,
                sdt: phone,
                email: email,
                vitri: "Nhân viên",
                ngayvaolam: Ngayvaolam, // Có thể thay đổi nếu bạn có ngày vào làm cụ thể
                taikhoan: newAccount
            );

            // Lưu người dùng vào MongoDB
            collection.InsertOne(newUser);
            MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Sau khi đăng ký thành công, có thể chuyển hướng về form đăng nhập hoặc đóng form đăng ký
            this.Close(); // Đóng form đăng ký
            frm_Login lg = new frm_Login();
            lg.Show();
        }


        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form đăng ký
            frm_Login lg = new frm_Login();
            lg.Show();
        }
    }
}
