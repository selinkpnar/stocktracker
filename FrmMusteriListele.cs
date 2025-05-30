using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockTrackerV4
{
    public partial class FrmMusteriListele : Form
    {
        public FrmMusteriListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=BERKAN\\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True");
        DataSet daset = new DataSet();

        private void FrmMusteriListele_Load(object sender, EventArgs e)
        {
            MusterileriListele();
        }

        private void MusterileriListele()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from Musteriler", baglanti);
                adtr.Fill(daset, "Musteriler");
                dataGridView1.DataSource = daset.Tables["Musteriler"];
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message);
                baglanti.Close();
            }
        }

        private void txtFirmaAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tablo = new DataTable();
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from Musteriler where FirmaAdi like @FirmaAdi", baglanti);
                adtr.SelectCommand.Parameters.AddWithValue("@FirmaAdi", "%" + txtFirmaAra.Text + "%");
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
                    txtFirmaAdi.Text = dataGridView1.Rows[e.RowIndex].Cells["FirmaAdi"].Value?.ToString();
                    txtYetkiliKisi.Text = dataGridView1.Rows[e.RowIndex].Cells["YetkiliKisi"].Value?.ToString();
                    txtTelefon.Text = dataGridView1.Rows[e.RowIndex].Cells["Telefon"].Value?.ToString();
                    txtAdres.Text = dataGridView1.Rows[e.RowIndex].Cells["Adres"].Value?.ToString();
                    txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value?.ToString();
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
                if (string.IsNullOrWhiteSpace(txtFirmaAdi.Text) ||
                    string.IsNullOrWhiteSpace(txtYetkiliKisi.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefon.Text))
                {
                    MessageBox.Show("Firma Adı, Yetkili Kişi ve Telefon alanları zorunludur!");
                    return;
                }

                baglanti.Open();
                SqlCommand komut = new SqlCommand("update Musteriler set YetkiliKisi=@YetkiliKisi, Telefon=@Telefon, Adres=@Adres, Email=@Email where FirmaAdi=@FirmaAdi", baglanti);
                komut.Parameters.AddWithValue("@FirmaAdi", txtFirmaAdi.Text);
                komut.Parameters.AddWithValue("@YetkiliKisi", txtYetkiliKisi.Text);
                komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
                komut.Parameters.AddWithValue("@Email", txtEmail.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                daset.Tables["Musteriler"].Clear();
                MusterileriListele();
                MessageBox.Show("Müşteri kaydı güncellendi");

                // Formu temizle
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
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
                if (string.IsNullOrWhiteSpace(txtFirmaAdi.Text))
                {
                    MessageBox.Show("Lütfen silinecek müşteriyi seçin!");
                    return;
                }

                if (MessageBox.Show("Bu müşteriyi silmek istediğinize emin misiniz?", "Silme Onayı",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("delete from Musteriler where FirmaAdi=@FirmaAdi", baglanti);
                    komut.Parameters.AddWithValue("@FirmaAdi", txtFirmaAdi.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    daset.Tables["Musteriler"].Clear();
                    MusterileriListele();
                    MessageBox.Show("Müşteri kaydı silindi");

                    // Formu temizle
                    foreach (Control item in this.Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text = "";
                        }
                    }
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