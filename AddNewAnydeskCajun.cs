using Microsoft.Data.SqlClient;

namespace AnydeskEasyConnect
{
    public partial class AddNewAnydeskCajun : Form
    {
        public AddNewAnydeskCajun()
        {
            InitializeComponent();
        }

        internal string? subeAdi;
        internal string? subeAnydeskNumarasi;
        internal string? subeAnydeskParolasi;
        internal string? subeBilgisayarYetkisi;
        private void ŞubeAdıGirdisi_TextChanged(object sender, EventArgs e)
        {
            subeAdi = ŞubeAdıGirdisi.Text;
        }
        private void AnydeskNumarasıGirdisi_TextChanged(object sender, EventArgs e)
        {
            subeAnydeskNumarasi = AnydeskNumarasıGirdisi.Text;
        }
        private void AnydeskParolasıGirdisi_TextChanged(object sender, EventArgs e)
        {
            subeAnydeskParolasi = AnydeskParolasıGirdisi.Text;
        }
        private void BilgisayarYetkisiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            subeBilgisayarYetkisi = BilgisayarYetkisiComboBox.Text;
        }

        private void KaydetButonu_Click(object sender, EventArgs e)
        {
            string connectionString = AnydeskDAO.CreateConnectionString();
            SqlConnection sqlConnection;
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            // Check if an Anydesk entry with the same number already exists in the database
            string duplicateAnydeskNo = "null";
            string duplicateSubeAdi = "null";
            try
            {
                string formattedSubeAnydeskNumarasi = subeAnydeskNumarasi.ToString().Replace(" ", "");
                formattedSubeAnydeskNumarasi = Algorithms.AnydeskNumarasiDuzenleyici(formattedSubeAnydeskNumarasi);
                string checkAnydeskNoCommand = $"SELECT SubeAnydeskNumarasi,SubeAdi FROM Cajun WHERE SubeAnydeskNumarasi='{formattedSubeAnydeskNumarasi}'";
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
            }
            catch
            {
                MessageBox.Show("Lütfen geçerli bir Anydesk numarası giriniz.");
                return;
            }

            // Check the number of entries in the table in order to set the Id value of the newest entry.
            string countCommand = "SELECT COUNT(*) FROM Cajun";
            int countOfEntries = 0;
            SqlCommand sqlCountCommand = new SqlCommand(countCommand, sqlConnection);
            using (SqlDataReader reader = sqlCountCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    countOfEntries = reader.GetInt32(0);
                }
            }
            int assignedId = countOfEntries + 1;
            subeAdi = subeAdi switch
            {
                null => "null",
                _ => subeAdi.Trim(),
            };
            if (subeAdi.Length > 153)
            {
                MessageBox.Show("Girdiğiniz şube adı çok uzun! Lütfen kısaltınız.");
                return;
            }
            try
            {
                subeAnydeskNumarasi = subeAnydeskNumarasi switch
                {
                    null => "null",
                    _ => subeAnydeskNumarasi.Trim(),
                };
                subeAnydeskNumarasi = subeAnydeskNumarasi.Replace(" ", "");
                Int64.Parse(subeAnydeskNumarasi);
                if (subeAnydeskNumarasi.Length < 9 | subeAnydeskNumarasi.Length > 10)
                {
                    MessageBox.Show("Girdiğiniz anydesk numarası 9 veya 10 haneli değil\r\nLütfen yeniden kontrol ediniz.");
                    return;
                }
                else
                {
                    subeAnydeskNumarasi = Algorithms.AnydeskNumarasiDuzenleyici(subeAnydeskNumarasi);
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
            subeAnydeskParolasi = subeAnydeskParolasi switch
            {
                null => "null",
                _ => subeAnydeskParolasi.Trim(),
            };
            if (subeAnydeskParolasi.Length > 153)
            {
                MessageBox.Show("Girdiğiniz şube parolası çok uzun! Lütfen kısaltınız.");
                return;
            }
            if (subeAnydeskParolasi != "DesenErp.12345")
            {
                DialogResult answerToQuestion = MessageBox.Show($"{subeAnydeskParolasi} şifresi normalde koyulan şifremizden farklı.\r\nBu şifreyi koymak istediğinize emin misiniz?", "Onaylıyor musunuz?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answerToQuestion == DialogResult.No)
                {
                    return;
                }
            }
            subeBilgisayarYetkisi = subeBilgisayarYetkisi switch
            {
                null => "null",
                _ => subeBilgisayarYetkisi.Trim(),
            };
            if (subeAnydeskNumarasi != "null" & subeAdi.Count() >= 8)
            {
                string insertQuery = $"INSERT INTO Cajun (Id,SubeAdi,SubeAnydeskNumarasi,SubeAnydeskParolasi,BilgisayarYetkisi) VALUES ({assignedId},'{subeAdi}','{subeAnydeskNumarasi}','{subeAnydeskParolasi}','{subeBilgisayarYetkisi}')";
                SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                insertCommand.ExecuteNonQuery();
                MainScreen.CajunYenile();
                this.Close();
            }
            else
            {
                MessageBox.Show("Şube adı en az 8 karakter olmalıdır. Lütfen geçerli bir şube adı giriniz.");
            }
            sqlConnection.Close();
        }
    }
}
