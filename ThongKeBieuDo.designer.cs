namespace QuanLyPhongHoc
{
    partial class ThongKeBieuDo
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
            this.chartSuDungPhong = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartThietBi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chartGioHoc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartSuDungPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThietBi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGioHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSuDungPhong
            // 
            this.chartSuDungPhong.Location = new System.Drawing.Point(20, 40);
            this.chartSuDungPhong.Name = "chartSuDungPhong";
            this.chartSuDungPhong.Size = new System.Drawing.Size(300, 300);
            this.chartSuDungPhong.TabIndex = 0;
            this.chartSuDungPhong.Text = "Biểu đồ 1";
            // 
            // chartThietBi
            // 
            this.chartThietBi.Location = new System.Drawing.Point(340, 40);
            this.chartThietBi.Name = "chartThietBi";
            this.chartThietBi.Size = new System.Drawing.Size(300, 300);
            this.chartThietBi.TabIndex = 1;
            this.chartThietBi.Text = "Biểu đồ 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tần suất sử dụng phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tỷ lệ thiết bị theo trạng thái";
            // 
            // chartGioHoc
            // 
            this.chartGioHoc.Location = new System.Drawing.Point(660, 40);
            this.chartGioHoc.Name = "chartGioHoc";
            this.chartGioHoc.Size = new System.Drawing.Size(300, 300);
            this.chartGioHoc.TabIndex = 4;
            this.chartGioHoc.Text = "Biểu đồ 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(660, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số giờ học theo tháng (2025)";
            // 
            // ThongKeBieuDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(980, 360);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chartGioHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartThietBi);
            this.Controls.Add(this.chartSuDungPhong);
            this.Name = "ThongKeBieuDo";
            this.Text = "Thống Kê & Biểu Đồ";
            this.Load += new System.EventHandler(this.ThongKeBieuDo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSuDungPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThietBi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGioHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSuDungPhong;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThietBi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGioHoc;
        private System.Windows.Forms.Label label3;
    }
}
