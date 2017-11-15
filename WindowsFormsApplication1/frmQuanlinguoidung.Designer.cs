namespace WindowsFormsApplication1
{
    partial class frmQuanlinguoidung
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
            this.btntaikhoannguoidung = new System.Windows.Forms.Button();
            this.btnBXHToanCuc = new System.Windows.Forms.Button();
            this.btnTangCapDoVuotTroi = new System.Windows.Forms.Button();
            this.btnQuaTrinhThangCap = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnTrove = new System.Windows.Forms.Button();
            this.lstV = new System.Windows.Forms.ListView();
            this.uiid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.acc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGridQuaTrinhTangCap = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridNguoiDungKhongLenCap = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuaTrinhTangCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNguoiDungKhongLenCap)).BeginInit();
            this.SuspendLayout();
            // 
            // btntaikhoannguoidung
            // 
            this.btntaikhoannguoidung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btntaikhoannguoidung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntaikhoannguoidung.Location = new System.Drawing.Point(189, 92);
            this.btntaikhoannguoidung.Name = "btntaikhoannguoidung";
            this.btntaikhoannguoidung.Size = new System.Drawing.Size(297, 38);
            this.btntaikhoannguoidung.TabIndex = 0;
            this.btntaikhoannguoidung.Text = "Tài khoản người dùng";
            this.btntaikhoannguoidung.UseVisualStyleBackColor = false;
            this.btntaikhoannguoidung.Click += new System.EventHandler(this.btntaikhoannguoidung_Click);
            // 
            // btnBXHToanCuc
            // 
            this.btnBXHToanCuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBXHToanCuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBXHToanCuc.Location = new System.Drawing.Point(189, 185);
            this.btnBXHToanCuc.Name = "btnBXHToanCuc";
            this.btnBXHToanCuc.Size = new System.Drawing.Size(297, 37);
            this.btnBXHToanCuc.TabIndex = 0;
            this.btnBXHToanCuc.Text = "Bảng xếp hạng toàn cục";
            this.btnBXHToanCuc.UseVisualStyleBackColor = false;
            this.btnBXHToanCuc.Click += new System.EventHandler(this.btnBXHToanCuc_Click);
            // 
            // btnTangCapDoVuotTroi
            // 
            this.btnTangCapDoVuotTroi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTangCapDoVuotTroi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTangCapDoVuotTroi.Location = new System.Drawing.Point(189, 232);
            this.btnTangCapDoVuotTroi.Name = "btnTangCapDoVuotTroi";
            this.btnTangCapDoVuotTroi.Size = new System.Drawing.Size(297, 37);
            this.btnTangCapDoVuotTroi.TabIndex = 0;
            this.btnTangCapDoVuotTroi.Text = "Tăng cấp độ vượt trội";
            this.btnTangCapDoVuotTroi.UseVisualStyleBackColor = false;
            this.btnTangCapDoVuotTroi.Click += new System.EventHandler(this.btnTangCapDoVuotTroi_Click);
            // 
            // btnQuaTrinhThangCap
            // 
            this.btnQuaTrinhThangCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnQuaTrinhThangCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuaTrinhThangCap.Location = new System.Drawing.Point(189, 139);
            this.btnQuaTrinhThangCap.Name = "btnQuaTrinhThangCap";
            this.btnQuaTrinhThangCap.Size = new System.Drawing.Size(297, 37);
            this.btnQuaTrinhThangCap.TabIndex = 0;
            this.btnQuaTrinhThangCap.Text = "Quá trình thăng cấp người dùng";
            this.btnQuaTrinhThangCap.UseVisualStyleBackColor = false;
            this.btnQuaTrinhThangCap.Click += new System.EventHandler(this.btnQuaTrinhThangCap_Click);
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Location = new System.Drawing.Point(417, 38);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(85, 30);
            this.btnXem.TabIndex = 1;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Visible = false;
            this.btnXem.Click += new System.EventHandler(this.Xem_Click);
            // 
            // btnTrove
            // 
            this.btnTrove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTrove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrove.Location = new System.Drawing.Point(105, 465);
            this.btnTrove.Name = "btnTrove";
            this.btnTrove.Size = new System.Drawing.Size(130, 33);
            this.btnTrove.TabIndex = 1;
            this.btnTrove.Text = "Trở về";
            this.btnTrove.UseVisualStyleBackColor = false;
            this.btnTrove.Visible = false;
            this.btnTrove.Click += new System.EventHandler(this.btnTrove_Click);
            // 
            // lstV
            // 
            this.lstV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.uiid,
            this.acc});
            this.lstV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstV.Location = new System.Drawing.Point(105, 402);
            this.lstV.Name = "lstV";
            this.lstV.Size = new System.Drawing.Size(90, 97);
            this.lstV.TabIndex = 2;
            this.lstV.UseCompatibleStateImageBehavior = false;
            this.lstV.View = System.Windows.Forms.View.Details;
            this.lstV.Visible = false;
            // 
            // uiid
            // 
            this.uiid.Text = "UIID";
            this.uiid.Width = 73;
            // 
            // acc
            // 
            this.acc.Text = "Account";
            this.acc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.acc.Width = 647;
            // 
            // dataGridQuaTrinhTangCap
            // 
            this.dataGridQuaTrinhTangCap.AllowUserToAddRows = false;
            this.dataGridQuaTrinhTangCap.AllowUserToDeleteRows = false;
            this.dataGridQuaTrinhTangCap.BackgroundColor = System.Drawing.Color.White;
            this.dataGridQuaTrinhTangCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQuaTrinhTangCap.Location = new System.Drawing.Point(610, 402);
            this.dataGridQuaTrinhTangCap.Name = "dataGridQuaTrinhTangCap";
            this.dataGridQuaTrinhTangCap.ReadOnly = true;
            this.dataGridQuaTrinhTangCap.Size = new System.Drawing.Size(98, 111);
            this.dataGridQuaTrinhTangCap.TabIndex = 3;
            this.dataGridQuaTrinhTangCap.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(558, 407);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(107, 106);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Những người tăng được nhiều hơn 2 cấp độ trong những tháng gần đây.";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhập số tháng gần đây : ";
            this.label2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(243, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 30);
            this.textBox1.TabIndex = 6;
            this.textBox1.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 386);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(131, 127);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(189, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Người dùng không lên cấp";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridNguoiDungKhongLenCap
            // 
            this.dataGridNguoiDungKhongLenCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNguoiDungKhongLenCap.Location = new System.Drawing.Point(350, 357);
            this.dataGridNguoiDungKhongLenCap.Name = "dataGridNguoiDungKhongLenCap";
            this.dataGridNguoiDungKhongLenCap.Size = new System.Drawing.Size(240, 150);
            this.dataGridNguoiDungKhongLenCap.TabIndex = 9;
            this.dataGridNguoiDungKhongLenCap.Visible = false;
            // 
            // frmQuanlinguoidung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 511);
            this.Controls.Add(this.dataGridNguoiDungKhongLenCap);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridQuaTrinhTangCap);
            this.Controls.Add(this.lstV);
            this.Controls.Add(this.btnTrove);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnQuaTrinhThangCap);
            this.Controls.Add(this.btnTangCapDoVuotTroi);
            this.Controls.Add(this.btnBXHToanCuc);
            this.Controls.Add(this.btntaikhoannguoidung);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanlinguoidung";
            this.Text = "frmQuanlinguoidung";
            this.Load += new System.EventHandler(this.frmQuanlinguoidung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuaTrinhTangCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNguoiDungKhongLenCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntaikhoannguoidung;
        private System.Windows.Forms.Button btnBXHToanCuc;
        private System.Windows.Forms.Button btnTangCapDoVuotTroi;
        private System.Windows.Forms.Button btnQuaTrinhThangCap;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ListView lstV;
        private System.Windows.Forms.ColumnHeader uiid;
        private System.Windows.Forms.ColumnHeader acc;
        private System.Windows.Forms.DataGridView dataGridQuaTrinhTangCap;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        internal System.Windows.Forms.Button btnTrove;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridNguoiDungKhongLenCap;
    }
}