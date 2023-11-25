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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        string chuoiKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConnection;
        private SqlCommand myCommand;
        //Khai báo 
        public static string conString = "Data Source=DESKTOP-3I593JA;Initial Catalog=MHHDL_KhoaLuanQLTV;Integrated Security=True";
        // Khoi tao
        SqlConnection con = new SqlConnection(conString);
        // lay ten tai khoan 
        public static string tenTaiKhoan = "";
        // lay ten 
        public static string HoTen = "";
        // lay ten thu thu
        public static string tenTT = "";
        // lay ten doc gia
        public static string tenDG = "";

        private void DongForm(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        // Phương thức kiểm tra ĐN tài khoản
        private int kq = 0;
        private void kTraDK()
        {
            if (txtTenDangNhap.Text.Length > 0 && txtMatKhau.Text.Length > 0)
                kq = 1;
        }

        // Phương thức kiểm tra TKTT
        private int x1 = 0, x2 = 0;
        private void xacThucTKTT()
        {
            myConnection = new SqlConnection(chuoiKetNoi);
            myConnection.Open();
            string strCauTruyVan = "select count(*) from tblThuThu where TenTaiKhoanTT=@acc and MatKhauTT=@pass";
            myCommand = new SqlCommand(strCauTruyVan, myConnection);
            myCommand.Parameters.Add(new SqlParameter("@acc", txtTenDangNhap.Text));
            myCommand.Parameters.Add(new SqlParameter("@pass", txtMatKhau.Text));
            x1 = (int)myCommand.ExecuteScalar();
            myConnection.Close();
        }

        // Phương thức kiểm tra TKDG
        private void xacThucTKDG()
        {
            myConnection = new SqlConnection(chuoiKetNoi);
            myConnection.Open();
            string strCauTruyVan = "select count(*) from tblDocGia where TenTaiKhoanDG=@acc and MatKhauDG=@pass";
            myCommand = new SqlCommand(strCauTruyVan, myConnection);
            myCommand.Parameters.Add(new SqlParameter("@acc", txtTenDangNhap.Text));
            myCommand.Parameters.Add(new SqlParameter("@pass", txtMatKhau.Text));
            x2 = (int)myCommand.ExecuteScalar();
            myConnection.Close();
        }



        private string getTenTT()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblThuThu WHERE TenTaiKhoanTT  ='" + txtTenDangNhap.Text + "' AND MatKhauTT = '" + txtMatKhau.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        HoTen = dr["TenTT"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "lỗi");
            }
            finally
            {
                con.Close();
            }

            return HoTen;

        }

        private string GetTenTaiKhoanTT()
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblThuThu WHERE TenTaiKhoanTT ='" + txtTenDangNhap.Text + "' AND MatKhauTT = '" + txtMatKhau.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        tenTaiKhoan = dr["TenTaiKhoanTT"].ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "lỗi");
            }
            finally
            {
                con.Close();
            }

            return tenTaiKhoan;

        }


        private string getTenDG()
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblDocGia WHERE TenTaiKhoanDG ='" + txtTenDangNhap.Text + "' AND MatKhauDG = '" + txtMatKhau.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        HoTen = dr["TenDG"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "lỗi");
            }
            finally
            {
                con.Close();
            }

            return HoTen;

        }

        private string GetTenTaiKhoanDG()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblDocGia WHERE TenTaiKhoanDG ='" + txtTenDangNhap.Text + "' AND MatKhauDG = '" + txtMatKhau.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        tenTaiKhoan = dr["TenTaiKhoanDG"].ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "lỗi");
            }
            finally
            {
                con.Close();
            }

            return tenTaiKhoan;

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            kTraDK();
            if (kq == 1)
            {
                try
                {
                    xacThucTKTT();
                    xacThucTKDG();
                    tenTT = getTenTT();
                    tenDG = getTenDG();
                    if (x1 == 1)
                    {
                        //tenTaiKhoan = GetTenTaiKhoanTT();
                        //HoTen = getTenTT();
                        MessageBox.Show("Đăng nhập thành công.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmGiaoDienChinh GiaoDienChinh = new frmGiaoDienChinh();
                        GiaoDienChinh.FormClosed += new FormClosedEventHandler(DongForm);
                        this.Hide();
                        GiaoDienChinh.Show();
                        //try
                        //{
                        //    con.Open();
                        //    SqlCommand cmd = new SqlCommand("Insert into tblNhatKyHoatDong values('" + DateTime.Now + "', N'" + HoTen + "','" + tenTaiKhoan + "',N'Đăng nhập hệ thống')", con);
                        //    cmd.ExecuteNonQuery();
                        //    con.Close();
                        //    GiaoDienChinh.Show();
                        //}
                        //catch (Exception ex)
                        //{
                        //    MessageBox.Show(ex.ToString(), "Đã có lỗi xảy ra.");
                        //}
                    }
                    else if (x2 == 1)
                    {
                        //tenTaiKhoan = GetTenTaiKhoanDG();
                        //HoTen = getTenDG();
                        MessageBox.Show("Đăng nhập thành công.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmDocGia GiaoDienDocGia = new frmDocGia(txtTenDangNhap.Text);
                        GiaoDienDocGia.FormClosed += new FormClosedEventHandler(DongForm);
                        this.Hide();
                        GiaoDienDocGia.Show();
                        //try
                        //{
                        //    con.Open();
                        //    //string Query = string.Format("insert into tblNhatKyHoatDong(ThoiGian, NguoiTao, TaiKhoan, ThaoTac) values('{0}', N'{1}', N'{2}', N'{3}')", DateTime.Now, HoTen, tenTaiKhoan, "Đăng nhập hệ thống");
                        //    //SqlCommand cmd = new SqlCommand(Query, con);
                        //    SqlCommand cmd = new SqlCommand("Insert into tblNhatKyHoatDong values('" + DateTime.Now + "', N'" + HoTen + "','" + tenTaiKhoan + "',N'Đăng nhập hệ thống')", con);
                        //    cmd.ExecuteNonQuery();
                        //    con.Close();
                        //    GiaoDienDocGia.Show();
                        //}
                        //catch (Exception ex)
                        //{
                        //    MessageBox.Show(ex.ToString(), "Đã có lỗi xảy ra.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //}

                    }
                    else
                    {
                        MessageBox.Show("Sai Tên tài khoản hoặc Mật khẩu.\nVui lòng kiểm tra lại.", "Thông báo.");
                        txtTenDangNhap.Clear();
                        txtMatKhau.Clear();
                        txtTenDangNhap.Focus();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Bạn chưa nhập thông tin đăng nhập.", "Thông báo");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                this.Close();
            }
        }

        // Phuong thuc doi ngay
        //private String doiNgay(String name) 
        //{
        //    String ngay = "";
        //    switch (name)
        //    {
        //        case "Monday":
        //            ngay = "Thứ Hai";
        //            break;
        //        case "Tuesday":
        //            ngay = "Thứ ba";
        //            break;
        //        case "Wednesday":
        //            ngay = "Thứ tư";
        //            break;
        //        case "Thusday":
        //            ngay = "Thứ năm";
        //            break;
        //        case "Friday":
        //            ngay = "Thứ sáu";
        //            break;
        //        case "Saturday":
        //            ngay = "Thứ bẩy";
        //            break;
        //        default:
        //            ngay = "Chủ nhật";
        //            break;
        //    }
        //    return ngay;
        //}

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            //lblNgay.Text = doiNgay(DateTime.Now.DayOfWeek.ToString()) + " " + 
            //    DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" +
            //    DateTime.Now.Year.ToString();  
        }

        private void tmrTGGĐG_Tick(object sender, EventArgs e)
        {
            //lblGio.Text = DateTime.Now.Hour.ToString() + " : " +
            //    DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString();
        }

        private void btnPopUp_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (SubForm uu = new SubForm())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        //private void btnMoPopUp_Click(object sender, EventArgs e)
        //{
        //    Form formBackground = new Form();
        //    try
        //    {
        //        using (SubForm uu = new SubForm())
        //        {
        //            formBackground.StartPosition = FormStartPosition.Manual;
        //            formBackground.FormBorderStyle = FormBorderStyle.None;
        //            formBackground.Opacity = .50d;
        //            formBackground.BackColor = Color.Black;
        //            formBackground.WindowState = FormWindowState.Maximized;
        //            formBackground.TopMost = true;
        //            formBackground.Location = this.Location;
        //            formBackground.ShowInTaskbar = false;
        //            formBackground.Show();

        //            uu.Owner = formBackground;
        //            uu.ShowDialog();

        //            formBackground.Dispose();
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        formBackground.Dispose();
        //    }
        //}

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !txtMatKhau.UseSystemPasswordChar;
        }


    }
}
