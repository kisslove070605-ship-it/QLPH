using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyPhongHoc
{
    public partial class ThongKeBieuDo : Form
    {
        public ThongKeBieuDo()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // ============ 1. Biểu đồ cột: Tần suất sử dụng phòng ============
            var suDungPhong = new Dictionary<string, int>();

            // Giả sử trong Thời Khóa Biểu, bạn lưu "Tên Phòng" trong cột "Mã Môn" (hoặc bạn có thể tạo field riêng)
            // Nếu bạn có field "TenPhong" trong ThoiKhoaBieuItem, hãy thay thế `item.MaMon` bằng `item.TenPhong`
            foreach (var item in GlobalData.DanhSachTKB)
            {
                string tenPhong = item.MaMon; // ← CẦN CHỈNH THEO DỮ LIỆU THỰC TẾ CỦA BẠN!
                if (string.IsNullOrEmpty(tenPhong)) continue;

                if (!suDungPhong.ContainsKey(tenPhong))
                    suDungPhong[tenPhong] = 0;
                suDungPhong[tenPhong]++;
            }

            chartSuDungPhong.Series.Clear();
            var seriesPhong = new Series("Tần suất")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                Color = Color.FromArgb(46, 204, 113)
            };

            foreach (var item in suDungPhong.OrderByDescending(x => x.Value))
            {
                seriesPhong.Points.AddXY(item.Key, item.Value);
            }

            chartSuDungPhong.Series.Add(seriesPhong);
            chartSuDungPhong.ChartAreas[0].AxisX.Title = "Phòng";
            chartSuDungPhong.ChartAreas[0].AxisY.Title = "Số lần sử dụng";

            // ============ 2. Biểu đồ tròn: Trạng thái thiết bị ============
            var thietBi = new Dictionary<string, int>
            {
                { "Còn tốt", 0 },
                { "Hỏng", 0 }
            };

            foreach (var item in GlobalData.DanhSachThietBi)
            {
                if (item.TinhTrang != null && (item.TinhTrang.Contains("Bình Thường") || item.TinhTrang.Contains("Tốt")))
                    thietBi["Còn tốt"]++;
                else
                    thietBi["Hỏng"]++;
            }

            chartThietBi.Series.Clear();
            var seriesThietBi = new Series("Trạng thái")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                Color = Color.FromArgb(52, 152, 219)
            };

            foreach (var item in thietBi)
            {
                seriesThietBi.Points.AddXY(item.Key, item.Value);
            }

            chartThietBi.Series.Add(seriesThietBi);
            chartThietBi.Titles.Clear();
            chartThietBi.Titles.Add("Tỷ lệ thiết bị");

            // ============ 3. Biểu đồ cột: Số giờ học theo tháng ============
            var gioHoc = new Dictionary<string, int>();

            foreach (var item in GlobalData.DanhSachTKB)
            {
                string thang = item.Ngay.ToString("MM/yyyy");
                if (!gioHoc.ContainsKey(thang))
                    gioHoc[thang] = 0;
                gioHoc[thang]++; // Mỗi bản ghi = 1 buổi học
            }

            chartGioHoc.Series.Clear();
            var seriesGioHoc = new Series("Số giờ")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                Color = Color.FromArgb(231, 76, 60)
            };

            foreach (var item in gioHoc.OrderBy(x => x.Key))
            {
                seriesGioHoc.Points.AddXY(item.Key, item.Value);
            }

            chartGioHoc.Series.Add(seriesGioHoc);
            chartGioHoc.ChartAreas[0].AxisX.Title = "Tháng";
            chartGioHoc.ChartAreas[0].AxisY.Title = "Số buổi học";
        }

        private void ThongKeBieuDo_Load(object sender, EventArgs e)
        {
            // Đã load trong constructor
        }
    }
}
