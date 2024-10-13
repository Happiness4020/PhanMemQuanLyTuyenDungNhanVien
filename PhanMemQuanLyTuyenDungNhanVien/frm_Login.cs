using MongoDB.Driver.Core.Configuration;
using MongoDB.Driver;
using PhanMemQuanLyTuyenDungNhanVien;
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
    public partial class frm_Login : Form
    {

        // Thay đổi connectionString cho phù hợp với MongoDB của bạn
        private readonly string connectionString = "mongodb://localhost:27017";
        private readonly string databaseName = "QLTuyenDungNhanVien"; // Tên cơ sở dữ liệu
        //private readonly string collectionName = "NhanVien"; // Tên collection chứa thông tin người dùng
        public frm_Login()
        {
            InitializeComponent();
        }

        // Thông báo cho người dùng khi đóng chương trình
        private void frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc chắn muốn đóng chương trình?", "Đóng chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        // Đóng chương trình
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // kiểm tra thông tin đăng nhập 
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text.Length == 0 || textBoxPassword.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // Kết nối tới MongoDB
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            var collection = database.GetCollection<NhanVien>("NhanVien");

            // Tìm kiếm nhân viên dựa trên username và password
            var nhanVien = collection.AsQueryable().FirstOrDefault(nv => nv.TaiKhoan.Username == username && nv.TaiKhoan.MatKhau == password);

            if (nhanVien != null)
            {
                // Nếu tài khoản đúng, kiểm tra quyền truy cập
                frmDashBoard dashboard = new frmDashBoard();
                frm_QLNhanVien QLNhanVien = new frm_QLNhanVien();


                if (nhanVien.TaiKhoan.QuyenTruyCap == "quanTriVien")
                {
                    dashboard.qlungvien = true;
                    dashboard.qltuyendung = true;
                    dashboard.qlphuchoi = true;
                    dashboard.qlnhanvien = true;
                }
                else if (nhanVien.TaiKhoan.QuyenTruyCap == "nhanVien")
                {
                    dashboard.qlungvien = false;
                    dashboard.qltuyendung = false;
                    dashboard.qlphuchoi = false;
                    dashboard.qlnhanvien = false;
                }

                this.Hide();
                dashboard.ShowDialog();
            }
            else
            {
                // Nếu tài khoản không đúng, hiển thị thông báo lỗi
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // Phương thức để thiết lập chế độ quản trị
        public void SetAdminMode(bool isAdmin)
        {
            // Lấy thể hiện hiện tại của frm_QLNhanVien
            frm_QLNhanVien QLNhanVien = new frm_QLNhanVien(); // hoặc bạn có thể làm theo cách khác để có được thể hiện hiện tại

            // Nếu là quản trị viên, bật tất cả các nút
            if (isAdmin)
            {
                QLNhanVien.btn_them.Enabled = true;
                QLNhanVien.btn_luu.Enabled = true;
                QLNhanVien.btn_xoa.Enabled = true;
                QLNhanVien.btn_lamMoi.Enabled = true;
            }
            else
            {
                // Nếu không phải là quản trị viên, tắt tất cả các nút
                QLNhanVien.grb_TT.Enabled = false;
                QLNhanVien.btn_them.Visible = false;
                QLNhanVien.btn_luu.Visible = false;
                QLNhanVien.btn_xoa.Visible = false;
                QLNhanVien.btn_lamMoi.Visible = false;
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_DangKy fr = new frm_DangKy();
            this.Hide();
            fr.ShowDialog();
        }
    }
}
