namespace StockTrackerV4
{
    partial class FrmMusteriEkle
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
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.txtYetkiliKisi = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblFirmaAdi = new System.Windows.Forms.Label();
            this.lblYetkiliKisi = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.Location = new System.Drawing.Point(100, 22);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(150, 20);
            this.txtFirmaAdi.TabIndex = 1;
            // 
            // txtYetkiliKisi
            // 
            this.txtYetkiliKisi.Location = new System.Drawing.Point(100, 62);
            this.txtYetkiliKisi.Name = "txtYetkiliKisi";
            this.txtYetkiliKisi.Size = new System.Drawing.Size(150, 20);
            this.txtYetkiliKisi.TabIndex = 3;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(100, 102);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(150, 20);
            this.txtTelefon.TabIndex = 5;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(100, 142);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(150, 20);
            this.txtAdres.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(100, 182);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(100, 222);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(150, 30);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblFirmaAdi
            // 
            this.lblFirmaAdi.AutoSize = true;
            this.lblFirmaAdi.Location = new System.Drawing.Point(20, 25);
            this.lblFirmaAdi.Name = "lblFirmaAdi";
            this.lblFirmaAdi.Size = new System.Drawing.Size(53, 13);
            this.lblFirmaAdi.TabIndex = 0;
            this.lblFirmaAdi.Text = "Firma Adı:";
            // 
            // lblYetkiliKisi
            // 
            this.lblYetkiliKisi.AutoSize = true;
            this.lblYetkiliKisi.Location = new System.Drawing.Point(20, 65);
            this.lblYetkiliKisi.Name = "lblYetkiliKisi";
            this.lblYetkiliKisi.Size = new System.Drawing.Size(57, 13);
            this.lblYetkiliKisi.TabIndex = 2;
            this.lblYetkiliKisi.Text = "Yetkili Kişi:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(20, 105);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(46, 13);
            this.lblTelefon.TabIndex = 4;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(20, 145);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(37, 13);
            this.lblAdres.TabIndex = 6;
            this.lblAdres.Text = "Adres:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 185);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // FrmMusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.lblFirmaAdi);
            this.Controls.Add(this.txtFirmaAdi);
            this.Controls.Add(this.lblYetkiliKisi);
            this.Controls.Add(this.txtYetkiliKisi);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnEkle);
            this.Name = "FrmMusteriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Ekleme";
            this.Load += new System.EventHandler(this.FrmMusteriEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public System.Windows.Forms.TextBox txtFirmaAdi;
        public System.Windows.Forms.TextBox txtYetkiliKisi;
        public System.Windows.Forms.TextBox txtTelefon;
        public System.Windows.Forms.TextBox txtAdres;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblFirmaAdi;
        private System.Windows.Forms.Label lblYetkiliKisi;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblEmail;
    }
}