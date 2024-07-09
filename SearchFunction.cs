using Microsoft.Data.SqlClient;

namespace AnydeskEasyConnect
{
    internal class SearchFunction
    {
        internal static void BindSearchData(DataGridView DataGrid, string sirketAdi)
        {
            BindingSource BindingSource = new()
            {
                DataSource = AramaSonucunuGetir(MainScreen.subeAdiylaAramaGirdisi, AnydeskDAO.CreateConnectionString(), sirketAdi)
            };
            DataGrid.DataSource = BindingSource;
        }
        private static List<Anydesks> AramaSonucunuGetir(string subeAdiylaAramaGirdisi, string connectionString, string sirketAdi)
        {
            List<Anydesks> returnThese = [];
            if (subeAdiylaAramaGirdisi != null)
            {
                subeAdiylaAramaGirdisi = subeAdiylaAramaGirdisi.Trim();
            }
            string searchQuery = $"SELECT SubeAdi,SubeAnydeskNumarasi,SubeAnydeskParolasi,BilgisayarYetkisi FROM {sirketAdi} WHERE SubeAdi LIKE '%{subeAdiylaAramaGirdisi}%'";
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

