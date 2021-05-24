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
            loadGridThuoc();
        }

        private void FrmBanHang_Load(object sender, EventArgs e)
        {
            dgv_KetQua.DataSource = xl.loadThuoc();
            addItemCBO();
        }

        public void loadGridThuoc()
        {
            dgv_KetQua.DataSource = xl.loadThuoc(txt_TimKiem.Text);
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                xl.themHoaDon(txt_MaHD.Text, txt_MaNV.Text, txt_MaKH.Text, dateTimePicker1.Value,int.Parse( txt_TongTien.Text));
                
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}