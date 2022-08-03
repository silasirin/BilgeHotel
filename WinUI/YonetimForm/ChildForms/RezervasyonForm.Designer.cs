namespace WinUI.ChildForms
{
    partial class RezervasyonForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.RezervasyonID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MusteriID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RezervasyonTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KonaklamaBaslangic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KonaklamaBitis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GunSayisi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TatilPaketiID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OdaID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToplamFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1281, 534);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezervasyon Bilgileri";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RezervasyonID,
            this.MusteriID,
            this.RezervasyonTarihi,
            this.KonaklamaBaslangic,
            this.KonaklamaBitis,
            this.GunSayisi,
            this.TatilPaketiID,
            this.OdaID,
            this.ToplamFiyat});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1264, 472);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // RezervasyonID
            // 
            this.RezervasyonID.Text = "Rezervasyon ID";
            this.RezervasyonID.Width = 134;
            // 
            // MusteriID
            // 
            this.MusteriID.Text = "Müşteri ID";
            this.MusteriID.Width = 114;
            // 
            // RezervasyonTarihi
            // 
            this.RezervasyonTarihi.Text = "Rezervasyon Tarihi";
            this.RezervasyonTarihi.Width = 164;
            // 
            // KonaklamaBaslangic
            // 
            this.KonaklamaBaslangic.Text = "Konaklama Başlangıç";
            this.KonaklamaBaslangic.Width = 186;
            // 
            // KonaklamaBitis
            // 
            this.KonaklamaBitis.Text = "Konaklama Bitiş";
            this.KonaklamaBitis.Width = 149;
            // 
            // GunSayisi
            // 
            this.GunSayisi.Text = "Gün Sayısı";
            this.GunSayisi.Width = 125;
            // 
            // TatilPaketiID
            // 
            this.TatilPaketiID.Text = "Tatil Paketi ID";
            this.TatilPaketiID.Width = 154;
            // 
            // OdaID
            // 
            this.OdaID.Text = "Oda ID";
            this.OdaID.Width = 92;
            // 
            // ToplamFiyat
            // 
            this.ToplamFiyat.Text = "Toplam Fiyat";
            this.ToplamFiyat.Width = 129;
            // 
            // RezervasyonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 560);
            this.Controls.Add(this.groupBox1);
            this.Name = "RezervasyonForm";
            this.Text = "RezervasyonForm";
            this.Load += new System.EventHandler(this.RezervasyonForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader RezervasyonID;
        private System.Windows.Forms.ColumnHeader MusteriID;
        private System.Windows.Forms.ColumnHeader RezervasyonTarihi;
        private System.Windows.Forms.ColumnHeader KonaklamaBaslangic;
        private System.Windows.Forms.ColumnHeader KonaklamaBitis;
        private System.Windows.Forms.ColumnHeader GunSayisi;
        private System.Windows.Forms.ColumnHeader TatilPaketiID;
        private System.Windows.Forms.ColumnHeader OdaID;
        private System.Windows.Forms.ColumnHeader ToplamFiyat;
    }
}