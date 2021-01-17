using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyovaRestorant.Tables
{
    public class Urun
    {
        public int id { get; set; }
        public string urunKodu { get; set; }
        public string urunAd { get; set; }
        public string urunBirim { get; set; }
        public double fiyat { get; set; }
    }
}
