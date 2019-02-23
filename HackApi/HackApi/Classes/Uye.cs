using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HackApi.Classes
{
    public class Uye
    {
        public int uyeID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public System.DateTime DogumTarihi { get; set; }
        public Nullable<decimal> enlem { get; set; }
        public Nullable<decimal> boylam { get; set; }
        public string sifre { get; set; }
    }
}