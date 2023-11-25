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
    public partial class frmTraCuuThongTinNXB : Form
    {
        public frmTraCuuThongTinNXB()
        {
            InitializeComponent();
        }

        string strKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConection;
        private SqlCommand myCommand;
        private SqlDataAdapter myDataAdapter;
        private DataTable myTable;

        // ket noi sql
        private DataTable ketnoi(string truyvan) 
        {
            myConection = new SqlConnection(strKetNoi);
            myConection.Open();
            string thuchiencaulenh = truyvan;
            myCommand = new SqlCommand(thuchiencaulenh, myConection);
            myDataAdapter = new SqlDataAdapter(myCommand);
            myTable = new DataTable();
            myDataAdapter.Fill(myTable);
            dataGridViewDSNhaXuatBan0.DataSource = myTable;
            return myTable;
        }

        // tim kiem nha xuat ban
        private void txtNDTimKiemNXB_TextChanged(object sender, EventArgs e)
        {
            if (radMaNXB.Checked) 
            {
                string timkiemMNXB = "select * from tblNhaXuatBan where MaNXB like '%" + txtNDTimKiemNXB.Text + "%'";
                ketnoi(timkiemMNXB);
                myCommand.ExecuteNonQuery();
                dataGridViewDSNhaXuatBan0.DataSource = myTable;
                dataGridViewDSNhaXuatBan0.AutoGenerateColumns = false;
                myConection.Close();
            }
            else if (radTenNXB.Checked) 
            {
                string timkiemTNXB = "select * from tblNhaXuatBan where TenNXB like '%" + txtNDTimKiemNXB.Text + "%'";
                ketnoi(timkiemTNXB);
                myCommand.ExecuteNonQuery();
                dataGridViewDSNhaXuatBan0.DataSource = myTable;
                dataGridViewDSNhaXuatBan0.AutoGenerateColumns = false;
                myConection.Close();

            }
        }

        // thoat giao dien tra cuu thong tin nha xuat ban
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
