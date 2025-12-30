namespace QuanLyPhongHoc
{
    partial class ThongKeHieuSuat
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLichPhongHoc = new System.Windows.Forms.TabPage();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnTim = new System.Windows.Forms.Button();
            this.comboBoxLop = new System.Windows.Forms.ComboBox();
            this.labelLop = new System.Windows.Forms.Label();
            this.dateTimePickerDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTuNgay = new System.Windows.Forms.DateTimePicker();
            this.labelDenNgay = new System.Windows.Forms.Label();
            this.labelTuNgay = new System.Windows.Forms.Label();
            this.comboBoxDayNha = new System.Windows.Forms.ComboBox();
            this.labelDayNha = new System.Windows.Forms.Label();
            this.textBoxTenPhong = new System.Windows.Forms.TextBox();
            this.labelTenPhong = new System.Windows.Forms.Label();
            this.textBoxMaPhong = new System.Windows.Forms.TextBox();
            this.labelMaPhong = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.dataGridViewThongKe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageChiTiet = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPageLichPhongHoc.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLichPhongHoc);
            this.tabControl1.Controls.Add(this.tabPageChiTiet);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1333, 738);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageLichPhongHoc
            // 
            this.tabPageLichPhongHoc.BackColor = System.Drawing.Color.LightBlue;
            this.tabPageLichPhongHoc.Controls.Add(this.panelLeft);
            this.tabPageLichPhongHoc.Controls.Add(this.panelRight);
            this.tabPageLichPhongHoc.Location = new System.Drawing.Point(4, 25);
            this.tabPageLichPhongHoc.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageLichPhongHoc.Name = "tabPageLichPhongHoc";
            this.tabPageLichPhongHoc.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageLichPhongHoc.Size = new System.Drawing.Size(1325, 709);
            this.tabPageLichPhongHoc.TabIndex = 0;
            this.tabPageLichPhongHoc.Text = "Lịch Phòng Học";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.LightBlue;
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Controls.Add(this.btnTim);
            this.panelLeft.Controls.Add(this.comboBoxLop);
            this.panelLeft.Controls.Add(this.labelLop);
            this.panelLeft.Controls.Add(this.dateTimePickerDenNgay);
            this.panelLeft.Controls.Add(this.dateTimePickerTuNgay);
            this.panelLeft.Controls.Add(this.labelDenNgay);
            this.panelLeft.Controls.Add(this.labelTuNgay);
            this.panelLeft.Controls.Add(this.comboBoxDayNha);
            this.panelLeft.Controls.Add(this.labelDayNha);
            this.panelLeft.Controls.Add(this.textBoxTenPhong);
            this.panelLeft.Controls.Add(this.labelTenPhong);
            this.panelLeft.Controls.Add(this.textBoxMaPhong);
            this.panelLeft.Controls.Add(this.labelMaPhong);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(4, 4);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(399, 701);
            this.panelLeft.TabIndex = 0;
            // 
            // btnTim
            // 
            this.btnTim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTim.Location = new System.Drawing.Point(160, 554);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(107, 37);
            this.btnTim.TabIndex = 12;
            this.btnTim.Text = "TÌM";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // comboBoxLop
            // 
            this.comboBoxLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLop.ForeColor = System.Drawing.Color.Blue;
            this.comboBoxLop.FormattingEnabled = true;
            this.comboBoxLop.Items.AddRange(new object[] {
            "DH19TIN03",
            "DH19MAR01",
            "DH19MAR02",
            "DH20TIN01"});
            this.comboBoxLop.Location = new System.Drawing.Point(124, 467);
            this.comboBoxLop.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxLop.Name = "comboBoxLop";
            this.comboBoxLop.Size = new System.Drawing.Size(239, 26);
            this.comboBoxLop.TabIndex = 11;
            // 
            // labelLop
            // 
            this.labelLop.AutoSize = true;
            this.labelLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelLop.Location = new System.Drawing.Point(27, 467);
            this.labelLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLop.Name = "labelLop";
            this.labelLop.Size = new System.Drawing.Size(41, 18);
            this.labelLop.TabIndex = 10;
            this.labelLop.Text = "Lớp:";
            // 
            // dateTimePickerDenNgay
            // 
            this.dateTimePickerDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDenNgay.Location = new System.Drawing.Point(124, 399);
            this.dateTimePickerDenNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDenNgay.Name = "dateTimePickerDenNgay";
            this.dateTimePickerDenNgay.Size = new System.Drawing.Size(145, 24);
            this.dateTimePickerDenNgay.TabIndex = 9;
            // 
            // dateTimePickerTuNgay
            // 
            this.dateTimePickerTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTuNgay.Location = new System.Drawing.Point(124, 347);
            this.dateTimePickerTuNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerTuNgay.Name = "dateTimePickerTuNgay";
            this.dateTimePickerTuNgay.Size = new System.Drawing.Size(145, 24);
            this.dateTimePickerTuNgay.TabIndex = 8;
            // 
            // labelDenNgay
            // 
            this.labelDenNgay.AutoSize = true;
            this.labelDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDenNgay.Location = new System.Drawing.Point(190, 351);
            this.labelDenNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDenNgay.Name = "labelDenNgay";
            this.labelDenNgay.Size = new System.Drawing.Size(24, 18);
            this.labelDenNgay.TabIndex = 7;
            this.labelDenNgay.Text = "→";
            // 
            // labelTuNgay
            // 
            this.labelTuNgay.AutoSize = true;
            this.labelTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTuNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelTuNgay.Location = new System.Drawing.Point(27, 348);
            this.labelTuNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTuNgay.Name = "labelTuNgay";
            this.labelTuNgay.Size = new System.Drawing.Size(75, 18);
            this.labelTuNgay.TabIndex = 6;
            this.labelTuNgay.Text = "Từ Ngày:";
            // 
            // comboBoxDayNha
            // 
            this.comboBoxDayNha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDayNha.ForeColor = System.Drawing.Color.Blue;
            this.comboBoxDayNha.FormattingEnabled = true;
            this.comboBoxDayNha.Items.AddRange(new object[] {
            "Dãy A",
            "Dãy B",
            "Dãy C",
            "Dãy D"});
            this.comboBoxDayNha.Location = new System.Drawing.Point(123, 280);
            this.comboBoxDayNha.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDayNha.Name = "comboBoxDayNha";
            this.comboBoxDayNha.Size = new System.Drawing.Size(239, 26);
            this.comboBoxDayNha.TabIndex = 5;
            // 
            // labelDayNha
            // 
            this.labelDayNha.AutoSize = true;
            this.labelDayNha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDayNha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelDayNha.Location = new System.Drawing.Point(26, 281);
            this.labelDayNha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDayNha.Name = "labelDayNha";
            this.labelDayNha.Size = new System.Drawing.Size(77, 18);
            this.labelDayNha.TabIndex = 4;
            this.labelDayNha.Text = "Dãy Nhà:";
            // 
            // textBoxTenPhong
            // 
            this.textBoxTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenPhong.ForeColor = System.Drawing.Color.Blue;
            this.textBoxTenPhong.Location = new System.Drawing.Point(123, 224);
            this.textBoxTenPhong.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTenPhong.Name = "textBoxTenPhong";
            this.textBoxTenPhong.Size = new System.Drawing.Size(239, 24);
            this.textBoxTenPhong.TabIndex = 3;
            // 
            // labelTenPhong
            // 
            this.labelTenPhong.AutoSize = true;
            this.labelTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelTenPhong.Location = new System.Drawing.Point(26, 225);
            this.labelTenPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTenPhong.Name = "labelTenPhong";
            this.labelTenPhong.Size = new System.Drawing.Size(94, 18);
            this.labelTenPhong.TabIndex = 2;
            this.labelTenPhong.Text = "Tên Phòng:";
            // 
            // textBoxMaPhong
            // 
            this.textBoxMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaPhong.ForeColor = System.Drawing.Color.Blue;
            this.textBoxMaPhong.Location = new System.Drawing.Point(123, 154);
            this.textBoxMaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaPhong.Name = "textBoxMaPhong";
            this.textBoxMaPhong.Size = new System.Drawing.Size(239, 24);
            this.textBoxMaPhong.TabIndex = 1;
            // 
            // labelMaPhong
            // 
            this.labelMaPhong.AutoSize = true;
            this.labelMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelMaPhong.Location = new System.Drawing.Point(26, 154);
            this.labelMaPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaPhong.Name = "labelMaPhong";
            this.labelMaPhong.Size = new System.Drawing.Size(89, 18);
            this.labelMaPhong.TabIndex = 0;
            this.labelMaPhong.Text = "Mã Phòng:";
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.dataGridViewThongKe);
            this.panelRight.Controls.Add(this.label1);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(4, 4);
            this.panelRight.Margin = new System.Windows.Forms.Padding(4);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1317, 701);
            this.panelRight.TabIndex = 1;
            // 
            // dataGridViewThongKe
            // 
            this.dataGridViewThongKe.AllowUserToAddRows = false;
            this.dataGridViewThongKe.AllowUserToDeleteRows = false;
            this.dataGridViewThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongKe.Location = new System.Drawing.Point(400, 12);
            this.dataGridViewThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewThongKe.Name = "dataGridViewThongKe";
            this.dataGridViewThongKe.ReadOnly = true;
            this.dataGridViewThongKe.RowHeadersWidth = 51;
            this.dataGridViewThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewThongKe.Size = new System.Drawing.Size(925, 662);
            this.dataGridViewThongKe.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hiển Thị Thông Tin Chi Tiết Sử Dụng";
            // 
            // tabPageChiTiet
            // 
            this.tabPageChiTiet.BackColor = System.Drawing.Color.LightBlue;
            this.tabPageChiTiet.Location = new System.Drawing.Point(4, 25);
            this.tabPageChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageChiTiet.Name = "tabPageChiTiet";
            this.tabPageChiTiet.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageChiTiet.Size = new System.Drawing.Size(1325, 709);
            this.tabPageChiTiet.TabIndex = 1;
            this.tabPageChiTiet.Text = "Chi Tiết Sử Dụng Phòng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ThongKeHieuSuat.Properties.Resources.logo;
            this.pictureBox1.Image = global::ThongKeHieuSuat.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(50, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // ThongKeHieuSuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 738);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThongKeHieuSuat";
            this.Text = "Thống Kê Hiệu Suất Sử Dụng Phòng Học";
            this.Load += new System.EventHandler(this.ThongKeHieuSuat_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageLichPhongHoc.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLichPhongHoc;
        private System.Windows.Forms.TabPage tabPageChiTiet;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label labelMaPhong;
        private System.Windows.Forms.TextBox textBoxMaPhong;
        private System.Windows.Forms.TextBox textBoxTenPhong;
        private System.Windows.Forms.Label labelTenPhong;
        private System.Windows.Forms.ComboBox comboBoxDayNha;
        private System.Windows.Forms.Label labelDayNha;
        private System.Windows.Forms.DateTimePicker dateTimePickerDenNgay;
        private System.Windows.Forms.DateTimePicker dateTimePickerTuNgay;
        private System.Windows.Forms.Label labelDenNgay;
        private System.Windows.Forms.Label labelTuNgay;
        private System.Windows.Forms.ComboBox comboBoxLop;
        private System.Windows.Forms.Label labelLop;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dataGridViewThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
