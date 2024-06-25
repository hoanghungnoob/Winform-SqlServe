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
using RibbonUIMaterial.View;
using RibbonUIMaterial.Model;

namespace RibbonUIMaterial
{
    public partial class Login : Form
    {
        string strCon = @"Data Source=msi\sqlexpress;Initial Catalog=TodoLists;Integrated Security=True;";
        SqlConnection sqlCon = null;

        private string name;
        private string pass;
        private string loggedInDisplayName;

        public Login()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.name = username.Text;
            this.pass = password.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please input username and password");
                return;
            }
            else
            {
                try
                {
                    // Gọi hàm Login từ lớp dbLogin để kiểm tra đăng nhập
                    DataTable dt = dbLogin.Login(name, pass);

                    // Kiểm tra kết quả từ hàm Login
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login successful");

                        // Đóng form Login
                        this.Hide();

                        // Mở Form1 và truyền tên người dùng đã đăng nhập vào
                        Form1 frm = new Form1(dt.Rows[0]["displayName"].ToString()); // Thay "displayName" bằng tên cột thực tế trong cơ sở dữ liệu
                        frm.ShowDialog();

                        // Sau khi Form1 đóng, đảm bảo thoát chương trình
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Login failed, please input correct username and password");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register registerForm = new Register();
            registerForm.ShowDialog();
          
            Application.Exit();
        }
    }
}
