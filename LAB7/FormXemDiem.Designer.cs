namespace LAB7
{
    partial class FormXemDiem
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMaSo = new System.Windows.Forms.ComboBox();
            this.qLSVDataSet = new LAB7.QLSVDataSet();
            this.cbTenSV = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienTableAdapter = new LAB7.QLSVDataSetTableAdapters.SinhVienTableAdapter();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.ketQuaTableAdapter = new LAB7.QLSVDataSetTableAdapters.KetQuaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên SV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khoa";
            // 
            // cbMaSo
            // 
            this.cbMaSo.DataSource = this.sinhVienBindingSource;
            this.cbMaSo.DisplayMember = "MaSo";
            this.cbMaSo.FormattingEnabled = true;
            this.cbMaSo.Location = new System.Drawing.Point(76, 19);
            this.cbMaSo.Margin = new System.Windows.Forms.Padding(10);
            this.cbMaSo.Name = "cbMaSo";
            this.cbMaSo.Size = new System.Drawing.Size(150, 21);
            this.cbMaSo.TabIndex = 6;
            // 
            // qLSVDataSet
            // 
            this.qLSVDataSet.DataSetName = "QLSVDataSet";
            this.qLSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbTenSV
            // 
            this.cbTenSV.DataSource = this.sinhVienBindingSource;
            this.cbTenSV.DisplayMember = "HoTen";
            this.cbTenSV.FormattingEnabled = true;
            this.cbTenSV.Location = new System.Drawing.Point(76, 46);
            this.cbTenSV.Margin = new System.Windows.Forms.Padding(10);
            this.cbTenSV.Name = "cbTenSV";
            this.cbTenSV.Size = new System.Drawing.Size(150, 21);
            this.cbTenSV.TabIndex = 7;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(263, 73);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(90, 23);
            this.btnXem.TabIndex = 8;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(330, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.qLSVDataSet;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // cbKhoa
            // 
            this.cbKhoa.DataSource = this.sinhVienBindingSource;
            this.cbKhoa.DisplayMember = "MaKhoa";
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(76, 73);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(10);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(150, 21);
            this.cbKhoa.TabIndex = 10;
            // 
            // ketQuaTableAdapter
            // 
            this.ketQuaTableAdapter.ClearBeforeFill = true;
            // 
            // FormXemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 273);
            this.Controls.Add(this.cbKhoa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.cbTenSV);
            this.Controls.Add(this.cbMaSo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormXemDiem";
            this.Text = "Xem điểm";
            this.Load += new System.EventHandler(this.FormXemDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMaSo;
        private System.Windows.Forms.ComboBox cbTenSV;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLSVDataSet qLSVDataSet;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private QLSVDataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.ComboBox cbKhoa;
        private QLSVDataSetTableAdapters.KetQuaTableAdapter ketQuaTableAdapter;
    }
}