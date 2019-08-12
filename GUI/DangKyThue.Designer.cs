namespace QLNT.GUI
{
    partial class DangKyThue
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvKhachDangThue = new System.Windows.Forms.DataGridView();
            this.dgvPhongCoKhach = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvKhachChuaCoPhong = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbbPhongMoi = new System.Windows.Forms.ComboBox();
            this.cbbPhongGhep = new System.Windows.Forms.ComboBox();
            this.rbtGhep = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.rbtPhongMoi = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.butThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachDangThue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongCoKhach)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachChuaCoPhong)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Menu;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(332, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "ĐĂNG KÝ THUÊ PHÒNG";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgvKhachDangThue);
            this.panel1.Controls.Add(this.dgvPhongCoKhach);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(26, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 253);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvKhachDangThue
            // 
            this.dgvKhachDangThue.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvKhachDangThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachDangThue.Location = new System.Drawing.Point(425, 67);
            this.dgvKhachDangThue.Name = "dgvKhachDangThue";
            this.dgvKhachDangThue.Size = new System.Drawing.Size(420, 150);
            this.dgvKhachDangThue.TabIndex = 2;
            // 
            // dgvPhongCoKhach
            // 
            this.dgvPhongCoKhach.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPhongCoKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongCoKhach.Location = new System.Drawing.Point(19, 67);
            this.dgvPhongCoKhach.Name = "dgvPhongCoKhach";
            this.dgvPhongCoKhach.Size = new System.Drawing.Size(362, 150);
            this.dgvPhongCoKhach.TabIndex = 1;
            this.dgvPhongCoKhach.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPhongCoKhach_RowHeaderMouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(422, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Danh sách khách đang thuê";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phòng có khách thuê";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dgvKhachChuaCoPhong);
            this.panel2.Location = new System.Drawing.Point(26, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 170);
            this.panel2.TabIndex = 3;
            // 
            // dgvKhachChuaCoPhong
            // 
            this.dgvKhachChuaCoPhong.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvKhachChuaCoPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachChuaCoPhong.Location = new System.Drawing.Point(19, 17);
            this.dgvKhachChuaCoPhong.Name = "dgvKhachChuaCoPhong";
            this.dgvKhachChuaCoPhong.Size = new System.Drawing.Size(443, 133);
            this.dgvKhachChuaCoPhong.TabIndex = 0;
            this.dgvKhachChuaCoPhong.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvKhachChuaCoPhong_RowHeaderMouseClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cbbPhongMoi);
            this.panel3.Controls.Add(this.cbbPhongGhep);
            this.panel3.Controls.Add(this.rbtGhep);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.rbtPhongMoi);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(602, 353);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 169);
            this.panel3.TabIndex = 4;
            // 
            // cbbPhongMoi
            // 
            this.cbbPhongMoi.FormattingEnabled = true;
            this.cbbPhongMoi.Location = new System.Drawing.Point(228, 39);
            this.cbbPhongMoi.Name = "cbbPhongMoi";
            this.cbbPhongMoi.Size = new System.Drawing.Size(121, 21);
            this.cbbPhongMoi.TabIndex = 4;
            // 
            // cbbPhongGhep
            // 
            this.cbbPhongGhep.FormattingEnabled = true;
            this.cbbPhongGhep.Location = new System.Drawing.Point(228, 105);
            this.cbbPhongGhep.Name = "cbbPhongGhep";
            this.cbbPhongGhep.Size = new System.Drawing.Size(121, 21);
            this.cbbPhongGhep.TabIndex = 3;
            // 
            // rbtGhep
            // 
            this.rbtGhep.AutoSize = true;
            this.rbtGhep.Location = new System.Drawing.Point(6, 105);
            this.rbtGhep.Name = "rbtGhep";
            this.rbtGhep.Size = new System.Drawing.Size(92, 17);
            this.rbtGhep.TabIndex = 2;
            this.rbtGhep.TabStop = true;
            this.rbtGhep.Text = "Khách ở ghép";
            this.rbtGhep.UseVisualStyleBackColor = true;
            this.rbtGhep.CheckedChanged += new System.EventHandler(this.rbtGhep_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(225, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Phòng mới";
            // 
            // rbtPhongMoi
            // 
            this.rbtPhongMoi.AutoSize = true;
            this.rbtPhongMoi.Location = new System.Drawing.Point(6, 43);
            this.rbtPhongMoi.Name = "rbtPhongMoi";
            this.rbtPhongMoi.Size = new System.Drawing.Size(117, 17);
            this.rbtPhongMoi.TabIndex = 1;
            this.rbtPhongMoi.TabStop = true;
            this.rbtPhongMoi.Text = "Khách ở phòng mới";
            this.rbtPhongMoi.UseVisualStyleBackColor = true;
            this.rbtPhongMoi.CheckedChanged += new System.EventHandler(this.rbtPhongMoi_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(225, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Phòng ở ghép";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kiểu";
            // 
            // butThem
            // 
            this.butThem.BackgroundImage = global::QLNT.Properties.Resources.add_user11;
            this.butThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butThem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.butThem.Location = new System.Drawing.Point(510, 545);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(107, 27);
            this.butThem.TabIndex = 5;
            this.butThem.Text = "Thêm Khách";
            this.butThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butThem.UseVisualStyleBackColor = true;
            this.butThem.Click += new System.EventHandler(this.butThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Firebrick;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(23, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Danh Sách Khách Thuê ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Firebrick;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(29, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(224, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Danh Sách Khách Chưa Có Phòng";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(599, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Thêm Khách Thuê";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(937, 545);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DangKyThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLNT.Properties.Resources.images__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 593);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butThem);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "DangKyThue";
            this.Text = "DangKyThue";
            this.Load += new System.EventHandler(this.DangKyThue_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachDangThue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongCoKhach)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachChuaCoPhong)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvKhachDangThue;
        private System.Windows.Forms.DataGridView dgvPhongCoKhach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvKhachChuaCoPhong;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbbPhongMoi;
        private System.Windows.Forms.ComboBox cbbPhongGhep;
        private System.Windows.Forms.RadioButton rbtGhep;
        private System.Windows.Forms.RadioButton rbtPhongMoi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button butThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}