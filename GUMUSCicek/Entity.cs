using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUMUSCicek
{
    public class Musteri
    {
        public Guid ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }

        public override string ToString()
        {
            return $"{Ad} {Soyad}";
        }

    }
    public class Cicek
    {
        public Guid ID { get; set; }

        public string Ad { get; set; }
        public string Kategori { get; set; }
        public double Fiyat { get; set; }
        public double Stok { get; set; }
        public string Detay { get; set; }
    }
    public class Satis
    {
        public Guid ID { get; set; }
        public Guid Musteriid { get; set; }
        public Guid Cicekid { get; set; }
        public DateTime Tarih { get; set; }
        public double Fiyat { get; set; }
    }
    public class Ödeme

    {
        public Guid ID { get; set; }
        public Guid Musteriid { get; set; }
        public DateTime Tarih { get; set; }
        public double Tutar { get; set; }
        public string Tur { get; set; }
        public string Aciklama { get; set; }
        
    }
}
