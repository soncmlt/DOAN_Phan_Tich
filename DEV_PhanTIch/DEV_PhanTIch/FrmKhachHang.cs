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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kh.ThemKH(txtmaKH.Text, txtHoTen.Text, cbgioitinh.SelectedItem.ToString(), int.Parse(txtTuoi.Text), txtSDT.Text))
            {
                MessageBox.Show("Thêm Khách Hàng Thành Công");

            }
            else
                MessageBox.Show("Khách Hàng Này Đã Tồn Tại");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            kh.Luu();
            gridDSKH.DataSource = kh.loadKH();
            MessageBox.Show("Lưu Thông Tin Thành Công");
        }
    }
}