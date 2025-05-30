using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockTrackerV4
{
    public partial class FrmMusteriEkle : Form
    {
        public FrmMusteriEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=BERKAN\\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True");

        private void btnEkle_Click(object sender, EventArgs e)
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
                SqlCommand komut = new SqlCommand("insert into Musteriler(FirmaAdi,YetkiliKisi,Telefon,Email,Adres) values(@FirmaAdi,@YetkiliKisi,@Telefon,@Email,@Adres)", baglanti);
                komut.Parameters.AddWithValue("@FirmaAdi", txtFirmaAdi.Text);
                komut.Parameters.AddWithValue("@YetkiliKisi", txtYetkiliKisi.Text);
                komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@Email", txtEmail.Text);
                komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Müşteri kaydı eklendi");

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
                MessageBox.Show("Müşteri ekleme hatası: " + ex.Message);
                baglanti.Close();
            }
        }

        private void FrmMusteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}