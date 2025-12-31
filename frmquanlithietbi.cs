using System;
using System.Drawing;
using System.Windows.Forms;

namespace GIL
{
    public partial class QuanLyThietBi : Form
    {
        public QuanLyThietBi()
        {
            InitializeComponent();
        }

        private void QuanLyThietBi_Load(object sender, EventArgs e)
        {
            // Khởi tạo ban đầu (nếu cần)
            // Ví dụ: load danh sách loại thiết bị, nhà cung cấp...
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã lưu thông tin thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang ở chế độ chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa thiết bị này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("Đã xóa thiết bị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã thêm thiết bị mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTaiDuLieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang tải dữ liệu từ Excel...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbAvatar.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void btnXoaAnh_Click(object sender, EventArgs e)
        {
            pbAvatar.Image = null;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang in danh sách thiết bị...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang xuất danh sách thiết bị ra Excel...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
