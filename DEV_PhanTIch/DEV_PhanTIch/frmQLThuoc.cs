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

        private void txtThongTin_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = gridDsThuoc.DataSource;
            if (cbPhuongThuc.SelectedItem.ToString() == "Mã Thuốc")
            {
                bs.Filter = "ma_thuoc like '%" + txtThongTin.Text + "%'";
                gridDsThuoc.DataSource = bs;
            }
            else if (cbPhuongThuc.SelectedItem.ToString() == "Mã Nhóm")
            {
                bs.Filter = "ma_nhom like '%" + txtThongTin.Text + "%'";
                gridDsThuoc.DataSource = bs;
            }
            else if (cbPhuongThuc.SelectedItem.ToString() == "Tên Thuốc")
            {
                bs.Filter = "ten_thuoc like '%" + txtThongTin.Text + "%'";
                gridDsThuoc.DataSource = bs;

            }
        }
    }
}