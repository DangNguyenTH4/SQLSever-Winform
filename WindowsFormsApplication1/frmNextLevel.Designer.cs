namespace WindowsFormsApplication1
{
    partial class frmNextLevel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNextLevel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbhuongdan = new System.Windows.Forms.Label();
            this.btnbatdau = new System.Windows.Forms.Button();
            this.btntieptuc = new System.Windows.Forms.Button();
            this.lbthoigiantraloi = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbSocausai = new System.Windows.Forms.Label();
            this.lbSocauDung = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbhuongdan2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbhuongdan);
            this.panel1.Location = new System.Drawing.Point(0, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(36, 32);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            this.panel1.Enter += new System.EventHandler(this.panel1_Enter);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // lbhuongdan
            // 
            this.lbhuongdan.AutoSize = true;
            this.lbhuongdan.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhuongdan.Location = new System.Drawing.Point(3, 0);
            this.lbhuongdan.Name = "lbhuongdan";
            this.lbhuongdan.Size = new System.Drawing.Size(0, 19);
            this.lbhuongdan.TabIndex = 2;
            // 
            // btnbatdau
            // 
            this.btnbatdau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnbatdau.Font = new System.Drawing.Font("Curlz MT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbatdau.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnbatdau.Location = new System.Drawing.Point(82, 349);
            this.btnbatdau.Name = "btnbatdau";
            this.btnbatdau.Size = new System.Drawing.Size(283, 98);
            this.btnbatdau.TabIndex = 2;
            this.btnbatdau.Text = "Start";
            this.btnbatdau.UseVisualStyleBackColor = false;
            this.btnbatdau.Click += new System.EventHandler(this.btnbatdau_Click);
            // 
            // btntieptuc
            // 
            this.btntieptuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btntieptuc.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntieptuc.Location = new System.Drawing.Point(82, 365);
            this.btntieptuc.Name = "btntieptuc";
            this.btntieptuc.Size = new System.Drawing.Size(283, 82);
            this.btntieptuc.TabIndex = 0;
            this.btntieptuc.Text = "Next";
            this.btntieptuc.UseVisualStyleBackColor = false;
            this.btntieptuc.Visible = false;
            this.btntieptuc.Click += new System.EventHandler(this.btntieptuc_Click);
            // 
            // lbthoigiantraloi
            // 
            this.lbthoigiantraloi.AutoSize = true;
            this.lbthoigiantraloi.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbthoigiantraloi.ForeColor = System.Drawing.Color.Sienna;
            this.lbthoigiantraloi.Location = new System.Drawing.Point(447, 50);
            this.lbthoigiantraloi.Name = "lbthoigiantraloi";
            this.lbthoigiantraloi.Size = new System.Drawing.Size(45, 34);
            this.lbthoigiantraloi.TabIndex = 1;
            this.lbthoigiantraloi.Text = "10";
            this.lbthoigiantraloi.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbSocausai
            // 
            this.lbSocausai.AutoSize = true;
            this.lbSocausai.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSocausai.ForeColor = System.Drawing.Color.Sienna;
            this.lbSocausai.Location = new System.Drawing.Point(452, 203);
            this.lbSocausai.Name = "lbSocausai";
            this.lbSocausai.Size = new System.Drawing.Size(30, 34);
            this.lbSocausai.TabIndex = 1;
            this.lbSocausai.Text = "0";
            this.lbSocausai.Visible = false;
            // 
            // lbSocauDung
            // 
            this.lbSocauDung.AutoSize = true;
            this.lbSocauDung.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSocauDung.ForeColor = System.Drawing.Color.Sienna;
            this.lbSocauDung.Location = new System.Drawing.Point(450, 136);
            this.lbSocauDung.Name = "lbSocauDung";
            this.lbSocauDung.Size = new System.Drawing.Size(30, 34);
            this.lbSocauDung.TabIndex = 1;
            this.lbSocauDung.Text = "0";
            this.lbSocauDung.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(442, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "True";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(439, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "False";
            this.label2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Location = new System.Drawing.Point(444, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 1;
            this.label4.Tag = "";
            this.label4.Text = "Time";
            this.label4.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbhuongdan2
            // 
            this.lbhuongdan2.AutoSize = true;
            this.lbhuongdan2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbhuongdan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhuongdan2.ForeColor = System.Drawing.Color.Navy;
            this.lbhuongdan2.Location = new System.Drawing.Point(7, 13);
            this.lbhuongdan2.Name = "lbhuongdan2";
            this.lbhuongdan2.Size = new System.Drawing.Size(18, 26);
            this.lbhuongdan2.TabIndex = 3;
            this.lbhuongdan2.Text = " ";
            // 
            // frmNextLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(505, 450);
            this.Controls.Add(this.lbhuongdan2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnbatdau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btntieptuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSocauDung);
            this.Controls.Add(this.lbSocausai);
            this.Controls.Add(this.lbthoigiantraloi);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNextLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNextLevel";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmNextLevel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmNextLevel_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btntieptuc;
        private System.Windows.Forms.Label lbthoigiantraloi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbSocausai;
        private System.Windows.Forms.Label lbSocauDung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbatdau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbhuongdan;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbhuongdan2;
    }
}