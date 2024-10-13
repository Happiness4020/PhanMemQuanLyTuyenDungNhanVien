
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
    public partial class frmDashBoard : Form
    {

        frmQLUngVien _frmUngVien = new frmQLUngVien();
        frmQLTuyenDung _frmTuyenDung = new frmQLTuyenDung();
        public bool qlnhanvien = false;
        public bool qlungvien = false;
        public bool qltuyendung = false;
        public bool qlphuchoi = false;

        public frmDashBoard()
        {
            InitializeComponent();
            this.Width = 1260;
            btn_QLTuyenDung.FlatStyle = FlatStyle.Flat;
            btn_QLTuyenDung.FlatAppearance.BorderSize = 0;
            btn_QLUngVien.FlatStyle = FlatStyle.Flat;
            btn_QLUngVien.FlatAppearance.BorderSize = 0;
            btn_SaoLuuPhucHoi.FlatStyle = FlatStyle.Flat;
            btn_SaoLuuPhucHoi.FlatAppearance.BorderSize = 0;
            btn_ThongKe.FlatStyle = FlatStyle.Flat;
            btn_ThongKe.FlatAppearance.BorderSize = 0;
        }

        private void changBackgroundClick(Button _click)
        {
            Button[] _btn = new Button[] { btn_QLTuyenDung, btn_QLUngVien, btn_SaoLuuPhucHoi, btn_ThongKe, btnQLNV };
            foreach (Button i in _btn)
            {
                i.BackColor = Color.FromArgb(60, 179, 113);
            }
            _click.BackColor = Color.FromArgb(50, 179, 113);
        }

        private void icon_hide_Click(object sender, EventArgs e)
        {
            if(panel_navbar.Width != 0)
            {
                icon_hide.Location = new Point(3, -1);
                panel_navbar.Width = 0;
                panel_master.Location = new Point(49, -1);
                panel_master.Width = panel_master.Width + 262;
                pic_bgindex.Location = new Point(186, 188);

                //QLUngVien
                _frmUngVien.setResponsiveControl(true);
                _frmTuyenDung.setResponsiveControl(true);
            }
            else{
                icon_hide.Location = new Point(196, -1);
                panel_navbar.Width = 195;
                panel_master.Location = new Point(242, -1);
                panel_master.Width = panel_master.Width - 262;
                pic_bgindex.Location = new Point(106, 188);

                //QLUngVien
                _frmUngVien.setResponsiveControl(false);
                _frmTuyenDung.setResponsiveControl(false);
            }
        }

        
        private void btn_QLTuyenDung_Click_1(object sender, EventArgs e)
        {
            changBackgroundClick(btn_QLTuyenDung);
            _frmTuyenDung.TopLevel = false;
            panel_master.Controls.Clear();
            panel_master.Controls.Add(_frmTuyenDung);
            _frmTuyenDung.Show();

            if (qltuyendung == true)
            {
                _frmTuyenDung.grp_TD.Enabled = true;
                _frmTuyenDung.grb_TT.Enabled = true;
            }
            else
            {
                _frmTuyenDung.grp_TD.Enabled = false;
                _frmTuyenDung.grb_TT.Enabled = false;
            }
        }

        private void btn_QLUngVien_Click_1(object sender, EventArgs e)
        {
            changBackgroundClick(btn_QLUngVien);
            _frmUngVien.TopLevel = false;
            panel_master.Controls.Clear();
            panel_master.Controls.Add(_frmUngVien);
            _frmUngVien.Show();

            if (qlungvien == true)
            {
                _frmUngVien.grb_TTHS.Enabled = true;
                _frmUngVien.grp_UV.Enabled = true;
            }
            else
            {
                _frmUngVien.grb_TTHS.Enabled = false;
                _frmUngVien.grp_UV.Enabled = false;
            }
        }

        private void btn_ThongKe_Click_1(object sender, EventArgs e)
        {
            changBackgroundClick(btn_ThongKe);
            frmThongKe _frmThongKe = new frmThongKe();
            _frmThongKe.TopLevel = false;
            panel_master.Controls.Clear();
            panel_master.Controls.Add(_frmThongKe);
            _frmThongKe.Show();
        }

        private void btn_SaoLuuPhucHoi_Click_1(object sender, EventArgs e)
        {
            changBackgroundClick(btn_SaoLuuPhucHoi);
            frmSaoLuuPhucHoi _frmSaoLuuPhucHoi = new frmSaoLuuPhucHoi();
            _frmSaoLuuPhucHoi.TopLevel = false;
            panel_master.Controls.Clear();
            panel_master.Controls.Add(_frmSaoLuuPhucHoi);
            _frmSaoLuuPhucHoi.Show();

            if (qlungvien == true)
            {
                _frmSaoLuuPhucHoi.btn_Saoluu.Enabled = true;
                _frmSaoLuuPhucHoi.btn_Phuchoi.Enabled = true;
            }
            else
            {
                _frmSaoLuuPhucHoi.btn_Saoluu.Enabled = false;
                _frmSaoLuuPhucHoi.btn_Phuchoi.Enabled = false;
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frm_Login lg = new frm_Login();
            lg.Show();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            changBackgroundClick(btnQLNV);
            frm_QLNhanVien _frmQLNhanVien = new frm_QLNhanVien();
            _frmQLNhanVien.TopLevel = false;
            panel_master.Controls.Clear();
            panel_master.Controls.Add(_frmQLNhanVien);
            _frmQLNhanVien.Show();

            if (qlnhanvien == true)
            {
                _frmQLNhanVien.grb_TT.Enabled = true;
                _frmQLNhanVien.grp_NV.Enabled = true;
            }
            else
            {
                _frmQLNhanVien.grb_TT.Enabled = false;
                _frmQLNhanVien.grp_NV.Enabled = false;
            }

        }

        private void icon_hide_Click_1(object sender, EventArgs e)
        {
            if (panel_navbar.Width != 0)
            {
                icon_hide.Location = new Point(3, -1);
                panel_navbar.Width = 0;
                panel_master.Location = new Point(49, -1);
                panel_master.Width = panel_master.Width + 262;
                pic_bgindex.Location = new Point(186, 188);

                //QLUngVien
                _frmUngVien.setResponsiveControl(true);
                _frmTuyenDung.setResponsiveControl(true);
            }
            else
            {
                icon_hide.Location = new Point(196, -1);
                panel_navbar.Width = 195;
                panel_master.Location = new Point(242, -1);
                panel_master.Width = panel_master.Width - 262;
                pic_bgindex.Location = new Point(106, 188);

                //QLUngVien
                _frmUngVien.setResponsiveControl(false);
                _frmTuyenDung.setResponsiveControl(false);
            }
        }
    }
}
