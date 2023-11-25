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
    public partial class frmQLNhanVien : Form
    {
        public frmQLNhanVien()
        {
            InitializeComponent();
        }

        // Khai bao
        string chuoiKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConnection; // kết nối tới csdl
        private SqlDataAdapter myDataAdapter;   // Vận chuyển csdl qa DataSet
        private DataTable myTable;  // Dùng để lưu bảng lấy từ c#
        SqlCommand myCommand;   // Thực hiện câu lệnh truy vấn
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
            dataGridViewDSNhanVien.DataSource = myTable;
            return myTable;
        }

        // Phuong thuc thiet lap controls
        private void setControls(bool edit) 
        {
            txtTenNV.Enabled = true;
            cboGioiTinhNV.Enabled = true;
            dtmNgaySinhNV.Enabled = true;
            txtDiaChiNV.Enabled = true;
            txtSoDTNV.Enabled = true;
            cboLoaiNV.Enabled = true;
            txtGhiChu.Enabled = true;
        }

        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            string cauTruyVan = "select * from tblNhanVien";
            dataGridViewDSNhanVien.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSNhanVien.AutoGenerateColumns = false;
            myConnection.Close();
            setControls(false);
            dataGridViewDSNhanVien.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtMaNV.Enabled = false;
        }

        // Phương thức hiển thị các thuộc tính bảng Nhân Viên lên txt
        public string maNV, tenNV, gioiTinhNV, ngaySinhNV, diaChiNV, sdtNV, loaiNV, ghiChu;

       

        private void dataGridViewDSNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                txtMaNV.Text = myTable.Rows[row]["MaNV"].ToString();
                maNV = txtMaNV.Text;
                txtTenNV.Text = myTable.Rows[row]["TenNV"].ToString();
                tenNV = txtMaNV.Text;
                cboGioiTinhNV.Text = myTable.Rows[row]["GioiTinhNV"].ToString();
                gioiTinhNV = cboGioiTinhNV.Text;
                dtmNgaySinhNV.Text = myTable.Rows[row]["NgaySinhNV"].ToString();
                ngaySinhNV = dtmNgaySinhNV.Text;
                txtSoDTNV.Text = myTable.Rows[row]["SoDienThoaiNV"].ToString();
                sdtNV = txtSoDTNV.Text;
                txtDiaChiNV.Text = myTable.Rows[row]["DiaChiNV"].ToString();
                diaChiNV = txtDiaChiNV.Text;
                cboLoaiNV.Text = myTable.Rows[row]["LoaiNV"].ToString();
                loaiNV = cboLoaiNV.Text;
                txtGhiChu.Text = myTable.Rows[row]["GhiChu"].ToString();
                ghiChu = txtGhiChu.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Đã có lỗi xảy ra.");
            }
        }

        // phuong thuc them
        public int xuly;
        private void btnThem_Click(object sender, EventArgs e)
        {
            setControls(true);
            txtMaNV.Text = setMaNV();
            txtTenNV.Text = "";
            txtSoDTNV.Text = "";
            txtDiaChiNV.Text = "";
            cboGioiTinhNV.Text = "Nam";
            dtmNgaySinhNV.Text = "";
            cboLoaiNV.Text = "";
            txtGhiChu.Text = "";
            txtTenNV.Focus();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnXoaDSNV.Enabled = false;
            btnXuatExcel.Enabled = false;
            xuly = 0;
            dataGridViewDSNhanVien.Enabled = false;

        }

        // Phương thức tăng mã NV tự động
        public string setMaNV()
        {
            string cauTruyVan = "select * from tblNhanVien";
            dataGridViewDSNhanVien.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSNhanVien.AutoGenerateColumns = false;
            myConnection.Close();
            string maTuDong = "";
            if (myTable.Rows.Count <= 0)
            {
                maTuDong = "NV001";
            }
            else
            {
                int k;
                maTuDong = "NV";
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

      

        // Phương thức sửa thông tin nhân viên
        private void suaNV()
        {
            setControls(true);
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            txtTenNV.Focus();
            dataGridViewDSNhanVien.Enabled = false;
            xuly = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            suaNV();
            btnXuatExcel.Enabled = false;
        }


        // phuong thuc xoa nhan vien
        private void xoaNV() 
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes) 
            {
                try
                {
                    string xoadongsql = "delete from tblNhanVien where MaNV='" + txtMaNV.Text + "'";
                    ketnoi(xoadongsql);
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Xoá thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //try
                    //{
                    //    string tentaikhoan = frmDangNhap.tenTaiKhoan;
                    //    string hoten = frmDangNhap.HoTen;
                    //    con.Open();
                    //    //SqlCommand cmd = new SqlCommand("Insert into tblLogNhatKy values('" + DateTime.Now + "', N'" + hoten + "','" + tentaikhoan + "', N'Thêm mới nhân viên')", con);
                    //    string Query = string.Format("insert into tblNhatKyHoatDong(ThoiGian, NguoiTao, TaiKhoan, ThaoTac) values('{0}', N'{1}', N'{2}', N'{3}')", DateTime.Now, hoten, tentaikhoan, "Xoá nhân viên " + txtTenNV.Text);
                    //    SqlCommand cmd = new SqlCommand(Query, con);
                    //    cmd.ExecuteNonQuery();
                    //    con.Close();
                    //}
                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show(ex.ToString(), "Đã có lỗi xảy ra.");
                    //}
                }
                catch (Exception)
                {
                    MessageBox.Show("Xoá thất bại.", "Thông báo");
                }
            }
            string cauTruyVan = "select * from tblNhanVien";
            dataGridViewDSNhanVien.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSNhanVien.AutoGenerateColumns = false;
            myConnection.Close();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaNV();
        }

        // luu
        private void themNV() 
        {
            try
            {
                string themdongsql = "insert into tblNhanVien values ('" + txtMaNV.Text + "',N'" + txtTenNV.Text + "',N'" + cboGioiTinhNV.Text + "','" + dtmNgaySinhNV.Text + "','" + txtSoDTNV.Text + "',N'" + txtDiaChiNV.Text + "',N'" + cboLoaiNV.Text + "',N'" + txtGhiChu.Text + "')";
                ketnoi(themdongsql);
                MessageBox.Show("Thêm nhân viên thành công.", "Thông báo");
                //try
                //{
                //    string tentaikhoan = frmDangNhap.tenTaiKhoan;
                //    string hoten = frmDangNhap.HoTen;
                //    con.Open();
                //    string Query = string.Format("insert into tblNhatKyHoatDong(ThoiGian, NguoiTao, TaiKhoan, ThaoTac) values('{0}', N'{1}', N'{2}', N'{3}')", DateTime.Now, hoten, tentaikhoan, "Thêm mới nhân viên " + txtTenNV.Text);
                //    SqlCommand cmd = new SqlCommand(Query, con);
                //    cmd.ExecuteNonQuery();
                //    con.Close();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.ToString(), "Đã có lỗi xảy ra.");
                //}
                btnXuatExcel.Enabled = true;
                btnXoaDSNV.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Đã có lỗi xảy ra.");
            }


        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text == "") 
            {
                errTenNV.SetError(txtTenNV, "Vui lòng nhập tên NV.");
            }
            else
            {
                errTenNV.Clear();
            }

            if (txtSoDTNV.Text == "")
            {
                errSDT.SetError(txtSoDTNV, "Vui lòng nhập số ĐTNV.");
            }
            else
            {
                errSDT.Clear();
            }

            if (txtDiaChiNV.Text == "")
            {
                errDC.SetError(txtDiaChiNV, "Vui lòng nhập địa chỉ.");
            }
            else
            {
                errDC.Clear();
            }

            if (cboGioiTinhNV.Text == "")
            {
                errGT.SetError(cboGioiTinhNV, "Vui lòng chọn giới tính NV.");
            }
            else
            {
                errGT.Clear();
            }

            if (cboLoaiNV.Text == "")
            {
                errLoaiNV.SetError(cboLoaiNV, "Vui lòng nhập loại NV.");
            }
            else
            {
                errLoaiNV.Clear();
            }
            int ktSDT;
            bool isNumberSDT = int.TryParse(txtSoDTNV.Text, out ktSDT);
            if (isNumberSDT == false || txtSoDTNV.Text.Length > 12)
            {
                MessageBox.Show("Nhập SĐT không đúng.\nVui lòng nhập lại.");
            }
            if (txtMaNV.Text.Length > 0 && txtTenNV.Text.Length > 0 && txtDiaChiNV.Text.Length > 0 && isNumberSDT == true && dtmNgaySinhNV.Text.Length > 0 && cboGioiTinhNV.Text.Length > 0 && cboLoaiNV.Text.Length > 0)
            {
                if (xuly == 0)
                {
                    themNV();
                }
                else if (xuly == 1)
                {
                    try
                    {
                        string capnhatdongsql;
                        capnhatdongsql = "update tblNhanVien set TenNV=N'" + txtTenNV.Text + "',GioiTinhNV=N'" + cboGioiTinhNV.Text + "',NgaySinhNV='" + dtmNgaySinhNV.Text + "',DiaChiNV=N'" + txtDiaChiNV.Text + "',SoDienThoaiNV='" + txtSoDTNV.Text + "',LoaiNV=N'" + cboLoaiNV.Text + "',GhiChu=N'" + txtGhiChu.Text + "' where MaNV='" + txtMaNV.Text + "'";
                        ketnoi(capnhatdongsql);
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công.", "Thông Báo");
                        //try
                        //{
                        //    string tentaikhoan = frmDangNhap.tenTaiKhoan;
                        //    string hoten = frmDangNhap.HoTen;
                        //    con.Open();
                        //    //SqlCommand cmd = new SqlCommand("Insert into tblLogNhatKy values('" + DateTime.Now + "', N'" + hoten + "','" + tentaikhoan + "', N'Thêm mới nhân viên')", con);
                        //    string Query = string.Format("insert into tblNhatKyHoatDong(ThoiGian, NguoiTao, TaiKhoan, ThaoTac) values('{0}', N'{1}', N'{2}', N'{3}')", DateTime.Now, hoten, tentaikhoan, "Sửa thông tin nhân viên " + txtTenNV.Text);
                        //    SqlCommand cmd = new SqlCommand(Query, con);
                        //    cmd.ExecuteNonQuery();
                        //    con.Close();
                        //}
                        //catch (Exception ex)
                        //{
                        //    MessageBox.Show(ex.ToString(), "Đã có lỗi xảy ra.");
                        //}
                        btnXuatExcel.Enabled = true;
                    }
                    catch
                    {
                        MessageBox.Show("Sửa thất bại.\nVui lòng kiểm tra lại dữ liệu.", "Thông Báo");
                    }
                }
                string cauTruyVan = "select * from tblNhanVien";
                dataGridViewDSNhanVien.DataSource = ketnoi(cauTruyVan);
                dataGridViewDSNhanVien.AutoGenerateColumns = false;
                myConnection.Close();
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                setControls(false);
                dataGridViewDSNhanVien.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông Báo");
                if (txtTenNV.Text.Length == 0)
                    txtTenNV.Focus();
                else if (txtDiaChiNV.Text.Length == 0)
                    txtDiaChiNV.Focus();
                else if (txtSoDTNV.Text.Length == 0)
                    txtSoDTNV.Focus();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = maNV;
            txtTenNV.Text = tenNV;
            txtSoDTNV.Text = sdtNV;
            txtDiaChiNV.Text = diaChiNV;
            cboGioiTinhNV.Text = gioiTinhNV;
            dtmNgaySinhNV.Text = ngaySinhNV;
            cboLoaiNV.Text = loaiNV;
            txtGhiChu.Text = ghiChu;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnXuatExcel.Enabled = true;
            setControls(false);
            dataGridViewDSNhanVien.Enabled = true;
            errSDT.Clear();
            errTenNV.Clear();
            errDC.Clear();
            errLoaiNV.Clear();
            errGT.Clear();
        }

        private void txtNDTimKiem_TextChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            if (radMaNV.Checked)
            {
                string timkiem = "select * from tblNhanVien where MaNV like '%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiem);
                myCommand.ExecuteNonQuery();
                dataGridViewDSNhanVien.DataSource = ketnoi(timkiem);
                dataGridViewDSNhanVien.AutoGenerateColumns = false;
                myConnection.Close();
            }
            else if (radTenNV.Checked)
            {
                string timkiem = "select * from tblNhanVien where TenNV like N'%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiem);
                myCommand.ExecuteNonQuery();
                dataGridViewDSNhanVien.DataSource = ketnoi(timkiem);
                dataGridViewDSNhanVien.AutoGenerateColumns = false;
                myConnection.Close();
            }
        }

        // xuat excel
        private void btnXuatExcel_Click(object sender, EventArgs e)
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
            worksheet.Cells[4, 2] = "DANH SÁCH NHÂN VIÊN";

            worksheet.Cells[6, 1] = "STT";
            worksheet.Cells[6, 2] = "Mã nhân viên";
            worksheet.Cells[6, 3] = "Tên nhân viên";
            worksheet.Cells[6, 4] = "Giới tính";
            worksheet.Cells[6, 5] = "Ngày sinh";
            worksheet.Cells[6, 6] = "Số ĐTNV";
            worksheet.Cells[6, 7] = "Địa chỉ";
            worksheet.Cells[6, 8] = "Loại NV";
            worksheet.Cells[6, 9] = "Ghi chú";
            for (int i = 0; i < dataGridViewDSNhanVien.RowCount - 0; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    worksheet.Cells[i + 7, 1] = i + 1;
                    worksheet.Cells[i + 7, j + 2] = dataGridViewDSNhanVien.Rows[i].Cells[j].Value;
                }
            }

            // Dinh dang trang
            worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;
            worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            worksheet.PageSetup.LeftMargin = 1.25;
            worksheet.PageSetup.RightMargin = 0.25;
            worksheet.PageSetup.TopMargin = 0.5;
            worksheet.PageSetup.BottomMargin = 0;

            // Ding dang cot
            worksheet.Range["A1"].ColumnWidth = 8;
            worksheet.Range["B1"].ColumnWidth = 12;
            worksheet.Range["C1"].ColumnWidth = 18;
            worksheet.Range["D1"].ColumnWidth = 9;
            worksheet.Range["E1"].ColumnWidth = 11;
            worksheet.Range["F1"].ColumnWidth = 11;
            worksheet.Range["G1"].ColumnWidth = 9;
            worksheet.Range["H1"].ColumnWidth = 10;
            worksheet.Range["I1"].ColumnWidth = 9;

            // Dinh dang font chu
            worksheet.Range["A1", "K100"].Font.Name = "Times New Roman";
            worksheet.Range["B2", "H2"].Font.Size = 18;
            worksheet.Range["B4", "H4"].Font.Size = 14;
            worksheet.Range["A6", "I6"].Font.Size = 12;
            worksheet.Range["B2", "H2"].MergeCells = true;
            worksheet.Range["B2", "H2"].Font.Bold = true;
            worksheet.Range["B2", "H2"].Font.Italic = true;
            worksheet.Range["B2", "H2"].Font.Underline = true;
            worksheet.Range["B4", "H4"].MergeCells = true;
            worksheet.Range["B4", "H4"].Font.Bold = true;
            worksheet.Range["A6", "I6"].Font.Bold = true;

            //Ding dang cac dong text
            worksheet.Range["B2", "H2"].HorizontalAlignment = 3;
            worksheet.Range["B4", "H4"].HorizontalAlignment = 3;
            worksheet.Range["A6", "I6"].HorizontalAlignment = 3;
            worksheet.Range["A6", "A100"].HorizontalAlignment = 3;
            worksheet.Range["E6", "E100"].HorizontalAlignment = 4; // phia ben phai
            worksheet.Range["F6", "F100"].HorizontalAlignment = 3;
            worksheet.Range["I6", "I100"].HorizontalAlignment = 3;
            worksheet.Range["J6", "J100"].HorizontalAlignment = 3;
        }

        //Phuong thuc xoa danh sach cac cuon sach
        private void xoaDSNV()
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn xóa danh sách nhân viên này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    string xoadongSql;
                    xoadongSql = "DELETE FROM tblNhanVien";
                    ketnoi(xoadongSql);
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công.", "Thông báo");
                    //try
                    //{
                    //    string tentaikhoan = frmDangNhap.tenTaiKhoan;
                    //    string hoten = frmDangNhap.HoTen;
                    //    con.Open();
                    //    //SqlCommand cmd = new SqlCommand("Insert into tblLogNhatKy values('" + DateTime.Now + "', N'" + hoten + "','" + tentaikhoan + "', N'Thêm mới nhân viên')", con);
                    //    string Query = string.Format("insert into tblNhatKyHoatDong(ThoiGian, NguoiTao, TaiKhoan, ThaoTac) values('{0}', N'{1}', N'{2}', N'{3}')", DateTime.Now, hoten, tentaikhoan, "Xoá danh sách nhân viên");
                    //    SqlCommand cmd = new SqlCommand(Query, con);
                    //    cmd.ExecuteNonQuery();
                    //    con.Close();
                    //}
                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show(ex.ToString(), "Đã có lỗi xảy ra.");
                    //}
                    txtMaNV.Clear();
                    txtTenNV.Clear();
                    txtDiaChiNV.Clear();
                    txtSoDTNV.Clear();
                    txtGhiChu.Clear();
                }
                catch
                {
                    MessageBox.Show("Xóa danh sách thất bại.\nCó sách đang được mượn.", "Thông báo");
                }
            }
            string cauTruyVan = "select * from tblSach";
            dataGridViewDSNhanVien.DataSource = ketnoi(cauTruyVan);
            myConnection.Close();
        }

        private void btnXoaDSNV_Click(object sender, EventArgs e)
        {
            if (txtMaNV.TextLength == 0)
            {
                MessageBox.Show("Không có danh sách cần xoá.\nVui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                xoaDSNV();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
