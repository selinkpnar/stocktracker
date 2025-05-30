using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockTrackerV4
{
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=BERKAN\\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True");

        private void FrmKategori_Load(object sender, EventArgs e)
        {
            KategorileriListele();
        }

        private void KategorileriListele()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM Kategoriler ORDER BY KategoriAdi", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                listBox1.Items.Clear();
                while (read.Read())
                {
                    listBox1.Items.Add(read["KategoriAdi"].ToString());
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategori listeleme hatası: " + ex.Message);
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKategori.Text))
            {
                MessageBox.Show("Lütfen bir kategori adı girin!");
                return;
            }

            try
            {
                baglanti.Open();
                // Önce bu kategorinin var olup olmadığını kontrol et
                SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM Kategoriler WHERE KategoriAdi = @KategoriAdi", baglanti);
                kontrolKomut.Parameters.AddWithValue("@KategoriAdi", txtKategori.Text.Trim());
                int kategoriSayisi = (int)kontrolKomut.ExecuteScalar();

                if (kategoriSayisi > 0)
                {
                    MessageBox.Show("Bu kategori zaten mevcut!");
                    baglanti.Close();
                    return;
                }

                // Kategori yoksa ekle
                SqlCommand komut = new SqlCommand("INSERT INTO Kategoriler (KategoriAdi) VALUES (@KategoriAdi)", baglanti);
                komut.Parameters.AddWithValue("@KategoriAdi", txtKategori.Text.Trim());
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kategori başarıyla eklendi");
                KategorileriListele();
                txtKategori.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategori ekleme hatası: " + ex.Message);
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen silinecek kategoriyi seçin!");
                return;
            }

            try
            {
                string secilenKategori = listBox1.SelectedItem.ToString();

                if (MessageBox.Show($"{secilenKategori} kategorisini silmek istediğinize emin misiniz?",
                    "Kategori Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("DELETE FROM Kategoriler WHERE KategoriAdi = @KategoriAdi", baglanti);
                    komut.Parameters.AddWithValue("@KategoriAdi", secilenKategori);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Kategori başarıyla silindi");
                    KategorileriListele();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategori silme hatası: " + ex.Message);
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }
    }
}