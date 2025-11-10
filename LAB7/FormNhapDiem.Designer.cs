namespace LAB7
{
    partial class FormNhapDiem
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMaSo = new System.Windows.Forms.ComboBox();
            this.cbHoTen = new System.Windows.Forms.ComboBox();
            this.cbMaMH = new System.Windows.Forms.ComboBox();
            this.cbTenMH = new System.Windows.Forms.ComboBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.qLSVDataSet = new LAB7.QLSVDataSet();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienTableAdapter = new LAB7.QLSVDataSetTableAdapters.SinhVienTableAdapter();
            this.monBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monTableAdapter = new LAB7.QLSVDataSetTableAdapters.MonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã môn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên môn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm";
            // 
            // cbMaSo
            // 
            this.cbMaSo.DataSource = this.sinhVienBindingSource;
            this.cbMaSo.DisplayMember = "MaSo";
            this.cbMaSo.FormattingEnabled = true;
            this.cbMaSo.Location = new System.Drawing.Point(82, 19);
            this.cbMaSo.Margin = new System.Windows.Forms.Padding(10);
            this.cbMaSo.Name = "cbMaSo";
            this.cbMaSo.Size = new System.Drawing.Size(121, 21);
            this.cbMaSo.TabIndex = 5;
            // 
            // cbHoTen
            // 
            this.cbHoTen.DataSource = this.sinhVienBindingSource;
            this.cbHoTen.DisplayMember = "HoTen";
            this.cbHoTen.FormattingEnabled = true;
            this.cbHoTen.Location = new System.Drawing.Point(82, 60);
            this.cbHoTen.Margin = new System.Windows.Forms.Padding(10);
            this.cbHoTen.Name = "cbHoTen";
            this.cbHoTen.Size = new System.Drawing.Size(121, 21);
            this.cbHoTen.TabIndex = 6;
            // 
            // cbMaMH
            // 
            this.cbMaMH.DataSource = this.monBindingSource;
            this.cbMaMH.DisplayMember = "MaMH";
            this.cbMaMH.FormattingEnabled = true;
            this.cbMaMH.Location = new System.Drawing.Point(82, 101);
            this.cbMaMH.Margin = new System.Windows.Forms.Padding(10);
            this.cbMaMH.Name = "cbMaMH";
            this.cbMaMH.Size = new System.Drawing.Size(121, 21);
            this.cbMaMH.TabIndex = 7;
            // 
            // cbTenMH
            // 
            this.cbTenMH.DataSource = this.monBindingSource;
            this.cbTenMH.DisplayMember = "TenMH";
            this.cbTenMH.FormattingEnabled = true;
            this.cbTenMH.Location = new System.Drawing.Point(82, 142);
            this.cbTenMH.Margin = new System.Windows.Forms.Padding(10);
            this.cbTenMH.Name = "cbTenMH";
            this.cbTenMH.Size = new System.Drawing.Size(121, 21);
            this.cbTenMH.TabIndex = 8;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(82, 183);
            this.txtDiem.Margin = new System.Windows.Forms.Padding(10);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(121, 20);
            this.txtDiem.TabIndex = 9;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(128, 216);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 10;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // qLSVDataSet
            // 
            this.qLSVDataSet.DataSetName = "QLSVDataSet";
            this.qLSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // monBindingSource
            // 
            this.monBindingSource.DataMember = "Mon";
            this.monBindingSource.DataSource = this.qLSVDataSet;
            // 
            // monTableAdapter
            // 
            this.monTableAdapter.ClearBeforeFill = true;
            // 
            // FormNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 246);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.cbTenMH);
            this.Controls.Add(this.cbMaMH);
            this.Controls.Add(this.cbHoTen);
            this.Controls.Add(this.cbMaSo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormNhapDiem";
            this.Text = "Nhập điểm";
            this.Load += new System.EventHandler(this.FormNhapDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMaSo;
        private System.Windows.Forms.ComboBox cbHoTen;
        private System.Windows.Forms.ComboBox cbMaMH;
        private System.Windows.Forms.ComboBox cbTenMH;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Button btnNhap;
        private QLSVDataSet qLSVDataSet;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private QLSVDataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.BindingSource monBindingSource;
        private QLSVDataSetTableAdapters.MonTableAdapter monTableAdapter;
    }
}