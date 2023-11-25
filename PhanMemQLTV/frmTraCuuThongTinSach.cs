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
    public partial class frmTraCuuThongTinSach : Form
    {
        public frmTraCuuThongTinSach()
        {
            InitializeComponent();
        }

        string strKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConnection;
        private SqlCommand myCommand;
        private SqlDataAdapter myDataAdapter;
        private DataTable myTable;


        //ket noi toi sql 
        private DataTable ketnoi(string truyvan) 
        {
            myConnection = new SqlConnection(strKetNoi);
            myConnection.Open();
            string thuchiencaulenh = truyvan;
            myCommand = new SqlCommand(thuchiencaulenh, myConnection);
            myDataAdapter = new SqlDataAdapter(myCommand);
            myTable = new DataTable();
            myDataAdapter.Fill(myTable);
            dataGridViewDSSach0.DataSource = myTable;
            return myTable;
        }


        // tim kiem sach 
        private void txtNDTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (radMaSach.Checked)
            {
                string timkiemMS = "select * from tblSach where MaSach like '%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiemMS);
                myCommand.ExecuteNonQuery();
                dataGridViewDSSach0.DataSource = myTable;
                dataGridViewDSSach0.AutoGenerateColumns = false;
                myConnection.Close();
            }
            else if (radTenSach.Checked) 
            {
                string timkiemTS = "select * from tblSach where TenSach like N'%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiemTS);
                myCommand.ExecuteNonQuery();
                dataGridViewDSSach0.DataSource = ketnoi(timkiemTS);
                dataGridViewDSSach0.AutoGenerateColumns = false;
                myConnection.Close();
            }
            else if (radTenTG.Checked) 
            {
                string timkiemTG = "select * from tblSach where TacGia like N'%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiemTG);
                myCommand.ExecuteNonQuery();
                dataGridViewDSSach0.DataSource = myTable;
                dataGridViewDSSach0.AutoGenerateColumns = false;
                myConnection.Close();
            }
            else if (radTenCD.Checked) 
            {
                string timkiemCD = "select * from tblSach where ChuDe like N'%" + txtNDTimKiem.Text + "%'";
                ketnoi(timkiemCD);
                myCommand.ExecuteNonQuery();
                dataGridViewDSSach0.DataSource = myTable;
                dataGridViewDSSach0.AutoGenerateColumns = false;
                myConnection.Close();
            }
        }

        // thoat giao dien tra cuu thong tin sach
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        
    }
}
