using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LucMinhTuanCD230010
{
    public partial class DangKy : Form
    {
        SqlConnection conn = new SqlConnection(
           @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyKhacSan;Integrated Security=True");

        public DangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string xacNhanMatKhau = txtXacNhanMatKhau.Text.Trim();
            string email = txtEmail.Text.Trim();
            string vaiTro = cboVaiTro.Text.Trim();


            if (tenDangNhap == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!");
                txtTenDangNhap.Focus();
                return;
            }
            if (matKhau == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                txtMatKhau.Focus();
                return;
            }
            if (xacNhanMatKhau == "")
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu!");
                txtXacNhanMatKhau.Focus();
                return;
            }
            if (email == "")
            {
                MessageBox.Show("Vui lòng nhập email!");
                txtEmail.Focus();
                return;
            }
            if (vaiTro == "")
            {
                MessageBox.Show("Vui lòng chọn vai trò!");
                cboVaiTro.Focus();
                return;
            }


            if (matKhau != xacNhanMatKhau)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp!");
                txtXacNhanMatKhau.Focus();
                return;
            }

            try
            {
                conn.Open();


                string checkUser = "SELECT COUNT(*) FROM NguoiDung WHERE TenDangNhap = @TenDangNhap";
                SqlCommand cmdCheck = new SqlCommand(checkUser, conn);
                cmdCheck.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                int count = (int)cmdCheck.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!");
                    txtTenDangNhap.Focus();
                    return;
                }


                string insert = "INSERT INTO NguoiDung (TenDangNhap, MatKhau, Email, VaiTro) " +
                                "VALUES (@TenDangNhap, @MatKhau, @Email, @VaiTro)";
                SqlCommand cmdInsert = new SqlCommand(insert, conn);
                cmdInsert.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                cmdInsert.Parameters.AddWithValue("@MatKhau", matKhau);
                cmdInsert.Parameters.AddWithValue("@Email", email);
                cmdInsert.Parameters.AddWithValue("@VaiTro", vaiTro);

                int rows = cmdInsert.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Đăng ký thành công!\n\n" +
                                    "Tên đăng nhập: " + tenDangNhap + "\n" +
                                    "Email: " + email + "\n" +
                                    "Vai trò: " + vaiTro);

                    // Xóa form
                    XoaForm();


                    DangNhap dangNhap = new DangNhap();
                    dangNhap.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại, vui lòng thử lại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            this.Hide();
        }

        private void XoaForm()
        {
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtXacNhanMatKhau.Clear();
            txtEmail.Clear();
            cboVaiTro.SelectedIndex = -1;
        }

       
    }
}
