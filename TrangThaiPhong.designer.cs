namespace QuanLyPhongHoc
{
    partial class TrangThaiPhong
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.comboBoxTrangThai = new System.Windows.Forms.ComboBox();
            this.labelTrangThai = new System.Windows.Forms.Label();
            this.comboBoxTinhTrang = new System.Windows.Forms.ComboBox();
            this.labelTinhTrang = new System.Windows.Forms.Label();
            this.comboBoxDayNha = new System.Windows.Forms.ComboBox();
            this.labelDayNha = new System.Windows.Forms.Label();
            this.comboBoxLoaiPhong = new System.Windows.Forms.ComboBox();
            this.labelLoaiPhong = new System.Windows.Forms.Label();
            this.textBoxTenPhong = new System.Windows.Forms.TextBox();
            this.labelTenPhong = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.dataGridViewTrangThai = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrangThai)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.LightBlue;
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Controls.Add(this.btnTim);
            this.panelLeft.Controls.Add(this.btnXuatExcel);
            this.panelLeft.Controls.Add(this.comboBoxTrangThai);
            this.panelLeft.Controls.Add(this.labelTrangThai);
            this.panelLeft.Controls.Add(this.comboBoxTinhTrang);
            this.panelLeft.Controls.Add(this.labelTinhTrang);
            this.panelLeft.Controls.Add(this.comboBoxDayNha);
            this.panelLeft.Controls.Add(this.labelDayNha);
            this.panelLeft.Controls.Add(this.comboBoxLoaiPhong);
            this.panelLeft.Controls.Add(this.labelLoaiPhong);
            this.panelLeft.Controls.Add(this.textBoxTenPhong);
            this.panelLeft.Controls.Add(this.labelTenPhong);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(365, 597);
            this.panelLeft.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.BackgroundImage = global::TrangThaiPhong.Properties.Resources.logo;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::TrangThaiPhong.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(15, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTim.Location = new System.Drawing.Point(212, 528);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(107, 37);
            this.btnTim.TabIndex = 11;
            this.btnTim.Text = "TÌM";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.Cyan;
            this.btnXuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXuatExcel.Location = new System.Drawing.Point(65, 528);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(133, 37);
            this.btnXuatExcel.TabIndex = 10;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // comboBoxTrangThai
            // 
            this.comboBoxTrangThai.ForeColor = System.Drawing.Color.Blue;
            this.comboBoxTrangThai.FormattingEnabled = true;
            this.comboBoxTrangThai.Items.AddRange(new object[] {
            "Bình Thường",
            "Đang sửa chữa",
            "Đang xin cấp"});
            this.comboBoxTrangThai.Location = new System.Drawing.Point(116, 427);
            this.comboBoxTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTrangThai.Name = "comboBoxTrangThai";
            this.comboBoxTrangThai.Size = new System.Drawing.Size(239, 24);
            this.comboBoxTrangThai.TabIndex = 9;
            // 
            // labelTrangThai
            // 
            this.labelTrangThai.AutoSize = true;
            this.labelTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelTrangThai.Location = new System.Drawing.Point(12, 433);
            this.labelTrangThai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTrangThai.Name = "labelTrangThai";
            this.labelTrangThai.Size = new System.Drawing.Size(93, 18);
            this.labelTrangThai.TabIndex = 8;
            this.labelTrangThai.Text = "Trạng Thái:";
            // 
            // comboBoxTinhTrang
            // 
            this.comboBoxTinhTrang.ForeColor = System.Drawing.Color.Blue;
            this.comboBoxTinhTrang.FormattingEnabled = true;
            this.comboBoxTinhTrang.Items.AddRange(new object[] {
            "Bình Thường",
            "Hỏng",
            "Cần bảo trì"});
            this.comboBoxTinhTrang.Location = new System.Drawing.Point(116, 345);
            this.comboBoxTinhTrang.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTinhTrang.Name = "comboBoxTinhTrang";
            this.comboBoxTinhTrang.Size = new System.Drawing.Size(239, 24);
            this.comboBoxTinhTrang.TabIndex = 7;
            // 
            // labelTinhTrang
            // 
            this.labelTinhTrang.AutoSize = true;
            this.labelTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTinhTrang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelTinhTrang.Location = new System.Drawing.Point(12, 351);
            this.labelTinhTrang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTinhTrang.Name = "labelTinhTrang";
            this.labelTinhTrang.Size = new System.Drawing.Size(93, 18);
            this.labelTinhTrang.TabIndex = 6;
            this.labelTinhTrang.Text = "Tình Trạng:";
            // 
            // comboBoxDayNha
            // 
            this.comboBoxDayNha.ForeColor = System.Drawing.Color.Blue;
            this.comboBoxDayNha.FormattingEnabled = true;
            this.comboBoxDayNha.Items.AddRange(new object[] {
            "Dãy A",
            "Dãy B",
            "Dãy C",
            "Dãy D",
            "Dãy E"});
            this.comboBoxDayNha.Location = new System.Drawing.Point(116, 280);
            this.comboBoxDayNha.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDayNha.Name = "comboBoxDayNha";
            this.comboBoxDayNha.Size = new System.Drawing.Size(239, 24);
            this.comboBoxDayNha.TabIndex = 5;
            // 
            // labelDayNha
            // 
            this.labelDayNha.AutoSize = true;
            this.labelDayNha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDayNha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelDayNha.Location = new System.Drawing.Point(12, 286);
            this.labelDayNha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDayNha.Name = "labelDayNha";
            this.labelDayNha.Size = new System.Drawing.Size(77, 18);
            this.labelDayNha.TabIndex = 4;
            this.labelDayNha.Text = "Dãy Nhà:";
            // 
            // comboBoxLoaiPhong
            // 
            this.comboBoxLoaiPhong.ForeColor = System.Drawing.Color.Blue;
            this.comboBoxLoaiPhong.FormattingEnabled = true;
            this.comboBoxLoaiPhong.Items.AddRange(new object[] {
            "Lý Thuyết",
            "Thực Hành",
            "Khu hiệu bộ",
            "Khu thực hành đa chức năng"});
            this.comboBoxLoaiPhong.Location = new System.Drawing.Point(116, 212);
            this.comboBoxLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxLoaiPhong.Name = "comboBoxLoaiPhong";
            this.comboBoxLoaiPhong.Size = new System.Drawing.Size(239, 24);
            this.comboBoxLoaiPhong.TabIndex = 3;
            // 
            // labelLoaiPhong
            // 
            this.labelLoaiPhong.AutoSize = true;
            this.labelLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoaiPhong.ForeColor = System.Drawing.Color.Blue;
            this.labelLoaiPhong.Location = new System.Drawing.Point(12, 217);
            this.labelLoaiPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoaiPhong.Name = "labelLoaiPhong";
            this.labelLoaiPhong.Size = new System.Drawing.Size(98, 18);
            this.labelLoaiPhong.TabIndex = 2;
            this.labelLoaiPhong.Text = "Loại Phòng:";
            // 
            // textBoxTenPhong
            // 
            this.textBoxTenPhong.ForeColor = System.Drawing.Color.Blue;
            this.textBoxTenPhong.Location = new System.Drawing.Point(116, 146);
            this.textBoxTenPhong.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTenPhong.Name = "textBoxTenPhong";
            this.textBoxTenPhong.Size = new System.Drawing.Size(239, 22);
            this.textBoxTenPhong.TabIndex = 1;
            // 
            // labelTenPhong
            // 
            this.labelTenPhong.AutoSize = true;
            this.labelTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenPhong.ForeColor = System.Drawing.Color.Blue;
            this.labelTenPhong.Location = new System.Drawing.Point(12, 149);
            this.labelTenPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTenPhong.Name = "labelTenPhong";
            this.labelTenPhong.Size = new System.Drawing.Size(94, 18);
            this.labelTenPhong.TabIndex = 0;
            this.labelTenPhong.Text = "Tên Phòng:";
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.dataGridViewTrangThai);
            this.panelRight.Controls.Add(this.label1);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(365, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(4);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1024, 597);
            this.panelRight.TabIndex = 1;
            // 
            // dataGridViewTrangThai
            // 
            this.dataGridViewTrangThai.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridViewTrangThai.AllowUserToAddRows = false;
            this.dataGridViewTrangThai.AllowUserToDeleteRows = false;
            this.dataGridViewTrangThai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrangThai.Location = new System.Drawing.Point(4, 67);
            this.dataGridViewTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewTrangThai.Name = "dataGridViewTrangThai";
            this.dataGridViewTrangThai.ReadOnly = true;
            this.dataGridViewTrangThai.RowHeadersWidth = 51;
            this.dataGridViewTrangThai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTrangThai.Size = new System.Drawing.Size(1004, 517);
            this.dataGridViewTrangThai.TabIndex = 1;
            this.dataGridViewTrangThai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTrangThai_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hiển Thị Thông Tin Trạng Thái Phòng";
            // 
            // TrangThaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1389, 597);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TrangThaiPhong";
            this.Text = "Thống Tin Trạng Thái Phòng";
            this.Load += new System.EventHandler(this.TrangThaiPhong_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrangThai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label labelTenPhong;
        private System.Windows.Forms.TextBox textBoxTenPhong;
        private System.Windows.Forms.ComboBox comboBoxLoaiPhong;
        private System.Windows.Forms.Label labelLoaiPhong;
        private System.Windows.Forms.ComboBox comboBoxDayNha;
        private System.Windows.Forms.Label labelDayNha;
        private System.Windows.Forms.ComboBox comboBoxTinhTrang;
        private System.Windows.Forms.Label labelTinhTrang;
        private System.Windows.Forms.ComboBox comboBoxTrangThai;
        private System.Windows.Forms.Label labelTrangThai;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dataGridViewTrangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
