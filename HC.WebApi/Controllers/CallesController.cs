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
    public class CallesController : ApiController
    {
        private HistoriaClinicaEntities db = new HistoriaClinicaEntities();

        // GET: api/Calles
        public IQueryable<calle> Getcalles()
        {
            return db.calles;
        }

        // GET: api/Calles/5
        [ResponseType(typeof(calle))]
        public async Task<IHttpActionResult> Getcalle(int id)
        {
            calle calle = await db.calles.FindAsync(id);
            if (calle == null)
            {
                return NotFound();
            }

            return Ok(calle);
        }

        // PUT: api/Calles/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putcalle(int id, calle calle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != calle.Persona_id)
            {
                return BadRequest();
            }

            db.Entry(calle).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!calleExists(id))
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

        // POST: api/Calles
        [ResponseType(typeof(calle))]
        public async Task<IHttpActionResult> Postcalle(calle calle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.calles.Add(calle);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = calle.Persona_id }, calle);
        }

        // DELETE: api/Calles/5
        [ResponseType(typeof(calle))]
        public async Task<IHttpActionResult> Deletecalle(int id)
        {
            calle calle = await db.calles.FindAsync(id);
            if (calle == null)
            {
                return NotFound();
            }

            db.calles.Remove(calle);
            await db.SaveChangesAsync();

            return Ok(calle);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool calleExists(int id)
        {
            return db.calles.Count(e => e.Persona_id == id) > 0;
        }
    }
}