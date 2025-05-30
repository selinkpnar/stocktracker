namespace StockTrackerV4
{
    partial class FrmStokHareket
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblStok = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblUrun = new System.Windows.Forms.Label();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Hareket";

            // Bilgi Etiketleri
            this.lblStok.AutoSize = true;
            this.lblStok.BackColor = System.Drawing.Color.White;
            this.lblStok.Location = new System.Drawing.Point(12, 15);
            this.lblStok.Size = new System.Drawing.Size(376, 30);
            this.lblStok.Text = "Stok: 0";
            this.lblStok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStok.Padding = new System.Windows.Forms.Padding(5);

            this.lblFiyat.AutoSize = true;
            this.lblFiyat.BackColor = System.Drawing.Color.White;
            this.lblFiyat.Location = new System.Drawing.Point(12, 55);
            this.lblFiyat.Size = new System.Drawing.Size(376, 30);
            this.lblFiyat.Text = "Fiyat: 0.00 TL";
            this.lblFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFiyat.Padding = new System.Windows.Forms.Padding(5);

            this.lblKategori.AutoSize = true;
            this.lblKategori.BackColor = System.Drawing.Color.White;
            this.lblKategori.Location = new System.Drawing.Point(12, 95);
            this.lblKategori.Size = new System.Drawing.Size(376, 30);
            this.lblKategori.Text = "Kategori: ";
            this.lblKategori.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblKategori.Padding = new System.Windows.Forms.Padding(5);

            // Ürün Seçimi
            this.lblUrun.AutoSize = true;
            this.lblUrun.Location = new System.Drawing.Point(12, 145);
            this.lblUrun.Text = "Ürün:";

            this.cmbUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrun.Location = new System.Drawing.Point(90, 142);
            this.cmbUrun.Size = new System.Drawing.Size(298, 21);
            this.cmbUrun.SelectedIndexChanged += new System.EventHandler(this.cmbUrun_SelectedIndexChanged);

            // Müşteri Seçimi
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Location = new System.Drawing.Point(12, 175);
            this.lblMusteri.Text = "Müşteri:";

            this.cmbMusteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusteri.Location = new System.Drawing.Point(90, 172);
            this.cmbMusteri.Size = new System.Drawing.Size(298, 21);

            // Miktar Girişi
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(12, 205);
            this.lblMiktar.Text = "Miktar:";

            this.txtMiktar.Location = new System.Drawing.Point(90, 202);
            this.txtMiktar.Size = new System.Drawing.Size(298, 20);

            // Butonlar
            this.btnGiris.Location = new System.Drawing.Point(12, 240);
            this.btnGiris.Size = new System.Drawing.Size(376, 30);
            this.btnGiris.Text = "Stok Giriş";
            this.btnGiris.BackColor = System.Drawing.Color.LightGreen;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);

            this.btnCikis.Location = new System.Drawing.Point(12, 276);
            this.btnCikis.Size = new System.Drawing.Size(376, 30);
            this.btnCikis.Text = "Stok Çıkış";
            this.btnCikis.BackColor = System.Drawing.Color.LightCoral;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);

            // Form Controls
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblStok,
                this.lblFiyat,
                this.lblKategori,
                this.lblUrun,
                this.cmbUrun,
                this.lblMusteri,
                this.cmbMusteri,
                this.lblMiktar,
                this.txtMiktar,
                this.btnGiris,
                this.btnCikis
            });

            this.ResumeLayout(false);
            this.PerformLayout();

            this.Load += new System.EventHandler(this.FrmStokHareket_Load);
        }

        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ComboBox cmbUrun;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.Label lblMiktar;
    }
}