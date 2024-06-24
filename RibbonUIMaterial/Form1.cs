using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace RibbonUIMaterial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
            this.IsMdiContainer = true;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            View.Home frm = new View.Home();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            
        }
    }
}
