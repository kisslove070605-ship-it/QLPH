using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyPhongHoc
{
    public partial class ThoiKhoaBieu : Form
    {
        private List<ThoiKhoaBieuItem> danhSachTKB = new List<ThoiKhoaBieuItem>();
        private BindingSource bindingSource = new BindingSource();
        private PrintDocument printDocument = new PrintDocument();

        public ThoiKhoaBieu()
        {
            InitializeComponent();

            // Khởi tạo dữ liệu mẫu
            KhoiTaoDuLieuMau();

            bindingSource.DataSource = danhSachTKB;
            dataGridViewTKB.DataSource = bindingSource;

            // Thiết lập cột hiển thị
            CauHinhDataGridView();

            // Cấu hình in
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void KhoiTaoDuLieuMau()
        {
            danhSachTKB.Add(new ThoiKhoaBieuItem("TKB001", "M001", "DH19TIN03", "Thứ 2", "1-5", new DateTime(2022, 12, 23)));
            danhSachTKB.Add(new ThoiKhoaBieuItem("TKB002", "M005", "DH19MAR01", "Thứ 4", "4-6", new DateTime(2022, 10, 03)));
            danhSachTKB.Add(new ThoiKhoaBieuItem("TKB003", "M004", "DH19MAR01", "Thứ 6", "10-12", new DateTime(2022, 03, 10)));
            danhSachTKB.Add(new ThoiKhoaBieuItem("TKB004", "M005", "DH19TIN03", "Thứ 6", "7-9", new DateTime(2022, 03, 10)));
        }

        private void CauHinhDataGridView()
        {
            var dgv = dataGridViewTKB;
            dgv.Columns["MaTKB"].HeaderText = "Mã TKB";
            dgv.Columns["MaMon"].HeaderText = "Mã Môn";
            dgv.Columns["MaLop"].HeaderText = "Mã Lớp";
            dgv.Columns["Thu"].HeaderText = "Thứ";
            dgv.Columns["Tiet"].HeaderText = "Tiết";
            dgv.Columns["Ngay"].HeaderText = "Ngày";

            dgv.Columns["MaTKB"].Width = 80;
            dgv.Columns["MaMon"].Width = 80;
            dgv.Columns["MaLop"].Width = 120;
            dgv.Columns["Thu"].Width = 80;
            dgv.Columns["Tiet"].Width = 80;
            dgv.Columns["Ngay"].Width = 100;
        }

        private void ThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            dateTimePickerNgay.Value = DateTime.Now;
        }

        // =============== THÊM, SỬA, XÓA ===============
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maTKB = comboBoxMaTKB.Text.Trim();
            if (string.IsNullOrEmpty(maTKB))
            {
                MessageBox.Show("Vui lòng chọn Mã TKB!");
                return;
            }

            if (danhSachTKB.Any(x => x.MaTKB == maTKB))
            {
                MessageBox.Show("Mã TKB đã tồn tại!");
                return;
            }

            var tkb = new ThoiKhoaBieuItem(
                maTKB,
                comboBoxMaMonHoc.Text,
                comboBoxMaLop.Text,
                comboBoxThu.Text,
                comboBoxTiet.Text,
                dateTimePickerNgay.Value
            );

            danhSachTKB.Add(tkb);
            bindingSource.ResetBindings(false);
            MessageBox.Show("Thêm thời khóa biểu thành công!");
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (dataGridViewTKB.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thời khóa biểu cần chỉnh sửa!");
                return;
            }

            string maTKB = comboBoxMaTKB.Text.Trim();
            if (string.IsNullOrEmpty(maTKB))
            {
                MessageBox.Show("Mã TKB không được để trống!");
                return;
            }

            var rowIndex = dataGridViewTKB.SelectedRows[0].Index;
            danhSachTKB[rowIndex] = new ThoiKhoaBieuItem(
                maTKB,
                comboBoxMaMonHoc.Text,
                comboBoxMaLop.Text,
                comboBoxThu.Text,
                comboBoxTiet.Text,
                dateTimePickerNgay.Value
            );

            bindingSource.ResetBindings(false);
            MessageBox.Show("Cập nhật thông tin thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewTKB.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thời khóa biểu để xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa thời khóa biểu này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var rowIndex = dataGridViewTKB.SelectedRows[0].Index;
                danhSachTKB.RemoveAt(rowIndex);
                bindingSource.ResetBindings(false);
                MessageBox.Show("Xóa thành công!");
            }
        }

        private void dataGridViewTKB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var tkb = danhSachTKB[e.RowIndex];
                comboBoxMaTKB.Text = tkb.MaTKB;
                comboBoxMaMonHoc.Text = tkb.MaMon;
                comboBoxMaLop.Text = tkb.MaLop;
                comboBoxThu.Text = tkb.Thu;
                comboBoxTiet.Text = tkb.Tiet;
                dateTimePickerNgay.Value = tkb.Ngay;
            }
        }

        // =============== CHỨC NĂNG IN ===============
        private void btnIn_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument;
            preview.Width = 800;
            preview.Height = 600;
            preview.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Font lớn cho in
            Font fontTitle = new Font("Arial", 18, FontStyle.Bold);
            Font fontHeader = new Font("Arial", 14, FontStyle.Bold);
            Font fontData = new Font("Arial", 12);

            // Tạo brush và pen riêng
            using (SolidBrush brush = new SolidBrush(Color.Black))
            using (Pen pen = new Pen(Color.Black))
            {
                float yPos = 50;
                float xPos = 50;
                float lineHeight = 30;

                // Độ rộng từng cột
                float[] colWidths = { 80f, 70f, 120f, 80f, 70f, 100f }; // Mã TKB, Mã Môn, Mã Lớp, Thứ, Tiết, Ngày
                string[] headers = { "Mã TKB", "Mã Môn", "Mã Lớp", "Thứ", "Tiết", "Ngày" };

                // Tiêu đề
                e.Graphics.DrawString("THỜI KHÓA BIỂU", fontTitle, brush, xPos, yPos);
                yPos += lineHeight * 1.5f;

                // Vẽ dòng kẻ đầu tiên (trên cùng của bảng)
                float totalWidth = colWidths.Sum();
                e.Graphics.DrawLine(pen, xPos, yPos, xPos + totalWidth, yPos);

                // Vẽ tiêu đề cột + kẻ khung
                float currentX = xPos;
                for (int i = 0; i < headers.Length; i++)
                {
                    // Căn giữa chữ trong ô
                    StringFormat format = new StringFormat();
                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Center;

                    // Vẽ chữ
                    e.Graphics.DrawString(headers[i], fontHeader, brush, new RectangleF(currentX, yPos + 5, colWidths[i], lineHeight - 10), format);

                    // Vẽ đường viền xung quanh ô
                    e.Graphics.DrawRectangle(pen, currentX, yPos, colWidths[i], lineHeight);

                    currentX += colWidths[i];
                }

                yPos += lineHeight;
                e.Graphics.DrawLine(pen, xPos, yPos, xPos + totalWidth, yPos); // Dưới tiêu đề

                // Vẽ dữ liệu + kẻ khung + căn giữa
                foreach (var item in danhSachTKB)
                {
                    currentX = xPos;
                    string[] data = {
                item.MaTKB,
                item.MaMon,
                item.MaLop,
                item.Thu,
                item.Tiet,
                item.Ngay.ToString("dd/MM/yyyy")
            };

                    for (int i = 0; i < data.Length; i++)
                    {
                        // Căn giữa chữ trong ô
                        StringFormat format = new StringFormat();
                        format.Alignment = StringAlignment.Center;
                        format.LineAlignment = StringAlignment.Center;

                        // Vẽ chữ
                        e.Graphics.DrawString(data[i], fontData, brush, new RectangleF(currentX, yPos + 5, colWidths[i], lineHeight - 10), format);

                        // Vẽ đường viền xung quanh ô
                        e.Graphics.DrawRectangle(pen, currentX, yPos, colWidths[i], lineHeight);

                        currentX += colWidths[i];
                    }

                    yPos += lineHeight;
                    e.Graphics.DrawLine(pen, xPos, yPos, xPos + totalWidth, yPos); // Dưới mỗi dòng

                    if (yPos > e.MarginBounds.Bottom)
                    {
                        e.HasMorePages = true;
                        break;
                    }
                }
            } // ← tự động dispose brush & pen

            // Giải phóng font
            fontTitle.Dispose();
            fontHeader.Dispose();
            fontData.Dispose();
        }

        // =============== XUẤT EXCEL ===============
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (danhSachTKB.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Lưu file Excel";
            saveFileDialog.FileName = "ThoiKhoaBieu.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Excel.Application excel = new Excel.Application();
                    Excel.Workbook workbook = excel.Workbooks.Add();
                    Excel.Worksheet worksheet = workbook.ActiveSheet;

                    // Tiêu đề cột
                    worksheet.Cells[1, 1] = "Mã TKB";
                    worksheet.Cells[1, 2] = "Mã Môn";
                    worksheet.Cells[1, 3] = "Mã Lớp";
                    worksheet.Cells[1, 4] = "Thứ";
                    worksheet.Cells[1, 5] = "Tiết";
                    worksheet.Cells[1, 6] = "Ngày";

                    // Dữ liệu
                    for (int i = 0; i < danhSachTKB.Count; i++)
                    {
                        var item = danhSachTKB[i];
                        worksheet.Cells[i + 2, 1] = item.MaTKB;
                        worksheet.Cells[i + 2, 2] = item.MaMon;
                        worksheet.Cells[i + 2, 3] = item.MaLop;
                        worksheet.Cells[i + 2, 4] = item.Thu;
                        worksheet.Cells[i + 2, 5] = item.Tiet;
                        worksheet.Cells[i + 2, 6] = item.Ngay.ToString("dd/MM/yyyy");
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

        // =============== IMPORT EXCEL ===============
        private void btnImportEx_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            openFileDialog.Title = "Chọn file Excel để nhập";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Excel.Application excel = new Excel.Application();
                    Excel.Workbook workbook = excel.Workbooks.Open(openFileDialog.FileName);
                    Excel.Worksheet worksheet = workbook.ActiveSheet;
                    Excel.Range range = worksheet.UsedRange;

                    danhSachTKB.Clear();

                    // Bắt đầu từ dòng 2 (dòng 1 là tiêu đề)
                    for (int row = 2; row <= range.Rows.Count; row++)
                    {
                        var maTKB = (range.Cells[row, 1] as Excel.Range)?.Value?.ToString() ?? "";
                        var maMon = (range.Cells[row, 2] as Excel.Range)?.Value?.ToString() ?? "";
                        var maLop = (range.Cells[row, 3] as Excel.Range)?.Value?.ToString() ?? "";
                        var thu = (range.Cells[row, 4] as Excel.Range)?.Value?.ToString() ?? "";
                        var tiet = (range.Cells[row, 5] as Excel.Range)?.Value?.ToString() ?? "";
                        var ngayStr = (range.Cells[row, 6] as Excel.Range)?.Value?.ToString() ?? "";

                        if (string.IsNullOrEmpty(maTKB)) continue;

                        DateTime ngay = DateTime.TryParse(ngayStr, out DateTime d) ? d : DateTime.Now;

                        danhSachTKB.Add(new ThoiKhoaBieuItem(maTKB, maMon, maLop, thu, tiet, ngay));
                    }

                    workbook.Close();
                    excel.Quit();

                    bindingSource.ResetBindings(false);
                    MessageBox.Show("Nhập Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi nhập Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // =============== HỖ TRỢ ===============
        public class ThoiKhoaBieuItem
        {
            public string MaTKB { get; set; }
            public string MaMon { get; set; }
            public string MaLop { get; set; }
            public string Thu { get; set; }
            public string Tiet { get; set; }
            public DateTime Ngay { get; set; }

            public ThoiKhoaBieuItem(string maTKB, string maMon, string maLop, string thu, string tiet, DateTime ngay)
            {
                MaTKB = maTKB;
                MaMon = maMon;
                MaLop = maLop;
                Thu = thu;
                Tiet = tiet;
                Ngay = ngay;
            }
        }
    }
}
