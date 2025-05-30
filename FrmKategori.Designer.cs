namespace StockTrackerV4
{
    partial class FrmKategori
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
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();

            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori İşlemleri";

            // Label
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(12, 15);
            this.lblKategori.Size = new System.Drawing.Size(77, 13);
            this.lblKategori.Text = "Kategori Adı:";

            // TextBox
            this.txtKategori.Location = new System.Drawing.Point(95, 12);
            this.txtKategori.Size = new System.Drawing.Size(177, 20);

            // Buttons
            this.btnEkle.Location = new System.Drawing.Point(95, 38);
            this.btnEkle.Size = new System.Drawing.Size(85, 23);
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);

            this.btnSil.Location = new System.Drawing.Point(187, 38);
            this.btnSil.Size = new System.Drawing.Size(85, 23);
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);

            // ListBox
            this.listBox1.Location = new System.Drawing.Point(15, 80);
            this.listBox1.Size = new System.Drawing.Size(257, 264);
            this.listBox1.BackColor = System.Drawing.SystemColors.Window;

            // Form Controls
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblKategori,
                this.txtKategori,
                this.btnEkle,
                this.btnSil,
                this.listBox1
            });

            this.ResumeLayout(false);
            this.PerformLayout();

            this.Load += new System.EventHandler(this.FrmKategori_Load);
        }

        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ListBox listBox1;
    }
}