namespace WindowsFormsApplication1
{
    partial class frmThemQA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemQA));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.txtFilenamePicture = new System.Windows.Forms.TextBox();
            this.txtExampleViet = new System.Windows.Forms.TextBox();
            this.txtExampleEng = new System.Windows.Forms.TextBox();
            this.txtTypeWord = new System.Windows.Forms.TextBox();
            this.txtVietWordPicture = new System.Windows.Forms.TextBox();
            this.txtEngWordPicture = new System.Windows.Forms.TextBox();
            this.txtFilenameSound = new System.Windows.Forms.TextBox();
            this.txtPronunciation = new System.Windows.Forms.TextBox();
            this.txtWordSound = new System.Windows.Forms.TextBox();
            this.btnChoosePicture = new System.Windows.Forms.Button();
            this.btnSaveToDatabase = new System.Windows.Forms.Button();
            this.btnChooseSound = new System.Windows.Forms.Button();
            this.cbboxSubject = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.lbCodeOfWord = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(177, 157);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(42, 33);
            this.axWindowsMediaPlayer1.TabIndex = 39;
            // 
            // txtFilenamePicture
            // 
            this.txtFilenamePicture.Location = new System.Drawing.Point(177, 506);
            this.txtFilenamePicture.Name = "txtFilenamePicture";
            this.txtFilenamePicture.Size = new System.Drawing.Size(219, 20);
            this.txtFilenamePicture.TabIndex = 37;
            // 
            // txtExampleViet
            // 
            this.txtExampleViet.Location = new System.Drawing.Point(177, 475);
            this.txtExampleViet.Name = "txtExampleViet";
            this.txtExampleViet.Size = new System.Drawing.Size(219, 20);
            this.txtExampleViet.TabIndex = 36;
            // 
            // txtExampleEng
            // 
            this.txtExampleEng.Location = new System.Drawing.Point(177, 440);
            this.txtExampleEng.Name = "txtExampleEng";
            this.txtExampleEng.Size = new System.Drawing.Size(219, 20);
            this.txtExampleEng.TabIndex = 35;
            // 
            // txtTypeWord
            // 
            this.txtTypeWord.Location = new System.Drawing.Point(177, 405);
            this.txtTypeWord.Name = "txtTypeWord";
            this.txtTypeWord.Size = new System.Drawing.Size(219, 20);
            this.txtTypeWord.TabIndex = 34;
            // 
            // txtVietWordPicture
            // 
            this.txtVietWordPicture.Location = new System.Drawing.Point(177, 368);
            this.txtVietWordPicture.Name = "txtVietWordPicture";
            this.txtVietWordPicture.Size = new System.Drawing.Size(219, 20);
            this.txtVietWordPicture.TabIndex = 33;
            // 
            // txtEngWordPicture
            // 
            this.txtEngWordPicture.Location = new System.Drawing.Point(177, 335);
            this.txtEngWordPicture.Name = "txtEngWordPicture";
            this.txtEngWordPicture.Size = new System.Drawing.Size(219, 20);
            this.txtEngWordPicture.TabIndex = 32;
            // 
            // txtFilenameSound
            // 
            this.txtFilenameSound.Location = new System.Drawing.Point(177, 233);
            this.txtFilenameSound.Name = "txtFilenameSound";
            this.txtFilenameSound.Size = new System.Drawing.Size(219, 20);
            this.txtFilenameSound.TabIndex = 31;
            // 
            // txtPronunciation
            // 
            this.txtPronunciation.Location = new System.Drawing.Point(177, 196);
            this.txtPronunciation.Name = "txtPronunciation";
            this.txtPronunciation.Size = new System.Drawing.Size(219, 20);
            this.txtPronunciation.TabIndex = 30;
            // 
            // txtWordSound
            // 
            this.txtWordSound.Location = new System.Drawing.Point(177, 119);
            this.txtWordSound.Name = "txtWordSound";
            this.txtWordSound.Size = new System.Drawing.Size(219, 20);
            this.txtWordSound.TabIndex = 27;
            // 
            // btnChoosePicture
            // 
            this.btnChoosePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnChoosePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoosePicture.Location = new System.Drawing.Point(30, 284);
            this.btnChoosePicture.Name = "btnChoosePicture";
            this.btnChoosePicture.Size = new System.Drawing.Size(157, 33);
            this.btnChoosePicture.TabIndex = 25;
            this.btnChoosePicture.Text = "Choose Picture";
            this.btnChoosePicture.UseVisualStyleBackColor = false;
            this.btnChoosePicture.Click += new System.EventHandler(this.btnChoosePicture_Click);
            // 
            // btnSaveToDatabase
            // 
            this.btnSaveToDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSaveToDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveToDatabase.Location = new System.Drawing.Point(476, 440);
            this.btnSaveToDatabase.Name = "btnSaveToDatabase";
            this.btnSaveToDatabase.Size = new System.Drawing.Size(102, 33);
            this.btnSaveToDatabase.TabIndex = 26;
            this.btnSaveToDatabase.Text = "Save";
            this.btnSaveToDatabase.UseVisualStyleBackColor = false;
            this.btnSaveToDatabase.Click += new System.EventHandler(this.btnSaveToDatabase_Click);
            // 
            // btnChooseSound
            // 
            this.btnChooseSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnChooseSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseSound.Location = new System.Drawing.Point(30, 72);
            this.btnChooseSound.Name = "btnChooseSound";
            this.btnChooseSound.Size = new System.Drawing.Size(157, 33);
            this.btnChooseSound.TabIndex = 23;
            this.btnChooseSound.Text = "Choose Sound";
            this.btnChooseSound.UseVisualStyleBackColor = false;
            this.btnChooseSound.Click += new System.EventHandler(this.btnChooseSound_Click);
            // 
            // cbboxSubject
            // 
            this.cbboxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbboxSubject.FormattingEnabled = true;
            this.cbboxSubject.Items.AddRange(new object[] {
            "Animal",
            "Clothes",
            "Flower",
            "Character",
            "Weather",
            "Color",
            "Vehicles",
            "Sports",
            "Job",
            "Family",
            "Nation "});
            this.cbboxSubject.Location = new System.Drawing.Point(476, 71);
            this.cbboxSubject.Name = "cbboxSubject";
            this.cbboxSubject.Size = new System.Drawing.Size(154, 24);
            this.cbboxSubject.TabIndex = 22;
            this.cbboxSubject.SelectedIndexChanged += new System.EventHandler(this.cbboxSubject_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 506);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Filename";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 475);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Example Viet";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 440);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Example Eng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "VietNamese Word";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "English Word";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Filename";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Pronunciation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sound";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Subject";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // lbCodeOfWord
            // 
            this.lbCodeOfWord.AutoSize = true;
            this.lbCodeOfWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodeOfWord.Location = new System.Drawing.Point(472, 335);
            this.lbCodeOfWord.Name = "lbCodeOfWord";
            this.lbCodeOfWord.Size = new System.Drawing.Size(102, 20);
            this.lbCodeOfWord.TabIndex = 9;
            this.lbCodeOfWord.Text = "CodeOfWord";
            // 
            // pic1
            // 
            this.pic1.Image = global::WindowsFormsApplication1.Properties.Resources.anh_dong_dep_thien_nhien_r3534;
            this.pic1.Location = new System.Drawing.Point(431, 118);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(203, 199);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 38;
            this.pic1.TabStop = false;
            // 
            // frmThemQA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 562);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.txtFilenamePicture);
            this.Controls.Add(this.txtExampleViet);
            this.Controls.Add(this.txtExampleEng);
            this.Controls.Add(this.txtTypeWord);
            this.Controls.Add(this.txtVietWordPicture);
            this.Controls.Add(this.txtEngWordPicture);
            this.Controls.Add(this.txtFilenameSound);
            this.Controls.Add(this.txtPronunciation);
            this.Controls.Add(this.txtWordSound);
            this.Controls.Add(this.btnChoosePicture);
            this.Controls.Add(this.btnSaveToDatabase);
            this.Controls.Add(this.btnChooseSound);
            this.Controls.Add(this.cbboxSubject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbCodeOfWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThemQA";
            this.Text = "frmThemQA";
            this.Load += new System.EventHandler(this.frmThemQA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.TextBox txtFilenamePicture;
        private System.Windows.Forms.TextBox txtExampleViet;
        private System.Windows.Forms.TextBox txtExampleEng;
        private System.Windows.Forms.TextBox txtTypeWord;
        private System.Windows.Forms.TextBox txtVietWordPicture;
        private System.Windows.Forms.TextBox txtEngWordPicture;
        private System.Windows.Forms.TextBox txtFilenameSound;
        private System.Windows.Forms.TextBox txtPronunciation;
        private System.Windows.Forms.TextBox txtWordSound;
        private System.Windows.Forms.Button btnChoosePicture;
        private System.Windows.Forms.Button btnSaveToDatabase;
        private System.Windows.Forms.Button btnChooseSound;
        private System.Windows.Forms.ComboBox cbboxSubject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Label lbCodeOfWord;
    }
}