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
    public partial class FormThongKeKhoa : Form
    {
        public FormThongKeKhoa()
        {
            InitializeComponent();
        }

        private void khoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khoaBindingSource.EndEdit();

        }

        private void FormThongKeKhoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSet.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.qLSVDataSet.Khoa);

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string conn = global::LAB7.Properties.Settings.Default.QLSVConnectionString;
            string str = string.Format("SELECT * FROM SinhVien WHERE MaKhoa = '{0}'", cbMaKhoa.Text);
            SqlDataAdapter da = new SqlDataAdapter(str, conn);
            DataSet ds = new DataSet();
            // đổ vào dataset
            da.Fill(ds);
            // hiển thị ra DataGridView
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
