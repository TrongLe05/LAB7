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
    public partial class FormMonHoc : Form
    {
        public FormMonHoc()
        {
            InitializeComponent();
        }

        private void monBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.monBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLSVDataSet);

        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSet.Mon' table. You can move, or remove it, as needed.
            this.monTableAdapter.Fill(this.qLSVDataSet.Mon);

        }
    }
}
