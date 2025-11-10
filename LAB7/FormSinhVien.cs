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
    public partial class FormSinhVien : Form
    {
        public FormSinhVien()
        {
            InitializeComponent();
        }

        private void sinhVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sinhVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLSVDataSet);

        }

        private void FormSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.qLSVDataSet.SinhVien);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var db = new QLSVEntities())
            {
                SinhVien sv = new SinhVien()
                {
                    MaSo = int.Parse(maSoTextBox.Text),
                    HoTen = hoTenTextBox.Text,
                    NgaySinh = ngaySinhDateTimePicker.Value,
                    GioiTinh = gioiTinhCheckBox.Checked,
                    DiaChi = diaChiTextBox.Text,
                    DienThoai = int.Parse(dienThoaiTextBox.Text),
                    MaKhoa = maKhoaTextBox.Text
                };
                db.SinhVien.Add(sv);
                db.SaveChanges();
            }
            LoadData();
        }

        private void LoadData()
        {
            using (var db = new QLSVEntities())
            {
                sinhVienDataGridView.DataSource = db.SinhVien.ToList(); 
            }
        }
    }
}
