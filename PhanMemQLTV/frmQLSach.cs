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
    public partial class frmQLSach : Form
    {
        public frmQLSach()
        {
            InitializeComponent();
        }
        string chuoiKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConnection;
        private SqlDataAdapter myDataAdapter;
        private SqlCommand myCommand;
        private DataTable myTable;
        //public static string conString = "Data Source=NDH09121999;Initial Catalog=MHHDL_KhoaLuanQLTV;Integrated Security=True";
        //// Khoi tao
        //SqlConnection con = new SqlConnection(conString);



        /// <summary>
        /// /////////////////////////////////////////////////
        /// </summary>
        private DataTable myTableNXB;
        private SqlDataReader myDataReaderNXB;

        // Ket noi toi Sql
        private DataTable ketnoi(string truyvan)
        {
            myConnection = new SqlConnection(chuoiKetNoi);
            myConnection.Open();
            string thuchiencaulenh = truyvan;
            myCommand = new SqlCommand(thuchiencaulenh, myConnection);
            myDataAdapter = new SqlDataAdapter(myCommand);
            myTable = new DataTable();
            myDataAdapter.Fill(myTable);
            dataGridViewDSSach.DataSource = myTable;
            return myTable;
        }

        // Ket noi toi tblNhaXuatBan
        private DataTable ketnoitblNhaXuatban(string truyvan)
        {
            myConnection = new SqlConnection(chuoiKetNoi);
            myConnection.Open();
            string thuchiencaulenh = truyvan;
            myCommand = new SqlCommand(thuchiencaulenh, myConnection);
            myDataAdapter = new SqlDataAdapter(myCommand);
            myTableNXB = new DataTable();
            myDataAdapter.Fill(myTableNXB);
            return myTableNXB;
        }

        //Lay maNXB len cboMaNXB
        public void layMaNXB() 
        {
            string strLayMaNhaXuatBan = "select MaNXB from tblNhaXuatBan";
            cboMaNXB.DataSource = ketnoitblNhaXuatban(strLayMaNhaXuatBan);
            cboMaNXB.DisplayMember = "MaNXB";
            cboMaNXB.ValueMember = "MaNXB";
            myConnection.Close();
        }

        private void setControls(bool edit)
        {
            txtTenSach.Enabled = edit;
            txtChuDe.Enabled = edit;
            txtTacGia.Enabled = edit;
            cboMaNXB.Enabled = edit;
            txtNamXB.Enabled = edit;
            txtSLNhap.Enabled = edit;
            txtDonGia.Enabled = edit;
            cboTinhTrang.Enabled = edit;
            txtGhiChu.Enabled = edit;
        }

        private void frmQLSach_Load(object sender, EventArgs e)
        {
            string cauTruyVan = "select * from tblSach";
            dataGridViewDSSach.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSSach.AutoGenerateColumns = false;
            myConnection.Close();
            setControls(false);
            dataGridViewDSSach.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtMaSach.Enabled = false;
            txtTTTenNXB.Enabled = false;
        }

        public string maSach, tenSach, tacGia, chuDe, maNXB, namXB, slNhap, donGia, tinhTrang, ghiChu;
        private void dataGridViewDSSach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                txtMaSach.Text = myTable.Rows[row]["MaSach"].ToString();
                maSach = txtMaSach.Text;
                txtTenSach.Text = myTable.Rows[row]["TenSach"].ToString();
                tenSach = txtTenSach.Text;
                txtChuDe.Text = myTable.Rows[row]["ChuDe"].ToString();
                chuDe = txtChuDe.Text;
                txtTacGia.Text = myTable.Rows[row]["TacGia"].ToString();
                tacGia = txtTacGia.Text;
                cboMaNXB.Text = myTable.Rows[row]["MaNXB"].ToString();
                maNXB = cboMaNXB.Text;
                txtNamXB.Text = myTable.Rows[row]["NamXB"].ToString();
                namXB = txtNamXB.Text;             
                txtSLNhap.Text = myTable.Rows[row]["SLNhap"].ToString();
                slNhap = txtSLNhap.Text;
                txtDonGia.Text = myTable.Rows[row]["DonGia"].ToString();
                donGia = txtDonGia.Text;
                cboTinhTrang.Text = myTable.Rows[row]["TinhTrang"].ToString();
                tinhTrang = cboTinhTrang.Text;
                txtGhiChu.Text = myTable.Rows[row]["GhiChu"].ToString();
                ghiChu = txtGhiChu.Text;
            }
            catch
            {

            }
        }

        public int xuly;
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaSach.Text = tangMaTuDong();
            txtTenSach.Text = "";
            txtChuDe.Text = "";
            txtTacGia.Text = "";
            layMaNXB();         
            txtSLNhap.Text = "";
            txtNamXB.Text = "";
            txtDonGia.Text = "";
            cboTinhTrang.Text = "";
            txtGhiChu.Text = "";

            setControls(true);
            dataGridViewDSSach.Enabled = false;
            txtTenSach.Focus();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnExportExcel.Enabled = false;
            xuly = 0;
        }

        //thiet lap chuc nang cboMaNXB
        private void cboMaNXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strlaydulieu = "select * from tblNhaXuatBan where MaNXB='" + cboMaNXB.SelectedValue.ToString() + "'";
            myConnection = new SqlConnection(chuoiKetNoi);
            myConnection.Open();
            string thuchiencaulenh = strlaydulieu;
            myCommand = new SqlCommand(thuchiencaulenh, myConnection);
            myDataReaderNXB = myCommand.ExecuteReader();
            while (myDataReaderNXB.Read())
            {
                txtTTTenNXB.Text = myDataReaderNXB.GetString(1);
            }

        }


        // Button sua

        private void btnSua_Click(object sender, EventArgs e)
        {
            cboTinhTrang.Text = "Mới";
            setControls(true);
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnExportExcel.Enabled = false;
            dataGridViewDSSach.Enabled = false;
            txtTenSach.Focus();
            xuly = 1;
            //lblNhapCD.Text = "";
            //lblNhapDonGia.Text = "";
            //lblNhapSLCon.Text = "";
            //lblNhapSLNhap.Text = "";
            //lblNhapTenNXB.Text = "";
            //lblNhapTenSach.Text = "";
            //lblNhapTenTG.Text = "";
            //lblNhapTinhTrang.Text = "";
        }

        //Phuong thuc xoa du lieu sach
        private void xoaSach()
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn xóa.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    string xoadongSql;
                    xoadongSql = "DELETE FROM tblSach WHERE MaSach='" + txtMaSach.Text + "'";
                    ketnoi(xoadongSql);
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công.", "Thông Báo");
                    //try
                    //{
                    //    string tentaikhoan = frmDangNhap.tenTaiKhoan;
                    //    string hoten = frmDangNhap.HoTen;
                    //    con.Open();
                    //    //SqlCommand cmd = new SqlCommand("Insert into tblLogNhatKy values('" + DateTime.Now + "', N'" + hoten + "','" + tentaikhoan + "', N'Thêm mới nhân viên')", con);
                    //    string Query = string.Format("insert into tblNhatKyHoatDong(ThoiGian, NguoiTao, TaiKhoan, ThaoTac) values('{0}', N'{1}', N'{2}', N'{3}')", DateTime.Now, hoten, tentaikhoan, "Xoá sách " + txtTenSach.Text);
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
                    MessageBox.Show("Xóa thất bại.\nSách này đang được mượn.", "Thông Báo");
                }
            }
            string cauTruyVan = "select * from tblSach";
            dataGridViewDSSach.DataSource = ketnoi(cauTruyVan);
            myConnection.Close();
        }

        // Xoá du lieu sach
        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaSach();
        }

        //Phuong thuc xoa danh sach cac cuon sach
        private void xoaDSSach()
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn xóa danh sách các đầu sách này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    string xoadongSql;
                    xoadongSql = "DELETE FROM tblSach";
                    ketnoi(xoadongSql);
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Xóa danh sách thành công.", "Thông báo");
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
                    txtMaSach.Clear();
                    txtTenSach.Clear();
                    txtTacGia.Clear();
                    txtNamXB.Clear();
                    txtChuDe.Clear();
                    txtSLNhap.Clear();
                    txtDonGia.Clear();
                    txtGhiChu.Clear();
                }
                catch
                {
                    MessageBox.Show("Xóa danh sách thất bại.\nCó sách đang được mượn.", "Thông báo");
                }
            }
            string cauTruyVan = "select * from tblSach";
            dataGridViewDSSach.DataSource = ketnoi(cauTruyVan);
            myConnection.Close();
        }


        // Xoa danh sach cac cuon sach
        private void btnXoaDSSach_Click(object sender, EventArgs e)
        {
            if (txtMaSach.TextLength == 0) 
            {
                MessageBox.Show("Không có danh sách cần xoá.\nVui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                xoaDSSach();
            }        
        }

        private void themSach()
        {
            try
            {

                string themdongSql;
                themdongSql = "insert into tblSach values ('" + txtMaSach.Text + "',N'" + txtTenSach.Text + "',N'" + txtChuDe.Text + "',N'" + txtTacGia.Text + "',N'" + cboMaNXB.Text + "','" + txtNamXB.Text + "','" + txtSLNhap.Text + "','" + txtDonGia.Text + "',N'" + cboTinhTrang.Text + "',N'" + txtGhiChu.Text + "')";
                ketnoi(themdongSql);
                MessageBox.Show("Thêm sách thành công.", "Thông Báo");
                //try
                //{
                //    string tentaikhoan = frmDangNhap.tenTaiKhoan;
                //    string hoten = frmDangNhap.HoTen;
                //    con.Open();
                //    //SqlCommand cmd = new SqlCommand("Insert into tblLogNhatKy values('" + DateTime.Now + "', N'" + hoten + "','" + tentaikhoan + "', N'Thêm mới nhân viên')", con);
                //    string Query = string.Format("insert into tblNhatKyHoatDong(ThoiGian, NguoiTao, TaiKhoan, ThaoTac) values('{0}', N'{1}', N'{2}', N'{3}')", DateTime.Now, hoten, tentaikhoan, "Thêm mới sách " + txtTenSach.Text);
                //    SqlCommand cmd = new SqlCommand(Query, con);
                //    cmd.ExecuteNonQuery();
                //    con.Close();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.ToString(), "Đã có lỗi xảy ra.");
                //}
                myCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch 
            {
                
            }
        }

        private void suaSach()
        {
            try
            {
                string capnhatdong;
                capnhatdong = "update tblSach set TenSach=N'" + txtTenSach.Text + "',ChuDe=N'" + txtChuDe.Text + "',TacGia=N'" + txtTacGia.Text + "',MaNXB=N'" + cboMaNXB.Text + "',NamXB='" + txtNamXB.Text + "',SLNhap='" + txtSLNhap.Text + "',DonGia='" + txtDonGia.Text + "',TinhTrang=N'" + cboTinhTrang.Text + "',GhiChu=N'" + txtGhiChu.Text + "' where MaSach='" + txtMaSach.Text + "'";
                //capnhatdong = "update tblSach set TenSach=N'" + txtTenSach.Text + "',ChuDe=N'" + txtChuDe.Text + "',TacGia=N'" + txtTacGia.Text + "',NXB=N'" + txtNXB.Text + "',NamXB='" + txtNamXB.Text + "',SLNhap='" + txtSLNhap.Text + "',DonGia='" + txtDonGia.Text + "',TinhTrang=N'" + cboTinhTrang.Text + "' where MaSach='" + txtMaSach.Text + "' ";
                ketnoi(capnhatdong);
                myCommand.ExecuteNonQuery();

                MessageBox.Show("Sửa thành công.", "Thông Báo");
                //try
                //{
                //    string tentaikhoan = frmDangNhap.tenTaiKhoan;
                //    string hoten = frmDangNhap.HoTen;
                //    con.Open();
                //    //SqlCommand cmd = new SqlCommand("Insert into tblLogNhatKy values('" + DateTime.Now + "', N'" + hoten + "','" + tentaikhoan + "', N'Thêm mới nhân viên')", con);
                //    string Query = string.Format("insert into tblNhatKyHoatDong(ThoiGian, NguoiTao, TaiKhoan, ThaoTac) values('{0}', N'{1}', N'{2}', N'{3}')", DateTime.Now, hoten, tentaikhoan, "Sửa thông tin sách " + txtTenSach.Text);
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
                MessageBox.Show("Sửa thất bại.\nVui lòng kiểm tra lại dữ liệu.", "Thông Báo");
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtTenSach.Text=="")
            {
                errTenSach.SetError(txtTenSach, "Vui lòng nhập Tên Sách");
            }
            else
            {
                errTenSach.Clear();
            }
            if (txtChuDe.Text == "")
            {
                errCD.SetError(txtChuDe, "Vui lòng nhập Chủ Đề");
            }
            else
            {
                errCD.Clear();
            }
            if (txtTacGia.Text == "")
            {
                errTG.SetError(txtTacGia, "Vui lòng nhập Tác Giả");
            }
            else
            {
                errTG.Clear();
            }
            if (cboMaNXB.Text == "")
            {
                errMaNXB.SetError(cboMaNXB, "Vui lòng nhập Mã NXB");
            }
            else
            {
                errMaNXB.Clear();
            }
            if (txtNamXB.Text == "")
            {
                errNamXB.SetError(txtNamXB, "Vui lòng nhập Năm XB");
            }
            else
            {
                errNamXB.Clear();
            }
            if (txtSLNhap.Text == "")
            {
                errSLNhap.SetError(txtSLNhap, "Vui lòng nhập SL");
            }
            else
            {
                errSLNhap.Clear();
            }
            
            if (txtDonGia.Text == "")
            {
                errDonGia.SetError(txtDonGia, "Vui lòng nhập Đơn Giá");
            }
            else
            {
                errDonGia.Clear();
            }
            if (cboTinhTrang.Text == "")
            {
                errTinhTrang.SetError(cboTinhTrang, "Vui lòng nhập Tình Trạng");
            }
            else
            {
                errTinhTrang.Clear();
            }
            int ktSLNhap, ktNamXB, ktDonGia;
            bool isNumberSLNhap = int.TryParse(txtSLNhap.Text, out ktSLNhap);
            bool isNumberDonGia = int.TryParse(txtDonGia.Text, out ktDonGia);
            bool isNumberNamXB = int.TryParse(txtNamXB.Text, out ktNamXB);
            if(isNumberSLNhap==false || isNumberDonGia==false || isNumberNamXB==false)
            {
                MessageBox.Show("Vui lòng nhập số trong các ô:\nSL Nhập.\nNăm XB.\nĐơn Giá.", "Thông Báo");
            }
            if (txtTenSach.Text.Length > 0 && txtTacGia.Text.Length > 0 && cboMaNXB.Text.Length > 0 && txtChuDe.Text.Length > 0 && isNumberSLNhap == true && isNumberDonGia == true && cboTinhTrang.Text.Length > 0 && isNumberNamXB == true)
            {
                    if (xuly == 0)
                    {
                        themSach();
                        btnExportExcel.Enabled = true;
                    }
                    else if (xuly == 1)
                    {
                        suaSach();
                        btnExportExcel.Enabled = true;
                    }
                    string cauTruyVan = "select * from tblSach";
                    dataGridViewDSSach.DataSource = ketnoi(cauTruyVan);
                    dataGridViewDSSach.AutoGenerateColumns = false;
                    myConnection.Close();
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    setControls(false);
                    dataGridViewDSSach.Enabled = true;

                    errTenSach.Clear();
                    errCD.Clear();
                    errTG.Clear();
                    errNamXB.Clear();
                    errMaNXB.Clear();
                    errDonGia.Clear();
                    errSLNhap.Clear();
                    errTinhTrang.Clear();
                
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông Báo");
                if (txtTenSach.Text.Length == 0)
                    txtTenSach.Focus();
                else if (txtChuDe.Text.Length == 0)
                    txtChuDe.Focus();
                else if (txtTacGia.Text.Length == 0)
                    txtTacGia.Focus();
                else if (cboMaNXB.Text.Length == 0)
                    cboMaNXB.Focus();
                else if (txtNamXB.Text.Length == 0)
                    txtNamXB.Focus();
                else if (txtSLNhap.Text.Length == 0)
                    txtSLNhap.Focus();
                else if (txtDonGia.Text.Length == 0)
                    txtDonGia.Focus();
                else if (cboTinhTrang.Text.Length == 0)
                    cboTinhTrang.Focus();
            }      
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaSach.Text = maSach;
            txtTenSach.Text = tenSach;
            txtChuDe.Text = chuDe;
            txtTacGia.Text = tacGia;
            cboMaNXB.Text = maNXB;
            txtSLNhap.Text = slNhap;
            txtDonGia.Text = donGia;
            cboTinhTrang.Text = tinhTrang;
            txtGhiChu.Text = ghiChu;
            setControls(false);
            dataGridViewDSSach.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnExportExcel.Enabled = true;

            errTenSach.Clear();
            errCD.Clear();
            errTG.Clear();
            errNamXB.Clear();
            errMaNXB.Clear();
            errDonGia.Clear();
            errSLNhap.Clear();
            errTinhTrang.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoadDS_Click(object sender, EventArgs e)
        {
            lblNhapCD.Text = "";
            lblNhapDonGia.Text = "";
            lblNhapSLCon.Text = "";
            lblNhapSLNhap.Text = "";
            lblNhapTenNXB.Text = "";
            lblNhapTenSach.Text = "";
            lblNhapTenTG.Text = "";
            lblNhapTinhTrang.Text = "";
            setControls(false);
            txtNDTimKiem.Text = "";
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            string cauTruyVan = "select * from tblSach";
            dataGridViewDSSach.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSSach.AutoGenerateColumns = false;
            myConnection.Close();
        }
        private void timKiemSach()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            if (radMaSach.Checked)
            {
                string timkiemMS = "select * from tblSach where MaSach like '%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiemMS);
                myCommand.ExecuteNonQuery();
                dataGridViewDSSach.DataSource = myTable;
                dataGridViewDSSach.AutoGenerateColumns = false;
                myConnection.Close();
            }
            else if (radTenSach.Checked)
            {
                string timkiemTS = "select * from tblSach where TenSach like N'%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiemTS);
                myCommand.ExecuteNonQuery();
                dataGridViewDSSach.DataSource = ketnoi(timkiemTS);
                dataGridViewDSSach.AutoGenerateColumns = false;
                myConnection.Close();
            }
            else if (radTenTG.Checked)
            {
                string timkiemMS = "select * from tblSach where TacGia like N'%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiemMS);
                myCommand.ExecuteNonQuery();
                dataGridViewDSSach.DataSource = myTable;
                dataGridViewDSSach.AutoGenerateColumns = false;
                myConnection.Close();
            }
            else if (radTenCD.Checked)
            {
                string timkiemMS = "select * from tblSach where ChuDe like N'%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiemMS);
                myCommand.ExecuteNonQuery();
                dataGridViewDSSach.DataSource = myTable;
                dataGridViewDSSach.AutoGenerateColumns = false;
                myConnection.Close();
            }
        }
        private void txtNDTimKiem_TextChanged(object sender, EventArgs e)
        {
            timKiemSach();
        }
        public string tangMaTuDong()
        {
            string cauTruyVan = "select * from tblSach";
            dataGridViewDSSach.DataSource = ketnoi(cauTruyVan);
            dataGridViewDSSach.AutoGenerateColumns = false;
            myConnection.Close();
            string maTuDong = "";
            if(myTable.Rows.Count<=0)
            {
                maTuDong = "MS001";
            }
            else
            {
                int k;
                maTuDong = "MS";
                k = Convert.ToInt32(myTable.Rows[myTable.Rows.Count - 1][0].ToString().Substring(2, 3));
                k = k + 1;
                if(k<10)
                {
                    maTuDong = maTuDong + "00";
                }
                else if(k<100)
                {
                    maTuDong = maTuDong + "0";
                }
                maTuDong = maTuDong + k.ToString();
            }
            return maTuDong;
        }


        // Xuat danh sach cac dau sach ra file excel

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
            worksheet.Cells[4, 2] = "DANH SÁCH CÁC ĐẦU SÁCH";
            //worksheet.Cells[3, 2] = "Mã sách: " + lblMaSach.Text;
            //worksheet.Cells[4, 2] = "Tên sách: " + lblTenSach.Text;
            //worksheet.Cells[5, 2] = "Tác giả: " + lblTacGia.Text;
            //worksheet.Cells[6, 2] = "Mã NXB: " + lblMaNXB.Text;
            //worksheet.Cells[7, 2] = "Năm XB: " + lblNamXB.Text;
            //worksheet.Cells[8, 2] = "Chủ đề: " + lblChuDe.Text;
            //worksheet.Cells[9, 2] = "SL nhập: " + lblSLNhap.Text;
            //worksheet.Cells[10, 2] = "Đơn giá: " + lblDonGia.Text;
            //worksheet.Cells[11, 2] = "Tình trạng: " + lblTinhTrang.Text;
            //worksheet.Cells[12, 2] = "Ghi chú: " + lblGhiChu.Text;
            worksheet.Cells[6, 1] = "STT";
            worksheet.Cells[6, 2] = "Mã sách";
            worksheet.Cells[6, 3] = "Tên sách";
            worksheet.Cells[6, 4] = "Chủ đề";
            worksheet.Cells[6, 5] = "Tác giả";
            worksheet.Cells[6, 6] = "Mã NXB";
            worksheet.Cells[6, 7] = "Năm XB";
            worksheet.Cells[6, 8] = "SL nhập";
            worksheet.Cells[6, 9] = "Đơn giá";
            worksheet.Cells[6, 10] = "Tình trạng";
            worksheet.Cells[6, 11] = "Ghi chú";
            for(int i = 0; i < dataGridViewDSSach.RowCount - 0; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    worksheet.Cells[i + 7, 1] = i + 1;
                    worksheet.Cells[i + 7, j + 2] = dataGridViewDSSach.Rows[i].Cells[j].Value;
                }
            }

            // Dinh dang trang
            worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;
            worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            worksheet.PageSetup.LeftMargin = 0.5;
            worksheet.PageSetup.RightMargin = 0;
            worksheet.PageSetup.TopMargin = 0;
            worksheet.PageSetup.BottomMargin = 0;

            // Ding dang cot
            worksheet.Range["A1"].ColumnWidth = 5;
            worksheet.Range["B1"].ColumnWidth = 8;
            worksheet.Range["C1"].ColumnWidth = 24;
            worksheet.Range["D1"].ColumnWidth = 15;
            worksheet.Range["E1"].ColumnWidth = 19;
            worksheet.Range["F1"].ColumnWidth = 10;
            worksheet.Range["G1"].ColumnWidth = 9;
            worksheet.Range["H1"].ColumnWidth = 9;
            worksheet.Range["I1"].ColumnWidth = 9;
            worksheet.Range["J1"].ColumnWidth = 11;
            worksheet.Range["K1"].ColumnWidth = 15;

            // Dinh dang font chu
            worksheet.Range["A1", "K100"].Font.Name = "Times New Roman";
            worksheet.Range["C2", "I2"].Font.Size = 18;
            worksheet.Range["B4", "J4"].Font.Size = 14;
            worksheet.Range["A6", "K17"].Font.Size = 12;
            worksheet.Range["C2", "I2"].MergeCells = true;
            worksheet.Range["C2", "I2"].Font.Bold = true;
            worksheet.Range["C2", "I2"].Font.Italic = true;
            worksheet.Range["C2", "I2"].Font.Underline = true;
            worksheet.Range["B4", "J4"].MergeCells = true;
            worksheet.Range["B4", "J4"].Font.Bold = true;
            worksheet.Range["A6", "K6"].Font.Bold = true;


            //Dinh dang bang
            //worksheet.Range["A5", "K100"].Borders.LineStyle = 1;

            //Ding dang cac dong text
            worksheet.Range["C2", "I2"].HorizontalAlignment = 3;
            worksheet.Range["B4", "J4"].HorizontalAlignment = 3;
            worksheet.Range["A6", "K6"].HorizontalAlignment = 3;
            worksheet.Range["A6", "A100"].HorizontalAlignment = 3;
            worksheet.Range["G6", "G100"].HorizontalAlignment = 3;
            worksheet.Range["H6", "H100"].HorizontalAlignment = 3;
            worksheet.Range["I6", "I100"].HorizontalAlignment = 3;
            worksheet.Range["J6", "J100"].HorizontalAlignment = 3;
        }

    }
}
