﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DEV_PhanTIch
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cậpNhậtThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatThuoc frmCapNhat = new CapNhatThuoc();
            frmCapNhat.MdiParent = this;
            frmCapNhat.Show();
        }
    }
}
