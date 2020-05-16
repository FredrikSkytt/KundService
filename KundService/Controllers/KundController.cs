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
using KundService;

namespace KundService.Controllers
{
    public class KundController : ApiController
    {
        private KundModel db = new KundModel();

        // GET: api/Kunds
        public IQueryable<Kund> GetKund()
        {
            return db.Kund;
        }

        // GET: api/Kunds/5
        [ResponseType(typeof(Kund))]
        public IHttpActionResult GetKund(int id)
        {
            Kund kund = db.Kund.Find(id);
            if (kund == null)
            {
                return NotFound();
            }

            return Ok(kund);
        }

        // PUT: api/Kunds/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKund(int id, Kund kund)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != kund.Id)
            {
                return BadRequest();
            }

            db.Entry(kund).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KundExists(id))
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

        // POST: api/Kunds
        [ResponseType(typeof(Kund))]
        public IHttpActionResult PostKund(Kund kund)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Kund.Add(kund);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = kund.Id }, kund);
        }

        // DELETE: api/Kunds/5
        [ResponseType(typeof(Kund))]
        public IHttpActionResult DeleteKund(int id)
        {
            Kund kund = db.Kund.Find(id);
            if (kund == null)
            {
                return NotFound();
            }

            db.Kund.Remove(kund);
            db.SaveChanges();

            return Ok(kund);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KundExists(int id)
        {
            return db.Kund.Count(e => e.Id == id) > 0;
        }
    }
}