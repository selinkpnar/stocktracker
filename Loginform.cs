using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockTrackerV4
{
    public partial class LoginForm : Form
    {
        // SQL bağlantısı (sunucu ismi ve veritabanı ayarına dikkat et)
        SqlConnection baglanti = new SqlConnection("Data Source=BERKAN\\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True");

        public LoginForm()
        {
            InitializeComponent();
        }

        // Giriş butonu tıklama olayı
        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Kullanicilar WHERE KullaniciAdi=@kullaniciAdi AND Sifre=@sifre", baglanti);
                cmd.Parameters.AddWithValue("@kullaniciAdi", txtKullaniciAdi.Text);
                cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read()) // Kullanıcı doğrulandıysa
                {
                    MessageBox.Show("Giriş Başarılı!");
                    FrmAnaSayfa anaForm = new FrmAnaSayfa(); // Ana form oluşturuluyor
                    this.Hide(); // LoginForm'u gizle
                    anaForm.ShowDialog(); // Ana formu modal aç
                    this.Show(); // Ana form kapandığında LoginForm tekrar görünür
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!");
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                baglanti.Close();
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

