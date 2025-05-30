using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockTrackerV4
{
    public partial class FrmStokHareket : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=BERKAN\\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True");

        public FrmStokHareket()
        {
            InitializeComponent();
        }

        public FrmStokHareket(string barkod, string urunAdi, int stok, decimal fiyat, string kategori)
            : this()
        {
            lblStok.Text = "Stok: " + stok.ToString();
            lblFiyat.Text = "Fiyat: " + fiyat.ToString("C2");
            lblKategori.Text = "Kategori: " + kategori;

            if (cmbUrun.Items.Contains(urunAdi))
            {
                cmbUrun.SelectedItem = urunAdi;
            }
        }

        private void FrmStokHareket_Load(object sender, EventArgs e)
        {
            UrunleriGetir();
            MusterileriGetir();
        }

        private void UrunleriGetir()
        {
            try
            {
                cmbUrun.Items.Clear();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM Urunler ORDER BY UrunAdi", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    cmbUrun.Items.Add(read["UrunAdi"].ToString());
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün listesi yüklenirken hata: " + ex.Message);
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void MusterileriGetir()
        {
            try
            {
                cmbMusteri.Items.Clear();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Musteriler", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    cmbMusteri.Items.Add(read["FirmaAdi"].ToString());
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri listesi yüklenirken hata: " + ex.Message);
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void cmbUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbUrun.SelectedIndex != -1)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("SELECT * FROM Urunler WHERE UrunAdi = @UrunAdi", baglanti);
                    komut.Parameters.AddWithValue("@UrunAdi", cmbUrun.Text);
                    SqlDataReader read = komut.ExecuteReader();

                    if (read.Read())
                    {
                        lblStok.Text = "Stok: " + read["StokMiktari"].ToString();
                        lblFiyat.Text = "Fiyat: " + Convert.ToDecimal(read["BirimFiyat"]).ToString("C2");
                        lblKategori.Text = "Kategori: " + read["Kategori"].ToString();
                    }
                    baglanti.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün bilgileri getirilirken hata: " + ex.Message);
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbUrun.SelectedIndex == -1 || cmbMusteri.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtMiktar.Text))
                {
                    MessageBox.Show("Lütfen ürün, miktar ve müşteri/tedarikçi seçin!");
                    return;
                }

                int miktar;
                if (!int.TryParse(txtMiktar.Text, out miktar) || miktar <= 0)
                {
                    MessageBox.Show("Geçerli bir miktar giriniz!");
                    return;
                }

                baglanti.Open();
                SqlCommand komut = new SqlCommand("update Urunler set StokMiktari = StokMiktari + @Miktar where UrunAdi = @UrunAdi", baglanti);
                komut.Parameters.AddWithValue("@Miktar", miktar);
                komut.Parameters.AddWithValue("@UrunAdi", cmbUrun.Text);
                komut.ExecuteNonQuery();

                // Hareket Kaydı
                SqlCommand komut2 = new SqlCommand(@"insert into StokHareketleri 
                    (UrunID, HareketTipi, Miktar, MusteriID, KullaniciID, IslemTarihi) 
                    values (
                    (select UrunID from Urunler where UrunAdi = @UrunAdi),
                    'Giris',
                    @Miktar,
                    (select MusteriID from Musteriler where FirmaAdi = @FirmaAdi),
                    (select KullaniciID from Kullanicilar where KullaniciAdi = @KullaniciAdi),
                    @Tarih)", baglanti);

                komut2.Parameters.AddWithValue("@UrunAdi", cmbUrun.Text);
                komut2.Parameters.AddWithValue("@Miktar", miktar);
                komut2.Parameters.AddWithValue("@FirmaAdi", cmbMusteri.Text);
                komut2.Parameters.AddWithValue("@KullaniciAdi", "Admin");
                komut2.Parameters.AddWithValue("@Tarih", DateTime.Now);
                komut2.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Stok girişi yapıldı");
                cmbUrun_SelectedIndexChanged(null, null); // Stok bilgisini güncelle
                txtMiktar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stok giriş hatası: " + ex.Message);
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbUrun.SelectedIndex == -1 || cmbMusteri.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtMiktar.Text))
                {
                    MessageBox.Show("Lütfen ürün, miktar ve müşteri/tedarikçi seçin!");
                    return;
                }

                int miktar;
                if (!int.TryParse(txtMiktar.Text, out miktar) || miktar <= 0)
                {
                    MessageBox.Show("Geçerli bir miktar giriniz!");
                    return;
                }

                baglanti.Open();
                // Stok yeterli mi kontrol et
                SqlCommand kontrolKomut = new SqlCommand("select StokMiktari from Urunler where UrunAdi = @UrunAdi", baglanti);
                kontrolKomut.Parameters.AddWithValue("@UrunAdi", cmbUrun.Text);
                int mevcutStok = Convert.ToInt32(kontrolKomut.ExecuteScalar());

                if (miktar > mevcutStok)
                {
                    MessageBox.Show("Stok yetersiz! Mevcut stok: " + mevcutStok);
                    baglanti.Close();
                    return;
                }

                // Stok Azalt
                SqlCommand komut = new SqlCommand("update Urunler set StokMiktari = StokMiktari - @Miktar where UrunAdi = @UrunAdi", baglanti);
                komut.Parameters.AddWithValue("@Miktar", miktar);
                komut.Parameters.AddWithValue("@UrunAdi", cmbUrun.Text);
                komut.ExecuteNonQuery();

                // Hareket Kaydı
                SqlCommand komut2 = new SqlCommand(@"insert into StokHareketleri 
                    (UrunID, HareketTipi, Miktar, MusteriID, KullaniciID, IslemTarihi) 
                    values (
                    (select UrunID from Urunler where UrunAdi = @UrunAdi),
                    'Cikis',
                    @Miktar,
                    (select MusteriID from Musteriler where FirmaAdi = @FirmaAdi),
                    (select KullaniciID from Kullanicilar where KullaniciAdi = @KullaniciAdi),
                    @Tarih)", baglanti);

                komut2.Parameters.AddWithValue("@UrunAdi", cmbUrun.Text);
                komut2.Parameters.AddWithValue("@Miktar", miktar);
                komut2.Parameters.AddWithValue("@FirmaAdi", cmbMusteri.Text);
                komut2.Parameters.AddWithValue("@KullaniciAdi", "Admin");
                komut2.Parameters.AddWithValue("@Tarih", DateTime.Now);
                komut2.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Stok çıkışı yapıldı");
                cmbUrun_SelectedIndexChanged(null, null); // Stok bilgisini güncelle
                txtMiktar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stok çıkış hatası: " + ex.Message);
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }
    }
}