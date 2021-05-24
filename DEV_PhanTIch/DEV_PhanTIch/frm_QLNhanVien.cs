using System;
using System.Linq;
using System.Windows.Forms;

namespace DEV_PhanTIch
{
    public partial class frm_QLNhanVien : DevExpress.XtraEditors.XtraForm
    {
        XuLiNhanVien nv = new XuLiNhanVien();
        public frm_QLNhanVien()
        {
            InitializeComponent();
        }

        private void frm_QLNhanVien_Load(object sender, EventArgs e)
        {
            gridDSNV.DataSource = nv.loadNV();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (nv.ThemNV(txtmaNV.Text, txtHoTen.Text, cbgioitinh.SelectedItem.ToString(), int.Parse(txtTuoi.Text), txtDiaChi.Text, cbChucVu.SelectedItem.ToString(), txtSDT.Text) == true)
            {
                MessageBox.Show("Thêm Nhân Viên Thành Công");
                gridDSNV.DataSource = nv.loadNV();
            }
            else
                MessageBox.Show("Nhân Viên này đã tồn tại hoặc bạn nhập sai định dạng");
        }
    }
}