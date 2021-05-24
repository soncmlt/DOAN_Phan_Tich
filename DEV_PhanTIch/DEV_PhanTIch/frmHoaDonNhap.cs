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
    public partial class frmHoaDonNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmHoaDonNhap()
        {
            cbPhuongThuc.SelectedIndex = cbPhuongThuc.FindStringExact("Mã Hóa Đơn");
            InitializeComponent();
        }
        XuLiHoaDonNhap xl = new XuLiHoaDonNhap();
        private void cbPhuongThuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            loadhdNhap();
        }


        private void txtThongTin_TextChanged(object sender, EventArgs e)
        {
            loadhdNhap();
        }


        public void loadhdNhap()
        {
            if (cbPhuongThuc.SelectedItem.ToString() == "Mã Hóa Đơn")
            { gridKQTK.DataSource = xl.loadhd_MaHD(txtThongTin.Text); }
            else
            {
                gridKQTK.DataSource = xl.loadhd_MaNV(txtThongTin.Text);
            }
        }

    }
}