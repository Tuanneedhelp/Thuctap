namespace LucMinhTuanCD230010
{
    partial class QuanLyKhach
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
            lblKhachID = new Label();
            txtKhachID = new TextBox();
            lblHo = new Label();
            txtHo = new TextBox();
            lblTen = new Label();
            txtTen = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblDienThoai = new Label();
            txtDienThoai = new TextBox();
            btnThem = new Button();
            btnLuu = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnLamMoi = new Button();
            groupBox1 = new GroupBox();
            dgvKhachHang = new DataGridView();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblKhachID
            // 
            lblKhachID.AutoSize = true;
            lblKhachID.Location = new Point(20, 30);
            lblKhachID.Name = "lblKhachID";
            lblKhachID.Size = new Size(57, 15);
            lblKhachID.TabIndex = 0;
            lblKhachID.Text = "Khách ID:";
            // 
            // txtKhachID
            // 
            txtKhachID.Location = new Point(100, 27);
            txtKhachID.Name = "txtKhachID";
            txtKhachID.ReadOnly = true;
            txtKhachID.Size = new Size(100, 23);
            txtKhachID.TabIndex = 1;
            // 
            // lblHo
            // 
            lblHo.AutoSize = true;
            lblHo.Location = new Point(20, 70);
            lblHo.Name = "lblHo";
            lblHo.Size = new Size(26, 15);
            lblHo.TabIndex = 2;
            lblHo.Text = "Họ:";
            // 
            // txtHo
            // 
            txtHo.Location = new Point(100, 67);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(150, 23);
            txtHo.TabIndex = 3;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(20, 110);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(28, 15);
            lblTen.TabIndex = 4;
            lblTen.Text = "Tên:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(100, 107);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(150, 23);
            txtTen.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 150);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(100, 147);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 7;
            // 
            // lblDienThoai
            // 
            lblDienThoai.AutoSize = true;
            lblDienThoai.Location = new Point(20, 190);
            lblDienThoai.Name = "lblDienThoai";
            lblDienThoai.Size = new Size(64, 15);
            lblDienThoai.TabIndex = 8;
            lblDienThoai.Text = "Điện thoại:";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(100, 187);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(150, 23);
            txtDienThoai.TabIndex = 9;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(360, 22);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 30);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(2, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(23, 10);
            btnLuu.TabIndex = 14;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(360, 70);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(75, 30);
            btnCapNhat.TabIndex = 12;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(360, 120);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 30);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(72, 32);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(59, 15);
            lblTimKiem.TabIndex = 1;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(152, 29);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(200, 23);
            txtTimKiem.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(371, 24);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 30);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(468, 24);
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
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(lblDienThoai);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(lblTen);
            groupBox1.Controls.Add(txtHo);
            groupBox1.Controls.Add(lblHo);
            groupBox1.Controls.Add(txtKhachID);
            groupBox1.Controls.Add(lblKhachID);
            groupBox1.Location = new Point(20, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(650, 229);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(20, 67);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(600, 200);
            dgvKhachHang.TabIndex = 0;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnLamMoi);
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(dgvKhachHang);
            groupBox2.Controls.Add(lblTimKiem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Location = new Point(20, 255);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(650, 280);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khách hàng";
            // 
            // QuanLyKhach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 534);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnLuu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "QuanLyKhach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý khách hàng";
            Load += QuanLyKhach_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblKhachID;
        private System.Windows.Forms.TextBox txtKhachID;
        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private DataGridView dgvKhachHang;
        private GroupBox groupBox2;
    }
}