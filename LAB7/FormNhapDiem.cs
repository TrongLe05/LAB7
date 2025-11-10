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
    public partial class FormNhapDiem : Form
    {
        public FormNhapDiem()
        {
            InitializeComponent();
        }

        private void FormNhapDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSet.Mon' table. You can move, or remove it, as needed.
            this.monTableAdapter.Fill(this.qLSVDataSet.Mon);
            // TODO: This line of code loads data into the 'qLSVDataSet.Mon' table. You can move, or remove it, as needed.
            this.monTableAdapter.Fill(this.qLSVDataSet.Mon);
            // TODO: This line of code loads data into the 'qLSVDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.qLSVDataSet.SinhVien);

        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            string connStr = global::LAB7.Properties.Settings.Default.QLSVConnectionString;
            string str = string.Format("INSERT INTO KetQua (MaSo, MaMH, Diem) VALUES ({0}, '{1}', {2})", cbMaSo.Text, cbMaMH.Text, txtDiem.Text);
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            txtDiem.Clear();
            MessageBox.Show("Thêm dữ liệu thành công!");
        }
    }
}
