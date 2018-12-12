using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using HC.WebApi;

namespace HC.WebApi.Controllers
{
    public class ProvinciasController : ApiController
    {
        private HistoriaClinicaEntities db = new HistoriaClinicaEntities();

        // GET: api/Provincias
        public IQueryable<provincia> Getprovincias()
        {
            return db.provincias;
        }

        // GET: api/Provincias/5
        [ResponseType(typeof(provincia))]
        public async Task<IHttpActionResult> Getprovincia(int id)
        {
            provincia provincia = await db.provincias.FindAsync(id);
            if (provincia == null)
            {
                return NotFound();
            }

            return Ok(provincia);
        }

        // PUT: api/Provincias/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putprovincia(int id, provincia provincia)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != provincia.Persona_id)
            {
                return BadRequest();
            }

            db.Entry(provincia).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!provinciaExists(id))
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

        // POST: api/Provincias
        [ResponseType(typeof(provincia))]
        public async Task<IHttpActionResult> Postprovincia(provincia provincia)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.provincias.Add(provincia);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = provincia.Persona_id }, provincia);
        }

        // DELETE: api/Provincias/5
        [ResponseType(typeof(provincia))]
        public async Task<IHttpActionResult> Deleteprovincia(int id)
        {
            provincia provincia = await db.provincias.FindAsync(id);
            if (provincia == null)
            {
                return NotFound();
            }

            db.provincias.Remove(provincia);
            await db.SaveChangesAsync();

            return Ok(provincia);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool provinciaExists(int id)
        {
            return db.provincias.Count(e => e.Persona_id == id) > 0;
        }
    }
}