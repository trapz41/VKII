using EntityLayer;
using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;

namespace DAL
{
    public class KullaniciDAL
    {
  
        private string connectionString =  @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\emirh\OneDrive\Masaüstü\UğraşDur\ProjeTaslak\KullaniciBilgileri.accdb;Persist Security Info=False;";

    
        public void KullaniciEkle(KullaniciBilgileri kullanici)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("INSERT INTO KullaniciBilgileri (Ad, Soyad, Boy, Kilo, VucutKitleEndeksi) VALUES (@Ad, @Soyad, @Boy, @Kilo, @VucutKitleEndeksi)", connection);
                    command.Parameters.AddWithValue("@Ad", kullanici.Ad);
                    command.Parameters.AddWithValue("@Soyad", kullanici.Soyad);
                    command.Parameters.AddWithValue("@Boy", kullanici.Boy);
                    command.Parameters.AddWithValue("@Kilo", kullanici.Kilo);
                    command.Parameters.AddWithValue("@VucutKitleEndeksi", kullanici.VucutKitleEndeksi);

                    command.ExecuteNonQuery();
                }
                catch (OleDbException ex)
                {
                   
                }
            }
        }

        
        public List<EntityLayer.KullaniciBilgileri> TumKullanicilariGetir()
        {
            List<KullaniciBilgileri> kullaniciListesi = new List<KullaniciBilgileri>();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("SELECT * FROM KullaniciBilgileri", connection);
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        KullaniciBilgileri kullanici = new KullaniciBilgileri
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Ad = reader["Ad"].ToString(),
                            Soyad = reader["Soyad"].ToString(),
                            Boy = Convert.ToDouble(reader["Boy"]),
                            Kilo = Convert.ToDouble(reader["Kilo"]),
                            VucutKitleEndeksi = Convert.ToDouble(reader["VucutKitleEndeksi"])
                        };

                        kullaniciListesi.Add(kullanici);
                    }

                    reader.Close();
                }
                catch (OleDbException ex)
                {
                    
                }
            }

            return kullaniciListesi;
        }

        public void KullaniciSil(int kullaniciId)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("DELETE FROM KullaniciBilgileri WHERE ID = @ID", connection);
                    command.Parameters.AddWithValue("@ID", kullaniciId);

                    command.ExecuteNonQuery();
                }
                catch (OleDbException ex)
                {
                    
                }
            }
        }
       
    }
}