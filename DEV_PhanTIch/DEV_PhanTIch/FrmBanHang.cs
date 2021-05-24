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
        
        public void addItemCBO()
        {
            cbo_TimKiem.Items.Add("Khách hàng");
            cbo_TimKiem.Items.Add("Thuốc");
            cbo_TimKiem.Items.Add("Đơn thuốc");
            cbo_TimKiem.SelectedItem="Khách hàng";
        }
    
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (cbo_TimKiem.SelectedIndex == 0)
                loadGridKhachHang();
            else
                loadGridThuoc();
        }

        private void FrmBanHang_Load(object sender, EventArgs e)
        {
            
            addItemCBO();
        }

        public void loadGridThuoc()
        {
            dgv_KetQua.DataSource = xl.loadThuoc(txt_TimKiem.Text);
        }
        public void loadGridKhachHang()
        {
            dgv_KetQua.DataSource = xl.loadKH(txt_TimKiem.Text);
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

        private void btn_ThemThuoc_Click(object sender, EventArgs e)
        {
            if (cbo_TimKiem.SelectedItem.ToString() == "Thuốc")
            {
                
            }
            else
                MessageBox.Show("Không thể thêm vào chi tiết đơn thuốc");
        }
    }
}