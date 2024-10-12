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
        }
    }




}
