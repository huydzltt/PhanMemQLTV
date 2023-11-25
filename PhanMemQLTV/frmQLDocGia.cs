using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace PhanMemQLTV
{
    public partial class frmQLDocGia : Form
    {
        public frmQLDocGia()
        {
            InitializeComponent();
        }

        // Khai báo 
        string chuoiKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConnection; // kết nối tới csdl
        private SqlDataAdapter myDataAdapter;   // Vận chuyển csdl qa DataSet
        private DataTable myTable;  // Dùng để lưu bảng lấy từ c#
        SqlCommand myCommand;   // Thực hiện cách lệnh truy vấn
        //public static string conString = "Data Source=NDH09121999;Initial Catalog=MHHDL_KhoaLuanQLTV;Integrated Security=True";
        //// Khoi tao
        //SqlConnection con = new SqlConnection(conString);

        // Phương thức kết nối
        private DataTable ketnoi(string truyvan)
        {
            myConnection = new SqlConnection(chuoiKetNoi);
            myConnection.Open();
            string thuchiencaulenh = truyvan;
            myCommand = new SqlCommand(thuchiencaulenh, myConnection);
            myDataAdapter = new SqlDataAdapter(myCommand);
            myTable = new DataTable();
            myDataAdapter.Fill(myTable);
            dataGridViewDSDocGia.DataSource = myTable;
            return myTable;
        }

        // Phương thức thiết lập Controls
        private void setControls(bool edit)
        {
            txtTenDG.Enabled = edit;
            dtmNgaySinh.Enabled = edit;
            cboGioiTinh.Enabled = edit;
            txtDiaChi.Enabled = edit;
            txtSoDT.Enabled = edit;
            txtTenTK.Enabled = edit;
            txtMK.Enabled = edit;
            txtGhiChu.Enabled = edit;
            cboLoaiDG.Enabled = edit;
        }

        // Load
        private void frmQLDocGia_Load(object sender, EventArgs e)
        {
            string cauTruyVan = "select * from tblDocGia";
            dataGridViewDSDocGia.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSDocGia.AutoGenerateColumns = false;
            myConnection.Close();
            setControls(false);
            dataGridViewDSDocGia.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtMaDG.Enabled = false;
        }

        // Phương thức hiển thị các thuộc tính bảng Độc Giả lên txt
        public string maDG, tenDG, gioiTinhDG, ngaySinhDG, diaChiDG, sdtDG, loaiDG, ghiChu, tenTK, mK;
        private void dataGridViewDSDocGia_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                txtMaDG.Text = myTable.Rows[row]["MaDG"].ToString();
                maDG = txtMaDG.Text;
                txtTenDG.Text = myTable.Rows[row]["TenDG"].ToString();
                tenDG = txtTenDG.Text;
                cboGioiTinh.Text = myTable.Rows[row]["GioiTinhDG"].ToString();
                gioiTinhDG = cboGioiTinh.Text;
                dtmNgaySinh.Text = myTable.Rows[row]["NgaySinhDG"].ToString();
                ngaySinhDG = dtmNgaySinh.Text;
                txtSoDT.Text = myTable.Rows[row]["SoDienThoaiDG"].ToString();
                sdtDG = txtSoDT.Text;
                txtDiaChi.Text = myTable.Rows[row]["DiaChiDG"].ToString();
                diaChiDG = txtDiaChi.Text;
                cboLoaiDG.Text = myTable.Rows[row]["LoaiDG"].ToString();
                loaiDG = cboLoaiDG.Text;
                txtGhiChu.Text = myTable.Rows[row]["GhiChu"].ToString();
                ghiChu = txtGhiChu.Text;
                txtTenTK.Text = myTable.Rows[row]["TenTaiKhoanDG"].ToString();
                tenTK = txtTenTK.Text;
                txtMK.Text = myTable.Rows[row]["MatKhauDG"].ToString();
                mK = txtMK.Text;
            }
            catch
            {

            }
        }

        // Phương thức tăng mã DG tự động
        public string setMaDG()
        {
            string cauTruyVan = "select * from tblDocGia";
            dataGridViewDSDocGia.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSDocGia.AutoGenerateColumns = false;
            myConnection.Close();
            string maTuDong = "";
            if (myTable.Rows.Count <= 0)
            {
                maTuDong = "DG001";
            }
            else
            {
                int k;
                maTuDong = "DG";
                k = Convert.ToInt32(myTable.Rows[myTable.Rows.Count - 1][0].ToString().Substring(2, 3));
                k = k + 1;
                if (k < 10)
                {
                    maTuDong = maTuDong + "00";
                }
                else if (k < 100)
                {
                    maTuDong = maTuDong + "0";
                }
                maTuDong = maTuDong + k.ToString();
            }
            return maTuDong;
        }

        // Phương thức thêm ĐG
        public int xuly;
        private void btnThem_Click(object sender, EventArgs e)
        {
            setControls(true);
            txtMaDG.Text = setMaDG();
            txtTenDG.Text = "";
            txtSoDT.Text = "";
            txtDiaChi.Text = "";
            cboGioiTinh.Text = "Nam";
            dtmNgaySinh.Text = "";
            cboLoaiDG.Text = "Bình thường";
            txtGhiChu.Text = "";
            txtTenTK.Text = txtMaDG.Text;
            txtTenTK.Enabled = false;
            txtMK.Text = "";
            txtTenDG.Focus();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnExportExcel.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            
            xuly = 0;
            dataGridViewDSDocGia.Enabled = false;
        }

        // Phương thức sửa thông tin độc giả
        private void suaDG()
        {
            setControls(true);
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            txtTenDG.Focus();
            dataGridViewDSDocGia.Enabled = false;
            txtTenTK.Enabled = false;
            xuly = 1;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            suaDG();
        }

        // Phương thức xóa độc giả
        private void xoaDG()
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn xóa độc giả này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    string xoadongsql = "delete from tblDocGia where MaDG='" + txtMaDG.Text + "'";
                    ketnoi(xoadongsql);
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    //try
                    //{
                    //    string tentaikhoan = frmDangNhap.tenTaiKhoan;
                    //    string hoten = frmDangNhap.HoTen;
                    //    con.Open();
                    //    //SqlCommand cmd = new SqlCommand("Insert into tblLogNhatKy values('" + DateTime.Now + "', N'" + hoten + "','" + tentaikhoan + "', N'Thêm mới nhân viên')", con);
                    //    string Query = string.Format("insert into tblNhatKyHoatDong(ThoiGian, NguoiTao, TaiKhoan, ThaoTac) values('{0}', N'{1}', N'{2}', N'{3}')", DateTime.Now, hoten, tentaikhoan, "Xoá độc giả" + txtTenDG.Text);
                    //    SqlCommand cmd = new SqlCommand(Query, con);
                    //    cmd.ExecuteNonQuery();
                    //    con.Close();
                    //}
                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show(ex.ToString(), "Đã có lỗi xảy ra.");
                    //}
                    //btnXoa.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại.\nĐộc Giả này đang mượn sách.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
            }
            string cauTruyVan = "select * from tblDocGia";
            dataGridViewDSDocGia.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSDocGia.AutoGenerateColumns = false;
            myConnection.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaDG();
        }

        // Lưu
        private void themDG()
        {
            try
            {
                string themdongsql = "insert into tblDocGia values ('" + txtMaDG.Text + "',N'" + txtTenDG.Text + "',N'" + cboGioiTinh.Text + "','" + dtmNgaySinh.Text + "','" + txtSoDT.Text + "',N'" + txtDiaChi.Text + "',N'" + cboLoaiDG.Text + "',N'" + txtGhiChu.Text + "','" + txtTenTK.Text + "','" + txtMK.Text + "')";
                ketnoi(themdongsql);
                MessageBox.Show("Thêm độc giả thành công.", "Thông Báo");
                //try
                //{
                //    string tentaikhoan = frmDangNhap.tenTaiKhoan;
                //    string hoten = frmDangNhap.HoTen;
                //    con.Open();
                //    //SqlCommand cmd = new SqlCommand("Insert into tblLogNhatKy values('" + DateTime.Now + "', N'" + hoten + "','" + tentaikhoan + "', N'Thêm mới nhân viên')", con);
                //    string Query = string.Format("insert into tblNhatKyHoatDong(ThoiGian, NguoiTao, TaiKhoan, ThaoTac) values('{0}', N'{1}', N'{2}', N'{3}')", DateTime.Now, hoten, tentaikhoan, "Thêm mới độc giả " + txtTenDG.Text);
                //    SqlCommand cmd = new SqlCommand(Query, con);
                //    cmd.ExecuteNonQuery();
                //    con.Close();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.ToString(), "Đã có lỗi xảy ra.");
                //}
                btnExportExcel.Enabled = true;
                myCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenDG.Text == "")
            {
                errTenDG.SetError(txtTenDG, "Vui lòng nhập tên ĐG.");
            }
            else
            {
                errTenDG.Clear();
            }

            if (txtSoDT.Text == "")
            {
                errSDT.SetError(txtSoDT, "Vui lòng nhập số ĐT");
            }
            else
            {
                errSDT.Clear();
            }

            if (txtDiaChi.Text == "")
            {
                errDC.SetError(txtDiaChi, "Vui lòng nhập địa chỉ");
            }
            else
            {
                errDC.Clear();
            }

            if (txtTenTK.Text == "")
            {
                errTenTK.SetError(txtTenTK, "Vui lòng nhập Tên TK");
            }
            else
            {
                errTenTK.Clear();
            }

            if (txtMK.Text == "")
            {
                errMK.SetError(txtMK, "Vui lòng nhập MK");
            }
            else
            {
                errMK.Clear();
            }

            if (cboGioiTinh.Text == "")
            {
                errGT.SetError(cboGioiTinh, "Vui lòng chọn Giới Tính");
            }
            else
            {
                errGT.Clear();
            }

            if (cboLoaiDG.Text == "")
            {
                errLoaiDG.SetError(cboLoaiDG, "Vui lòng nhập Loại ĐG");
            }
            else
            {
                errLoaiDG.Clear();
            }
            int ktSDT;
            bool isNumberSDT = int.TryParse(txtSoDT.Text, out ktSDT);
            if (isNumberSDT == false || txtSoDT.Text.Length > 12)
            {
                MessageBox.Show("Nhập SĐT không đúng.\nVui lòng nhập lại.");
            }
            if (txtMaDG.Text.Length > 0 && txtTenDG.Text.Length > 0 && txtDiaChi.Text.Length > 0 && isNumberSDT == true && dtmNgaySinh.Text.Length > 0 && cboGioiTinh.Text.Length > 0 && txtTenTK.Text.Length > 0 && txtMK.Text.Length > 0 && cboLoaiDG.Text.Length > 0)
            {
                if (xuly == 0)
                {
                    themDG();
                }
                else if (xuly == 1)
                {
                    try
                    {
                        string capnhatdongsql;
                        capnhatdongsql = "update tblDocGia set TenDG=N'" + txtTenDG.Text + "',GioiTinhDG=N'" + cboGioiTinh.Text + "',NgaySinhDG='" + dtmNgaySinh.Text + "',DiaChiDG=N'" + txtDiaChi.Text + "',SoDienThoaiDG='" + txtSoDT.Text + "',LoaiDG=N'" + cboLoaiDG.Text + "',GhiChu=N'" + txtGhiChu.Text + "',TenTaiKhoanDG='" + txtTenTK.Text + "',MatKhauDG='" + txtMK.Text + "' where MaDG='" + txtMaDG.Text + "'";
                        ketnoi(capnhatdongsql);
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công.", "Thông báo");
                        //try
                        //{
                        //    string tentaikhoan = frmDangNhap.tenTaiKhoan;
                        //    string hoten = frmDangNhap.HoTen;
                        //    con.Open();
                        //    //SqlCommand cmd = new SqlCommand("Insert into tblLogNhatKy values('" + DateTime.Now + "', N'" + hoten + "','" + tentaikhoan + "', N'Thêm mới nhân viên')", con);
                        //    string Query = string.Format("insert into tblNhatKyHoatDong(ThoiGian, NguoiTao, TaiKhoan, ThaoTac) values('{0}', N'{1}', N'{2}', N'{3}')", DateTime.Now, hoten, tentaikhoan, "Sửa thông tin độc giả " + txtTenDG.Text);
                        //    SqlCommand cmd = new SqlCommand(Query, con);
                        //    cmd.ExecuteNonQuery();
                        //    con.Close();
                        //}
                        //catch (Exception ex)
                        //{
                        //    MessageBox.Show(ex.ToString(), "Đã có lỗi xảy ra.");
                        //}
                    }
                    catch
                    {
                        MessageBox.Show("Sửa thất bại.\nVui lòng kiểm tra lại dữ liệu.", "Thông báo");
                    }
                }
                string cauTruyVan = "select * from tblDocGia";
                dataGridViewDSDocGia.DataSource = ketnoi(cauTruyVan);
                dataGridViewDSDocGia.AutoGenerateColumns = false;
                myConnection.Close();
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                setControls(false);
                dataGridViewDSDocGia.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo");
                if (txtTenDG.Text.Length == 0)
                    txtTenDG.Focus();
                else if (txtDiaChi.Text.Length == 0)
                    txtDiaChi.Focus();
                else if (txtSoDT.Text.Length == 0)
                    txtSoDT.Focus();
                else if (txtTenTK.Text.Length == 0)
                    txtTenTK.Focus();
                else if (txtMK.Text.Length == 0)
                    txtMK.Focus();
            }
        }

        // Phương thức nút hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaDG.Text = maDG;
            txtTenDG.Text = tenDG;
            txtSoDT.Text = sdtDG;
            txtDiaChi.Text = diaChiDG;
            cboGioiTinh.Text = gioiTinhDG;
            dtmNgaySinh.Text = ngaySinhDG;
            cboLoaiDG.Text = loaiDG;
            txtGhiChu.Text = ghiChu;
            txtTenTK.Text = tenTK;
            txtMK.Text = mK;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnExportExcel.Enabled = true;
            setControls(false);
            dataGridViewDSDocGia.Enabled = true;
            errMK.Clear();
            errSDT.Clear();
            errTenTK.Clear();
            errTenDG.Clear();
            errDC.Clear();
            errLoaiDG.Clear();
            errGT.Clear();
        }

        // Thoát form
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Tìm kiếm 
        private void txtNDTimKiem_TextChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            //btnSua.Enabled = false;
            if (radMaDG.Checked)
            {
                string timkiem = "select * from tblDocGia where MaDG like '%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiem);
                myCommand.ExecuteNonQuery();
                dataGridViewDSDocGia.DataSource = ketnoi(timkiem);
                dataGridViewDSDocGia.AutoGenerateColumns = false;
                myConnection.Close();
            }
            else if (radTenDG.Checked)
            {
                string timkiem = "select * from tblDocGia where TenDG like N'%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiem);
                myCommand.ExecuteNonQuery();
                dataGridViewDSDocGia.DataSource = ketnoi(timkiem);
                dataGridViewDSDocGia.AutoGenerateColumns = false;
                myConnection.Close();
            }
        }

        // Phương thức nút Load DS
        private void btnLoadDS_Click(object sender, EventArgs e)
        {
            lblNhapTenDG.Text = "";
            lblNhapNgaySinh.Text = "";
            lblNhapGioiTinh.Text = "";
            lblNhapSDT.Text = "";
            lblNhapDiaChi.Text = "";
            setControls(false);
            txtNDTimKiem.Text = "";
            string cauTruyVan = "select * from tblDocGia";
            dataGridViewDSDocGia.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSDocGia.AutoGenerateColumns = false;
            myConnection.Close();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        // Xuat danh sach doc gia ra Excel
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
            worksheet.Cells[2, 3] = "THƯ VIỆN HUFLIT";
            worksheet.Cells[4, 3] = "DANH SÁCH ĐỘC GIẢ";

            worksheet.Cells[6, 1] = "STT";
            worksheet.Cells[6, 2] = "Mã ĐG";
            worksheet.Cells[6, 3] = "Tên ĐG";
            worksheet.Cells[6, 4] = "Giới tính";
            worksheet.Cells[6, 5] = "Ngày sinh";
            worksheet.Cells[6, 6] = "Số ĐTĐG";
            worksheet.Cells[6, 7] = "Địa chỉ";
            worksheet.Cells[6, 8] = "Loại ĐG";
            worksheet.Cells[6, 9] = "Ghi chú";
            worksheet.Cells[6, 10] = "Tên TK";
            worksheet.Cells[6, 11] = "Mật khẩu";
            for (int i = 0; i < dataGridViewDSDocGia.RowCount - 0; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    worksheet.Cells[i + 7, 1] = i + 1;
                    worksheet.Cells[i + 7, j + 2] = dataGridViewDSDocGia.Rows[i].Cells[j].Value;
                }
            }

            // Dinh dang trang
            worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;
            worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            worksheet.PageSetup.LeftMargin = 0;
            worksheet.PageSetup.RightMargin = 0;
            worksheet.PageSetup.TopMargin = 0.5;
            worksheet.PageSetup.BottomMargin = 0;

            // Ding dang cot
            worksheet.Range["A1"].ColumnWidth = 4;
            worksheet.Range["B1"].ColumnWidth = 7;
            worksheet.Range["C1"].ColumnWidth = 21;
            worksheet.Range["D1"].ColumnWidth = 9;
            worksheet.Range["E1"].ColumnWidth = 10;
            worksheet.Range["F1"].ColumnWidth = 11;
            worksheet.Range["G1"].ColumnWidth = 26;
            worksheet.Range["H1"].ColumnWidth = 12;
            worksheet.Range["I1"].ColumnWidth = 9;
            worksheet.Range["J1"].ColumnWidth = 7;
            worksheet.Range["K1"].ColumnWidth = 9;

            // Dinh dang font chu
            worksheet.Range["A1", "K100"].Font.Name = "Times New Roman";
            worksheet.Range["B2", "J2"].Font.Size = 18;
            worksheet.Range["C4", "I4"].Font.Size = 14;
            worksheet.Range["A6", "K16"].Font.Size = 12;
            worksheet.Range["B2", "J2"].MergeCells = true;
            worksheet.Range["B2", "J2"].Font.Bold = true;
            worksheet.Range["B2", "J2"].Font.Italic = true;
            worksheet.Range["B2", "J2"].Font.Underline = true;
            worksheet.Range["C4", "I4"].MergeCells = true;
            worksheet.Range["C4", "I4"].Font.Bold = true;
            worksheet.Range["C4", "I4"].Font.Bold = true;
            worksheet.Range["A6", "K6"].Font.Bold = true;

            //Ding dang cac dong text
            worksheet.Range["C2", "J2"].HorizontalAlignment = 3;
            worksheet.Range["B4", "J4"].HorizontalAlignment = 3;
            worksheet.Range["A6", "K6"].HorizontalAlignment = 3;
            worksheet.Range["A6", "A100"].HorizontalAlignment = 3;
            worksheet.Range["E6", "E100"].HorizontalAlignment = 4;
            worksheet.Range["F6", "F100"].HorizontalAlignment = 4;
            worksheet.Range["I6", "I100"].HorizontalAlignment = 3;
            worksheet.Range["J6", "J100"].HorizontalAlignment = 3;
            worksheet.Range["K6", "K100"].HorizontalAlignment = 3;
        }
      
    }
}
