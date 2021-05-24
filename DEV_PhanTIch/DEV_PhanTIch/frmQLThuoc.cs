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
        DataThuocDataContext data = new DataThuocDataContext();
        public frmQLThuoc()
        {
            InitializeComponent();
        }

        private void frmQLThuoc_Load(object sender, EventArgs e)
        {
            gridDsThuoc.DataSource = thuoc.loadThuoc();
        }
        private void txtThongTin_TextChanged(object sender, EventArgs e)
        {
            if(cbPhuongThuc.SelectedItem.ToString() == "Mã Thuốc")
                gridKQTK.DataSource = data.Thuocs.Where(c => c.ma_thuoc.Contains(txtThongTin.Text));
            else if (cbPhuongThuc.SelectedItem.ToString() == "Tên Thuốc")
                gridKQTK.DataSource = data.Thuocs.Where(c => c.ten_thuoc.Contains(txtThongTin.Text));
            else if (cbPhuongThuc.SelectedItem.ToString() == "Mã Nhóm")
                gridKQTK.DataSource = data.Thuocs.Where(c => c.ma_nhom.Contains(txtThongTin.Text));
            else
                gridKQTK.DataSource = data.Thuocs.Where(c => c.cong_dung.Contains(txtThongTin.Text));
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtThongTin.Clear();

        }
    }
}