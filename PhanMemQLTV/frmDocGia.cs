using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace PhanMemQLTV
{
    public partial class frmDocGia : Form
    {
        public string tKDG;
        public frmDocGia(string tkDG)
        {
            InitializeComponent();
            tKDG = tkDG;
        }

        //public frmDocGia()
        //{
        //}

        //string strKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        ////private SqlConnection myConnection;
        //private SqlCommand myCommand;

        //private SqlDataAdapter myDataAdapter;

        //private DataTable myTable;


        //private DataTable ketnoi(string truyvan)
        //{
        //    myConnection = new SqlConnection(strKetNoi);
        //    myConnection.Open();
        //    string thuchiencaulenh = truyvan;
        //    myCommand = new SqlCommand(thuchiencaulenh, myConnection);
        //    myDataAdapter = new SqlDataAdapter(myCommand);
        //    myTable = new DataTable();
        //    myDataAdapter.Fill(myTable);
        //    dataGridViewDSSach0.DataSource = myTable;
        //    return myTable;
        //}


        //private void txtNDTimKiem_TextChanged(object sender, EventArgs e)
        //{
        //    if (radMaSach.Checked)
        //    {
        //        string timkiemMS = "select * from tblSach where MaSach like '%" + txtNDTimKiem.Text + "%'";
        //        ketnoi(timkiemMS);
        //        myCommand.ExecuteNonQuery();
        //        dataGridViewDSSach0.DataSource = myTable;
        //        dataGridViewDSSach0.AutoGenerateColumns = false;
        //        myConnection.Close();
        //    }
        //    else if (radTenSach.Checked)
        //    {
        //        string timkiemTS = "select * from tblSach where TenSach like N'%" + txtNDTimKiem.Text + "%'";
        //        ketnoi(timkiemTS);
        //        myCommand.ExecuteNonQuery();
        //        dataGridViewDSSach0.DataSource = ketnoi(timkiemTS);
        //        dataGridViewDSSach0.AutoGenerateColumns = false;
        //        myConnection.Close();
        //    }
        //    else if (radTenTG.Checked)
        //    {
        //        string timkiemMS = "select * from tblSach where TacGia like N'%" + txtNDTimKiem.Text + "%'";
        //        ketnoi(timkiemMS);
        //        myCommand.ExecuteNonQuery();
        //        dataGridViewDSSach0.DataSource = myTable;
        //        dataGridViewDSSach0.AutoGenerateColumns = false;
        //        myConnection.Close();
        //    }
        //    else if (radTenCD.Checked)
        //    {
        //        string timkiemMS = "select * from tblSach where ChuDe like N'%" + txtNDTimKiem.Text + "%'";
        //        ketnoi(timkiemMS);
        //        myCommand.ExecuteNonQuery();
        //        dataGridViewDSSach0.DataSource = myTable;
        //        dataGridViewDSSach0.AutoGenerateColumns = false;
        //        myConnection.Close();
        //    }
        //}





        // Su kien thoat

        private void frmDocGia_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        //Phuong thuc doi ngay giao dien doc gia
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


        string tenDGlenLabel = frmDangNhap.tenDG;
        private void frmDocGia_Load(object sender, EventArgs e)
        {
            lblNgayDG.Text = doiNgay(DateTime.Now.DayOfWeek.ToString()) + " " +
            DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" +
            DateTime.Now.Year.ToString();
            //timer1.Enabled = true;
            //timer2.Enabled = true;
            lblChaoMung.Text = "Xin chào: " + tenDGlenLabel + "." + " " + "Chúc quý độc giả một ngày vui vẻ.";
        }

        private void tmrGioDG_Tick(object sender, EventArgs e)
        {
            lblGioDG.Text = DateTime.Now.Hour.ToString() + " : " +
                DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString();
        }


        // Hien thi form doi mat khau doc gia
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMKDG frmDoiMKDG = new frmDoiMKDG();
            frmDoiMKDG.Show();
        }

        // Hien thi form quy dinh chung
        private void quyĐịnhChungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuyDinh frmQuyDinh = new frmQuyDinh();
            frmQuyDinh.Show();
        }

        // Hien thi form huong dan su dung
        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHuongDanSuDungDG frmHuongDanSuDungDG = new frmHuongDanSuDungDG();
            frmHuongDanSuDungDG.Show();
        }

        // Hien thi form tra cuu thong tin sach
        private void traCứuSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraCuuThongTinSach frmTraCuuThongTinSach = new frmTraCuuThongTinSach();
            frmTraCuuThongTinSach.Show();
        }

        // Hien thi form tra cuu thong tin nha xuat ban
        private void traCứuNhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraCuuThongTinNXB frmTraCuuThongTinNXB = new frmTraCuuThongTinNXB();
            frmTraCuuThongTinNXB.Show();
        }

        //Dong form
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // label chao mung
        private void timer1_Tick(object sender, EventArgs e)
        {
            //lblChaoMung.Left += 10;

            //if (lblChaoMung.Left >= 450)
            //    timer1.Enabled = false;
        }

        // label anticovid
        private void timer2_Tick(object sender, EventArgs e)
        {
            //lblAntiCovid.Left += 10;

            //if (lblAntiCovid.Left >= 280)
            //    timer2.Enabled = false;
        }

        private void lblChaoMung_Click(object sender, EventArgs e)
        {

        }
    }
}
