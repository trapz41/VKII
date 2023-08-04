using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;

namespace BLL
{
    public class HesaplamaBLL
    {
       
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\emirh\OneDrive\Masaüstü\UğraşDur\ProjeTaslak\KullaniciBilgileri.accdb;Persist Security Info=False;";
       
     
        public double VucutKitleEndeksiHesapla(double boy, double kilo)
        {
            double vucutKitleEndeksi = kilo / (boy * boy);
            return vucutKitleEndeksi;
        }

     
        public void KullaniciBilgileriniKaydet(string ad, string soyad, double boy, double kilo, double vucutKitleEndeksi)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("INSERT INTO KullaniciBilgileri (Ad, Soyad, Boy, Kilo, VucutKitleEndeksi) VALUES (@Ad, @Soyad, @Boy, @Kilo, @VucutKitleEndeksi)", connection);
                    command.Parameters.AddWithValue("@Ad", ad);
                    command.Parameters.AddWithValue("@Soyad", soyad);
                    command.Parameters.AddWithValue("@Boy", boy);
                    command.Parameters.AddWithValue("@Kilo", kilo);
                    command.Parameters.AddWithValue("@VucutKitleEndeksi", vucutKitleEndeksi);

                    command.ExecuteNonQuery();
                }
                catch (OleDbException ex)
                {
                  
                }
            }
        }

       
    }
}