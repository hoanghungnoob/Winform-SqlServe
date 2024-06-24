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
namespace RibbonUIMaterial
{
    public partial class Login : Form
    {
        string strCon = @"Data Source=msi\sqlexpress;Initial Catalog=testLogin;Integrated Security=True;";
        SqlConnection sqlCon = null;

        private string name;
        private string pass;
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
                MessageBox.Show("Please input name and password");
                return;
            }
            else
            {
                try
                {
                    using (sqlCon = new SqlConnection(strCon))
                    {
                        sqlCon.Open();
                        string query = "SELECT COUNT(1) FROM login WHERE name=@Username AND password=@Password";
                        SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                        sqlCmd.Parameters.AddWithValue("@Username", name);
                        sqlCmd.Parameters.AddWithValue("@Password", pass);
                        int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                        if (count == 1)
                        {
                            MessageBox.Show("Login successfull");
                            // Đóng form Login
                            this.Hide();

                            // Mở Form1
                            Form1 frm = new Form1();
                            frm.ShowDialog();

                            // Sau khi Form1 đóng, đảm bảo thoát chương trình
                            Application.Exit();
                        }
                        else
                        {
                            MessageBox.Show("Login failed, please input username and password correctly");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
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
