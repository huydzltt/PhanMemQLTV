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

namespace PhanMemQLTV
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        string chuoiKetNoi = "Data Source=NDH09121999;Initial Catalog=MHHDL_DoAnQLTV;Integrated Security=True";
        private SqlConnection myConnection;
        private SqlCommand myCommand;

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtTenNguoiDung.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên người dùng.", "Thông báo");
                txtTenNguoiDung.Focus();
            }
            else if (txtTenTaiKhoan.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản.", "Thông báo");
                txtTenTaiKhoan.Focus();
            }
            else if (txtMatKhau.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Mật khẩu.", "Thông báo");
                txtMatKhau.Focus();
            }
            else if (txtSdt.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa Số điện thoại.", "Thông báo");
                txtSdt.Focus();
            }
            int luusdt;
            bool isNumber = int.TryParse(txtSdt.Text, out luusdt);
            if(isNumber==false)
            {
                MessageBox.Show("Số điện thoại không đúng");
            }
            if (txtTenNguoiDung.Text.Length > 0 && txtTenTaiKhoan.Text.Length > 0 && txtMatKhau.Text.Length > 0 && txtSdt.Text.Length > 0)
            {
                try
                {
                    myConnection = new SqlConnection(chuoiKetNoi);
                    myConnection.Open();
                    string strCauTruyVan = "select count(*) from tblDangNhap where TenTaiKhoan=@acc";
                    myCommand = new SqlCommand(strCauTruyVan, myConnection);
                    myCommand.Parameters.Add(new SqlParameter("@acc", txtTenTaiKhoan.Text));
             
                    int x = (int)myCommand.ExecuteScalar();
                    myConnection.Close();
                    if (x == 0)
                    {
                        try
                        {

                            string themdongSql;
                            themdongSql = "insert into tblDangNhap values ('" + txtTenTaiKhoan.Text + "',N'" + txtMatKhau.Text + "',N'" + txtTenNguoiDung.Text + "','" + txtSdt.Text + "')";
                            myConnection = new SqlConnection(chuoiKetNoi);
                            myConnection.Open();
                            myCommand = new SqlCommand(themdongSql, myConnection);
                            MessageBox.Show("Đăng ký thành công.", "Thông báo");
                            myCommand.ExecuteNonQuery();
                            myConnection.Close();

                            txtTenNguoiDung.Clear();
                            txtTenTaiKhoan.Clear();
                            txtMatKhau.Clear();
                            txtSdt.Clear();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại.\nVui lòng nhập tên khác.", "Thông báo");
                        txtTenTaiKhoan.Clear();
                        txtTenTaiKhoan.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {

        }
    }
}
