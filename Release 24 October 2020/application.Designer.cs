namespace Soviet_Windows
{
    partial class application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(application));
            this.winxp = new System.Windows.Forms.Panel();
            this.startMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hideStart = new System.Windows.Forms.PictureBox();
            this.mediaControl = new System.Windows.Forms.PictureBox();
            this.startBtn = new System.Windows.Forms.PictureBox();
            this.winxp.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hideStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // winxp
            // 
            this.winxp.BackColor = System.Drawing.Color.White;
            this.winxp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("winxp.BackgroundImage")));
            this.winxp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.winxp.Controls.Add(this.startMenu);
            this.winxp.Controls.Add(this.panel1);
            this.winxp.Location = new System.Drawing.Point(3, 3);
            this.winxp.Name = "winxp";
            this.winxp.Size = new System.Drawing.Size(1028, 572);
            this.winxp.TabIndex = 0;
            this.winxp.Click += new System.EventHandler(this.winxp_Click);
            this.winxp.Paint += new System.Windows.Forms.PaintEventHandler(this.winxp_Paint);
            // 
            // startMenu
            // 
            this.startMenu.Location = new System.Drawing.Point(1, 188);
            this.startMenu.Name = "startMenu";
            this.startMenu.Size = new System.Drawing.Size(294, 355);
            this.startMenu.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.hideStart);
            this.panel1.Controls.Add(this.mediaControl);
            this.panel1.Controls.Add(this.startBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 542);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 30);
            this.panel1.TabIndex = 0;
            // 
            // hideStart
            // 
            this.hideStart.BackColor = System.Drawing.Color.Transparent;
            this.hideStart.Image = ((System.Drawing.Image)(resources.GetObject("hideStart.Image")));
            this.hideStart.Location = new System.Drawing.Point(0, 0);
            this.hideStart.Name = "hideStart";
            this.hideStart.Size = new System.Drawing.Size(100, 30);
            this.hideStart.TabIndex = 3;
            this.hideStart.TabStop = false;
            this.hideStart.Click += new System.EventHandler(this.hideStart_Click);
            // 
            // mediaControl
            // 
            this.mediaControl.Image = ((System.Drawing.Image)(resources.GetObject("mediaControl.Image")));
            this.mediaControl.Location = new System.Drawing.Point(928, 1);
            this.mediaControl.Name = "mediaControl";
            this.mediaControl.Size = new System.Drawing.Size(100, 30);
            this.mediaControl.TabIndex = 2;
            this.mediaControl.TabStop = false;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Transparent;
            this.startBtn.Image = ((System.Drawing.Image)(resources.GetObject("startBtn.Image")));
            this.startBtn.Location = new System.Drawing.Point(0, 0);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(100, 30);
            this.startBtn.TabIndex = 1;
            this.startBtn.TabStop = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1034, 578);
            this.Controls.Add(this.winxp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "application";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soviet Windows";
            this.Load += new System.EventHandler(this.application_Load);
            this.winxp.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hideStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel winxp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox startBtn;
        private System.Windows.Forms.PictureBox mediaControl;
        private System.Windows.Forms.Panel startMenu;
        private System.Windows.Forms.PictureBox hideStart;
    }
}