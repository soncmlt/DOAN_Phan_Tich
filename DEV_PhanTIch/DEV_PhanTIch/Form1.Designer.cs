﻿namespace DEV_PhanTIch
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.giớiThiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhậpThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpHóaĐơnNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýXuấtTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giớiThiệuToolStripMenuItem,
            this.quảnLýNhậpThuốcToolStripMenuItem,
            this.quảnLýXuấtTToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // giớiThiệuToolStripMenuItem
            // 
            this.giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            this.giớiThiệuToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.giớiThiệuToolStripMenuItem.Text = "Giới Thiệu";
            // 
            // quảnLýNhậpThuốcToolStripMenuItem
            // 
            this.quảnLýNhậpThuốcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtThuốcToolStripMenuItem,
            this.lậpHóaĐơnNhậpToolStripMenuItem});
            this.quảnLýNhậpThuốcToolStripMenuItem.Name = "quảnLýNhậpThuốcToolStripMenuItem";
            this.quảnLýNhậpThuốcToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.quảnLýNhậpThuốcToolStripMenuItem.Text = "Quản Lý Nhập Thuốc";
            // 
            // cậpNhậtThuốcToolStripMenuItem
            // 
            this.cậpNhậtThuốcToolStripMenuItem.Name = "cậpNhậtThuốcToolStripMenuItem";
            this.cậpNhậtThuốcToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cậpNhậtThuốcToolStripMenuItem.Text = "Cập Nhật Thuốc";
            this.cậpNhậtThuốcToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtThuốcToolStripMenuItem_Click);
            // 
            // lậpHóaĐơnNhậpToolStripMenuItem
            // 
            this.lậpHóaĐơnNhậpToolStripMenuItem.Name = "lậpHóaĐơnNhậpToolStripMenuItem";
            this.lậpHóaĐơnNhậpToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.lậpHóaĐơnNhậpToolStripMenuItem.Text = "Lập Hóa Đơn Nhập";
            // 
            // quảnLýXuấtTToolStripMenuItem
            // 
            this.quảnLýXuấtTToolStripMenuItem.Name = "quảnLýXuấtTToolStripMenuItem";
            this.quảnLýXuấtTToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.quảnLýXuấtTToolStripMenuItem.Text = "Quản Lý Xuất Thuốc";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản Lý Nhân Viên";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống Kê";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 278);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem giớiThiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhậpThuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtThuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpHóaĐơnNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýXuấtTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
    }
}
