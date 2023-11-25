using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;

namespace PhanMemQLTV
{
    public partial class frmImportDuLieu : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=NDH09121999;Initial Catalog=MHHDL_KhoaLuanQLTV;Integrated Security=True");

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        ConnectionDB db = new ConnectionDB();

        public frmImportDuLieu()
        {
            InitializeComponent();

            con = new SqlConnection(db.GetConnection());
            Loadrecords();
        }

        public void Loadrecords()
        {
            dgvDanhSachTaiLieu.Rows.Clear();
            //int i = 0;
            con.Open();
            cmd = new SqlCommand("select * from tblSach", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //i++;
                dgvDanhSachTaiLieu.Rows.Add(dr["MaSach"].ToString(), dr["TenSach"].ToString(), dr["ChuDe"].ToString(), dr["TacGia"].ToString(), dr["MaNXB"].ToString(), dr["NamXB"].ToString(), dr["SLNhap"].ToString(), dr["DonGia"].ToString(), dr["TinhTrang"].ToString(), dr["Ghichu"].ToString());

            }
            dr.Close();
            con.Close();
        }



        private void btnImport_Click(object sender, EventArgs e)
        {
            //OleDbConnection theConnection = new OleDbConnection(@"provider=Microsoft.Jet.OLEDB.4.0;data source='" + txtTenFile.Text + "';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1\"");

            //theConnection.Open();
            //OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("Select * from[Sheet1$]", theConnection);
            //DataSet theSD = new DataSet();
            //DataTable dt = new DataTable();
            //theDataAdapter.Fill(dt);
            //this.dgvDanhSachDuLieu.DataSource = dt.DefaultView;
            dgvDanhSachTaiLieu.Rows.Clear();
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            Microsoft.Office.Interop.Excel.Range xlRange;

            int xlRow;
            string strFileName;

            openFD.Filter = "Excel Office |*.xls; *xlsx";
            openFD.ShowDialog();
            strFileName = openFD.FileName;

            if (strFileName != "")
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkbook = xlApp.Workbooks.Open(strFileName);
                xlWorkSheet = xlWorkbook.Worksheets["Sheet1"];
                xlRange = xlWorkSheet.UsedRange;

                //int i = 0;
                for (xlRow = 2; xlRow <= xlRange.Rows.Count; xlRow++)
                {
                    if (xlRange.Cells[xlRow, 1].Text != "")
                    {
                        //i++;
                        dgvDanhSachTaiLieu.Rows.Add(xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text,    //Co them i, o dau neu muon them so thu tu
                            xlRange.Cells[xlRow, 3].Text, xlRange.Cells[xlRow, 4].Text, xlRange.Cells[xlRow, 5].Text,
                            xlRange.Cells[xlRow, 6].Text, xlRange.Cells[xlRow, 7].Text, xlRange.Cells[xlRow, 8].Text, 
                            xlRange.Cells[xlRow, 9].Text, xlRange.Cells[xlRow, 10].Text);
                    }
                }
                xlWorkbook.Close();
                xlApp.Quit();
            }
        }


        //private void btnBrowse_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog fdlg = new OpenFileDialog();
        //    fdlg.Title = "Select file";
        //    fdlg.FileName = txtTenFile.Text;
        //    fdlg.Filter = "Excel Sheet (*.xlsx)|*.xlsx|All Files(*.*)|*.*";
        //    fdlg.FilterIndex = 1;
        //    fdlg.RestoreDirectory = true;
        //    if (fdlg.ShowDialog() == DialogResult.OK) 
        //    {
        //        txtTenFile.Text = fdlg.FileName;
        //    }
        //}


        //void fillGrid()
        //{
        //    con.Open();
        //    SqlDataAdapter da = new SqlDataAdapter("select * from tblSach", con);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    dgvDanhSachDuLieu.DataSource = dt;
        //    con.Close();

        //}

        private void frmImportDuLieu_Load(object sender, EventArgs e)
        {
            //fillGrid();
            dgvDanhSachTaiLieu.Rows.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //con.Open();
            //for (int i = 0; i < dgvDanhSachDuLieu.Rows.Count; i++)
            //{
            //    SqlCommand cmd = new SqlCommand("insert into tblSach(MaSach,TenSach,ChuDe,TacGia,MaNXB,NamXB,SLNhap,DonGia,TinhTrang,GhiChu)values('" + dgvDanhSachDuLieu.Rows[i].Cells[0].Value + "',N'" + dgvDanhSachDuLieu.Rows[i].Cells[1].Value + "',N'" + dgvDanhSachDuLieu.Rows[i].Cells[2].Value + "',N'" + dgvDanhSachDuLieu.Rows[i].Cells[3].Value + "','" + dgvDanhSachDuLieu.Rows[i].Cells[4].ErrorText + "','" + dgvDanhSachDuLieu.Rows[i].Cells[5].Value + "','" + dgvDanhSachDuLieu.Rows[i].Cells[6].Value + "','" + dgvDanhSachDuLieu.Rows[i].Cells[7].Value + "',N'" + dgvDanhSachDuLieu.Rows[i].Cells[8].Value + "','" + dgvDanhSachDuLieu.Rows[i].Cells[9].Value + "')", con);
            //    cmd.ExecuteNonQuery();
            //}
            //con.Close();
            //MessageBox.Show("Lưu thành công.", "Thông báo");
            //fillGrid();


            for (int i = 0; i < dgvDanhSachTaiLieu.Rows.Count; i++)
            {
                con.Open();
                cmd = new SqlCommand("insert into tblSach (MaSach, TenSach, ChuDe, TacGia, MaNXB, NamXB, SLNhap, DonGia, TinhTrang, Ghichu) values (@MaSach, @TenSach, @ChuDe, @TacGia, @MaNXB, @NamXB, @SLNhap, @DonGia, @TinhTrang, @Ghichu)", con);
                cmd.Parameters.AddWithValue("@MaSach", dgvDanhSachTaiLieu.Rows[i].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@TenSach", dgvDanhSachTaiLieu.Rows[i].Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@ChuDe", dgvDanhSachTaiLieu.Rows[i].Cells[2].Value.ToString());
                cmd.Parameters.AddWithValue("@TacGia", dgvDanhSachTaiLieu.Rows[i].Cells[3].Value.ToString());
                cmd.Parameters.AddWithValue("@MaNXB", dgvDanhSachTaiLieu.Rows[i].Cells[4].Value.ToString());
                cmd.Parameters.AddWithValue("@NamXB", dgvDanhSachTaiLieu.Rows[i].Cells[5].Value.ToString());
                cmd.Parameters.AddWithValue("@SLNhap", dgvDanhSachTaiLieu.Rows[i].Cells[6].Value.ToString());
                cmd.Parameters.AddWithValue("@DonGia", dgvDanhSachTaiLieu.Rows[i].Cells[7].Value.ToString());
                cmd.Parameters.AddWithValue("@TinhTrang", dgvDanhSachTaiLieu.Rows[i].Cells[8].Value.ToString());
                cmd.Parameters.AddWithValue("@Ghichu", dgvDanhSachTaiLieu.Rows[i].Cells[9].Value.ToString());
                cmd.ExecuteNonQuery();
                con.Close();
            }
            MessageBox.Show("Lưu danh sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);        
            Loadrecords();
            //fillGrid();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
