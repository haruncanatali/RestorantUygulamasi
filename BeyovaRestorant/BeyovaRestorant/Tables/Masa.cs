using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyovaRestorant.Tables
{
    public class Masa
    {
        public int id { get; set; }
        public string masaKodu { get; set; }
        public string masaAdi { get; set; }

        public List<UrunHareket> hareketler { get; set; }
    }
}
