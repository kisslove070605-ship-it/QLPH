using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyPhongHoc
{
    public partial class frmDangKyTaiKhoan : Form
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyPhongHoc;Integrated Security=True";

        public frmDangKyTaiKhoan()
        {
            InitializeComponent();
            Load += FrmDangKyTaiKhoan_Load;
        }

        private void FrmDangKyTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadDanhSachTaiKhoan();
            cbPhanQuyen.Items.Add("0 - Quyền nhân viên");
            cbPhanQuyen.Items.Add("1 - Quyền admin");
            cbPhanQuyen.SelectedIndex = 0;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string taiKhoan = txtTaiKhoan.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            int phanQuyen = cbPhanQuyen.SelectedIndex == 0 ? 0 : 1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Kiểm tra tài khoản đã tồn tại chưa
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", taiKhoan);
                        int exists = (int)checkCmd.ExecuteScalar();
                        if (exists > 0)
                        {
                            MessageBox.Show("Tài khoản đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Thêm người dùng mới
                    string insertUserQuery = @"
                        INSERT INTO Users (FullName, Email, PhoneNumber, Username, PasswordHash)
                        VALUES (@FullName, @Email, @Phone, @Username, @PasswordHash);
                        SELECT SCOPE_IDENTITY();";

                    int userId;
                    using (SqlCommand cmd = new SqlCommand(insertUserQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", taiKhoan); // Tạm dùng tên tài khoản làm họ tên
                        cmd.Parameters.AddWithValue("@Email", $"{taiKhoan}@example.com"); // Email mẫu
                        cmd.Parameters.AddWithValue("@Phone", "0900000000"); // SĐT mẫu
                        cmd.Parameters.AddWithValue("@Username", taiKhoan);
                        cmd.Parameters.AddWithValue("@PasswordHash", matKhau); // Trong thực tế nên mã hóa MD5/SHA256
                        userId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Gán vai trò
                    string insertRoleQuery = "INSERT INTO UserRoles (UserID, RoleID) VALUES (@UserID, @RoleID)";
                    using (SqlCommand roleCmd = new SqlCommand(insertRoleQuery, conn))
                    {
                        roleCmd.Parameters.AddWithValue("@UserID", userId);
                        roleCmd.Parameters.AddWithValue("@RoleID", phanQuyen + 1); // Giả sử RoleID: 1=Admin, 2=Staff
                        roleCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachTaiKhoan();
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đăng ký: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDanhSachTaiKhoan();
        }

        private void LoadDanhSachTaiKhoan()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT u.Username AS 'Tên Tài Khoản', 
                               u.PasswordHash AS 'Mật Khẩu', 
                               ur.RoleID AS 'Quyền'
                        FROM Users u
                        INNER JOIN UserRoles ur ON u.UserID = ur.UserID
                        ORDER BY u.Username";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvDanhSach.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ResetForm()
        {
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            cbPhanQuyen.SelectedIndex = 0;
            chkHienMatKhau.Checked = false;
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chkHienMatKhau.Checked;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}