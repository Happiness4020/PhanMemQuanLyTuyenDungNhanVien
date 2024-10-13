using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyTuyenDungNhanVien
{
    public partial class frmQLUngVien : Form
    {
        KetNoi ketNoi = new KetNoi();

        BindingSource bindingSource = new BindingSource();
        List<UngVien> danhSachUngVien = new List<UngVien>();
        private string _jobName = "";
        public frmQLUngVien()
        {
            InitializeComponent();
        }

       

        private void frmQLUngVien_Load(object sender, EventArgs e)
        {
            List<string> danhSachTenVTTD = ketNoi.LayDanhSachTenVTTD();
            cbb_tenVTTD.DataSource = danhSachTenVTTD;
        }


        private void dgv_dsUngVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void setResponsiveControl(bool flag)
        {
            if (flag)
            {
                this.Width = 1539;
                dgv_dsUngVien.Width = 756;
                grp_UV.Width = 1150;
                txt_cacKyNang.Width = 618;
                txt_chiTietKyNang.Width = 618;
                txt_kinhNghiemLamViec.Width = 618;
                txt_cacDuAn.Width = 618;
                txt_mucTieuCaNhan.Width = 618;
            }
            else
            {
                this.Width = 1349;
                dgv_dsUngVien.Width = 566;
                grp_UV.Width = 959;
                txt_cacKyNang.Width = 428;
                txt_chiTietKyNang.Width = 428;
                txt_kinhNghiemLamViec.Width = 428;
                txt_cacDuAn.Width = 428;
                txt_mucTieuCaNhan.Width = 428;
            }
        }

        private void txt_maVTTD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ThemUV_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có mục nào được chọn trong combobox không
                if (cbb_tenVTTD.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn một vị trí tuyển dụng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy tên vị trí từ combobox
                string tenVTTD = cbb_tenVTTD.SelectedItem.ToString();

                // Tạo đối tượng ứng viên mới
                UngVien ungVienMoi = new UngVien
                {
                    soCCCD = txt_cccd.Text,
                    hoTen = txt_hoTenUV.Text,
                    ngaySinh = date_NS.Value,
                    diaChi = txt_diaChi.Text,
                    email = txt_email.Text,
                    soDienThoai = txt_soDienThoai.Text,
                    hocVan = txt_hocVan.Text,
                    chuyenNganh = txt_chuyenNganh.Text,
                    GPA = double.TryParse(txt_gpa.Text, out double gpa) ? gpa : 0,
                    cacKyNang = txt_cacKyNang.Text.Split(',').Select(k => k.Trim()).ToList(),
                    chiTietKyNang = txt_chiTietKyNang.Text,
                    kinhNghiemLamViec = txt_kinhNghiemLamViec.Text,
                    cacDuAn = txt_cacDuAn.Text,
                    mucTieuCaNhan = txt_mucTieuCaNhan.Text,
                    tenVTTD = tenVTTD // Lưu tên vị trí tuyển dụng
                };

                // Gọi phương thức thêm ứng viên
                ketNoi.ThemUngVien(ungVienMoi);

                // Thông báo thành công
                MessageBox.Show("Thêm ứng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Thông báo thất bại
                MessageBox.Show("Thêm ứng viên thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_SuaUV_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có mục nào được chọn trong combobox không
                if (cbb_tenVTTD.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn một ứng viên để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy tên vị trí từ combobox
                string tenVTTD = cbb_tenVTTD.SelectedItem.ToString();

                // Tạo đối tượng ứng viên với thông tin mới
                UngVien ungVienCapNhat = new UngVien
                {
                    soCCCD = txt_cccd.Text,
                    hoTen = txt_hoTenUV.Text,
                    ngaySinh = date_NS.Value,
                    diaChi = txt_diaChi.Text,
                    email = txt_email.Text,
                    soDienThoai = txt_soDienThoai.Text,
                    hocVan = txt_hocVan.Text,
                    chuyenNganh = txt_chuyenNganh.Text,
                    GPA = double.TryParse(txt_gpa.Text, out double gpa) ? gpa : 0,
                    cacKyNang = txt_cacKyNang.Text.Split(',').Select(k => k.Trim()).ToList(),
                    chiTietKyNang = txt_chiTietKyNang.Text,
                    kinhNghiemLamViec = txt_kinhNghiemLamViec.Text,
                    cacDuAn = txt_cacDuAn.Text,
                    mucTieuCaNhan = txt_mucTieuCaNhan.Text,
                    tenVTTD = tenVTTD // Lưu tên vị trí tuyển dụng
                };

                // Gọi phương thức sửa thông tin ứng viên
                ketNoi.SuaUngVien(ungVienCapNhat);

                // Thông báo thành công
                MessageBox.Show("Sửa thông tin ứng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Thông báo thất bại
                MessageBox.Show("Sửa thông tin ứng viên thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_cccd.Clear();
            txt_hoTenUV.Clear();
            date_NS.Value = DateTime.Now;
            txt_diaChi.Clear();
            txt_email.Clear();
            txt_soDienThoai.Clear();
            txt_hocVan.Clear();
            txt_chuyenNganh.Clear();
            txt_gpa.Clear();
            txt_cacKyNang.Clear();
            txt_chiTietKyNang.Clear();
            txt_kinhNghiemLamViec.Clear();
            txt_cacDuAn.Clear();
            txt_mucTieuCaNhan.Clear();
            cbb_tenVTTD.SelectedIndex = -1;
        }

        private void btn_xemTenVTTD_Click_1(object sender, EventArgs e)
        {
            string tenVTTD = cbb_tenVTTD.SelectedValue.ToString();
            _jobName = tenVTTD;
            List<UngVien> danhSachUngVien = ketNoi.FillThongTinUngVienTheoTenTTD(tenVTTD);
            if (danhSachUngVien != null && danhSachUngVien.Count > 0)
            {
                bindingSource.DataSource = danhSachUngVien; // Gán danh sách vào BindingSource
                dgv_dsUngVien.DataSource = bindingSource; // Gán BindingSource vào DataGridView
                this.dgv_dsUngVien.DefaultCellStyle.ForeColor = Color.Black;
            }
            else
            {
                MessageBox.Show("Không tìm thấy ứng viên.");
            }
        }

        private void dgv_dsUngVien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex + 1 < dgv_dsUngVien.Rows.Count)
            {
                UngVien selectedUngVien = dgv_dsUngVien.Rows[e.RowIndex].DataBoundItem as UngVien;
                if (selectedUngVien != null)
                {
                    txt_hoTenUV.Text = selectedUngVien.hoTen;
                    txt_cccd.Text = selectedUngVien.soCCCD;
                    if (selectedUngVien.ngaySinh != DateTime.MinValue)
                    {
                        date_NS.Value = selectedUngVien.ngaySinh;
                    }
                    else
                    {
                        date_NS.Value = DateTime.Now;
                    }

                    txt_soDienThoai.Text = selectedUngVien.soDienThoai;
                    txt_email.Text = selectedUngVien.email;
                    txt_chiTietKyNang.Text = selectedUngVien.chiTietKyNang;
                    txt_kinhNghiemLamViec.Text = selectedUngVien.kinhNghiemLamViec;
                    txt_cacKyNang.Text = string.Join(", ", selectedUngVien.cacKyNang);
                    txt_mucTieuCaNhan.Text = selectedUngVien.mucTieuCaNhan;
                    txt_diaChi.Text = selectedUngVien.diaChi;
                    txt_hocVan.Text = selectedUngVien.hocVan;
                    txt_chuyenNganh.Text = selectedUngVien.chuyenNganh;
                    txt_gpa.Text = selectedUngVien.GPA.ToString();
                    txt_cacDuAn.Text = selectedUngVien.cacDuAn;
                }
            }
        }

        private async void btn_henPhongVan_Click_1(object sender, EventArgs e)
        {
            if (txt_hoTenUV.Text.Trim() == String.Empty || txt_email.Text.Trim() == String.Empty)
                MessageBox.Show("Vui lòng chọn ứng viên trước khi thực hiện thao tác");
            else
            {
                DialogResult dgresult = MessageBox.Show("Bạn có muốn gửi thông báo cho ứng viên?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dgresult == DialogResult.Yes)
                {
                    const string ApiUrl = "http://127.0.0.1:8000/send-mail-notification";
                    const string CsrfToken = "elcrNeYB73hWdlM9Tti5ykqlSyfux3jE26E1Fhuy";

                    string email = txt_email.Text;
                    string fullName = txt_hoTenUV.Text;
                    string jobTitle = _jobName;

                    string apiUrlWithQueryString = $"{ApiUrl}?email={email}&hoten={fullName}&vitrituyendung={jobTitle}&CsrfToken={CsrfToken}";

                    using (HttpClient httpClient = new HttpClient())
                    {
                        try
                        {
                            HttpResponseMessage response = await httpClient.GetAsync(apiUrlWithQueryString);

                            if (response.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Gửi email thông báo cho ứng viên thành công!");
                            }
                            else
                            {
                                MessageBox.Show("Gửi email thông báo thất bại. Mã lỗi: " + response.StatusCode);
                            }
                        }
                        catch (HttpRequestException ex)
                        {
                            MessageBox.Show("Lỗi trong quá trình gửi yêu cầu: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void btn_xoaHoSo_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dgv_dsUngVien.SelectedRows.Count > 0)
            {
                DialogResult dgresult = MessageBox.Show("Bạn có muốn xóa ứng viên khỏi danh sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dgresult == DialogResult.Yes)
                {
                    string soCCCD = dgv_dsUngVien.SelectedRows[0].Cells["SoCCCD"].Value.ToString();

                    int result = ketNoi.xoaUngVien(soCCCD);

                    if (result == 1)
                    {
                        danhSachUngVien.Remove(danhSachUngVien.FirstOrDefault(u => u.soCCCD == soCCCD)); // Xóa ứng viên khỏi danh sách
                        bindingSource.DataSource = danhSachUngVien; // Cập nhật BindingSource
                        dgv_dsUngVien.Refresh(); // Làm mới DataGridView để hiển thị dữ liệu mới

                        MessageBox.Show("Xóa ứng viên thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Xóa ứng viên không thành công.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ứng viên cần xóa.");
            }
        }
    }
}
