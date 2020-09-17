namespace Soviet_Windows
{
    partial class boot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(boot));
            this.americanMegatrends = new System.Windows.Forms.Panel();
            this.stalinsoftBoot = new System.Windows.Forms.Panel();
            this.errorMsg = new System.Windows.Forms.Label();
            this.black = new System.Windows.Forms.Panel();
            this.black.SuspendLayout();
            this.SuspendLayout();
            // 
            // americanMegatrends
            // 
            this.americanMegatrends.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("americanMegatrends.BackgroundImage")));
            this.americanMegatrends.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.americanMegatrends.Location = new System.Drawing.Point(6, 3);
            this.americanMegatrends.Name = "americanMegatrends";
            this.americanMegatrends.Size = new System.Drawing.Size(957, 577);
            this.americanMegatrends.TabIndex = 0;
            // 
            // stalinsoftBoot
            // 
            this.stalinsoftBoot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stalinsoftBoot.BackgroundImage")));
            this.stalinsoftBoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stalinsoftBoot.Location = new System.Drawing.Point(14, 3);
            this.stalinsoftBoot.Name = "stalinsoftBoot";
            this.stalinsoftBoot.Size = new System.Drawing.Size(930, 565);
            this.stalinsoftBoot.TabIndex = 1;
            // 
            // errorMsg
            // 
            this.errorMsg.AutoSize = true;
            this.errorMsg.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.errorMsg.ForeColor = System.Drawing.Color.White;
            this.errorMsg.Location = new System.Drawing.Point(8, 9);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(918, 180);
            this.errorMsg.TabIndex = 1;
            this.errorMsg.Text = resources.GetString("errorMsg.Text");
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.Color.Black;
            this.black.Controls.Add(this.stalinsoftBoot);
            this.black.Controls.Add(this.americanMegatrends);
            this.black.Location = new System.Drawing.Point(-1, 0);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(957, 587);
            this.black.TabIndex = 2;
            // 
            // boot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(977, 578);
            this.Controls.Add(this.black);
            this.Controls.Add(this.errorMsg);
            this.Name = "boot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soviet Windows";
            this.Load += new System.EventHandler(this.boot_Load);
            this.black.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel americanMegatrends;
        private System.Windows.Forms.Panel stalinsoftBoot;
        private System.Windows.Forms.Label errorMsg;
        private System.Windows.Forms.Panel black;
    }
}

