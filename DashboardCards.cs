using System;
using System.Drawing;
using System.Windows.Forms;

namespace GIL
{
    public partial class DashboardCards : UserControl
    {
        private Label lblTongGiangVien, lblPhongHoatDong, lblThietBiHuHong, lblYeuCauMoi;
        private Label lblTitle1, lblTitle2, lblTitle3, lblTitle4;
        private PictureBox pb1, pb2, pb3, pb4;
        private Panel card1, card2, card3, card4;

        public DashboardCards()
        {
            InitUI(); // ✅ Đổi tên từ InitializeComponent -> InitUI
            LoadData();
        }

        private void InitUI() // ✅ Đổi tên từ InitializeComponent -> InitUI
        {
            this.Size = new Size(800, 160);
            this.BackColor = Color.FromArgb(245, 245, 245); // Nền trắng xám nhẹ

            // Tạo 4 card
            CreateCard1();
            CreateCard2();
            CreateCard3();
            CreateCard4();

            // Add vào panel
            this.Controls.Add(card1);
            this.Controls.Add(card2);
            this.Controls.Add(card3);
            this.Controls.Add(card4);
        }

        private void CreateCard1()
        {
            card1 = new Panel();
            card1.Size = new Size(190, 140);
            card1.Location = new Point(10, 10);
            card1.BackColor = Color.FromArgb(52, 152, 219); // Xanh dương
            card1.Paint += (s, e) =>
            {
                using (var path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    int radius = 10;
                    var rect = new Rectangle(0, 0, card1.Width - 1, card1.Height - 1);
                    path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                    path.AddArc(rect.X + rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
                    path.AddArc(rect.X + rect.Width - radius - 1, rect.Y + rect.Height - radius - 1, radius, radius, 0, 90);
                    path.AddArc(rect.X, rect.Y + rect.Height - radius - 1, radius, radius, 90, 90);
                    path.CloseFigure();
                    card1.Region = new Region(path);
                }
            };

            pb1 = new PictureBox();
            //pb1.Image = Properties.Resources.user_white; // Icon người — phải có trong Resources
            pb1.Size = new Size(40, 40);
            pb1.Location = new Point(15, 20);
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;

            lblTitle1 = new Label();
            lblTitle1.Text = "Tổng Giảng Viên";
            lblTitle1.ForeColor = Color.White;
            lblTitle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTitle1.Location = new Point(70, 20);
            lblTitle1.Size = new Size(100, 20);

            lblTongGiangVien = new Label();
            lblTongGiangVien.Text = "120";
            lblTongGiangVien.ForeColor = Color.White;
            lblTongGiangVien.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTongGiangVien.Location = new Point(70, 50);
            lblTongGiangVien.Size = new Size(80, 40);

            card1.Controls.Add(pb1);
            card1.Controls.Add(lblTitle1);
            card1.Controls.Add(lblTongGiangVien);
        }

        private void CreateCard2()
        {
            card2 = new Panel();
            card2.Size = new Size(190, 140);
            card2.Location = new Point(210, 10);
            card2.BackColor = Color.FromArgb(46, 204, 113); // Xanh lá
            card2.Paint += (s, e) =>
            {
                using (var path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    int radius = 10;
                    var rect = new Rectangle(0, 0, card2.Width - 1, card2.Height - 1);
                    path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                    path.AddArc(rect.X + rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
                    path.AddArc(rect.X + rect.Width - radius - 1, rect.Y + rect.Height - radius - 1, radius, radius, 0, 90);
                    path.AddArc(rect.X, rect.Y + rect.Height - radius - 1, radius, radius, 90, 90);
                    path.CloseFigure();
                    card2.Region = new Region(path);
                }
            };

            pb2 = new PictureBox();
            //pb2.Image = Properties.Resources.classroom_white; // Icon phòng học
            pb2.Size = new Size(40, 40);
            pb2.Location = new Point(15, 20);
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;

            lblTitle2 = new Label();
            lblTitle2.Text = "Phòng Hoạt Động";
            lblTitle2.ForeColor = Color.White;
            lblTitle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTitle2.Location = new Point(70, 20);
            lblTitle2.Size = new Size(120, 20);

            lblPhongHoatDong = new Label();
            lblPhongHoatDong.Text = "45";
            lblPhongHoatDong.ForeColor = Color.White;
            lblPhongHoatDong.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblPhongHoatDong.Location = new Point(70, 50);
            lblPhongHoatDong.Size = new Size(80, 40);

            card2.Controls.Add(pb2);
            card2.Controls.Add(lblTitle2);
            card2.Controls.Add(lblPhongHoatDong);
        }

        private void CreateCard3()
        {
            card3 = new Panel();
            card3.Size = new Size(190, 140);
            card3.Location = new Point(410, 10);
            card3.BackColor = Color.FromArgb(243, 156, 18); // Cam
            card3.Paint += (s, e) =>
            {
                using (var path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    int radius = 10;
                    var rect = new Rectangle(0, 0, card3.Width - 1, card3.Height - 1);
                    path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                    path.AddArc(rect.X + rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
                    path.AddArc(rect.X + rect.Width - radius - 1, rect.Y + rect.Height - radius - 1, radius, radius, 0, 90);
                    path.AddArc(rect.X, rect.Y + rect.Height - radius - 1, radius, radius, 90, 90);
                    path.CloseFigure();
                    card3.Region = new Region(path);
                }
            };

            pb3 = new PictureBox();
            //pb3.Image = Properties.Resources.wrench_white; // Icon wrench
            pb3.Size = new Size(40, 40);
            pb3.Location = new Point(15, 20);
            pb3.SizeMode = PictureBoxSizeMode.StretchImage;

            lblTitle3 = new Label();
            lblTitle3.Text = "Thiết Bị Hư Hỏng";
            lblTitle3.ForeColor = Color.White;
            lblTitle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTitle3.Location = new Point(70, 20);
            lblTitle3.Size = new Size(120, 20);

            lblThietBiHuHong = new Label();
            lblThietBiHuHong.Text = "8";
            lblThietBiHuHong.ForeColor = Color.White;
            lblThietBiHuHong.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblThietBiHuHong.Location = new Point(70, 50);
            lblThietBiHuHong.Size = new Size(80, 40);

            card3.Controls.Add(pb3);
            card3.Controls.Add(lblTitle3);
            card3.Controls.Add(lblThietBiHuHong);
        }

        private void CreateCard4()
        {
            card4 = new Panel();
            card4.Size = new Size(190, 140);
            card4.Location = new Point(610, 10);
            card4.BackColor = Color.FromArgb(142, 68, 173); // Tím
            card4.Paint += (s, e) =>
            {
                using (var path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    int radius = 10;
                    var rect = new Rectangle(0, 0, card4.Width - 1, card4.Height - 1);
                    path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                    path.AddArc(rect.X + rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
                    path.AddArc(rect.X + rect.Width - radius - 1, rect.Y + rect.Height - radius - 1, radius, radius, 0, 90);
                    path.AddArc(rect.X, rect.Y + rect.Height - radius - 1, radius, radius, 90, 90);
                    path.CloseFigure();
                    card4.Region = new Region(path);
                }
            };

            pb4 = new PictureBox();
            //pb4.Image = Properties.Resources.bell_white; // Icon chuông
            pb4.Size = new Size(40, 40);
            pb4.Location = new Point(15, 20);
            pb4.SizeMode = PictureBoxSizeMode.StretchImage;

            lblTitle4 = new Label();
            lblTitle4.Text = "Yêu Cầu Mới";
            lblTitle4.ForeColor = Color.White;
            lblTitle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTitle4.Location = new Point(70, 20);
            lblTitle4.Size = new Size(100, 20);

            lblYeuCauMoi = new Label();
            lblYeuCauMoi.Text = "15";
            lblYeuCauMoi.ForeColor = Color.White;
            lblYeuCauMoi.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblYeuCauMoi.Location = new Point(70, 50);
            lblYeuCauMoi.Size = new Size(80, 40);

            card4.Controls.Add(pb4);
            card4.Controls.Add(lblTitle4);
            card4.Controls.Add(lblYeuCauMoi);
        }

        private void LoadData()
        {
            // Đây là nơi bạn load dữ liệu từ DB / API
            // Ví dụ:
            // lblTongGiangVien.Text = db.GetTotalTeachers().ToString();
            // lblPhongHoatDong.Text = db.GetActiveRooms().ToString();
            // ...
        }
    }
}
