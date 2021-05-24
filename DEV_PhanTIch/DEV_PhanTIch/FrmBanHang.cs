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
    public partial class FrmBanHang : DevExpress.XtraEditors.XtraForm
    {
        XuLiBanHang xl =new XuLiBanHang();
        public FrmBanHang()
        {
            InitializeComponent();
        }
        
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmBanHang_Load(object sender, EventArgs e)
        {
            dgv_KetQua.DataSource = xl.loadThuoc();
        }
    }
}