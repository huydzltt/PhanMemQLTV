using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQLTV
{
    public partial class frmGiaoDienChinh : Form
    {
        //AutoSize _form_resize;
        public frmGiaoDienChinh()
        {
            InitializeComponent();
            //_form_resize = new AutoSize(this);
            //this.Load += _Load;
            //this.Resize += _Resize;
        }

        //private void _Load(object sender, EventArgs e) 
        //{
        //    _form_resize._get_initial_size();
        //}

        //private void _Resize(object sender, EventArgs e) 
        //{
        //    _form_resize._resize();
        //}

        // Mục các đối tượng quản lý

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangKyTT DKTT = new frmDangKyTT();
            DKTT.Show();
        }

        private void đổiMậtKhậuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau DoiMKTT = new frmDoiMatKhau();
            DoiMKTT.Show();
        }


        private void quảnLýSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQLSach QLSach = new frmQLSach();
            QLSach.Show();
        }

        private void quảnLýĐộcGiảToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQLDocGia QLDocGia = new frmQLDocGia();
            QLDocGia.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLNhanVien QLNhanVien = new frmQLNhanVien();
            QLNhanVien.Show();
        }

        private void quảnLýNhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLNhaXuatBan QLNhaXuatBan = new frmQLNhaXuatBan();
            QLNhaXuatBan.Show();
        }

        private void quảnLýMượnTrảToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQLMuonTra QLmuonTra = new frmQLMuonTra();
            QLmuonTra.Show();
        }

        // Bao cao - thong ke
        private void quảnLýMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoThongKe BaoCaoThongKe = new frmBaoCaoThongKe();
            BaoCaoThongKe.Show();
        }
        // Quy dinh chung
        private void quyĐịnhChungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuyDinh quyDinh = new frmQuyDinh();
            quyDinh.Show();
        }

        // Huong dan su dung
        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHuongDanSuDungTT huongDanSuDungTT = new frmHuongDanSuDungTT();
            huongDanSuDungTT.Show();
        }

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Su kien dong form
        private void frmGiaoDienChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        //Phuong thuc doi ngay giao dien main
        private String doiNgay(String name)
        {
            String ngay = "";
            switch (name)
            {
                case "Monday":
                    ngay = "Thứ hai";
                    break;
                case "Tuesday":
                    ngay = "Thứ ba";
                    break;
                case "Wednesday":
                    ngay = "Thứ tư";
                    break;
                case "Thusday":
                    ngay = "Thứ năm";
                    break;
                case "Friday":
                    ngay = "Thứ sáu";
                    break;
                case "Saturday":
                    ngay = "Thứ bẩy";
                    break;
                default:
                    ngay = "Chủ nhật";
                    break;
            }
            return ngay;
        }

        string tenTTlenLabel = frmDangNhap.tenTT;
        private void frmGiaoDienChinh_Load(object sender, EventArgs e)
        {
            lblNgayMain.Text = doiNgay(DateTime.Now.DayOfWeek.ToString())  + " " +
            DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" +
            DateTime.Now.Year.ToString();
           
        }

        private void tmrGioMain_Tick(object sender, EventArgs e)
        {
            lblGioMain.Text = DateTime.Now.Hour.ToString() + " : " +
                DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString();
        }

        // Import du lieu
        private void importDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImportDuLieu importDuLieu = new frmImportDuLieu();
            importDuLieu.Show();
        }

        // mo form nhat ky hoat dong                
        private void nhậtKýHoạtĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhatKyHoatDong frmNhatKyHoatDong = new frmNhatKyHoatDong();
            frmNhatKyHoatDong.Show();
        }
    }
}
