using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EntityLayer
{
    public class KullaniciBilgileri
    {
        public override string ToString()
        {
            return $"{Ad.PadRight(10)} {Soyad.PadRight(10)} {Boy.ToString().PadRight(10)} {Kilo.ToString().PadRight(10)}  {VucutKitleEndeksi.ToString("F2").PadRight(7)}";
        }
        public double VucutKitleEndeksiDouble => Convert.ToDouble(VucutKitleEndeksi);
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public double Boy { get; set; }
        public double Kilo { get; set; }
        public double VucutKitleEndeksi { get; set; }
    }

}

