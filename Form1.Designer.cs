namespace HashVault
{
    partial class frmHashVault
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFilePath = new Label();
            txtFilePath = new TextBox();
            btnBrowse = new Button();
            btnHash = new Button();
            btnExport = new Button();
            txtHashOutput = new TextBox();
            btnAppendLog = new Button();
            lblChooseHashMethod = new Label();
            chkMD5 = new CheckBox();
            chkSHA256 = new CheckBox();
            chkSHA512 = new CheckBox();
            lbltitle = new Label();
            lblCopyrightsDiodor = new Label();
            lblGithub = new LinkLabel();
            label1 = new Label();
            lblLicense = new LinkLabel();
            SuspendLayout();
            // 
            // lblFilePath
            // 
            lblFilePath.AutoSize = true;
            lblFilePath.Font = new Font("Segoe UI", 10F);
            lblFilePath.Location = new Point(199, 116);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(75, 19);
            lblFilePath.TabIndex = 0;
            lblFilePath.Text = "Select File: ";
            lblFilePath.Click += label1_Click;
            // 
            // txtFilePath
            // 
            txtFilePath.AllowDrop = true;
            txtFilePath.Location = new Point(283, 112);
            txtFilePath.Multiline = true;
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(204, 23);
            txtFilePath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(493, 112);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnHash
            // 
            btnHash.Location = new Point(199, 252);
            btnHash.Name = "btnHash";
            btnHash.Size = new Size(111, 23);
            btnHash.TabIndex = 3;
            btnHash.Text = "Show Hash";
            btnHash.UseVisualStyleBackColor = true;
            btnHash.Click += btnHash_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(457, 377);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(111, 23);
            btnExport.TabIndex = 4;
            btnExport.Text = "Export to new .txt";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // txtHashOutput
            // 
            txtHashOutput.Location = new Point(329, 252);
            txtHashOutput.Multiline = true;
            txtHashOutput.Name = "txtHashOutput";
            txtHashOutput.ReadOnly = true;
            txtHashOutput.Size = new Size(239, 105);
            txtHashOutput.TabIndex = 5;
            // 
            // btnAppendLog
            // 
            btnAppendLog.Location = new Point(329, 377);
            btnAppendLog.Name = "btnAppendLog";
            btnAppendLog.Size = new Size(109, 23);
            btnAppendLog.TabIndex = 6;
            btnAppendLog.Text = "Add to a txt file";
            btnAppendLog.UseVisualStyleBackColor = true;
            btnAppendLog.Click += btnAppendLog_Click;
            // 
            // lblChooseHashMethod
            // 
            lblChooseHashMethod.AutoSize = true;
            lblChooseHashMethod.Location = new Point(197, 165);
            lblChooseHashMethod.Name = "lblChooseHashMethod";
            lblChooseHashMethod.Size = new Size(140, 15);
            lblChooseHashMethod.TabIndex = 7;
            lblChooseHashMethod.Text = "Choose hashing method:";
            lblChooseHashMethod.Click += label1_Click_1;
            // 
            // chkMD5
            // 
            chkMD5.AutoSize = true;
            chkMD5.Location = new Point(359, 164);
            chkMD5.Name = "chkMD5";
            chkMD5.Size = new Size(51, 19);
            chkMD5.TabIndex = 8;
            chkMD5.Text = "MD5";
            chkMD5.UseVisualStyleBackColor = true;
            // 
            // chkSHA256
            // 
            chkSHA256.AutoSize = true;
            chkSHA256.Location = new Point(359, 189);
            chkSHA256.Name = "chkSHA256";
            chkSHA256.Size = new Size(72, 19);
            chkSHA256.TabIndex = 9;
            chkSHA256.Text = "SHA-256";
            chkSHA256.UseVisualStyleBackColor = true;
            // 
            // chkSHA512
            // 
            chkSHA512.AutoSize = true;
            chkSHA512.Location = new Point(359, 214);
            chkSHA512.Name = "chkSHA512";
            chkSHA512.Size = new Size(72, 19);
            chkSHA512.TabIndex = 10;
            chkSHA512.Text = "SHA-512";
            chkSHA512.UseVisualStyleBackColor = true;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Bookman Old Style", 54F, FontStyle.Bold);
            lbltitle.Location = new Point(175, -5);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(421, 84);
            lbltitle.TabIndex = 11;
            lbltitle.Text = "HashVault";
            // 
            // lblCopyrightsDiodor
            // 
            lblCopyrightsDiodor.AutoSize = true;
            lblCopyrightsDiodor.Font = new Font("Segoe UI", 7F);
            lblCopyrightsDiodor.Location = new Point(3, 418);
            lblCopyrightsDiodor.Name = "lblCopyrightsDiodor";
            lblCopyrightsDiodor.Size = new Size(202, 12);
            lblCopyrightsDiodor.TabIndex = 12;
            lblCopyrightsDiodor.Text = "©2025, Hashvault v0.1, Created by DiodorEos";
            // 
            // lblGithub
            // 
            lblGithub.ActiveLinkColor = Color.FromArgb(78, 129, 172);
            lblGithub.AutoSize = true;
            lblGithub.Font = new Font("Segoe UI", 8F);
            lblGithub.LinkColor = Color.FromArgb(230, 124, 58);
            lblGithub.Location = new Point(198, 67);
            lblGithub.Name = "lblGithub";
            lblGithub.Size = new Size(124, 13);
            lblGithub.TabIndex = 13;
            lblGithub.TabStop = true;
            lblGithub.Text = "github.com/DiodorEos";
            lblGithub.LinkClicked += lblGithub_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F);
            label1.Location = new Point(3, 435);
            label1.Name = "label1";
            label1.Size = new Size(139, 12);
            label1.TabIndex = 14;
            label1.Text = "This work is licensed under the";
            // 
            // lblLicense
            // 
            lblLicense.ActiveLinkColor = Color.FromArgb(78, 129, 172);
            lblLicense.AutoSize = true;
            lblLicense.Font = new Font("Segoe UI", 7F);
            lblLicense.LinkColor = Color.FromArgb(230, 124, 58);
            lblLicense.Location = new Point(141, 435);
            lblLicense.Name = "lblLicense";
            lblLicense.Size = new Size(370, 12);
            lblLicense.TabIndex = 15;
            lblLicense.TabStop = true;
            lblLicense.Text = "Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License.";
            lblLicense.LinkClicked += lblLicense_LinkClicked;
            // 
            // frmHashVault
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLicense);
            Controls.Add(label1);
            Controls.Add(lblGithub);
            Controls.Add(lblCopyrightsDiodor);
            Controls.Add(lbltitle);
            Controls.Add(chkSHA512);
            Controls.Add(chkSHA256);
            Controls.Add(chkMD5);
            Controls.Add(lblChooseHashMethod);
            Controls.Add(btnAppendLog);
            Controls.Add(txtHashOutput);
            Controls.Add(btnExport);
            Controls.Add(btnHash);
            Controls.Add(btnBrowse);
            Controls.Add(txtFilePath);
            Controls.Add(lblFilePath);
            Name = "frmHashVault";
            Text = "HashVault";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFilePath;
        private TextBox txtFilePath;
        private Button btnBrowse;
        private Button btnHash;
        private Button btnExport;
        private TextBox txtHashOutput;
        private Button btnAppendLog;
        private Label lblChooseHashMethod;
        private CheckBox chkMD5;
        private CheckBox chkSHA256;
        private CheckBox chkSHA512;
        private Label lbltitle;
        private Label lblCopyrightsDiodor;
        private LinkLabel lblGithub;
        private Label label1;
        private LinkLabel lblLicense;
    }
}
