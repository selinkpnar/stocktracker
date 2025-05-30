using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockTrackerV4
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=BERKAN\\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True");
        DataSet daset = new DataSet();

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            StokDurumunuGuncelle();
            SonHareketleriListele();
            KritikStokKontrol();
        }

        private void StokDurumunuGuncelle()
        {
            try
            {
                baglanti.Open();
                // Toplam ürün sayısı
                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Urunler", baglanti);
                lblToplamUrun.Text = "Toplam Ürün: " + cmd1.ExecuteScalar().ToString();

                // Toplam stok miktarı
                SqlCommand cmd2 = new SqlCommand("SELECT SUM(StokMiktari) FROM Urunler", baglanti);
                var toplamStok = cmd2.ExecuteScalar();
                lblToplamStok.Text = "Toplam Stok: " + (toplamStok == DBNull.Value ? "0" : toplamStok.ToString());

                // Kritik stok sayısı
                SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) FROM Urunler WHERE StokMiktari <= MinimumStok", baglanti);
                lblKritikStok.Text = "Kritik Stok: " + cmd3.ExecuteScalar().ToString() + " ürün";

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stok durumu güncellenirken hata: " + ex.Message);
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void SonHareketleriListele()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter(@"
                    SELECT TOP 50
                        sh.IslemTarihi as 'Tarih',
                        u.UrunAdi as 'Ürün',
                        sh.HareketTipi as 'İşlem',
                        sh.Miktar as 'Miktar',
                        u.StokMiktari as 'Güncel Stok',
                        m.FirmaAdi as 'Firma'
                    FROM StokHareketleri sh
                    LEFT JOIN Urunler u ON sh.UrunID = u.UrunID
                    LEFT JOIN Musteriler m ON sh.MusteriID = m.MusteriID
                    ORDER BY sh.IslemTarihi DESC", baglanti);
                daset.Tables.Clear();
                adtr.Fill(daset, "StokHareketleri");
                dataGridView1.DataSource = daset.Tables["StokHareketleri"];
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stok hareketleri listelenirken hata: " + ex.Message);
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void KritikStokKontrol()
        {
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand(@"
                    SELECT UrunAdi, StokMiktari, MinimumStok 
                    FROM Urunler 
                    WHERE StokMiktari <= MinimumStok", baglanti);
                SqlDataReader reader = cmd.ExecuteReader();

                string kritikUrunler = "";
                while (reader.Read())
                {
                    kritikUrunler += $"{reader["UrunAdi"]} (Stok: {reader["StokMiktari"]}/{reader["MinimumStok"]})\n";
                }
                baglanti.Close();

                if (!string.IsNullOrEmpty(kritikUrunler))
                {
                    MessageBox.Show("Aşağıdaki ürünler kritik stok seviyesinde:\n\n" + kritikUrunler,
                        "Kritik Stok Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kritik stok kontrolü yapılırken hata: " + ex.Message);
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            FrmMusteriEkle frm = new FrmMusteriEkle();
            frm.ShowDialog();
        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            FrmMusteriListele frm = new FrmMusteriListele();
            frm.ShowDialog();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            FrmUrunEkle frm = new FrmUrunEkle();
            frm.ShowDialog();
            StokDurumunuGuncelle();
            SonHareketleriListele();
            KritikStokKontrol();
        }

        private void btnUrunListele_Click(object sender, EventArgs e)
        {
            FrmUrunListele frm = new FrmUrunListele();
            frm.ShowDialog();
            StokDurumunuGuncelle();
            SonHareketleriListele();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            FrmKategori frm = new FrmKategori();
            frm.ShowDialog();
        }

        private void btnStokHareketleri_Click(object sender, EventArgs e)
        {
            FrmStokHareketleri frm = new FrmStokHareketleri();
            frm.ShowDialog();
            StokDurumunuGuncelle();
            SonHareketleriListele();
        }

        private void btnStokHareket_Click(object sender, EventArgs e)
        {
            FrmStokHareket frm = new FrmStokHareket();
            frm.ShowDialog();
            StokDurumunuGuncelle();
            SonHareketleriListele();
            KritikStokKontrol();
        }
    }
}