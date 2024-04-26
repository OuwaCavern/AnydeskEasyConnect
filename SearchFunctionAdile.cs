using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnydeskEasyConnect
{
    internal class SearchFunctionAdile
    {
        internal static void BindSearchData(DataGridView AdileDataGrid)
        {
            BindingSource AdileBindingSource = new()
            {
                DataSource = AramaSonucunuGetir(MainScreen.subeAdiylaAramaGirdisi, AnydeskDAO.CreateConnectionString())
            };
            AdileDataGrid.DataSource = AdileBindingSource;
        }
        private static List<Anydesks> AramaSonucunuGetir(string subeAdiylaAramaGirdisi, string connectionString)
        {
            List<Anydesks> returnThese = [];
            if (subeAdiylaAramaGirdisi != null)
            {
                subeAdiylaAramaGirdisi = subeAdiylaAramaGirdisi.Trim();
            }
            string searchQuery = $"SELECT SubeAdi,SubeAnydeskNumarasi,SubeAnydeskParolasi,BilgisayarYetkisi FROM Adile WHERE SubeAdi LIKE '%{subeAdiylaAramaGirdisi}%'";
            try
            {
                SqlConnection sqlConnection;
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(searchQuery, sqlConnection);
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
                        };
                        returnThese.Add(a);
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

