﻿using Microsoft.Data.SqlClient;
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
    public partial class EditExistingAnydeskKomagene : Form
    {
        public EditExistingAnydeskKomagene()
        {
            InitializeComponent();
        }
        string? duzenlenenSubeAdi;
        string? duzenlenenAnydeskNumarasi;
        string? duzenlenenAnydeskParolasi;
        string? duzenlenenBilgisayarYetkisi;
        string? eskiAnydeskNumarasi;
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

            eskiAnydeskNumarasi = AnydeskNumarasıGirdisi.Text;
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
            // Check if an Anydesk entry with the same number already exists in the database
            string duplicateAnydeskNo = "null";
            string duplicateSubeAdi = "null";
            string checkAnydeskNoCommand = $"SELECT SubeAnydeskNumarasi,SubeAdi FROM Komagene WHERE SubeAnydeskNumarasi='{duzenlenenAnydeskNumarasi}'";
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
            else
            {
                string updateQuery = $"UPDATE Komagene SET SubeAdi='{duzenlenenSubeAdi}',SubeAnydeskNumarasi='{duzenlenenAnydeskNumarasi}',SubeAnydeskParolasi='{duzenlenenAnydeskParolasi}',BilgisayarYetkisi='{duzenlenenBilgisayarYetkisi}' WHERE SubeAnydeskNumarasi='{eskiAnydeskNumarasi}'";
                SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                updateCommand.ExecuteNonQuery();
                sqlConnection.Close();
                this.Close();
            }
        }
    }
}