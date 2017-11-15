namespace WindowsFormsApplication1
{
    partial class Thi1
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
            this.picB = new System.Windows.Forms.PictureBox();
            this.picD = new System.Windows.Forms.PictureBox();
            this.picA = new System.Windows.Forms.PictureBox();
            this.picC = new System.Windows.Forms.PictureBox();
            this.lbYeuCau = new System.Windows.Forms.Label();
            this.lbword = new System.Windows.Forms.Label();
            this.rdbA = new System.Windows.Forms.RadioButton();
            this.rdbB = new System.Windows.Forms.RadioButton();
            this.rdbC = new System.Windows.Forms.RadioButton();
            this.rdbD = new System.Windows.Forms.RadioButton();
            this.btncheck = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbUIID = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC)).BeginInit();
            this.SuspendLayout();
            // 
            // picB
            // 
            this.picB.Location = new System.Drawing.Point(467, 148);
            this.picB.Name = "picB";
            this.picB.Size = new System.Drawing.Size(178, 176);
            this.picB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picB.TabIndex = 0;
            this.picB.TabStop = false;
            this.picB.Click += new System.EventHandler(this.picB_Click);
            // 
            // picD
            // 
            this.picD.Location = new System.Drawing.Point(467, 368);
            this.picD.Name = "picD";
            this.picD.Size = new System.Drawing.Size(178, 176);
            this.picD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picD.TabIndex = 0;
            this.picD.TabStop = false;
            this.picD.Click += new System.EventHandler(this.picD_Click);
            // 
            // picA
            // 
            this.picA.Location = new System.Drawing.Point(106, 148);
            this.picA.Name = "picA";
            this.picA.Size = new System.Drawing.Size(178, 176);
            this.picA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picA.TabIndex = 0;
            this.picA.TabStop = false;
            this.picA.Click += new System.EventHandler(this.picA_Click);
            // 
            // picC
            // 
            this.picC.Location = new System.Drawing.Point(106, 368);
            this.picC.Name = "picC";
            this.picC.Size = new System.Drawing.Size(178, 176);
            this.picC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picC.TabIndex = 0;
            this.picC.TabStop = false;
            this.picC.Click += new System.EventHandler(this.picC_Click);
            // 
            // lbYeuCau
            // 
            this.lbYeuCau.AutoSize = true;
            this.lbYeuCau.BackColor = System.Drawing.Color.Green;
            this.lbYeuCau.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYeuCau.Location = new System.Drawing.Point(102, 71);
            this.lbYeuCau.Name = "lbYeuCau";
            this.lbYeuCau.Size = new System.Drawing.Size(248, 21);
            this.lbYeuCau.TabIndex = 1;
            this.lbYeuCau.Text = "Choose Image for word : ";
            // 
            // lbword
            // 
            this.lbword.AutoSize = true;
            this.lbword.BackColor = System.Drawing.Color.Green;
            this.lbword.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbword.ForeColor = System.Drawing.Color.Red;
            this.lbword.Location = new System.Drawing.Point(356, 65);
            this.lbword.Name = "lbword";
            this.lbword.Size = new System.Drawing.Size(21, 31);
            this.lbword.TabIndex = 1;
            this.lbword.Text = " ";
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbA.Location = new System.Drawing.Point(169, 330);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(38, 26);
            this.rdbA.TabIndex = 2;
            this.rdbA.TabStop = true;
            this.rdbA.Text = "A";
            this.rdbA.UseVisualStyleBackColor = true;
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbB.Location = new System.Drawing.Point(538, 330);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(38, 26);
            this.rdbB.TabIndex = 3;
            this.rdbB.TabStop = true;
            this.rdbB.Text = "B";
            this.rdbB.UseVisualStyleBackColor = true;
            // 
            // rdbC
            // 
            this.rdbC.AutoSize = true;
            this.rdbC.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbC.Location = new System.Drawing.Point(169, 550);
            this.rdbC.Name = "rdbC";
            this.rdbC.Size = new System.Drawing.Size(38, 26);
            this.rdbC.TabIndex = 2;
            this.rdbC.TabStop = true;
            this.rdbC.Text = "C";
            this.rdbC.UseVisualStyleBackColor = true;
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbD.Location = new System.Drawing.Point(537, 548);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(38, 26);
            this.rdbD.TabIndex = 3;
            this.rdbD.TabStop = true;
            this.rdbD.Text = "D";
            this.rdbD.UseVisualStyleBackColor = true;
            // 
            // btncheck
            // 
            this.btncheck.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheck.Location = new System.Drawing.Point(257, 582);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(94, 30);
            this.btncheck.TabIndex = 4;
            this.btncheck.Text = "Check";
            this.btncheck.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(377, 582);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 30);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(497, 582);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(94, 30);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = " Choose Subject";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(284, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Green;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(534, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Account";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbUIID
            // 
            this.lbUIID.AutoSize = true;
            this.lbUIID.BackColor = System.Drawing.Color.Green;
            this.lbUIID.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUIID.Location = new System.Drawing.Point(632, 23);
            this.lbUIID.Name = "lbUIID";
            this.lbUIID.Size = new System.Drawing.Size(21, 21);
            this.lbUIID.TabIndex = 1;
            this.lbUIID.Text = "3";
            this.lbUIID.Click += new System.EventHandler(this.label6_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Thi1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 624);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.rdbD);
            this.Controls.Add(this.rdbB);
            this.Controls.Add(this.rdbC);
            this.Controls.Add(this.rdbA);
            this.Controls.Add(this.lbword);
            this.Controls.Add(this.lbUIID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbYeuCau);
            this.Controls.Add(this.picD);
            this.Controls.Add(this.picC);
            this.Controls.Add(this.picA);
            this.Controls.Add(this.picB);
            this.MaximizeBox = false;
            this.Name = "Thi1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Luyện tập";
            this.Load += new System.EventHandler(this.Thi1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picB;
        private System.Windows.Forms.PictureBox picD;
        private System.Windows.Forms.PictureBox picA;
        private System.Windows.Forms.PictureBox picC;
        private System.Windows.Forms.Label lbYeuCau;
        private System.Windows.Forms.Label lbword;
        private System.Windows.Forms.RadioButton rdbA;
        private System.Windows.Forms.RadioButton rdbB;
        private System.Windows.Forms.RadioButton rdbC;
        private System.Windows.Forms.RadioButton rdbD;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbUIID;
        private System.Windows.Forms.Timer timer1;
    }
}