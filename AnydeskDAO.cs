using System.Configuration;
using Microsoft.Data.SqlClient;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace AnydeskEasyConnect
{
    public class AnydeskDAO
    {
        private string ConnectionString = "";

        public static string CreateConnectionString()
        {
            try
            {
                ExeConfigurationFileMap fileMapping = new ExeConfigurationFileMap
                {
                    ExeConfigFilename = Path.Combine(Application.StartupPath, "App.config")
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

        public SortableBindingList<Anydesks> AnydeskleriGetir(string sirketAdi)
        {
            List<Anydesks> listOfAnydesks = new();
            SortableBindingList<Anydesks> returnThese = new SortableBindingList<Anydesks>(listOfAnydesks);
            try
            {
                ConnectionString = CreateConnectionString();
                string selectQuery = $"SELECT TOP 1000 SubeAdi,SubeAnydeskNumarasi,SubeAnydeskParolasi,BilgisayarYetkisi,OlusturulduguTarih FROM {sirketAdi}";
                SqlConnection sqlConnection;
                sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(selectQuery, sqlConnection);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Anydesks a = new Anydesks
                        {
                            ŞubeninAdı = reader.IsDBNull(0) ? "null" : reader.GetString(0),
                            ŞubeninAnydeskNumarası = reader.IsDBNull(1) ? "null" : reader.GetString(1),
                            ŞubeninAnydeskParolası = reader.IsDBNull(2) ? "null" : reader.GetString(2),
                            BilgisayarYetkisi = reader.IsDBNull(3) ? "null" : reader.GetString(3),
                            OluşturulduğuTarih = reader.IsDBNull(4) ? DateTime.MinValue : reader.GetDateTime(4),
                        };
                        listOfAnydesks.Add(a);
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return returnThese;
        }
    }
}

