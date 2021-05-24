namespace DEV_PhanTIch
{
    partial class FrmBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TimKiem = new DevExpress.XtraEditors.TextEdit();
            this.btn_TimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_KetQua = new System.Windows.Forms.DataGridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_TongTien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txt_MaKH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_MaNV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_MaHD = new DevExpress.XtraEditors.TextEdit();
            this.btn_ThemThuoc = new DevExpress.XtraEditors.SimpleButton();
            this.btn_XoaThuoc = new DevExpress.XtraEditors.SimpleButton();
            this.btn_HuyThuoc = new DevExpress.XtraEditors.SimpleButton();
            this.btn_HuyHD = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.cbo_TimKiem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimKiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KetQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TongTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaHD.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(415, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(147, 39);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Đơn thuốc";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(51, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tìm kiếm";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(176, 49);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Tìm kiếm theo: ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(380, 47);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(86, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Thông tin tìm kiếm";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(380, 69);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(180, 20);
            this.txt_TimKiem.TabIndex = 5;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(588, 67);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiem.TabIndex = 6;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgv_KetQua);
            this.groupControl1.Location = new System.Drawing.Point(12, 92);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(776, 129);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Kết quả tìm kiếm";
            // 
            // dgv_KetQua
            // 
            this.dgv_KetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_KetQua.Location = new System.Drawing.Point(2, 23);
            this.dgv_KetQua.Name = "dgv_KetQua";
            this.dgv_KetQua.Size = new System.Drawing.Size(772, 104);
            this.dgv_KetQua.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dataGridView1);
            this.groupControl2.Location = new System.Drawing.Point(12, 256);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(334, 127);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "Chi tiết đơn thuốc";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(330, 102);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.dateTimePicker1);
            this.groupControl3.Controls.Add(this.txt_TongTien);
            this.groupControl3.Controls.Add(this.labelControl9);
            this.groupControl3.Controls.Add(this.labelControl8);
            this.groupControl3.Controls.Add(this.txt_MaKH);
            this.groupControl3.Controls.Add(this.labelControl7);
            this.groupControl3.Controls.Add(this.txt_MaNV);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.txt_MaHD);
            this.groupControl3.Location = new System.Drawing.Point(352, 227);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(334, 156);
            this.groupControl3.TabIndex = 9;
            this.groupControl3.Text = "Hóa đơn";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(83, 105);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(246, 21);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Location = new System.Drawing.Point(82, 130);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(247, 20);
            this.txt_TongTien.TabIndex = 18;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(31, 133);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(45, 13);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "Tổng tiền";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(26, 107);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(50, 13);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Ngày xuất";
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.EditValue = "";
            this.txt_MaKH.Location = new System.Drawing.Point(82, 78);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(247, 20);
            this.txt_MaKH.TabIndex = 5;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(4, 81);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(72, 13);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "Mã khách hàng";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(82, 52);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(247, 20);
            this.txt_MaNV.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 55);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(64, 13);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Mã nhân viên";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(20, 29);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Mã hóa đơn";
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Location = new System.Drawing.Point(82, 26);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Size = new System.Drawing.Size(247, 20);
            this.txt_MaHD.TabIndex = 0;
            // 
            // btn_ThemThuoc
            // 
            this.btn_ThemThuoc.Location = new System.Drawing.Point(14, 227);
            this.btn_ThemThuoc.Name = "btn_ThemThuoc";
            this.btn_ThemThuoc.Size = new System.Drawing.Size(75, 23);
            this.btn_ThemThuoc.TabIndex = 10;
            this.btn_ThemThuoc.Text = "Thêm thuốc";
            // 
            // btn_XoaThuoc
            // 
            this.btn_XoaThuoc.Location = new System.Drawing.Point(95, 227);
            this.btn_XoaThuoc.Name = "btn_XoaThuoc";
            this.btn_XoaThuoc.Size = new System.Drawing.Size(75, 23);
            this.btn_XoaThuoc.TabIndex = 11;
            this.btn_XoaThuoc.Text = "Xóa thuốc";
            // 
            // btn_HuyThuoc
            // 
            this.btn_HuyThuoc.Location = new System.Drawing.Point(271, 227);
            this.btn_HuyThuoc.Name = "btn_HuyThuoc";
            this.btn_HuyThuoc.Size = new System.Drawing.Size(75, 23);
            this.btn_HuyThuoc.TabIndex = 12;
            this.btn_HuyThuoc.Text = "Hủy";
            // 
            // btn_HuyHD
            // 
            this.btn_HuyHD.Location = new System.Drawing.Point(692, 283);
            this.btn_HuyHD.Name = "btn_HuyHD";
            this.btn_HuyHD.Size = new System.Drawing.Size(75, 50);
            this.btn_HuyHD.TabIndex = 14;
            this.btn_HuyHD.Text = "Hủy";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(692, 227);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 50);
            this.btn_Luu.TabIndex = 13;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // cbo_TimKiem
            // 
            this.cbo_TimKiem.FormattingEnabled = true;
            this.cbo_TimKiem.Location = new System.Drawing.Point(176, 69);
            this.cbo_TimKiem.Name = "cbo_TimKiem";
            this.cbo_TimKiem.Size = new System.Drawing.Size(168, 21);
            this.cbo_TimKiem.TabIndex = 15;
            // 
            // FrmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 390);
            this.Controls.Add(this.cbo_TimKiem);
            this.Controls.Add(this.btn_HuyHD);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_HuyThuoc);
            this.Controls.Add(this.btn_XoaThuoc);
            this.Controls.Add(this.btn_ThemThuoc);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmBanHang";
            this.Text = "Thêm thuốc";
            this.Load += new System.EventHandler(this.FrmBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimKiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KetQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TongTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaHD.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_TimKiem;
        private DevExpress.XtraEditors.SimpleButton btn_TimKiem;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgv_KetQua;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btn_ThemThuoc;
        private DevExpress.XtraEditors.SimpleButton btn_XoaThuoc;
        private DevExpress.XtraEditors.SimpleButton btn_HuyThuoc;
        private DevExpress.XtraEditors.SimpleButton btn_HuyHD;
        private DevExpress.XtraEditors.SimpleButton btn_Luu;
        private DevExpress.XtraEditors.TextEdit txt_MaNV;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_MaHD;
        private DevExpress.XtraEditors.TextEdit txt_TongTien;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txt_MaKH;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbo_TimKiem;
    }
}