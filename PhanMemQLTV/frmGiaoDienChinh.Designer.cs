namespace PhanMemQLTV
{
    partial class frmGiaoDienChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoDienChinh));
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.mnuHeThong = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhậuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSáchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐộcGiảToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhàXuấtBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMượnTrảToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMượnTrảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoThốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quyĐịnhChungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrGioMain = new System.Windows.Forms.Timer(this.components);
            this.picAnhNen = new System.Windows.Forms.PictureBox();
            this.lblGioMain = new System.Windows.Forms.Label();
            this.lblNgayMain = new System.Windows.Forms.Label();
            this.mnuHeThong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhNen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDe.Location = new System.Drawing.Point(0, 32);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(1286, 58);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Thư viện HUFLIT";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnuHeThong.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mnuHeThong.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuHeThong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.quảnLýDanhMụcToolStripMenuItem,
            this.quảnLýMượnTrảToolStripMenuItem,
            this.báoCáoThốngKêToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.mnuHeThong.Location = new System.Drawing.Point(0, 0);
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnuHeThong.Size = new System.Drawing.Size(1286, 32);
            this.mnuHeThong.TabIndex = 0;
            this.mnuHeThong.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngKýToolStripMenuItem,
            this.đổiMậtKhậuToolStripMenuItem,
            this.importDữLiệuToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tàiKhoảnToolStripMenuItem.Image = global::PhanMemQLTV.Properties.Resources.onebit_01;
            this.tàiKhoảnToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(109, 28);
            this.tàiKhoảnToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngKýToolStripMenuItem
            // 
            this.đăngKýToolStripMenuItem.Image = global::PhanMemQLTV.Properties.Resources.dangky;
            this.đăngKýToolStripMenuItem.Name = "đăngKýToolStripMenuItem";
            this.đăngKýToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.đăngKýToolStripMenuItem.Text = "Đăng ký ";
            this.đăngKýToolStripMenuItem.Click += new System.EventHandler(this.đăngKýToolStripMenuItem_Click);
            // 
            // đổiMậtKhậuToolStripMenuItem
            // 
            this.đổiMậtKhậuToolStripMenuItem.Image = global::PhanMemQLTV.Properties.Resources.pngtree_lock_password_icon_vectors_png_image_1738050;
            this.đổiMậtKhậuToolStripMenuItem.Name = "đổiMậtKhậuToolStripMenuItem";
            this.đổiMậtKhậuToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.đổiMậtKhậuToolStripMenuItem.Text = "Đổi mật khẩu ";
            this.đổiMậtKhậuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhậuToolStripMenuItem_Click);
            // 
            // importDữLiệuToolStripMenuItem
            // 
            this.importDữLiệuToolStripMenuItem.Image = global::PhanMemQLTV.Properties.Resources.import_icon;
            this.importDữLiệuToolStripMenuItem.Name = "importDữLiệuToolStripMenuItem";
            this.importDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.importDữLiệuToolStripMenuItem.Text = "Import sách";
            this.importDữLiệuToolStripMenuItem.Click += new System.EventHandler(this.importDữLiệuToolStripMenuItem_Click);
            // 
            // quảnLýDanhMụcToolStripMenuItem
            // 
            this.quảnLýDanhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSáchToolStripMenuItem1,
            this.quảnLýĐộcGiảToolStripMenuItem1,
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýNhàXuấtBảnToolStripMenuItem,
            this.quảnLýMượnTrảToolStripMenuItem1});
            this.quảnLýDanhMụcToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.quảnLýDanhMụcToolStripMenuItem.Image = global::PhanMemQLTV.Properties.Resources.danhmucquanly;
            this.quảnLýDanhMụcToolStripMenuItem.Name = "quảnLýDanhMụcToolStripMenuItem";
            this.quảnLýDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(167, 28);
            this.quảnLýDanhMụcToolStripMenuItem.Text = "Danh mục quản lý";
            // 
            // quảnLýSáchToolStripMenuItem1
            // 
            this.quảnLýSáchToolStripMenuItem1.Image = global::PhanMemQLTV.Properties.Resources.sach2;
            this.quảnLýSáchToolStripMenuItem1.Name = "quảnLýSáchToolStripMenuItem1";
            this.quảnLýSáchToolStripMenuItem1.Size = new System.Drawing.Size(230, 26);
            this.quảnLýSáchToolStripMenuItem1.Text = "Quản lý sách";
            this.quảnLýSáchToolStripMenuItem1.Click += new System.EventHandler(this.quảnLýSáchToolStripMenuItem1_Click);
            // 
            // quảnLýĐộcGiảToolStripMenuItem1
            // 
            this.quảnLýĐộcGiảToolStripMenuItem1.Image = global::PhanMemQLTV.Properties.Resources.dg32;
            this.quảnLýĐộcGiảToolStripMenuItem1.Name = "quảnLýĐộcGiảToolStripMenuItem1";
            this.quảnLýĐộcGiảToolStripMenuItem1.Size = new System.Drawing.Size(230, 26);
            this.quảnLýĐộcGiảToolStripMenuItem1.Text = "Quản lý độc giả";
            this.quảnLýĐộcGiảToolStripMenuItem1.Click += new System.EventHandler(this.quảnLýĐộcGiảToolStripMenuItem1_Click);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Image = global::PhanMemQLTV.Properties.Resources.nhanvien;
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // quảnLýNhàXuấtBảnToolStripMenuItem
            // 
            this.quảnLýNhàXuấtBảnToolStripMenuItem.Image = global::PhanMemQLTV.Properties.Resources.nhaxuatban2;
            this.quảnLýNhàXuấtBảnToolStripMenuItem.Name = "quảnLýNhàXuấtBảnToolStripMenuItem";
            this.quảnLýNhàXuấtBảnToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.quảnLýNhàXuấtBảnToolStripMenuItem.Text = "Quản lý nhà xuất bản";
            this.quảnLýNhàXuấtBảnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhàXuấtBảnToolStripMenuItem_Click);
            // 
            // quảnLýMượnTrảToolStripMenuItem1
            // 
            this.quảnLýMượnTrảToolStripMenuItem1.Image = global::PhanMemQLTV.Properties.Resources.muontra;
            this.quảnLýMượnTrảToolStripMenuItem1.Name = "quảnLýMượnTrảToolStripMenuItem1";
            this.quảnLýMượnTrảToolStripMenuItem1.Size = new System.Drawing.Size(230, 26);
            this.quảnLýMượnTrảToolStripMenuItem1.Text = "Quản lý mượn - trả";
            this.quảnLýMượnTrảToolStripMenuItem1.Click += new System.EventHandler(this.quảnLýMượnTrảToolStripMenuItem1_Click);
            // 
            // quảnLýMượnTrảToolStripMenuItem
            // 
            this.quảnLýMượnTrảToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.quảnLýMượnTrảToolStripMenuItem.Image = global::PhanMemQLTV.Properties.Resources.statistical32;
            this.quảnLýMượnTrảToolStripMenuItem.Name = "quảnLýMượnTrảToolStripMenuItem";
            this.quảnLýMượnTrảToolStripMenuItem.Size = new System.Drawing.Size(178, 28);
            this.quảnLýMượnTrảToolStripMenuItem.Text = "Báo cáo - Thống kê";
            this.quảnLýMượnTrảToolStripMenuItem.Click += new System.EventHandler(this.quảnLýMượnTrảToolStripMenuItem_Click);
            // 
            // báoCáoThốngKêToolStripMenuItem
            // 
            this.báoCáoThốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quyĐịnhChungToolStripMenuItem,
            this.hướngDẫnSửDụngToolStripMenuItem});
            this.báoCáoThốngKêToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.báoCáoThốngKêToolStripMenuItem.Image = global::PhanMemQLTV.Properties.Resources.FAQ_icon;
            this.báoCáoThốngKêToolStripMenuItem.Name = "báoCáoThốngKêToolStripMenuItem";
            this.báoCáoThốngKêToolStripMenuItem.Size = new System.Drawing.Size(103, 28);
            this.báoCáoThốngKêToolStripMenuItem.Text = "Trợ giúp";
            // 
            // quyĐịnhChungToolStripMenuItem
            // 
            this.quyĐịnhChungToolStripMenuItem.Image = global::PhanMemQLTV.Properties.Resources.quydinhchung;
            this.quyĐịnhChungToolStripMenuItem.Name = "quyĐịnhChungToolStripMenuItem";
            this.quyĐịnhChungToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.quyĐịnhChungToolStripMenuItem.Text = "Quy định chung";
            this.quyĐịnhChungToolStripMenuItem.Click += new System.EventHandler(this.quyĐịnhChungToolStripMenuItem_Click);
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            this.hướngDẫnSửDụngToolStripMenuItem.Image = global::PhanMemQLTV.Properties.Resources.hdsudung;
            this.hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            this.hướngDẫnSửDụngToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            this.hướngDẫnSửDụngToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnSửDụngToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thoátToolStripMenuItem.Image = global::PhanMemQLTV.Properties.Resources.exit32;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(85, 28);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click_1);
            // 
            // tmrGioMain
            // 
            this.tmrGioMain.Enabled = true;
            this.tmrGioMain.Interval = 1000;
            this.tmrGioMain.Tick += new System.EventHandler(this.tmrGioMain_Tick);
            // 
            // picAnhNen
            // 
            this.picAnhNen.Image = global::PhanMemQLTV.Properties.Resources.hinhnenchuan;
            this.picAnhNen.Location = new System.Drawing.Point(10, 109);
            this.picAnhNen.Name = "picAnhNen";
            this.picAnhNen.Size = new System.Drawing.Size(1264, 580);
            this.picAnhNen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnhNen.TabIndex = 2;
            this.picAnhNen.TabStop = false;
            // 
            // lblGioMain
            // 
            this.lblGioMain.AutoSize = true;
            this.lblGioMain.Location = new System.Drawing.Point(1189, 5);
            this.lblGioMain.Name = "lblGioMain";
            this.lblGioMain.Size = new System.Drawing.Size(51, 19);
            this.lblGioMain.TabIndex = 3;
            this.lblGioMain.Text = "label2";
            // 
            // lblNgayMain
            // 
            this.lblNgayMain.AutoSize = true;
            this.lblNgayMain.Location = new System.Drawing.Point(1065, 5);
            this.lblNgayMain.Name = "lblNgayMain";
            this.lblNgayMain.Size = new System.Drawing.Size(51, 19);
            this.lblNgayMain.TabIndex = 4;
            this.lblNgayMain.Text = "label1";
            // 
            // frmGiaoDienChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 701);
            this.Controls.Add(this.lblNgayMain);
            this.Controls.Add(this.lblGioMain);
            this.Controls.Add(this.picAnhNen);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.mnuHeThong);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuHeThong;
            this.MaximizeBox = false;
            this.Name = "frmGiaoDienChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGiaoDienChinh_FormClosing);
            this.Load += new System.EventHandler(this.frmGiaoDienChinh_Load);
            this.mnuHeThong.ResumeLayout(false);
            this.mnuHeThong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhNen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.MenuStrip mnuHeThong;
        private System.Windows.Forms.PictureBox picAnhNen;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMượnTrảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoThốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDanhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSáchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐộcGiảToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhậuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhàXuấtBảnToolStripMenuItem;
        private System.Windows.Forms.Timer tmrGioMain;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMượnTrảToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quyĐịnhChungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importDữLiệuToolStripMenuItem;
        private System.Windows.Forms.Label lblGioMain;
        private System.Windows.Forms.Label lblNgayMain;
    }
}