
namespace PhanMemQLTV
{
    partial class frmQLNhaXuatBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLNhaXuatBan));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtNDTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radTenNXB = new System.Windows.Forms.RadioButton();
            this.radMaNXB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChiNXB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoFax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoDTNXB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNhapTenDG = new System.Windows.Forms.Label();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNXB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDSNhaXuatBan = new System.Windows.Forms.DataGridView();
            this.colMaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDienThoaiNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoFax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChiNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errTenNXB = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDCNXB = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSDTNXB = new System.Windows.Forms.ErrorProvider(this.components);
            this.errEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSoFax = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSNhaXuatBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenNXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDCNXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSDTNXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSoFax)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(83, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1247, 112);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm nhà xuất bản:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtNDTimKiem);
            this.groupBox5.Location = new System.Drawing.Point(560, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(639, 74);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Nhập thông tin cần tìm kiếm:";
            // 
            // txtNDTimKiem
            // 
            this.txtNDTimKiem.Location = new System.Drawing.Point(27, 24);
            this.txtNDTimKiem.Name = "txtNDTimKiem";
            this.txtNDTimKiem.Size = new System.Drawing.Size(588, 30);
            this.txtNDTimKiem.TabIndex = 0;
            this.txtNDTimKiem.TextChanged += new System.EventHandler(this.txtNDTimKiem_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radTenNXB);
            this.groupBox4.Controls.Add(this.radMaNXB);
            this.groupBox4.Location = new System.Drawing.Point(143, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(343, 74);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm theo";
            // 
            // radTenNXB
            // 
            this.radTenNXB.AutoSize = true;
            this.radTenNXB.Location = new System.Drawing.Point(188, 24);
            this.radTenNXB.Name = "radTenNXB";
            this.radTenNXB.Size = new System.Drawing.Size(111, 26);
            this.radTenNXB.TabIndex = 1;
            this.radTenNXB.TabStop = true;
            this.radTenNXB.Text = "Tên NXB";
            this.radTenNXB.UseVisualStyleBackColor = true;
            // 
            // radMaNXB
            // 
            this.radMaNXB.AutoSize = true;
            this.radMaNXB.Location = new System.Drawing.Point(63, 25);
            this.radMaNXB.Name = "radMaNXB";
            this.radMaNXB.Size = new System.Drawing.Size(107, 26);
            this.radMaNXB.TabIndex = 0;
            this.radMaNXB.TabStop = true;
            this.radMaNXB.Text = "Mã NXB";
            this.radMaNXB.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTrangThai);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDiaChiNXB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSoFax);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSoDTNXB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblNhapTenDG);
            this.groupBox1.Controls.Add(this.txtTenNXB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaNXB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(83, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1247, 208);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà xuất bản:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(806, 158);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(264, 30);
            this.txtGhiChu.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(701, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ghi chú:";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(806, 114);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(264, 30);
            this.txtTrangThai.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(701, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "Trạng thái:";
            // 
            // txtDiaChiNXB
            // 
            this.txtDiaChiNXB.Location = new System.Drawing.Point(806, 73);
            this.txtDiaChiNXB.Name = "txtDiaChiNXB";
            this.txtDiaChiNXB.Size = new System.Drawing.Size(264, 30);
            this.txtDiaChiNXB.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(701, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Địa chỉ:";
            // 
            // txtSoFax
            // 
            this.txtSoFax.Location = new System.Drawing.Point(806, 30);
            this.txtSoFax.Name = "txtSoFax";
            this.txtSoFax.Size = new System.Drawing.Size(264, 30);
            this.txtSoFax.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(701, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Số fax:";
            // 
            // txtSoDTNXB
            // 
            this.txtSoDTNXB.Location = new System.Drawing.Point(309, 157);
            this.txtSoDTNXB.Name = "txtSoDTNXB";
            this.txtSoDTNXB.Size = new System.Drawing.Size(284, 30);
            this.txtSoDTNXB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Số điện thoại:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(309, 111);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(284, 30);
            this.txtEmail.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(139, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 22);
            this.label9.TabIndex = 11;
            this.label9.Text = "Email:";
            // 
            // lblNhapTenDG
            // 
            this.lblNhapTenDG.AutoSize = true;
            this.lblNhapTenDG.Location = new System.Drawing.Point(301, 76);
            this.lblNhapTenDG.Name = "lblNhapTenDG";
            this.lblNhapTenDG.Size = new System.Drawing.Size(0, 22);
            this.lblNhapTenDG.TabIndex = 6;
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Location = new System.Drawing.Point(309, 69);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(284, 30);
            this.txtTenNXB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhà xuất bản :";
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.Location = new System.Drawing.Point(309, 26);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.Size = new System.Drawing.Size(284, 30);
            this.txtMaNXB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhà xuất bản :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridViewDSNhaXuatBan);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(83, 424);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1247, 311);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhà xuất bản:";
            // 
            // dataGridViewDSNhaXuatBan
            // 
            this.dataGridViewDSNhaXuatBan.AllowUserToAddRows = false;
            this.dataGridViewDSNhaXuatBan.AllowUserToDeleteRows = false;
            this.dataGridViewDSNhaXuatBan.AllowUserToResizeRows = false;
            this.dataGridViewDSNhaXuatBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDSNhaXuatBan.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDSNhaXuatBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSNhaXuatBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNXB,
            this.colTenNXB,
            this.colEmail,
            this.colSoDienThoaiNXB,
            this.colSoFax,
            this.colDiaChiNXB,
            this.colTrangThai,
            this.colGhiChu});
            this.dataGridViewDSNhaXuatBan.Location = new System.Drawing.Point(15, 24);
            this.dataGridViewDSNhaXuatBan.Name = "dataGridViewDSNhaXuatBan";
            this.dataGridViewDSNhaXuatBan.ReadOnly = true;
            this.dataGridViewDSNhaXuatBan.RowHeadersWidth = 62;
            this.dataGridViewDSNhaXuatBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDSNhaXuatBan.Size = new System.Drawing.Size(1214, 272);
            this.dataGridViewDSNhaXuatBan.TabIndex = 2;
            this.dataGridViewDSNhaXuatBan.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSNhaXuatBan_RowEnter);
            // 
            // colMaNXB
            // 
            this.colMaNXB.DataPropertyName = "MaNXB";
            this.colMaNXB.HeaderText = "Mã NXB";
            this.colMaNXB.MinimumWidth = 8;
            this.colMaNXB.Name = "colMaNXB";
            this.colMaNXB.ReadOnly = true;
            this.colMaNXB.Width = 60;
            // 
            // colTenNXB
            // 
            this.colTenNXB.DataPropertyName = "TenNXB";
            this.colTenNXB.HeaderText = "Tên NXB";
            this.colTenNXB.MinimumWidth = 8;
            this.colTenNXB.Name = "colTenNXB";
            this.colTenNXB.ReadOnly = true;
            this.colTenNXB.Width = 210;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 8;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 170;
            // 
            // colSoDienThoaiNXB
            // 
            this.colSoDienThoaiNXB.DataPropertyName = "SoDienThoaiNXB";
            this.colSoDienThoaiNXB.HeaderText = "SĐT NXB";
            this.colSoDienThoaiNXB.MinimumWidth = 8;
            this.colSoDienThoaiNXB.Name = "colSoDienThoaiNXB";
            this.colSoDienThoaiNXB.ReadOnly = true;
            this.colSoDienThoaiNXB.Width = 110;
            // 
            // colSoFax
            // 
            this.colSoFax.DataPropertyName = "SoFax";
            this.colSoFax.HeaderText = "Số Fax";
            this.colSoFax.MinimumWidth = 8;
            this.colSoFax.Name = "colSoFax";
            this.colSoFax.ReadOnly = true;
            this.colSoFax.Width = 90;
            // 
            // colDiaChiNXB
            // 
            this.colDiaChiNXB.DataPropertyName = "DiaChiNXB";
            this.colDiaChiNXB.HeaderText = "Địa chỉ NXB";
            this.colDiaChiNXB.MinimumWidth = 8;
            this.colDiaChiNXB.Name = "colDiaChiNXB";
            this.colDiaChiNXB.ReadOnly = true;
            this.colDiaChiNXB.Width = 160;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 8;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Width = 150;
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
            // errTenNXB
            // 
            this.errTenNXB.ContainerControl = this;
            // 
            // errDCNXB
            // 
            this.errDCNXB.ContainerControl = this;
            // 
            // errSDTNXB
            // 
            this.errSDTNXB.ContainerControl = this;
            // 
            // errEmail
            // 
            this.errEmail.ContainerControl = this;
            // 
            // errSoFax
            // 
            this.errSoFax.ContainerControl = this;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExportExcel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.Image = global::PhanMemQLTV.Properties.Resources.Dakirby309_Simply_Styled_Microsoft_Excel_2013;
            this.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportExcel.Location = new System.Drawing.Point(921, 358);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(165, 60);
            this.btnExportExcel.TabIndex = 15;
            this.btnExportExcel.Text = "Xuất Excel";
            this.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::PhanMemQLTV.Properties.Resources.home_icon1;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(177, 358);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(162, 60);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Trang chủ";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::PhanMemQLTV.Properties.Resources.Paomedia_Small_N_Flat_Floppy;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(777, 358);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(106, 60);
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
            this.btnXoa.Location = new System.Drawing.Point(643, 358);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(115, 60);
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
            this.btnSua.Location = new System.Drawing.Point(513, 358);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 60);
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
            this.btnHuy.Location = new System.Drawing.Point(1108, 358);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(117, 60);
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
            this.btnThem.Location = new System.Drawing.Point(373, 358);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 60);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmQLNhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1411, 755);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQLNhaXuatBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà xuất bản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQLNhaXuatBan_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSNhaXuatBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenNXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDCNXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSDTNXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSoFax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtNDTimKiem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radTenNXB;
        private System.Windows.Forms.RadioButton radMaNXB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNhapTenDG;
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNXB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoDTNXB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoFax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChiNXB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewDSNhaXuatBan;
        private System.Windows.Forms.ErrorProvider errTenNXB;
        private System.Windows.Forms.ErrorProvider errDCNXB;
        private System.Windows.Forms.ErrorProvider errSDTNXB;
        private System.Windows.Forms.ErrorProvider errEmail;
        private System.Windows.Forms.ErrorProvider errSoFax;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDienThoaiNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoFax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChiNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
    }
}