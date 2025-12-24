namespace QuanLyPhongHoc
{
    partial class frmQuanLyThietBi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenThietBi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMaThietBi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQLThietBi = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(218, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ THÔNG TIN THIẾT BỊ";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.LightBlue;
            this.panelLeft.Controls.Add(this.btnXuatExcel);
            this.panelLeft.Controls.Add(this.btnIn);
            this.panelLeft.Controls.Add(this.btnXoa);
            this.panelLeft.Controls.Add(this.btnChinhSua);
            this.panelLeft.Controls.Add(this.btnThem);
            this.panelLeft.Controls.Add(this.txtGhiChu);
            this.panelLeft.Controls.Add(this.label5);
            this.panelLeft.Controls.Add(this.txtTrangThai);
            this.panelLeft.Controls.Add(this.label4);
            this.panelLeft.Controls.Add(this.txtTinhTrang);
            this.panelLeft.Controls.Add(this.label3);
            this.panelLeft.Controls.Add(this.txtTenThietBi);
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Controls.Add(this.cbMaThietBi);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.lblQLThietBi);
            this.panelLeft.Location = new System.Drawing.Point(12, 30);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(250, 400);
            this.panelLeft.TabIndex = 1;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Location = new System.Drawing.Point(130, 350);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(100, 25);
            this.btnXuatExcel.TabIndex = 15;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(20, 350);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(100, 25);
            this.btnIn.TabIndex = 14;
            this.btnIn.Text = "IN";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(130, 310);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 25);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Location = new System.Drawing.Point(20, 310);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(100, 25);
            this.btnChinhSua.TabIndex = 12;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(70, 270);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 25);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(100, 200);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(130, 50);
            this.txtGhiChu.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ghi Chú";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(100, 160);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(130, 20);
            this.txtTrangThai.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Trạng Thái";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(100, 120);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(130, 20);
            this.txtTinhTrang.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tình Trạng";
            // 
            // txtTenThietBi
            // 
            this.txtTenThietBi.Location = new System.Drawing.Point(100, 80);
            this.txtTenThietBi.Name = "txtTenThietBi";
            this.txtTenThietBi.Size = new System.Drawing.Size(130, 20);
            this.txtTenThietBi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Thiết Bị";
            // 
            // cbMaThietBi
            // 
            this.cbMaThietBi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaThietBi.FormattingEnabled = true;
            this.cbMaThietBi.Location = new System.Drawing.Point(100, 40);
            this.cbMaThietBi.Name = "cbMaThietBi";
            this.cbMaThietBi.Size = new System.Drawing.Size(130, 21);
            this.cbMaThietBi.TabIndex = 2;
            this.cbMaThietBi.SelectedIndexChanged += new System.EventHandler(this.cbMaThietBi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Thiết Bị";
            // 
            // lblQLThietBi
            // 
            this.lblQLThietBi.AutoSize = true;
            this.lblQLThietBi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLThietBi.ForeColor = System.Drawing.Color.Red;
            this.lblQLThietBi.Location = new System.Drawing.Point(10, 10);
            this.lblQLThietBi.Name = "lblQLThietBi";
            this.lblQLThietBi.Size = new System.Drawing.Size(155, 15);
            this.lblQLThietBi.TabIndex = 0;
            this.lblQLThietBi.Text = "Quản Lý Thông Tin Thiết Bị";
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.dgvDanhSach);
            this.panelRight.Controls.Add(this.lblDanhSach);
            this.panelRight.Location = new System.Drawing.Point(270, 30);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(600, 400);
            this.panelRight.TabIndex = 2;
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.AllowUserToDeleteRows = false;
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(10, 40);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.Size = new System.Drawing.Size(580, 350);
            this.dgvDanhSach.TabIndex = 1;
            this.dgvDanhSach.SelectionChanged += new System.EventHandler(this.dgvDanhSach_SelectionChanged);
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSach.ForeColor = System.Drawing.Color.Blue;
            this.lblDanhSach.Location = new System.Drawing.Point(10, 10);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(207, 15);
            this.lblDanhSach.TabIndex = 0;
            this.lblDanhSach.Text = "Hiển Thị Danh Sách Thông Tin Thiết Bị";
            // 
            // frmQuanLyThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmQuanLyThietBi";
            this.Text = "Quản lý Thiết bị - Hệ thống Quản lý Phòng Học DNC";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblQLThietBi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMaThietBi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenThietBi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.DataGridView dgvDanhSach;
    }
}
