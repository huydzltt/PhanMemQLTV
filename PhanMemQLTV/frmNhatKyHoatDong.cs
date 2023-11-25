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
    public partial class frmNhatKyHoatDong : Form
    {
        public frmNhatKyHoatDong()
        {
            InitializeComponent();
        }

        //string chuoiKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        //private SqlConnection myConnection; // ket noi toi csdl
        //private SqlDataAdapter myDataAdapter; // chuyen csdl qua dataset
        //private DataTable myTable; // Luu bang 
        //SqlCommand myCommand; // thuc hien cac lenh truy van

        ////phuong thuc ket noi
        //private DataTable ketnoi(string truyvan) 
        //{
        //    myConnection = new SqlConnection(chuoiKetNoi);
        //    myConnection.Open();
        //    string thuchiencautruyvan = truyvan;
        //    myCommand = new SqlCommand(thuchiencautruyvan, myConnection);
        //    myDataAdapter = new SqlDataAdapter(myCommand);
        //    myTable = new DataTable();
        //    myDataAdapter.Fill(myTable);
        //    dgvNhatKyHoatDong.DataSource = myTable;
        //    return myTable;
        //}

        //// lay du lieu len dgv
        //private void frmNhatKyHoatDong_Load(object sender, EventArgs e)
        //{
        //    string cauTruyVan = "select * from tblNhatKyHoatDong";
        //    dgvNhatKyHoatDong.DataSource = ketnoi(cauTruyVan);
        //    dgvNhatKyHoatDong.AutoGenerateColumns = false;
        //    myConnection.Close();
        //    dgvNhatKyHoatDong.Enabled = true;
        //}

        //// thoat
        //private void btnThoat_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        
    }
}
