using System;
using System.Windows.Forms;

namespace LucMinhTuanCD230010
{
    public partial class MenuChinh : Form
    {
        public MenuChinh()
        {
            InitializeComponent();
        }

        private void quanLyKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mở form Quản lý khách hàng
            QuanLyKhach form = new QuanLyKhach();
            form.Show();
        }

        private void quanLyPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mở form Quản lý phòng
            QuanLyPhong form = new QuanLyPhong();
            form.Show();
        }

        private void quanLyDatPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mở form Đặt phòng
            BookingForm form = new BookingForm();
            form.Show();
        }

        private void quanLyThanhToanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mở form Thanh toán
            ThanhToan form = new ThanhToan();
            form.Show();
        }

        private void baoCaotoolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mở form Báo cáo
            ReportsForm form = new ReportsForm();
            form.Show();
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hỏi xác nhận trước khi đăng xuất
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide(); // Ẩn form chính
                DangNhap formDangNhap = new DangNhap();
                formDangNhap.Show();
            }
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hỏi xác nhận trước khi thoát
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
