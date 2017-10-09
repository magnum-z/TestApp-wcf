namespace TestApp_wcf_01
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
            this.btnDownloadFile = new System.Windows.Forms.Button();
            this.pbDownloadFile = new System.Windows.Forms.ProgressBar();
            this.tbDownloadFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDirectoryDownload = new System.Windows.Forms.TextBox();
            this.btnBrowseDirectory = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbAuth = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDownloadFile
            // 
            this.btnDownloadFile.Location = new System.Drawing.Point(41, 219);
            this.btnDownloadFile.Name = "btnDownloadFile";
            this.btnDownloadFile.Size = new System.Drawing.Size(133, 23);
            this.btnDownloadFile.TabIndex = 3;
            this.btnDownloadFile.Text = "Download File";
            this.btnDownloadFile.UseVisualStyleBackColor = true;
            this.btnDownloadFile.Click += new System.EventHandler(this.btnDownloadFile_Click);
            // 
            // pbDownloadFile
            // 
            this.pbDownloadFile.Location = new System.Drawing.Point(41, 160);
            this.pbDownloadFile.Name = "pbDownloadFile";
            this.pbDownloadFile.Size = new System.Drawing.Size(521, 23);
            this.pbDownloadFile.TabIndex = 3;
            // 
            // tbDownloadFile
            // 
            this.tbDownloadFile.Location = new System.Drawing.Point(41, 36);
            this.tbDownloadFile.Name = "tbDownloadFile";
            this.tbDownloadFile.Size = new System.Drawing.Size(521, 20);
            this.tbDownloadFile.TabIndex = 0;
            this.tbDownloadFile.Text = "http://download.eset.com/download/engine/eav/offline_update_eav.zip";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "URI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Directory for download";
            // 
            // tbDirectoryDownload
            // 
            this.tbDirectoryDownload.Location = new System.Drawing.Point(41, 123);
            this.tbDirectoryDownload.Name = "tbDirectoryDownload";
            this.tbDirectoryDownload.Size = new System.Drawing.Size(493, 20);
            this.tbDirectoryDownload.TabIndex = 1;
            this.tbDirectoryDownload.Text = "d:\\Temp\\download_test\\";
            // 
            // btnBrowseDirectory
            // 
            this.btnBrowseDirectory.Location = new System.Drawing.Point(535, 122);
            this.btnBrowseDirectory.Name = "btnBrowseDirectory";
            this.btnBrowseDirectory.Size = new System.Drawing.Size(27, 20);
            this.btnBrowseDirectory.TabIndex = 2;
            this.btnBrowseDirectory.Text = "\' \' \'";
            this.btnBrowseDirectory.UseVisualStyleBackColor = true;
            this.btnBrowseDirectory.Click += new System.EventHandler(this.btnBrowseDirectory_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 262);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(598, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "user";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(176, 73);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(154, 20);
            this.tbUser.TabIndex = 8;
            this.tbUser.Text = "EAV-0207360899";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(408, 73);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(154, 20);
            this.tbPassword.TabIndex = 9;
            this.tbPassword.Text = "ckbtdsv8tb";
            // 
            // cbAuth
            // 
            this.cbAuth.AutoSize = true;
            this.cbAuth.Location = new System.Drawing.Point(41, 75);
            this.cbAuth.Name = "cbAuth";
            this.cbAuth.Size = new System.Drawing.Size(94, 17);
            this.cbAuth.TabIndex = 10;
            this.cbAuth.Text = "Authentication";
            this.cbAuth.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 284);
            this.Controls.Add(this.cbAuth);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnBrowseDirectory);
            this.Controls.Add(this.tbDirectoryDownload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDownloadFile);
            this.Controls.Add(this.pbDownloadFile);
            this.Controls.Add(this.btnDownloadFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DownloadFile";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownloadFile;
        private System.Windows.Forms.ProgressBar pbDownloadFile;
        private System.Windows.Forms.TextBox tbDownloadFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDirectoryDownload;
        private System.Windows.Forms.Button btnBrowseDirectory;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.CheckBox cbAuth;
    }
}

