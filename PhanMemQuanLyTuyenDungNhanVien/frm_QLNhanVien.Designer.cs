namespace PhanMemQuanLyTuyenDungNhanVien
{
    partial class frm_QLNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grb_TT = new System.Windows.Forms.GroupBox();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dgv_dsNhanVien = new System.Windows.Forms.DataGridView();
            this.grp_TD = new System.Windows.Forms.GroupBox();
            this.txt_mucLuong = new System.Windows.Forms.TextBox();
            this.txt_soLuong = new System.Windows.Forms.TextBox();
            this.txt_loaiVTTD = new System.Windows.Forms.TextBox();
            this.txt_tenVTTD = new System.Windows.Forms.TextBox();
            this.txt_maVTTD = new System.Windows.Forms.TextBox();
            this.date_DT = new System.Windows.Forms.DateTimePicker();
            this.date_BD = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_ycgt = new System.Windows.Forms.Label();
            this.cbb_gioiTinhYeuCau = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.grb_TT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsNhanVien)).BeginInit();
            this.grp_TD.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(112)))), ((int)(((byte)(253)))));
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(30, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // grb_TT
            // 
            this.grb_TT.Controls.Add(this.btn_lamMoi);
            this.grb_TT.Controls.Add(this.btn_luu);
            this.grb_TT.Controls.Add(this.btn_xoa);
            this.grb_TT.Controls.Add(this.btn_them);
            this.grb_TT.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_TT.Location = new System.Drawing.Point(1159, 514);
            this.grb_TT.Name = "grb_TT";
            this.grb_TT.Size = new System.Drawing.Size(183, 261);
            this.grb_TT.TabIndex = 14;
            this.grb_TT.TabStop = false;
            this.grb_TT.Text = "Thao Tác:";
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.ForeColor = System.Drawing.Color.Black;
            this.btn_lamMoi.Image = global::PhanMemQuanLyTuyenDungNhanVien.Properties.Resources.redo;
            this.btn_lamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lamMoi.Location = new System.Drawing.Point(23, 194);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_lamMoi.Size = new System.Drawing.Size(140, 42);
            this.btn_lamMoi.TabIndex = 2;
            this.btn_lamMoi.Text = "       LÀM MỚI";
            this.btn_lamMoi.UseVisualStyleBackColor = true;
            // 
            // btn_luu
            // 
            this.btn_luu.ForeColor = System.Drawing.Color.Black;
            this.btn_luu.Image = global::PhanMemQuanLyTuyenDungNhanVien.Properties.Resources.diskette;
            this.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luu.Location = new System.Drawing.Point(23, 141);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_luu.Size = new System.Drawing.Size(140, 42);
            this.btn_luu.TabIndex = 2;
            this.btn_luu.Text = "LƯU";
            this.btn_luu.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.Image = global::PhanMemQuanLyTuyenDungNhanVien.Properties.Resources.delete;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(23, 88);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_xoa.Size = new System.Drawing.Size(140, 42);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.Image = global::PhanMemQuanLyTuyenDungNhanVien.Properties.Resources.add_button;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(23, 35);
            this.btn_them.Name = "btn_them";
            this.btn_them.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_them.Size = new System.Drawing.Size(140, 42);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "THÊM";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // dgv_dsNhanVien
            // 
            this.dgv_dsNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_dsNhanVien.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_dsNhanVien.Location = new System.Drawing.Point(70, 514);
            this.dgv_dsNhanVien.Name = "dgv_dsNhanVien";
            this.dgv_dsNhanVien.RowHeadersWidth = 51;
            this.dgv_dsNhanVien.RowTemplate.Height = 24;
            this.dgv_dsNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dsNhanVien.Size = new System.Drawing.Size(1067, 261);
            this.dgv_dsNhanVien.TabIndex = 13;
            // 
            // grp_TD
            // 
            this.grp_TD.Controls.Add(this.textBox3);
            this.grp_TD.Controls.Add(this.textBox4);
            this.grp_TD.Controls.Add(this.textBox5);
            this.grp_TD.Controls.Add(this.dateTimePicker2);
            this.grp_TD.Controls.Add(this.comboBox1);
            this.grp_TD.Controls.Add(this.label3);
            this.grp_TD.Controls.Add(this.label4);
            this.grp_TD.Controls.Add(this.label7);
            this.grp_TD.Controls.Add(this.label10);
            this.grp_TD.Controls.Add(this.label12);
            this.grp_TD.Controls.Add(this.txt_mucLuong);
            this.grp_TD.Controls.Add(this.txt_soLuong);
            this.grp_TD.Controls.Add(this.txt_loaiVTTD);
            this.grp_TD.Controls.Add(this.txt_tenVTTD);
            this.grp_TD.Controls.Add(this.txt_maVTTD);
            this.grp_TD.Controls.Add(this.date_DT);
            this.grp_TD.Controls.Add(this.date_BD);
            this.grp_TD.Controls.Add(this.cbb_gioiTinhYeuCau);
            this.grp_TD.Controls.Add(this.label18);
            this.grp_TD.Controls.Add(this.label17);
            this.grp_TD.Controls.Add(this.label16);
            this.grp_TD.Controls.Add(this.label15);
            this.grp_TD.Controls.Add(this.lbl_ycgt);
            this.grp_TD.Controls.Add(this.label9);
            this.grp_TD.Controls.Add(this.label8);
            this.grp_TD.Controls.Add(this.label2);
            this.grp_TD.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_TD.Location = new System.Drawing.Point(70, 42);
            this.grp_TD.Name = "grp_TD";
            this.grp_TD.Size = new System.Drawing.Size(1272, 453);
            this.grp_TD.TabIndex = 12;
            this.grp_TD.TabStop = false;
            // 
            // txt_mucLuong
            // 
            this.txt_mucLuong.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mucLuong.ForeColor = System.Drawing.Color.Black;
            this.txt_mucLuong.Location = new System.Drawing.Point(180, 348);
            this.txt_mucLuong.Name = "txt_mucLuong";
            this.txt_mucLuong.Size = new System.Drawing.Size(289, 25);
            this.txt_mucLuong.TabIndex = 26;
            // 
            // txt_soLuong
            // 
            this.txt_soLuong.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soLuong.ForeColor = System.Drawing.Color.Black;
            this.txt_soLuong.Location = new System.Drawing.Point(180, 297);
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.Size = new System.Drawing.Size(289, 25);
            this.txt_soLuong.TabIndex = 25;
            // 
            // txt_loaiVTTD
            // 
            this.txt_loaiVTTD.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loaiVTTD.ForeColor = System.Drawing.Color.Black;
            this.txt_loaiVTTD.Location = new System.Drawing.Point(180, 141);
            this.txt_loaiVTTD.Name = "txt_loaiVTTD";
            this.txt_loaiVTTD.Size = new System.Drawing.Size(289, 25);
            this.txt_loaiVTTD.TabIndex = 24;
            // 
            // txt_tenVTTD
            // 
            this.txt_tenVTTD.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenVTTD.ForeColor = System.Drawing.Color.Black;
            this.txt_tenVTTD.Location = new System.Drawing.Point(180, 93);
            this.txt_tenVTTD.Name = "txt_tenVTTD";
            this.txt_tenVTTD.Size = new System.Drawing.Size(289, 25);
            this.txt_tenVTTD.TabIndex = 23;
            // 
            // txt_maVTTD
            // 
            this.txt_maVTTD.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maVTTD.ForeColor = System.Drawing.Color.Black;
            this.txt_maVTTD.Location = new System.Drawing.Point(180, 42);
            this.txt_maVTTD.Name = "txt_maVTTD";
            this.txt_maVTTD.Size = new System.Drawing.Size(289, 25);
            this.txt_maVTTD.TabIndex = 22;
            // 
            // date_DT
            // 
            this.date_DT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_DT.Location = new System.Drawing.Point(180, 244);
            this.date_DT.Name = "date_DT";
            this.date_DT.Size = new System.Drawing.Size(289, 25);
            this.date_DT.TabIndex = 21;
            // 
            // date_BD
            // 
            this.date_BD.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_BD.Location = new System.Drawing.Point(180, 193);
            this.date_BD.Name = "date_BD";
            this.date_BD.Size = new System.Drawing.Size(289, 25);
            this.date_BD.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(25, 99);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 16);
            this.label18.TabIndex = 16;
            this.label18.Text = "Địa chỉ:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(25, 149);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 16);
            this.label17.TabIndex = 15;
            this.label17.Text = "Số điện thoại:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(25, 249);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 16);
            this.label16.TabIndex = 14;
            this.label16.Text = "Ngày vào làm:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(25, 299);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 16);
            this.label15.TabIndex = 13;
            this.label15.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(25, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Ngày sinh:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(25, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Vị trí:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên nhân viên:";
            // 
            // lbl_ycgt
            // 
            this.lbl_ycgt.AutoSize = true;
            this.lbl_ycgt.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ycgt.ForeColor = System.Drawing.Color.Black;
            this.lbl_ycgt.Location = new System.Drawing.Point(25, 399);
            this.lbl_ycgt.Name = "lbl_ycgt";
            this.lbl_ycgt.Size = new System.Drawing.Size(61, 16);
            this.lbl_ycgt.TabIndex = 8;
            this.lbl_ycgt.Text = "Giới tính:";
            // 
            // cbb_gioiTinhYeuCau
            // 
            this.cbb_gioiTinhYeuCau.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_gioiTinhYeuCau.ForeColor = System.Drawing.Color.Black;
            this.cbb_gioiTinhYeuCau.FormattingEnabled = true;
            this.cbb_gioiTinhYeuCau.Items.AddRange(new object[] {
            "Không yêu cầu",
            "Nam",
            "Nữ"});
            this.cbb_gioiTinhYeuCau.Location = new System.Drawing.Point(180, 398);
            this.cbb_gioiTinhYeuCau.Name = "cbb_gioiTinhYeuCau";
            this.cbb_gioiTinhYeuCau.Size = new System.Drawing.Size(289, 25);
            this.cbb_gioiTinhYeuCau.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(791, 143);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(289, 25);
            this.textBox3.TabIndex = 40;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(791, 95);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(289, 25);
            this.textBox4.TabIndex = 39;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(791, 44);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(289, 25);
            this.textBox5.TabIndex = 38;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(791, 195);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(289, 25);
            this.dateTimePicker2.TabIndex = 36;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Không yêu cầu",
            "Nam",
            "Nữ"});
            this.comboBox1.Location = new System.Drawing.Point(791, 249);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(289, 25);
            this.comboBox1.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(636, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Mật khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(636, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Quyền truy cập:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(636, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Trạng thái:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(636, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Ngày tạo tài khoản:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(636, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Tài khoản nhân viên:";
            // 
            // frm_QLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 801);
            this.Controls.Add(this.grb_TT);
            this.Controls.Add(this.dgv_dsNhanVien);
            this.Controls.Add(this.grp_TD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_QLNhanVien";
            this.Text = "frm_QLNhanVien";
            this.Load += new System.EventHandler(this.frm_QLNhanVien_Load);
            this.grb_TT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsNhanVien)).EndInit();
            this.grp_TD.ResumeLayout(false);
            this.grp_TD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grb_TT;
        private System.Windows.Forms.Button btn_lamMoi;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgv_dsNhanVien;
        private System.Windows.Forms.GroupBox grp_TD;
        private System.Windows.Forms.TextBox txt_mucLuong;
        private System.Windows.Forms.TextBox txt_soLuong;
        private System.Windows.Forms.TextBox txt_loaiVTTD;
        private System.Windows.Forms.TextBox txt_tenVTTD;
        private System.Windows.Forms.TextBox txt_maVTTD;
        private System.Windows.Forms.DateTimePicker date_DT;
        private System.Windows.Forms.DateTimePicker date_BD;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbb_gioiTinhYeuCau;
        private System.Windows.Forms.Label lbl_ycgt;
    }
}