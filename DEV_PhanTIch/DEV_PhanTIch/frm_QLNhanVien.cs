﻿using System;
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
                
            }
            else
                MessageBox.Show("Nhân Viên này đã tồn tại hoặc bạn nhập sai định dạng");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (nv.editNV(txtmaNV.Text, txtHoTen.Text, cbgioitinh.SelectedItem.ToString(), int.Parse(txtTuoi.Text), txtDiaChi.Text, cbChucVu.SelectedItem.ToString(),txtEmail.Text, txtSDT.Text) == true)
            {
                MessageBox.Show("Sửa Nhân Viên Thành Công");
                gridDSNV.DataSource = nv.loadNV();
            }
            else
                MessageBox.Show("Sửa Thất Bại");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (nv.deleteNV(txtmaNV.Text))
            {
                MessageBox.Show("Xóa Nhân Viên Thành Công");
                gridDSNV.DataSource = nv.loadNV();
            }
            else
                MessageBox.Show("Xóa Thất Bại");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            nv.Luu();
            MessageBox.Show("LLưu Thành Công");
            gridDSNV.DataSource = nv.loadNV();
        }
    }
}