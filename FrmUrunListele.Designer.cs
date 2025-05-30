namespace StockTrackerV4
{
    partial class FrmUrunListele
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
            this.grpUrunGuncelle = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBarkodNoAra = new System.Windows.Forms.TextBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtAlisFiyati = new System.Windows.Forms.TextBox();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();

            System.Windows.Forms.Label lblBarkodNoAra = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblKategori = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblUrunAdi = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblMiktar = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblAlisFiyati = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblSatisFiyati = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // Ana Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listeleme";

            // BarkodNo Arama
            lblBarkodNoAra.Text = "BarkodNo Ara:";
            lblBarkodNoAra.Location = new System.Drawing.Point(12, 15);
            lblBarkodNoAra.AutoSize = true;

            this.txtBarkodNoAra.Location = new System.Drawing.Point(90, 12);
            this.txtBarkodNoAra.Size = new System.Drawing.Size(167, 20);
            this.txtBarkodNoAra.TextChanged += new System.EventHandler(this.txtBarkodNoAra_TextChanged);

            // Ürün Güncelleme GroupBox
            this.grpUrunGuncelle.Text = "Ürün Güncelle";
            this.grpUrunGuncelle.Location = new System.Drawing.Point(12, 45);
            this.grpUrunGuncelle.Size = new System.Drawing.Size(250, 300);

            // Kategori
            lblKategori.Text = "Kategori:";
            lblKategori.Location = new System.Drawing.Point(6, 25);
            lblKategori.AutoSize = true;

            this.cmbKategori.Location = new System.Drawing.Point(78, 22);
            this.cmbKategori.Size = new System.Drawing.Size(157, 21);

            // Ürün Adı
            lblUrunAdi.Text = "Ürün Adı:";
            lblUrunAdi.Location = new System.Drawing.Point(6, 65);
            lblUrunAdi.AutoSize = true;

            this.txtUrunAdi.Location = new System.Drawing.Point(78, 62);
            this.txtUrunAdi.Size = new System.Drawing.Size(157, 20);

            // Miktar
            lblMiktar.Text = "Miktar:";
            lblMiktar.Location = new System.Drawing.Point(6, 105);
            lblMiktar.AutoSize = true;

            this.txtMiktar.Location = new System.Drawing.Point(78, 102);
            this.txtMiktar.Size = new System.Drawing.Size(157, 20);

            // Alış Fiyatı
            lblAlisFiyati.Text = "Alış Fiyatı:";
            lblAlisFiyati.Location = new System.Drawing.Point(6, 145);
            lblAlisFiyati.AutoSize = true;

            this.txtAlisFiyati.Location = new System.Drawing.Point(78, 142);
            this.txtAlisFiyati.Size = new System.Drawing.Size(157, 20);

            // Satış Fiyatı
            lblSatisFiyati.Text = "Satış Fiyatı:";
            lblSatisFiyati.Location = new System.Drawing.Point(6, 185);
            lblSatisFiyati.AutoSize = true;

            this.txtSatisFiyati.Location = new System.Drawing.Point(78, 182);
            this.txtSatisFiyati.Size = new System.Drawing.Size(157, 20);

            // Butonlar
            this.btnGuncelle.Location = new System.Drawing.Point(78, 222);
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);

            this.btnSil.Location = new System.Drawing.Point(160, 222);
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);

            // DataGridView
            this.dataGridView1.Location = new System.Drawing.Point(280, 45);
            this.dataGridView1.Size = new System.Drawing.Size(480, 400);
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            // GroupBox Controls
            this.grpUrunGuncelle.Controls.Add(lblKategori);
            this.grpUrunGuncelle.Controls.Add(this.cmbKategori);
            this.grpUrunGuncelle.Controls.Add(lblUrunAdi);
            this.grpUrunGuncelle.Controls.Add(this.txtUrunAdi);
            this.grpUrunGuncelle.Controls.Add(lblMiktar);
            this.grpUrunGuncelle.Controls.Add(this.txtMiktar);
            this.grpUrunGuncelle.Controls.Add(lblAlisFiyati);
            this.grpUrunGuncelle.Controls.Add(this.txtAlisFiyati);
            this.grpUrunGuncelle.Controls.Add(lblSatisFiyati);
            this.grpUrunGuncelle.Controls.Add(this.txtSatisFiyati);
            this.grpUrunGuncelle.Controls.Add(this.btnGuncelle);
            this.grpUrunGuncelle.Controls.Add(this.btnSil);

            // Form Controls
            this.Controls.Add(lblBarkodNoAra);
            this.Controls.Add(this.txtBarkodNoAra);
            this.Controls.Add(this.grpUrunGuncelle);
            this.Controls.Add(this.dataGridView1);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.Load += new System.EventHandler(this.FrmUrunListele_Load);
        }

        public System.Windows.Forms.GroupBox grpUrunGuncelle;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox txtBarkodNoAra;
        public System.Windows.Forms.ComboBox cmbKategori;
        public System.Windows.Forms.TextBox txtUrunAdi;
        public System.Windows.Forms.TextBox txtMiktar;
        public System.Windows.Forms.TextBox txtAlisFiyati;
        public System.Windows.Forms.TextBox txtSatisFiyati;
        public System.Windows.Forms.Button btnGuncelle;
        public System.Windows.Forms.Button btnSil;
    }
}