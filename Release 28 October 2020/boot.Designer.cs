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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tOne = new System.Windows.Forms.Panel();
            this.errorMsg = new System.Windows.Forms.Label();
            this.black = new System.Windows.Forms.Panel();
            this.tTwo = new System.Windows.Forms.Panel();
            this.tThree = new System.Windows.Forms.Panel();
            this.tFour = new System.Windows.Forms.Panel();
            this.tFive = new System.Windows.Forms.Panel();
            this.tZero = new System.Windows.Forms.Panel();
            this.stalinsoftBoot.SuspendLayout();
            this.panel1.SuspendLayout();
            this.black.SuspendLayout();
            this.tFour.SuspendLayout();
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
            this.stalinsoftBoot.Controls.Add(this.panel1);
            this.stalinsoftBoot.Location = new System.Drawing.Point(7, 3);
            this.stalinsoftBoot.Name = "stalinsoftBoot";
            this.stalinsoftBoot.Size = new System.Drawing.Size(930, 565);
            this.stalinsoftBoot.TabIndex = 1;
            this.stalinsoftBoot.Paint += new System.Windows.Forms.PaintEventHandler(this.stalinsoftBoot_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tZero);
            this.panel1.Controls.Add(this.tFour);
            this.panel1.Controls.Add(this.tThree);
            this.panel1.Controls.Add(this.tTwo);
            this.panel1.Controls.Add(this.tOne);
            this.panel1.Location = new System.Drawing.Point(374, 392);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 38);
            this.panel1.TabIndex = 0;
            // 
            // tOne
            // 
            this.tOne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tOne.BackgroundImage")));
            this.tOne.Location = new System.Drawing.Point(2, 16);
            this.tOne.Name = "tOne";
            this.tOne.Size = new System.Drawing.Size(87, 24);
            this.tOne.TabIndex = 1;
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
            // tTwo
            // 
            this.tTwo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tTwo.BackgroundImage")));
            this.tTwo.Location = new System.Drawing.Point(32, 16);
            this.tTwo.Name = "tTwo";
            this.tTwo.Size = new System.Drawing.Size(87, 24);
            this.tTwo.TabIndex = 2;
            // 
            // tThree
            // 
            this.tThree.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tThree.BackgroundImage")));
            this.tThree.Location = new System.Drawing.Point(72, 16);
            this.tThree.Name = "tThree";
            this.tThree.Size = new System.Drawing.Size(87, 24);
            this.tThree.TabIndex = 3;
            // 
            // tFour
            // 
            this.tFour.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tFour.BackgroundImage")));
            this.tFour.Controls.Add(this.tFive);
            this.tFour.Location = new System.Drawing.Point(95, 16);
            this.tFour.Name = "tFour";
            this.tFour.Size = new System.Drawing.Size(87, 24);
            this.tFour.TabIndex = 4;
            // 
            // tFive
            // 
            this.tFive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tFive.BackgroundImage")));
            this.tFive.Location = new System.Drawing.Point(30, 0);
            this.tFive.Name = "tFive";
            this.tFive.Size = new System.Drawing.Size(87, 24);
            this.tFive.TabIndex = 5;
            // 
            // tZero
            // 
            this.tZero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tZero.BackgroundImage")));
            this.tZero.Location = new System.Drawing.Point(-34, 16);
            this.tZero.Name = "tZero";
            this.tZero.Size = new System.Drawing.Size(87, 24);
            this.tZero.TabIndex = 6;
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
            this.stalinsoftBoot.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.black.ResumeLayout(false);
            this.tFour.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel americanMegatrends;
        private System.Windows.Forms.Panel stalinsoftBoot;
        private System.Windows.Forms.Label errorMsg;
        private System.Windows.Forms.Panel black;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel tOne;
        private System.Windows.Forms.Panel tTwo;
        private System.Windows.Forms.Panel tFour;
        private System.Windows.Forms.Panel tFive;
        private System.Windows.Forms.Panel tThree;
        private System.Windows.Forms.Panel tZero;
    }
}

