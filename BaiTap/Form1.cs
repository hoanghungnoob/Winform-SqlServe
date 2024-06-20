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
namespace BaiTap
{

    public partial class Form1 : Form
    {
        string strCon = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=Quanlybanhang;Integrated Security=True";
        SqlConnection sqlCon = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if(sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select * from NHACC";
            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string maNCC = reader.GetString(0);
                string tenNCC = reader.GetString(1);
                string line = maNCC + "/" + tenNCC;
                lsbNCC.Items.Add(line);

            }
            reader.Close();
        }

        private void lsbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsbNCC.SelectedIndex == -1)
            {
                return;
            }
            // Clear the ListView
            lsvDonDH.Items.Clear();
            string line = lsbNCC.SelectedItem.ToString();
            string[] arr = line.Split('/');
            string maNCC = arr[0];
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select * from DonDH where MaNCC = @maNCC";
            SqlParameter parmaNCC = new SqlParameter("@maNCC", SqlDbType.Char);
            parmaNCC.Value = maNCC.Trim();
            sqlCmd.Parameters.Add(parmaNCC);

            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string soDH = reader.GetString(0);
                DateTime NgayDH = reader.GetDateTime(1);

                ListViewItem lvi = new ListViewItem(soDH);
                lvi.SubItems.Add(NgayDH.ToString());
                lsvDonDH.Items.Add(lvi);
            }
            reader.Close();
        }
    }
}
