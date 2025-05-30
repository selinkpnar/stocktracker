namespace StockTrackerV4
{
    partial class FrmSatis
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

        public System.Windows.Forms.TextBox txtBarkodNo;
        public System.Windows.Forms.TextBox txtMiktar;
        public System.Windows.Forms.TextBox txtFiyat;
        public System.Windows.Forms.TextBox txtToplamFiyat;
        public System.Windows.Forms.TextBox txtSatisFiyati;
        public System.Windows.Forms.TextBox txtUrunAdi;
        public System.Windows.Forms.ComboBox cmbKategori;
        public System.Windows.Forms.Button btnEkle;
        public System.Windows.Forms.Button btnSatisYap;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label lblGenelToplam;
        public System.Windows.Forms.GroupBox grpUrun;

        private void InitializeComponent()
        {
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtToplamFiyat = new System.Windows.Forms.TextBox();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.grpUrun = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Text = "Satış Sayfası";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.FrmSatis_Load);

            // Ürün Bilgileri GroupBox
            this.grpUrun.Text = "Ürün İşlemleri";
            this.grpUrun.Location = new System.Drawing.Point(20, 20);
            this.grpUrun.Size = new System.Drawing.Size(250, 300);

            // BarkodNo
            this.txtBarkodNo.Location = new System.Drawing.Point(10, 45);
            this.txtBarkodNo.Size = new System.Drawing.Size(200, 20);
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);

            // Ürün Adı
            this.txtUrunAdi.Location = new System.Drawing.Point(10, 95);
            this.txtUrunAdi.Size = new System.Drawing.Size(200, 20);
            this.txtUrunAdi.Enabled = false;

            // Kategori
            this.cmbKategori.Location = new System.Drawing.Point(10, 145);
            this.cmbKategori.Size = new System.Drawing.Size(200, 20);
            this.cmbKategori.Enabled = false;

            // Miktar
            this.txtMiktar.Location = new System.Drawing.Point(10, 195);
            this.txtMiktar.Size = new System.Drawing.Size(200, 20);
            this.txtMiktar.Text = "1";
            this.txtMiktar.TextChanged += new System.EventHandler(this.txtMiktar_TextChanged);

            // Fiyat
            this.txtFiyat.Location = new System.Drawing.Point(10, 245);
            this.txtFiyat.Size = new System.Drawing.Size(200, 20);
            this.txtFiyat.Enabled = false;

            // Butonlar
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Location = new System.Drawing.Point(290, 45);
            this.btnEkle.Size = new System.Drawing.Size(75, 30);
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);

            this.btnSil.Text = "Sil";
            this.btnSil.Location = new System.Drawing.Point(290, 85);
            this.btnSil.Size = new System.Drawing.Size(75, 30);
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);

            this.btnSatisYap.Text = "Satış Yap";
            this.btnSatisYap.Location = new System.Drawing.Point(600, 500);
            this.btnSatisYap.Size = new System.Drawing.Size(100, 40);
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);

            // DataGridView
            this.dataGridView1.Location = new System.Drawing.Point(290, 130);
            this.dataGridView1.Size = new System.Drawing.Size(480, 350);
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // Genel Toplam Label
            this.lblGenelToplam.Text = "Genel Toplam: 0 TL";
            this.lblGenelToplam.Location = new System.Drawing.Point(290, 500);
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);

            // Label'lar
            System.Windows.Forms.Label lblBarkodNo = new System.Windows.Forms.Label();
            lblBarkodNo.Text = "Barkod No:";
            lblBarkodNo.Location = new System.Drawing.Point(10, 25);
            lblBarkodNo.AutoSize = true;

            System.Windows.Forms.Label lblUrunAdi = new System.Windows.Forms.Label();
            lblUrunAdi.Text = "Ürün Adı:";
            lblUrunAdi.Location = new System.Drawing.Point(10, 75);
            lblUrunAdi.AutoSize = true;

            System.Windows.Forms.Label lblKategori = new System.Windows.Forms.Label();
            lblKategori.Text = "Kategori:";
            lblKategori.Location = new System.Drawing.Point(10, 125);
            lblKategori.AutoSize = true;

            System.Windows.Forms.Label lblMiktar = new System.Windows.Forms.Label();
            lblMiktar.Text = "Miktar:";
            lblMiktar.Location = new System.Drawing.Point(10, 175);
            lblMiktar.AutoSize = true;

            System.Windows.Forms.Label lblFiyat = new System.Windows.Forms.Label();
            lblFiyat.Text = "Fiyat:";
            lblFiyat.Location = new System.Drawing.Point(10, 225);
            lblFiyat.AutoSize = true;

            // GroupBox'a kontrolleri ekleme
            this.grpUrun.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblBarkodNo, this.txtBarkodNo,
                lblUrunAdi, this.txtUrunAdi,
                lblKategori, this.cmbKategori,
                lblMiktar, this.txtMiktar,
                lblFiyat, this.txtFiyat
            });

            // Form'a kontrolleri ekleme
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.grpUrun,
                this.btnEkle,
                this.btnSil,
                this.btnSatisYap,
                this.dataGridView1,
                this.lblGenelToplam
            });

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}