
namespace PhanMemQLTV
{
    partial class frmQLNhanVien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLNhanVien));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNDTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radTenNV = new System.Windows.Forms.RadioButton();
            this.radMaNV = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboLoaiNV = new System.Windows.Forms.ComboBox();
            this.lblLoaiNhanVien = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblNhapGioiTinh = new System.Windows.Forms.Label();
            this.lblNhapDiaChi = new System.Windows.Forms.Label();
            this.lblNhapSDT = new System.Windows.Forms.Label();
            this.lblNhapNgaySinh = new System.Windows.Forms.Label();
            this.lblNhapTenDG = new System.Windows.Forms.Label();
            this.dtmNgaySinhNV = new System.Windows.Forms.DateTimePicker();
            this.cboGioiTinhNV = new System.Windows.Forms.ComboBox();
            this.txtDiaChiNV = new System.Windows.Forms.TextBox();
            this.txtSoDTNV = new System.Windows.Forms.TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDSNhanVien = new System.Windows.Forms.DataGridView();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDienThoaiNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChiNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errTenNV = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDC = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSDT = new System.Windows.Forms.ErrorProvider(this.components);
            this.errGT = new System.Windows.Forms.ErrorProvider(this.components);
            this.errLoaiNV = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoaDSNV = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errGT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLoaiNV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(58, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1182, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm nhân viên:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtNDTimKiem);
            this.groupBox3.Location = new System.Drawing.Point(587, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(561, 72);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập thông tin cần tìm kiếm:";
            // 
            // txtNDTimKiem
            // 
            this.txtNDTimKiem.Location = new System.Drawing.Point(6, 26);
            this.txtNDTimKiem.Name = "txtNDTimKiem";
            this.txtNDTimKiem.Size = new System.Drawing.Size(538, 30);
            this.txtNDTimKiem.TabIndex = 0;
            this.txtNDTimKiem.TextChanged += new System.EventHandler(this.txtNDTimKiem_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radTenNV);
            this.groupBox2.Controls.Add(this.radMaNV);
            this.groupBox2.Location = new System.Drawing.Point(211, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 72);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm theo:";
            // 
            // radTenNV
            // 
            this.radTenNV.AutoSize = true;
            this.radTenNV.Location = new System.Drawing.Point(160, 26);
            this.radTenNV.Name = "radTenNV";
            this.radTenNV.Size = new System.Drawing.Size(97, 26);
            this.radTenNV.TabIndex = 2;
            this.radTenNV.TabStop = true;
            this.radTenNV.Text = "Tên NV";
            this.radTenNV.UseVisualStyleBackColor = true;
            // 
            // radMaNV
            // 
            this.radMaNV.AutoSize = true;
            this.radMaNV.Location = new System.Drawing.Point(61, 25);
            this.radMaNV.Name = "radMaNV";
            this.radMaNV.Size = new System.Drawing.Size(93, 26);
            this.radMaNV.TabIndex = 1;
            this.radMaNV.TabStop = true;
            this.radMaNV.Text = "Mã NV";
            this.radMaNV.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.cboLoaiNV);
            this.groupBox4.Controls.Add(this.lblLoaiNhanVien);
            this.groupBox4.Controls.Add(this.txtGhiChu);
            this.groupBox4.Controls.Add(this.lblGhiChu);
            this.groupBox4.Controls.Add(this.lblNhapGioiTinh);
            this.groupBox4.Controls.Add(this.lblNhapDiaChi);
            this.groupBox4.Controls.Add(this.lblNhapSDT);
            this.groupBox4.Controls.Add(this.lblNhapNgaySinh);
            this.groupBox4.Controls.Add(this.lblNhapTenDG);
            this.groupBox4.Controls.Add(this.dtmNgaySinhNV);
            this.groupBox4.Controls.Add(this.cboGioiTinhNV);
            this.groupBox4.Controls.Add(this.txtDiaChiNV);
            this.groupBox4.Controls.Add(this.txtSoDTNV);
            this.groupBox4.Controls.Add(this.lblSoDienThoai);
            this.groupBox4.Controls.Add(this.lblDiaChi);
            this.groupBox4.Controls.Add(this.lblGioiTinh);
            this.groupBox4.Controls.Add(this.lblNgaySinh);
            this.groupBox4.Controls.Add(this.txtTenNV);
            this.groupBox4.Controls.Add(this.lblTenNhanVien);
            this.groupBox4.Controls.Add(this.txtMaNV);
            this.groupBox4.Controls.Add(this.lblMaNhanVien);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(58, 128);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1182, 201);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin nhân viên:";
            // 
            // cboLoaiNV
            // 
            this.cboLoaiNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLoaiNV.FormattingEnabled = true;
            this.cboLoaiNV.Items.AddRange(new object[] {
            "Sinh viên",
            "Giáo viên",
            "Khách",
            "Ngôi sao",
            "Độc đoán",
            "Nhanh nhạy",
            "Khách",
            "Bình thường"});
            this.cboLoaiNV.Location = new System.Drawing.Point(785, 107);
            this.cboLoaiNV.Name = "cboLoaiNV";
            this.cboLoaiNV.Size = new System.Drawing.Size(255, 30);
            this.cboLoaiNV.TabIndex = 6;
            // 
            // lblLoaiNhanVien
            // 
            this.lblLoaiNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoaiNhanVien.AutoSize = true;
            this.lblLoaiNhanVien.Location = new System.Drawing.Point(653, 112);
            this.lblLoaiNhanVien.Name = "lblLoaiNhanVien";
            this.lblLoaiNhanVien.Size = new System.Drawing.Size(83, 22);
            this.lblLoaiNhanVien.TabIndex = 38;
            this.lblLoaiNhanVien.Text = "Loại NV:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChu.Location = new System.Drawing.Point(785, 152);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(255, 30);
            this.txtGhiChu.TabIndex = 7;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(653, 156);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(78, 22);
            this.lblGhiChu.TabIndex = 36;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // lblNhapGioiTinh
            // 
            this.lblNhapGioiTinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNhapGioiTinh.AutoSize = true;
            this.lblNhapGioiTinh.Location = new System.Drawing.Point(723, 25);
            this.lblNhapGioiTinh.Name = "lblNhapGioiTinh";
            this.lblNhapGioiTinh.Size = new System.Drawing.Size(0, 22);
            this.lblNhapGioiTinh.TabIndex = 30;
            // 
            // lblNhapDiaChi
            // 
            this.lblNhapDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNhapDiaChi.AutoSize = true;
            this.lblNhapDiaChi.Location = new System.Drawing.Point(781, 70);
            this.lblNhapDiaChi.Name = "lblNhapDiaChi";
            this.lblNhapDiaChi.Size = new System.Drawing.Size(0, 22);
            this.lblNhapDiaChi.TabIndex = 29;
            // 
            // lblNhapSDT
            // 
            this.lblNhapSDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNhapSDT.AutoSize = true;
            this.lblNhapSDT.Location = new System.Drawing.Point(781, 120);
            this.lblNhapSDT.Name = "lblNhapSDT";
            this.lblNhapSDT.Size = new System.Drawing.Size(0, 22);
            this.lblNhapSDT.TabIndex = 28;
            // 
            // lblNhapNgaySinh
            // 
            this.lblNhapNgaySinh.AutoSize = true;
            this.lblNhapNgaySinh.Location = new System.Drawing.Point(276, 109);
            this.lblNhapNgaySinh.Name = "lblNhapNgaySinh";
            this.lblNhapNgaySinh.Size = new System.Drawing.Size(0, 22);
            this.lblNhapNgaySinh.TabIndex = 31;
            // 
            // lblNhapTenDG
            // 
            this.lblNhapTenDG.AutoSize = true;
            this.lblNhapTenDG.Location = new System.Drawing.Point(276, 72);
            this.lblNhapTenDG.Name = "lblNhapTenDG";
            this.lblNhapTenDG.Size = new System.Drawing.Size(0, 22);
            this.lblNhapTenDG.TabIndex = 27;
            // 
            // dtmNgaySinhNV
            // 
            this.dtmNgaySinhNV.CustomFormat = "dd/MM/yyyy";
            this.dtmNgaySinhNV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgaySinhNV.Location = new System.Drawing.Point(288, 106);
            this.dtmNgaySinhNV.Name = "dtmNgaySinhNV";
            this.dtmNgaySinhNV.Size = new System.Drawing.Size(257, 30);
            this.dtmNgaySinhNV.TabIndex = 2;
            // 
            // cboGioiTinhNV
            // 
            this.cboGioiTinhNV.FormattingEnabled = true;
            this.cboGioiTinhNV.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinhNV.Location = new System.Drawing.Point(288, 152);
            this.cboGioiTinhNV.Name = "cboGioiTinhNV";
            this.cboGioiTinhNV.Size = new System.Drawing.Size(257, 30);
            this.cboGioiTinhNV.TabIndex = 3;
            // 
            // txtDiaChiNV
            // 
            this.txtDiaChiNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChiNV.Location = new System.Drawing.Point(785, 26);
            this.txtDiaChiNV.Name = "txtDiaChiNV";
            this.txtDiaChiNV.Size = new System.Drawing.Size(255, 30);
            this.txtDiaChiNV.TabIndex = 4;
            // 
            // txtSoDTNV
            // 
            this.txtSoDTNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoDTNV.Location = new System.Drawing.Point(785, 68);
            this.txtSoDTNV.Name = "txtSoDTNV";
            this.txtSoDTNV.Size = new System.Drawing.Size(255, 30);
            this.txtSoDTNV.TabIndex = 5;
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Location = new System.Drawing.Point(653, 71);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(120, 22);
            this.lblSoDienThoai.TabIndex = 20;
            this.lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(653, 29);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(84, 22);
            this.lblDiaChi.TabIndex = 19;
            this.lblDiaChi.Text = "Địa chỉ : ";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(148, 156);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(92, 22);
            this.lblGioiTinh.TabIndex = 18;
            this.lblGioiTinh.Text = "Giới tính :";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(148, 112);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(94, 22);
            this.lblNgaySinh.TabIndex = 17;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(288, 65);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(257, 30);
            this.txtTenNV.TabIndex = 1;
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Location = new System.Drawing.Point(148, 68);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(131, 22);
            this.lblTenNhanVien.TabIndex = 16;
            this.lblTenNhanVien.Text = "Tên nhân viên :";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(288, 25);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(257, 30);
            this.txtMaNV.TabIndex = 0;
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Location = new System.Drawing.Point(148, 27);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(127, 22);
            this.lblMaNhanVien.TabIndex = 15;
            this.lblMaNhanVien.Text = "Mã nhân viên :";
            this.lblMaNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox5.Controls.Add(this.dataGridViewDSNhanVien);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(58, 411);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1182, 348);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách nhân viên:";
            // 
            // dataGridViewDSNhanVien
            // 
            this.dataGridViewDSNhanVien.AllowUserToAddRows = false;
            this.dataGridViewDSNhanVien.AllowUserToDeleteRows = false;
            this.dataGridViewDSNhanVien.AllowUserToResizeRows = false;
            this.dataGridViewDSNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDSNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDSNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNV,
            this.colTenNV,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colSoDienThoaiNV,
            this.colDiaChiNV,
            this.colLoaiNV,
            this.colGhiChu});
            this.dataGridViewDSNhanVien.Location = new System.Drawing.Point(7, 26);
            this.dataGridViewDSNhanVien.Name = "dataGridViewDSNhanVien";
            this.dataGridViewDSNhanVien.ReadOnly = true;
            this.dataGridViewDSNhanVien.RowHeadersWidth = 62;
            this.dataGridViewDSNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDSNhanVien.Size = new System.Drawing.Size(1157, 307);
            this.dataGridViewDSNhanVien.TabIndex = 3;
            this.dataGridViewDSNhanVien.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSNhanVien_RowEnter);
            // 
            // colMaNV
            // 
            this.colMaNV.DataPropertyName = "MaNV";
            this.colMaNV.HeaderText = "Mã NV";
            this.colMaNV.MinimumWidth = 8;
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.ReadOnly = true;
            this.colMaNV.Width = 50;
            // 
            // colTenNV
            // 
            this.colTenNV.DataPropertyName = "TenNV";
            this.colTenNV.HeaderText = "Tên NV";
            this.colTenNV.MinimumWidth = 8;
            this.colTenNV.Name = "colTenNV";
            this.colTenNV.ReadOnly = true;
            this.colTenNV.Width = 140;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DataPropertyName = "GioiTinhNV";
            this.colGioiTinh.HeaderText = "Giới tính";
            this.colGioiTinh.MinimumWidth = 8;
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.ReadOnly = true;
            this.colGioiTinh.Width = 70;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "NgaySinhNV";
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.MinimumWidth = 8;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.ReadOnly = true;
            this.colNgaySinh.Width = 80;
            // 
            // colSoDienThoaiNV
            // 
            this.colSoDienThoaiNV.DataPropertyName = "SoDienThoaiNV";
            this.colSoDienThoaiNV.HeaderText = "Số ĐTNV";
            this.colSoDienThoaiNV.MinimumWidth = 8;
            this.colSoDienThoaiNV.Name = "colSoDienThoaiNV";
            this.colSoDienThoaiNV.ReadOnly = true;
            this.colSoDienThoaiNV.Width = 80;
            // 
            // colDiaChiNV
            // 
            this.colDiaChiNV.DataPropertyName = "DiaChiNV";
            this.colDiaChiNV.HeaderText = "Địa chỉ ";
            this.colDiaChiNV.MinimumWidth = 8;
            this.colDiaChiNV.Name = "colDiaChiNV";
            this.colDiaChiNV.ReadOnly = true;
            this.colDiaChiNV.Width = 80;
            // 
            // colLoaiNV
            // 
            this.colLoaiNV.DataPropertyName = "LoaiNV";
            this.colLoaiNV.HeaderText = "Loại NV";
            this.colLoaiNV.MinimumWidth = 8;
            this.colLoaiNV.Name = "colLoaiNV";
            this.colLoaiNV.ReadOnly = true;
            this.colLoaiNV.Width = 120;
            // 
            // colGhiChu
            // 
            this.colGhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGhiChu.DataPropertyName = "GhiChu";
            this.colGhiChu.HeaderText = "Ghi chú";
            this.colGhiChu.MinimumWidth = 8;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.ReadOnly = true;
            // 
            // errTenNV
            // 
            this.errTenNV.ContainerControl = this;
            // 
            // errDC
            // 
            this.errDC.ContainerControl = this;
            // 
            // errSDT
            // 
            this.errSDT.ContainerControl = this;
            // 
            // errGT
            // 
            this.errGT.ContainerControl = this;
            // 
            // errLoaiNV
            // 
            this.errLoaiNV.ContainerControl = this;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXuatExcel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.Image = global::PhanMemQLTV.Properties.Resources.Dakirby309_Simply_Styled_Microsoft_Excel_2013;
            this.btnXuatExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatExcel.Location = new System.Drawing.Point(760, 345);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(164, 60);
            this.btnXuatExcel.TabIndex = 14;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::PhanMemQLTV.Properties.Resources.Paomedia_Small_N_Flat_Floppy;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(620, 345);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(113, 60);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::PhanMemQLTV.Properties.Resources.Graphicloads_100_Flat_Close;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(489, 345);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 60);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::PhanMemQLTV.Properties.Resources.Custom_Icon_Design_Pretty_Office_7_Save_as;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(363, 345);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 60);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::PhanMemQLTV.Properties.Resources.onebit_35;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(1116, 345);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(107, 60);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::PhanMemQLTV.Properties.Resources.add32;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(223, 345);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 60);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::PhanMemQLTV.Properties.Resources.home_icon1;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(43, 345);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(159, 60);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Trang chủ";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoaDSNV
            // 
            this.btnXoaDSNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoaDSNV.Location = new System.Drawing.Point(954, 345);
            this.btnXoaDSNV.Name = "btnXoaDSNV";
            this.btnXoaDSNV.Size = new System.Drawing.Size(137, 60);
            this.btnXoaDSNV.TabIndex = 15;
            this.btnXoaDSNV.Text = "Xoá danh sách";
            this.btnXoaDSNV.UseVisualStyleBackColor = true;
            this.btnXoaDSNV.Click += new System.EventHandler(this.btnXoaDSNV_Click);
            // 
            // frmQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1335, 789);
            this.Controls.Add(this.btnXoaDSNV);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmQLNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQLNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errGT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLoaiNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radMaNV;
        private System.Windows.Forms.RadioButton radTenNV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNDTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cboLoaiNV;
        private System.Windows.Forms.Label lblLoaiNhanVien;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblNhapGioiTinh;
        private System.Windows.Forms.Label lblNhapDiaChi;
        private System.Windows.Forms.Label lblNhapSDT;
        private System.Windows.Forms.Label lblNhapNgaySinh;
        private System.Windows.Forms.Label lblNhapTenDG;
        private System.Windows.Forms.DateTimePicker dtmNgaySinhNV;
        private System.Windows.Forms.ComboBox cboGioiTinhNV;
        private System.Windows.Forms.TextBox txtDiaChiNV;
        private System.Windows.Forms.TextBox txtSoDTNV;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.DataGridView dataGridViewDSNhanVien;
        private System.Windows.Forms.ErrorProvider errTenNV;
        private System.Windows.Forms.ErrorProvider errDC;
        private System.Windows.Forms.ErrorProvider errSDT;
        private System.Windows.Forms.ErrorProvider errGT;
        private System.Windows.Forms.ErrorProvider errLoaiNV;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDienThoaiNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChiNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.Button btnXoaDSNV;
    }
}