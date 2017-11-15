namespace WindowsFormsApplication1
{
    partial class frmFornext3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFornext3));
            this.axA = new AxWMPLib.AxWindowsMediaPlayer();
            this.axB = new AxWMPLib.AxWindowsMediaPlayer();
            this.axC = new AxWMPLib.AxWindowsMediaPlayer();
            this.axD = new AxWMPLib.AxWindowsMediaPlayer();
            this.rdbA = new System.Windows.Forms.RadioButton();
            this.rdbB = new System.Windows.Forms.RadioButton();
            this.rdbC = new System.Windows.Forms.RadioButton();
            this.rdbD = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.axA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // axA
            // 
            this.axA.Enabled = true;
            this.axA.Location = new System.Drawing.Point(74, 263);
            this.axA.Name = "axA";
            this.axA.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axA.OcxState")));
            this.axA.Size = new System.Drawing.Size(38, 33);
            this.axA.TabIndex = 1;
            this.axA.Enter += new System.EventHandler(this.axA_Enter);
            // 
            // axB
            // 
            this.axB.Enabled = true;
            this.axB.Location = new System.Drawing.Point(158, 263);
            this.axB.Name = "axB";
            this.axB.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axB.OcxState")));
            this.axB.Size = new System.Drawing.Size(38, 33);
            this.axB.TabIndex = 1;
            this.axB.Enter += new System.EventHandler(this.axB_Enter);
            // 
            // axC
            // 
            this.axC.Enabled = true;
            this.axC.Location = new System.Drawing.Point(235, 263);
            this.axC.Name = "axC";
            this.axC.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axC.OcxState")));
            this.axC.Size = new System.Drawing.Size(38, 33);
            this.axC.TabIndex = 1;
            this.axC.Enter += new System.EventHandler(this.axC_Enter);
            // 
            // axD
            // 
            this.axD.Enabled = true;
            this.axD.Location = new System.Drawing.Point(313, 263);
            this.axD.Name = "axD";
            this.axD.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axD.OcxState")));
            this.axD.Size = new System.Drawing.Size(38, 33);
            this.axD.TabIndex = 1;
            this.axD.Enter += new System.EventHandler(this.axD_Enter);
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbA.Location = new System.Drawing.Point(77, 298);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(38, 24);
            this.rdbA.TabIndex = 2;
            this.rdbA.TabStop = true;
            this.rdbA.Text = "A";
            this.rdbA.UseVisualStyleBackColor = true;
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbB.Location = new System.Drawing.Point(163, 300);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(38, 24);
            this.rdbB.TabIndex = 2;
            this.rdbB.TabStop = true;
            this.rdbB.Text = "B";
            this.rdbB.UseVisualStyleBackColor = true;
            // 
            // rdbC
            // 
            this.rdbC.AutoSize = true;
            this.rdbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbC.Location = new System.Drawing.Point(238, 298);
            this.rdbC.Name = "rdbC";
            this.rdbC.Size = new System.Drawing.Size(38, 24);
            this.rdbC.TabIndex = 2;
            this.rdbC.TabStop = true;
            this.rdbC.Text = "C";
            this.rdbC.UseVisualStyleBackColor = true;
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbD.Location = new System.Drawing.Point(316, 299);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(39, 24);
            this.rdbD.TabIndex = 2;
            this.rdbD.TabStop = true;
            this.rdbD.Text = "D";
            this.rdbD.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(72, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmFornext3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(423, 342);
            this.Controls.Add(this.rdbD);
            this.Controls.Add(this.rdbC);
            this.Controls.Add(this.rdbB);
            this.Controls.Add(this.rdbA);
            this.Controls.Add(this.axD);
            this.Controls.Add(this.axC);
            this.Controls.Add(this.axB);
            this.Controls.Add(this.axA);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFornext3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmFornext3";
            this.Load += new System.EventHandler(this.frmFornext3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private AxWMPLib.AxWindowsMediaPlayer axA;
        private AxWMPLib.AxWindowsMediaPlayer axB;
        private AxWMPLib.AxWindowsMediaPlayer axC;
        private AxWMPLib.AxWindowsMediaPlayer axD;
        private System.Windows.Forms.RadioButton rdbA;
        private System.Windows.Forms.RadioButton rdbB;
        private System.Windows.Forms.RadioButton rdbC;
        private System.Windows.Forms.RadioButton rdbD;
    }
}