namespace StockTrackerV4
{
    partial class FrmStokHareketleri
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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.btnListele = new System.Windows.Forms.Button();

            System.Windows.Forms.Label lblBaslangic = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblBitis = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Hareketleri";

            // Başlık
            this.lblBaslik.Text = "Son Stok Hareketleri";
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Location = new System.Drawing.Point(12, 15);

            // Tarih Aralığı
            lblBaslangic.Text = "Başlangıç Tarihi:";
            lblBaslangic.Location = new System.Drawing.Point(12, 50);
            lblBaslangic.AutoSize = true;

            this.dtpBaslangic.Location = new System.Drawing.Point(100, 48);
            this.dtpBaslangic.Size = new System.Drawing.Size(150, 20);
            this.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            lblBitis.Text = "Bitiş Tarihi:";
            lblBitis.Location = new System.Drawing.Point(270, 50);
            lblBitis.AutoSize = true;

            this.dtpBitis.Location = new System.Drawing.Point(330, 48);
            this.dtpBitis.Size = new System.Drawing.Size(150, 20);
            this.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // Listeleme Butonu
            this.btnListele.Text = "Hareketleri Göster";
            this.btnListele.Location = new System.Drawing.Point(500, 46);
            this.btnListele.Size = new System.Drawing.Size(120, 25);
            this.btnListele.BackColor = System.Drawing.Color.LightGreen;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);

            // DataGridView
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.Size = new System.Drawing.Size(960, 464);
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ReadOnly = true;

            // Form Controls
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblBaslik,
                lblBaslangic,
                this.dtpBaslangic,
                lblBitis,
                this.dtpBitis,
                this.btnListele,
                this.dataGridView1
            });

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.Load += new System.EventHandler(this.FrmStokHareketleri_Load);
        }

        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label lblBaslik;
        public System.Windows.Forms.DateTimePicker dtpBaslangic;
        public System.Windows.Forms.DateTimePicker dtpBitis;
        public System.Windows.Forms.Button btnListele;
    }
}