using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RibbonUIMaterial.View.Todo
{
    public partial class Todo : DevExpress.XtraEditors.XtraForm
    {
        public Todo()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Create frm = new Create();
            frm.Show();
        }
    }
}