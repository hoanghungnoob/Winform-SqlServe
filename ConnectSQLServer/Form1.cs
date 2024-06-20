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

namespace ConnectSQLServer
{
    public partial class Form1 : Form
    {
        // chuỗi kết nối
        string strCon = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True";
        // đối tượng kết nối
        SqlConnection sqlCon = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMoKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                if(sqlCon == null)
                {
                    sqlCon = new SqlConnection(strCon); // rỗng thì tạo mới
                }
                //mở kết nối
                if(sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open(); // đóng thì mở lại
                    MessageBox.Show("Kết nối thành công");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnDongKetNoi_Click(object sender, EventArgs e)
        {
            if(sqlCon!= null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
                MessageBox.Show("Đóng kết nối thành công");
            }
            else
            {
                MessageBox.Show("Chưa tạo kết nối");
            }
        }
    }
}
