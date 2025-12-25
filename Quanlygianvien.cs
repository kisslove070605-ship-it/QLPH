using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GIL
{
    public partial class QuanLyGiangVien : Form
    {
        private DataTable teacherTable; // Dữ liệu giả lập

        public QuanLyGiangVien()
        {
            InitializeComponent();
            InitializeSampleData(); // Tạo dữ liệu mẫu
        }

        private void InitializeSampleData()
        {
            teacherTable = new DataTable();
            teacherTable.Columns.Add("Mã GV");
            teacherTable.Columns.Add("Mã Khoa");
            teacherTable.Columns.Add("Tên GV");
            teacherTable.Columns.Add("Ngày Sinh");
            teacherTable.Columns.Add("Địa Chỉ");

            teacherTable.Rows.Add("GV001", "CNTT", "Nguyễn Văn A", "1999/12/12", "Cần Thơ");
            teacherTable.Rows.Add("GV002", "CNTT", "Nguyễn Văn B", "1999/12/12", "Trà Vinh");
            teacherTable.Rows.Add("GV003", "YKH", "Thái Thị Trâm", "1998/11/25", "Vĩnh Long");
            teacherTable.Rows.Add("GV004", "KT", "Nguyễn Trâm Anh", "1978/02/23", "An Giang");

            dgvTeachers.DataSource = teacherTable;
        }

        private void dgvTeachers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTeachers.SelectedRows.Count > 0)
            {
                var row = dgvTeachers.SelectedRows[0];
                cboMaGV.Text = row.Cells["Mã GV"].Value?.ToString() ?? "";
                cboMaKhoa.Text = row.Cells["Mã Khoa"].Value?.ToString() ?? "";
                txtTenGV.Text = row.Cells["Tên GV"].Value?.ToString() ?? "";
                dtpNgaySinh.Value = DateTime.TryParse(row.Cells["Ngày Sinh"].Value?.ToString(), out DateTime date) ? date : DateTime.Now;
                txtDiaChi.Text = row.Cells["Địa Chỉ"].Value?.ToString() ?? "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboMaGV.Text) || string.IsNullOrWhiteSpace(txtTenGV.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã GV và Tên Giảng Viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newRow = teacherTable.NewRow();
            newRow["Mã GV"] = cboMaGV.Text;
            newRow["Mã Khoa"] = cboMaKhoa.Text;
            newRow["Tên GV"] = txtTenGV.Text;
            newRow["Ngày Sinh"] = dtpNgaySinh.Value.ToString("yyyy/MM/dd");
            newRow["Địa Chỉ"] = txtDiaChi.Text;

            teacherTable.Rows.Add(newRow);
            MessageBox.Show("Thêm giảng viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTeachers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn giảng viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvTeachers.SelectedRows[0];
            var dataRow = ((DataRowView)row.DataBoundItem).Row;

            dataRow["Mã GV"] = cboMaGV.Text;
            dataRow["Mã Khoa"] = cboMaKhoa.Text;
            dataRow["Tên GV"] = txtTenGV.Text;
            dataRow["Ngày Sinh"] = dtpNgaySinh.Value.ToString("yyyy/MM/dd");
            dataRow["Địa Chỉ"] = txtDiaChi.Text;

            MessageBox.Show("Cập nhật giảng viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTeachers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn giảng viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvTeachers.SelectedRows[0];
            var dataRow = ((DataRowView)row.DataBoundItem).Row;

            teacherTable.Rows.Remove(dataRow);
            MessageBox.Show("Xóa giảng viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng In chưa được triển khai.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Xuất Excel chưa được triển khai.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearForm()
        {
            cboMaGV.Text = "";
            cboMaKhoa.Text = "";
            txtTenGV.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            txtSDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            dgvTeachers.ClearSelection();
        }

        private void QuanLyGiangVien_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
            this.Text = "ShareCode.vn - Hệ thống quản lý phòng học DNC";
        }
    }
}
