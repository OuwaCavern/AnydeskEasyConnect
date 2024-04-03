using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace AnydeskEasyConnect
{
    internal class AnydeskDAO
    {
        private string ConnectionString = "";

        static string CreateConnectionString()
        {
            try
            {
                ExeConfigurationFileMap fileMapping = new ExeConfigurationFileMap
                {
                    ExeConfigFilename = @"C:\Users\emirc\source\repos\AnydeskEasyConnect\connectionstring.config"
                };
                Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMapping, ConfigurationUserLevel.None);
                return configuration.AppSettings.Settings["baglanti"].Value;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }
        public List<Anydesks> MaydonozSiparisleriniGetir()
        {
            List<Anydesks> returnThese = new List<Anydesks>();
            try
            {
                ConnectionString = CreateConnectionString();
                string selectMaydonozAll = "SELECT SubeAdi,SubeAnydeskNumarasi,SubeAnydeskParolasi,BilgisayarYetkisi,OnlineStatus FROM Maydonoz";
                SqlConnection sqlConnection;
                sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(selectMaydonozAll, sqlConnection);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {

                }

            }
        }

    }
}
