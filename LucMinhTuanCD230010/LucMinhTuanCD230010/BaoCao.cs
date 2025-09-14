using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace LucMinhTuanCD230010
{
    public partial class ReportsForm : Form
    {
        SqlConnection conn = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyKhacSan;Integrated Security=True");

        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            cboReport.Items.Add("Danh sách khách hàng");
            cboReport.Items.Add("Danh sách phòng");
            cboReport.Items.Add("Danh sách đặt phòng");
            cboReport.Items.Add("Danh sách thanh toán");
            cboReport.Items.Add("Tổng doanh thu theo ngày"); 

            cboReport.SelectedIndex = 0;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string query = "";

            switch (cboReport.SelectedItem.ToString())
            {
                case "Danh sách khách hàng":
                    query = "SELECT KhachID, Ho, Ten, Email, DienThoai FROM KhachHang";
                    break;

                case "Danh sách phòng":
                    query = "SELECT PhongID, SoPhong, LoaiPhong, Gia, TinhTrang FROM Phong";
                    break;

                case "Danh sách đặt phòng":
                    query = @"SELECT dp.DatPhongID, kh.Ho + ' ' + kh.Ten AS KhachHang,
                                     p.SoPhong, dp.NgayNhanPhong, dp.NgayTraPhong
                              FROM DatPhong dp
                              JOIN KhachHang kh ON dp.KhachID = kh.KhachID
                              JOIN Phong p ON dp.PhongID = p.PhongID";
                    break;

                case "Danh sách thanh toán":
                    query = @"SELECT t.ThanhToanID, p.SoPhong, k.Ho + ' ' + k.Ten AS TenKhach,
                                     dp.NgayNhanPhong, dp.NgayTraPhong, t.SoTien, t.PhuongThuc, t.NgayTT
                              FROM ThanhToan t
                              JOIN DatPhong dp ON t.DatPhongID = dp.DatPhongID
                              JOIN Phong p ON dp.PhongID = p.PhongID
                              JOIN KhachHang k ON dp.KhachID = k.KhachID";
                    break;

                              

                case "Tổng doanh thu theo ngày":   
                    query = @"SELECT NgayTT AS [Ngày Thanh Toán],
                                     SUM(SoTien) AS [Tổng doanh thu]
                              FROM ThanhToan
                              GROUP BY NgayTT
                              ORDER BY NgayTT DESC";
                    break;
            }

            LoadData(query);
        }

        private void LoadData(string query)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvReport.DataSource = dt;

                if (cboReport.SelectedItem.ToString() == "Doanh thu theo ngày")
                {
                    decimal tong = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["SoTien"] != DBNull.Value)
                            tong += Convert.ToDecimal(row["SoTien"]);
                    }
                    lblTong.Text = "Tổng doanh thu: " + tong.ToString("N0") + " VND";
                }
                else if (cboReport.SelectedItem.ToString() == "Tổng doanh thu theo ngày")
                {
                    decimal tong = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["Tổng doanh thu"] != DBNull.Value)
                            tong += Convert.ToDecimal(row["Tổng doanh thu"]);
                    }
                    lblTong.Text = "Tổng tất cả ngày: " + tong.ToString("N0") + " VND";
                }
                else
                {
                    lblTong.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count > 0)
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (XLWorkbook wb = new XLWorkbook())
                            {
                                var ws = wb.Worksheets.Add("BaoCao");

                                // Ghi header
                                for (int i = 0; i < dgvReport.Columns.Count; i++)
                                {
                                    ws.Cell(2, i + 1).Value = dgvReport.Columns[i].HeaderText;
                                }

                                // Ghi dữ liệu
                                for (int i = 0; i < dgvReport.Rows.Count; i++)
                                {
                                    for (int j = 0; j < dgvReport.Columns.Count; j++)
                                    {
                                        ws.Cell(i + 3, j + 1).Value = dgvReport.Rows[i].Cells[j].Value?.ToString();
                                    }
                                }

                                ws.Columns().AdjustToContents();

                                // Thêm tiêu đề
                                ws.Cell(1, 1).Value = "BÁO CÁO - " + cboReport.SelectedItem.ToString();
                                ws.Range(1, 1, 1, dgvReport.Columns.Count).Merge();
                                ws.Cell(1, 1).Style.Font.Bold = true;
                                ws.Cell(1, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                                // Kẻ border
                                var rangeAll = ws.Range(2, 1, dgvReport.Rows.Count + 2, dgvReport.Columns.Count);
                                rangeAll.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                                rangeAll.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                                // Lưu file
                                wb.SaveAs(sfd.FileName);

                                MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cboReport.SelectedItem.ToString() != "Doanh thu (snapshot)")
            {
                MessageBox.Show("Chỉ có thể xóa trong báo cáo doanh thu (snapshot).");
                return;
            }

            if (dgvReport.SelectedRows.Count == 0) return;

            int id = Convert.ToInt32(dgvReport.SelectedRows[0].Cells["DoanhThuID"].Value);

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM DoanhThu WHERE DoanhThuID=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Xóa báo cáo thành công!");
                btnXem_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa báo cáo: " + ex.Message);
            }
            finally { conn.Close(); }
        }
    }
}
