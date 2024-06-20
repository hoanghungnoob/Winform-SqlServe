using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InsertData
{
    public partial class Form1 : Form
    {
        private string maVT;
        private string tenVT;
        private string dvTinh;
        private string phanTram;
        string strCon = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=Quanlybanhang;Integrated Security=True";
        SqlConnection sqlCon = null;

        public Form1()
        {
            InitializeComponent();
            InitializeListView();
        }

        private void InitializeListView()
        {
            // Đặt chế độ View của ListView thành Details để hiển thị các cột

        }

        private void btnThemVT_Click(object sender, EventArgs e)
        {
            // Kiểm tra các ô nhập liệu có rỗng không
            if (string.IsNullOrEmpty(maVT) || string.IsNullOrEmpty(tenVT) || string.IsNullOrEmpty(dvTinh) || string.IsNullOrEmpty(phanTram))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                sqlCon = new SqlConnection(strCon);
                sqlCon.Open();

                // Tạo câu lệnh SQL để chèn dữ liệu
                string query = "INSERT INTO VATTU (MaVTu, TenVTu, DVTinh, PhanTram) VALUES (@MaVT, @TenVT, @DVTinh, @PhanTram)";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("@MaVT", maVT);
                sqlCmd.Parameters.AddWithValue("@TenVT", tenVT);
                sqlCmd.Parameters.AddWithValue("@DVTinh", dvTinh);
                sqlCmd.Parameters.AddWithValue("@PhanTram", phanTram);

                // Thực thi câu lệnh SQL
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Thêm dữ liệu thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Làm sạch các ô nhập liệu sau khi thêm dữ liệu
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

                // Làm mới dữ liệu trong ListView
                LoadDataToListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                // Đóng kết nối nếu mở
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        private void onChangeMaVT(object sender, EventArgs e)
        {
            this.maVT = textBox1.Text;
        }

        private void onChangeTenVT(object sender, EventArgs e)
        {
            this.tenVT = textBox2.Text;
        }

        private void onChangedvTinh(object sender, EventArgs e)
        {
            this.dvTinh = textBox3.Text;
        }

        private void onChangePhanTram(object sender, EventArgs e)
        {
            this.phanTram = textBox4.Text;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            LoadDataToListView();
        }

        private void LoadDataToListView()
        {
            lvVT.Items.Clear(); // Xóa dữ liệu hiện tại trong ListView

            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            SqlCommand sqlCmd = new SqlCommand("Select * from VATTU", sqlCon);
            SqlDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                string maVT = reader.GetString(0);
                string tenVT = reader.GetString(1);
                string dvTinh = reader.GetString(2);
                float phanTram = reader.GetFloat(3);
                ListViewItem lvi = new ListViewItem(maVT);
                lvi.SubItems.Add(tenVT);
                lvi.SubItems.Add(dvTinh);
                lvi.SubItems.Add(phanTram.ToString());

                lvVT.Items.Add(lvi);
            }
            reader.Close();
            sqlCon.Close(); // Đóng kết nối sau khi hoàn thành
        }
    }
}
