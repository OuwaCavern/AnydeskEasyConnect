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

namespace AnydeskEasyConnect
{
    public partial class AddNewAnydeskKomagene : Form
    {
        public AddNewAnydeskKomagene()
        {
            InitializeComponent();
        }

        internal string? subeAdi;
        internal string? subeAnydeskNumarasi;
        internal string? subeAnydeskParolasi;
        internal string? subeBilgisayarYetkisi;
        public void ŞubeAdıGirdisi_TextChanged(object sender, EventArgs e)
        {
            subeAdi = ŞubeAdıGirdisi.Text;
        }
        public void AnydeskNumarasıGirdisi_TextChanged(object sender, EventArgs e)
        {
            subeAnydeskNumarasi = AnydeskNumarasıGirdisi.Text;
        }
        public void AnydeskParolasıGirdisi_TextChanged(object sender, EventArgs e)
        {
            subeAnydeskParolasi = AnydeskParolasıGirdisi.Text;
        }
        public void BilgisayarYetkisiComboBox_TextChanged(object sender, EventArgs e)
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
            string duplicateAnydeskNo = "";
            string checkAnydeskNoCommand = $"SELECT SubeAnydeskNumarasi FROM Komagene WHERE SubeAnydeskNumarasi='{subeAnydeskNumarasi}'";
            SqlCommand sqlCheckAnydeskNoCommand = new SqlCommand(checkAnydeskNoCommand, sqlConnection);
            using (SqlDataReader reader = sqlCheckAnydeskNoCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    duplicateAnydeskNo = reader.GetString(0);
                }
            }
            if (duplicateAnydeskNo != "null")
            {
                MessageBox.Show("Bu Anydesk numarasına ait bir girdi bulundu. Lütfen numarayı yeniden kontrol edin veya uygulamada halihazırda bulunan girdiyi düzenleyin.");
                return;
            }

            // Check the number of entries in the table in order to set the Id value of the newest entry.
            string countCommand = "SELECT COUNT(*) FROM Komagene";
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
            if (subeAnydeskNumarasi != null)
            {
                string insertCommand = $"INSERT INTO Komagene (Id,SubeAdi,SubeAnydeskNumarasi,SubeAnydeskParolasi,BilgisayarYetkisi) VALUES ({assignedId},'{subeAdi}','{subeAnydeskNumarasi}','{subeAnydeskParolasi}','{subeBilgisayarYetkisi}')";
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir AnydeskNumarası giriniz.");
            }
            sqlConnection.Close();
        }
    }
}
