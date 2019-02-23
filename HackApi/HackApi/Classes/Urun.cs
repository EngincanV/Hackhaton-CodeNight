using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HackApi.Classes
{
    public class Urun
    {
        public int urunId { get; set; }
        public string urunAd { get; set; }
        public Nullable<int> tipId { get; set; }
        public Nullable<int> uyeId { get; set; }
        public Nullable<bool> urunDurumu { get; set; }
        public Nullable<System.DateTime> eklenmeTarihi { get; set; }
        public Nullable<decimal> fiyat { get; set; }
        public Nullable<bool> aktifMi { get; set; }
    }
}