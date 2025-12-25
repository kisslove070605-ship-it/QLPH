namespace GIL
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    partial class DoiMatKhau
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
            this.tabPageChangePassword = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblChangePassword = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tabPageCreateAccount = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPageChangePassword.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPageChangePassword
            // 
            this.tabPageChangePassword.Controls.Add(this.panel1);
            this.tabPageChangePassword.Location = new System.Drawing.Point(4, 25);
            this.tabPageChangePassword.Name = "tabPageChangePassword";
            this.tabPageChangePassword.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChangePassword.Size = new System.Drawing.Size(792, 421);
            this.tabPageChangePassword.TabIndex = 1;
            this.tabPageChangePassword.Text = "Đổi Mật Khẩu";
            this.tabPageChangePassword.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtOldPassword);
            this.panel1.Controls.Add(this.txtNewPassword);
            this.panel1.Controls.Add(this.txtConfirmPassword);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.lblOldPassword);
            this.panel1.Controls.Add(this.lblNewPassword);
            this.panel1.Controls.Add(this.lblConfirmPassword);
            this.panel1.Controls.Add(this.chkShowPassword);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnAccept);
            this.panel1.Controls.Add(this.lblChangePassword);
            this.panel1.Location = new System.Drawing.Point(6, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 350);
            this.panel1.TabIndex = 0;
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePassword.ForeColor = System.Drawing.Color.Red;
            this.lblChangePassword.Location = new System.Drawing.Point(540, 61);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(168, 29);
            this.lblChangePassword.TabIndex = 15;
            this.lblChangePassword.Text = "Đổi Mật Khẩu";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(641, 251);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(90, 30);
            this.btnAccept.TabIndex = 14;
            this.btnAccept.Text = "Xác Nhận";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(531, 251);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 30);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Nhập Lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword.Location = new System.Drawing.Point(599, 225);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(132, 20);
            this.chkShowPassword.TabIndex = 12;
            this.chkShowPassword.Text = "Hiển thị mật khẩu";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(372, 199);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(145, 18);
            this.lblConfirmPassword.TabIndex = 11;
            this.lblConfirmPassword.Text = "Nhập Lại Mật Khẩu:";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(372, 169);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(111, 18);
            this.lblNewPassword.TabIndex = 10;
            this.lblNewPassword.Text = "Mật Khẩu Mới:";
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPassword.Location = new System.Drawing.Point(372, 139);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(103, 18);
            this.lblOldPassword.TabIndex = 9;
            this.lblOldPassword.Text = "Mật Khẩu Cũ:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(372, 111);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(84, 18);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Tài Khoản:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(531, 197);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(200, 22);
            this.txtConfirmPassword.TabIndex = 7;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(531, 167);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(200, 22);
            this.txtNewPassword.TabIndex = 6;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(531, 137);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(200, 22);
            this.txtOldPassword.TabIndex = 5;
            this.txtOldPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(531, 107);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 22);
            this.txtUsername.TabIndex = 4;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Blue;
            this.labelTitle.Location = new System.Drawing.Point(18, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(339, 24);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "HỆ THỐNG QUẢN LÝ PHÒNG HỌC";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // tabPageCreateAccount
            // 
            this.tabPageCreateAccount.Location = new System.Drawing.Point(4, 25);
            this.tabPageCreateAccount.Name = "tabPageCreateAccount";
            this.tabPageCreateAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreateAccount.Size = new System.Drawing.Size(792, 421);
            this.tabPageCreateAccount.TabIndex = 0;
            this.tabPageCreateAccount.Text = "Tạo Tài Khoản";
            this.tabPageCreateAccount.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageCreateAccount);
            this.tabControl.Controls.Add(this.tabPageChangePassword);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 1;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GIL.Properties.Resources.z7359893045379_e1bad2a62df24426d627d9eba96a9ad31;
            this.pictureBox1.Location = new System.Drawing.Point(67, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DoiMatKhau_Load);
            this.Resize += new System.EventHandler(this.DoiMatKhau_Resize);
            this.tabPageChangePassword.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPageChangePassword;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label labelTitle;
        private TextBox txtUsername;
        private TextBox txtOldPassword;
        private TextBox txtNewPassword;
        private TextBox txtConfirmPassword;
        private Label lblUsername;
        private Label lblOldPassword;
        private Label lblNewPassword;
        private Label lblConfirmPassword;
        private CheckBox chkShowPassword;
        private Button btnReset;
        private Button btnAccept;
        private Label lblChangePassword;
        private TabPage tabPageCreateAccount;
        private TabControl tabControl;
    }
}
