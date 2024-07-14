using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AnydeskEasyConnect
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private string? kullaniciAdi;
        private string? kullaniciParolasi;
        public static bool basariliGiris = false;

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
                        foundKullaniciAdi = reader.IsDBNull(0) ? "null" : reader.GetString(0);
                        foundKullaniciParolasi = reader.IsDBNull(1) ? "null" : reader.GetString(1);
                    }
                }
                sqlConnection.Close();

                if (foundKullaniciAdi == kullaniciAdi && foundKullaniciParolasi == kullaniciParolasi)
                {
                    basariliGiris = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (basariliGiris)
            {
                Application.Run(new MainScreen());
            }
        }
    }
}