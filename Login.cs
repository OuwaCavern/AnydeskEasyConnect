using Microsoft.Data.SqlClient;

namespace AnydeskEasyConnect
{
    public partial class Login : Form
    {
        private Size formOriginalSize;
        private Rectangle recKullaniciParolasiGirdisi;
        private Rectangle recKullaniciAdiGirdisi;
        private Rectangle recKullaniciAdiLabel;
        private Rectangle recKullaniciParolasiLabel;
        private Rectangle recGirisYapButonu;
        public Login()
        {
            InitializeComponent();
            this.Resize += Login_Resiz;
            formOriginalSize = this.Size;
            recKullaniciParolasiGirdisi = new Rectangle(KullaniciParolasiGirdisi.Location, KullaniciParolasiGirdisi.Size);
            recKullaniciAdiGirdisi = new Rectangle(KullaniciAdiGirdisi.Location, KullaniciAdiGirdisi.Size);
            recKullaniciAdiLabel = new Rectangle(KullaniciAdiLabel.Location, KullaniciAdiLabel.Size);
            recKullaniciParolasiLabel = new Rectangle(KullaniciParolasiLabel.Location, KullaniciParolasiLabel.Size);
            recGirisYapButonu = new Rectangle(GirisYapButonu.Location, GirisYapButonu.Size);
        }
        private void Login_Resiz(object sender, EventArgs e)
        {
            ResizeControl(KullaniciParolasiGirdisi, recKullaniciParolasiGirdisi);
            ResizeControl(KullaniciAdiGirdisi, recKullaniciAdiGirdisi);
            ResizeControl(KullaniciAdiLabel, recKullaniciAdiLabel);
            ResizeControl(KullaniciParolasiLabel, recKullaniciParolasiLabel);
            ResizeControl(GirisYapButonu, recGirisYapButonu);
        }
        private void ResizeControl(Control control, Rectangle rect)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(rect.X * xRatio);
            int newY = (int)(rect.Y * yRatio);

            int newWidth = (int)(rect.Width * xRatio);
            int newHeight = (int)(rect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }

        private string? kullaniciAdi;
        private string? kullaniciParolasi;

        private void KullaniciAdiGirdisi_TextChanged(object sender, EventArgs e)
        {
            kullaniciAdi = KullaniciAdiGirdisi.Text;
        }

        private void KullaniciParolasiGirdisi_TextChanged(object sender, EventArgs e)
        {
            kullaniciParolasi = KullaniciParolasiGirdisi.Text;
        }

        private void GirisYapButonu_Click(object sender, EventArgs e)
        {
            string connectionString = AnydeskDAO.CreateConnectionString();

            try
            {
                kullaniciAdi = kullaniciAdi.Trim();
                kullaniciParolasi = kullaniciParolasi.Trim();

                string ConnectionString = AnydeskDAO.CreateConnectionString();
                string selectQuery = $"SELECT * FROM UserBase WHERE KullaniciAdi='{PrivateHasher.ParolaSifreleyici(kullaniciAdi)}'";

                string foundKullaniciAdi = "";
                string foundKullaniciParolasi = "";

                SqlConnection sqlConnection;
                sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(selectQuery, sqlConnection);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        foundKullaniciAdi = reader.IsDBNull(0) ? "null" : reader.GetString(1);
                        foundKullaniciParolasi = reader.IsDBNull(1) ? "null" : reader.GetString(2);
                    }
                }
                sqlConnection.Close();

                if (PrivateHasher.ParolaGeriCevirici(foundKullaniciAdi) == kullaniciAdi && foundKullaniciParolasi == kullaniciParolasi)
                {
                    Program.BasariliGirisiAyarla(true);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(text:$"{kullaniciAdi} ile uygulamaya giriş yapılamadı. Lütfen kullanıcı adınızı ve şifrenizi kontrol edip yeniden deneyiniz.", caption:"Giriş yapılamadı",buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}