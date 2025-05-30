using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockTrackerV4
{
    public partial class FrmUrunListele : Form
    {
        public FrmUrunListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=BERKAN\\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True");
        DataSet daset = new DataSet();

        private void FrmUrunListele_Load(object sender, EventArgs e)
        {
            KategorileriGetir();
            UrunleriListele();
        }

        private void KategorileriGetir()
        {
            try
            {
                cmbKategori.Items.Clear();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select KategoriAdi from Kategoriler", baglanti);
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

        private void UrunleriListele()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from Urunler", baglanti);
                adtr.Fill(daset, "Urunler");
                dataGridView1.DataSource = daset.Tables["Urunler"];
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message);
                baglanti.Close();
            }
        }

        private void txtBarkodNoAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tablo = new DataTable();
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from Urunler where Barkod like '%" + txtBarkodNoAra.Text + "%'", baglanti);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama hatası: " + ex.Message);
                baglanti.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    txtUrunAdi.Text = dataGridView1.Rows[e.RowIndex].Cells["UrunAdi"].Value.ToString();
                    cmbKategori.Text = dataGridView1.Rows[e.RowIndex].Cells["Kategori"].Value.ToString();
                    txtMiktar.Text = dataGridView1.Rows[e.RowIndex].Cells["StokMiktari"].Value.ToString();
                    txtAlisFiyati.Text = dataGridView1.Rows[e.RowIndex].Cells["BirimFiyat"].Value.ToString();
                    txtSatisFiyati.Text = dataGridView1.Rows[e.RowIndex].Cells["BirimFiyat"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri seçme hatası: " + ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUrunAdi.Text))
                {
                    MessageBox.Show("Lütfen güncellenecek ürünü seçin!");
                    return;
                }

                baglanti.Open();
                SqlCommand komut = new SqlCommand("update Urunler set Kategori=@Kategori, UrunAdi=@UrunAdi, StokMiktari=@StokMiktari, BirimFiyat=@BirimFiyat where Barkod=@Barkod", baglanti);
                komut.Parameters.AddWithValue("@Kategori", cmbKategori.Text);
                komut.Parameters.AddWithValue("@UrunAdi", txtUrunAdi.Text);
                komut.Parameters.AddWithValue("@StokMiktari", int.Parse(txtMiktar.Text));
                komut.Parameters.AddWithValue("@BirimFiyat", double.Parse(txtAlisFiyati.Text));
                komut.Parameters.AddWithValue("@Barkod", dataGridView1.CurrentRow.Cells["Barkod"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();

                daset.Tables["Urunler"].Clear();
                UrunleriListele();
                MessageBox.Show("Ürün kaydı güncellendi");

                foreach (Control item in grpUrunGuncelle.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                cmbKategori.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message);
                baglanti.Close();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUrunAdi.Text))
                {
                    MessageBox.Show("Lütfen silinecek ürünü seçin!");
                    return;
                }

                if (MessageBox.Show("Seçili ürünü silmek istiyor musunuz?", "Uyarı",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("delete from Urunler where Barkod=@Barkod", baglanti);
                    komut.Parameters.AddWithValue("@Barkod", dataGridView1.CurrentRow.Cells["Barkod"].Value.ToString());
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    daset.Tables["Urunler"].Clear();
                    UrunleriListele();
                    MessageBox.Show("Ürün kaydı silindi");

                    foreach (Control item in grpUrunGuncelle.Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text = "";
                        }
                    }
                    cmbKategori.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatası: " + ex.Message);
                baglanti.Close();
            }
        }
    }
}