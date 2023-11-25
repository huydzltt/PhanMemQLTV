using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace PhanMemQLTV
{
    public partial class frmBaoCaoThongKe : Form
    {
        public frmBaoCaoThongKe()
        {
            InitializeComponent();
        }
        string strKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConnection;
        private SqlCommand myCommand;
        private SqlDataAdapter myDataAdapter;
        private DataTable myTable;


        private SqlDataReader myDataReaderSLDauSach;
        private SqlDataReader myDataReaderSLMuon;
        private SqlDataReader myDataReaderSLDG;
        private SqlDataReader myDataReaderSLNV;
        private SqlDataReader myDataReaderSLNXB;
        private SqlDataReader myDataReaderSLDGMuon;
        private SqlDataReader myDataReaderSLSQuaHan;
        private SqlDataReader myDataReaderSLDGQuaHan;


        private DataTable ketnoi(string truyvan)
        {
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            string thuchiencaulenh = truyvan;
            myCommand = new SqlCommand(thuchiencaulenh, myConnection);
            myDataAdapter = new SqlDataAdapter(myCommand);
            myTable = new DataTable();
            myDataAdapter.Fill(myTable);
            dataGridViewDSDGQuaHan.DataSource = myTable;
            return myTable;
        }



        public string luuSLDauSach, luuSLCuon, luuTongGiaTriSach;
        // Tính SL Đầu Sách, SL Cuốn, SL Còn, Tổng GT Sách
        private void slDauSach()
        {
            string strTinhSLDauSach = "select count(MaSach) as TongSLDauSach, sum(SLNhap) as TongSLSach, sum(DonGia) as TongGiaTriSach from tblSach";
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            myCommand = new SqlCommand(strTinhSLDauSach, myConnection);
            myDataReaderSLDauSach = myCommand.ExecuteReader();
            while (myDataReaderSLDauSach.Read())
            {
                luuSLDauSach = myDataReaderSLDauSach.GetInt32(0).ToString();
                luuSLCuon = myDataReaderSLDauSach.GetInt32(1).ToString();
                luuTongGiaTriSach = myDataReaderSLDauSach.GetInt32(2).ToString();
            }

        }

        // Tính SL Mượn
        public string luuSLMuon;
        private void slMuon()
        {
            string strTinhSLMuon = "select sum(SLMuon) as Tong from tblHSPhieuMuon";
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            myCommand = new SqlCommand(strTinhSLMuon, myConnection);
            myDataReaderSLMuon = myCommand.ExecuteReader();
            while (myDataReaderSLMuon.Read())
            {
                if (dataGridViewDSDGQuaHan.DataSource != null)
                {
                    luuSLMuon = myDataReaderSLMuon.GetInt32(0).ToString();
                }          
            }

        }

        // Tính SL Độc Giả
        public string luuSLDG;
        private void slDocGia()
        {
            string strTinhSLMuon = "select count(MaDG) as TongSLDG from tblDocGia";
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            myCommand = new SqlCommand(strTinhSLMuon, myConnection);
            myDataReaderSLDG = myCommand.ExecuteReader();
            while (myDataReaderSLDG.Read())
            {
                luuSLDG = myDataReaderSLDG.GetInt32(0).ToString();
            }
        }

        // tính tổng SL Nhân Viên
        public string luuSLNV;

        private void slNhanVien() 
        {
            string strTinhSLNhanVien = "select count(MaNV) as TongSLNV from tblNhanVien";
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            myCommand = new SqlCommand(strTinhSLNhanVien, myConnection);
            myDataReaderSLNV = myCommand.ExecuteReader();
            while (myDataReaderSLNV.Read()) 
            {
                luuSLNV = myDataReaderSLNV.GetInt32(0).ToString();
            }

        }

        // tính tổng số lượng nhà xuất bản
        public string luuSLNXB;
        
        private void slNhaXuatBan()
        {
            string strTinhSLNhaXuatBan = "select count(MaNXB) as TongSLNXB from tblNhaXuatBan";
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            myCommand = new SqlCommand(strTinhSLNhaXuatBan, myConnection);
            myDataReaderSLNXB = myCommand.ExecuteReader();
            while (myDataReaderSLNXB.Read())
            {
                luuSLNXB = myDataReaderSLNXB.GetInt32(0).ToString();
            }
        }
        
        // Tính SLDG Đã Mượn sách
        public string luuSLDGMuon;
        private void slDocGiaMuon()
        {
            string strTinhSLMuon = "select (count(distinct(MaDG))) as TongSLDGMuon from tblHSPhieuMuon";
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            myCommand = new SqlCommand(strTinhSLMuon, myConnection);
            myDataReaderSLDGMuon = myCommand.ExecuteReader();
            while (myDataReaderSLDGMuon.Read())
            {
                luuSLDGMuon = myDataReaderSLDGMuon.GetInt32(0).ToString();
            }
        }

        //SL sách quá hạn
        public string luuSLSQuaHan;
        private void slSachQuaHan()
        {
            string strTinhSLSachQuaHan = "SELECT count(SLMuon) as TongSLQuaHan from tblHSPhieuMuon where CONVERT (datetime, NgayTra, 103) < getdate()";
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            myCommand = new SqlCommand(strTinhSLSachQuaHan, myConnection);
            myDataReaderSLSQuaHan = myCommand.ExecuteReader();
            while (myDataReaderSLSQuaHan.Read())
            {
                luuSLSQuaHan = myDataReaderSLSQuaHan.GetInt32(0).ToString();
            }

        }

        // SL Độc Giả quá hạn
        public string luuSLDGQuaHan;
        private void slDGQuaHan()
        {
            string strTinhSLDGQuaHan = "SELECT count(distinct(MaDG)) as TongSLQuaHan from tblHSPhieuMuon where CONVERT (datetime, NgayTra, 103) < getdate()"; //  dinh dang du lieu dd/mm/yy
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            myCommand = new SqlCommand(strTinhSLDGQuaHan, myConnection);
            myDataReaderSLDGQuaHan = myCommand.ExecuteReader();
            while (myDataReaderSLDGQuaHan.Read())
            {
                luuSLDGQuaHan = myDataReaderSLDGQuaHan.GetInt32(0).ToString();
            }

        }

        private void frmBaoCaoThongKe_Load(object sender, EventArgs e)
        {
            txtSLDauSach.Enabled = false;
            txtSLCuon.Enabled = false;
            txtSLCon.Enabled = false;
            txtSLMuon.Enabled = false;
            txtTongGiaTriSach.Enabled = false;
            txtSLSachQuaHan.Enabled = false;

            txtSLDGQuaHan.Enabled = false;
            txtSLDocGia.Enabled = false;
            txtSLNhanVien.Enabled = false;
            txtSLNhaXuatBan.Enabled = false;
            txtSLDGMuon.Enabled = false;

            dataGridViewDSDGQuaHan.Hide();

            // Tổng SL Đầu sách, sl nhập, sl còn , tổng giá trị
            slDauSach();
            txtSLDauSach.Text = luuSLDauSach;
            txtSLCuon.Text = luuSLCuon;
            txtTongGiaTriSach.Text = luuTongGiaTriSach;

            // tổng sl mượn
            slMuon();
            txtSLMuon.Text = luuSLMuon;
            int luuSLCon = Convert.ToInt32(luuSLCuon) - Convert.ToInt32(luuSLMuon);
            txtSLCon.Text = luuSLCon.ToString();

            // tổng sl độc giả
            slDocGia();
            txtSLDocGia.Text = luuSLDG;

            // tổng sl nhân viên
            slNhanVien();
            txtSLNhanVien.Text = luuSLNV;

            // tổng sl nhà xuất bản
            slNhaXuatBan();
            txtSLNhaXuatBan.Text = luuSLNXB;

            // SL  độc giả đã mượn sahcs
            slDocGiaMuon();
            txtSLDGMuon.Text = luuSLDGMuon;


            // SL Sách quá hạn
            slSachQuaHan();
            txtSLSachQuaHan.Text = luuSLSQuaHan;

            //SL DG quá hạn
            slDGQuaHan();
            txtSLDGQuaHan.Text = luuSLDGQuaHan;
        }

        private void frmBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            dataGridViewDSDGQuaHan.Hide();
        }

        private void btnXemSLSachQuaHan_Click(object sender, EventArgs e)
        {
            string strTimSLSQuaHan = @"SELECT MaPhieu as 'Mã phiếu', MaDG as 'Mã ĐG', MaSach as 'Mã sách', NgayMuon as 'Ngày mượn', NgayTra as 'Ngày trả', GhiChu as 'Ghi chú' from tblHSPhieuMuon where CONVERT (datetime, NgayTra, 103) < getdate()"; // dinh dang ngay theo kieu dd/mm/yy
            dataGridViewDSDGQuaHan.DataSource = ketnoi(strTimSLSQuaHan);
            dataGridViewDSDGQuaHan.Columns["Ghi chú"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewDSDGQuaHan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDSDGQuaHan.Show();
        }

        private void btnSLDGQuaHan_Click(object sender, EventArgs e)
        {
            string strTimSLDGQuaHan = @"SELECT MaDG as 'Mã ĐG', count(SLMuon) as 'SL sách mượn' from tblHSPhieuMuon where CONVERT (datetime, NgayTra, 103) <= getdate() group by MaDG";
            dataGridViewDSDGQuaHan.DataSource = ketnoi(strTimSLDGQuaHan);
            dataGridViewDSDGQuaHan.Columns["Mã ĐG"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewDSDGQuaHan.Columns["SL sách mượn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridViewDSDGQuaHan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDSDGQuaHan.Show();
        }

      

        //Xuat cac danh sach thong ke ra Excel
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            //Khoi tao Excel
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //Khoi tao WorkBook
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //Khoi tao WorkSheet
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;

            //Do du lieu vao Sheet
            //p1: 2 phan thong ke
            worksheet.Cells[2, 2] = "Thư Viện Tư Nhân Hà Công Luận";

            //sach
            worksheet.Cells[5, 3] = "*Thống kê sách";
            worksheet.Cells[6, 3] = "Số lượng đầu sách: " + txtSLDauSach.Text;
            worksheet.Cells[7, 3] = "Số lượng cuốn: " + txtSLCuon.Text;
            worksheet.Cells[8, 3] = "Số lượng mượn: " + txtSLMuon.Text;
            worksheet.Cells[9, 3] = "Số lượng còn: " + txtSLCon.Text;
            worksheet.Cells[10, 3] = "Số lượng quá hạn: " + txtSLDGQuaHan.Text;
            worksheet.Cells[11, 3] = "Tổng giá trị: " + txtTongGiaTriSach.Text;

            //nhan vien
            worksheet.Cells[14, 3] = "*Thống kế nhân viên";
            worksheet.Cells[15, 3] = "Số lượng nhân viên: " + txtSLNhanVien.Text;

            //nha xuat ban
            worksheet.Cells[14, 5] = "*Thống kê nhà xuất bản";
            worksheet.Cells[15, 5] = "Số lượng nhà xuất bản: " + txtSLNhaXuatBan.Text;

            //doc gia
            worksheet.Cells[5, 5] = "*Thống kê độc giả";
            worksheet.Cells[6, 5] = "Số lượng độc giả: " + txtSLDocGia.Text;
            worksheet.Cells[7, 5] = "Số lượng độc giả đã mượn: " + txtSLDGMuon.Text;
            worksheet.Cells[8, 5] = "Số lượng độc giả quá hạn: " + txtSLDGQuaHan.Text;

            

            //p2: 2 bang danh sach: Danh sach doc gia qua han, Danh sach sach qua han
            //worksheet.Cells[14, 3] = "DANH SÁCH SÁCH QUÁ HẠN";
            //worksheet.Cells[16, 1] = "STT";
            //worksheet.Cells[16, 2] = "Mã ĐG";
            //worksheet.Cells[16, 3] = "Mã phiếu";
            //worksheet.Cells[16, 4] = "Mã sách";
            //worksheet.Cells[16, 5] = "Ngày mượn";
            //worksheet.Cells[16, 8] = "Ngày trả";
            //worksheet.Cells[16, 9] = "Ghi chú";
            //for (int i = 0; i < dataGridViewDSDGQuaHan.RowCount - 0; i++)
            //{
            //    for (int j = 0; j < 6; j++)
            //    {
            //        worksheet.Cells[i + 17, 1] = i + 1;
            //        worksheet.Cells[i + 17, j + 2] = dataGridViewDSDGQuaHan.Rows[i].Cells[j].Value;
            //    }
            //}



            // Dinh dang trang
            worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;
            worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            worksheet.PageSetup.LeftMargin = 0;
            worksheet.PageSetup.RightMargin = 0;
            worksheet.PageSetup.TopMargin = 0;
            worksheet.PageSetup.BottomMargin = 0;

            // Ding dang cot
            worksheet.Range["A1"].ColumnWidth = 14;
            worksheet.Range["B1"].ColumnWidth = 19;
            worksheet.Range["C1"].ColumnWidth = 24;
            worksheet.Range["D1"].ColumnWidth = 20;
            worksheet.Range["E1"].ColumnWidth = 8;
            worksheet.Range["F1"].ColumnWidth = 8;
            worksheet.Range["G1"].ColumnWidth = 8;
            worksheet.Range["H1"].ColumnWidth = 8;

            // Dinh dang font chu
            worksheet.Range["A1", "K100"].Font.Name = "Times New Roman";
            worksheet.Range["B2", "H2"].Font.Size = 18;
            worksheet.Range["A5", "H5"].Font.Size = 13;

            worksheet.Range["B2", "H2"].MergeCells = true;
            worksheet.Range["B2", "H2"].Font.Bold = true;
            worksheet.Range["B2", "H2"].Font.Italic = true;
            worksheet.Range["B2", "H2"].Font.Underline = true;

            worksheet.Range["A5", "H5"].Font.Bold = true;
            worksheet.Range["A14", "H14"].Font.Bold = true;
            worksheet.Range["E5", "G5"].MergeCells = true;
            worksheet.Range["E14", "G14"].MergeCells = true;
            worksheet.Range["E6", "G6"].MergeCells = true;
            worksheet.Range["E15", "G15"].MergeCells = true;
            worksheet.Range["E7", "G7"].MergeCells = true;
            worksheet.Range["E8", "G8"].MergeCells = true;

            //Ding dang cac dong text
            worksheet.Range["B2", "H2"].HorizontalAlignment = 3;
            
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
