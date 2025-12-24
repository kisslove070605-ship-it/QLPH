using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
namespace QuanLyPhongHoc
{
    public partial class frmQuanLyThietBi : Form
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyPhongHoc;Integrated Security=True";
        private bool isEditing = false;
        private string currentMaThietBi = "";

        public frmQuanLyThietBi()
        {
            InitializeComponent();
            Load += FrmQuanLyThietBi_Load;
        }

        private void FrmQuanLyThietBi_Load(object sender, EventArgs e)
        {
            LoadDanhSachThietBi();
            LoadMaThietBi();
            ResetForm();
        }

        private void LoadDanhSachThietBi()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            MaThietBi AS 'Mã Thiết Bị',
                            TenThietBi AS 'Tên Thiết Bị',
                            TinhTrang AS 'Tình Trạng',
                            TrangThai AS 'Trạng Thái',
                            GhiChu AS 'Ghi Chú'
                        FROM Equipments
                        ORDER BY MaThietBi";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvDanhSach.DataSource = dt;

                    // Tùy chỉnh màu sắc cho cột "Trạng Thái"
                    foreach (DataGridViewRow row in dgvDanhSach.Rows)
                    {
                        string trangThai = row.Cells["Trạng Thái"].Value?.ToString() ?? "";
                        if (trangThai == "Đã Mượn")
                            row.DefaultCellStyle.BackColor = Color.LightBlue;
                        else if (trangThai == "Hỏng")
                            row.DefaultCellStyle.BackColor = Color.LightPink;
                        else if (trangThai == "Đang xin cấp")
                            row.DefaultCellStyle.BackColor = Color.LightYellow;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadMaThietBi()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MaThietBi FROM Equipments ORDER BY MaThietBi DESC";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cbMaThietBi.Items.Clear();
                    while (reader.Read())
                    {
                        cbMaThietBi.Items.Add(reader["MaThietBi"].ToString());
                    }
                    reader.Close();

                    if (cbMaThietBi.Items.Count > 0)
                        cbMaThietBi.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi load mã thiết bị: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbMaThietBi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaThietBi.SelectedItem == null) return;

            string maThietBi = cbMaThietBi.SelectedItem.ToString();
            LoadThongTinThietBi(maThietBi);
        }

        private void LoadThongTinThietBi(string maThietBi)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Equipments WHERE MaThietBi = @ma";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ma", maThietBi);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtTenThietBi.Text = reader["TenThietBi"].ToString();
                        txtTinhTrang.Text = reader["TinhTrang"].ToString();
                        txtTrangThai.Text = reader["TrangThai"].ToString();
                        txtGhiChu.Text = reader["GhiChu"].ToString();
                    }
                    reader.Close();
                    isEditing = true;
                    currentMaThietBi = maThietBi;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi load thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenThietBi.Text))
            {
                MessageBox.Show("Vui lòng nhập tên thiết bị!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maThietBi = GenerateMaThietBi(); // Tự động sinh mã
            string tenThietBi = txtTenThietBi.Text.Trim();
            string tinhTrang = txtTinhTrang.Text.Trim();
            string trangThai = txtTrangThai.Text.Trim();
            string ghiChu = txtGhiChu.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        INSERT INTO Equipments (MaThietBi, TenThietBi, TinhTrang, TrangThai, GhiChu)
                        VALUES (@ma, @ten, @tinh, @trang, @ghi)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ma", maThietBi);
                    cmd.Parameters.AddWithValue("@ten", tenThietBi);
                    cmd.Parameters.AddWithValue("@tinh", tinhTrang);
                    cmd.Parameters.AddWithValue("@trang", trangThai);
                    cmd.Parameters.AddWithValue("@ghi", ghiChu);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thiết bị thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachThietBi();
                    LoadMaThietBi();
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm thiết bị: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (!isEditing || string.IsNullOrEmpty(currentMaThietBi))
            {
                MessageBox.Show("Vui lòng chọn thiết bị để chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenThietBi = txtTenThietBi.Text.Trim();
            string tinhTrang = txtTinhTrang.Text.Trim();
            string trangThai = txtTrangThai.Text.Trim();
            string ghiChu = txtGhiChu.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        UPDATE Equipments 
                        SET TenThietBi = @ten, TinhTrang = @tinh, TrangThai = @trang, GhiChu = @ghi
                        WHERE MaThietBi = @ma";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ma", currentMaThietBi);
                    cmd.Parameters.AddWithValue("@ten", tenThietBi);
                    cmd.Parameters.AddWithValue("@tinh", tinhTrang);
                    cmd.Parameters.AddWithValue("@trang", trangThai);
                    cmd.Parameters.AddWithValue("@ghi", ghiChu);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thiết bị thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachThietBi();
                    LoadMaThietBi();
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!isEditing || string.IsNullOrEmpty(currentMaThietBi))
            {
                MessageBox.Show("Vui lòng chọn thiết bị để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa thiết bị này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Equipments WHERE MaThietBi = @ma";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ma", currentMaThietBi);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Xóa thiết bị thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachThietBi();
                    LoadMaThietBi();
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            PrintDanhSach();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void ResetForm()
        {
            cbMaThietBi.SelectedIndex = -1;
            txtTenThietBi.Clear();
            txtTinhTrang.Clear();
            txtTrangThai.Clear();
            txtGhiChu.Clear();
            isEditing = false;
            currentMaThietBi = "";
        }

        private string GenerateMaThietBi()
        {
            string prefix = "TB";
            int nextNumber = 1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MAX(CAST(SUBSTRING(MaThietBi, 3, LEN(MaThietBi)-2) AS INT)) FROM Equipments";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                        nextNumber = Convert.ToInt32(result) + 1;
                }
                catch { }
            }

            return $"{prefix}{nextNumber:D3}"; // TB001, TB002...
        }

        private void PrintDanhSach()
        {
            MessageBox.Show("Chức năng in đang được phát triển. Hiện tại chỉ hỗ trợ xuất Excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExportToExcel()
        {
            // ⚠️ Nếu bạn chưa cài ClosedXML, hãy comment đoạn này và dùng cách khác
            try
            {
                // Cách 1: Dùng Clipboard (đơn giản nhất)
                dgvDanhSach.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                dgvDanhSach.SelectAll();
                DataObject dataObj = dgvDanhSach.GetClipboardContent();
                if (dataObj != null)
                    Clipboard.SetDataObject(dataObj);

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
                saveDialog.FileName = "DanhSachThietBi_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(saveDialog.FileName, Clipboard.GetText());
                    MessageBox.Show("Xuất Excel (text) thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ THÊM HÀM NÀY ĐỂ SỬA LỖI CS1061
        private void dgvDanhSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDanhSach.SelectedRows.Count > 0)
            {
                string maThietBi = dgvDanhSach.SelectedRows[0].Cells["Mã Thiết Bị"].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(maThietBi))
                {
                    cbMaThietBi.Text = maThietBi;
                    LoadThongTinThietBi(maThietBi);
                }
            }
        }
    }
}
