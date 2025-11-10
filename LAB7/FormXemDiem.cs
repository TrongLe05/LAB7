using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB7
{
    public partial class FormXemDiem : Form
    {
        public FormXemDiem()
        {
            InitializeComponent();
        }

        private void FormXemDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSet.KetQua' table. You can move, or remove it, as needed.
            this.ketQuaTableAdapter.Fill(this.qLSVDataSet.KetQua);
            // TODO: This line of code loads data into the 'qLSVDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.qLSVDataSet.SinhVien);

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            // lấy chuỗi connectionstring từ app.config
            string conn = global::LAB7.Properties.Settings.Default.QLSVConnectionString;
            // truy vấn lấy điểm các môn học của SV có mã số được chọn
            string str = string.Format("Select TenMH, Diem From KetQua,Mon where [KetQua].MaMH = [Mon].MaMH AND MaSo = {0}",cbMaSo.Text);
            SqlDataAdapter da = new SqlDataAdapter(str, conn);
            DataSet ds = new DataSet();
            // đổ vào dataset
            da.Fill(ds);
            // hiển thị ra DataGridView
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
