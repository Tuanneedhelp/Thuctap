using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace LucMinhTuanCD230010
{
    public partial class ThanhToan : Form
    {
        SqlConnection conn = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyKhacSan;Integrated Security=True;TrustServerCertificate=True");

        public ThanhToan()
        {
            InitializeComponent();
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            LoadSoPhong();
            LoadThanhToan();
        }

        // Load danh sách phòng đã được đặt
        private void LoadSoPhong()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn.ConnectionString))
                {
                    con.Open();
                    string sql = @"
                        SELECT dp.DatPhongID, p.SoPhong, k.Ho + ' ' + k.Ten AS TenKhach,
                               dp.NgayNhanPhong, dp.NgayTraPhong, p.Gia
                        FROM DatPhong dp
                        JOIN Phong p ON dp.PhongID = p.PhongID
                        JOIN KhachHang k ON dp.KhachID = k.KhachID";
                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboSoPhong.DataSource = dt;
                    cboSoPhong.DisplayMember = "SoPhong";
                    cboSoPhong.ValueMember = "DatPhongID";
                    cboSoPhong.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi LoadSoPhong: " + ex.Message);
            }
        }

        private void cboSoPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSoPhong.SelectedIndex < 0) return;

            var drv = cboSoPhong.SelectedItem as DataRowView;
            if (drv != null)
            {
                txtTenKhachHang.Text = drv["TenKhach"]?.ToString() ?? "";

                if (drv["NgayNhanPhong"] != DBNull.Value &&
                    DateTime.TryParse(drv["NgayNhanPhong"].ToString(), out DateTime nn))
                    dtpNgayNhan.Value = nn;

                if (drv["NgayTraPhong"] != DBNull.Value &&
                    DateTime.TryParse(drv["NgayTraPhong"].ToString(), out DateTime nt))
                    dtpNgayTra.Value = nt;

                // Tính số tiền
                if (drv["Gia"] != DBNull.Value &&
                    decimal.TryParse(drv["Gia"].ToString(), out decimal giaPhong))
                {
                    int soNgay = (int)(dtpNgayTra.Value.Date - dtpNgayNhan.Value.Date).TotalDays;
                    if (soNgay < 1) soNgay = 1; // ít nhất 1 ngày
                    decimal tongTien = soNgay * giaPhong;
                    txtSoTien.Text = tongTien.ToString("N0");
                }
            }
        }

        private void LoadThanhToan()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn.ConnectionString))
                {
                    con.Open();
                    string sql = @"
                        SELECT t.ThanhToanID, t.DatPhongID, p.SoPhong, 
                               k.Ho + ' ' + k.Ten AS TenKhach,
                               dp.NgayNhanPhong, dp.NgayTraPhong, p.Gia, 
                               t.SoTien, t.PhuongThuc, t.NgayTT
                        FROM ThanhToan t
                        JOIN DatPhong dp ON t.DatPhongID = dp.DatPhongID
                        JOIN Phong p ON dp.PhongID = p.PhongID
                        JOIN KhachHang k ON dp.KhachID = k.KhachID
                        ORDER BY t.ThanhToanID DESC";
                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvThanhToan.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi LoadThanhToan: " + ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboSoPhong.SelectedIndex < 0)
                {
                    MessageBox.Show("Vui lòng chọn số phòng.");
                    return;
                }
                if (!decimal.TryParse(txtSoTien.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal soTien))
                {
                    MessageBox.Show("Số tiền không hợp lệ.");
                    return;
                }
                if (cboPhuongThuc.SelectedIndex < 0)
                {
                    MessageBox.Show("Vui lòng chọn phương thức thanh toán.");
                    return;
                }

                using (SqlConnection con = new SqlConnection(conn.ConnectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "INSERT INTO ThanhToan (DatPhongID, SoTien, PhuongThuc, NgayTT) VALUES (@DatPhongID, @SoTien, @PhuongThuc, @NgayTT)", con))
                    {
                        cmd.Parameters.AddWithValue("@DatPhongID", cboSoPhong.SelectedValue);
                        cmd.Parameters.AddWithValue("@SoTien", soTien);
                        cmd.Parameters.AddWithValue("@PhuongThuc", cboPhuongThuc.Text);
                        cmd.Parameters.AddWithValue("@NgayTT", dtpNgayTT.Value.Date);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadThanhToan();
                MessageBox.Show("Thêm thanh toán thành công.");
                btnLamMoi_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtThanhToanID.Text))
                {
                    MessageBox.Show("Vui lòng chọn bản ghi để cập nhật.");
                    return;
                }
                if (!decimal.TryParse(txtSoTien.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal soTien))
                {
                    MessageBox.Show("Số tiền không hợp lệ.");
                    return;
                }

                using (SqlConnection con = new SqlConnection(conn.ConnectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "UPDATE ThanhToan SET DatPhongID=@DatPhongID, SoTien=@SoTien, PhuongThuc=@PhuongThuc, NgayTT=@NgayTT WHERE ThanhToanID=@ID", con))
                    {
                        cmd.Parameters.AddWithValue("@ID", txtThanhToanID.Text.Trim());
                        cmd.Parameters.AddWithValue("@DatPhongID", cboSoPhong.SelectedValue);
                        cmd.Parameters.AddWithValue("@SoTien", soTien);
                        cmd.Parameters.AddWithValue("@PhuongThuc", cboPhuongThuc.Text);
                        cmd.Parameters.AddWithValue("@NgayTT", dtpNgayTT.Value.Date);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadThanhToan();
                MessageBox.Show("Cập nhật thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtThanhToanID.Text))
                {
                    MessageBox.Show("Vui lòng chọn bản ghi để xóa.");
                    return;
                }

                if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;

                using (SqlConnection con = new SqlConnection(conn.ConnectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM ThanhToan WHERE ThanhToanID=@ID", con))
                    {
                        cmd.Parameters.AddWithValue("@ID", txtThanhToanID.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadThanhToan();
                MessageBox.Show("Xóa thành công.");
                btnLamMoi_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        private void dgvThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvThanhToan.Rows[e.RowIndex];
            txtThanhToanID.Text = row.Cells["ThanhToanID"].Value?.ToString() ?? "";
            cboSoPhong.SelectedValue = row.Cells["DatPhongID"].Value;
            txtTenKhachHang.Text = row.Cells["TenKhach"].Value?.ToString() ?? "";
            if (row.Cells["NgayNhanPhong"].Value != DBNull.Value)
                dtpNgayNhan.Value = Convert.ToDateTime(row.Cells["NgayNhanPhong"].Value);
            if (row.Cells["NgayTraPhong"].Value != DBNull.Value)
                dtpNgayTra.Value = Convert.ToDateTime(row.Cells["NgayTraPhong"].Value);
            txtSoTien.Text = row.Cells["SoTien"].Value?.ToString() ?? "";
            cboPhuongThuc.Text = row.Cells["PhuongThuc"].Value?.ToString() ?? "";
            if (row.Cells["NgayTT"].Value != DBNull.Value)
                dtpNgayTT.Value = Convert.ToDateTime(row.Cells["NgayTT"].Value);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn.ConnectionString))
                {
                    con.Open();
                    string sql = @"
                        SELECT t.ThanhToanID, t.DatPhongID, p.SoPhong, 
                               k.Ho + ' ' + k.Ten AS TenKhach,
                               dp.NgayNhanPhong, dp.NgayTraPhong, p.Gia, 
                               t.SoTien, t.PhuongThuc, t.NgayTT
                        FROM ThanhToan t
                        JOIN DatPhong dp ON t.DatPhongID = dp.DatPhongID
                        JOIN Phong p ON dp.PhongID = p.PhongID
                        JOIN KhachHang k ON dp.KhachID = k.KhachID
                        WHERE p.SoPhong LIKE @search OR (k.Ho + ' ' + k.Ten) LIKE @search
                        ORDER BY t.ThanhToanID DESC";
                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    da.SelectCommand.Parameters.AddWithValue("@search", "%" + txtTimKiem.Text.Trim() + "%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvThanhToan.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtThanhToanID.Clear();
            txtSoTien.Clear();
            txtTenKhachHang.Clear();
            cboSoPhong.SelectedIndex = -1;
            cboPhuongThuc.SelectedIndex = -1;
            txtTimKiem.Clear();
            dtpNgayNhan.Value = DateTime.Now;
            dtpNgayTra.Value = DateTime.Now;
            dtpNgayTT.Value = DateTime.Now;
            LoadThanhToan();
        }
    }
}
