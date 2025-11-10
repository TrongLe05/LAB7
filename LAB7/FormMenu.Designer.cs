namespace LAB7
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hỗTrợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsBtnSinhVien = new System.Windows.Forms.ToolStripButton();
            this.tsBtnKhoa = new System.Windows.Forms.ToolStripButton();
            this.tsBtnMonHoc = new System.Windows.Forms.ToolStripButton();
            this.tsBtnNhapDiem = new System.Windows.Forms.ToolStripButton();
            this.tsBtnXemDiem = new System.Windows.Forms.ToolStripButton();
            this.tsBtnThongKe = new System.Windows.Forms.ToolStripButton();
            this.tsBtnThoat = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.hỗTrợToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 2;
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "&Hệ thống";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "&Chức năng";
            // 
            // hỗTrợToolStripMenuItem
            // 
            this.hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            this.hỗTrợToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.hỗTrợToolStripMenuItem.Text = "&Hỗ trợ";
            this.hỗTrợToolStripMenuItem.Click += new System.EventHandler(this.hỗTrợToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnSinhVien,
            this.tsBtnKhoa,
            this.tsBtnMonHoc,
            this.tsBtnNhapDiem,
            this.toolStripSeparator1,
            this.tsBtnXemDiem,
            this.tsBtnThongKe,
            this.toolStripLabel1,
            this.tsBtnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 39);
            this.toolStrip1.TabIndex = 1;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 36);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Image = global::LAB7.Properties.Resources.user;
            this.toolStripStatusLabel2.Margin = new System.Windows.Forms.Padding(720, 3, 0, 2);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(46, 16);
            this.toolStripStatusLabel2.Text = "User";
            // 
            // tsBtnSinhVien
            // 
            this.tsBtnSinhVien.Image = global::LAB7.Properties.Resources.add_user;
            this.tsBtnSinhVien.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnSinhVien.Name = "tsBtnSinhVien";
            this.tsBtnSinhVien.Size = new System.Drawing.Size(91, 36);
            this.tsBtnSinhVien.Text = "Sinh viên";
            this.tsBtnSinhVien.Click += new System.EventHandler(this.tsBtnSinhVien_Click);
            // 
            // tsBtnKhoa
            // 
            this.tsBtnKhoa.Image = global::LAB7.Properties.Resources.staff;
            this.tsBtnKhoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnKhoa.Name = "tsBtnKhoa";
            this.tsBtnKhoa.Size = new System.Drawing.Size(70, 36);
            this.tsBtnKhoa.Text = "Khoa";
            this.tsBtnKhoa.Click += new System.EventHandler(this.tsBtnKhoa_Click);
            // 
            // tsBtnMonHoc
            // 
            this.tsBtnMonHoc.Image = global::LAB7.Properties.Resources.writing;
            this.tsBtnMonHoc.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnMonHoc.Name = "tsBtnMonHoc";
            this.tsBtnMonHoc.Size = new System.Drawing.Size(91, 36);
            this.tsBtnMonHoc.Text = "Môn học";
            this.tsBtnMonHoc.Click += new System.EventHandler(this.tsBtnMonHoc_Click);
            // 
            // tsBtnNhapDiem
            // 
            this.tsBtnNhapDiem.Image = global::LAB7.Properties.Resources.score;
            this.tsBtnNhapDiem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnNhapDiem.Name = "tsBtnNhapDiem";
            this.tsBtnNhapDiem.Size = new System.Drawing.Size(102, 36);
            this.tsBtnNhapDiem.Text = "Nhập điểm";
            this.tsBtnNhapDiem.Click += new System.EventHandler(this.tsBtnNhapDiem_Click);
            // 
            // tsBtnXemDiem
            // 
            this.tsBtnXemDiem.Image = global::LAB7.Properties.Resources.search;
            this.tsBtnXemDiem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnXemDiem.Name = "tsBtnXemDiem";
            this.tsBtnXemDiem.Size = new System.Drawing.Size(97, 36);
            this.tsBtnXemDiem.Text = "Xem điểm";
            this.tsBtnXemDiem.Click += new System.EventHandler(this.tsBtnXemDiem_Click);
            // 
            // tsBtnThongKe
            // 
            this.tsBtnThongKe.Image = global::LAB7.Properties.Resources.analytics;
            this.tsBtnThongKe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnThongKe.Name = "tsBtnThongKe";
            this.tsBtnThongKe.Size = new System.Drawing.Size(121, 36);
            this.tsBtnThongKe.Text = "Thống kê khoa";
            this.tsBtnThongKe.Click += new System.EventHandler(this.tsBtnThongKe_Click);
            // 
            // tsBtnThoat
            // 
            this.tsBtnThoat.Image = global::LAB7.Properties.Resources.right_arrow;
            this.tsBtnThoat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnThoat.Margin = new System.Windows.Forms.Padding(100, 1, 0, 2);
            this.tsBtnThoat.Name = "tsBtnThoat";
            this.tsBtnThoat.Size = new System.Drawing.Size(73, 36);
            this.tsBtnThoat.Text = "Thoát";
            this.tsBtnThoat.Click += new System.EventHandler(this.tsBtnThoat_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Quản lý sinh viên";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hỗTrợToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnSinhVien;
        private System.Windows.Forms.ToolStripButton tsBtnKhoa;
        private System.Windows.Forms.ToolStripButton tsBtnMonHoc;
        private System.Windows.Forms.ToolStripButton tsBtnNhapDiem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnXemDiem;
        private System.Windows.Forms.ToolStripButton tsBtnThongKe;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsBtnThoat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}