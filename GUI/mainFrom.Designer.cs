namespace QLNT
{
    partial class Form1
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.khachthueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phongtroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýThuêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoadonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bangiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giáPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giáDịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongtinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangnhapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menu.BackgroundImage = global::QLNT.Properties.Resources.istockphoto_692641848_612x612;
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khachthueToolStripMenuItem,
            this.phongtroToolStripMenuItem,
            this.hoadonToolStripMenuItem,
            this.bangiaToolStripMenuItem,
            this.thongkeToolStripMenuItem,
            this.thongtinToolStripMenuItem,
            this.dangnhapToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(123, 9);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(855, 27);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // khachthueToolStripMenuItem
            // 
            this.khachthueToolStripMenuItem.Image = global::QLNT.Properties.Resources.user_group_icon;
            this.khachthueToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.khachthueToolStripMenuItem.Name = "khachthueToolStripMenuItem";
            this.khachthueToolStripMenuItem.Size = new System.Drawing.Size(113, 23);
            this.khachthueToolStripMenuItem.Text = "Khách Thuê";
            this.khachthueToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.khachthueToolStripMenuItem.Click += new System.EventHandler(this.khachthueToolStripMenuItem_Click);
            // 
            // phongtroToolStripMenuItem
            // 
            this.phongtroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem,
            this.đăngKýThuêToolStripMenuItem});
            this.phongtroToolStripMenuItem.Image = global::QLNT.Properties.Resources.motel;
            this.phongtroToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.phongtroToolStripMenuItem.Name = "phongtroToolStripMenuItem";
            this.phongtroToolStripMenuItem.Size = new System.Drawing.Size(106, 23);
            this.phongtroToolStripMenuItem.Text = "Phòng Trọ";
            this.phongtroToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.thôngTinToolStripMenuItem.Text = "Thông Tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // đăngKýThuêToolStripMenuItem
            // 
            this.đăngKýThuêToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.đăngKýThuêToolStripMenuItem.Name = "đăngKýThuêToolStripMenuItem";
            this.đăngKýThuêToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.đăngKýThuêToolStripMenuItem.Text = "Đăng Ký Thuê";
            this.đăngKýThuêToolStripMenuItem.Click += new System.EventHandler(this.đăngKýThuêToolStripMenuItem_Click);
            // 
            // hoadonToolStripMenuItem
            // 
            this.hoadonToolStripMenuItem.Image = global::QLNT.Properties.Resources.Money_32;
            this.hoadonToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hoadonToolStripMenuItem.Name = "hoadonToolStripMenuItem";
            this.hoadonToolStripMenuItem.Size = new System.Drawing.Size(96, 23);
            this.hoadonToolStripMenuItem.Text = "Hóa Đơn";
            this.hoadonToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hoadonToolStripMenuItem.Click += new System.EventHandler(this.hoadonToolStripMenuItem_Click);
            // 
            // bangiaToolStripMenuItem
            // 
            this.bangiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giáPhòngToolStripMenuItem,
            this.giáDịchVụToolStripMenuItem});
            this.bangiaToolStripMenuItem.Image = global::QLNT.Properties.Resources.order_1;
            this.bangiaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bangiaToolStripMenuItem.Name = "bangiaToolStripMenuItem";
            this.bangiaToolStripMenuItem.Size = new System.Drawing.Size(97, 23);
            this.bangiaToolStripMenuItem.Text = "Bảng Giá";
            this.bangiaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bangiaToolStripMenuItem.Click += new System.EventHandler(this.bangiaToolStripMenuItem_Click);
            // 
            // giáPhòngToolStripMenuItem
            // 
            this.giáPhòngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giáPhòngToolStripMenuItem.Name = "giáPhòngToolStripMenuItem";
            this.giáPhòngToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.giáPhòngToolStripMenuItem.Text = "Giá Phòng";
            this.giáPhòngToolStripMenuItem.Click += new System.EventHandler(this.giáPhòngToolStripMenuItem_Click);
            // 
            // giáDịchVụToolStripMenuItem
            // 
            this.giáDịchVụToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giáDịchVụToolStripMenuItem.Name = "giáDịchVụToolStripMenuItem";
            this.giáDịchVụToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.giáDịchVụToolStripMenuItem.Text = "Giá Dịch Vụ";
            // 
            // thongkeToolStripMenuItem
            // 
            this.thongkeToolStripMenuItem.Image = global::QLNT.Properties.Resources.e24f1be346a;
            this.thongkeToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.thongkeToolStripMenuItem.Name = "thongkeToolStripMenuItem";
            this.thongkeToolStripMenuItem.Size = new System.Drawing.Size(100, 23);
            this.thongkeToolStripMenuItem.Text = "Thống Kê";
            this.thongkeToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // thongtinToolStripMenuItem
            // 
            this.thongtinToolStripMenuItem.Image = global::QLNT.Properties.Resources.information;
            this.thongtinToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.thongtinToolStripMenuItem.Name = "thongtinToolStripMenuItem";
            this.thongtinToolStripMenuItem.Size = new System.Drawing.Size(103, 23);
            this.thongtinToolStripMenuItem.Text = "Thông Tin";
            this.thongtinToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dangnhapToolStripMenuItem
            // 
            this.dangnhapToolStripMenuItem.Image = global::QLNT.Properties.Resources.Login;
            this.dangnhapToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dangnhapToolStripMenuItem.Name = "dangnhapToolStripMenuItem";
            this.dangnhapToolStripMenuItem.Size = new System.Drawing.Size(112, 23);
            this.dangnhapToolStripMenuItem.Text = "Đăng Nhập";
            this.dangnhapToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dangnhapToolStripMenuItem.Click += new System.EventHandler(this.dangnhapToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLNT.Properties.Resources.images__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1021, 516);
            this.Controls.Add(this.menu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "mainFrom";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem khachthueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phongtroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hoadonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bangiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongtinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangnhapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giáPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giáDịchVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKýThuêToolStripMenuItem;
    }
}