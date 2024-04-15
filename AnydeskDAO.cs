﻿using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

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
        public List<Anydesks> MaydonozAnydeskleriniGetir()
        {
            List<Anydesks> returnThese = new List<Anydesks>();
            try
            {
                ConnectionString = CreateConnectionString();
                string selectMaydonozAll = "SELECT SubeAdi,SubeAnydeskNumarasi,SubeAnydeskParolasi,BilgisayarYetkisi FROM Maydonoz";
                SqlConnection sqlConnection;
                sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(selectMaydonozAll, sqlConnection);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Anydesks a = new Anydesks
                        {
                            SubeAdi = reader.IsDBNull(0) ? "null" : reader.GetString(0),
                            SubeAnydeskNumarasi = reader.IsDBNull(1) ? "null" : reader.GetString(1),
                            SubeAnydeskParolasi = reader.IsDBNull(2) ? "null" : reader.GetString(2),
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
        public List<Anydesks> KomageneAnydeskleriniGetir()
        {
            List<Anydesks> returnThese = new List<Anydesks>();
            try
            {
                ConnectionString = CreateConnectionString();
                string selectMaydonozAll = "SELECT SubeAdi,SubeAnydeskNumarasi,SubeAnydeskParolasi,BilgisayarYetkisi FROM Komagene";
                SqlConnection sqlConnection;
                sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(selectMaydonozAll, sqlConnection);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Anydesks a = new Anydesks
                        {
                            SubeAdi = reader.IsDBNull(0) ? "null" : reader.GetString(0),
                            SubeAnydeskNumarasi = reader.IsDBNull(1) ? "null" : reader.GetString(1),
                            SubeAnydeskParolasi = reader.IsDBNull(2) ? "null" : reader.GetString(2),
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
        public List<Anydesks> KofteciYusufAnydeskleriniGetir()
        {
            List<Anydesks> returnThese = new List<Anydesks>();
            try
            {
                ConnectionString = CreateConnectionString();
                string selectMaydonozAll = "SELECT SubeAdi,SubeAnydeskNumarasi,SubeAnydeskParolasi,BilgisayarYetkisi FROM Kofteci";
                SqlConnection sqlConnection;
                sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(selectMaydonozAll, sqlConnection);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Anydesks a = new Anydesks
                        {
                            SubeAdi = reader.IsDBNull(0) ? "null" : reader.GetString(0),
                            SubeAnydeskNumarasi = reader.IsDBNull(1) ? "null" : reader.GetString(1),
                            SubeAnydeskParolasi = reader.IsDBNull(2) ? "null" : reader.GetString(2),
                            BilgisayarYetkisi = reader.IsDBNull(3) ? "null" : reader.GetString(3),
                        };
                        returnThese.Add(a);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return returnThese;
        }
        public List<Anydesks> CajunCornerAnydeskleriniGetir()
        {
            List<Anydesks> returnThese = new();
            try
            {
                ConnectionString = CreateConnectionString();
                string selectMaydonozAll = "SELECT SubeAdi,SubeAnydeskNumarasi,SubeAnydeskParolasi,BilgisayarYetkisi FROM Cajun";
                SqlConnection sqlConnection;
                sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(selectMaydonozAll, sqlConnection);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Anydesks a = new Anydesks
                        {
                            SubeAdi = reader.IsDBNull(0) ? "null" : reader.GetString(0),
                            SubeAnydeskNumarasi = reader.IsDBNull(1) ? "null" : reader.GetString(1),
                            SubeAnydeskParolasi = reader.IsDBNull(2) ? "null" : reader.GetString(2),
                            BilgisayarYetkisi = reader.IsDBNull(3) ? "null" : reader.GetString(3),
                        };
                        returnThese.Add(a);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return returnThese;
        }
        public List<Anydesks> HotDonerAnydeskleriniGetir()
        {
            List<Anydesks> returnThese = new List<Anydesks>();
            try
            {
                ConnectionString = CreateConnectionString();
                string selectMaydonozAll = "SELECT SubeAdi,SubeAnydeskNumarasi,SubeAnydeskParolasi,BilgisayarYetkisi FROM Hot";
                SqlConnection sqlConnection;
                sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(selectMaydonozAll, sqlConnection);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Anydesks a = new Anydesks
                        {
                            SubeAdi = reader.IsDBNull(0) ? "null" : reader.GetString(0),
                            SubeAnydeskNumarasi = reader.IsDBNull(1) ? "null" : reader.GetString(1),
                            SubeAnydeskParolasi = reader.IsDBNull(2) ? "null" : reader.GetString(2),
                            BilgisayarYetkisi = reader.IsDBNull(3) ? "null" : reader.GetString(3),
                        };
                        returnThese.Add(a);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return returnThese;
        }
        public List<Anydesks> BereketDonerAnydeskleriniGetir()
        {
            List<Anydesks> returnThese = new List<Anydesks>();
            try
            {
                ConnectionString = CreateConnectionString();
                string selectMaydonozAll = "SELECT SubeAdi,SubeAnydeskNumarasi,SubeAnydeskParolasi,BilgisayarYetkisi FROM Bereket";
                SqlConnection sqlConnection;
                sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(selectMaydonozAll, sqlConnection);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Anydesks a = new Anydesks
                        {
                            SubeAdi = reader.IsDBNull(0) ? "null" : reader.GetString(0),
                            SubeAnydeskNumarasi = reader.IsDBNull(1) ? "null" : reader.GetString(1),
                            SubeAnydeskParolasi = reader.IsDBNull(2) ? "null" : reader.GetString(2),
                            BilgisayarYetkisi = reader.IsDBNull(3) ? "null" : reader.GetString(3),
                        };
                        returnThese.Add(a);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return returnThese;
        }
        public List<Anydesks> AdileSultanAnydeskleriniGetir()
        {
            List<Anydesks> returnThese = new List<Anydesks>();
            try
            {
                ConnectionString = CreateConnectionString();
                string selectMaydonozAll = "SELECT SubeAdi,SubeAnydeskNumarasi,SubeAnydeskParolasi,BilgisayarYetkisi FROM Adile";
                SqlConnection sqlConnection;
                sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(selectMaydonozAll, sqlConnection);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Anydesks a = new Anydesks
                        {
                            SubeAdi = reader.IsDBNull(0) ? "null" : reader.GetString(0),
                            SubeAnydeskNumarasi = reader.IsDBNull(1) ? "null" : reader.GetString(1),
                            SubeAnydeskParolasi = reader.IsDBNull(2) ? "null" : reader.GetString(2),
                            BilgisayarYetkisi = reader.IsDBNull(3) ? "null" : reader.GetString(3),
                        };
                        returnThese.Add(a);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return returnThese;
        }
        public List<Anydesks> DigerAnydeskleriniGetir()
        {
            List<Anydesks> returnThese = new List<Anydesks>();
            try
            {
                ConnectionString = CreateConnectionString();
                string selectMaydonozAll = "SELECT SubeAdi,SubeAnydeskNumarasi,SubeAnydeskParolasi,BilgisayarYetkisi FROM Diger";
                SqlConnection sqlConnection;
                sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(selectMaydonozAll, sqlConnection);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Anydesks a = new Anydesks
                        {
                            SubeAdi = reader.IsDBNull(0) ? "null" : reader.GetString(0),
                            SubeAnydeskNumarasi = reader.IsDBNull(1) ? "null" : reader.GetString(1),
                            SubeAnydeskParolasi = reader.IsDBNull(2) ? "null" : reader.GetString(2),
                            BilgisayarYetkisi = reader.IsDBNull(3) ? "null" : reader.GetString(3),
                        };
                        returnThese.Add(a);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return returnThese;
        }
    }
}
