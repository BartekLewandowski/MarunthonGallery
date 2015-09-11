namespace GalleryUploader
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnUpload = new System.Windows.Forms.Button();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.groupBoxEvent = new System.Windows.Forms.GroupBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxGallery = new System.Windows.Forms.GroupBox();
            this.txtGalName = new System.Windows.Forms.TextBox();
            this.groupBoxImages = new System.Windows.Forms.GroupBox();
            this.chkRotate = new System.Windows.Forms.CheckBox();
            this.txtImgPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.pbUpload = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxLogin.SuspendLayout();
            this.groupBoxEvent.SuspendLayout();
            this.groupBoxGallery.SuspendLayout();
            this.groupBoxImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login (email)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(100, 25);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(150, 20);
            this.txtLogin.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(256, 50);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "OK";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Enter gallery name";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(255, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(246, 355);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(143, 23);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "Upload images now";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.txtPass);
            this.groupBoxLogin.Controls.Add(this.txtLogin);
            this.groupBoxLogin.Controls.Add(this.label1);
            this.groupBoxLogin.Controls.Add(this.label2);
            this.groupBoxLogin.Controls.Add(this.btnLogin);
            this.groupBoxLogin.Location = new System.Drawing.Point(12, 70);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(377, 79);
            this.groupBoxLogin.TabIndex = 0;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Log into Marunthon.com account";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(100, 52);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(150, 20);
            this.txtPass.TabIndex = 1;
            // 
            // groupBoxEvent
            // 
            this.groupBoxEvent.Controls.Add(this.lblCity);
            this.groupBoxEvent.Controls.Add(this.lblName);
            this.groupBoxEvent.Controls.Add(this.label5);
            this.groupBoxEvent.Controls.Add(this.btnSearch);
            this.groupBoxEvent.Location = new System.Drawing.Point(13, 150);
            this.groupBoxEvent.Name = "groupBoxEvent";
            this.groupBoxEvent.Size = new System.Drawing.Size(376, 71);
            this.groupBoxEvent.TabIndex = 1;
            this.groupBoxEvent.TabStop = false;
            this.groupBoxEvent.Text = "Find event";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCity.Location = new System.Drawing.Point(18, 53);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 13);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "label6";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(18, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Select event to add gallery.";
            // 
            // groupBoxGallery
            // 
            this.groupBoxGallery.Controls.Add(this.txtGalName);
            this.groupBoxGallery.Controls.Add(this.label4);
            this.groupBoxGallery.Location = new System.Drawing.Point(12, 222);
            this.groupBoxGallery.Name = "groupBoxGallery";
            this.groupBoxGallery.Size = new System.Drawing.Size(377, 53);
            this.groupBoxGallery.TabIndex = 2;
            this.groupBoxGallery.TabStop = false;
            this.groupBoxGallery.Text = "Gallery";
            // 
            // txtGalName
            // 
            this.txtGalName.Location = new System.Drawing.Point(114, 21);
            this.txtGalName.Name = "txtGalName";
            this.txtGalName.Size = new System.Drawing.Size(217, 20);
            this.txtGalName.TabIndex = 2;
            // 
            // groupBoxImages
            // 
            this.groupBoxImages.Controls.Add(this.chkRotate);
            this.groupBoxImages.Controls.Add(this.txtImgPath);
            this.groupBoxImages.Controls.Add(this.label3);
            this.groupBoxImages.Controls.Add(this.button3);
            this.groupBoxImages.Location = new System.Drawing.Point(13, 276);
            this.groupBoxImages.Name = "groupBoxImages";
            this.groupBoxImages.Size = new System.Drawing.Size(376, 73);
            this.groupBoxImages.TabIndex = 3;
            this.groupBoxImages.TabStop = false;
            this.groupBoxImages.Text = "Images";
            // 
            // chkRotate
            // 
            this.chkRotate.AutoSize = true;
            this.chkRotate.Checked = true;
            this.chkRotate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRotate.Location = new System.Drawing.Point(18, 48);
            this.chkRotate.Name = "chkRotate";
            this.chkRotate.Size = new System.Drawing.Size(202, 17);
            this.chkRotate.TabIndex = 6;
            this.chkRotate.Text = "auto-rotate (use EXIF info if avaliable)";
            this.chkRotate.UseVisualStyleBackColor = true;
            // 
            // txtImgPath
            // 
            this.txtImgPath.Location = new System.Drawing.Point(145, 19);
            this.txtImgPath.Name = "txtImgPath";
            this.txtImgPath.ReadOnly = true;
            this.txtImgPath.Size = new System.Drawing.Size(185, 20);
            this.txtImgPath.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select folder with images";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(256, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Select";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnSelFolder_Click);
            // 
            // lbLog
            // 
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(12, 386);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(380, 160);
            this.lbLog.TabIndex = 5;
            // 
            // pbUpload
            // 
            this.pbUpload.Location = new System.Drawing.Point(12, 547);
            this.pbUpload.Name = "pbUpload";
            this.pbUpload.Size = new System.Drawing.Size(380, 11);
            this.pbUpload.Step = 1;
            this.pbUpload.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GalleryUploader.Properties.Resources.marunthon;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 59);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbUpload);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.groupBoxImages);
            this.Controls.Add(this.groupBoxGallery);
            this.Controls.Add(this.groupBoxEvent);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.btnUpload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Marunthon.com - gallery uploader (v 1.0)";
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.groupBoxEvent.ResumeLayout(false);
            this.groupBoxEvent.PerformLayout();
            this.groupBoxGallery.ResumeLayout(false);
            this.groupBoxGallery.PerformLayout();
            this.groupBoxImages.ResumeLayout(false);
            this.groupBoxImages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.GroupBox groupBoxEvent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxGallery;
        private System.Windows.Forms.GroupBox groupBoxImages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtImgPath;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtGalName;
        private System.Windows.Forms.ProgressBar pbUpload;
        private System.Windows.Forms.CheckBox chkRotate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

