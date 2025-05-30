namespace StockTrackerV4
{
    partial class FrmUrunEkle
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
            // Form Controls
            this.grpYeniUrun = new System.Windows.Forms.GroupBox();
            this.grpVarOlanUrun = new System.Windows.Forms.GroupBox();

            // Yeni Ürün Kontrolleri
            this.lblYeniBarkodNo = new System.Windows.Forms.Label();
            this.txtYeniBarkodNo = new System.Windows.Forms.TextBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.lblYeniUrunAdi = new System.Windows.Forms.Label();
            this.txtYeniUrunAdi = new System.Windows.Forms.TextBox();
            this.lblYeniMiktar = new System.Windows.Forms.Label();
            this.txtYeniMiktar = new System.Windows.Forms.TextBox();
            this.lblYeniAlisFiyati = new System.Windows.Forms.Label();
            this.txtYeniAlisFiyati = new System.Windows.Forms.TextBox();
            this.lblYeniSatisFiyati = new System.Windows.Forms.Label();
            this.txtYeniSatisFiyati = new System.Windows.Forms.TextBox();
            this.btnYeniEkle = new System.Windows.Forms.Button();

            // Var Olan Ürün Kontrolleri
            this.lblVarOlanBarkodNo = new System.Windows.Forms.Label();
            this.txtVarOlanBarkodNo = new System.Windows.Forms.TextBox();
            this.lblVarOlanMiktar = new System.Windows.Forms.Label();
            this.txtVarOlanMiktar = new System.Windows.Forms.TextBox();
            this.btnVarOlanEkle = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Form Ayarları
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Ekleme";

            // Yeni Ürün GroupBox
            this.grpYeniUrun.Text = "Yeni Ürün";
            this.grpYeniUrun.Location = new System.Drawing.Point(12, 12);
            this.grpYeniUrun.Size = new System.Drawing.Size(273, 337);
            this.grpYeniUrun.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);

            // Yeni Ürün Kontrolleri
            this.lblYeniBarkodNo.Text = "Barkod No:";
            this.lblYeniBarkodNo.Location = new System.Drawing.Point(6, 25);
            this.lblYeniBarkodNo.AutoSize = true;
            this.lblYeniBarkodNo.ForeColor = System.Drawing.Color.White;

            this.txtYeniBarkodNo.Location = new System.Drawing.Point(88, 22);
            this.txtYeniBarkodNo.Size = new System.Drawing.Size(170, 20);

            this.lblKategori.Text = "Kategori:";
            this.lblKategori.Location = new System.Drawing.Point(6, 55);
            this.lblKategori.AutoSize = true;
            this.lblKategori.ForeColor = System.Drawing.Color.White;

            this.cmbKategori.Location = new System.Drawing.Point(88, 52);
            this.cmbKategori.Size = new System.Drawing.Size(170, 21);
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblYeniUrunAdi.Text = "Ürün Adı:";
            this.lblYeniUrunAdi.Location = new System.Drawing.Point(6, 85);
            this.lblYeniUrunAdi.AutoSize = true;
            this.lblYeniUrunAdi.ForeColor = System.Drawing.Color.White;

            this.txtYeniUrunAdi.Location = new System.Drawing.Point(88, 82);
            this.txtYeniUrunAdi.Size = new System.Drawing.Size(170, 20);

            this.lblYeniMiktar.Text = "Miktar:";
            this.lblYeniMiktar.Location = new System.Drawing.Point(6, 115);
            this.lblYeniMiktar.AutoSize = true;
            this.lblYeniMiktar.ForeColor = System.Drawing.Color.White;

            this.txtYeniMiktar.Location = new System.Drawing.Point(88, 112);
            this.txtYeniMiktar.Size = new System.Drawing.Size(170, 20);
            this.txtYeniMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYeniMiktar_KeyPress);

            this.lblYeniAlisFiyati.Text = "Alış Fiyatı:";
            this.lblYeniAlisFiyati.Location = new System.Drawing.Point(6, 145);
            this.lblYeniAlisFiyati.AutoSize = true;
            this.lblYeniAlisFiyati.ForeColor = System.Drawing.Color.White;

            this.txtYeniAlisFiyati.Location = new System.Drawing.Point(88, 142);
            this.txtYeniAlisFiyati.Size = new System.Drawing.Size(170, 20);
            this.txtYeniAlisFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYeniAlisFiyati_KeyPress);

            this.lblYeniSatisFiyati.Text = "Satış Fiyatı:";
            this.lblYeniSatisFiyati.Location = new System.Drawing.Point(6, 175);
            this.lblYeniSatisFiyati.AutoSize = true;
            this.lblYeniSatisFiyati.ForeColor = System.Drawing.Color.White;

            this.txtYeniSatisFiyati.Location = new System.Drawing.Point(88, 172);
            this.txtYeniSatisFiyati.Size = new System.Drawing.Size(170, 20);
            this.txtYeniSatisFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYeniSatisFiyati_KeyPress);

            this.btnYeniEkle.Location = new System.Drawing.Point(88, 202);
            this.btnYeniEkle.Size = new System.Drawing.Size(170, 30);
            this.btnYeniEkle.Text = "Ekle";
            this.btnYeniEkle.BackColor = System.Drawing.Color.LightGreen;
            this.btnYeniEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniEkle.Click += new System.EventHandler(this.btnYeniEkle_Click);

            // Var Olan Ürün GroupBox
            this.grpVarOlanUrun.Text = "Var Olan Ürün";
            this.grpVarOlanUrun.Location = new System.Drawing.Point(291, 12);
            this.grpVarOlanUrun.Size = new System.Drawing.Size(273, 337);
            this.grpVarOlanUrun.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);

            // Var Olan Ürün Kontrolleri
            this.lblVarOlanBarkodNo.Text = "Barkod No:";
            this.lblVarOlanBarkodNo.Location = new System.Drawing.Point(6, 25);
            this.lblVarOlanBarkodNo.AutoSize = true;
            this.lblVarOlanBarkodNo.ForeColor = System.Drawing.Color.White;

            this.txtVarOlanBarkodNo.Location = new System.Drawing.Point(88, 22);
            this.txtVarOlanBarkodNo.Size = new System.Drawing.Size(170, 20);
            this.txtVarOlanBarkodNo.TextChanged += new System.EventHandler(this.txtVarOlanBarkodNo_TextChanged);

            this.lblVarOlanMiktar.Text = "Miktar:";
            this.lblVarOlanMiktar.Location = new System.Drawing.Point(6, 55);
            this.lblVarOlanMiktar.AutoSize = true;
            this.lblVarOlanMiktar.ForeColor = System.Drawing.Color.White;

            this.txtVarOlanMiktar.Location = new System.Drawing.Point(88, 52);
            this.txtVarOlanMiktar.Size = new System.Drawing.Size(170, 20);
            this.txtVarOlanMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVarOlanMiktar_KeyPress);

            this.btnVarOlanEkle.Location = new System.Drawing.Point(88, 82);
            this.btnVarOlanEkle.Size = new System.Drawing.Size(170, 30);
            this.btnVarOlanEkle.Text = "Ekle";
            this.btnVarOlanEkle.BackColor = System.Drawing.Color.LightGreen;
            this.btnVarOlanEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVarOlanEkle.Click += new System.EventHandler(this.btnVarOlanEkle_Click);

            // GroupBox Controls
            this.grpYeniUrun.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblYeniBarkodNo, this.txtYeniBarkodNo,
                this.lblKategori, this.cmbKategori,
                this.lblYeniUrunAdi, this.txtYeniUrunAdi,
                this.lblYeniMiktar, this.txtYeniMiktar,
                this.lblYeniAlisFiyati, this.txtYeniAlisFiyati,
                this.lblYeniSatisFiyati, this.txtYeniSatisFiyati,
                this.btnYeniEkle
            });

            this.grpVarOlanUrun.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblVarOlanBarkodNo, this.txtVarOlanBarkodNo,
                this.lblVarOlanMiktar, this.txtVarOlanMiktar,
                this.btnVarOlanEkle
            });

            // Form Controls
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.grpYeniUrun,
                this.grpVarOlanUrun
            });

            this.ResumeLayout(false);

            this.Load += new System.EventHandler(this.FrmUrunEkle_Load);
        }

        // Control Declarations
        private System.Windows.Forms.GroupBox grpYeniUrun;
        private System.Windows.Forms.GroupBox grpVarOlanUrun;
        private System.Windows.Forms.TextBox txtYeniBarkodNo;
        private System.Windows.Forms.TextBox txtYeniUrunAdi;
        private System.Windows.Forms.TextBox txtYeniMiktar;
        private System.Windows.Forms.TextBox txtYeniAlisFiyati;
        private System.Windows.Forms.TextBox txtYeniSatisFiyati;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Button btnYeniEkle;
        private System.Windows.Forms.TextBox txtVarOlanBarkodNo;
        private System.Windows.Forms.TextBox txtVarOlanMiktar;
        private System.Windows.Forms.Button btnVarOlanEkle;
        private System.Windows.Forms.Label lblYeniBarkodNo;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblYeniUrunAdi;
        private System.Windows.Forms.Label lblYeniMiktar;
        private System.Windows.Forms.Label lblYeniAlisFiyati;
        private System.Windows.Forms.Label lblYeniSatisFiyati;
        private System.Windows.Forms.Label lblVarOlanBarkodNo;
        private System.Windows.Forms.Label lblVarOlanMiktar;
    }
}