using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LucMinhTuanCD230010
{
    public partial class DangNhap : Form
    {
        SqlConnection conn = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyKhacSan;Integrated Security=True");

        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                conn.Close();
                // Kết nối thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối CSDL: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            // Kiểm tra dữ liệu đầu vào
            if (tenDangNhap == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!");
                return;
            }

            if (matKhau == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }

            // Kiểm tra đăng nhập từ DB
            if (KiemTraDangNhap(tenDangNhap, matKhau))
            {
                MessageBox.Show("Đăng nhập thành công!");

                // Mở form menu chính
                MenuChinh menuChinh = new MenuChinh();
                menuChinh.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                txtMatKhau.Clear();
            }
        }

        private bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            bool ketQua = false;
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM NguoiDung WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                int count = (int)cmd.ExecuteScalar();
                ketQua = count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra đăng nhập: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return ketQua;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThiMatKhau.Checked)
            {
                txtMatKhau.PasswordChar = '\0'; // Hiển thị mật khẩu
            }
            else
            {
                txtMatKhau.PasswordChar = '*'; // Ẩn mật khẩu
            }
        }

        private void lblDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Mở form đăng ký
            DangKy dangKy = new DangKy();
            dangKy.Show();
            this.Hide();
        }
    }
}
