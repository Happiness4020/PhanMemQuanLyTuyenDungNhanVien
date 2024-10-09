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

namespace QuanLiNhaHang
{
    public partial class frm_Login : Form
    {

        // Thay đổi connectionString cho phù hợp với MongoDB của bạn
        private readonly string connectionString = "mongodb://localhost:27017";
        private readonly string databaseName = "QLTuyenDungNhanVien"; // Tên cơ sở dữ liệu
        private readonly string collectionName = "UserAccounts"; // Tên collection chứa thông tin người dùng
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
                MessageBox.Show("Vui lòng điền đầy đủ tên đăng nhập và mật khẩu!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // Kiểm tra thông tin đăng nhập từ MongoDB
            if (IsLoginValid(username, password))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmDashBoard mainForm = new frmDashBoard();
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Phương thức kiểm tra thông tin đăng nhập từ MongoDB
        private bool IsLoginValid(string username, string password)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            var collection = database.GetCollection<User>("UserAccounts"); // Đổi thành tên collection bạn sử dụng

            // Tìm người dùng trong MongoDB
            var user = collection.Find(u => u.username == username && u.password == password).FirstOrDefault();

            return user != null;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_DangKy fr = new frm_DangKy();
            this.Hide();
            fr.ShowDialog();
        }
    }
}
