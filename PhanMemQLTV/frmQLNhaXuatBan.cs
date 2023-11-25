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
    public partial class frmQLNhaXuatBan : Form
    {
        public frmQLNhaXuatBan()
        {
            InitializeComponent();
        }

        // Khai báo 
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
            dataGridViewDSNhaXuatBan.DataSource = myTable;
            return myTable;
        }

        // Phuong thuc thiet lap Controls
        private void setControls(bool edit)
        {
            txtTenNXB.Enabled = edit;
            txtEmail.Enabled = edit;
            txtSoDTNXB.Enabled = edit;
            txtSoFax.Enabled = edit;
            txtDiaChiNXB.Enabled = edit;
            txtTrangThai.Enabled = edit;
            txtGhiChu.Enabled = edit;
        }

        private void frmQLNhaXuatBan_Load(object sender, EventArgs e)
        {
            string cauTruyVan = "select * from tblNhaXuatBan";
            dataGridViewDSNhaXuatBan.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSNhaXuatBan.AutoGenerateColumns = false;
            myConnection.Close();
            setControls(false);
            dataGridViewDSNhaXuatBan.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtMaNXB.Enabled = false;
        }

        // Phuong thuc hien thi cac thuoc tinh bang Nha Xuat Ban len txt
        public string maNXB, tenNXB, emailNXB, sdtNXB, soFax, diaChiNXB, trangThai, ghiChu;
  
        private void dataGridViewDSNhaXuatBan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                txtMaNXB.Text = myTable.Rows[row]["MaNXB"].ToString();
                maNXB = txtMaNXB.Text;
                txtTenNXB.Text = myTable.Rows[row]["TenNXB"].ToString();
                tenNXB = txtMaNXB.Text;
                txtEmail.Text = myTable.Rows[row]["Email"].ToString();
                emailNXB = txtEmail.Text;
                txtSoDTNXB.Text = myTable.Rows[row]["SoDienThoaiNXB"].ToString();
                sdtNXB = txtSoDTNXB.Text;
                txtSoFax.Text = myTable.Rows[row]["SoFax"].ToString();
                soFax = txtSoFax.Text;
                txtDiaChiNXB.Text = myTable.Rows[row]["DiaChiNXB"].ToString();
                diaChiNXB = txtDiaChiNXB.Text;
                txtTrangThai.Text = myTable.Rows[row]["TrangThai"].ToString();
                trangThai = txtTrangThai.Text;
                txtGhiChu.Text = myTable.Rows[row]["GhiChu"].ToString();
                ghiChu = txtGhiChu.Text;
            }
            catch
            {

            }
        }

        // Phuong thuc tang ma tư dong nha xuat ban

        //public string setMaNXB()
        //{
        //    int count = 0;
        //    count = dataGridViewDSNhaXuatBan.Rows.Count;
        //    string chuoi = "";
        //    int chuoi2 = 0;
        //    chuoi = Convert.ToString(dataGridViewDSNhaXuatBan.Rows[count - 2].Cells[0].Value);
        //    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3))); // Loai bo ky tu NXB
        //    if (chuoi2 + 1 < 10)
        //    {
        //        txtMaNXB.Text = "NXB00" + (chuoi2 + 1).ToString();
        //    }
        //    else if (chuoi2 + 1 < 100)
        //    {
        //        txtMaNXB.Text = "NXB0" + (chuoi2 + 1).ToString();
        //    }
        //    return chuoi;
        //}

        // Phuong thuc tang ma tu dong nha xuat ban
        public string setMaNXB()
        {
            string cauTruyVan = "select * from tblNhaXuatBan";
            dataGridViewDSNhaXuatBan.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSNhaXuatBan.AutoGenerateColumns = false;
            myConnection.Close();
            string maTuDong = "";
            if (myTable.Rows.Count <= 0)
            {
                maTuDong = "NXB001";
            }
            else
            {
                int k;
                maTuDong = "NXB";
                k = Convert.ToInt32(myTable.Rows[myTable.Rows.Count - 1][0].ToString().Substring(3, 3));
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



        //Phuong thuc them NXB
        public int xuly;

        private void btnThem_Click(object sender, EventArgs e)
        {
            setControls(true);
            txtMaNXB.Text = setMaNXB();
            txtTenNXB.Text = "";
            txtSoDTNXB.Text = "";
            txtDiaChiNXB.Text = "";
            txtEmail.Text = "";
            txtSoFax.Text = "";
            txtTrangThai.Text = "";         
            txtGhiChu.Text = "";
            txtTenNXB.Focus();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnExportExcel.Enabled = false;
            xuly = 0;
            dataGridViewDSNhaXuatBan.Enabled = false;
        }
    
        //Phuong thuc sua thong tin nha xuat ban
        private void suaNXB()
        {
            setControls(true);
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            txtTenNXB.Focus();
            dataGridViewDSNhaXuatBan.Enabled = false;
            xuly = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            suaNXB();
            btnExportExcel.Enabled = false;
        }

        //Phuong thuc xoa nha xuat ban

        private void xoaNXB()
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà xuất bản này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    string xoadongsql = "delete from tblNhaXuatBan where MaNXB='" + txtMaNXB.Text + "'";
                    ketnoi(xoadongsql);
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công.", "Thông báo");
                    //try
                    //{
                    //    string tentaikhoan = frmDangNhap.tenTaiKhoan;
                    //    string hoten = frmDangNhap.HoTen;
                    //    con.Open();
                    //    //SqlCommand cmd = new SqlCommand("Insert into tblLogNhatKy values('" + DateTime.Now + "', N'" + hoten + "','" + tentaikhoan + "', N'Thêm mới nhân viên')", con);
                    //    string Query = string.Format("insert into tblNhatKyHoatDong(ThoiGian, NguoiTao, TaiKhoan, ThaoTac) values('{0}', N'{1}', N'{2}', N'{3}')", DateTime.Now, hoten, tentaikhoan, "Xoá nhà xuất bản" + txtTenNXB.Text);
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
                    MessageBox.Show("Xóa thất bại.\nVui lòng kiểm tra lại.", "Thông báo");
                }
            }
            string cauTruyVan = "select * from tblNhaXuatBan";
            dataGridViewDSNhaXuatBan.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSNhaXuatBan.AutoGenerateColumns = false;
            myConnection.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaNXB();
        }

        // luu
        private void themNXB()
        {         
            try
            {
                string themdongsql = "insert into tblNhaXuatBan values ('" + txtMaNXB.Text + "',N'" + txtTenNXB.Text + "',N'" + txtEmail.Text + "','" + txtSoDTNXB.Text + "','" + txtSoFax.Text + "',N'" + txtDiaChiNXB.Text + "',N'" + txtTrangThai.Text + "',N'" + txtGhiChu.Text + "')";
                ketnoi(themdongsql);
                MessageBox.Show("Thêm nhà xuất bản thành công.", "Thông báo");
                //try
                //{
                //    string tentaikhoan = frmDangNhap.tenTaiKhoan;
                //    string hoten = frmDangNhap.HoTen;
                //    con.Open();
                //    //SqlCommand cmd = new SqlCommand("Insert into tblLogNhatKy values('" + DateTime.Now + "', N'" + hoten + "','" + tentaikhoan + "', N'Thêm mới nhân viên')", con);
                //    string Query = string.Format("insert into tblNhatKyHoatDong(ThoiGian, NguoiTao, TaiKhoan, ThaoTac) values('{0}', N'{1}', N'{2}', N'{3}')", DateTime.Now, hoten, tentaikhoan, "Thêm mới nhà xuất bản" + txtTenNXB.Text);
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
            catch
            {

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenNXB.Text == "")
            {
                errTenNXB.SetError(txtTenNXB, "Vui long nhap ten NXB.");
            }
            else
            {
                errTenNXB.Clear();
            }

            if (txtSoDTNXB.Text == "")
            {
                errSDTNXB.SetError(txtSoDTNXB, "Vui lòng nhập số ĐTNXB.");
            }
            else
            {
                errSDTNXB.Clear();
            }

            if (txtDiaChiNXB.Text == "")
            {
                errDCNXB.SetError(txtDiaChiNXB, "Vui lòng nhập địa chỉ.");
            }
            else
            {
                errDCNXB.Clear();
            }

            if (txtEmail.Text == "")
            {
                errEmail.SetError(txtEmail, "Vui lòng nhập email.");
            }
            else
            {
                errEmail.Clear();
            }

            if (txtSoFax.Text == "")
            {
                errSoFax.SetError(txtSoFax, "Vui lòng nhập so fax.");
            }
            else
            {
                errSoFax.Clear();
            }
            int ktSDT;
            bool isNumberSDT = int.TryParse(txtSoDTNXB.Text, out ktSDT);
            if (isNumberSDT == false || txtSoDTNXB.Text.Length > 12)
            {
                MessageBox.Show("Nhập SĐT không đúng.\nVui lòng nhập lại.");
            }
            if (txtMaNXB.Text.Length > 0 && txtTenNXB.Text.Length > 0 && txtDiaChiNXB.Text.Length > 0 && isNumberSDT == true && txtEmail.Text.Length > 0 && txtSoFax.Text.Length > 0 && txtTrangThai.Text.Length > 0)
            {
                if (xuly == 0)
                {
                    themNXB();
                }
                else if (xuly == 1)
                {
                    try
                    {
                        string capnhatdongsql;
                        capnhatdongsql = "update tblNhaXuatban set TenNXB=N'" + txtTenNXB.Text + "',Email=N'" + txtEmail.Text + "',SoDienThoaiNXB='" + txtSoDTNXB.Text + "',SoFax='" + txtSoFax.Text + "',DiaChiNXB=N'" + txtDiaChiNXB.Text + "',TrangThai=N'" + txtTrangThai.Text + "',GhiChu=N'" + txtGhiChu.Text + "' where MaNXB='" + txtMaNXB.Text + "'";
                        ketnoi(capnhatdongsql);
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công.", "Thông báo");
                        //try
                        //{
                        //    string tentaikhoan = frmDangNhap.tenTaiKhoan;
                        //    string hoten = frmDangNhap.HoTen;
                        //    con.Open();
                        //    //SqlCommand cmd = new SqlCommand("Insert into tblLogNhatKy values('" + DateTime.Now + "', N'" + hoten + "','" + tentaikhoan + "', N'Thêm mới nhân viên')", con);
                        //    string Query = string.Format("insert into tblNhatKyHoatDong(ThoiGian, NguoiTao, TaiKhoan, ThaoTac) values('{0}', N'{1}', N'{2}', N'{3}')", DateTime.Now, hoten, tentaikhoan, "Sửa thông tin nhà xuất bản" + txtTenNXB.Text);
                        //    SqlCommand cmd = new SqlCommand(Query, con);
                        //    cmd.ExecuteNonQuery();
                        //    con.Close();
                        //}
                        //catch (Exception ex)
                        //{
                        //    MessageBox.Show(ex.ToString(), "Đã có lỗi xảy ra.");
                        //}
                        btnExportExcel.Enabled = true;
                    }
                    catch
                    {
                        MessageBox.Show("Sửa thất bại.\nVui lòng kiểm tra lại dữ liệu.", "Thông báo");
                    }
                }
                string cauTruyVan = "select * from tblNhaXuatBan";
                dataGridViewDSNhaXuatBan.DataSource = ketnoi(cauTruyVan);
                dataGridViewDSNhaXuatBan.AutoGenerateColumns = false;
                myConnection.Close();
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                setControls(false);
                dataGridViewDSNhaXuatBan.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông Báo");
                if (txtTenNXB.Text.Length == 0)
                    txtTenNXB.Focus();
                else if (txtDiaChiNXB.Text.Length == 0)
                    txtDiaChiNXB.Focus();
                else if (txtSoDTNXB.Text.Length == 0)
                    txtSoDTNXB.Focus();
            }
        }

        //Phuong thuc nut huy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNXB.Text = maNXB;
            txtTenNXB.Text = tenNXB;
            txtSoDTNXB.Text = sdtNXB;
            txtDiaChiNXB.Text = diaChiNXB;
            txtEmail.Text = emailNXB;
            txtSoFax.Text = soFax;
            txtTrangThai.Text = trangThai;
            txtGhiChu.Text = ghiChu;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnExportExcel.Enabled = true;
            setControls(false);
            dataGridViewDSNhaXuatBan.Enabled = true;
            errSDTNXB.Clear();
            errTenNXB.Clear();
            errDCNXB.Clear();
            errSoFax.Clear();
            errEmail.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Tim kiem

        private void txtNDTimKiem_TextChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            if (radMaNXB.Checked)
            {
                string timkiem = "select * from tblNhaXuatBan where MaNXB like '%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiem);
                myCommand.ExecuteNonQuery();
                dataGridViewDSNhaXuatBan.DataSource = ketnoi(timkiem);
                dataGridViewDSNhaXuatBan.AutoGenerateColumns = false;
                myConnection.Close();
            }
            else if (radTenNXB.Checked)
            {
                string timkiem = "select * from tblNhaXuatBan where TenNXB like N'%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiem);
                myCommand.ExecuteNonQuery();
                dataGridViewDSNhaXuatBan.DataSource = ketnoi(timkiem);
                dataGridViewDSNhaXuatBan.AutoGenerateColumns = false;
                myConnection.Close();
            }
        }

        // xuat danh sach nha xuat ban ra excel
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
            worksheet.Cells[4, 2] = "DANH SÁCH NHÀ XUẤT BẢN";

            worksheet.Cells[6, 1] = "STT";
            worksheet.Cells[6, 2] = "Mã NXB";
            worksheet.Cells[6, 3] = "Tên NXB";
            worksheet.Cells[6, 4] = "Email";
            worksheet.Cells[6, 5] = "SĐT NXB";
            worksheet.Cells[6, 6] = "Số Fax";
            worksheet.Cells[6, 7] = "Địa chỉ NXB";
            worksheet.Cells[6, 8] = "Trạng thái";
            worksheet.Cells[6, 9] = "Ghi chú";
            for (int i = 0; i < dataGridViewDSNhaXuatBan.RowCount - 0; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    worksheet.Cells[i + 7, 1] = i + 1;
                    worksheet.Cells[i + 7, j + 2] = dataGridViewDSNhaXuatBan.Rows[i].Cells[j].Value;
                }
            }

            // Dinh dang trang
            worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;
            worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            worksheet.PageSetup.LeftMargin = 0;
            worksheet.PageSetup.RightMargin = 0;
            worksheet.PageSetup.TopMargin = 0;
            worksheet.PageSetup.BottomMargin = 0;

            // Ding dang cot
            worksheet.Range["A1"].ColumnWidth = 5;
            worksheet.Range["B1"].ColumnWidth = 9;
            worksheet.Range["C1"].ColumnWidth = 27;
            worksheet.Range["D1"].ColumnWidth = 23;
            worksheet.Range["E1"].ColumnWidth = 11;
            worksheet.Range["F1"].ColumnWidth = 13;
            worksheet.Range["G1"].ColumnWidth = 21;
            worksheet.Range["H1"].ColumnWidth = 13;
            worksheet.Range["I1"].ColumnWidth = 8;

            // Dinh dang font chu
            worksheet.Range["A1", "K100"].Font.Name = "Times New Roman";
            worksheet.Range["C2", "G2"].Font.Size = 18;
            worksheet.Range["B4", "G4"].Font.Size = 14;
            worksheet.Range["A6", "I6"].Font.Size = 12;
            worksheet.Range["C2", "G2"].MergeCells = true;
            worksheet.Range["C2", "G2"].Font.Bold = true;
            worksheet.Range["C2", "G2"].Font.Italic = true;
            worksheet.Range["C2", "G2"].Font.Underline = true;
            worksheet.Range["B4", "G4"].MergeCells = true;
            worksheet.Range["B4", "G4"].Font.Bold = true;
            worksheet.Range["A6", "I6"].Font.Bold = true;

            ////Ding dang cac dong text
            worksheet.Range["C2", "G2"].HorizontalAlignment = 3;
            worksheet.Range["B4", "G4"].HorizontalAlignment = 3;
            ////worksheet.Range["A6", "I6"].HorizontalAlignment = 3;
            ////worksheet.Range["A6", "A100"].HorizontalAlignment = 3;
            ////worksheet.Range["D6", "D100"].HorizontalAlignment = 5; // phia ben trai
            worksheet.Range["E6", "E100"].HorizontalAlignment = 5;
            worksheet.Range["F7", "F100"].HorizontalAlignment = 5;
            worksheet.Range["A6", "I6"].HorizontalAlignment = 3;

        }
    }
}
