using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LucMinhTuanCD230010
{
    public partial class QuanLyPhong : Form
    {
        private SqlConnection conn = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyKhacSan;Integrated Security=True;TrustServerCertificate=True;");

        private DataTable dtPhong;
        private int currentIndex = -1;

        public QuanLyPhong()
        {
            InitializeComponent();
        }

        private void QuanLyPhong_Load(object sender, EventArgs e)
        {
            LoadPhong();
            XoaForm();
        }

        private void LoadPhong()
        {
            try
            {
                string query = "SELECT PhongID, SoPhong, LoaiPhong, Gia, TinhTrang FROM Phong ORDER BY PhongID";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                dtPhong = new DataTable();
                da.Fill(dtPhong);

                dgvPhong.DataSource = dtPhong;
                dgvPhong.Columns["PhongID"].Width = 80;
                dgvPhong.Columns["SoPhong"].Width = 80;
                dgvPhong.Columns["LoaiPhong"].Width = 100;
                dgvPhong.Columns["Gia"].Width = 120;
                dgvPhong.Columns["TinhTrang"].Width = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu phòng: " + ex.Message);
            }
        }

        /* private void btnLuu_Click(object sender, EventArgs e)
         {
             if (KiemTraDuLieu())
             {
                 try
                 {
                     string query = "INSERT INTO Phong (SoPhong, LoaiPhong, Gia, TinhTrang) " +
                                    "VALUES (@SoPhong, @LoaiPhong, @Gia, @TinhTrang)";
                     SqlCommand cmd = new SqlCommand(query, conn);
                     cmd.Parameters.AddWithValue("@SoPhong", txtSoPhong.Text);
                     cmd.Parameters.AddWithValue("@LoaiPhong", cboLoaiPhong.Text);
                     cmd.Parameters.AddWithValue("@Gia", Convert.ToDecimal(txtGia.Text));
                     cmd.Parameters.AddWithValue("@TinhTrang", cboTinhTrang.Text);

                     conn.Open();
                     int result = cmd.ExecuteNonQuery();
                     conn.Close();

                     if (result > 0)
                     {
                         MessageBox.Show("Thêm phòng thành công!");
                         LoadPhong();
                         XoaForm();
                     }
                     else
                     {
                         MessageBox.Show("Thêm phòng thất bại!");
                     }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Lỗi thêm phòng: " + ex.Message);
                     conn.Close();
                 }
             }
         }*/
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                try
                {
                    // 1. Kiểm tra số phòng trùng
                    string checkQuery = "SELECT COUNT(*) FROM Phong WHERE SoPhong=@SoPhong";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@SoPhong", txtSoPhong.Text.Trim());

                    conn.Open();
                    int count = (int)checkCmd.ExecuteScalar();
                    conn.Close();

                    if (count > 0)
                    {
                        MessageBox.Show("Số phòng đã tồn tại!");
                        return;
                    }

                    // 2. Thêm phòng nếu không trùng
                    string query = "INSERT INTO Phong (SoPhong, LoaiPhong, Gia, TinhTrang) " +
                                   "VALUES (@SoPhong, @LoaiPhong, @Gia, @TinhTrang)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SoPhong", txtSoPhong.Text.Trim());
                    cmd.Parameters.AddWithValue("@LoaiPhong", cboLoaiPhong.Text);
                    cmd.Parameters.AddWithValue("@Gia", Convert.ToDecimal(txtGia.Text));
                    cmd.Parameters.AddWithValue("@TinhTrang", cboTinhTrang.Text);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (result > 0)
                    {
                        MessageBox.Show("Thêm phòng thành công!");
                        LoadPhong();
                        XoaForm();
                    }
                    else
                    {
                        MessageBox.Show("Thêm phòng thất bại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm phòng: " + ex.Message);
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhongID.Text))
            {
                MessageBox.Show("Vui lòng chọn phòng cần cập nhật!");
                return;
            }

            if (KiemTraDuLieu())
            {
                try
                {
                    int phongID = Convert.ToInt32(txtPhongID.Text);
                    string query = "UPDATE Phong SET SoPhong=@SoPhong, LoaiPhong=@LoaiPhong, Gia=@Gia, TinhTrang=@TinhTrang " +
                                   "WHERE PhongID=@PhongID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SoPhong", txtSoPhong.Text);
                    cmd.Parameters.AddWithValue("@LoaiPhong", cboLoaiPhong.Text);
                    cmd.Parameters.AddWithValue("@Gia", Convert.ToDecimal(txtGia.Text));
                    cmd.Parameters.AddWithValue("@TinhTrang", cboTinhTrang.Text);
                    cmd.Parameters.AddWithValue("@PhongID", phongID);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật phòng thành công!");
                        LoadPhong();
                        XoaForm();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật phòng: " + ex.Message);
                    conn.Close();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 0)
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa phòng này?",
                                                       "Xác nhận", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        int phongID = Convert.ToInt32(txtPhongID.Text);
                        string query = "DELETE FROM Phong WHERE PhongID=@PhongID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@PhongID", phongID);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (result > 0)
                        {
                            MessageBox.Show("Xóa phòng thành công!");
                            LoadPhong();
                            XoaForm();
                        }
                        else
                        {
                            MessageBox.Show("Xóa phòng thất bại!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa phòng: " + ex.Message);
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string timKiem = txtTimKiem.Text.Trim();
            try
            {
                string query = "SELECT PhongID, SoPhong, LoaiPhong, Gia, TinhTrang FROM Phong " +
                               "WHERE SoPhong LIKE @TuKhoa OR LoaiPhong LIKE @TuKhoa OR TinhTrang LIKE @TuKhoa " +
                               "ORDER BY PhongID";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@TuKhoa", "%" + timKiem + "%");

                DataTable dtTimKiem = new DataTable();
                da.Fill(dtTimKiem);
                dgvPhong.DataSource = dtTimKiem;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadPhong();
            txtTimKiem.Clear();
            XoaForm();
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                currentIndex = e.RowIndex;
                DataGridViewRow row = dgvPhong.Rows[e.RowIndex];

                txtPhongID.Text = row.Cells["PhongID"].Value.ToString();
                txtSoPhong.Text = row.Cells["SoPhong"].Value.ToString();
                cboLoaiPhong.Text = row.Cells["LoaiPhong"].Value.ToString();
                txtGia.Text = row.Cells["Gia"].Value.ToString();
                cboTinhTrang.Text = row.Cells["TinhTrang"].Value.ToString();
            }
        }

        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txtSoPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập số phòng!");
                txtSoPhong.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cboLoaiPhong.Text))
            {
                MessageBox.Show("Vui lòng chọn loại phòng!");
                cboLoaiPhong.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtGia.Text) || !decimal.TryParse(txtGia.Text, out decimal gia) || gia <= 0)
            {
                MessageBox.Show("Vui lòng nhập giá hợp lệ!");
                txtGia.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cboTinhTrang.Text))
            {
                MessageBox.Show("Vui lòng chọn tình trạng!");
                cboTinhTrang.Focus();
                return false;
            }
            return true;
        }

        private void XoaForm()
        {
            txtPhongID.Clear();
            txtSoPhong.Clear();
            cboLoaiPhong.SelectedIndex = -1;
            txtGia.Clear();
            cboTinhTrang.SelectedIndex = -1;
            currentIndex = -1;
        }

       
    }
}
