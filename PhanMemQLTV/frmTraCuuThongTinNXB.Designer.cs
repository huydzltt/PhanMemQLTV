
namespace PhanMemQLTV
{
    partial class frmTraCuuThongTinNXB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuThongTinNXB));
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.txtNDTimKiemNXB = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radTenNXB = new System.Windows.Forms.RadioButton();
            this.radMaNXB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDSNhaXuatBan0 = new System.Windows.Forms.DataGridView();
            this.colMaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDienThoaiNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoFax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChiNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSNhaXuatBan0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::PhanMemQLTV.Properties.Resources.home_icon1;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1147, 41);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(158, 64);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Trang chủ";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.grpTimKiem);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(47, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1258, 115);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm nhà xuất bản";
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTimKiem.Controls.Add(this.txtNDTimKiemNXB);
            this.grpTimKiem.Location = new System.Drawing.Point(674, 29);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(566, 71);
            this.grpTimKiem.TabIndex = 1;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Nhập thông tin cần tìm kiếm:";
            // 
            // txtNDTimKiemNXB
            // 
            this.txtNDTimKiemNXB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNDTimKiemNXB.Location = new System.Drawing.Point(11, 24);
            this.txtNDTimKiemNXB.Name = "txtNDTimKiemNXB";
            this.txtNDTimKiemNXB.Size = new System.Drawing.Size(549, 30);
            this.txtNDTimKiemNXB.TabIndex = 0;
            this.txtNDTimKiemNXB.TextChanged += new System.EventHandler(this.txtNDTimKiemNXB_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radTenNXB);
            this.groupBox4.Controls.Add(this.radMaNXB);
            this.groupBox4.Location = new System.Drawing.Point(59, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(559, 71);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm theo:";
            // 
            // radTenNXB
            // 
            this.radTenNXB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radTenNXB.AutoSize = true;
            this.radTenNXB.Location = new System.Drawing.Point(296, 29);
            this.radTenNXB.Name = "radTenNXB";
            this.radTenNXB.Size = new System.Drawing.Size(167, 26);
            this.radTenNXB.TabIndex = 2;
            this.radTenNXB.TabStop = true;
            this.radTenNXB.Text = "Tên nhà xuất bản";
            this.radTenNXB.UseVisualStyleBackColor = true;
            // 
            // radMaNXB
            // 
            this.radMaNXB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radMaNXB.AutoSize = true;
            this.radMaNXB.Location = new System.Drawing.Point(101, 29);
            this.radMaNXB.Name = "radMaNXB";
            this.radMaNXB.Size = new System.Drawing.Size(163, 26);
            this.radMaNXB.TabIndex = 0;
            this.radMaNXB.TabStop = true;
            this.radMaNXB.Text = "Mã nhà xuất bản";
            this.radMaNXB.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridViewDSNhaXuatBan0);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(47, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1258, 419);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà xuất bản:";
            // 
            // dataGridViewDSNhaXuatBan0
            // 
            this.dataGridViewDSNhaXuatBan0.AllowUserToAddRows = false;
            this.dataGridViewDSNhaXuatBan0.AllowUserToDeleteRows = false;
            this.dataGridViewDSNhaXuatBan0.AllowUserToResizeRows = false;
            this.dataGridViewDSNhaXuatBan0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDSNhaXuatBan0.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDSNhaXuatBan0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSNhaXuatBan0.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNXB,
            this.colTenNXB,
            this.colEmail,
            this.colSoDienThoaiNXB,
            this.colSoFax,
            this.colDiaChiNXB,
            this.colTrangThai,
            this.colGhiChu});
            this.dataGridViewDSNhaXuatBan0.Location = new System.Drawing.Point(8, 29);
            this.dataGridViewDSNhaXuatBan0.Name = "dataGridViewDSNhaXuatBan0";
            this.dataGridViewDSNhaXuatBan0.ReadOnly = true;
            this.dataGridViewDSNhaXuatBan0.RowHeadersWidth = 62;
            this.dataGridViewDSNhaXuatBan0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDSNhaXuatBan0.Size = new System.Drawing.Size(1232, 370);
            this.dataGridViewDSNhaXuatBan0.TabIndex = 3;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhanMemQLTV.Properties.Resources.newlogo;
            this.pictureBox1.Location = new System.Drawing.Point(43, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Thư Viện Tư Nhân Hà Công Luận";
            // 
            // frmTraCuuThongTinNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 731);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTraCuuThongTinNXB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox3.ResumeLayout(false);
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSNhaXuatBan0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.TextBox txtNDTimKiemNXB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radTenNXB;
        private System.Windows.Forms.RadioButton radMaNXB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewDSNhaXuatBan0;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDienThoaiNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoFax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChiNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}