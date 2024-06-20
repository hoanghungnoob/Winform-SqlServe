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

namespace ConnectSQLServer.View
{
    public partial class TestQuery1 : Form
    {
        // chuỗi kết nối 
        string strCon = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=Quanlybanhang;Integrated Security=True";
        SqlConnection sqlCon = null;

        public TestQuery1()
        {
            InitializeComponent();
        }

        private void btnTruyVan_Click(object sender, EventArgs e)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            // đối tượng thực thi truy vấn
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select count(*) from VATTU";
            sqlCmd.Connection = sqlCon;  // Associate SqlCommand with SqlConnection

            try
            {
                // nhận kết quả
                int soLuong = (int)sqlCmd.ExecuteScalar();
                MessageBox.Show("So luong vat tu là: " + soLuong);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            // Prepare the command
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select MaVTu, TenVTu, DVTinh, PhanTram from VATTU where MaVTu = 'DD01'";
            sqlCmd.Connection = sqlCon;

            try
            {
                // Fill the DataTable
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCmd);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    string maVTu = row["MaVTu"].ToString();
                    string tenVTu = row["TenVTu"].ToString();
                    string DVTinh = row["DVTinh"].ToString();
                    int PhanTram = Convert.ToInt32(row["PhanTram"]);
                    MessageBox.Show($"MaVTu: {maVTu}, TenVTu: {tenVTu}, DVTinh: {DVTinh}, PhanTram: {PhanTram}");
                }
                else
                {
                    MessageBox.Show("No data found for MaVTu = 'DD01'");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void btnCloseProgram(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
