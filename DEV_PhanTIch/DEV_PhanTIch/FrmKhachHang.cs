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
    public partial class FrmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        XuLiKhachHang kh = new XuLiKhachHang();
        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            gridDSKH.DataSource = kh.loadKH();
        }
    }
}