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
using QuanLiNhaHang;

namespace PhanMemQuanLyTuyenDungNhanVien
{
    public partial class frm_DangKy : Form
    {

        // Thay đổi connectionString cho phù hợp với MongoDB của bạn
        private readonly string connectionString = "mongodb://localhost:27017";
        private readonly string databaseName = "QLTuyenDungNhanVien"; // Tên cơ sở dữ liệu
        private readonly string collectionName = "UserAccounts"; // Tên collection chứa thông tin người dùng
        public frm_DangKy()
        {
            InitializeComponent();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem các trường đã được điền đầy đủ chưa
            if (string.IsNullOrEmpty(txt_DangNhap.Text) ||
                string.IsNullOrEmpty(txt_MatKhau.Text) ||
                string.IsNullOrEmpty(txt_XacNhanMK.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra mật khẩu xác nhận
            if (txt_MatKhau.Text != txt_XacNhanMK.Text)
            {
                MessageBox.Show("Mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi hàm đăng ký
            RegisterUser(txt_DangNhap.Text, txt_MatKhau.Text);
        }

        private void RegisterUser(string username, string password)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            var collection = database.GetCollection<User>("UserAccounts");

            // Kiểm tra xem tên đăng nhập đã tồn tại chưa
            var existingUser = collection.Find(u => u.username == username).FirstOrDefault();
            if (existingUser != null)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          

            // Tạo đối tượng người dùng mới
            var newUser = new User
            {
                username = username,
                password = password
            };

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
