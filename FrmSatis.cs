using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockTrackerV4
{
    public partial class FrmSatis : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=BERKAN\\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True");
        DataSet daset = new DataSet();

        public FrmSatis()
        {
            InitializeComponent();
        }

        private void FrmSatis_Load(object sender, EventArgs e)
        {
            SepetListele();
        }

        private void SepetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Sepet", baglanti);
            adtr.Fill(daset, "Sepet");
            dataGridView1.DataSource = daset.Tables["Sepet"];
            baglanti.Close();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            if (txtBarkodNo.Text == "")
            {
                txtMiktar.Text = "1";
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox && item != txtMiktar)
                    {
                        item.Text = "";
                    }
                }
            }

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Urunler where BarkodNo like '" + txtBarkodNo.Text + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    txtUrunAdi.Text = read["UrunAdi"].ToString();
                    cmbKategori.Text = read["Kategori"].ToString();
                    txtFiyat.Text = read["SatisFiyati"].ToString();
                }
                baglanti.Close();
            }
            catch (Exception)
            {
                baglanti.Close();
            }
        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtFiyat.Text) * double.Parse(txtMiktar.Text)).ToString();
            }
            catch (Exception)
            {
                ;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Sepet(BarkodNo,UrunAdi,Kategori,Miktar,SatisFiyati,ToplamFiyati) values(@BarkodNo,@UrunAdi,@Kategori,@Miktar,@SatisFiyati,@ToplamFiyati)", baglanti);
            komut.Parameters.AddWithValue("@BarkodNo", txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@UrunAdi", txtUrunAdi.Text);
            komut.Parameters.AddWithValue("@Kategori", cmbKategori.Text);
            komut.Parameters.AddWithValue("@Miktar", int.Parse(txtMiktar.Text));
            komut.Parameters.AddWithValue("@SatisFiyati", double.Parse(txtFiyat.Text));
            komut.Parameters.AddWithValue("@ToplamFiyati", double.Parse(txtToplamFiyat.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Ürün sepete eklendi");
            daset.Tables["Sepet"].Clear();
            SepetListele();
            Hesapla();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Sepet where BarkodNo='" + dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Ürün sepetten çıkarıldı");
            daset.Tables["Sepet"].Clear();
            SepetListele();
            Hesapla();
        }

        private void Hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(ToplamFiyati) from Sepet", baglanti);
                lblGenelToplam.Text = "Genel Toplam: " + komut.ExecuteScalar() + " TL";
                baglanti.Close();
            }
            catch (Exception)
            {
                baglanti.Close();
            }
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Satislar(BarkodNo,UrunAdi,Kategori,Miktar,SatisFiyati,ToplamFiyati,Tarih) values(@BarkodNo,@UrunAdi,@Kategori,@Miktar,@SatisFiyati,@ToplamFiyati,@Tarih)", baglanti);
                komut.Parameters.AddWithValue("@BarkodNo", dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString());
                komut.Parameters.AddWithValue("@UrunAdi", dataGridView1.Rows[i].Cells["UrunAdi"].Value.ToString());
                komut.Parameters.AddWithValue("@Kategori", dataGridView1.Rows[i].Cells["Kategori"].Value.ToString());
                komut.Parameters.AddWithValue("@Miktar", int.Parse(dataGridView1.Rows[i].Cells["Miktar"].Value.ToString()));
                komut.Parameters.AddWithValue("@SatisFiyati", double.Parse(dataGridView1.Rows[i].Cells["SatisFiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@ToplamFiyati", double.Parse(dataGridView1.Rows[i].Cells["ToplamFiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();

                // Stok azaltma
                SqlCommand komut2 = new SqlCommand("update Urunler set StokMiktari=StokMiktari-'" + int.Parse(dataGridView1.Rows[i].Cells["Miktar"].Value.ToString()) + "' where BarkodNo='" + dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString() + "'", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
            }

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from Sepet", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();

            daset.Tables["Sepet"].Clear();
            SepetListele();
            Hesapla();

            MessageBox.Show("Satış yapıldı");
        }
    }
}