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

        public string? kullaniciAdi;
        public string? kullaniciParolasi;

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
            string selectQuery = $"SELECT * FROM UserBase WHERE KullaniciAdi='{PrivateHasher.ParolaSifreleyici(kullaniciAdi)}'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(selectQuery, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                List<Dictionary<string, object>> result = new();

                while (reader.Read())
                {
                    Dictionary<string, object> row = new();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row.Add(reader.GetName(i), reader.GetValue(i));
                    }

                    result.Add(row);
                }
            }
        }
    }
}