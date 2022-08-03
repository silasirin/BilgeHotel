namespace WinUI.CalisanForms
{
    partial class CalisanForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vardiyalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tatilPaketleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervasyonBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vardiyalarToolStripMenuItem,
            this.müşterilerToolStripMenuItem,
            this.tatilPaketleriToolStripMenuItem,
            this.müşterilerToolStripMenuItem1,
            this.rezervasyonBilgileriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vardiyalarToolStripMenuItem
            // 
            this.vardiyalarToolStripMenuItem.Name = "vardiyalarToolStripMenuItem";
            this.vardiyalarToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.vardiyalarToolStripMenuItem.Text = "Vardiyalar";
            this.vardiyalarToolStripMenuItem.Click += new System.EventHandler(this.vardiyalarToolStripMenuItem_Click);
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.müşterilerToolStripMenuItem.Text = "Odalar";
            this.müşterilerToolStripMenuItem.Click += new System.EventHandler(this.müşterilerToolStripMenuItem_Click);
            // 
            // tatilPaketleriToolStripMenuItem
            // 
            this.tatilPaketleriToolStripMenuItem.Name = "tatilPaketleriToolStripMenuItem";
            this.tatilPaketleriToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.tatilPaketleriToolStripMenuItem.Text = "Tatil Paketleri";
            this.tatilPaketleriToolStripMenuItem.Click += new System.EventHandler(this.tatilPaketleriToolStripMenuItem_Click);
            // 
            // müşterilerToolStripMenuItem1
            // 
            this.müşterilerToolStripMenuItem1.Name = "müşterilerToolStripMenuItem1";
            this.müşterilerToolStripMenuItem1.Size = new System.Drawing.Size(89, 24);
            this.müşterilerToolStripMenuItem1.Text = "Müşteriler";
            this.müşterilerToolStripMenuItem1.Click += new System.EventHandler(this.müşterilerToolStripMenuItem1_Click);
            // 
            // rezervasyonBilgileriToolStripMenuItem
            // 
            this.rezervasyonBilgileriToolStripMenuItem.Name = "rezervasyonBilgileriToolStripMenuItem";
            this.rezervasyonBilgileriToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.rezervasyonBilgileriToolStripMenuItem.Text = "Rezervasyon Bilgileri";
            this.rezervasyonBilgileriToolStripMenuItem.Click += new System.EventHandler(this.rezervasyonBilgileriToolStripMenuItem_Click);
            // 
            // CalisanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CalisanForm";
            this.Text = "CalisanForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vardiyalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tatilPaketleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonBilgileriToolStripMenuItem;
    }
}