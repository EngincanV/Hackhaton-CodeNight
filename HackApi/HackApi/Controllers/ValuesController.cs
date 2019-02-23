using HackApi.Classes;
using HackApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HackApi.Controllers
{
    public class ValuesController : ApiController
    {
        Uye uye = new Uye();
        Urun urun = new Urun();
        HackhathonEntities1 abc = new HackhathonEntities1();
        // GET api/values
        public IEnumerable<Urun> GetUrunler()
        {
            //Urun urun = new Urun();
            List<Urun> urunler = new List<Urun>();
            foreach (var item in abc.tbl_Urunler.ToList())
            {
                
                urun.urunId = item.urunId;
                urun.urunAd = item.urunAd;
                urun.aktifMi = item.aktifMi;
                urun.eklenmeTarihi = item.eklenmeTarihi;
                urun.fiyat = item.fiyat;
                urun.tipId = item.tipId;
                urun.urunDurumu = item.urunDurumu;
                urun.uyeId = item.uyeId;
                urunler.Add(urun);  
            }

            return urunler;
        }
        public IEnumerable<Uye> GetUye()
        {
            List<Uye> uyeler = new List<Uye>();
            foreach (var item in abc.tbl_Uyeler.ToList())
            {
                
                uye.Ad = item.Ad;
                uye.boylam = item.boylam;
                uye.DogumTarihi = item.DogumTarihi;
                uye.enlem = item.enlem;
                uye.sifre = item.sifre;
                uye.Soyad = item.Soyad;
                uye.uyeID = item.uyeID;
                
                uyeler.Add(uye);
            }

            return uyeler;
        }
        public IEnumerable<tbl_Urunler> urunEkle(tbl_Urunler _Urunler)
        {
            List<tbl_Urunler> uruns = new List<tbl_Urunler>();
            foreach (var item in abc.tbl_Urunler.ToList())
            {

                

                //uruns.Add();
            }

            return uruns;
        }

        public void urunEkle()
        {
            tbl_Urunler uruntbl = new tbl_Urunler();
            uruntbl.aktifMi = urun.aktifMi;
            uruntbl.eklenmeTarihi = urun.eklenmeTarihi;
            uruntbl.fiyat = urun.fiyat;
            uruntbl.urunAd = urun.urunAd;
            uruntbl.urunDurumu = urun.urunDurumu;
            uruntbl.urunId = urun.urunId;
            uruntbl.uyeId = urun.uyeId;
        }



        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
