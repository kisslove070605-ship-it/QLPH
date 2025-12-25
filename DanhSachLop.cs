using System;
using System.Drawing;
using System.Windows.Forms;

namespace GIL
{
    public partial class DanhSachLop : Form
    {
        public DanhSachLop()
        {
            InitializeComponent();
        }

        private void DanhSachLop_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
            this.Text = "ShareCode.vn - Hệ thống quản lý phòng học DNC";
        }

        // 👇 Các sự kiện nút bấm — bạn sẽ tự implement logic SQL sau
        private void btnThem_Click(object sender, EventArgs e)
        {
            // TODO: Thêm lớp vào SQL
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            // TODO: Cập nhật lớp trong SQL
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // TODO: Xóa lớp trong SQL
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // TODO: In danh sách
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            // TODO: Xuất Excel
        }

        private void dgvClasses_SelectionChanged(object sender, EventArgs e)
        {
            // TODO: Khi chọn dòng trong DataGridView → điền vào textbox (bạn tự làm khi bind dữ liệu)
        }
    }
}
