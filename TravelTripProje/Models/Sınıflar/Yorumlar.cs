using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Sınıflar
{
    public class Yorumlar
    {
        public int ID { get; set; }
        public String KullaniciAdi { get; set; }
        public string Mail  { get; set; }
        public string Yorum  { get; set; }
        public Blog Blog { get; set; }
       
        

    }
}