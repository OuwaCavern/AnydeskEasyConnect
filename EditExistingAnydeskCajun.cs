using Microsoft.Data.SqlClient;

namespace AnydeskEasyConnect
{
    public partial class EditExistingAnydeskCajun : Form
    {
        public EditExistingAnydeskCajun()
        {
            InitializeComponent();
        }
        string? duzenlenenSubeAdi;
        string? duzenlenenAnydeskNumarasi;
        string? duzenlenenAnydeskParolasi;
        string? duzenlenenBilgisayarYetkisi;
        string? eskiAnydeskNumarasi;
        string? eskiAnydeskParolasi;
        internal void SatirinBilgileriniAl(string subeAdi, string anydeskNumarasi, string anydeskParolasi, string bilgisayarYetkisi)
        {
            AnydeskNumarasıGirdisi.Text = anydeskNumarasi;
            AnydeskParolasıGirdisi.Text = anydeskParolasi;
            ŞubeAdıGirdisi.Text = subeAdi;
            BilgisayarYetkisiComboBox.Text = bilgisayarYetkisi;

            duzenlenenAnydeskNumarasi = anydeskNumarasi;
            duzenlenenAnydeskParolasi = anydeskParolasi;
            duzenlenenSubeAdi = subeAdi;
            duzenlenenBilgisayarYetkisi = bilgisayarYetkisi;

            eskiAnydeskNumarasi = AnydeskNumarasıGirdisi.Text.Replace(" ", "");
            eskiAnydeskParolasi = AnydeskParolasıGirdisi.Text;
        }

        private void ŞubeAdıGirdisi_TextChanged(object sender, EventArgs e)
        {
            duzenlenenSubeAdi = ŞubeAdıGirdisi.Text;
        }

        private void AnydeskNumarasıGirdisi_TextChanged(object sender, EventArgs e)
        {
            duzenlenenAnydeskNumarasi = AnydeskNumarasıGirdisi.Text;
        }

        private void AnydeskParolasıGirdisi_TextChanged(object sender, EventArgs e)
        {
            duzenlenenAnydeskParolasi = AnydeskParolasıGirdisi.Text;
        }

        private void BilgisayarYetkisiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            duzenlenenBilgisayarYetkisi = BilgisayarYetkisiComboBox.Text;
        }

        private void KaydetButonu_Click(object sender, EventArgs e)
        {
            string connectionString = AnydeskDAO.CreateConnectionString();
            SqlConnection sqlConnection;
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            duzenlenenSubeAdi = duzenlenenSubeAdi switch
            {
                null => "null",
                _ => duzenlenenSubeAdi.Trim(),
            };
            if (duzenlenenSubeAdi.Length > 153)
            {
                MessageBox.Show("Girdiğiniz şube adı çok uzun! Lütfen kısaltınız.");
                return;
            }
            try
            {
                duzenlenenAnydeskNumarasi = duzenlenenAnydeskNumarasi switch
                {
                    null => "null",
                    _ => duzenlenenAnydeskNumarasi.Trim(),
                };
                duzenlenenAnydeskNumarasi = duzenlenenAnydeskNumarasi.Replace(" ", "");
                Int64.Parse(duzenlenenAnydeskNumarasi);
                if (duzenlenenAnydeskNumarasi.Length < 9 | duzenlenenAnydeskNumarasi.Length > 10)
                {
                    MessageBox.Show("Girdiğiniz anydesk numarası 9 veya 10 haneli değil\r\nLütfen yeniden kontrol ediniz.");
                    return;
                }
                else
                {
                    duzenlenenAnydeskNumarasi = Algorithms.AnydeskNumarasiDuzenleyici(duzenlenenAnydeskNumarasi);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Girdiğiniz anydesk numarası bir sayı değil.\r\n" + ex.Message);
                return;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Girdiğinizi anydesk numarası çok büyük.\r\nLütfen tekrar kontrol ediniz.\r\n" + ex.Message);
                return;
            }
            duzenlenenAnydeskParolasi = duzenlenenAnydeskParolasi switch
            {
                null => "null",
                _ => duzenlenenAnydeskParolasi.Trim(),
            };
            if (duzenlenenAnydeskParolasi != "DesenErp.12345" && duzenlenenAnydeskParolasi != eskiAnydeskParolasi)
            {
                DialogResult answerToQuestion = MessageBox.Show($"{duzenlenenAnydeskParolasi} şifresi normalde koyulan şifremizden farklı.\r\nBu şifreyi koymak istediğinize emin misiniz?", "Onaylıyor musunuz?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answerToQuestion == DialogResult.No)
                {
                    return;
                }
            }
            duzenlenenBilgisayarYetkisi = duzenlenenBilgisayarYetkisi switch
            {
                null => "null",
                _ => duzenlenenBilgisayarYetkisi.Trim(),
            };
            // Check if an Anydesk entry with the same number already exists in the database
            if (duzenlenenSubeAdi.Count() >= 8)
            {
                duzenlenenAnydeskNumarasi = duzenlenenAnydeskNumarasi.Replace(" ", "");
                if (eskiAnydeskNumarasi != duzenlenenAnydeskNumarasi)
                {
                    string duplicateAnydeskNo = "null";
                    string duplicateSubeAdi = "null";
                    string checkAnydeskNoCommand = $"SELECT SubeAnydeskNumarasi,SubeAdi FROM Cajun WHERE SubeAnydeskNumarasi='{Algorithms.AnydeskNumarasiDuzenleyici(duzenlenenAnydeskNumarasi)}'";
                    SqlCommand sqlCheckAnydeskNoCommand = new SqlCommand(checkAnydeskNoCommand, sqlConnection);
                    using (SqlDataReader reader = sqlCheckAnydeskNoCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            duplicateAnydeskNo = reader.GetString(0);
                            duplicateSubeAdi = reader.GetString(1);
                        }
                    }
                    if (duplicateAnydeskNo != "null")
                    {
                        MessageBox.Show($"Bu Anydesk numarasına ait bir girdi bulundu: {duplicateSubeAdi}. Lütfen numarayı yeniden kontrol edin veya uygulamada halihazırda bulunan girdiyi düzenleyin.");
                        return;
                    }
                    else if (duzenlenenSubeAdi.Count() >= 8)
                    {
                        duzenlenenAnydeskNumarasi = Algorithms.AnydeskNumarasiDuzenleyici(duzenlenenAnydeskNumarasi);
                        string updateQuery = $"UPDATE Cajun SET SubeAdi='{duzenlenenSubeAdi}',SubeAnydeskNumarasi='{duzenlenenAnydeskNumarasi}',SubeAnydeskParolasi='{duzenlenenAnydeskParolasi}',BilgisayarYetkisi='{duzenlenenBilgisayarYetkisi}' WHERE SubeAnydeskNumarasi='{Algorithms.AnydeskNumarasiDuzenleyici(eskiAnydeskNumarasi)}'";
                        SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                        updateCommand.ExecuteNonQuery();
                        MainScreen.CajunYenile();
                        sqlConnection.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"{duzenlenenSubeAdi} 8 karakterden daha küçük. Lütfen geçerli bir şube adı giriniz.");
                        return;
                    }
                }
                else
                {
                    duzenlenenAnydeskNumarasi = Algorithms.AnydeskNumarasiDuzenleyici(duzenlenenAnydeskNumarasi);
                    string updateQuery = $"UPDATE Cajun SET SubeAdi='{duzenlenenSubeAdi}',SubeAnydeskNumarasi='{duzenlenenAnydeskNumarasi}',SubeAnydeskParolasi='{duzenlenenAnydeskParolasi}',BilgisayarYetkisi='{duzenlenenBilgisayarYetkisi}' WHERE SubeAnydeskNumarasi='{Algorithms.AnydeskNumarasiDuzenleyici(eskiAnydeskNumarasi)}'";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                    updateCommand.ExecuteNonQuery();
                    MainScreen.CajunYenile();
                    sqlConnection.Close();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Şube adı en az 8 karakter olmalıdır. Lütfen geçerli bir şube adı giriniz.");
            }
        }
    }
}
