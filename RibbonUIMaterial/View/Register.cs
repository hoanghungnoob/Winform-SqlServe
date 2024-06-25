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


namespace RibbonUIMaterial.View
{
    public partial class Register : Form
    {
        private string Nickname;
        private string Username;
        private string Password;
        private string RePassword;
        string strCon = @"Data Source=msi\sqlexpress;Initial Catalog=TodoLists;Integrated Security=True;";
        SqlConnection sqlCon = null;
        public Register()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void register_Click(object sender, EventArgs e)
        {
            this.Nickname = nickname.Text;
            this.Username = username.Text;
            this.Password = password.Text;
            this.RePassword = repassword.Text;
            if (string.IsNullOrEmpty(Nickname) ||  string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(RePassword))
            {
                MessageBox.Show("Please input full information!");
            }
            else if (Password != RePassword)
            {
                MessageBox.Show("Password and password confirm not match");
            }
            else
            {
                try
                {
                    using (sqlCon = new SqlConnection(strCon))
                    {
                        sqlCon.Open();
                        string query = "INSERT INTO users (displayname, username, password) values (@Nickname,@Username, @Password)";
                        SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                        sqlCmd.Parameters.AddWithValue("@Nickname", Nickname);
                        sqlCmd.Parameters.AddWithValue("@Username", Username);
                        sqlCmd.Parameters.AddWithValue("@Password", Password);
                        int result = sqlCmd.ExecuteNonQuery(); // Use ExecuteNonQuery for INSERT

                        if (result > 0)
                        {
                            // edit dispaly message in MessageBox
                            MessageBox.Show("Registration successful!", "Succcessfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Login formLogin = new Login();
                            formLogin.ShowDialog();
                            this.Show();
                            Application.Exit();
                        }
                        else
                        {
                            MessageBox.Show("Registration failed!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void login_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.ShowDialog();

            Application.Exit();
        }
    }
}
