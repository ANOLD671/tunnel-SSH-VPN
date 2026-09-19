namespace ssh_vpn
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

        
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

        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnToggle = new System.Windows.Forms.Button();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            this.timer_check_status = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnGh = new System.Windows.Forms.Button();
            this.btnTelegram = new System.Windows.Forms.Button();
            this.SuspendLayout();
      
            this.btnToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggle.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggle.Location = new System.Drawing.Point(18, 18);
            this.btnToggle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(390, 112);
            this.btnToggle.TabIndex = 0;
            this.btnToggle.Text = "Connect";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
           
            this.githubLink.AutoSize = true;
            this.githubLink.Location = new System.Drawing.Point(18, 394);
            this.githubLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(97, 20);
            this.githubLink.TabIndex = 2;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "Github page";
            this.githubLink.Visible = false;
            
            this.timer_check_status.Interval = 1000;
            this.timer_check_status.Tick += new System.EventHandler(this.timer_check_status_Tick);
            
            this.notifyIcon1.BalloonTipText = "SSH VPN Disconected...";
            this.notifyIcon1.Text = "SSH VPN NOTIF";
            this.notifyIcon1.Visible = true;
            
          
            this.lblStatus.BackColor = System.Drawing.Color.Red;
            this.lblStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Location = new System.Drawing.Point(18, 140);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(390, 98);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Not Connected";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            this.btnGh.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnGh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGh.BackgroundImage")));
            this.btnGh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGh.FlatAppearance.BorderSize = 0;
            this.btnGh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGh.Location = new System.Drawing.Point(18, 248);
            this.btnGh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGh.Name = "btnGh";
            this.btnGh.Size = new System.Drawing.Size(82, 80);
            this.btnGh.TabIndex = 5;
            this.btnGh.UseVisualStyleBackColor = false;
            this.btnGh.Click += new System.EventHandler(this.btnGh_Click);
            
            
            this.btnTelegram.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnTelegram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTelegram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTelegram.FlatAppearance.BorderSize = 0;
            this.btnTelegram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelegram.Image = global::ssh_vpn.Properties.Resources.telegramIcon;
            this.btnTelegram.Location = new System.Drawing.Point(118, 248);
            this.btnTelegram.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTelegram.Name = "btnTelegram";
            this.btnTelegram.Size = new System.Drawing.Size(90, 80);
            this.btnTelegram.TabIndex = 6;
            this.btnTelegram.Text = "Telegram";
            this.btnTelegram.UseVisualStyleBackColor = false;
            this.btnTelegram.Click += new System.EventHandler(this.btnTelegram_Click);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(424, 349);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnGh);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.btnTelegram);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SSH VPN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel githubLink;
        private System.Windows.Forms.Timer timer_check_status;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnGh;
        private System.Windows.Forms.Button btnTelegram;
        private System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.Button btnToggle;
    }
}

