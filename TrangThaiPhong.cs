using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel; 

namespace QuanLyPhongHoc
{
    public partial class TrangThaiPhong : Form
    {
        private List<Phong> danhSachPhong = new List<Phong>();
        private BindingSource bindingSource = new BindingSource();

        public TrangThaiPhong()
        {
            InitializeComponent();

            // Khởi tạo dữ liệu mẫu
            danhSachPhong.Add(new Phong("A22", "A2 - 02", "Lý Thuyết", "Dãy A", "2"));
            danhSachPhong.Add(new Phong("A23", "A2 - 03", "Lý Thuyết", "Dãy A", "2"));
            danhSachPhong.Add(new Phong("B22", "B2 - 02", "Thực Hành", "Dãy B", "2"));
            danhSachPhong.Add(new Phong("C31", "C3 - 01", "Thực Hành", "Khu hiệu bộ", "2"));
            danhSachPhong.Add(new Phong("D27", "D2 - 07", "Lý Thuyết", "Dãy D", "2"));
            danhSachPhong.Add(new Phong("D32", "D3 - 02", "Lý Thuyết", "Dãy D", "3"));
            danhSachPhong.Add(new Phong("E22", "E2 - 02", "Thực Hành", "Khu thực hành đa chức năng", "2"));

            bindingSource.DataSource = danhSachPhong;
            dataGridViewTrangThai.DataSource = bindingSource;

            // Gán tên cột
            dataGridViewTrangThai.Columns["MaPhong"].HeaderText = "Mã Phòng";
            dataGridViewTrangThai.Columns["TenPhong"].HeaderText = "Tên Phòng";
            dataGridViewTrangThai.Columns["LoaiPhong"].HeaderText = "Loại Phòng";
            dataGridViewTrangThai.Columns["DayNha"].HeaderText = "Dãy Nhà";
            dataGridViewTrangThai.Columns["Tang"].HeaderText = "Tầng";

            // Thiết lập độ rộng cột
            dataGridViewTrangThai.Columns["MaPhong"].Width = 80;
            dataGridViewTrangThai.Columns["TenPhong"].Width = 100;
            dataGridViewTrangThai.Columns["LoaiPhong"].Width = 120;
            dataGridViewTrangThai.Columns["DayNha"].Width = 150;
            dataGridViewTrangThai.Columns["Tang"].Width = 60;
        }

        private void TrangThaiPhong_Load(object sender, EventArgs e)
        {
            // Không cần xử lý thêm
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tenPhong = textBoxTenPhong.Text.Trim();
            string loaiPhong = comboBoxLoaiPhong.Text.Trim();
            string dayNha = comboBoxDayNha.Text.Trim();
            string tinhTrang = comboBoxTinhTrang.Text.Trim();
            string trangThai = comboBoxTrangThai.Text.Trim();

            var filtered = danhSachPhong.Where(p =>
                (string.IsNullOrEmpty(tenPhong) || p.TenPhong.Contains(tenPhong)) &&
                (string.IsNullOrEmpty(loaiPhong) || p.LoaiPhong == loaiPhong) &&
                (string.IsNullOrEmpty(dayNha) || p.DayNha == dayNha) &&
                (string.IsNullOrEmpty(tinhTrang) || p.TinhTrang == tinhTrang) &&
                (string.IsNullOrEmpty(trangThai) || p.TrangThai == trangThai)
            ).ToList();

            bindingSource.DataSource = filtered;
            bindingSource.ResetBindings(false);

            MessageBox.Show($"Tìm thấy {filtered.Count} kết quả.", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (danhSachPhong.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Lưu file Excel";
            saveFileDialog.FileName = "TrangThaiPhong.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Excel.Application excel = new Excel.Application();
                    Excel.Workbook workbook = excel.Workbooks.Add();
                    Excel.Worksheet worksheet = workbook.ActiveSheet;

                    // Tiêu đề cột
                    worksheet.Cells[1, 1] = "Mã Phòng";
                    worksheet.Cells[1, 2] = "Tên Phòng";
                    worksheet.Cells[1, 3] = "Loại Phòng";
                    worksheet.Cells[1, 4] = "Dãy Nhà";
                    worksheet.Cells[1, 5] = "Tầng";

                    // Dữ liệu
                    for (int i = 0; i < danhSachPhong.Count; i++)
                    {
                        var phong = danhSachPhong[i];
                        worksheet.Cells[i + 2, 1] = phong.MaPhong;
                        worksheet.Cells[i + 2, 2] = phong.TenPhong;
                        worksheet.Cells[i + 2, 3] = phong.LoaiPhong;
                        worksheet.Cells[i + 2, 4] = phong.DayNha;
                        worksheet.Cells[i + 2, 5] = phong.Tang;
                    }

                    // Tự động căn cột
                    worksheet.Columns.AutoFit();

                    // Lưu file
                    workbook.SaveAs(saveFileDialog.FileName);
                    workbook.Close();
                    excel.Quit();

                    MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewTrangThai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var phong = danhSachPhong[e.RowIndex];
                textBoxTenPhong.Text = phong.TenPhong;
                comboBoxLoaiPhong.Text = phong.LoaiPhong;
                comboBoxDayNha.Text = phong.DayNha;
                comboBoxTinhTrang.Text = phong.TinhTrang;
                comboBoxTrangThai.Text = phong.TrangThai;
            }
        }

        // Class Phòng
        public class Phong
        {
            public string MaPhong { get; set; }
            public string TenPhong { get; set; }
            public string LoaiPhong { get; set; }
            public string DayNha { get; set; }
            public string Tang { get; set; }
            public string TinhTrang { get; set; } = "Bình Thường"; // Mặc định
            public string TrangThai { get; set; } = "Bình Thường"; // Mặc định

            public Phong(string maPhong, string tenPhong, string loaiPhong, string dayNha, string tang)
            {
                MaPhong = maPhong;
                TenPhong = tenPhong;
                LoaiPhong = loaiPhong;
                DayNha = dayNha;
                Tang = tang;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
