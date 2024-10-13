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
    public partial class frmQLTuyenDung : Form
    {
        KetNoi ketNoi = new KetNoi();
        DataTable dt;
        DateTime now = DateTime.Now;
        public frmQLTuyenDung()
        {
            InitializeComponent();

            foreach (DataGridViewRow row in dgv_dsVTTD.Rows)
            {
                row.DefaultCellStyle.ForeColor = Color.Black;
            }


        }

        private void frmQLTuyenDung_Load(object sender, EventArgs e)
        {
            dt = ketNoi.LoadDataToDataTable();
            while (dgv_dsVTTD.Columns.Count > 0)
            {
                dgv_dsVTTD.Columns.RemoveAt(0);
            }
            dgv_dsVTTD.DataSource = dt;

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                string _updated_at = now.Year + "-" + now.Month + "-" + now.Day;
                bool xoaThanhCong = ketNoi.XoaViTri(txt_maVTTD.Text);

                if (xoaThanhCong)
                {
                    MessageBox.Show("Xóa thành công");
                    dgv_dsVTTD.Refresh();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }

                refreshDataGridView();
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn lưu thay đổi?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                List<string> kyNangYeuCau = txt_kyNangYeuCau.Text.Split(',').Select(item => item.Trim()).ToList();
                int t;
                if (cbb_trangThaiTuyen.Text == "Đang tuyển dụng")
                    t = 1;
                else
                    t = 0;

                string _updated_at = now.Year + "-" + now.Month + "-" + now.Day;
                ketNoi.CapNhatViTriTuyenDung(
                    txt_maVTTD.Text,
                    txt_tenVTTD.Text,
                    txt_loaiVTTD.Text,
                    date_BD.Value.ToShortDateString().ToString(),
                    date_DT.Value.ToShortDateString().ToString(),
                    int.Parse(txt_soLuong.Text),
                    txt_mucLuong.Text,
                    txt_diaDiem.Text,
                    txt_chiTietDiaDiem.Text,
                    cbb_hinhThucLamViec.Text,
                    cbb_gioiTinhYeuCau.Text,
                    int.Parse(txt_kinhNghiem.Text),
                    txt_moTaVTTD.Text,
                    kyNangYeuCau,
                    txt_yeuCauChiTiet.Text,
                    txt_quyenLoi.Text,
                    t,
                    _updated_at
                );

                refreshDataGridView();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thêm mới?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                int t;
                List<string> kyNangYeuCau = txt_kyNangYeuCau.Text.Split(',').Select(item => item.Trim()).ToList();
                if (cbb_trangThaiTuyen.Text == "Đang tuyển dụng")
                    t = 1;
                else
                    t = 0;

                string _created_at = now.Year + "-" + now.Month + "-" + now.Day;
                var themThanhCong = ketNoi.ThemViTriTuyenDung(txt_maVTTD.Text,
                    txt_tenVTTD.Text,
                    txt_loaiVTTD.Text,
                    date_BD.Value,
                    date_DT.Value,
                    int.Parse(txt_soLuong.Text),
                    txt_mucLuong.Text,
                    txt_diaDiem.Text,
                    txt_chiTietDiaDiem.Text,
                    cbb_hinhThucLamViec.Text,
                    cbb_gioiTinhYeuCau.Text,
                    int.Parse(txt_kinhNghiem.Text),
                    txt_moTaVTTD.Text,
                    kyNangYeuCau,
                    txt_yeuCauChiTiet.Text,
                    txt_quyenLoi.Text,
                    t,
                    _created_at, "", "");

                if (themThanhCong)
                {
                    MessageBox.Show("Thêm vị trí tuyển dụng thành công");
                }
                else
                {
                    MessageBox.Show("Thêm vị trí tuyển dụng thất bại");
                }
                refreshDataGridView();
            }
        }





        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            refreshDataGridView();
            ClearAllInputs();
        }

        private void refreshDataGridView()
        {
            dt.Rows.Clear();
            dgv_dsVTTD.DataSource = ketNoi.LoadDataToDataTable();
           
        }
        private void ClearAllInputs()
        {
            txt_maVTTD.Text = string.Empty;
            txt_tenVTTD.Text = string.Empty;
            txt_loaiVTTD.Text = string.Empty;
            txt_soLuong.Text = string.Empty;
            txt_mucLuong.Text = string.Empty;
            txt_diaDiem.Text = string.Empty;
            txt_chiTietDiaDiem.Text = string.Empty;
            txt_kinhNghiem.Text = string.Empty;
            txt_moTaVTTD.Text = string.Empty;
            txt_kyNangYeuCau.Text = string.Empty;
            txt_yeuCauChiTiet.Text = string.Empty;
            txt_quyenLoi.Text = string.Empty;

            cbb_hinhThucLamViec.SelectedIndex = -1;
            cbb_gioiTinhYeuCau.SelectedIndex = -1;
            cbb_trangThaiTuyen.SelectedIndex = -1;

            date_BD.Value = DateTime.Now;
            date_DT.Value = DateTime.Now;
        }



        private void dgv_dsVTTD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_dsVTTD.Rows.Count)
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgv_dsVTTD.Rows.Count)
                {
                   
                    DataGridViewRow selectedRow = dgv_dsVTTD.Rows[e.RowIndex];
                    txt_maVTTD.Text = selectedRow.Cells["maVTTD"].Value.ToString();
                    txt_tenVTTD.Text = selectedRow.Cells["tenVTTD"].Value.ToString();
                    txt_loaiVTTD.Text = selectedRow.Cells["loaiVTTD"].Value.ToString();
                    date_BD.Value = DateTime.Parse(selectedRow.Cells["ngayBatDauTD"].Value.ToString());
                    date_DT.Value = DateTime.Parse(selectedRow.Cells["ngayKetThucTD"].Value.ToString());
                    txt_soLuong.Text = selectedRow.Cells["soLuongTD"].Value.ToString();
                    txt_mucLuong.Text = selectedRow.Cells["mucLuong"].Value.ToString();
                    txt_diaDiem.Text = selectedRow.Cells["diaDiem"].Value.ToString();
                    txt_chiTietDiaDiem.Text = selectedRow.Cells["diaChiCuThe"].Value.ToString();
                    cbb_hinhThucLamViec.Text = selectedRow.Cells["hinhThucLamViec"].Value.ToString();
                    cbb_gioiTinhYeuCau.Text = selectedRow.Cells["gioiTinh"].Value.ToString();
                    txt_kinhNghiem.Text = selectedRow.Cells["kinhNghiemYeuCau"].Value.ToString();
                    txt_moTaVTTD.Text = selectedRow.Cells["moTaVTTD"].Value.ToString();
                    txt_kyNangYeuCau.Text= selectedRow.Cells["kyNangYeuCau"].Value.ToString();
                    txt_yeuCauChiTiet.Text =selectedRow.Cells["yeuCauChiTiet"].Value.ToString();
                    txt_quyenLoi.Text = selectedRow.Cells["quyenLoi"].Value.ToString();
                    cbb_trangThaiTuyen.Text = selectedRow.Cells["trangThaiVTTD"].Value.ToString();
                }
            }
        }

        public void setResponsiveControl(bool flag)
        {
            if (flag)
            {
                this.Width = 1539;
                grp_TD.Width = 1150;
                grb_TT.Location = new Point(1038, 475);
                dgv_dsVTTD.Width = 997;
                txt_kyNangYeuCau.Width = 625;
                txt_yeuCauChiTiet.Width = 625;
                txt_quyenLoi.Width = 625;
                txt_moTaVTTD.Width = 625;
                cbb_hinhThucLamViec.Width = cbb_hinhThucLamViec.Width + 90;
                cbb_gioiTinhYeuCau.Width = cbb_gioiTinhYeuCau.Width + 90;
                cbb_gioiTinhYeuCau.Location = new Point(892, 35);
                cbb_trangThaiTuyen.Width = cbb_trangThaiTuyen.Width + 90;
                cbb_trangThaiTuyen.Location = new Point(892, 75);
                lbl_ttt.Location = new Point(786, 77);
                lbl_ycgt.Location = new Point(786, 37);
                txt_kinhNghiem.Width = txt_kinhNghiem.Width + 90;
            }
            else
            {
                this.Width = 1349;
                grp_TD.Width = 959;
                grb_TT.Location = new Point(848, 475);
                dgv_dsVTTD.Width = 807;
                txt_kyNangYeuCau.Width = 435;
                txt_yeuCauChiTiet.Width = 435;
                txt_quyenLoi.Width = 435;
                txt_moTaVTTD.Width = 435;
                cbb_hinhThucLamViec.Width = cbb_hinhThucLamViec.Width - 90;
                cbb_gioiTinhYeuCau.Width = cbb_gioiTinhYeuCau.Width- 90;
                cbb_gioiTinhYeuCau.Location = new Point(792, 35);
                cbb_trangThaiTuyen.Width = cbb_trangThaiTuyen.Width - 90;
                cbb_trangThaiTuyen.Location = new Point(792, 75);
                lbl_ttt.Location = new Point(686, 77);
                lbl_ycgt.Location = new Point(686, 37);
                txt_kinhNghiem.Width = txt_kinhNghiem.Width -90;
            }
        }

        private void txt_loaiVTTD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_maVTTD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
