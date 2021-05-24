using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DEV_PhanTIch
{
    public partial class frmQLThuoc : DevExpress.XtraEditors.XtraForm
    {
        XuLiThuoc thuoc = new XuLiThuoc();
        public frmQLThuoc()
        {
            InitializeComponent();
        }

        private void frmQLThuoc_Load(object sender, EventArgs e)
        {
            gridDsThuoc.DataSource = thuoc.loadThuoc();
        }
    }
}