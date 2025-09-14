namespace LucMinhTuanCD230010
{
    partial class BookingForm
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
            lblID = new Label();
            txtDatPhongID = new TextBox();
            lblKhach = new Label();
            cboKhachHang = new ComboBox();
            lblPhong = new Label();
            cboPhong = new ComboBox();
            lblNhan = new Label();
            dtpNhan = new DateTimePicker();
            lblTra = new Label();
            dtpTra = new DateTimePicker();
            btnLuu = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnLamMoi = new Button();
            dgvDatPhong = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDatPhong).BeginInit();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(20, 20);
            lblID.Name = "lblID";
            lblID.Size = new Size(80, 15);
            lblID.TabIndex = 0;
            lblID.Text = "Đặt phòng ID:";
            // 
            // txtDatPhongID
            // 
            txtDatPhongID.Location = new Point(120, 17);
            txtDatPhongID.Name = "txtDatPhongID";
            txtDatPhongID.ReadOnly = true;
            txtDatPhongID.Size = new Size(100, 23);
            txtDatPhongID.TabIndex = 1;
            // 
            // lblKhach
            // 
            lblKhach.AutoSize = true;
            lblKhach.Location = new Point(20, 60);
            lblKhach.Name = "lblKhach";
            lblKhach.Size = new Size(73, 15);
            lblKhach.TabIndex = 2;
            lblKhach.Text = "Khách hàng:";
            // 
            // cboKhachHang
            // 
            cboKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(120, 57);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(200, 23);
            cboKhachHang.TabIndex = 3;
            // 
            // lblPhong
            // 
            lblPhong.AutoSize = true;
            lblPhong.Location = new Point(20, 100);
            lblPhong.Name = "lblPhong";
            lblPhong.Size = new Size(45, 15);
            lblPhong.TabIndex = 4;
            lblPhong.Text = "Phòng:";
            // 
            // cboPhong
            // 
            cboPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhong.FormattingEnabled = true;
            cboPhong.Location = new Point(120, 97);
            cboPhong.Name = "cboPhong";
            cboPhong.Size = new Size(200, 23);
            cboPhong.TabIndex = 5;
            // 
            // lblNhan
            // 
            lblNhan.AutoSize = true;
            lblNhan.Location = new Point(20, 140);
            lblNhan.Name = "lblNhan";
            lblNhan.Size = new Size(106, 15);
            lblNhan.TabIndex = 6;
            lblNhan.Text = "Ngày nhận phòng:";
            // 
            // dtpNhan
            // 
            dtpNhan.Format = DateTimePickerFormat.Short;
            dtpNhan.Location = new Point(120, 137);
            dtpNhan.Name = "dtpNhan";
            dtpNhan.Size = new Size(200, 23);
            dtpNhan.TabIndex = 7;
            // 
            // lblTra
            // 
            lblTra.AutoSize = true;
            lblTra.Location = new Point(20, 180);
            lblTra.Name = "lblTra";
            lblTra.Size = new Size(93, 15);
            lblTra.TabIndex = 8;
            lblTra.Text = "Ngày trả phòng:";
            // 
            // dtpTra
            // 
            dtpTra.Format = DateTimePickerFormat.Short;
            dtpTra.Location = new Point(120, 177);
            dtpTra.Name = "dtpTra";
            dtpTra.Size = new Size(200, 23);
            dtpTra.TabIndex = 9;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(20, 220);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 25);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(110, 220);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(75, 25);
            btnCapNhat.TabIndex = 11;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(200, 220);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 25);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(20, 260);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(200, 23);
            txtTimKiem.TabIndex = 13;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(230, 260);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 25);
            btnTimKiem.TabIndex = 14;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(310, 260);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(75, 25);
            btnLamMoi.TabIndex = 15;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // dgvDatPhong
            // 
            dgvDatPhong.AllowUserToAddRows = false;
            dgvDatPhong.AllowUserToDeleteRows = false;
            dgvDatPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatPhong.Location = new Point(20, 300);
            dgvDatPhong.Name = "dgvDatPhong";
            dgvDatPhong.ReadOnly = true;
            dgvDatPhong.RowHeadersVisible = false;
            dgvDatPhong.Size = new Size(679, 200);
            dgvDatPhong.TabIndex = 16;
            dgvDatPhong.CellClick += dgvDatPhong_CellClick;
            // 
            // BookingForm
            // 
            ClientSize = new Size(721, 530);
            Controls.Add(dgvDatPhong);
            Controls.Add(btnLamMoi);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(btnXoa);
            Controls.Add(btnCapNhat);
            Controls.Add(btnLuu);
            Controls.Add(dtpTra);
            Controls.Add(lblTra);
            Controls.Add(dtpNhan);
            Controls.Add(lblNhan);
            Controls.Add(cboPhong);
            Controls.Add(lblPhong);
            Controls.Add(cboKhachHang);
            Controls.Add(lblKhach);
            Controls.Add(txtDatPhongID);
            Controls.Add(lblID);
            Name = "BookingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Đặt phòng";
            Load += BookingForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatPhong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtDatPhongID;
        private System.Windows.Forms.Label lblKhach;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.Label lblNhan;
        private System.Windows.Forms.DateTimePicker dtpNhan;
        private System.Windows.Forms.Label lblTra;
        private System.Windows.Forms.DateTimePicker dtpTra;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvDatPhong;
    }
}
