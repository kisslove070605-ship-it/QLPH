using System;
using System.Drawing;
using System.Windows.Forms;

namespace GIL
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
            this.Text = "ShareCode.vn - Hệ thống quản lý phòng học DNC";

            // Căn giữa panel khi form load
            CenterPanel();
        }

        private void CenterPanel()
        {
            if (tabControl.SelectedTab == tabPageChangePassword)
            {
                panel1.Location = new Point(
                    (tabPageChangePassword.ClientSize.Width - panel1.Width) / 2,
                    (tabPageChangePassword.ClientSize.Height - panel1.Height) / 2
                );
            }
        }

        private void DoiMatKhau_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtOldPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
            chkShowPassword.Checked = false;
            txtOldPassword.UseSystemPasswordChar = true;
            txtNewPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
            txtUsername.Focus();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập Tài Khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtOldPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập Mật Khẩu Cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOldPassword.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập Mật Khẩu Mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Mật khẩu mới không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
                return;
            }

            MessageBox.Show("Đổi mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnReset_Click(sender, e);
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool show = chkShowPassword.Checked;
            txtOldPassword.UseSystemPasswordChar = !show;
            txtNewPassword.UseSystemPasswordChar = !show;
            txtConfirmPassword.UseSystemPasswordChar = !show;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPageCreateAccount)
            {
                MessageBox.Show("Chức năng Tạo Tài Khoản chưa được triển khai.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabControl.SelectedTab = tabPageChangePassword;
            }
            else
            {
                CenterPanel(); // Căn lại panel nếu chuyển về tab Đổi Mật Khẩu
            }
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
