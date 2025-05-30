using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockTrackerV4
{
    public partial class FrmStokHareketleri : Form
    {
        public FrmStokHareketleri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=BERKAN\\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True");

        private void FrmStokHareketleri_Load(object sender, EventArgs e)
        {
            // Varsayılan olarak son 7 günü göster
            dtpBaslangic.Value = DateTime.Now.AddDays(-7);
            dtpBitis.Value = DateTime.Now;
            HareketleriListele();
        }

        private void HareketleriListele()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(@"
                    SELECT 
                        h.IslemTarihi as 'Tarih',
                        u.UrunAdi as 'Ürün',
                        h.HareketTipi as 'İşlem',
                        h.Miktar as 'Miktar',
                        m.FirmaAdi as 'Müşteri/Tedarikçi',
                        k.KullaniciAdi as 'Kullanıcı'
                    FROM StokHareketleri h
                    LEFT JOIN Urunler u ON h.UrunID = u.UrunID
                    LEFT JOIN Musteriler m ON h.MusteriID = m.MusteriID
                    LEFT JOIN Kullanicilar k ON h.KullaniciID = k.KullaniciID
                    WHERE h.IslemTarihi BETWEEN @BaslangicTarihi AND @BitisTarihi
                    ORDER BY h.IslemTarihi DESC", baglanti);

                komut.Parameters.AddWithValue("@BaslangicTarihi", dtpBaslangic.Value.Date);
                komut.Parameters.AddWithValue("@BitisTarihi", dtpBitis.Value.Date.AddDays(1).AddSeconds(-1));

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message);
                baglanti.Close();
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            if (dtpBitis.Value < dtpBaslangic.Value)
            {
                MessageBox.Show("Bitiş tarihi başlangıç tarihinden küçük olamaz!");
                return;
            }

            HareketleriListele();
        }
    }
}
