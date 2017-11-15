namespace WindowsFormsApplication1
{
    partial class frmDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangKy));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cbxNgaysinh = new System.Windows.Forms.ComboBox();
            this.cbxThangSinh = new System.Windows.Forms.ComboBox();
            this.cbxnamsinh = new System.Windows.Forms.ComboBox();
            this.cbxgioitinh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.btndangky = new System.Windows.Forms.Button();
            this.lbmatkhaukhongKhop = new System.Windows.Forms.Label();
            this.lbtaikhoandatontai = new System.Windows.Forms.Label();
            this.btnDaCoTK = new System.Windows.Forms.Button();
            this.lbTrungSDT = new System.Windows.Forms.Label();
            this.lbTrungEmail = new System.Windows.Forms.Label();
            this.lbNgaySinhKhongHop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày sinh:";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ:";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới tính:";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số điện thoại:";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Email: ";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên đăng nhập:";
            this.label8.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mật khẩu:";
            this.label9.Click += new System.EventHandler(this.label2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Xác nhận mật khẩu:";
            this.label10.Click += new System.EventHandler(this.label2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(205, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(359, 43);
            this.label11.TabIndex = 0;
            this.label11.Text = "Đăng ký tài khoản";
            this.label11.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(249, 118);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(283, 26);
            this.txtTenDangNhap.TabIndex = 0;
            this.txtTenDangNhap.TextChanged += new System.EventHandler(this.txtTenDangNhap_TextChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(249, 156);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(283, 26);
            this.txtMatKhau.TabIndex = 1;
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(249, 198);
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.PasswordChar = '*';
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(283, 26);
            this.txtXacNhanMatKhau.TabIndex = 2;
            this.txtXacNhanMatKhau.TextChanged += new System.EventHandler(this.txtXacNhanMatKhau_TextChanged);
            this.txtXacNhanMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtXacNhanMatKhau_KeyDown);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(249, 238);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(283, 26);
            this.txtHoTen.TabIndex = 3;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(249, 367);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(283, 26);
            this.txtDiaChi.TabIndex = 8;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(249, 402);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(283, 26);
            this.txtSoDienThoai.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(249, 439);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(283, 26);
            this.txtEmail.TabIndex = 10;
            // 
            // cbxNgaysinh
            // 
            this.cbxNgaysinh.FormattingEnabled = true;
            this.cbxNgaysinh.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbxNgaysinh.Location = new System.Drawing.Point(249, 283);
            this.cbxNgaysinh.Name = "cbxNgaysinh";
            this.cbxNgaysinh.Size = new System.Drawing.Size(45, 21);
            this.cbxNgaysinh.TabIndex = 4;
            this.cbxNgaysinh.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbxThangSinh
            // 
            this.cbxThangSinh.FormattingEnabled = true;
            this.cbxThangSinh.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbxThangSinh.Location = new System.Drawing.Point(320, 283);
            this.cbxThangSinh.Name = "cbxThangSinh";
            this.cbxThangSinh.Size = new System.Drawing.Size(42, 21);
            this.cbxThangSinh.TabIndex = 5;
            // 
            // cbxnamsinh
            // 
            this.cbxnamsinh.FormattingEnabled = true;
            this.cbxnamsinh.Items.AddRange(new object[] {
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007"});
            this.cbxnamsinh.Location = new System.Drawing.Point(404, 283);
            this.cbxnamsinh.Name = "cbxnamsinh";
            this.cbxnamsinh.Size = new System.Drawing.Size(67, 21);
            this.cbxnamsinh.TabIndex = 6;
            // 
            // cbxgioitinh
            // 
            this.cbxgioitinh.FormattingEnabled = true;
            this.cbxgioitinh.Items.AddRange(new object[] {
            "Nữ",
            "Nam"});
            this.cbxgioitinh.Location = new System.Drawing.Point(249, 326);
            this.cbxgioitinh.Name = "cbxgioitinh";
            this.cbxgioitinh.Size = new System.Drawing.Size(45, 21);
            this.cbxgioitinh.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "/";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(383, 281);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 24);
            this.label12.TabIndex = 3;
            this.label12.Text = "/";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // btndangky
            // 
            this.btndangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangky.Location = new System.Drawing.Point(249, 488);
            this.btndangky.Name = "btndangky";
            this.btndangky.Size = new System.Drawing.Size(120, 40);
            this.btndangky.TabIndex = 11;
            this.btndangky.Text = "Đăng ký";
            this.btndangky.UseVisualStyleBackColor = true;
            this.btndangky.Click += new System.EventHandler(this.btndangky_Click);
            // 
            // lbmatkhaukhongKhop
            // 
            this.lbmatkhaukhongKhop.AutoSize = true;
            this.lbmatkhaukhongKhop.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmatkhaukhongKhop.Location = new System.Drawing.Point(539, 205);
            this.lbmatkhaukhongKhop.Name = "lbmatkhaukhongKhop";
            this.lbmatkhaukhongKhop.Size = new System.Drawing.Size(140, 15);
            this.lbmatkhaukhongKhop.TabIndex = 12;
            this.lbmatkhaukhongKhop.Text = "Không khớp mật khẩu";
            this.lbmatkhaukhongKhop.Visible = false;
            // 
            // lbtaikhoandatontai
            // 
            this.lbtaikhoandatontai.AutoSize = true;
            this.lbtaikhoandatontai.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtaikhoandatontai.Location = new System.Drawing.Point(539, 122);
            this.lbtaikhoandatontai.Name = "lbtaikhoandatontai";
            this.lbtaikhoandatontai.Size = new System.Drawing.Size(147, 15);
            this.lbtaikhoandatontai.TabIndex = 12;
            this.lbtaikhoandatontai.Text = "Tài khoản đã tồn tại";
            this.lbtaikhoandatontai.Visible = false;
            // 
            // btnDaCoTK
            // 
            this.btnDaCoTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaCoTK.Location = new System.Drawing.Point(396, 488);
            this.btnDaCoTK.Name = "btnDaCoTK";
            this.btnDaCoTK.Size = new System.Drawing.Size(136, 40);
            this.btnDaCoTK.TabIndex = 13;
            this.btnDaCoTK.Text = "Đã có tài khoản";
            this.btnDaCoTK.UseVisualStyleBackColor = true;
            // 
            // lbTrungSDT
            // 
            this.lbTrungSDT.AutoSize = true;
            this.lbTrungSDT.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrungSDT.Location = new System.Drawing.Point(538, 409);
            this.lbTrungSDT.Name = "lbTrungSDT";
            this.lbTrungSDT.Size = new System.Drawing.Size(210, 15);
            this.lbTrungSDT.TabIndex = 12;
            this.lbTrungSDT.Text = "Số điện thoại đã được sử dụng";
            this.lbTrungSDT.Visible = false;
            // 
            // lbTrungEmail
            // 
            this.lbTrungEmail.AutoSize = true;
            this.lbTrungEmail.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrungEmail.Location = new System.Drawing.Point(538, 445);
            this.lbTrungEmail.Name = "lbTrungEmail";
            this.lbTrungEmail.Size = new System.Drawing.Size(154, 15);
            this.lbTrungEmail.TabIndex = 12;
            this.lbTrungEmail.Text = "Email đã được sử dụng";
            this.lbTrungEmail.Visible = false;
            // 
            // lbNgaySinhKhongHop
            // 
            this.lbNgaySinhKhongHop.AutoSize = true;
            this.lbNgaySinhKhongHop.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinhKhongHop.Location = new System.Drawing.Point(539, 289);
            this.lbNgaySinhKhongHop.Name = "lbNgaySinhKhongHop";
            this.lbNgaySinhKhongHop.Size = new System.Drawing.Size(161, 15);
            this.lbNgaySinhKhongHop.TabIndex = 12;
            this.lbNgaySinhKhongHop.Text = "Ngày sinh không hợp lệ";
            this.lbNgaySinhKhongHop.Visible = false;
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 592);
            this.Controls.Add(this.btnDaCoTK);
            this.Controls.Add(this.lbtaikhoandatontai);
            this.Controls.Add(this.lbTrungEmail);
            this.Controls.Add(this.lbTrungSDT);
            this.Controls.Add(this.lbNgaySinhKhongHop);
            this.Controls.Add(this.lbmatkhaukhongKhop);
            this.Controls.Add(this.btndangky);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxnamsinh);
            this.Controls.Add(this.cbxThangSinh);
            this.Controls.Add(this.cbxgioitinh);
            this.Controls.Add(this.cbxNgaysinh);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtXacNhanMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDangKy";
            this.Text = "frmDangKy";
            this.Load += new System.EventHandler(this.frmDangKy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtXacNhanMatKhau;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cbxNgaysinh;
        private System.Windows.Forms.ComboBox cbxThangSinh;
        private System.Windows.Forms.ComboBox cbxnamsinh;
        private System.Windows.Forms.ComboBox cbxgioitinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button btndangky;
        private System.Windows.Forms.Label lbmatkhaukhongKhop;
        private System.Windows.Forms.Label lbtaikhoandatontai;
        private System.Windows.Forms.Button btnDaCoTK;
        private System.Windows.Forms.Label lbTrungSDT;
        private System.Windows.Forms.Label lbTrungEmail;
        private System.Windows.Forms.Label lbNgaySinhKhongHop;
    }
}