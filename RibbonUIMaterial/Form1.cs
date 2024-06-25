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
        private string nickName;
        public Form1(string name)
        {
            this.nickName = name;
            InitializeComponent(); 
            this.IsMdiContainer = true;
        }

        //to-do
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            View.Todo.Todo frm = new View.Todo.Todo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            View.Home frm = new View.Home(nickName);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            
        }
    }
}
