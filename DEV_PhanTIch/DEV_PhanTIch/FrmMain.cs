﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace DEV_PhanTIch
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public void ViewChildForm(Form _form)
        {
            if (!IsFormActive(_form))
            {
                _form.MdiParent = this;
                _form.Show();
            }
        }
        public bool IsFormActive(Form form)
        {
            bool Isopend = false;
            if (MdiChildren.Count() > 0)
            {
                foreach (var item in MdiChildren)
                {
                    if (form.Name == item.Name)
                    {
                        xtraTabbedMdiManager1.Pages[item].MdiChild.Activate();
                        Isopend = true;
                    }

                }
            }
            return Isopend;
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQLThuoc frm = new frmQLThuoc();
            frm.Name = "Quản Lý Thuốc";
            ViewChildForm(frm);
        }
    }
}