namespace StockTrackerV4
{
    partial class FrmAnaSayfa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnMusteriListele = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnUrunListele = new System.Windows.Forms.Button();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnStokHareketleri = new System.Windows.Forms.Button();
            this.btnStokHareket = new System.Windows.Forms.Button();
            this.lblToplamUrun = new System.Windows.Forms.Label();
            this.lblToplamStok = new System.Windows.Forms.Label();
            this.lblKritikStok = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockTracker V4";

            // Butonlar
            this.btnMusteriEkle.Location = new System.Drawing.Point(12, 12);
            this.btnMusteriEkle.Size = new System.Drawing.Size(120, 40);
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);

            this.btnMusteriListele.Location = new System.Drawing.Point(142, 12);
            this.btnMusteriListele.Size = new System.Drawing.Size(120, 40);
            this.btnMusteriListele.Text = "Müşteri Listele";
            this.btnMusteriListele.Click += new System.EventHandler(this.btnMusteriListele_Click);

            this.btnUrunEkle.Location = new System.Drawing.Point(272, 12);
            this.btnUrunEkle.Size = new System.Drawing.Size(120, 40);
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);

            this.btnUrunListele.Location = new System.Drawing.Point(402, 12);
            this.btnUrunListele.Size = new System.Drawing.Size(120, 40);
            this.btnUrunListele.Text = "Ürün Listele";
            this.btnUrunListele.Click += new System.EventHandler(this.btnUrunListele_Click);

            this.btnKategori.Location = new System.Drawing.Point(532, 12);
            this.btnKategori.Size = new System.Drawing.Size(120, 40);
            this.btnKategori.Text = "Kategori";
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);

            this.btnStokHareketleri.Location = new System.Drawing.Point(662, 12);
            this.btnStokHareketleri.Size = new System.Drawing.Size(120, 40);
            this.btnStokHareketleri.Text = "Stok Hareketleri";
            this.btnStokHareketleri.Click += new System.EventHandler(this.btnStokHareketleri_Click);

            this.btnStokHareket.Location = new System.Drawing.Point(792, 12);
            this.btnStokHareket.Size = new System.Drawing.Size(120, 40);
            this.btnStokHareket.Text = "Stok Hareket";
            this.btnStokHareket.Click += new System.EventHandler(this.btnStokHareket_Click);

            // Labels
            this.lblToplamUrun.Location = new System.Drawing.Point(12, 70);
            this.lblToplamUrun.AutoSize = true;
            this.lblToplamUrun.Text = "Toplam Ürün: 0";

            this.lblToplamStok.Location = new System.Drawing.Point(12, 100);
            this.lblToplamStok.AutoSize = true;
            this.lblToplamStok.Text = "Toplam Stok: 0";

            this.lblKritikStok.Location = new System.Drawing.Point(12, 130);
            this.lblKritikStok.AutoSize = true;
            this.lblKritikStok.ForeColor = System.Drawing.Color.Red;
            this.lblKritikStok.Text = "Kritik Stok: 0";

            // DataGridView
            this.dataGridView1.Location = new System.Drawing.Point(200, 70);
            this.dataGridView1.Size = new System.Drawing.Size(800, 650);
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.AllowUserToAddRows = false;

            // Controls
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnMusteriEkle,
                this.btnMusteriListele,
                this.btnUrunEkle,
                this.btnUrunListele,
                this.btnKategori,
                this.btnStokHareketleri,
                this.btnStokHareket,
                this.lblToplamUrun,
                this.lblToplamStok,
                this.lblKritikStok,
                this.dataGridView1
            });

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnMusteriListele;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnUrunListele;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnStokHareketleri;
        private System.Windows.Forms.Button btnStokHareket;
        private System.Windows.Forms.Label lblToplamUrun;
        private System.Windows.Forms.Label lblToplamStok;
        private System.Windows.Forms.Label lblKritikStok;
    }
}