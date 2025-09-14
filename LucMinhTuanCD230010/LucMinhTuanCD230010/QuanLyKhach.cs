using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LucMinhTuanCD230010
{
    public partial class QuanLyKhach : Form
    {
        private SqlConnection conn = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyKhacSan;Integrated Security=True;TrustServerCertificate=True;
");
        private DataTable dtKhachHang;
        private int currentIndex = -1;

        public QuanLyKhach()
        {
            InitializeComponent();
        }

        private void QuanLyKhach_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            XoaForm();
        }

        private void LoadKhachHang()
        {
            try
            {
                string query = "SELECT KhachID, Ho, Ten, Email, DienThoai FROM KhachHang ORDER BY KhachID";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                dtKhachHang = new DataTable();
                da.Fill(dtKhachHang);

                dgvKhachHang.DataSource = dtKhachHang;
                dgvKhachHang.Columns["KhachID"].Width = 80;
                dgvKhachHang.Columns["Ho"].Width = 100;
                dgvKhachHang.Columns["Ten"].Width = 100;
                dgvKhachHang.Columns["Email"].Width = 150;
                dgvKhachHang.Columns["DienThoai"].Width = 120;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu khách hàng: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                try
                {
                    string query = "INSERT INTO KhachHang (Ho, Ten, Email, DienThoai) VALUES (@Ho, @Ten, @Email, @DienThoai)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Ho", txtHo.Text);
                    cmd.Parameters.AddWithValue("@Ten", txtTen.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (result > 0)
                    {
                        MessageBox.Show("Thêm khách hàng thành công!");
                        LoadKhachHang();
                        XoaForm();
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng thất bại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm khách hàng: " + ex.Message);
                    conn.Close();
                }
            }
        }

       

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKhachID.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần cập nhật!");
                return;
            }

            if (KiemTraDuLieu())
            {
                try
                {
                    int khachID = Convert.ToInt32(txtKhachID.Text);
                    string query = "UPDATE KhachHang SET Ho=@Ho, Ten=@Ten, Email=@Email, DienThoai=@DienThoai WHERE KhachID=@KhachID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Ho", txtHo.Text);
                    cmd.Parameters.AddWithValue("@Ten", txtTen.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text);
                    cmd.Parameters.AddWithValue("@KhachID", khachID);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật khách hàng thành công!");
                        LoadKhachHang();
                        XoaForm();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật khách hàng thất bại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật khách hàng: " + ex.Message);
                    conn.Close();
                }
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 0)
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        int khachID = Convert.ToInt32(txtKhachID.Text);
                        string query = "DELETE FROM KhachHang WHERE KhachID=@KhachID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@KhachID", khachID);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (result > 0)
                        {
                            MessageBox.Show("Xóa khách hàng thành công!");
                            LoadKhachHang();
                            XoaForm();
                        }
                        else
                        {
                            MessageBox.Show("Xóa khách hàng thất bại!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa khách hàng: " + ex.Message);
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string timKiem = txtTimKiem.Text.Trim();
            try
            {
                string query = "SELECT KhachID, Ho, Ten, Email, DienThoai FROM KhachHang " +
                               "WHERE Ho LIKE @TimKiem OR Ten LIKE @TimKiem OR Email LIKE @TimKiem " +
                               "ORDER BY KhachID";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@TimKiem", "%" + timKiem + "%");

                DataTable dtTimKiem = new DataTable();
                da.Fill(dtTimKiem);
                dgvKhachHang.DataSource = dtTimKiem;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadKhachHang();
            txtTimKiem.Clear();
            XoaForm();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                currentIndex = e.RowIndex;
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];

                txtKhachID.Text = row.Cells["KhachID"].Value.ToString();
                txtHo.Text = row.Cells["Ho"].Value.ToString();
                txtTen.Text = row.Cells["Ten"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtDienThoai.Text = row.Cells["DienThoai"].Value.ToString();
            }
        }

        private bool KiemTraDuLieu()
        {
            if (txtHo.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ!");
                txtHo.Focus();
                return false;
            }
            if (txtTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên!");
                txtTen.Focus();
                return false;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập email!");
                txtEmail.Focus();
                return false;
            }
            if (txtDienThoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!");
                txtDienThoai.Focus();
                return false;
            }
            return true;
        }

        private void XoaForm()
        {
            txtKhachID.Clear();
            txtHo.Clear();
            txtTen.Clear();
            txtEmail.Clear();
            txtDienThoai.Clear();
            currentIndex = -1;
        }
    }
}
