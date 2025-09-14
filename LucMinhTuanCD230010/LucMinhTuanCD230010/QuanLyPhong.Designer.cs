namespace LucMinhTuanCD230010
{
    partial class QuanLyPhong
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
            lblPhongID = new Label();
            txtPhongID = new TextBox();
            lblSoPhong = new Label();
            txtSoPhong = new TextBox();
            lblLoaiPhong = new Label();
            cboLoaiPhong = new ComboBox();
            lblGia = new Label();
            txtGia = new TextBox();
            lblTinhTrang = new Label();
            cboTinhTrang = new ComboBox();
            btnLuu = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            dgvPhong = new DataGridView();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnLamMoi = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvPhong).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblPhongID
            // 
            lblPhongID.AutoSize = true;
            lblPhongID.Location = new Point(20, 30);
            lblPhongID.Name = "lblPhongID";
            lblPhongID.Size = new Size(59, 15);
            lblPhongID.TabIndex = 0;
            lblPhongID.Text = "Phòng ID:";
            // 
            // txtPhongID
            // 
            txtPhongID.Location = new Point(100, 27);
            txtPhongID.Name = "txtPhongID";
            txtPhongID.ReadOnly = true;
            txtPhongID.Size = new Size(100, 23);
            txtPhongID.TabIndex = 1;
            // 
            // lblSoPhong
            // 
            lblSoPhong.AutoSize = true;
            lblSoPhong.Location = new Point(20, 70);
            lblSoPhong.Name = "lblSoPhong";
            lblSoPhong.Size = new Size(61, 15);
            lblSoPhong.TabIndex = 2;
            lblSoPhong.Text = "Số phòng:";
            // 
            // txtSoPhong
            // 
            txtSoPhong.Location = new Point(100, 67);
            txtSoPhong.Name = "txtSoPhong";
            txtSoPhong.Size = new Size(100, 23);
            txtSoPhong.TabIndex = 3;
            // 
            // lblLoaiPhong
            // 
            lblLoaiPhong.AutoSize = true;
            lblLoaiPhong.Location = new Point(20, 110);
            lblLoaiPhong.Name = "lblLoaiPhong";
            lblLoaiPhong.Size = new Size(70, 15);
            lblLoaiPhong.TabIndex = 4;
            lblLoaiPhong.Text = "Loại phòng:";
            // 
            // cboLoaiPhong
            // 
            cboLoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiPhong.FormattingEnabled = true;
            cboLoaiPhong.Items.AddRange(new object[] { "Đơn", "Đôi", "Cao Cấp" });
            cboLoaiPhong.Location = new Point(100, 107);
            cboLoaiPhong.Name = "cboLoaiPhong";
            cboLoaiPhong.Size = new Size(150, 23);
            cboLoaiPhong.TabIndex = 5;
            // 
            // lblGia
            // 
            lblGia.AutoSize = true;
            lblGia.Location = new Point(20, 150);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(27, 15);
            lblGia.TabIndex = 6;
            lblGia.Text = "Giá:";
            // 
            // txtGia
            // 
            txtGia.Location = new Point(100, 147);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(150, 23);
            txtGia.TabIndex = 7;
            // 
            // lblTinhTrang
            // 
            lblTinhTrang.AutoSize = true;
            lblTinhTrang.Location = new Point(20, 190);
            lblTinhTrang.Name = "lblTinhTrang";
            lblTinhTrang.Size = new Size(64, 15);
            lblTinhTrang.TabIndex = 8;
            lblTinhTrang.Text = "Tình trạng:";
            // 
            // cboTinhTrang
            // 
            cboTinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTinhTrang.FormattingEnabled = true;
            cboTinhTrang.Items.AddRange(new object[] { "Còn trống", "Đã đặt", "Bảo trì" });
            cboTinhTrang.Location = new Point(100, 187);
            cboTinhTrang.Name = "cboTinhTrang";
            cboTinhTrang.Size = new Size(150, 23);
            cboTinhTrang.TabIndex = 9;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(279, 43);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 30);
            btnLuu.TabIndex = 11;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(279, 102);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(75, 30);
            btnCapNhat.TabIndex = 12;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(279, 164);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 30);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dgvPhong
            // 
            dgvPhong.AllowUserToAddRows = false;
            dgvPhong.AllowUserToDeleteRows = false;
            dgvPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhong.Location = new Point(22, 66);
            dgvPhong.Name = "dgvPhong";
            dgvPhong.ReadOnly = true;
            dgvPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhong.Size = new Size(600, 200);
            dgvPhong.TabIndex = 0;
            dgvPhong.CellClick += dgvPhong_CellClick;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(76, 37);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(59, 15);
            lblTimKiem.TabIndex = 1;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(141, 32);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(200, 23);
            txtTimKiem.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(368, 27);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 30);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(487, 29);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(75, 30);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnCapNhat);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(cboTinhTrang);
            groupBox1.Controls.Add(lblTinhTrang);
            groupBox1.Controls.Add(txtGia);
            groupBox1.Controls.Add(lblGia);
            groupBox1.Controls.Add(cboLoaiPhong);
            groupBox1.Controls.Add(lblLoaiPhong);
            groupBox1.Controls.Add(txtSoPhong);
            groupBox1.Controls.Add(lblSoPhong);
            groupBox1.Controls.Add(txtPhongID);
            groupBox1.Controls.Add(lblPhongID);
            groupBox1.Location = new Point(20, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(650, 230);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phòng";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnLamMoi);
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(dgvPhong);
            groupBox2.Controls.Add(lblTimKiem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Location = new Point(20, 257);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(650, 280);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách phòng";
            // 
            // QuanLyPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 549);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "QuanLyPhong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý phòng";
            Load += QuanLyPhong_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPhong).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblPhongID;
        private System.Windows.Forms.TextBox txtPhongID;
        private System.Windows.Forms.Label lblSoPhong;
        private System.Windows.Forms.TextBox txtSoPhong;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}