namespace StockTrackerV4
{
    partial class FrmMusteriListele
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
            this.txtFirmaAra = new System.Windows.Forms.TextBox();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.txtYetkiliKisi = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            System.Windows.Forms.Label lblFirmaAra = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblFirmaAdi = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblYetkiliKisi = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblTelefon = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblAdres = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblEmail = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Listeleme";

            // Firma Ara
            lblFirmaAra.Text = "Firma Ara:";
            lblFirmaAra.Location = new System.Drawing.Point(12, 15);
            lblFirmaAra.AutoSize = true;

            this.txtFirmaAra.Location = new System.Drawing.Point(90, 12);
            this.txtFirmaAra.Size = new System.Drawing.Size(167, 20);
            this.txtFirmaAra.TextChanged += new System.EventHandler(this.txtFirmaAra_TextChanged);

            // GroupBox
            System.Windows.Forms.GroupBox grpMusteri = new System.Windows.Forms.GroupBox();
            grpMusteri.Text = "Müşteri Bilgileri";
            grpMusteri.Location = new System.Drawing.Point(12, 45);
            grpMusteri.Size = new System.Drawing.Size(250, 300);

            // Firma Adı
            lblFirmaAdi.Text = "Firma Adı:";
            lblFirmaAdi.Location = new System.Drawing.Point(6, 25);
            lblFirmaAdi.AutoSize = true;

            this.txtFirmaAdi.Location = new System.Drawing.Point(78, 22);
            this.txtFirmaAdi.Size = new System.Drawing.Size(157, 20);

            // Yetkili Kişi
            lblYetkiliKisi.Text = "Yetkili Kişi:";
            lblYetkiliKisi.Location = new System.Drawing.Point(6, 65);
            lblYetkiliKisi.AutoSize = true;

            this.txtYetkiliKisi.Location = new System.Drawing.Point(78, 62);
            this.txtYetkiliKisi.Size = new System.Drawing.Size(157, 20);

            // Telefon
            lblTelefon.Text = "Telefon:";
            lblTelefon.Location = new System.Drawing.Point(6, 105);
            lblTelefon.AutoSize = true;

            this.txtTelefon.Location = new System.Drawing.Point(78, 102);
            this.txtTelefon.Size = new System.Drawing.Size(157, 20);

            // Adres
            lblAdres.Text = "Adres:";
            lblAdres.Location = new System.Drawing.Point(6, 145);
            lblAdres.AutoSize = true;

            this.txtAdres.Location = new System.Drawing.Point(78, 142);
            this.txtAdres.Size = new System.Drawing.Size(157, 20);

            // Email
            lblEmail.Text = "Email:";
            lblEmail.Location = new System.Drawing.Point(6, 185);
            lblEmail.AutoSize = true;

            this.txtEmail.Location = new System.Drawing.Point(78, 182);
            this.txtEmail.Size = new System.Drawing.Size(157, 20);

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
            grpMusteri.Controls.Add(lblFirmaAdi);
            grpMusteri.Controls.Add(this.txtFirmaAdi);
            grpMusteri.Controls.Add(lblYetkiliKisi);
            grpMusteri.Controls.Add(this.txtYetkiliKisi);
            grpMusteri.Controls.Add(lblTelefon);
            grpMusteri.Controls.Add(this.txtTelefon);
            grpMusteri.Controls.Add(lblAdres);
            grpMusteri.Controls.Add(this.txtAdres);
            grpMusteri.Controls.Add(lblEmail);
            grpMusteri.Controls.Add(this.txtEmail);
            grpMusteri.Controls.Add(this.btnGuncelle);
            grpMusteri.Controls.Add(this.btnSil);

            // Form Controls
            this.Controls.Add(lblFirmaAra);
            this.Controls.Add(this.txtFirmaAra);
            this.Controls.Add(grpMusteri);
            this.Controls.Add(this.dataGridView1);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.Load += new System.EventHandler(this.FrmMusteriListele_Load);
        }

        public System.Windows.Forms.TextBox txtFirmaAra;
        public System.Windows.Forms.TextBox txtFirmaAdi;
        public System.Windows.Forms.TextBox txtYetkiliKisi;
        public System.Windows.Forms.TextBox txtTelefon;
        public System.Windows.Forms.TextBox txtAdres;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.Button btnGuncelle;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}