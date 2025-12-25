namespace GIL
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    partial class DanhSachLop
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboMaLop = new System.Windows.Forms.ComboBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtSoLuongSV = new System.Windows.Forms.TextBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.lblSoLuongSV = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Controls.Add(this.lblTitle);
            this.panelLeft.Controls.Add(this.cboMaLop);
            this.panelLeft.Controls.Add(this.txtTenLop);
            this.panelLeft.Controls.Add(this.txtSoLuongSV);
            this.panelLeft.Controls.Add(this.lblMaLop);
            this.panelLeft.Controls.Add(this.lblTenLop);
            this.panelLeft.Controls.Add(this.lblSoLuongSV);
            this.panelLeft.Controls.Add(this.btnThem);
            this.panelLeft.Controls.Add(this.btnChinhSua);
            this.panelLeft.Controls.Add(this.btnXoa);
            this.panelLeft.Controls.Add(this.btnIn);
            this.panelLeft.Controls.Add(this.btnXuatExcel);
            this.panelLeft.Location = new System.Drawing.Point(10, 35);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(292, 380);
            this.panelLeft.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(112, 18);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Danh Mục Lớp";
            // 
            // cboMaLop
            // 
            this.cboMaLop.FormattingEnabled = true;
            this.cboMaLop.Location = new System.Drawing.Point(127, 40);
            this.cboMaLop.Name = "cboMaLop";
            this.cboMaLop.Size = new System.Drawing.Size(150, 24);
            this.cboMaLop.TabIndex = 1;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(127, 70);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(150, 22);
            this.txtTenLop.TabIndex = 2;
            // 
            // txtSoLuongSV
            // 
            this.txtSoLuongSV.Location = new System.Drawing.Point(127, 98);
            this.txtSoLuongSV.Name = "txtSoLuongSV";
            this.txtSoLuongSV.Size = new System.Drawing.Size(150, 22);
            this.txtSoLuongSV.TabIndex = 3;
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(10, 43);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(55, 16);
            this.lblMaLop.TabIndex = 4;
            this.lblMaLop.Text = "Mã Lớp:";
            // 
            // lblTenLop
            // 
            this.lblTenLop.AutoSize = true;
            this.lblTenLop.Location = new System.Drawing.Point(10, 73);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(60, 16);
            this.lblTenLop.TabIndex = 5;
            this.lblTenLop.Text = "Tên Lớp:";
            // 
            // lblSoLuongSV
            // 
            this.lblSoLuongSV.AutoSize = true;
            this.lblSoLuongSV.Location = new System.Drawing.Point(10, 98);
            this.lblSoLuongSV.Name = "lblSoLuongSV";
            this.lblSoLuongSV.Size = new System.Drawing.Size(88, 16);
            this.lblSoLuongSV.TabIndex = 6;
            this.lblSoLuongSV.Text = "Số Lượng SV:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(13, 144);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 25);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Location = new System.Drawing.Point(111, 144);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(70, 25);
            this.btnChinhSua.TabIndex = 8;
            this.btnChinhSua.Text = "Sửa";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(207, 144);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 25);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(65, 185);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(70, 25);
            this.btnIn.TabIndex = 10;
            this.btnIn.Text = "IN";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Location = new System.Drawing.Point(158, 185);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(70, 25);
            this.btnXuatExcel.TabIndex = 11;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Controls.Add(this.lblDanhSach);
            this.panelRight.Controls.Add(this.dgvClasses);
            this.panelRight.Location = new System.Drawing.Point(308, 35);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(462, 380);
            this.panelRight.TabIndex = 2;
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSach.Location = new System.Drawing.Point(10, 10);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(181, 18);
            this.lblDanhSach.TabIndex = 0;
            this.lblDanhSach.Text = "Hiển Thị Danh Sách Lớp";
            // 
            // dgvClasses
            // 
            this.dgvClasses.AllowUserToAddRows = false;
            this.dgvClasses.AllowUserToDeleteRows = false;
            this.dgvClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Location = new System.Drawing.Point(10, 30);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.ReadOnly = true;
            this.dgvClasses.RowHeadersVisible = false;
            this.dgvClasses.RowHeadersWidth = 51;
            this.dgvClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClasses.Size = new System.Drawing.Size(436, 340);
            this.dgvClasses.TabIndex = 1;
            this.dgvClasses.SelectionChanged += new System.EventHandler(this.dgvClasses_SelectionChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GIL.Properties.Resources.z7359893045379_e1bad2a62df24426d627d9eba96a9ad31;
            this.pictureBox1.Location = new System.Drawing.Point(37, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // DanhSachLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Name = "DanhSachLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShareCode.vn - Hệ thống quản lý phòng học DNC";
            this.Load += new System.EventHandler(this.DanhSachLop_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cboMaLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtSoLuongSV;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.Label lblSoLuongSV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.DataGridView dgvClasses;
        private PictureBox pictureBox1;
    }
}
