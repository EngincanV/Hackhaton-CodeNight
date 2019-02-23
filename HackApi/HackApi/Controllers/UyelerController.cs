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
    public class UyelerController : ApiController
    {
        Uye uye = new Uye();
        private HackhathonEntities1 db = new HackhathonEntities1();

        // GET: api/Uyeler
        public IQueryable<tbl_Uyeler> Gettbl_Uyeler()
        {

            return db.tbl_Uyeler;
        }

        // GET: api/Uyeler/5
        [ResponseType(typeof(tbl_Uyeler))]
        public IHttpActionResult Gettbl_Uyeler(int id)
        {
            tbl_Uyeler tbl_Uyeler = db.tbl_Uyeler.Find(id);
            if (tbl_Uyeler == null)
            {
                return NotFound();
            }
            else
            {
                List<Uye> uyeler = new List<Uye>();
                foreach (var item in db.tbl_Uyeler.ToList())
                {
                    if (item.uyeID == id)
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
                }

                return Ok(uyeler);
            }

            //return Ok(tbl_Uyeler);
        }

        // PUT: api/Uyeler/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttbl_Uyeler(int id, tbl_Uyeler tbl_Uyeler)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_Uyeler.uyeID)
            {
                return BadRequest();
            }

            db.Entry(tbl_Uyeler).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tbl_UyelerExists(id))
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

        // POST: api/Uyeler
        [ResponseType(typeof(tbl_Uyeler))]
        public IHttpActionResult Posttbl_Uyeler(tbl_Uyeler tbl_Uyeler)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tbl_Uyeler.Add(tbl_Uyeler);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tbl_Uyeler.uyeID }, tbl_Uyeler);
        }

        // DELETE: api/Uyeler/5
        [ResponseType(typeof(tbl_Uyeler))]
        public IHttpActionResult Deletetbl_Uyeler(int id)
        {
            tbl_Uyeler tbl_Uyeler = db.tbl_Uyeler.Find(id);
            if (tbl_Uyeler == null)
            {
                return NotFound();
            }

            db.tbl_Uyeler.Remove(tbl_Uyeler);
            db.SaveChanges();

            return Ok(tbl_Uyeler);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tbl_UyelerExists(int id)
        {
            return db.tbl_Uyeler.Count(e => e.uyeID == id) > 0;
        }
    }
}