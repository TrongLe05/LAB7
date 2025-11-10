using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB7
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void tsBtnSinhVien_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FormSinhVien")
                {
                    f.Activate();
                    return;
                }
            }
            FormSinhVien sv = new FormSinhVien();
            sv.MdiParent = this;
            sv.Show();
        }

        private void tsBtnKhoa_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FormKhoa")
                {
                    f.Activate();
                    return;
                }
            }
            FormKhoa sv = new FormKhoa();
            sv.MdiParent = this;
            sv.Show();
        }

        private void tsBtnXemDiem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FormXemDiem")
                {
                    f.Activate();
                    return;
                }
            }
            FormXemDiem sv = new FormXemDiem();
            sv.MdiParent = this;
            sv.Show();
        }

        private void tsBtnNhapDiem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FormNhapDiem")
                {
                    f.Activate();
                    return;
                }
            }
            FormNhapDiem sv = new FormNhapDiem();
            sv.MdiParent = this;
            sv.Show();
        }

        private void tsBtnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsBtnMonHoc_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FormMonHoc")
                {
                    f.Activate();
                    return;
                }
            }
            FormMonHoc sv = new FormMonHoc();
            sv.MdiParent = this;
            sv.Show();
        }

        private void tsBtnThongKe_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FormThongKeKhoa")
                {
                    f.Activate();
                    return;
                }
            }
            FormThongKeKhoa sv = new FormThongKeKhoa();
            sv.MdiParent = this;
            sv.Show();
        }

        private void hỗTrợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "AboutQLSV")
                {
                    f.Activate();
                    return;
                }
            }
            AboutQLSV sv = new AboutQLSV();
            sv.MdiParent = this;
            sv.Show();
        }
    }
}
