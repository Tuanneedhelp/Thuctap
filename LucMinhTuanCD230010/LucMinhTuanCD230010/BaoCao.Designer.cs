namespace LucMinhTuanCD230010
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            cboReport = new ComboBox();
            btnXem = new Button();
            btnExportExcel = new Button();
            btnXoa = new Button();
            dgvReport = new DataGridView();
            lblTong = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // cboReport
            // 
            cboReport.DropDownStyle = ComboBoxStyle.DropDownList;
            cboReport.FormattingEnabled = true;
            cboReport.Location = new Point(145, 104);
            cboReport.Name = "cboReport";
            cboReport.Size = new Size(219, 23);
            cboReport.TabIndex = 0;
            // 
            // btnXem
            // 
            btnXem.Location = new Point(145, 149);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(70, 23);
            btnXem.TabIndex = 1;
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = true;
            btnXem.Click += btnXem_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.LawnGreen;
            btnExportExcel.Location = new Point(423, 104);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(88, 23);
            btnExportExcel.TabIndex = 2;
            btnExportExcel.Text = "Xuất Excel";
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(294, 149);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(70, 23);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dgvReport
            // 
            dgvReport.AllowUserToAddRows = false;
            dgvReport.AllowUserToDeleteRows = false;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(24, 214);
            dgvReport.MultiSelect = false;
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.RowHeadersWidth = 51;
            dgvReport.RowTemplate.Height = 24;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.Size = new Size(648, 281);
            dgvReport.TabIndex = 5;
            // 
            // lblTong
            // 
            lblTong.AutoSize = true;
            lblTong.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblTong.Location = new Point(24, 510);
            lblTong.Name = "lblTong";
            lblTong.Size = new Size(0, 17);
            lblTong.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(219, 21);
            label1.Name = "label1";
            label1.Size = new Size(216, 32);
            label1.TabIndex = 7;
            label1.Text = "Báo cáo tổng quan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 104);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 8;
            label2.Text = "Chọn loại báo cáo";
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 550);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTong);
            Controls.Add(dgvReport);
            Controls.Add(btnXoa);
            Controls.Add(btnExportExcel);
            Controls.Add(btnXem);
            Controls.Add(cboReport);
            Name = "ReportsForm";
            Text = "Báo Cáo";
            Load += ReportsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboReport;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Label lblTong;
        private Label label1;
        private Label label2;
    }
}
