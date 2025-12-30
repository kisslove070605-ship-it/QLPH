using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongHoc
{
    public partial class ThongKeHieuSuat : Form
    {
        private List<ThongKe> danhSachThongKe = new List<ThongKe>();
        private BindingSource bindingSource = new BindingSource();

        public ThongKeHieuSuat()
        {
            InitializeComponent();

            // Khởi tạo dữ liệu mẫu
            danhSachThongKe.Add(new ThongKe("DH19TIN03", "Xác suất thống kê", "A2 - 02", "Thứ 2", "1-5", new DateTime(2022, 1, 23)));
            danhSachThongKe.Add(new ThongKe("DH19MAR01", "Đồ án cơ sở 2", "D2 - 07", "Thứ 4", "4-6", new DateTime(2022, 12, 23)));
            danhSachThongKe.Add(new ThongKe("DH19MAR01", "Đồ án cơ sở 2", "C3 - 01", "Thứ 5", "4-6", new DateTime(2022, 12, 24)));
            danhSachThongKe.Add(new ThongKe("DH19MAR01", "Đồ án cơ sở 2", "B2 - 02", "Thứ 6", "4-6", new DateTime(2022, 12, 25)));

            bindingSource.DataSource = danhSachThongKe;
            dataGridViewThongKe.DataSource = bindingSource;

            // Gán tên cột
            dataGridViewThongKe.Columns["MaMonHoc"].HeaderText = "Mã Môn Học";
            dataGridViewThongKe.Columns["TenMonHoc"].HeaderText = "Tên Môn Học";
            dataGridViewThongKe.Columns["TenPhong"].HeaderText = "Tên Phòng";
            dataGridViewThongKe.Columns["Thu"].HeaderText = "Thứ";
            dataGridViewThongKe.Columns["Tiet"].HeaderText = "Tiết";
            dataGridViewThongKe.Columns["NgayBatDau"].HeaderText = "Ngày Bắt Đầu";

            // Thiết lập độ rộng cột
            dataGridViewThongKe.Columns["MaMonHoc"].Width = 100;
            dataGridViewThongKe.Columns["TenMonHoc"].Width = 150;
            dataGridViewThongKe.Columns["TenPhong"].Width = 100;
            dataGridViewThongKe.Columns["Thu"].Width = 80;
            dataGridViewThongKe.Columns["Tiet"].Width = 80;
            dataGridViewThongKe.Columns["NgayBatDau"].Width = 100;
        }

        private void ThongKeHieuSuat_Load(object sender, EventArgs e)
        {
            // Đặt giá trị mặc định cho datetimepicker
            dateTimePickerTuNgay.Value = new DateTime(2022, 12, 4);
            dateTimePickerDenNgay.Value = new DateTime(2022, 12, 4);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string maPhong = textBoxMaPhong.Text.Trim();
            string tenPhong = textBoxTenPhong.Text.Trim();
            string dayNha = comboBoxDayNha.Text.Trim();
            string lop = comboBoxLop.Text.Trim();
            DateTime tuNgay = dateTimePickerTuNgay.Value.Date;
            DateTime denNgay = dateTimePickerDenNgay.Value.Date;

            var filtered = danhSachThongKe.Where(tk =>
                (string.IsNullOrEmpty(maPhong) || tk.TenPhong.Contains(maPhong)) &&
                (string.IsNullOrEmpty(tenPhong) || tk.TenPhong.Contains(tenPhong)) &&
                (string.IsNullOrEmpty(dayNha) || tk.TenPhong.StartsWith(dayNha)) &&
                (string.IsNullOrEmpty(lop) || tk.MaMonHoc.Contains(lop)) &&
                tk.NgayBatDau >= tuNgay &&
                tk.NgayBatDau <= denNgay
            ).ToList();

            bindingSource.DataSource = filtered;
            bindingSource.ResetBindings(false);

            MessageBox.Show($"Tìm thấy {filtered.Count} kết quả.", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Class Thống Kê
        public class ThongKe
        {
            public string MaMonHoc { get; set; }
            public string TenMonHoc { get; set; }
            public string TenPhong { get; set; }
            public string Thu { get; set; }
            public string Tiet { get; set; }
            public DateTime NgayBatDau { get; set; }

            public ThongKe(string maMonHoc, string tenMonHoc, string tenPhong, string thu, string tiet, DateTime ngayBatDau)
            {
                MaMonHoc = maMonHoc;
                TenMonHoc = tenMonHoc;
                TenPhong = tenPhong;
                Thu = thu;
                Tiet = tiet;
                NgayBatDau = ngayBatDau;
            }
        }
    }
}
