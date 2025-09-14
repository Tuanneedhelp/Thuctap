using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LucMinhTuanCD230010
{
    public partial class BookingForm : Form
    {
        SqlConnection conn = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyKhacSan;Integrated Security=True;TrustServerCertificate=True;"
        );

        public BookingForm()
        {
            InitializeComponent();
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            LoadPhong();
            LoadDatPhong();
        }

        private void LoadKhachHang()
        {
            try
            {
                string query = "SELECT KhachID, Ho + ' ' + Ten AS HoTen FROM KhachHang";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboKhachHang.DataSource = dt;
                cboKhachHang.DisplayMember = "HoTen";
                cboKhachHang.ValueMember = "KhachID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải khách hàng: " + ex.Message);
            }
        }

        private void LoadPhong()
        {
            try
            {
                string query = @"SELECT PhongID, SoPhong, 
                                 CAST(SoPhong AS NVARCHAR(10)) + ' - ' + LoaiPhong + ' - ' 
                                 + CAST(Gia AS NVARCHAR(20)) + ' VND' AS Phong 
                                 FROM Phong WHERE TinhTrang = N'Còn trống'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboPhong.DataSource = dt;
                cboPhong.DisplayMember = "Phong";
                cboPhong.ValueMember = "PhongID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải phòng: " + ex.Message);
            }
        }

        private void LoadDatPhong()
        {
            try
            {
                string query = @"SELECT dp.DatPhongID, dp.KhachID, dp.PhongID,
                                        kh.Ho + ' ' + kh.Ten AS KhachHang,
                                        p.SoPhong, p.LoaiPhong, dp.NgayNhanPhong, dp.NgayTraPhong
                                 FROM DatPhong dp
                                 JOIN KhachHang kh ON dp.KhachID = kh.KhachID
                                 JOIN Phong p ON dp.PhongID = p.PhongID";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvDatPhong.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách đặt phòng: " + ex.Message);
            }
        }

        private bool CheckTrungNgay(int phongID, DateTime ngayNhan, DateTime ngayTra)
        {
            bool trung = false;
            try
            {
                string query = @"SELECT COUNT(*) FROM DatPhong 
                                 WHERE PhongID = @PhongID 
                                 AND (NgayNhanPhong <= @NgayTra AND NgayTraPhong >= @NgayNhan)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PhongID", phongID);
                cmd.Parameters.AddWithValue("@NgayNhan", ngayNhan);
                cmd.Parameters.AddWithValue("@NgayTra", ngayTra);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                trung = count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra trùng ngày: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return trung;
        }

        private bool CheckPhongDaDat(int phongID)
        {
            bool daDat = false;
            try
            {
                string query = "SELECT COUNT(*) FROM DatPhong WHERE PhongID = @PhongID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PhongID", phongID);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                daDat = count > 0; // Nếu đã có bản ghi đặt phòng thì coi như đã được đặt
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra phòng đã đặt: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return daDat;
        }


        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                int khachID = (int)cboKhachHang.SelectedValue;
                int phongID = (int)cboPhong.SelectedValue;
                DateTime ngayNhan = dtpNhan.Value;
                DateTime ngayTra = dtpTra.Value;

                // Kiểm tra nếu phòng đã có người đặt (bất kể ngày nào) thì không cho thêm
                if (CheckPhongDaDat(phongID))
                {
                    MessageBox.Show("Phòng này đã có người đặt, vui lòng chọn phòng khác!");
                    return;
                }

                // Vẫn giữ kiểm tra trùng ngày (phòng chưa ai đặt nhưng vẫn chắc chắn hơn)
                if (CheckTrungNgay(phongID, ngayNhan, ngayTra))
                {
                    MessageBox.Show("Phòng đã được đặt trong khoảng thời gian này!");
                    return;
                }

                string query = @"INSERT INTO DatPhong (KhachID, PhongID, NgayNhanPhong, NgayTraPhong)
                         VALUES (@KhachID, @PhongID, @Nhan, @Tra)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@KhachID", khachID);
                cmd.Parameters.AddWithValue("@PhongID", phongID);
                cmd.Parameters.AddWithValue("@Nhan", ngayNhan);
                cmd.Parameters.AddWithValue("@Tra", ngayTra);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                LoadDatPhong();
                MessageBox.Show("Thêm đặt phòng thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm đặt phòng: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }



        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtDatPhongID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn bản ghi để cập nhật!");
                return;
            }

            try
            {
                int datPhongID = int.Parse(txtDatPhongID.Text);
                int khachID = (int)cboKhachHang.SelectedValue;
                int phongID = (int)cboPhong.SelectedValue;
                DateTime ngayNhan = dtpNhan.Value;
                DateTime ngayTra = dtpTra.Value;

                if (CheckTrungNgay(phongID, ngayNhan, ngayTra))
                {
                    MessageBox.Show("Phòng đã được đặt trong khoảng thời gian này!");
                    return;
                }

                string query = @"UPDATE DatPhong 
                                 SET KhachID=@KhachID, PhongID=@PhongID, NgayNhanPhong=@Nhan, NgayTraPhong=@Tra 
                                 WHERE DatPhongID=@ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@KhachID", khachID);
                cmd.Parameters.AddWithValue("@PhongID", phongID);
                cmd.Parameters.AddWithValue("@Nhan", ngayNhan);
                cmd.Parameters.AddWithValue("@Tra", ngayTra);
                cmd.Parameters.AddWithValue("@ID", datPhongID);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                LoadDatPhong();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtDatPhongID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn bản ghi để xóa!");
                return;
            }

            try
            {
                int datPhongID = int.Parse(txtDatPhongID.Text);

                string query = "DELETE FROM DatPhong WHERE DatPhongID=@ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", datPhongID);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                LoadDatPhong();
                MessageBox.Show("Xóa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        private void dgvDatPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDatPhong.Rows[e.RowIndex];

                txtDatPhongID.Text = row.Cells["DatPhongID"].Value.ToString();
                cboKhachHang.SelectedValue = row.Cells["KhachID"].Value;
                cboPhong.SelectedValue = row.Cells["PhongID"].Value;
                dtpNhan.Value = Convert.ToDateTime(row.Cells["NgayNhanPhong"].Value);
                dtpTra.Value = Convert.ToDateTime(row.Cells["NgayTraPhong"].Value);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string timKiem = txtTimKiem.Text.Trim();
            try
            {
                string query = @"SELECT dp.DatPhongID, dp.KhachID, dp.PhongID,
                                kh.Ho + ' ' + kh.Ten AS KhachHang,
                                p.SoPhong, p.LoaiPhong, dp.NgayNhanPhong, dp.NgayTraPhong
                         FROM DatPhong dp
                         JOIN KhachHang kh ON dp.KhachID = kh.KhachID
                         JOIN Phong p ON dp.PhongID = p.PhongID
                         WHERE kh.Ho LIKE @TimKiem 
                            OR kh.Ten LIKE @TimKiem
                            OR p.SoPhong LIKE @TimKiem
                         ORDER BY dp.DatPhongID";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@TimKiem", "%" + timKiem + "%");

                DataTable dtTimKiem = new DataTable();
                da.Fill(dtTimKiem);
                dgvDatPhong.DataSource = dtTimKiem;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDatPhong();      
            txtTimKiem.Clear();  
        }

    }
}
