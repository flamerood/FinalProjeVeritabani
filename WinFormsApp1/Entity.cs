using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
   public class Satislar
    {

        public Guid SatisID { get; set; }
        public string Filmid { get; set; }
        public string Musteriid { get; set; }
        public string SatisFiyat { get; set; }
        
    }
    
    public class Musteriler
    {
        public Guid MusteriID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }

    }
    public class Filmler
    {
        public Guid FilmID { get; set; }
        public string Ad { get; set; }
        public string icerik { get; set; }
        public string oyuncular { get; set; }
        public string tur { get; set; }
        public string cikisyili { get; set; }
        public string yonetmen { get; set; }
        
    }
    public class Odemeler
    {
        public Guid OdemeID { get; set; }
        public string Filmid { get; set; }
        public string Musteriid { get; set; }
        public string Tutar { get; set; }
        public string Aciklama { get; set; }
        public string OdemeTuru { get; set; }
       
    }
}
