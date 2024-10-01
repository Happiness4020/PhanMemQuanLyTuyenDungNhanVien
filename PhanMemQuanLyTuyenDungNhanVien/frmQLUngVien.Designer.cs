namespace PhanMemQuanLyTuyenDungNhanVien
{
    partial class frmQLUngVien
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
            this.dgv_dsUngVien = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_xemTenVTTD = new System.Windows.Forms.Button();
            this.btn_xemMaVTTD = new System.Windows.Forms.Button();
            this.cbb_tenVTTD = new System.Windows.Forms.ComboBox();
            this.txt_maVTTD = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_UV = new System.Windows.Forms.GroupBox();
            this.txt_mucTieuCaNhan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_cacDuAn = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_kinhNghiemLamViec = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_chiTietKyNang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cacKyNang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_soDienThoai = new System.Windows.Forms.TextBox();
            this.txt_gpa = new System.Windows.Forms.TextBox();
            this.txt_chuyenNganh = new System.Windows.Forms.TextBox();
            this.txt_hocVan = new System.Windows.Forms.TextBox();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.txt_ngaySinh = new System.Windows.Forms.TextBox();
            this.txt_cccd = new System.Windows.Forms.TextBox();
            this.txt_hoTenUV = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_xoaHoSo = new System.Windows.Forms.Button();
            this.btn_henPhongVan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsUngVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grp_UV.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_dsUngVien
            // 
            this.dgv_dsUngVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsUngVien.GridColor = System.Drawing.Color.IndianRed;
            this.dgv_dsUngVien.Location = new System.Drawing.Point(556, 61);
            this.dgv_dsUngVien.Name = "dgv_dsUngVien";
            this.dgv_dsUngVien.RowHeadersWidth = 62;
            this.dgv_dsUngVien.RowTemplate.Height = 24;
            this.dgv_dsUngVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dsUngVien.Size = new System.Drawing.Size(755, 226);
            this.dgv_dsUngVien.TabIndex = 17;
            this.dgv_dsUngVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsUngVien_CellClick);
            this.dgv_dsUngVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsUngVien_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_xemTenVTTD);
            this.groupBox1.Controls.Add(this.btn_xemMaVTTD);
            this.groupBox1.Controls.Add(this.cbb_tenVTTD);
            this.groupBox1.Controls.Add(this.txt_maVTTD);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 126);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vị Trí Ứng Tuyển";
            // 
            // btn_xemTenVTTD
            // 
            this.btn_xemTenVTTD.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xemTenVTTD.ForeColor = System.Drawing.Color.Black;
            this.btn_xemTenVTTD.Location = new System.Drawing.Point(395, 77);
            this.btn_xemTenVTTD.Name = "btn_xemTenVTTD";
            this.btn_xemTenVTTD.Size = new System.Drawing.Size(92, 30);
            this.btn_xemTenVTTD.TabIndex = 27;
            this.btn_xemTenVTTD.Text = "Xem";
            this.btn_xemTenVTTD.UseVisualStyleBackColor = true;
            this.btn_xemTenVTTD.Click += new System.EventHandler(this.btn_xemTenVTTD_Click);
            // 
            // btn_xemMaVTTD
            // 
            this.btn_xemMaVTTD.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xemMaVTTD.ForeColor = System.Drawing.Color.Black;
            this.btn_xemMaVTTD.Location = new System.Drawing.Point(395, 26);
            this.btn_xemMaVTTD.Name = "btn_xemMaVTTD";
            this.btn_xemMaVTTD.Size = new System.Drawing.Size(92, 30);
            this.btn_xemMaVTTD.TabIndex = 26;
            this.btn_xemMaVTTD.Text = "Xem";
            this.btn_xemMaVTTD.UseVisualStyleBackColor = true;
            this.btn_xemMaVTTD.Click += new System.EventHandler(this.btn_xemMaVTTD_Click);
            // 
            // cbb_tenVTTD
            // 
            this.cbb_tenVTTD.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_tenVTTD.ForeColor = System.Drawing.Color.Black;
            this.cbb_tenVTTD.FormattingEnabled = true;
            this.cbb_tenVTTD.Location = new System.Drawing.Point(178, 81);
            this.cbb_tenVTTD.Name = "cbb_tenVTTD";
            this.cbb_tenVTTD.Size = new System.Drawing.Size(199, 25);
            this.cbb_tenVTTD.TabIndex = 25;
            this.cbb_tenVTTD.Text = "--- Chọn ---";
            // 
            // txt_maVTTD
            // 
            this.txt_maVTTD.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maVTTD.ForeColor = System.Drawing.Color.Black;
            this.txt_maVTTD.Location = new System.Drawing.Point(178, 30);
            this.txt_maVTTD.Name = "txt_maVTTD";
            this.txt_maVTTD.Size = new System.Drawing.Size(199, 25);
            this.txt_maVTTD.TabIndex = 24;
            this.txt_maVTTD.TextChanged += new System.EventHandler(this.txt_maVTTD_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(19, 84);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 16);
            this.label18.TabIndex = 18;
            this.label18.Text = "Tên vị trí tuyển dụng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã vị trí tuyển dụng:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(112)))), ((int)(((byte)(253)))));
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 27);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "QUẢN LÝ ỨNG VIÊN";
            // 
            // grp_UV
            // 
            this.grp_UV.Controls.Add(this.txt_mucTieuCaNhan);
            this.grp_UV.Controls.Add(this.label12);
            this.grp_UV.Controls.Add(this.txt_cacDuAn);
            this.grp_UV.Controls.Add(this.label11);
            this.grp_UV.Controls.Add(this.txt_kinhNghiemLamViec);
            this.grp_UV.Controls.Add(this.label10);
            this.grp_UV.Controls.Add(this.txt_chiTietKyNang);
            this.grp_UV.Controls.Add(this.label6);
            this.grp_UV.Controls.Add(this.txt_cacKyNang);
            this.grp_UV.Controls.Add(this.label5);
            this.grp_UV.Controls.Add(this.txt_email);
            this.grp_UV.Controls.Add(this.txt_soDienThoai);
            this.grp_UV.Controls.Add(this.txt_gpa);
            this.grp_UV.Controls.Add(this.txt_chuyenNganh);
            this.grp_UV.Controls.Add(this.txt_hocVan);
            this.grp_UV.Controls.Add(this.txt_diaChi);
            this.grp_UV.Controls.Add(this.txt_ngaySinh);
            this.grp_UV.Controls.Add(this.txt_cccd);
            this.grp_UV.Controls.Add(this.txt_hoTenUV);
            this.grp_UV.Controls.Add(this.label14);
            this.grp_UV.Controls.Add(this.label8);
            this.grp_UV.Controls.Add(this.label7);
            this.grp_UV.Controls.Add(this.label3);
            this.grp_UV.Controls.Add(this.label17);
            this.grp_UV.Controls.Add(this.label16);
            this.grp_UV.Controls.Add(this.label15);
            this.grp_UV.Controls.Add(this.label9);
            this.grp_UV.Controls.Add(this.label4);
            this.grp_UV.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_UV.Location = new System.Drawing.Point(32, 306);
            this.grp_UV.Name = "grp_UV";
            this.grp_UV.Size = new System.Drawing.Size(1279, 540);
            this.grp_UV.TabIndex = 30;
            this.grp_UV.TabStop = false;
            this.grp_UV.Text = "Thông Tin Ứng Viên";
            // 
            // txt_mucTieuCaNhan
            // 
            this.txt_mucTieuCaNhan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mucTieuCaNhan.ForeColor = System.Drawing.Color.Black;
            this.txt_mucTieuCaNhan.Location = new System.Drawing.Point(688, 446);
            this.txt_mucTieuCaNhan.Multiline = true;
            this.txt_mucTieuCaNhan.Name = "txt_mucTieuCaNhan";
            this.txt_mucTieuCaNhan.Size = new System.Drawing.Size(568, 73);
            this.txt_mucTieuCaNhan.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(534, 450);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 16);
            this.label12.TabIndex = 46;
            this.label12.Text = "Mục tiêu cá nhân:";
            // 
            // txt_cacDuAn
            // 
            this.txt_cacDuAn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cacDuAn.ForeColor = System.Drawing.Color.Black;
            this.txt_cacDuAn.Location = new System.Drawing.Point(688, 344);
            this.txt_cacDuAn.Multiline = true;
            this.txt_cacDuAn.Name = "txt_cacDuAn";
            this.txt_cacDuAn.Size = new System.Drawing.Size(568, 73);
            this.txt_cacDuAn.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(534, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 44;
            this.label11.Text = "Các dự án:";
            // 
            // txt_kinhNghiemLamViec
            // 
            this.txt_kinhNghiemLamViec.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kinhNghiemLamViec.ForeColor = System.Drawing.Color.Black;
            this.txt_kinhNghiemLamViec.Location = new System.Drawing.Point(688, 242);
            this.txt_kinhNghiemLamViec.Multiline = true;
            this.txt_kinhNghiemLamViec.Name = "txt_kinhNghiemLamViec";
            this.txt_kinhNghiemLamViec.Size = new System.Drawing.Size(568, 73);
            this.txt_kinhNghiemLamViec.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(534, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 16);
            this.label10.TabIndex = 42;
            this.label10.Text = "Kinh nghiệm làm việc:";
            // 
            // txt_chiTietKyNang
            // 
            this.txt_chiTietKyNang.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chiTietKyNang.ForeColor = System.Drawing.Color.Black;
            this.txt_chiTietKyNang.Location = new System.Drawing.Point(688, 89);
            this.txt_chiTietKyNang.Multiline = true;
            this.txt_chiTietKyNang.Name = "txt_chiTietKyNang";
            this.txt_chiTietKyNang.Size = new System.Drawing.Size(568, 124);
            this.txt_chiTietKyNang.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(534, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Chi tiết kỹ năng:";
            // 
            // txt_cacKyNang
            // 
            this.txt_cacKyNang.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cacKyNang.ForeColor = System.Drawing.Color.Black;
            this.txt_cacKyNang.Location = new System.Drawing.Point(688, 38);
            this.txt_cacKyNang.Name = "txt_cacKyNang";
            this.txt_cacKyNang.Size = new System.Drawing.Size(568, 25);
            this.txt_cacKyNang.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(534, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Các kỹ năng:";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.Black;
            this.txt_email.Location = new System.Drawing.Point(149, 242);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(356, 25);
            this.txt_email.TabIndex = 37;
            // 
            // txt_soDienThoai
            // 
            this.txt_soDienThoai.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soDienThoai.ForeColor = System.Drawing.Color.Black;
            this.txt_soDienThoai.Location = new System.Drawing.Point(149, 191);
            this.txt_soDienThoai.Name = "txt_soDienThoai";
            this.txt_soDienThoai.Size = new System.Drawing.Size(356, 25);
            this.txt_soDienThoai.TabIndex = 36;
            // 
            // txt_gpa
            // 
            this.txt_gpa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gpa.ForeColor = System.Drawing.Color.Black;
            this.txt_gpa.Location = new System.Drawing.Point(149, 446);
            this.txt_gpa.Name = "txt_gpa";
            this.txt_gpa.Size = new System.Drawing.Size(356, 25);
            this.txt_gpa.TabIndex = 35;
            // 
            // txt_chuyenNganh
            // 
            this.txt_chuyenNganh.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chuyenNganh.ForeColor = System.Drawing.Color.Black;
            this.txt_chuyenNganh.Location = new System.Drawing.Point(149, 395);
            this.txt_chuyenNganh.Name = "txt_chuyenNganh";
            this.txt_chuyenNganh.Size = new System.Drawing.Size(356, 25);
            this.txt_chuyenNganh.TabIndex = 34;
            // 
            // txt_hocVan
            // 
            this.txt_hocVan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hocVan.ForeColor = System.Drawing.Color.Black;
            this.txt_hocVan.Location = new System.Drawing.Point(149, 344);
            this.txt_hocVan.Name = "txt_hocVan";
            this.txt_hocVan.Size = new System.Drawing.Size(356, 25);
            this.txt_hocVan.TabIndex = 33;
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diaChi.ForeColor = System.Drawing.Color.Black;
            this.txt_diaChi.Location = new System.Drawing.Point(149, 293);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(356, 25);
            this.txt_diaChi.TabIndex = 32;
            // 
            // txt_ngaySinh
            // 
            this.txt_ngaySinh.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngaySinh.ForeColor = System.Drawing.Color.Black;
            this.txt_ngaySinh.Location = new System.Drawing.Point(149, 137);
            this.txt_ngaySinh.Name = "txt_ngaySinh";
            this.txt_ngaySinh.Size = new System.Drawing.Size(356, 25);
            this.txt_ngaySinh.TabIndex = 31;
            // 
            // txt_cccd
            // 
            this.txt_cccd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cccd.ForeColor = System.Drawing.Color.Black;
            this.txt_cccd.Location = new System.Drawing.Point(149, 89);
            this.txt_cccd.Name = "txt_cccd";
            this.txt_cccd.Size = new System.Drawing.Size(356, 25);
            this.txt_cccd.TabIndex = 30;
            // 
            // txt_hoTenUV
            // 
            this.txt_hoTenUV.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hoTenUV.ForeColor = System.Drawing.Color.Black;
            this.txt_hoTenUV.Location = new System.Drawing.Point(149, 38);
            this.txt_hoTenUV.Name = "txt_hoTenUV";
            this.txt_hoTenUV.Size = new System.Drawing.Size(356, 25);
            this.txt_hoTenUV.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(19, 448);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 16);
            this.label14.TabIndex = 25;
            this.label14.Text = "GPA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(19, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Học vấn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(19, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Chuyên ngành:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Số CCCD/CMND:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(19, 143);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 16);
            this.label17.TabIndex = 21;
            this.label17.Text = "Ngày sinh:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(19, 245);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 16);
            this.label16.TabIndex = 20;
            this.label16.Text = "Email:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(19, 296);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 16);
            this.label15.TabIndex = 19;
            this.label15.Text = "Địa chỉ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(19, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(19, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Họ tên ứng viên:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_xoaHoSo);
            this.groupBox3.Controls.Add(this.btn_henPhongVan);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(32, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(505, 94);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thao Tác Hồ Sơ";
            // 
            // btn_xoaHoSo
            // 
            this.btn_xoaHoSo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_xoaHoSo.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoaHoSo.ForeColor = System.Drawing.Color.Black;
            this.btn_xoaHoSo.Location = new System.Drawing.Point(350, 32);
            this.btn_xoaHoSo.Name = "btn_xoaHoSo";
            this.btn_xoaHoSo.Size = new System.Drawing.Size(137, 42);
            this.btn_xoaHoSo.TabIndex = 31;
            this.btn_xoaHoSo.Text = "Xóa Hồ Sơ";
            this.btn_xoaHoSo.UseVisualStyleBackColor = false;
            this.btn_xoaHoSo.Click += new System.EventHandler(this.btn_xoaHoSo_Click);
            // 
            // btn_henPhongVan
            // 
            this.btn_henPhongVan.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_henPhongVan.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_henPhongVan.ForeColor = System.Drawing.Color.Black;
            this.btn_henPhongVan.Location = new System.Drawing.Point(22, 32);
            this.btn_henPhongVan.Name = "btn_henPhongVan";
            this.btn_henPhongVan.Size = new System.Drawing.Size(322, 42);
            this.btn_henPhongVan.TabIndex = 30;
            this.btn_henPhongVan.Text = "Hẹn Phỏng Vấn";
            this.btn_henPhongVan.UseVisualStyleBackColor = false;
            this.btn_henPhongVan.Click += new System.EventHandler(this.btn_henPhongVan_Click);
            // 
            // frmQLUngVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1339, 858);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grp_UV);
            this.Controls.Add(this.dgv_dsUngVien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLUngVien";
            this.Text = "frmQLUngVien";
            this.Load += new System.EventHandler(this.frmQLUngVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsUngVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_UV.ResumeLayout(false);
            this.grp_UV.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_dsUngVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_maVTTD;
        private System.Windows.Forms.ComboBox cbb_tenVTTD;
        private System.Windows.Forms.Button btn_xemTenVTTD;
        private System.Windows.Forms.Button btn_xemMaVTTD;
        private System.Windows.Forms.GroupBox grp_UV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_mucTieuCaNhan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_cacDuAn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_kinhNghiemLamViec;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_chiTietKyNang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cacKyNang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_soDienThoai;
        private System.Windows.Forms.TextBox txt_gpa;
        private System.Windows.Forms.TextBox txt_chuyenNganh;
        private System.Windows.Forms.TextBox txt_hocVan;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.TextBox txt_ngaySinh;
        private System.Windows.Forms.TextBox txt_cccd;
        private System.Windows.Forms.TextBox txt_hoTenUV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_xoaHoSo;
        private System.Windows.Forms.Button btn_henPhongVan;

    }
}