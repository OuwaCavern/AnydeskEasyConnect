using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnydeskEasyConnect
{
    internal class SearchFunctionKomagene
    {
        public List<Anydesks> AramaSonucunuGetir()
        {
            public SearchFunctionKomagene(string subeAdiylaAramaGirdisi, string connectionString)
            {
                string searchQuery = $"SELECT SubeAdi FROM Komagene WHERE SubeAdi LIKE '%{subeAdiylaAramaGirdisi}%'";
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
                            };
                        }
                    }
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

