using System;
using System.Windows.Forms;
using QuanLyBaoTriSuCo.Models;

namespace QuanLyBaoTriSuCo
{
    public partial class QuanLyBaoTriSuCo : Form
    {
        public QuanLyBaoTriSuCo()
        {
            InitializeComponent();
            LoadDanhSachSuCo();
            LoadDanhSachBaoTri();

            // Khởi tạo dữ liệu cho ComboBox
            cboThietBi.Items.AddRange(new string[] { "Máy chiếu", "Điều hòa", "Máy tính", "Loa", "Đèn", "Ổ điện", "Khác" });
            cboMucDo.SelectedIndex = 1;
            cboHangMuc.Items.AddRange(new string[] { "Vệ sinh máy lạnh", "Bảo dưỡng máy chiếu", "Kiểm tra điện", "Tổng vệ sinh phòng", "Khác" });
            cboTanSuat.SelectedIndex = 1;
            dtpThoiGianPhatHien.Value = DateTime.Now;
            dtpLanGanNhat.Value = DateTime.Now.AddMonths(-3);
            dtpLanTiepTheo.Value = DateTime.Now.AddMonths(3);
        }

        // === Tab 1: Báo cáo sự cố ===
        private void btnLuuSuCo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ tên và Phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var suco = new SuCo
            {
                MaSuCo = DuLieu.DanhSachSuCo.Count + 1,
                HoTen = txtHoTen.Text,
                DonVi = txtDonVi.Text,
                SoDienThoai = txtSDT.Text,
                Email = txtEmail.Text,
                Phong = txtPhong.Text,
                ThietBi = cboThietBi.SelectedItem?.ToString() ?? "",
                MoTa = txtMoTa.Text,
                ThoiGianPhatHien = dtpThoiGianPhatHien.Value,
                MucDo = cboMucDo.SelectedItem?.ToString() ?? "Trung bình"
            };

            DuLieu.DanhSachSuCo.Add(suco);
            LoadDanhSachSuCo(); // Cập nhật ngay
            MessageBox.Show($"✅ Báo cáo thành công! Mã: {suco.MaSuCo}", "Thông báo");
            // Reset form (tùy chọn)
            txtHoTen.Clear(); txtPhong.Clear(); txtMoTa.Clear();
        }

        // === Tab 2: Lịch bảo trì ===
        private void btnLuuBaoTri_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhongBaoTri.Text))
            {
                MessageBox.Show("Vui lòng nhập tên phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var baoTri = new BaoTriDinhKy
            {
                Phong = txtPhongBaoTri.Text,
                HangMuc = cboHangMuc.SelectedItem?.ToString() ?? "",
                TanSuat = cboTanSuat.SelectedItem?.ToString() ?? "3 tháng",
                LanGanNhat = dtpLanGanNhat.Value,
                LanTiepTheo = dtpLanTiepTheo.Value,
                DonViThucHien = txtDonViThucHien.Text,
                NguoiTheoDoi = txtNguoiTheoDoi.Text,
                GhiChu = txtGhiChu.Text
            };

            DuLieu.DanhSachBaoTri.Add(baoTri);
            LoadDanhSachBaoTri(); // Cập nhật ngay
            MessageBox.Show("✅ Lưu lịch bảo trì thành công!", "Thông báo");
        }

        // === Tab 3: Xem danh sách sự cố ===
        private void LoadDanhSachSuCo()
        {
            dgvSuCo.AutoGenerateColumns = false;
            dgvSuCo.DataSource = null;
            dgvSuCo.DataSource = DuLieu.DanhSachSuCo;
        }

        private void btnLamMoiSuCo_Click(object sender, EventArgs e)
        {
            LoadDanhSachSuCo();
        }

        // === Tab 4: Xem danh sách lịch bảo trì ===
        private void LoadDanhSachBaoTri()
        {
            dgvBaoTri.AutoGenerateColumns = false;
            dgvBaoTri.DataSource = null;
            dgvBaoTri.DataSource = DuLieu.DanhSachBaoTri;
        }

        private void btnLamMoiBaoTri_Click(object sender, EventArgs e)
        {
            LoadDanhSachBaoTri();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
