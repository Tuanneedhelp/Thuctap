namespace LucMinhTuanCD230010
{
    partial class ThanhToan
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            lblThanhToanID = new Label();
            txtThanhToanID = new TextBox();
            lblSoPhong = new Label();
            cboSoPhong = new ComboBox();
            lblTenKhachHang = new Label();
            txtTenKhachHang = new TextBox();
            lblNgayNhan = new Label();
            dtpNgayNhan = new DateTimePicker();
            lblNgayTra = new Label();
            dtpNgayTra = new DateTimePicker();
            lblSoTien = new Label();
            txtSoTien = new TextBox();
            lblPhuongThuc = new Label();
            cboPhuongThuc = new ComboBox();
            lblNgayTT = new Label();
            dtpNgayTT = new DateTimePicker();
            btnLuu = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dgvThanhToan = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvThanhToan).BeginInit();
            SuspendLayout();
            // 
            // lblThanhToanID
            // 
            lblThanhToanID.AutoSize = true;
            lblThanhToanID.Location = new Point(20, 20);
            lblThanhToanID.Name = "lblThanhToanID";
            lblThanhToanID.Size = new Size(88, 15);
            lblThanhToanID.TabIndex = 0;
            lblThanhToanID.Text = "Mã thanh toán:";
            // 
            // txtThanhToanID
            // 
            txtThanhToanID.Location = new Point(130, 17);
            txtThanhToanID.Name = "txtThanhToanID";
            txtThanhToanID.ReadOnly = true;
            txtThanhToanID.Size = new Size(180, 23);
            txtThanhToanID.TabIndex = 1;
            // 
            // lblSoPhong
            // 
            lblSoPhong.AutoSize = true;
            lblSoPhong.Location = new Point(20, 55);
            lblSoPhong.Name = "lblSoPhong";
            lblSoPhong.Size = new Size(61, 15);
            lblSoPhong.TabIndex = 2;
            lblSoPhong.Text = "Số phòng:";
            // 
            // cboSoPhong
            // 
            cboSoPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSoPhong.Location = new Point(130, 52);
            cboSoPhong.Name = "cboSoPhong";
            cboSoPhong.Size = new Size(180, 23);
            cboSoPhong.TabIndex = 3;
            cboSoPhong.SelectedIndexChanged += cboSoPhong_SelectedIndexChanged;
            // 
            // lblTenKhachHang
            // 
            lblTenKhachHang.AutoSize = true;
            lblTenKhachHang.Location = new Point(20, 90);
            lblTenKhachHang.Name = "lblTenKhachHang";
            lblTenKhachHang.Size = new Size(93, 15);
            lblTenKhachHang.TabIndex = 4;
            lblTenKhachHang.Text = "Tên khách hàng:";
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(130, 87);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.ReadOnly = true;
            txtTenKhachHang.Size = new Size(250, 23);
            txtTenKhachHang.TabIndex = 5;
            // 
            // lblNgayNhan
            // 
            lblNgayNhan.AutoSize = true;
            lblNgayNhan.Location = new Point(20, 125);
            lblNgayNhan.Name = "lblNgayNhan";
            lblNgayNhan.Size = new Size(68, 15);
            lblNgayNhan.TabIndex = 6;
            lblNgayNhan.Text = "Ngày nhận:";
            // 
            // dtpNgayNhan
            // 
            dtpNgayNhan.Enabled = false;
            dtpNgayNhan.Location = new Point(130, 122);
            dtpNgayNhan.Name = "dtpNgayNhan";
            dtpNgayNhan.Size = new Size(200, 23);
            dtpNgayNhan.TabIndex = 7;
            // 
            // lblNgayTra
            // 
            lblNgayTra.AutoSize = true;
            lblNgayTra.Location = new Point(20, 160);
            lblNgayTra.Name = "lblNgayTra";
            lblNgayTra.Size = new Size(55, 15);
            lblNgayTra.TabIndex = 8;
            lblNgayTra.Text = "Ngày trả:";
            // 
            // dtpNgayTra
            // 
            dtpNgayTra.Enabled = false;
            dtpNgayTra.Location = new Point(130, 157);
            dtpNgayTra.Name = "dtpNgayTra";
            dtpNgayTra.Size = new Size(200, 23);
            dtpNgayTra.TabIndex = 9;
            // 
            // lblSoTien
            // 
            lblSoTien.AutoSize = true;
            lblSoTien.Location = new Point(20, 195);
            lblSoTien.Name = "lblSoTien";
            lblSoTien.Size = new Size(46, 15);
            lblSoTien.TabIndex = 10;
            lblSoTien.Text = "Số tiền:";
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(130, 192);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.ReadOnly = true;
            txtSoTien.Size = new Size(180, 23);
            txtSoTien.TabIndex = 11;
            // 
            // lblPhuongThuc
            // 
            lblPhuongThuc.AutoSize = true;
            lblPhuongThuc.Location = new Point(20, 230);
            lblPhuongThuc.Name = "lblPhuongThuc";
            lblPhuongThuc.Size = new Size(79, 15);
            lblPhuongThuc.TabIndex = 12;
            lblPhuongThuc.Text = "Phương thức:";
            // 
            // cboPhuongThuc
            // 
            cboPhuongThuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhuongThuc.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản", "Thẻ" });
            cboPhuongThuc.Location = new Point(130, 227);
            cboPhuongThuc.Name = "cboPhuongThuc";
            cboPhuongThuc.Size = new Size(180, 23);
            cboPhuongThuc.TabIndex = 13;
            // 
            // lblNgayTT
            // 
            lblNgayTT.AutoSize = true;
            lblNgayTT.Location = new Point(20, 265);
            lblNgayTT.Name = "lblNgayTT";
            lblNgayTT.Size = new Size(99, 15);
            lblNgayTT.TabIndex = 14;
            lblNgayTT.Text = "Ngày thanh toán:";
            // 
            // dtpNgayTT
            // 
            dtpNgayTT.Location = new Point(130, 262);
            dtpNgayTT.Name = "dtpNgayTT";
            dtpNgayTT.Size = new Size(200, 23);
            dtpNgayTT.TabIndex = 15;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(420, 20);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(90, 30);
            btnLuu.TabIndex = 16;
            btnLuu.Text = "Lưu";
            btnLuu.Click += btnLuu_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(420, 60);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(90, 30);
            btnCapNhat.TabIndex = 17;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(420, 100);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 30);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(501, 300);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(90, 30);
            btnLamMoi.TabIndex = 19;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(20, 305);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(59, 15);
            lblTimKiem.TabIndex = 20;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(130, 302);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(250, 23);
            txtTimKiem.TabIndex = 21;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(390, 300);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(91, 30);
            btnTimKiem.TabIndex = 22;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dgvThanhToan
            // 
            dgvThanhToan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThanhToan.Location = new Point(20, 340);
            dgvThanhToan.Name = "dgvThanhToan";
            dgvThanhToan.Size = new Size(775, 200);
            dgvThanhToan.TabIndex = 23;
            dgvThanhToan.CellClick += dgvThanhToan_CellClick;
            // 
            // ThanhToan
            // 
            ClientSize = new Size(807, 570);
            Controls.Add(lblThanhToanID);
            Controls.Add(txtThanhToanID);
            Controls.Add(lblSoPhong);
            Controls.Add(cboSoPhong);
            Controls.Add(lblTenKhachHang);
            Controls.Add(txtTenKhachHang);
            Controls.Add(lblNgayNhan);
            Controls.Add(dtpNgayNhan);
            Controls.Add(lblNgayTra);
            Controls.Add(dtpNgayTra);
            Controls.Add(lblSoTien);
            Controls.Add(txtSoTien);
            Controls.Add(lblPhuongThuc);
            Controls.Add(cboPhuongThuc);
            Controls.Add(lblNgayTT);
            Controls.Add(dtpNgayTT);
            Controls.Add(btnLuu);
            Controls.Add(btnCapNhat);
            Controls.Add(btnXoa);
            Controls.Add(btnLamMoi);
            Controls.Add(lblTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(dgvThanhToan);
            Name = "ThanhToan";
            Text = "Quản lý thanh toán";
            Load += ThanhToan_Load;
            ((System.ComponentModel.ISupportInitialize)dgvThanhToan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblThanhToanID;
        private System.Windows.Forms.TextBox txtThanhToanID;
        private System.Windows.Forms.Label lblSoPhong;
        private System.Windows.Forms.ComboBox cboSoPhong;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label lblNgayNhan;
        private System.Windows.Forms.DateTimePicker dtpNgayNhan;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Label lblPhuongThuc;
        private System.Windows.Forms.ComboBox cboPhuongThuc;
        private System.Windows.Forms.Label lblNgayTT;
        private System.Windows.Forms.DateTimePicker dtpNgayTT;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvThanhToan;
    }
}
