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
            this.wlcmErr = new System.Windows.Forms.Panel();
            this.okSixnine = new System.Windows.Forms.Panel();
            this.labelChrome = new System.Windows.Forms.Label();
            this.trashLabel = new System.Windows.Forms.Label();
            this.icoTrash = new System.Windows.Forms.Panel();
            this.icoChrome = new System.Windows.Forms.Panel();
            this.startMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hideStart = new System.Windows.Forms.PictureBox();
            this.mediaControl = new System.Windows.Forms.PictureBox();
            this.startBtn = new System.Windows.Forms.PictureBox();
            this.codeT = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.winxp.SuspendLayout();
            this.wlcmErr.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hideStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startBtn)).BeginInit();
            this.codeT.SuspendLayout();
            this.SuspendLayout();
            // 
            // winxp
            // 
            this.winxp.BackColor = System.Drawing.Color.White;
            this.winxp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("winxp.BackgroundImage")));
            this.winxp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.winxp.Controls.Add(this.codeT);
            this.winxp.Controls.Add(this.wlcmErr);
            this.winxp.Controls.Add(this.labelChrome);
            this.winxp.Controls.Add(this.trashLabel);
            this.winxp.Controls.Add(this.icoTrash);
            this.winxp.Controls.Add(this.icoChrome);
            this.winxp.Controls.Add(this.startMenu);
            this.winxp.Controls.Add(this.panel1);
            this.winxp.Location = new System.Drawing.Point(3, 3);
            this.winxp.Name = "winxp";
            this.winxp.Size = new System.Drawing.Size(1028, 572);
            this.winxp.TabIndex = 0;
            this.winxp.Click += new System.EventHandler(this.winxp_Click);
            this.winxp.Paint += new System.Windows.Forms.PaintEventHandler(this.winxp_Paint);
            // 
            // wlcmErr
            // 
            this.wlcmErr.BackColor = System.Drawing.Color.Transparent;
            this.wlcmErr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wlcmErr.BackgroundImage")));
            this.wlcmErr.Controls.Add(this.okSixnine);
            this.wlcmErr.Location = new System.Drawing.Point(222, 177);
            this.wlcmErr.Name = "wlcmErr";
            this.wlcmErr.Size = new System.Drawing.Size(617, 122);
            this.wlcmErr.TabIndex = 2;
            // 
            // okSixnine
            // 
            this.okSixnine.BackColor = System.Drawing.Color.White;
            this.okSixnine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("okSixnine.BackgroundImage")));
            this.okSixnine.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.okSixnine.Location = new System.Drawing.Point(324, 76);
            this.okSixnine.Name = "okSixnine";
            this.okSixnine.Size = new System.Drawing.Size(69, 31);
            this.okSixnine.TabIndex = 0;
            this.okSixnine.Click += new System.EventHandler(this.okSixnine_Click);
            // 
            // labelChrome
            // 
            this.labelChrome.AutoSize = true;
            this.labelChrome.BackColor = System.Drawing.Color.Transparent;
            this.labelChrome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelChrome.ForeColor = System.Drawing.Color.White;
            this.labelChrome.Location = new System.Drawing.Point(5, 162);
            this.labelChrome.Name = "labelChrome";
            this.labelChrome.Size = new System.Drawing.Size(68, 20);
            this.labelChrome.TabIndex = 5;
            this.labelChrome.Text = "Chrome";
            this.labelChrome.Click += new System.EventHandler(this.icoChrome_Click);
            // 
            // trashLabel
            // 
            this.trashLabel.AutoSize = true;
            this.trashLabel.BackColor = System.Drawing.Color.Transparent;
            this.trashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.trashLabel.ForeColor = System.Drawing.Color.White;
            this.trashLabel.Location = new System.Drawing.Point(14, 72);
            this.trashLabel.Name = "trashLabel";
            this.trashLabel.Size = new System.Drawing.Size(52, 20);
            this.trashLabel.TabIndex = 4;
            this.trashLabel.Text = "Trash";
            this.trashLabel.Click += new System.EventHandler(this.icoTrash_Click);
            // 
            // icoTrash
            // 
            this.icoTrash.BackColor = System.Drawing.Color.Transparent;
            this.icoTrash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("icoTrash.BackgroundImage")));
            this.icoTrash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icoTrash.Location = new System.Drawing.Point(9, 9);
            this.icoTrash.Name = "icoTrash";
            this.icoTrash.Size = new System.Drawing.Size(61, 61);
            this.icoTrash.TabIndex = 3;
            this.icoTrash.Click += new System.EventHandler(this.icoTrash_Click);
            // 
            // icoChrome
            // 
            this.icoChrome.BackColor = System.Drawing.Color.Transparent;
            this.icoChrome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("icoChrome.BackgroundImage")));
            this.icoChrome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icoChrome.Location = new System.Drawing.Point(9, 99);
            this.icoChrome.Name = "icoChrome";
            this.icoChrome.Size = new System.Drawing.Size(61, 61);
            this.icoChrome.TabIndex = 2;
            this.icoChrome.Click += new System.EventHandler(this.icoChrome_Click);
            // 
            // startMenu
            // 
            this.startMenu.Location = new System.Drawing.Point(1, 463);
            this.startMenu.Name = "startMenu";
            this.startMenu.Size = new System.Drawing.Size(294, 80);
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
            this.mediaControl.Click += new System.EventHandler(this.mediaControl_Click);
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
            // codeT
            // 
            this.codeT.BackColor = System.Drawing.Color.Transparent;
            this.codeT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("codeT.BackgroundImage")));
            this.codeT.Controls.Add(this.panel2);
            this.codeT.Location = new System.Drawing.Point(436, 160);
            this.codeT.Name = "codeT";
            this.codeT.Size = new System.Drawing.Size(274, 121);
            this.codeT.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Location = new System.Drawing.Point(122, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(69, 31);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
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
            this.winxp.PerformLayout();
            this.wlcmErr.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hideStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startBtn)).EndInit();
            this.codeT.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel winxp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox startBtn;
        private System.Windows.Forms.PictureBox mediaControl;
        private System.Windows.Forms.Panel startMenu;
        private System.Windows.Forms.PictureBox hideStart;
        private System.Windows.Forms.Label labelChrome;
        private System.Windows.Forms.Label trashLabel;
        private System.Windows.Forms.Panel icoTrash;
        private System.Windows.Forms.Panel icoChrome;
        private System.Windows.Forms.Panel wlcmErr;
        private System.Windows.Forms.Panel okSixnine;
        private System.Windows.Forms.Panel codeT;
        private System.Windows.Forms.Panel panel2;
    }
}