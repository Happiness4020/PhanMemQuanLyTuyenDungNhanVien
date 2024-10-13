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
    public partial class frm_QLNhanVien : Form
    {
        KetNoi ketNoi = new KetNoi();
        DataTable dt;
        DateTime now = DateTime.Now;
        public frm_QLNhanVien()
        {
            InitializeComponent();
        }

        private void frm_QLNhanVien_Load(object sender, EventArgs e)
        {
            dt = ketNoi.LoadData_NhanVien();
            while (dgv_dsNhanVien.Columns.Count > 0)
            {
                dgv_dsNhanVien.Columns.RemoveAt(0);
            }
            dgv_dsNhanVien.DataSource = dt;
            dgv_dsNhanVien.Columns["_id"].Visible = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_dsNhanVien.SelectedRows.Count > 0)
            {
                string maNhanVien = dgv_dsNhanVien.SelectedRows[0].Cells["_id"].Value.ToString();

                bool ketQua = ketNoi.XoaNhanVien(maNhanVien);
                if (ketQua)
                {
                    MessageBox.Show("Xóa nhân viên thành công!");
                    CapNhatDataGridView();
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại!");
                }
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn lưu thay đổi?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                string maNhanVien = dgv_dsNhanVien.SelectedRows[0].Cells["_id"].Value.ToString();
                ketNoi.CapNhatNhanVien(
                    maNhanVien,
                    txtHoTenNV.Text,
                    dateNgaySinh.Value.ToShortDateString(),
                    cbxGioiTinh.Text,
                    txtDiaChi.Text,
                    txtSDT.Text,
                    txtEmail.Text,
                    txtViTri.Text,
                    dateNgayVaoLam.Value.ToShortDateString(),
                    txtTK.Text,
                    txtMK.Text,
                    cbxQuyen.Text,
                    cbxTrangThai.Text
                );

                CapNhatDataGridView();
            }
        }


        private void CapNhatDataGridView()
        {
            dgv_dsNhanVien.DataSource = ketNoi.LoadData_NhanVien();
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            CapNhatDataGridView();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txtHoTenNV.Text.Length == 0 || cbxGioiTinh.SelectedItem == null || txtDiaChi.Text.Length == 0 || txtSDT.Text.Length == 0 || txtEmail.Text.Length == 0 || txtViTri.Text.Length == 0 || txtTK.Text.Length == 0 || txtMK.Text.Length == 0 || cbxQuyen.SelectedItem == null || cbxTrangThai.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên!!!");
            }
            else
            {
                try
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc muốn thêm mới?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        string _created_at = DateTime.Now.ToString("dd/MM/yyyy");
                        string _ngayTaoTaiKhoan = DateTime.Now.ToString("dd/MM/yyyy");

                        //NhanVien nv = new NhanVien
                        //{
                        //    HoTen = txtHoTenNV.Text,
                        //    NgaySinh = dateNgaySinh.Value.ToString(),
                        //    GioiTinh = cbxGioiTinh.Text,
                        //    DiaChi = txtDiaChi.Text,
                        //    Sdt = txtSDT.Text,
                        //    Email = txtEmail.Text,
                        //    ViTri = txtViTri.Text,
                        //    NgayVaoLam = dateNgayVaoLam.Value.ToString(),
                        //    TaiKhoan = new TaiKhoan
                        //    {
                        //        Username = txtTK.Text,
                        //        MatKhau = txtMK.Text,
                        //        QuyenTruyCap = cbxQuyen.Text,
                        //        NgayTaoTaiKhoan = dateNgayTao.Value.ToString(),
                        //        TrangThai = cbxTrangThai.Text
                        //    }
                        //};

                        //var themThanhCong = ketNoi.ThemNhanVien(
                        //        nv.HoTen,
                        //        nv.NgaySinh.ToString("dd/MM/yyyy"),
                        //        nv.GioiTinh,
                        //        nv.DiaChi,
                        //        nv.Sdt,
                        //        nv.Email,
                        //        nv.ViTri,
                        //        nv.NgayVaoLam.ToString("dd/MM/yyyy"),
                        //        nv.TaiKhoan.Username,
                        //        nv.TaiKhoan.MatKhau,
                        //        nv.TaiKhoan.QuyenTruyCap,
                        //        nv.TaiKhoan.NgayTaoTaiKhoan.ToString("dd/MM/yyyy"),
                        //        nv.TaiKhoan.TrangThai
                        //);

                        var themThanhCong = ketNoi.ThemNhanVien(
                            txtHoTenNV.Text,
                            dateNgaySinh.Value.ToString("dd/MM/yyyy"),
                            cbxGioiTinh.Text,
                            txtDiaChi.Text,
                            txtSDT.Text,
                            txtEmail.Text,
                            txtViTri.Text,
                            dateNgayVaoLam.Value.ToString("dd/MM/yyyy"),
                            txtTK.Text,
                            txtMK.Text,
                            cbxQuyen.Text,
                            _ngayTaoTaiKhoan,
                            cbxTrangThai.Text
                        );

                        if (themThanhCong)
                        {
                            MessageBox.Show("Thêm nhân viên thành công");
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra khi thêm nhân viên!!!");
                        }

                        CapNhatDataGridView();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi thêm nhân viên: " + ex);
                }
            }
        }

        private void dgv_dsNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dgv_dsNhanVien.CurrentRow;

            // Kiểm tra và gán giá trị cho các trường
            txtHoTenNV.Text = currentRow.Cells[1].Value.ToString();

            // Xử lý ngày sinh
            DateTime ngaySinh;
            if (DateTime.TryParseExact(currentRow.Cells[2].Value.ToString(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out ngaySinh))
            {
                dateNgaySinh.Value = ngaySinh;
            }
            else
            {
                MessageBox.Show("Định dạng ngày sinh không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cbxGioiTinh.SelectedItem = currentRow.Cells[3].Value.ToString();
            txtDiaChi.Text = currentRow.Cells[4].Value.ToString();
            txtSDT.Text = currentRow.Cells[5].Value.ToString();
            txtEmail.Text = currentRow.Cells[6].Value.ToString();
            txtViTri.Text = currentRow.Cells[7].Value.ToString();

            // Xử lý ngày vào làm
            DateTime ngayVaoLam;
            if (DateTime.TryParseExact(currentRow.Cells[8].Value.ToString(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out ngayVaoLam))
            {
                dateNgayVaoLam.Value = ngayVaoLam;
            }
            else
            {
                MessageBox.Show("Định dạng ngày vào làm không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtTK.Text = currentRow.Cells[9].Value.ToString();
            txtMK.Text = currentRow.Cells[10].Value.ToString();
            cbxQuyen.SelectedItem = currentRow.Cells[11].Value.ToString();

            // Xử lý ngày tạo
            DateTime ngayTao;
            if (DateTime.TryParseExact(currentRow.Cells[12].Value.ToString(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out ngayTao))
            {
                dateNgayTao.Value = ngayTao;
            }
            else
            {
                MessageBox.Show("Định dạng ngày tạo không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cbxTrangThai.SelectedItem = currentRow.Cells[13].Value.ToString();
        }


       
    }




}
