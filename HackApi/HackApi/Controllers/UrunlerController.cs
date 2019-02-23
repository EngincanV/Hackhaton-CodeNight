using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using HackApi.Classes;
using HackApi.Models;

namespace HackApi.Controllers
{
    public class UrunlerController : ApiController
    {
        Urun urun = new Urun();
   
        private HackhathonEntities1 db = new HackhathonEntities1();

        // GET: api/Urunler
        public IQueryable<tbl_Urunler> Gettbl_Urunler()
        {
            return db.tbl_Urunler;
        }

        // GET: api/Urunler/5
        [ResponseType(typeof(tbl_Urunler))]
        public IHttpActionResult Gettbl_Urunler(int id)
        {
            tbl_Urunler tbl_Urunler = db.tbl_Urunler.Find(id);
            if (tbl_Urunler == null)
            {
                return NotFound();
            }
            else
            {
                
                List<Urun> urunler = new List<Urun>();
                
                foreach (var item in db.tbl_Urunler.ToList())
                {
                    if (item.urunId == id)
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
                }

                return Ok(urunler);
               
                
                // return Ok(tbl_Urunler);
            }

            
        }

        // PUT: api/Urunler/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttbl_Urunler(int id, tbl_Urunler tbl_Urunler)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_Urunler.urunId)
            {
                return BadRequest();
            }

            db.Entry(tbl_Urunler).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tbl_UrunlerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Urunler
        [ResponseType(typeof(tbl_Urunler))]
        public IHttpActionResult Posttbl_Urunler(tbl_Urunler tbl_Urunler)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tbl_Urunler.Add(tbl_Urunler);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tbl_Urunler.urunId }, tbl_Urunler);
        }

        // DELETE: api/Urunler/5
        [ResponseType(typeof(tbl_Urunler))]
        public IHttpActionResult Deletetbl_Urunler(int id)
        {
            tbl_Urunler tbl_Urunler = db.tbl_Urunler.Find(id);
            if (tbl_Urunler == null)
            {
                return NotFound();
            }

            db.tbl_Urunler.Remove(tbl_Urunler);
            db.SaveChanges();

            return Ok(tbl_Urunler);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tbl_UrunlerExists(int id)
        {
            return db.tbl_Urunler.Count(e => e.urunId == id) > 0;
        }
    }
}