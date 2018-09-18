namespace SVEmailSender
{
    partial class SVEmail
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
            this.lblFromEmailId = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblSMTPAddress = new System.Windows.Forms.Label();
            this.lblSMTPPort = new System.Windows.Forms.Label();
            this.lblEmailDistribution = new System.Windows.Forms.Label();
            this.tbFromEmailId = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbSMTPAddress = new System.Windows.Forms.TextBox();
            this.tbSMTPPort = new System.Windows.Forms.TextBox();
            this.chkSSL = new System.Windows.Forms.CheckBox();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.fileDialogSelector = new System.Windows.Forms.OpenFileDialog();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btnFileSelector = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFromEmailId
            // 
            this.lblFromEmailId.AutoSize = true;
            this.lblFromEmailId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromEmailId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFromEmailId.Location = new System.Drawing.Point(46, 28);
            this.lblFromEmailId.Name = "lblFromEmailId";
            this.lblFromEmailId.Size = new System.Drawing.Size(120, 20);
            this.lblFromEmailId.TabIndex = 0;
            this.lblFromEmailId.Text = "From Email Id";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPassword.Location = new System.Drawing.Point(46, 79);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 20);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblSMTPAddress
            // 
            this.lblSMTPAddress.AutoSize = true;
            this.lblSMTPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSMTPAddress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSMTPAddress.Location = new System.Drawing.Point(46, 117);
            this.lblSMTPAddress.Name = "lblSMTPAddress";
            this.lblSMTPAddress.Size = new System.Drawing.Size(127, 20);
            this.lblSMTPAddress.TabIndex = 2;
            this.lblSMTPAddress.Text = "SMTP Address";
            // 
            // lblSMTPPort
            // 
            this.lblSMTPPort.AutoSize = true;
            this.lblSMTPPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSMTPPort.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSMTPPort.Location = new System.Drawing.Point(46, 161);
            this.lblSMTPPort.Name = "lblSMTPPort";
            this.lblSMTPPort.Size = new System.Drawing.Size(94, 20);
            this.lblSMTPPort.TabIndex = 3;
            this.lblSMTPPort.Text = "SMTP Port";
            // 
            // lblEmailDistribution
            // 
            this.lblEmailDistribution.AutoSize = true;
            this.lblEmailDistribution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailDistribution.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmailDistribution.Location = new System.Drawing.Point(46, 252);
            this.lblEmailDistribution.Name = "lblEmailDistribution";
            this.lblEmailDistribution.Size = new System.Drawing.Size(206, 20);
            this.lblEmailDistribution.TabIndex = 5;
            this.lblEmailDistribution.Text = "Select Email Distribution";
            // 
            // tbFromEmailId
            // 
            this.tbFromEmailId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFromEmailId.Location = new System.Drawing.Point(259, 12);
            this.tbFromEmailId.Multiline = true;
            this.tbFromEmailId.Name = "tbFromEmailId";
            this.tbFromEmailId.Size = new System.Drawing.Size(368, 36);
            this.tbFromEmailId.TabIndex = 6;
            this.tbFromEmailId.Leave += new System.EventHandler(this.tbFromEmailId_Leave);
            this.tbFromEmailId.Validated += new System.EventHandler(this.tbFromEmailId_Validated);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(259, 66);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(368, 33);
            this.tbPassword.TabIndex = 7;
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassword_Validating);
            // 
            // tbSMTPAddress
            // 
            this.tbSMTPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSMTPAddress.Location = new System.Drawing.Point(259, 117);
            this.tbSMTPAddress.Multiline = true;
            this.tbSMTPAddress.Name = "tbSMTPAddress";
            this.tbSMTPAddress.Size = new System.Drawing.Size(367, 31);
            this.tbSMTPAddress.TabIndex = 8;
            this.tbSMTPAddress.Validating += new System.ComponentModel.CancelEventHandler(this.tbSMTPAddress_Validating);
            // 
            // tbSMTPPort
            // 
            this.tbSMTPPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSMTPPort.Location = new System.Drawing.Point(259, 154);
            this.tbSMTPPort.Multiline = true;
            this.tbSMTPPort.Name = "tbSMTPPort";
            this.tbSMTPPort.Size = new System.Drawing.Size(127, 36);
            this.tbSMTPPort.TabIndex = 9;
            this.tbSMTPPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSMTPPort_KeyPress);
            this.tbSMTPPort.Validating += new System.ComponentModel.CancelEventHandler(this.tbSMTPPort_Validating);
            // 
            // chkSSL
            // 
            this.chkSSL.AutoSize = true;
            this.chkSSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSSL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkSSL.Location = new System.Drawing.Point(259, 200);
            this.chkSSL.Name = "chkSSL";
            this.chkSSL.Size = new System.Drawing.Size(123, 24);
            this.chkSSL.TabIndex = 10;
            this.chkSSL.Text = "Enable SSL";
            this.chkSSL.UseVisualStyleBackColor = true;
            // 
            // btnSendMail
            // 
            this.btnSendMail.BackColor = System.Drawing.Color.LightPink;
            this.btnSendMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSendMail.Location = new System.Drawing.Point(910, 241);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(141, 42);
            this.btnSendMail.TabIndex = 14;
            this.btnSendMail.Text = "Send Email";
            this.btnSendMail.UseVisualStyleBackColor = false;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // fileDialogSelector
            // 
            this.fileDialogSelector.FileName = "fileDialogSelector";
            this.fileDialogSelector.Title = "File Selector";
            // 
            // tbFilePath
            // 
            this.tbFilePath.Enabled = false;
            this.tbFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilePath.Location = new System.Drawing.Point(259, 243);
            this.tbFilePath.Multiline = true;
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(503, 42);
            this.tbFilePath.TabIndex = 15;
            // 
            // btnFileSelector
            // 
            this.btnFileSelector.BackColor = System.Drawing.Color.Green;
            this.btnFileSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileSelector.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFileSelector.Location = new System.Drawing.Point(784, 241);
            this.btnFileSelector.Name = "btnFileSelector";
            this.btnFileSelector.Size = new System.Drawing.Size(110, 42);
            this.btnFileSelector.TabIndex = 13;
            this.btnFileSelector.Text = "Browse";
            this.btnFileSelector.UseVisualStyleBackColor = false;
            this.btnFileSelector.Click += new System.EventHandler(this.btnFileSelector_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1108, 278);
            this.dataGridView1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SVEmailSender.Properties.Resources.Softvision_Logo_JPEG;
            this.pictureBox1.Location = new System.Drawing.Point(722, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 58);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // SVEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(984, 585);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFileSelector);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.chkSSL);
            this.Controls.Add(this.tbSMTPPort);
            this.Controls.Add(this.tbSMTPAddress);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbFromEmailId);
            this.Controls.Add(this.lblEmailDistribution);
            this.Controls.Add(this.lblSMTPPort);
            this.Controls.Add(this.lblSMTPAddress);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblFromEmailId);
            this.MaximizeBox = false;
            this.Name = "SVEmail";
            this.Text = "SVEmail";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFromEmailId;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblSMTPAddress;
        private System.Windows.Forms.Label lblSMTPPort;
        private System.Windows.Forms.Label lblEmailDistribution;
        private System.Windows.Forms.TextBox tbFromEmailId;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbSMTPAddress;
        private System.Windows.Forms.TextBox tbSMTPPort;
        private System.Windows.Forms.CheckBox chkSSL;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.OpenFileDialog fileDialogSelector;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btnFileSelector;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

