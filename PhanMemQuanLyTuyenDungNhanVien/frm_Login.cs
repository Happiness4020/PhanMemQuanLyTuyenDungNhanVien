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

            //if (MainClass.ValidUser(textBoxUsername.Text, textBoxPassword.Text, out int accountType))
            //{
            //    switch (accountType)
            //    {
            //        case 0: // User
            //            frm_GiaoDien_NhanVien fr = new frm_GiaoDien_NhanVien();
            //            this.Hide();
            //            fr.ShowDialog();
            //            this.Show();
            //            break;

            //        case 1: // Admin
            //            frm_Main form = new frm_Main();
            //            this.Hide();
            //            form.ShowDialog();
            //            this.Show();
            //            break;

            //        default:
            //            MessageBox.Show("Lỗi không xác định!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            break;
            //    }
            //}
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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
