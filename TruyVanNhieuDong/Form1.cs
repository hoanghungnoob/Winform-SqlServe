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

namespace TruyVanNhieuDong
{
    public partial class Form1 : Form
    {
        string strCon = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=Quanlybanhang;Integrated Security=True";
        SqlConnection sqlCon = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXemThongTin_Click(object sender, EventArgs e)
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
            sqlCmd.CommandText = "Select * from VATTU";

            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string MaVtu = reader.GetString(0);
                string tenVtu = reader.GetString(1);
                string dvTinh = reader.GetString(2);
                float phanTram = reader.GetFloat(3);

                ListViewItem lvi = new ListViewItem(MaVtu);
                lvi.SubItems.Add(tenVtu);
                lvi.SubItems.Add(dvTinh);
                lvi.SubItems.Add(phanTram.ToString());

                lsvThongtin.Items.Add(lvi);
               
            }
            reader.Close();
        }
    }
}
