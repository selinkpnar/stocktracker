using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockTrackerV4
{
    public partial class FrmUrunEkle : Form
    {
        public FrmUrunEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=BERKAN\\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True");

        private void FrmUrunEkle_Load(object sender, EventArgs e)
        {
            KategorileriGetir();
            txtYeniMiktar.Text = "0";
            txtVarOlanMiktar.Text = "1";
        }

        private void KategorileriGetir()
        {
            try
            {
                cmbKategori.Items.Clear();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT KategoriAdi FROM Kategoriler ORDER BY KategoriAdi", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    cmbKategori.Items.Add(read["KategoriAdi"].ToString());
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategori getirme hatası: " + ex.Message);
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void txtVarOlanBarkodNo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVarOlanBarkodNo.Text))
            {
                txtVarOlanMiktar.Text = "1";
                return;
            }

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM Urunler WHERE Barkod = @BarkodNo", baglanti);
                komut.Parameters.AddWithValue("@BarkodNo", txtVarOlanBarkodNo.Text);
                SqlDataReader read = komut.ExecuteReader();

                if (read.Read())
                {
                    txtVarOlanMiktar.Text = "1";
                }
                else
                {
                    txtVarOlanMiktar.Clear();
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Barkod arama hatası: " + ex.Message);
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtYeniBarkodNo.Text) ||
                    string.IsNullOrWhiteSpace(txtYeniUrunAdi.Text) ||
                    string.IsNullOrWhiteSpace(txtYeniMiktar.Text) ||
                    string.IsNullOrWhiteSpace(txtYeniAlisFiyati.Text) ||
                    string.IsNullOrWhiteSpace(txtYeniSatisFiyati.Text) ||
                    cmbKategori.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun!");
                    return;
                }

                // Barkod no kontrolü
                baglanti.Open();
                SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM Urunler WHERE Barkod = @Barkod", baglanti);
                kontrolKomut.Parameters.AddWithValue("@Barkod", txtYeniBarkodNo.Text);
                int barkodSayisi = Convert.ToInt32(kontrolKomut.ExecuteScalar());
                baglanti.Close();

                if (barkodSayisi > 0)
                {
                    MessageBox.Show("Bu barkod numarası zaten kullanılıyor!");
                    return;
                }

                baglanti.Open();
                SqlCommand komut = new SqlCommand(@"INSERT INTO Urunler
                    (Barkod, Kategori, UrunAdi, StokMiktari, BirimFiyat, MinimumStok, KategoriID) 
                    VALUES (@Barkod, @Kategori, @UrunAdi, @StokMiktari, @BirimFiyat, @MinimumStok,
                    (SELECT KategoriID FROM Kategoriler WHERE KategoriAdi = @Kategori))", baglanti);

                komut.Parameters.AddWithValue("@Barkod", txtYeniBarkodNo.Text);
                komut.Parameters.AddWithValue("@Kategori", cmbKategori.Text);
                komut.Parameters.AddWithValue("@UrunAdi", txtYeniUrunAdi.Text);
                komut.Parameters.AddWithValue("@StokMiktari", int.Parse(txtYeniMiktar.Text));
                komut.Parameters.AddWithValue("@BirimFiyat", decimal.Parse(txtYeniSatisFiyati.Text));
                komut.Parameters.AddWithValue("@MinimumStok", 10); // Varsayılan minimum stok

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Yeni ürün başarıyla eklendi");

                foreach (Control item in grpYeniUrun.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                cmbKategori.SelectedIndex = -1;
                txtYeniMiktar.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yeni ürün ekleme hatası: " + ex.Message);
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void btnVarOlanEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtVarOlanBarkodNo.Text) || string.IsNullOrWhiteSpace(txtVarOlanMiktar.Text))
                {
                    MessageBox.Show("Lütfen barkod no ve miktar girin!");
                    return;
                }

                baglanti.Open();
                // Önce ürünün var olduğunu kontrol et
                SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM Urunler WHERE Barkod = @BarkodNo", baglanti);
                kontrolKomut.Parameters.AddWithValue("@BarkodNo", txtVarOlanBarkodNo.Text);
                int urunSayisi = Convert.ToInt32(kontrolKomut.ExecuteScalar());

                if (urunSayisi == 0)
                {
                    MessageBox.Show("Bu barkod numarasına sahip ürün bulunamadı!");
                    baglanti.Close();
                    return;
                }

                SqlCommand komut = new SqlCommand("UPDATE Urunler SET StokMiktari = StokMiktari + @Miktar WHERE Barkod = @BarkodNo", baglanti);
                komut.Parameters.AddWithValue("@BarkodNo", txtVarOlanBarkodNo.Text);
                komut.Parameters.AddWithValue("@Miktar", int.Parse(txtVarOlanMiktar.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Var olan ürüne stok eklendi");
                txtVarOlanBarkodNo.Clear();
                txtVarOlanMiktar.Text = "1";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stok ekleme hatası: " + ex.Message);
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        // Sayısal kontroller
        private void txtYeniMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtYeniAlisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void txtYeniSatisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void txtVarOlanMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}