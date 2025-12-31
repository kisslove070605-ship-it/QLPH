using System;
using System.Drawing;
using System.Windows.Forms;

namespace GIL
{
    public partial class Quanlygianvien : Form
    {
        public Quanlygianvien()
        {
            InitializeComponent();
        }

        // Sự kiện Load của form — PHẢI đặt đúng tên class + _Load
        private void Quanlygianvien_Load(object sender, EventArgs e)
        {
            // Bạn có thể thêm code khởi tạo ở đây nếu cần
            // Ví dụ: load dữ liệu từ DB, thiết lập combobox mặc định, v.v.
        }

        // Đóng form
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Lưu thông tin
        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã lưu thông tin giảng viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Chỉnh sửa
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang ở chế độ chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Xóa giảng viên
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin giảng viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("Đã xóa thông tin giảng viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Tải ảnh đại diện
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

        // Xóa ảnh đại diện
        private void btnXoaAnh_Click(object sender, EventArgs e)
        {
            pbAvatar.Image = null;
        }

        // Nút "Chọn" cho ngày sinh (nếu bạn muốn mở calendar custom)
        private void btnChonNgay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chọn ngày sinh trong DateTimePicker.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Thực tế, bạn có thể bỏ nút này nếu dùng DateTimePicker mặc định
        }

        // Khóa giảng viên
        private void btnKhoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã khóa giảng viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Thêm giảng viên mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã thêm giảng viên mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Tải dữ liệu từ Excel
        private void btnTaiDuLieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang tải dữ liệu từ Excel...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
