
namespace PhanMemQLTV
{
    partial class frmTraCuuThongTinSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuThongTinSach));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDSSach0 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.txtNDTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radTenCD = new System.Windows.Forms.RadioButton();
            this.radTenTG = new System.Windows.Forms.RadioButton();
            this.radTenSach = new System.Windows.Forms.RadioButton();
            this.radMaSach = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSSach0)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridViewDSSach0);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1260, 435);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách:";
            // 
            // dataGridViewDSSach0
            // 
            this.dataGridViewDSSach0.AllowUserToAddRows = false;
            this.dataGridViewDSSach0.AllowUserToDeleteRows = false;
            this.dataGridViewDSSach0.AllowUserToResizeRows = false;
            this.dataGridViewDSSach0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDSSach0.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDSSach0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSSach0.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colTenSach,
            this.colTenLoai,
            this.colTenTG,
            this.colMaNXB,
            this.colNamXB,
            this.colSoLuong,
            this.colDonGia,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewDSSach0.Location = new System.Drawing.Point(8, 29);
            this.dataGridViewDSSach0.Name = "dataGridViewDSSach0";
            this.dataGridViewDSSach0.RowHeadersWidth = 62;
            this.dataGridViewDSSach0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDSSach0.Size = new System.Drawing.Size(1234, 386);
            this.dataGridViewDSSach0.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaSach";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã sách";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // colTenSach
            // 
            this.colTenSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenSach.DataPropertyName = "TenSach";
            this.colTenSach.HeaderText = "Tên sách";
            this.colTenSach.MinimumWidth = 8;
            this.colTenSach.Name = "colTenSach";
            this.colTenSach.ReadOnly = true;
            // 
            // colTenLoai
            // 
            this.colTenLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTenLoai.DataPropertyName = "ChuDe";
            this.colTenLoai.HeaderText = "Chủ đề";
            this.colTenLoai.MinimumWidth = 8;
            this.colTenLoai.Name = "colTenLoai";
            this.colTenLoai.ReadOnly = true;
            this.colTenLoai.Width = 101;
            // 
            // colTenTG
            // 
            this.colTenTG.DataPropertyName = "TacGia";
            this.colTenTG.HeaderText = "Tác giả";
            this.colTenTG.MinimumWidth = 8;
            this.colTenTG.Name = "colTenTG";
            this.colTenTG.ReadOnly = true;
            this.colTenTG.Width = 150;
            // 
            // colMaNXB
            // 
            this.colMaNXB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMaNXB.DataPropertyName = "MaNXB";
            this.colMaNXB.HeaderText = "Mã NXB";
            this.colMaNXB.MinimumWidth = 8;
            this.colMaNXB.Name = "colMaNXB";
            this.colMaNXB.ReadOnly = true;
            this.colMaNXB.Width = 109;
            // 
            // colNamXB
            // 
            this.colNamXB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNamXB.DataPropertyName = "NamXB";
            this.colNamXB.HeaderText = "Năm XB";
            this.colNamXB.MinimumWidth = 8;
            this.colNamXB.Name = "colNamXB";
            this.colNamXB.Width = 107;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SLNhap";
            this.colSoLuong.HeaderText = "SL nhập";
            this.colSoLuong.MinimumWidth = 8;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            this.colSoLuong.Width = 50;
            // 
            // colDonGia
            // 
            this.colDonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDonGia.DataPropertyName = "DonGia";
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.MinimumWidth = 8;
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.ReadOnly = true;
            this.colDonGia.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TinhTrang";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tình trạng";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GhiChu";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ghi chú";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.grpTimKiem);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(40, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1260, 115);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm sách";
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTimKiem.Controls.Add(this.txtNDTimKiem);
            this.grpTimKiem.Location = new System.Drawing.Point(674, 29);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(568, 71);
            this.grpTimKiem.TabIndex = 1;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Nhập thông tin cần tìm kiếm:";
            // 
            // txtNDTimKiem
            // 
            this.txtNDTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNDTimKiem.Location = new System.Drawing.Point(11, 24);
            this.txtNDTimKiem.Name = "txtNDTimKiem";
            this.txtNDTimKiem.Size = new System.Drawing.Size(551, 30);
            this.txtNDTimKiem.TabIndex = 0;
            this.txtNDTimKiem.TextChanged += new System.EventHandler(this.txtNDTimKiem_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radTenCD);
            this.groupBox4.Controls.Add(this.radTenTG);
            this.groupBox4.Controls.Add(this.radTenSach);
            this.groupBox4.Controls.Add(this.radMaSach);
            this.groupBox4.Location = new System.Drawing.Point(59, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(559, 71);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm theo:";
            // 
            // radTenCD
            // 
            this.radTenCD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radTenCD.AutoSize = true;
            this.radTenCD.Location = new System.Drawing.Point(408, 29);
            this.radTenCD.Name = "radTenCD";
            this.radTenCD.Size = new System.Drawing.Size(121, 26);
            this.radTenCD.TabIndex = 3;
            this.radTenCD.TabStop = true;
            this.radTenCD.Text = "Tên chủ đề";
            this.radTenCD.UseVisualStyleBackColor = true;
            // 
            // radTenTG
            // 
            this.radTenTG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radTenTG.AutoSize = true;
            this.radTenTG.Location = new System.Drawing.Point(267, 29);
            this.radTenTG.Name = "radTenTG";
            this.radTenTG.Size = new System.Drawing.Size(122, 26);
            this.radTenTG.TabIndex = 2;
            this.radTenTG.TabStop = true;
            this.radTenTG.Text = "Tên tác giả";
            this.radTenTG.UseVisualStyleBackColor = true;
            // 
            // radTenSach
            // 
            this.radTenSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radTenSach.AutoSize = true;
            this.radTenSach.Location = new System.Drawing.Point(147, 29);
            this.radTenSach.Name = "radTenSach";
            this.radTenSach.Size = new System.Drawing.Size(105, 26);
            this.radTenSach.TabIndex = 1;
            this.radTenSach.TabStop = true;
            this.radTenSach.Text = "Tên sách";
            this.radTenSach.UseVisualStyleBackColor = true;
            // 
            // radMaSach
            // 
            this.radMaSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radMaSach.AutoSize = true;
            this.radMaSach.Location = new System.Drawing.Point(26, 29);
            this.radMaSach.Name = "radMaSach";
            this.radMaSach.Size = new System.Drawing.Size(101, 26);
            this.radMaSach.TabIndex = 0;
            this.radMaSach.TabStop = true;
            this.radMaSach.Text = "Mã sách";
            this.radMaSach.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::PhanMemQLTV.Properties.Resources.home_icon1;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1142, 36);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(158, 64);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Trang chủ";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhanMemQLTV.Properties.Resources.newlogo;
            this.pictureBox1.Location = new System.Drawing.Point(39, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Thư Viện Tư Nhân Hà Công Luận";
            // 
            // frmTraCuuThongTinSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 731);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTraCuuThongTinSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSSach0)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewDSSach0;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.TextBox txtNDTimKiem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radTenCD;
        private System.Windows.Forms.RadioButton radTenTG;
        private System.Windows.Forms.RadioButton radTenSach;
        private System.Windows.Forms.RadioButton radMaSach;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}